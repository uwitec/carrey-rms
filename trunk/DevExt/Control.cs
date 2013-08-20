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


namespace DevExt
{
    public class Control
    {
        /// <summary>
        /// 继电器控制
        /// </summary>
        /// <param name="PORT_NAME">端口</param>
        /// <param name="Address">地址</param>
        /// <param name="Line">线路</param>
        /// <param name="type">类型</param>
        public static void Relay(string PORT_NAME, short Address, int Line, RelayType type)
        {
            DevExt.Relay.Switch(PORT_NAME, Address, Line, type);
        }
        /// <summary>
        /// 打开所有继电器
        /// </summary>
        /// <param name="PORT_NAME">端口</param>
        /// <param name="Address">地址</param>
        public static void RelayAllOn(string PORT_NAME, short Address)
        {
            DevExt.Relay.Switch(PORT_NAME, Address, 0xFFFF, RelayType.BYTECTRL);
        }
        /// <summary>
        /// 关闭所有继电器
        /// </summary>
        /// <param name="PORT_NAME">端口</param>
        /// <param name="Address">地址</param>
        public static void RelayAllOff(string PORT_NAME, short Address)
        {
            DevExt.Relay.Switch(PORT_NAME, Address, 0x0000, RelayType.BYTECTRL);
        }
        /// <summary>
        /// 打开钱箱
        /// </summary>
        public static void CashDrawerOpen()
        {
            DevExt.CashDrawer.Open();
        }
        /// <summary>
        /// 在客显上显示数据
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        public static void PoleDisplay(DevExt.PoleDisplayType type,string text)
        {
            DevExt.PoleDisplayer.Display(text, type);
        }
        /// <summary>
        /// 枚举串口
        /// </summary>
        /// <returns>串口列表</returns>
        public static string[] GetSerialPorts()
        {
           return System.IO.Ports.SerialPort.GetPortNames();
        }
    }
}
