using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Threading;
using System.Runtime.Remoting.Messaging;


namespace Kitchen
{
	sealed class rms_var
	{
		
		const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
		
		public static string ConnStr;
		public static AppExt.CAppExt TheAppExt; //类库中的对象
		public static int FoodInputMode = 0; //0 菜品编码 1 菜品拼音码 2 菜品类别编码
		
		public struct OperatorInfo
		{
			public string OpID;
			public string EmpID;
			public string DeptNo;
			public string EmployeeName;
			public string Department;
		}
		
		public static OperatorInfo opinfo;
		
		//读写注册表
		public static string ReadStrfromReg(string KeyName, string DefaultValue)
		{
			RegistryKey reg;
			
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
            string ret = "";
			if (reg != null)
			{
				ret=reg.GetValue(KeyName, DefaultValue).ToString() ;
//				reg.Close();
			}
            return ret;
		}
		
		public static int ReadIntfromReg(string KeyName, int DefaultValue)
		{
			RegistryKey reg;
			
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
            int ret=0;
			if (reg != null)
			{
				ret=Convert.ToInt32(reg.GetValue(KeyName, DefaultValue).ToString());
//				reg.Close();
			}
            return ret;
		}
		
		public static void WriteStrToReg(string KeyName, string KeyValue)
		{
			RegistryKey reg;
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), true);
			if (reg == null)
			{
				// Key doesn't exist; create it.
				reg = Registry.CurrentUser.CreateSubKey(regSubKey.ToString());
			}
			
			if (reg != null)
			{
				reg.SetValue(KeyName, KeyValue);
				reg.Close();
			}
		}
		
		public static void WriteIntToReg(string KeyName, int KeyValue)
		{
			RegistryKey reg;
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), true);
			if (reg == null)
			{
				// Key doesn't exist; create it.
				reg = Registry.CurrentUser.CreateSubKey(regSubKey.ToString());
			}
			
			if (reg != null)
			{
				reg.SetValue(KeyName, KeyValue);
				reg.Close();
			}
		}
		
		//Hash加密
		public static string MD5Crypt(string s)
		{
			MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
			byte[] hashedBytes;
			UTF8Encoding encoder = new UTF8Encoding();
			
			hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(s));
			
			return BitConverter.ToString(hashedBytes);
		}
		
		//程序初始化操作
		static public void InitialApp()
		{
			//读取数据库连接选项
			ConnStr = "workstation id=" + (ReadStrfromReg("Wkst_Id", "") + ";") + "packet size=" + (ReadStrfromReg("pkt_size", "") + ";") + "user id=" + (ReadStrfromReg("SQL_User", "") + ";") + "data source=" + (ReadStrfromReg("SQLServerName", "") + ";") + "persist security info=" + (ReadStrfromReg("ps_info", "") + ";") + "initial catalog=" + (ReadStrfromReg("DataBaseName", "") + ";") + "password=" + ReadStrfromReg("SQL_PSW", "");
		}
		
		//填充操作员信息 LogOperatorID
		public static void ReceiveOperatorInfo(string userid)
		{
			//根据LogOperator返回雇员信息
			opinfo.OpID = userid;
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM Operator where OperatorID='" + userid + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				//获得 EmployeeID->empno
				string empno;
                empno = dbDS.Tables[0].Rows[0]["EmpID"].ToString();
				opinfo.EmpID = empno;
				//根据EmpNo返回EmployeeName 和 Department
				selectCMD.Dispose();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM Employee where EmpID='" + empno + "'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                opinfo.EmployeeName = dbDS.Tables[0].Rows[0]["name"].ToString();
				
				
				//返回部门名称
				string depno;
                depno = dbDS.Tables[0].Rows[0]["depcode"].ToString();
				selectCMD.Dispose();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM Department where depcode='" + depno + "'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");

                opinfo.Department = dbDS.Tables[0].Rows[0]["deptname"].ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		//检测条码的合法性 是否存在 是否还未上菜
		public static bool CheckBarcode(string barcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select count(*) from SaledFoods where transfered<>'2' and barcode='" + barcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (System.Convert.ToInt32(dbDS.Tables[0].Rows[0][0]) > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				conn.Close();
			}
		}
		
		//根据菜品条码返回菜品所属桌台号
		public static string GetTablenofromBarcode(string barcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select tableno from SaledFoods where barcode='" + barcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0][0].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				ret="";
			}
			finally
			{
				conn.Close();
			}
            return ret;
		}
		
		//根据菜品条码返回菜品名称
		public static string GetFoodnamefromBarcode(string barcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select foodname from SaledFoods where barcode='" + barcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0][0].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
            return ret;
		}
		
		//返回App运行路径
		public static string GetAppPath()
		{
			//获取报表路径信息
			string AppPath;
			
			AppPath = ReadStrfromReg("AppPath", Directory.GetCurrentDirectory());
			if (AppPath[AppPath.Length - 1]!= '\\')
			{
				AppPath += "\\";
			}
			
			return AppPath;
		}
		
	}
	
	
}
