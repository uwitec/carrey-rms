using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace GSMModem
{
    public class GSMModem
    {
        public SerialPort sp = new SerialPort();

        private const string CSCACode = "00";  //无指定短信中心号码，按照CSCA号码
        private const string FO = "11";//FO取值
        private const string TPMR = "00"; //TP-MR取值
        private const string MBLenth = "0D";//手机号码长度为13位
        private const string TAddress = "91";//目标号码地址类型，国际
        private const string QH = "68";//中国的国际区号
        private const string PID = "00"; //IP协议号
        private const string CodeMode = "08";//编码模式 08为Unicode，00为Bit7编码，15为Bit8编码
        private const string Msg_Time = "01";//短信保留有效期

        public GSMModem()//初始化建串口类实例
        {
        }

        /// <summary>
        ///  初始化建串口类实例,并且打开串口,注意：属性ReceivedBytesThreshold = 5;
        /// </summary>
        public GSMModem(string PortName, int PortNum)
        {
            sp = new SerialPort(PortName, PortNum, Parity.None, 8);
            sp.ReceivedBytesThreshold = 5;                          
            sp.Handshake = Handshake.RequestToSend;
            sp.Parity = Parity.None;
            sp.ReadTimeout = 200;
            sp.WriteTimeout = 200;
            sp.RtsEnable = true;        //必须为true 这样串口才能接收到数据

            sp.Open();       
        }

        //------------------------串口操作部分开始-------------------------

        public string SetMsgCenter(string CenterNum)//设置短信中心号码
        {
            try
            {
                sp.Write("AT+CSCA=+86" + CenterNum + ";&W"+"\r");
                Thread.Sleep(500);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);
                return System.Text.Encoding.ASCII.GetString(buffer);
            }
            catch
            {
                return "失败！";
            }
        }

        /// <summary>
        /// //通过短信中心发送短信到用户手机，3个参数是：手机号码、短信中心号码、具体内容,它们被组织成一条短信
        /// </summary>
        public string SendToCom(string mobile,string CenterNum,string msgTxt)  
        {
            try
            {
                sp.Write("AT+CSCA=+86" + CenterNum + ";&W" + "\r");
                Thread.Sleep(200);
                sp.Write("AT+CMGF=0" + "\r");
                Thread.Sleep(200);
                SendPdu(mobile,msgTxt);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);
                return System.Text.Encoding.ASCII.GetString(buffer);
            }
            catch
            {
                return "发送失败！";
            }
        }

        /// <summary>
        /// //通过短信中心发送短信到用户手机，参数是：手机号码、具体内容,它们被组织成一条短信
        /// </summary>
        public string SendToCom(string mobile, string msgTxt)
        {
            try
            {
                sp.Write("AT+CMGF=0" + "\r");
                Thread.Sleep(200);
                SendPdu(mobile, msgTxt);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);
                return System.Text.Encoding.ASCII.GetString(buffer);
            }
            catch
            {
                return "发送失败！";
            }
        }

        //------------发送PDU规约信息单元数据----------------
        /// <summary>
        /// //发送PDU串，它由2个参数（手机号码、手机具体内容）构成，此函数由SendToCom函数调用，用户不必调用，故为private
        /// </summary>
        private void SendPdu(string mobile, string message)   
        {
            string PduData = "";
            string CMGS_Lenth = "";
            CMGS_Lenth = (message.Length * 2 + 15).ToString().Trim();  //发送短信息十进制长度与规约数据长度和,全部按照中文发
            if (CMGS_Lenth.Length == 2)
            {
                CMGS_Lenth = "0" + CMGS_Lenth;
            }
            PduData = "AT+CMGS=" + CMGS_Lenth;
            sp.Write(PduData + "\r");
            Thread.Sleep(200);
            PduData = PduStr(mobile, message);
            sp.Write(PduData);
            Thread.Sleep(200);
            sp.Write(((char)26).ToString() + "\r");//一定要分开发

        }
        /// <summary>
        /// //将提供的参数（手机号码、具体内容）组装成USC2格式的PDU串,此函数由SendPdu函数调用，用户不必调用，故为private
        /// </summary>
        private string PduStr(string moible, string content)   
        {
            string MBCode = smsDecodedNumber(moible);
            string Msg_Data = smsPDUEncoded(content);
            return "00" + "11" + "00" + "0D" + "91" + MBCode + "00" + "08" + "01" + Msg_Data;
        }


        /// <summary>
        /// 用 AT+CMGR= msgIndex 命令读出索引为msgIndex的未读短信， 然后解析成通俗的短信信息,返回string类型
        /// </summary>
        public string ReadMsg(string msgIndex)
        {
            try
            {
                sp.Write("AT+CMGR =" +msgIndex +"\r");     // 按照索引读出未读短信
                Thread.Sleep(1000);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);
                string str = Encoding.ASCII.GetString(buffer);
                if (str.Contains("OK"))
                {
                    int index1 = str.IndexOf("\r\n");
                    int index2 = str.IndexOf("\r\n", index1 + 2);
                    int index3 = str.IndexOf("\r\n", index2 + 2);

                    string pdu = str.Substring(index2 + 2, index3 - index2 - 2);  //生成了供解析用的PDU码

                    if (pdu.Substring(40, 2) == "08")
                    {
                        //return "内容：" + GetTextFromPdu_UCS2(pdu) + "---发送者：" + GetTeleFromPdu(pdu) + "---接收时间：" + GetTimeFromPdu(pdu);
                        //电话+时间+内容
                        return GetTeleFromPdu(pdu)+","+GetTimeFromPdu(pdu)+","+GetTextFromPdu_UCS2(pdu);
                    }
                    else if (pdu.Substring(40, 2) == "00")
                    {
                        return "内容：" + GetTextFromPdu_7Bit(pdu);
                    }
                    else
                    {
                        return  "当前位置没有短信内容！";
                    }
                }
                else
                {
                    return  "读取短信错误！";
                }
            }
            catch
            {
                return "读取信息失败！";
            }
        }

        /// <summary>
        ///  //从串口缓冲区读出字节，并且转化为string类型
        /// </summary>
        public string ReadCom()    
        {
            try
            {
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);
                return System.Text.Encoding.ASCII.GetString(buffer);
            }
            catch
            {
                return "读取信息失败";
            }
        }

        public void CloseCom()//关闭串口
        {
            sp.Dispose();
            sp.Close();
        }

        //------------------------串口操作部分结束-------------------------

        //--------------------------短信编码部分-------------------------

        /// <summary>
        /// 函数功能：短信内容编码
        /// 函数名称：smsPDUEncoded(string srvContent)
        /// 参    数：srvContent 要进行转换的短信内容,string类型
        /// 返 回 值：编码后的短信内容，string类型
        /// 函数说明：
        ///          1，采用Big-Endian 字节顺序的 Unicode 格式编码，也就说把高低位的互换在这里完成了
        ///          2，将转换后的短信内容存进字节数组
        ///          3，去掉在进行Unicode格式编码中，两个字节中的"-",例如：00-21，变成0021
        ///          4，将整条短信内容的长度除2，保留两位16进制数
        /// </summary>
        private  string smsPDUEncoded(string srvContent)
        {
            Encoding encodingUTF = System.Text.Encoding.BigEndianUnicode;
            string s = null;
            byte[] encodedBytes = encodingUTF.GetBytes(srvContent);
            for (int i = 0; i < encodedBytes.Length; i++)
            {
                s += BitConverter.ToString(encodedBytes, i, 1);
            }
            s = String.Format("{0:X2}{1}", s.Length / 2, s);

            return s;
        }

        /// <summary>
        /// 函数功能：接收短信手机号编码
        /// 函数名称：smsDecodedNumber(string srvNumber)
        /// 参    数：srvCenterNumber 要进行转换的短信中心号,string类型
        /// 返 回 值：编码后的接收短信手机号，string类型
        /// 函数说明：
        ///          1，检查当前接收手机号是否按标准格式书写，不是，就补上“86”
        ///          1，将奇数位和偶数位交换。
        ///          2，短信中心号奇偶数交换后，看看长度是否为偶数，如果不是，最后添加F
        /// </summary>
        private  string smsDecodedNumber(string srvNumber)
        {
            string s = null;
            if (!(srvNumber.Substring(0, 2) == "86"))
            {
                srvNumber = String.Format("86{0}", srvNumber);     //检查当前接收手机号是否按标准格式书写，不是，就补上“86”
            }
            int nLength = srvNumber.Length;
            for (int i = 1; i < nLength; i += 2)                 //将奇数位和偶数位交换
            {
                s += srvNumber[i];
                s += srvNumber[i - 1];
            }
            if (!(nLength % 2 == 0))                              //是否为偶数，不是就加上F，并对最后一位与加上的F位互换
            {
                s += 'F';
                s += srvNumber[nLength - 1];
            }
            return s;
        }
        //--------------------------短信编码部分结束-------------------------


        //--------------------------短信解码部分开始-------------------------

        private string GetTextFromPdu_7Bit(string pdu) //解析短信正文函数_7-Bit编码
        {
            string TextInPdu = pdu.Substring(58);//截取PDU串中短信正文部分源码
            string Text = "";
            while (TextInPdu.Length % 14 != 0) //最后一组不满7个成员时补"0"
                TextInPdu += "0";
            char[] a = TextInPdu.ToCharArray(); //将源码存入字符数组 a[]
            string b = "";
            for (int i = 0; i < a.Length; i++) //将源码转为二进制并存入字符串 b
                b += GetBinary(a[i]);
            char[] total = b.ToCharArray(); //将二进制码存入字符数组 total[]
            for (int j = 0; j < total.Length; j += 56) //56位二进制码为一组,循环所有组  
            {
                char[] s = new char[56];
                for (int i = 0; i < 56; i++)  //将一组二进制码拷贝到字符数组 s[]
                    s[i] = total[i + j];
                char[] d = new char[56];
                //-------------------------------------------------------------------------------------
                for (int i = 0; i < 7; i++) //组内解码得到目标二进制码数组 d[]
                    d[i] = s[i + 1];
                for (int k = 1; k <= 6; k++)
                {
                    for (int i = k * 7; i < (k + 1) * 7 - k; i++)
                        d[i] = s[i + (k * 2 + 1)];
                    for (int i = (k + 1) * 7 - k; i < (k + 1) * 7; i++)
                        d[i] = s[i - ((7 - k) * 2 + 1)];
                }
                for (int i = 49; i < 56; i++)
                    d[i] = s[i - 1];
                //-------------------------------------------------------------------------------------
                for (int k = 0; k < 56; k += 7) //组内循环得到目标 ASCII 字符        
                {
                    int ascii_nu = 0;
                    for (int m = 0; m < 7; m++)
                        ascii_nu += Convert.ToInt16(d[k + m].ToString()) * (1 << (6 - m));
                    Text += (char)ascii_nu; //输出 ASCII 码相应字符
                }
            }  // END OF loop j
            return Text;
        }

        //=====================================================================================
        private  string GetBinary(char Hex) //16 进制转 2 进制
        {
            int Dec;
            if (Hex >= '0' && Hex <= '9')
                Dec = Convert.ToInt16(Hex - '0');
            else
                Dec = Convert.ToInt16(Hex - 'A') + 10;
            int displayMask = 1 << 3;
            StringBuilder Bin = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                //append 0 or 1 depending on result of masking		
                Bin.Append((Dec & displayMask) == 0 ? "0" : "1");
                //shift left so that mask will find bit of next digit 
                //during next iteration of loop
                Dec <<= 1;
            }
            return Bin.ToString();
        }
        //=====================================================================================

        //=====================================================================================
        private string GetTextFromPdu_UCS2(string pdu) //解析短信正文函数_UCS2编码
        {
            //截取PDU串中短信正文部分源码,读者也可用BitConverter函数实现部分转换
            string TextInPdu = pdu.Substring(58);
            string Text = "";
            char[] d = TextInPdu.ToCharArray();//存入字符数组
            for (int i = 0; i < d.Length; i += 4)
            {
                int unicode_nu = 0;
                for (int m = 0; m < 4; m++) //计算 Unicode 十进制值
                    unicode_nu += HexToDec(d[i + m]) * (1 << ((3 - m) * 4));
                Text += (char)unicode_nu; //输出 Unicode 对应字符
            }
            return Text;//返回短信正文内容
        }
        //=====================================================================================
        private int HexToDec(char Hex) //16 进制转 10 进制
        {
            int Dec;
            if (Hex >= '0' && Hex <= '9')
                Dec = Convert.ToInt16(Hex - '0'); //0-9
            else
                Dec = Convert.ToInt16(Hex - 'A') + 10;// A-F
            return Dec;//返回 10 进制值
        }

        //=====================================================================================
        private string GetTeleFromPdu(string pdu) //解析 TeleNumber 函数
        {
            //截取PDU串中短信发送方电话号码源码
            string TeleInPdu = pdu.Substring(26, 12);
            string Tele = "";
            char[] d = TeleInPdu.ToCharArray();//存入字符数组
            for (int i = 0; i < d.Length; i += 2)//字符两两对调
            {
                Tele += d[i + 1].ToString();
                Tele += d[i].ToString();
            }
            Tele = Tele.Substring(0, 11);//去掉末位"F"
            return Tele;//返回发送方电话号码
        }

        //=====================================================================================
        private string GetTimeFromPdu(string pdu) //解析 DateTime 函数
        {
            //截取PDU串中短信日期时间源码
            string TimeInPdu = pdu.Substring(42, 14);
            string Time = "";
            char[] d = TimeInPdu.ToCharArray();//存入字符数组
            for (int i = 0; i < d.Length; i += 2)//字符两两对调
            {
                Time += d[i + 1].ToString();
                Time += d[i].ToString();
            }
            Time = "20" + Time; //将年份前加 20 形成 4 位格式,以下为日期时间输出格式控制
            Time = Time.Substring(0, 4) + "-" + Time.Substring(4, 2) + "-"
                + Time.Substring(6, 2) + " " + Time.Substring(8, 2) + ":"
                + Time.Substring(10, 2) + ":" + Time.Substring(12, 2);
            return Time; //返回短信日期时间[年-月-日 时:分:秒]
        }
        //--------------------------短信解码部分结束-------------------------


        public string ATCommand(string ATCmd)//发送AT指令
        {
            try
            {
                if (ATCmd.Substring(0, 2).ToLower() != "at")
                {
                    return "失败！";
                }
                sp.Write(ATCmd + "\r");
                Thread.Sleep(500);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);

                return System.Text.Encoding.ASCII.GetString(buffer);
            }
            catch
            {
                return "失败！";
            }
        }


        //--------------------------事件部分开始，这部分代码暂时无用，所以我把它们注释掉--------------------

        //private void sp_DataReceived(Object sender, SerialDataReceivedEventArgs e)//接收事件
        //{
        //    System.Windows.Forms.MessageBox.Show(sp.ReadExisting());
        //}

        //private void sp_ErrorReceived(Object sender, SerialErrorReceivedEventArgs e)//错误事件
        //{
        //}
        //--------------------------事件部分结束--------------------

    }

}


