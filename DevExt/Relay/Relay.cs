#region License
//
//****************************************************************************
// *
// * Copyright (c) Caesar LAB. All Rights Reserved.
// *
// * This software is the confidential and proprietary information of Caesar LAB ("Confidential Information").  
// * You shall not disclose such Confidential Information and shall use it only in
// * accordance with the terms of the license agreement you entered into with Caesar LAB.
// *
// * CAESAR LAB MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY OF THE
// * SOFTWARE, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// * IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// * PURPOSE, OR NON-INFRINGEMENT. CRELAB SHALL NOT BE LIABLE FOR ANY DAMAGES
// * SUFFERED BY LICENSEE AS A RESULT OF USING, MODIFYING OR DISTRIBUTING
// * THIS SOFTWARE OR ITS DERIVATIVES.
// *
// * Original Author: Caesar LAB
// * Last checked in by $Author$
// * $Id$
// */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;

namespace DevExt
{
    //class RelayEventArgs : EventArgs   //继电器信息
    //{

    //    private StringBuilder relayInfo;

    //    public RelayEventArgs(StringBuilder RelayInfo)

    //        : base()
    //    {

    //        this.relayInfo = RelayInfo;

    //    }

    //    public StringBuilder RelayInfo
    //    {

    //        get { return relayInfo; }

    //    }

    //}

    //public delegate void RelayDataReceivedEventHandler();

    public enum RelayType : uint
    {
        /// <summary>
        /// 开
        /// </summary>
        ON =0x12,
        /// <summary>
        /// 关
        /// </summary>
        OFF =0x11,
        /// <summary>
        /// 位控制
        /// </summary>
        BYTECTRL=0x13,
        /// <summary>
        /// 查询
        /// </summary>
        INQUIRE=0x10
    }
    /// <summary>
    /// 
    /// </summary>
    public class Relay
    {
        private static string PORT_NAME = "COM1";
        private static short Address;
        private static int Line;
        private static RelayType type;

        private static SerialPort serialPort = null;        
        private const int BAUD_RATE = 9600;

        private const int ReadTimeout = 50;
        private const int WriteTimeout = 50;

        static byte[] commandClear = new byte[] { 0x0C };
        //static byte[] commandInitialize = new byte[] { 0x1B, 0x40 };
        //static byte[] commandLight = new byte[] { 0x1B, 0x73 };

        public static StringBuilder RelayInfo;

        /// <summary>
        /// 在客显上显示金额
        /// </summary>
        /// <param name="_text">数值</param>
        /// <param name="_type">显示类型</param>
        public static void Switch(string _PORT_NAME, short _Address, int _Line, RelayType _type)
        {
            PORT_NAME = _PORT_NAME;
            Address = _Address;
            Line = _Line;
            type = _type;

            Thread thread = new Thread(new ThreadStart(Switch));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        //DataReceived事件委托方法
        private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(120);
            int DataLength = serialPort.BytesToRead;
            int i = 0;
            StringBuilder sb = new StringBuilder();
            while (i < DataLength)
            {
                byte[] ds = new byte[1024];
                int len = serialPort.Read(ds, 0, 1024);
                sb.Append(Encoding.ASCII.GetString(ds, 0, len));
                i += len;
            }
            RelayInfo = sb;
            //此处触发事件交给EXE处理
            //DateChanged(sb);

            //}
            //try
            //{
            //    StringBuilder currentline = new StringBuilder();
            //    //循环接收数据
            //    while (serialPort.BytesToRead > 0)
            //    {
            //        char ch = (char)serialPort.ReadByte();
            //        currentline.Append(ch);
            //    }
            //    //在这里对接收到的数据进行处理
            //    //
            //    currentline = new StringBuilder();
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine(ex.Message.ToString());
            //}

            //Thread.Sleep(300);
            //if (_serialPort.IsOpen)
            //{
            //    //StatusChanged("正在获取数据... ...");                
            //    int bytes = _serialPort.BytesToRead;
            //    byte[] buffer = new byte[bytes];
            //    _serialPort.Read(buffer, 0, bytes);
            //    DataReceived(buffer);
            //    buffer = null;
            //    allDone.Set();
            //    //StatusChanged("获取数据成功... ...");            
            //}
        }

        private static void Switch()
        {
            try
            {
                if (serialPort == null)
                {
                    serialPort = new SerialPort(PORT_NAME, BAUD_RATE, Parity.None, 8);
                    serialPort.ReceivedBytesThreshold = 4;
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);//DataReceived事件委托
                    //读写时间超时            
                    serialPort.ReadTimeout = ReadTimeout;
                    serialPort.WriteTimeout = WriteTimeout;
                    serialPort.Open();
                }

                if (serialPort.IsOpen)
                {
                    byte[] command =new byte[8];
                    command[0]=0x55;
                    command[1]=(byte)(Address%256);
                    command[2]=(byte)type;
                    command[3]=0;
                    command[4]=0;
                    command[5] =(byte)(Line>>8);
                    command[6] =(byte)Line;
                    int sum=0;
                    for(int i=0;i<=6;i++)
                    {
                        sum=sum+command[i];
                    }
                    command[7]=(byte)(sum%256);
                    serialPort.Write(command,0,8);
                }
            }
            catch
            {
            }
        }
    }
}
