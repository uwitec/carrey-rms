using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DeskApp
{

    class Authorize
    {
        [DllImport("Authorize.dll")]
        private static extern bool ValidityUUID(string uuid);
        [DllImport("Authorize.dll")]
        private static extern bool ValidityDemo(string uuid);
        [DllImport("Authorize.dll")]
        private static extern int GetRemainingDays(string uuid);
        [DllImport("Authorize.dll")]
        private static extern string Serial([Out, MarshalAs(UnmanagedType.LPArray)] char[] sn);

        //public static string GetLicense()
        //{
        //    string uuid = string.Empty;
        //    string fi=System.Environment.CurrentDirectory+"\\License.ini";
        //    if (System.IO.File.Exists(fi))
        //    {
        //        uuid = INIFile.ReadValue(fi,"License", "UUID");
        //    }
        //    return uuid;
        //}
        //public static void SetLicense(string uuid)
        //{
        //    string fi = System.Environment.CurrentDirectory + "\\License.ini";
        //    if (System.IO.File.Exists(fi))
        //    {
        //         INIFile.Writue(fi,"License","UUID",uuid);
        //    }
        //}
        public static bool GetValidityUUID(string uuid)
        {
            bool ret = false;
            try
            {
                ret = ValidityUUID(uuid);
            }
            catch { }
            return ret;
        }

        public static bool GetValidityDemo(string uuid)
        {
            bool ret=false;
            try
            {
                ret = ValidityDemo(uuid);
            }
            catch { }
            return ret;
        }

        public static int RemainingDays(string uuid)
        {
            int ret = 0;
            try
            {
                ret = GetRemainingDays(uuid);
            }
            catch { }
            return ret;
        }

        public static string GetSerial()
        {
            string sn=string.Empty;
            //try
            //{
                char[] ds = new char[64];
                Serial(ds);
                sn = new string(ds);
            //}
            //catch { }
            return sn;
        }
    }
}
