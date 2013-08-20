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
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32.SafeHandles;

using System.Diagnostics;

namespace DevExt
{
    public class CashDrawer
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        private class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;

            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;

            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true,
        CharSet = CharSet.Ansi, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)]
        private static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] 
        string szPrinter, out IntPtr hPrinter, Int32 pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true,
        ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool ClosePrinter(IntPtr hPrinter);
        
        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true,
        CharSet = CharSet.Ansi, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)]
        private static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level,
        [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true,
        ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true,
        ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true,
        ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true,
        ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32
        dwCount, out Int32 dwWritten);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr CreateFile(string lpFileName,
        int dwDesiredAccess,
        int dwShareMode,
        int lpSecurityAttributes,
        int dwCreationDisposition,
        int dwFlagsAndAttributes,
        int hTemplateFile);

        /*ESC p M n1 n2
        M =0 代表一个钱箱 n代表脉冲宽度 n1 =40--50 之间
        M =1 代表两个钱箱 n2 =120--150之间*/
        //static byte[] commandOpenDrawer = new byte[] { 0x1B, 0x70, 0x0, 0x3C, 0xFF};
        static byte[] commandOpenDrawer = new byte[] { 27, 112, 0, 50, 200 };

        public static void Open()
        {
            Thread thread = new Thread(new ThreadStart(OpenDrawerByEXE));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        #region 开钱箱
        private static void OpenDrawerByEXE()
        {
            try
            {
                //實例一個Process類，啟動一個獨立進程
                Process p = new Process();

                //Process類有一個StartInfo屬性，這個是ProcessStartInfo類，包括了一些屬性和方法，下面我們用到了他的幾個屬性：

                p.StartInfo.FileName = "OpenDrawer.exe";           //設定程序名
                //p.StartInfo.Arguments = "/c " + command;    //設定程式執行參數
                p.StartInfo.UseShellExecute = false;        //關閉Shell的使用
                //p.StartInfo.RedirectStandardInput = true;   //重定向標準輸入
                //p.StartInfo.RedirectStandardOutput = true;  //重定向標準輸出
                //p.StartInfo.RedirectStandardError = true;   //重定向錯誤輸出
                p.StartInfo.CreateNoWindow = true;          //設置不顯示窗口

                p.Start();   //啟動

                //p.StandardInput.WriteLine(command);       //也可以用這種方式輸入要執行的命令
                //p.StandardInput.WriteLine("exit");        //不過要記得加上Exit要不然下一行程式執行的時候會當機

                //return p.StandardOutput.ReadToEnd();        //從輸出流取得命令執行結果
            }
            catch{}

        }
        /// <summary>
        /// 开钱箱
        /// </summary>
        private static void OpenDrawerByLPT()
        {
            const int OPEN_EXISTING = 3;
            string prnPort = "LPT1";
            try
            {
                IntPtr iHandle = CreateFile(prnPort, 0x40000000, 0, 0, OPEN_EXISTING, 0, 0);
                if (iHandle.ToInt32() != -1)
                {
                    SafeFileHandle handle = new SafeFileHandle(iHandle, true);
                    FileStream fs = new FileStream(handle, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                    sw.Write(commandOpenDrawer);
                    sw.Close();
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        private static void OpenDrawerByCOM(string str)
        {
            const int OPEN_EXISTING = 3;
            string prnPort = "COM1";

            IntPtr iHandle = CreateFile(prnPort, 0x40000000, 0, 0, OPEN_EXISTING, 0, 0);
            if (iHandle.ToInt32() != -1)
            {
                FileStream fs = new FileStream(iHandle, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                sw.Write(((char)27).ToString() + "p" + ((char)0).ToString() + ((char)60).ToString() + ((char)255).ToString());
                sw.Close();
                fs.Close();
            }
        }
        #endregion

        private static void OpenDrawerByPrinter()
        {
            //Settings settings = new Settings();
            //settings.getValuesFromRegistry();
            string PrinterName="";
            IntPtr hPrinter = new IntPtr(0);
            if (OpenPrinter(PrinterName, out hPrinter, 0))
            {
                Int32 dwWritten = 0;

                DOCINFOA docinfo = new DOCINFOA();
                docinfo.pDocName = "CashPop";

                if (StartDocPrinter(hPrinter, 1, docinfo))
                {
                    if (StartPagePrinter(hPrinter))
                    {
                        IntPtr pBytesCommandOpenDrawer = Marshal.UnsafeAddrOfPinnedArrayElement(commandOpenDrawer, 0);
                        WritePrinter(hPrinter, pBytesCommandOpenDrawer, commandOpenDrawer.Length, out dwWritten);
                        Marshal.FreeCoTaskMem(pBytesCommandOpenDrawer);

                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
        }

    }
}