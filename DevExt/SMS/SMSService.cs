using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO.Ports;
using Microsoft.Win32;
using System.Threading;
using GSMModem;

namespace Caesar.SMSCenter
{
    using Caesar.DbUtilities;
    using Caesar.SMSCenter.Model;
    using Caesar.SMSCenter.Business;

    public class SMSService : System.MarshalByRefObject, ISMSService
    {
        private GSMModem.GSMModem sp = null;
        private Timer tm =null;

        private IDbHelper SMSDBHelper;
        //List<GSMModem.GSMModem> Modems=new List<GSMModem.GSMModem>();
        protected bool isConnect=false;

        public bool ISCONNECT
        {
            get
            {
                return isConnect;
            }

            set
            {
                isConnect = value;
            }
        }

        public bool IsConnect()
        {
            return ISCONNECT;
        }

        public SMSService()
        {
            
        }

        /// <summary>
        /// //接收短信的方法，供串口sp的SerialDataReceivedEventHandler事件调用
        /// 参数：object sender,SerialDataReceivedEventArgs e：是SerialDataReceivedEventHandler事件调用的委托方法所要求的参数类型
        /// 
        /// 注意：这个函数由串口（收到数据后）引发的SerialDataReceivedEventHandler事件自动调用（用户不必调用），所以属性为private
        ///       由于SerialDataReceivedEventHandler事件是由串口（收到数据后）引发的，所以,短信接收是自动执行的的
        /// </summary>

        private void ReceiveMessage(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveManager receiveManager = new ReceiveManager(this.SMSDBHelper);
            ReceiveEntity re = new ReceiveEntity();

            string ReceiveValue = string.Empty;
            try
            {
                SMSDBHelper.Open();
                Thread.Sleep(1000);
                string str = sp.ReadCom();   // 先从串口缓存中读出字节内容并转化为string类型
                Thread.Sleep(2000);
                str = str.Replace("\r\n", "").Replace(" ", "");
                if (str.Length > 6)                       // 只有当string长度大于6时，才认为可能是收到了用户短信？？
                {
                    if (str.Substring(0, 5) == "+CMTI")
                    {
                        //MessageBox.Show("收到一条短信！");
                        int index = str.IndexOf(",");
                        string location = str.Substring(index + 1);
                        ReceiveValue = sp.ReadMsg(location);                   // 用ReadMsg解析出具体的短信内容
                        //MessageBox.Show(value, "有新短信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        re.Phone = ReceiveValue.Split(',')[0];
                        re.ReceiveTime = DateTime.Parse(ReceiveValue.Split(',')[1]);
                        re.Txt = ReceiveValue.Split(',')[2];
                        receiveManager.Add(re);
                        //读完删除
                        DelMSG(location);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                SMSDBHelper.Close();
            }
        }

        /// <summary>
        /// 枚举系统中所有串口
        /// </summary>
        public string GetCOMPorts()
        {
            string COMPorts = string.Empty;

            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                foreach (string sName in sSubKeys)
                {
                    COMPorts += (string)keyCom.GetValue(sName) + ",";
                }
            }
            return COMPorts;
        }

        /// <summary>
        /// 连接执行后，串口初始化,并且开始接受中断事件！若有数据到达串口，将触发SerialDataReceivedEventHandler事件（调用ReceiveMessage方法）接收短信
        /// </summary>
        /// Timer构造函数参数说明：
        //Callback：一个 TimerCallback 委托，表示要执行的方法。
        //State：一个包含回调方法要使用的信息的对象，或者为空引用（Visual Basic 中为 Nothing）。
        //dueTime：调用 callback 之前延迟的时间量（以毫秒为单位）。指定 Timeout.Infinite 以防止计时器开始计时。指定零 (0) 以立即启动计时器。
        //Period：调用 callback 的时间间隔（以毫秒为单位）。指定 Timeout.Infinite 可以禁用定期终止。

        public bool Connect(IDbHelper DbHelper,string Port, int PortNum)
        {
            SMSDBHelper = DbHelper;

            sp = new GSMModem.GSMModem(Port, PortNum);  //串口初始化
            if (sp.sp.IsOpen)
            {
                sp.sp.DataReceived += new SerialDataReceivedEventHandler(ReceiveMessage); //
                ISCONNECT = true;
            }
            return sp.sp.IsOpen;
            //GSMModem.GSMModem sp = new GSMModem.GSMModem(Port, PortNum);
            //if (sp.sp.IsOpen)
            //{
            //    sp.sp.DataReceived += new SerialDataReceivedEventHandler(ReceiveMessage); //
            //    Modems.Add(sp);
            //}
            //return sp.sp.IsOpen;
        }
        public void Close()
        {
            //if (Modems.Exists(delegate(GSMModem.GSMModem sp) { return sp.sp.PortName == Port;}))
            //{
            //    Modems.Find(delegate(GSMModem.GSMModem sp) { return sp.sp.PortName == Port; }).CloseCom();
            //}
            sp.CloseCom();
            ISCONNECT = false;
        }

        public string ATCmd(string Command)
        {
            return sp.ATCommand(Command);
        }

        /// <summary>
        /// 短信中心号码
        /// </summary>
        public string CenterNO
        {
            get
            {
                return sp.ATCommand("AT+CSCA?");
            }

            set
            {
                sp.ATCommand("AT+CSCA=" +value + ";&W");
            }
        }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string SIM()
        {
            return sp.ATCommand("AT+CCID");
        }
        /// <summary>
        /// 测试
        /// </summary>
        public string Test()
        {
            return sp.ATCommand("AT+CSQ");
        }
        /// <summary>
        /// 发送短信
        /// </summary>
        public string SendMSG(string Mobile,string Content)
        {
            return sp.SendToCom(Mobile,Content);
        }

        /// <summary>
        /// 从数据库发送短信
        /// </summary>
        private void SendDBMSG(object state)
        {
            SendManager iss = new SendManager(this.SMSDBHelper);
            SendEntity se = new SendEntity();
            this.SMSDBHelper.Open();
            se=iss.GetEntity("0");
            sp.SendToCom(se.Phone,se.Txt);
            se.Sent = "1";
            iss.Update(se);
            this.SMSDBHelper.Close();
        }
        /// <summary>
        /// 从数据库发送短信-开始
        /// </summary>
        public void StartSend()
        {
            tm = new Timer(new TimerCallback(SendDBMSG), null, 2000, 18000);
        }
        /// <summary>
        /// 从数据库发送短信-停止
        /// </summary>
        public void StopSend()
        {
            tm.Dispose();
            tm = null;
        }
        /// <summary>
        /// 读取短信
        /// </summary>
        private string ReadMSG(string Index)
        {
            return sp.ReadMsg(Index);
        }
        /// <summary>
        /// 删除短信
        /// </summary>
        private string DelMSG(string Index)
        {
            return sp.ATCommand("AT+CMGD=" + Index);
        }
    }
}
