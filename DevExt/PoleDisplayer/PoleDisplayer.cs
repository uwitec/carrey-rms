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
    public enum PoleDisplayType : uint
    {
        /// <summary>
        /// 全暗
        /// </summary>
        Dark = 0,
        /// <summary>
        /// 单价
        /// </summary>
        Price = 1,
        /// <summary>
        /// 总计
        /// </summary>
        Total = 2, 
        /// <summary>
        /// 收款
        /// </summary>
        Payment = 3, 
        /// <summary>
        /// 找零
        /// </summary>
        Change = 4
    }
    /// <summary>
    /// 
    /// </summary>
    public class PoleDisplayer
    {
        private static string text;
        private static PoleDisplayType type;
        private static SerialPort serialPort = null;

        private const string PORT_NAME = "COM1";
        private const int BAUD_RATE = 2400;

        static byte[] commandClear = new byte[] { 0x0C };
        //static byte[] commandInitialize = new byte[] { 0x1B, 0x40 };
        //static byte[] commandLight = new byte[] { 0x1B, 0x73 };

        /// <summary>
        /// 在客显上显示金额
        /// </summary>
        /// <param name="_text">数值</param>
        /// <param name="_type">显示类型</param>
        public static void Display(string _text, PoleDisplayType _type)
        {
            text = _text;
            type = _type;

            Thread thread = new Thread(new ThreadStart(Display));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private static void Display()
        {
            try
            {
                if (serialPort == null)
                {
                    serialPort = new SerialPort(PORT_NAME, BAUD_RATE, Parity.None, 8);
                    serialPort.Open();
                }

                if (serialPort.IsOpen)
                {
                    //serialPort.Write(commandInitialize, 0, commandInitialize.Length);
                    //serialPort.Write(commandLight, 0, commandLight.Length);
                    //serialPort.Write(Convert.ToInt32(type).ToString());
                    //serialPort.WriteLine(FillStr(text));

                    char esc = (char)27;

                    //serialPort.Write(esc + @"@");
                    //serialPort.Write(commandClear, 0, 1);
                    serialPort.Write(esc + @"s" + Convert.ToInt32(type).ToString());
                    serialPort.WriteLine(esc + @"  Q  A  " + text+ (char)13);
                    //serialPort.WriteLine(FillString(text));
                    //serialPort.WriteLine(text);
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 填充text,不含小数点的8位
        /// </summary>
        /// <param name="text"></param>
        private static string FillString(string text)
        {
            //string temp = text.Replace(".", string.Empty);

            for (int i = 0; i < 8 - text.Length; i++)
            {
                text += "0";
            }

            return text;
        }
    }
}