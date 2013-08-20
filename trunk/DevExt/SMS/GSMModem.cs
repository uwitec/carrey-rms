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

        private const string CSCACode = "00";  //��ָ���������ĺ��룬����CSCA����
        private const string FO = "11";//FOȡֵ
        private const string TPMR = "00"; //TP-MRȡֵ
        private const string MBLenth = "0D";//�ֻ����볤��Ϊ13λ
        private const string TAddress = "91";//Ŀ������ַ���ͣ�����
        private const string QH = "68";//�й��Ĺ�������
        private const string PID = "00"; //IPЭ���
        private const string CodeMode = "08";//����ģʽ 08ΪUnicode��00ΪBit7���룬15ΪBit8����
        private const string Msg_Time = "01";//���ű�����Ч��

        public GSMModem()//��ʼ����������ʵ��
        {
        }

        /// <summary>
        ///  ��ʼ����������ʵ��,���Ҵ򿪴���,ע�⣺����ReceivedBytesThreshold = 5;
        /// </summary>
        public GSMModem(string PortName, int PortNum)
        {
            sp = new SerialPort(PortName, PortNum, Parity.None, 8);
            sp.ReceivedBytesThreshold = 5;                          
            sp.Handshake = Handshake.RequestToSend;
            sp.Parity = Parity.None;
            sp.ReadTimeout = 200;
            sp.WriteTimeout = 200;
            sp.RtsEnable = true;        //����Ϊtrue �������ڲ��ܽ��յ�����

            sp.Open();       
        }

        //------------------------���ڲ������ֿ�ʼ-------------------------

        public string SetMsgCenter(string CenterNum)//���ö������ĺ���
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
                return "ʧ�ܣ�";
            }
        }

        /// <summary>
        /// //ͨ���������ķ��Ͷ��ŵ��û��ֻ���3�������ǣ��ֻ����롢�������ĺ��롢��������,���Ǳ���֯��һ������
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
                return "����ʧ�ܣ�";
            }
        }

        /// <summary>
        /// //ͨ���������ķ��Ͷ��ŵ��û��ֻ��������ǣ��ֻ����롢��������,���Ǳ���֯��һ������
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
                return "����ʧ�ܣ�";
            }
        }

        //------------����PDU��Լ��Ϣ��Ԫ����----------------
        /// <summary>
        /// //����PDU��������2���������ֻ����롢�ֻ��������ݣ����ɣ��˺�����SendToCom�������ã��û����ص��ã���Ϊprivate
        /// </summary>
        private void SendPdu(string mobile, string message)   
        {
            string PduData = "";
            string CMGS_Lenth = "";
            CMGS_Lenth = (message.Length * 2 + 15).ToString().Trim();  //���Ͷ���Ϣʮ���Ƴ������Լ���ݳ��Ⱥ�,ȫ���������ķ�
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
            sp.Write(((char)26).ToString() + "\r");//һ��Ҫ�ֿ���

        }
        /// <summary>
        /// //���ṩ�Ĳ������ֻ����롢�������ݣ���װ��USC2��ʽ��PDU��,�˺�����SendPdu�������ã��û����ص��ã���Ϊprivate
        /// </summary>
        private string PduStr(string moible, string content)   
        {
            string MBCode = smsDecodedNumber(moible);
            string Msg_Data = smsPDUEncoded(content);
            return "00" + "11" + "00" + "0D" + "91" + MBCode + "00" + "08" + "01" + Msg_Data;
        }


        /// <summary>
        /// �� AT+CMGR= msgIndex �����������ΪmsgIndex��δ�����ţ� Ȼ�������ͨ�׵Ķ�����Ϣ,����string����
        /// </summary>
        public string ReadMsg(string msgIndex)
        {
            try
            {
                sp.Write("AT+CMGR =" +msgIndex +"\r");     // ������������δ������
                Thread.Sleep(1000);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);
                string str = Encoding.ASCII.GetString(buffer);
                if (str.Contains("OK"))
                {
                    int index1 = str.IndexOf("\r\n");
                    int index2 = str.IndexOf("\r\n", index1 + 2);
                    int index3 = str.IndexOf("\r\n", index2 + 2);

                    string pdu = str.Substring(index2 + 2, index3 - index2 - 2);  //�����˹������õ�PDU��

                    if (pdu.Substring(40, 2) == "08")
                    {
                        //return "���ݣ�" + GetTextFromPdu_UCS2(pdu) + "---�����ߣ�" + GetTeleFromPdu(pdu) + "---����ʱ�䣺" + GetTimeFromPdu(pdu);
                        //�绰+ʱ��+����
                        return GetTeleFromPdu(pdu)+","+GetTimeFromPdu(pdu)+","+GetTextFromPdu_UCS2(pdu);
                    }
                    else if (pdu.Substring(40, 2) == "00")
                    {
                        return "���ݣ�" + GetTextFromPdu_7Bit(pdu);
                    }
                    else
                    {
                        return  "��ǰλ��û�ж������ݣ�";
                    }
                }
                else
                {
                    return  "��ȡ���Ŵ���";
                }
            }
            catch
            {
                return "��ȡ��Ϣʧ�ܣ�";
            }
        }

        /// <summary>
        ///  //�Ӵ��ڻ����������ֽڣ�����ת��Ϊstring����
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
                return "��ȡ��Ϣʧ��";
            }
        }

        public void CloseCom()//�رմ���
        {
            sp.Dispose();
            sp.Close();
        }

        //------------------------���ڲ������ֽ���-------------------------

        //--------------------------���ű��벿��-------------------------

        /// <summary>
        /// �������ܣ��������ݱ���
        /// �������ƣ�smsPDUEncoded(string srvContent)
        /// ��    ����srvContent Ҫ����ת���Ķ�������,string����
        /// �� �� ֵ�������Ķ������ݣ�string����
        /// ����˵����
        ///          1������Big-Endian �ֽ�˳��� Unicode ��ʽ���룬Ҳ��˵�Ѹߵ�λ�Ļ��������������
        ///          2����ת����Ķ������ݴ���ֽ�����
        ///          3��ȥ���ڽ���Unicode��ʽ�����У������ֽ��е�"-",���磺00-21�����0021
        ///          4���������������ݵĳ��ȳ�2��������λ16������
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
        /// �������ܣ����ն����ֻ��ű���
        /// �������ƣ�smsDecodedNumber(string srvNumber)
        /// ��    ����srvCenterNumber Ҫ����ת���Ķ������ĺ�,string����
        /// �� �� ֵ�������Ľ��ն����ֻ��ţ�string����
        /// ����˵����
        ///          1����鵱ǰ�����ֻ����Ƿ񰴱�׼��ʽ��д�����ǣ��Ͳ��ϡ�86��
        ///          1��������λ��ż��λ������
        ///          2���������ĺ���ż�������󣬿��������Ƿ�Ϊż����������ǣ�������F
        /// </summary>
        private  string smsDecodedNumber(string srvNumber)
        {
            string s = null;
            if (!(srvNumber.Substring(0, 2) == "86"))
            {
                srvNumber = String.Format("86{0}", srvNumber);     //��鵱ǰ�����ֻ����Ƿ񰴱�׼��ʽ��д�����ǣ��Ͳ��ϡ�86��
            }
            int nLength = srvNumber.Length;
            for (int i = 1; i < nLength; i += 2)                 //������λ��ż��λ����
            {
                s += srvNumber[i];
                s += srvNumber[i - 1];
            }
            if (!(nLength % 2 == 0))                              //�Ƿ�Ϊż�������Ǿͼ���F���������һλ����ϵ�Fλ����
            {
                s += 'F';
                s += srvNumber[nLength - 1];
            }
            return s;
        }
        //--------------------------���ű��벿�ֽ���-------------------------


        //--------------------------���Ž��벿�ֿ�ʼ-------------------------

        private string GetTextFromPdu_7Bit(string pdu) //�����������ĺ���_7-Bit����
        {
            string TextInPdu = pdu.Substring(58);//��ȡPDU���ж������Ĳ���Դ��
            string Text = "";
            while (TextInPdu.Length % 14 != 0) //���һ�鲻��7����Աʱ��"0"
                TextInPdu += "0";
            char[] a = TextInPdu.ToCharArray(); //��Դ������ַ����� a[]
            string b = "";
            for (int i = 0; i < a.Length; i++) //��Դ��תΪ�����Ʋ������ַ��� b
                b += GetBinary(a[i]);
            char[] total = b.ToCharArray(); //��������������ַ����� total[]
            for (int j = 0; j < total.Length; j += 56) //56λ��������Ϊһ��,ѭ��������  
            {
                char[] s = new char[56];
                for (int i = 0; i < 56; i++)  //��һ��������뿽�����ַ����� s[]
                    s[i] = total[i + j];
                char[] d = new char[56];
                //-------------------------------------------------------------------------------------
                for (int i = 0; i < 7; i++) //���ڽ���õ�Ŀ������������� d[]
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
                for (int k = 0; k < 56; k += 7) //����ѭ���õ�Ŀ�� ASCII �ַ�        
                {
                    int ascii_nu = 0;
                    for (int m = 0; m < 7; m++)
                        ascii_nu += Convert.ToInt16(d[k + m].ToString()) * (1 << (6 - m));
                    Text += (char)ascii_nu; //��� ASCII ����Ӧ�ַ�
                }
            }  // END OF loop j
            return Text;
        }

        //=====================================================================================
        private  string GetBinary(char Hex) //16 ����ת 2 ����
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
        private string GetTextFromPdu_UCS2(string pdu) //�����������ĺ���_UCS2����
        {
            //��ȡPDU���ж������Ĳ���Դ��,����Ҳ����BitConverter����ʵ�ֲ���ת��
            string TextInPdu = pdu.Substring(58);
            string Text = "";
            char[] d = TextInPdu.ToCharArray();//�����ַ�����
            for (int i = 0; i < d.Length; i += 4)
            {
                int unicode_nu = 0;
                for (int m = 0; m < 4; m++) //���� Unicode ʮ����ֵ
                    unicode_nu += HexToDec(d[i + m]) * (1 << ((3 - m) * 4));
                Text += (char)unicode_nu; //��� Unicode ��Ӧ�ַ�
            }
            return Text;//���ض�����������
        }
        //=====================================================================================
        private int HexToDec(char Hex) //16 ����ת 10 ����
        {
            int Dec;
            if (Hex >= '0' && Hex <= '9')
                Dec = Convert.ToInt16(Hex - '0'); //0-9
            else
                Dec = Convert.ToInt16(Hex - 'A') + 10;// A-F
            return Dec;//���� 10 ����ֵ
        }

        //=====================================================================================
        private string GetTeleFromPdu(string pdu) //���� TeleNumber ����
        {
            //��ȡPDU���ж��ŷ��ͷ��绰����Դ��
            string TeleInPdu = pdu.Substring(26, 12);
            string Tele = "";
            char[] d = TeleInPdu.ToCharArray();//�����ַ�����
            for (int i = 0; i < d.Length; i += 2)//�ַ������Ե�
            {
                Tele += d[i + 1].ToString();
                Tele += d[i].ToString();
            }
            Tele = Tele.Substring(0, 11);//ȥ��ĩλ"F"
            return Tele;//���ط��ͷ��绰����
        }

        //=====================================================================================
        private string GetTimeFromPdu(string pdu) //���� DateTime ����
        {
            //��ȡPDU���ж�������ʱ��Դ��
            string TimeInPdu = pdu.Substring(42, 14);
            string Time = "";
            char[] d = TimeInPdu.ToCharArray();//�����ַ�����
            for (int i = 0; i < d.Length; i += 2)//�ַ������Ե�
            {
                Time += d[i + 1].ToString();
                Time += d[i].ToString();
            }
            Time = "20" + Time; //�����ǰ�� 20 �γ� 4 λ��ʽ,����Ϊ����ʱ�������ʽ����
            Time = Time.Substring(0, 4) + "-" + Time.Substring(4, 2) + "-"
                + Time.Substring(6, 2) + " " + Time.Substring(8, 2) + ":"
                + Time.Substring(10, 2) + ":" + Time.Substring(12, 2);
            return Time; //���ض�������ʱ��[��-��-�� ʱ:��:��]
        }
        //--------------------------���Ž��벿�ֽ���-------------------------


        public string ATCommand(string ATCmd)//����ATָ��
        {
            try
            {
                if (ATCmd.Substring(0, 2).ToLower() != "at")
                {
                    return "ʧ�ܣ�";
                }
                sp.Write(ATCmd + "\r");
                Thread.Sleep(500);
                byte[] buffer = new byte[sp.BytesToRead];
                sp.Read(buffer, 0, buffer.Length);

                return System.Text.Encoding.ASCII.GetString(buffer);
            }
            catch
            {
                return "ʧ�ܣ�";
            }
        }


        //--------------------------�¼����ֿ�ʼ���ⲿ�ִ�����ʱ���ã������Ұ�����ע�͵�--------------------

        //private void sp_DataReceived(Object sender, SerialDataReceivedEventArgs e)//�����¼�
        //{
        //    System.Windows.Forms.MessageBox.Show(sp.ReadExisting());
        //}

        //private void sp_ErrorReceived(Object sender, SerialErrorReceivedEventArgs e)//�����¼�
        //{
        //}
        //--------------------------�¼����ֽ���--------------------

    }

}


