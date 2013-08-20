using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text;
using System.Security.Cryptography;
using System.IO;


namespace AppExt
{
	sealed class rms_var
	{
		
		public const string apptitle = "餐厅管家系统 2.0";
		public const string ShortVendorName = "Carrey Group";
		public const string EnCopyright = "Copyright (C) Carrey Group. All Rights Reserved!";
		public const string ChnCopyright = "版权所有 (C) Carrey Group. 保留所有权利！";
		public const string WebPage = "Http://www.carreygroup.com";
		
		public static string BaseConnStr = "";
		public static string ConnStr = "";
		
		const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
		
		public static string shopdbfile;
		
		public static string opid;
		
		//登录模块代码
		public static int log_mod_code;
		
		//权限列表
		
		//是否允许登录
		public static bool log_sys = false; //系统管理
		public static bool log_kc_wl = false; //库存管理 物料
		public static bool log_kc_yl = false; //库存管理 原料
		public static bool log_qt = false; //前台管理
		public static bool log_cmp = false; //触摸屏客户端
		public static bool log_hc = false; //后厨上菜管理
		public static bool log_hztj = false; //汇总统计
		public static bool log_svc = false; //RMS 服务程序
		
		//系统管理模块的权限
		public static bool sys_xtsz = false; //系统设置
		public static bool sys_khgl = false; //客户管理
		public static bool sys_rygl = false; //人员管理
		public static bool sys_cpgl = false; //菜品管理
		public static bool sys_qtgl = false; //前台信息
		public static bool sys_sjgl = false; //数据管理
		
		//操作权限
		public static bool op_audit = false; //审核权
		public static bool op_jz = false; //结帐权
		public static bool op_tc = false; //退菜权
		public static bool op_qd = false; //允许客户签单
		public static bool op_dz = false; //允许自由打折
		public static bool op_df = false; //未结帐允许删除单据和菜品
		public static bool op_fw = false; //返位
		
		//读写注册表
		public static string ReadStrfromReg(string KeyName, string DefaultValue)
		{
            RegistryKey reg;
            string ret = "";
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
            if (reg != null)
            {
                ret=reg.GetValue(KeyName, DefaultValue).ToString();
            }
            return ret;
		}
		
		public static int ReadIntfromReg(string KeyName, int DefaultValue)
		{
			RegistryKey reg;
            int ret =0;
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
            if (reg != null)
            {
                ret=Convert.ToInt32(reg.GetValue(KeyName, DefaultValue).ToString());
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
		
		//程序初始化操作 数据库连接
		static public void InitialApp()
		{
			//读取数据库连接选项 "workstation id=" & ReadStrfromReg("Wkst_Id") + ";" & "data source=" & ReadStrfromReg("SQLServerName") + ";" & _
			//Provider=SQLOLEDB.1;Persist Security Info=False;User ID=test;Initial Catalog=RMS;Data Source=192.168.2.101;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=RITHIA;Use Encryption for Data=False;Tag with column collation when possible=False
			
			BaseConnStr = "workstation id=" + (ReadStrfromReg("Wkst_Id", "") + ";") + "data source=" + (ReadStrfromReg("SQLServerName", "") + ";") + "packet size=" + (ReadStrfromReg("pkt_size", "") + ";") + "user id=" + (ReadStrfromReg("SQL_User", "") + ";") + "persist security info=" + (ReadStrfromReg("ps_info", "") + ";") + "initial catalog=" + (ReadStrfromReg("DataBaseName", "") + ";") + "password=" + ReadStrfromReg("SQL_PSW", "");
			ConnStr = BaseConnStr;
		}
		
		public static DataSet LoadShopData()
		{
			OleDbConnection conn = new OleDbConnection();
			conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + shopdbfile + ";Mode=Share Deny None;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:SFP=False";
			OleDbCommand selectcmd;
			selectcmd = new OleDbCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from shop";
			OleDbDataAdapter dbDA;
			dbDA = new OleDbDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			
			return dbDS;
		}
		
		public static string GetShopIPFormName(string shopname)
		{
			if (shopname.Trim() == "")
			{
				return "localhost";
			}
			else
			{
				OleDbConnection conn = new OleDbConnection();
				conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + shopdbfile + ";Mode=Share Deny None;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:SFP=False";
				OleDbCommand selectcmd;
				selectcmd = new OleDbCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				selectcmd.CommandText = "select shopip from shop where shopname='" + shopname + "'";
				OleDbDataAdapter dbDA;
				dbDA = new OleDbDataAdapter();
				dbDA.SelectCommand = selectcmd;
				conn.Open();
				DataSet dbDS;
				dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0) //存在记录
				{
					return dbDS.Tables[0].Rows[0][0].ToString();
				}
				else
				{
					return shopname;
				}
			}
		}
		
		//检测登录用户是否合法
		//0=该用户名和密码虽然正确但无使用该模块权限 1=通过
		public static int CheckLog(string userid, string userpsw, string rmtserverip)
		{
			opid = userid;
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			
			ConnStr = BaseConnStr;
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM Operator where " + "OperatorID=" + "'" + userid + "'" + " and " + "password=" + "'" + MD5Crypt(userpsw) + ("'" + " and disabled<>1"), conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0) //该用户名和口令存在，返回权限并检测权限
				{
					//填充权限
					GetLogAccessInfo(opid);
					GetSysAccessInfo(opid);
					GetOPAccessInfo(opid);
					switch (log_mod_code)
					{
						case 1: //检测是否允许登录系统管理
							if (log_sys)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
						case 2: //检测是否允许登录库存管理
							if (log_kc_wl || log_kc_yl)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
						case 3: //检测是否允许登录前台管理
							if (log_qt)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
						case 4: //检测是否允许登录汇总统计
							if (log_hztj)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
						case 5: //检测是否允许登录后厨上菜
							if (log_hc)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
						case 6: //检测是否允许登陆RMS服务程序
							if (log_svc)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
						case 7: //检测是否允许登陆触摸屏客户端
							if (log_cmp)
							{
								return 1;
							}
							else
							{
								//没有权限
								return 0;
							}
							break;
					}
					
				}
				else //用户名、口令不正确
				{
					return 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				
				return -1;
			}
			finally
			{
				conn.Close();
			}
			return 0;
		}
		
		//返回权限设置
		public static void GetLogAccessInfo(object opid)
		{
			//sys 系统管理
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			SqlCommand selectcmd;
			selectcmd = new SqlCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='sys'";
			SqlDataAdapter dbDA;
			dbDA = new SqlDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_sys = true;
			}
			else
			{
				log_sys = false;
			}
			
			//kc 库存管理 物料
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='kc_wl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_kc_wl = true;
			}
			else
			{
				log_kc_wl = false;
			}
			
			//kc 库存管理 原料
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='kc_yl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_kc_yl = true;
			}
			else
			{
				log_kc_yl = false;
			}
			
			//qt 前台管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qt'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_qt = true;
			}
			else
			{
				log_qt = false;
			}
			
			//hc 后厨管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='hc'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_hc = true;
			}
			else
			{
				log_hc = false;
			}
			
			//hztj 汇总统计
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='hztj'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_hztj = true;
			}
			else
			{
				log_hztj = false;
			}
			
			//rmssvc RMS 服务程序
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='rmssvc'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_svc = true;
			}
			else
			{
				log_svc = false;
			}
			
			//cmp 触摸屏客户端
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='cmp'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				log_cmp = true;
			}
			else
			{
				log_cmp = false;
			}
		}
		
		public static void GetSysAccessInfo(object opid)
		{
			//xtsz 系统设置
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			SqlCommand selectcmd;
			selectcmd = new SqlCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='xtsz'";
			SqlDataAdapter dbDA;
			dbDA = new SqlDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				sys_xtsz = true;
			}
			else
			{
				sys_xtsz = false;
			}
			
			//khgl 客户管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='khgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				sys_khgl = true;
			}
			else
			{
				sys_khgl = false;
			}
			
			//rygl 人员管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='rygl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				sys_rygl = true;
			}
			else
			{
				sys_rygl = false;
			}
			
			//clgl 菜品信息管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='clgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				sys_cpgl = true;
			}
			else
			{
				sys_cpgl = false;
			}
			
			//qtgl 前台管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qtgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				sys_qtgl = true;
			}
			else
			{
				sys_qtgl = false;
			}
			
			//sjgl 数据管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='sjgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				sys_sjgl = true;
			}
			else
			{
				sys_sjgl = false;
			}
		}
		
		public static void GetOPAccessInfo(object opid)
		{
			//audit 审核权
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			SqlCommand selectcmd;
			selectcmd = new SqlCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='audit'";
			SqlDataAdapter dbDA;
			dbDA = new SqlDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_audit = true;
			}
			else
			{
				op_audit = false;
			}
			
			//jz 结帐权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='jz'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_jz = true;
			}
			else
			{
				op_jz = false;
			}
			
			//tc 退菜权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='tc'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_tc = true;
			}
			else
			{
				op_tc = false;
			}
			
			//qd 签单权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qd'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_qd = true;
			}
			else
			{
				op_qd = false;
			}
			
			//dz 自由打折权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='dz'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_dz = true;
			}
			else
			{
				op_dz = false;
			}
			
			//df 未结帐允许删单据删菜品权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='df'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_df = true;
			}
			else
			{
				op_df = false;
			}
			
			//fw 返位权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='fw'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				op_fw = true;
			}
			else
			{
				op_fw = false;
			}
		}
		
	}
	
	
}
