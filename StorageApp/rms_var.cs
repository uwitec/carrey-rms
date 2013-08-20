using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.IO;


namespace StorageApp
{
	sealed class rms_var
	{
		
		public static string ConnStr;
		const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
		
		public struct OperatorInfo
		{
			public string OpID;
			public string EmpID;
			public string DeptNo;
			public string EmployeeName;
			public string Department;
		}
		
		public static AppExt.CAppExt TheAppExt; //类库中的对象
		
		public static OperatorInfo opinfo;
		public static int periodmonth = 1; //结转的周期，默认= 1 每月结帐
		
		//基本信息 窗口
		public static frmMaterialType frmMaterTyp;
		public static frmMaterials frmMtrls;
		public static frmVendor frmVndor;
		
		public static frmStorageInventory frmStorageInvent;
		public static frmDeptStorageInventory frmDeptStorageInvent;
		
		//业务处理 窗口
		public static frmInBill frmTheInBill;
		public static frmOutBill frmTheOutBill;
		public static frmPayVendor frmPayVD;
		
		
		
		//读写注册表
		public static string ReadStrfromReg(string KeyName, string DefaultValue)
		{
			RegistryKey reg;
			
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
			string ret="";
			if (reg != null)
			{
				ret=reg.GetValue(KeyName, DefaultValue).ToString();
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
		
		//审核权 audit
		public static bool AllowAudit()
		{
			System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
			conn1.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn1;
				selectCMD1.CommandText = "SELECT count(*) FROM op_acs where operatorid='" + opinfo.OpID + "' and access='audit'";
				selectCMD1.CommandTimeout = 30;
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				dbDA1.SelectCommand = selectCMD1;
				conn1.Open();
				DataSet dbDS1 = new DataSet();
				dbDA1.Fill(dbDS1, "t");
				if (Convert.ToInt32(dbDS1.Tables[0].Rows[0][0].ToString()) > 0)
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
				conn1.Close();
			}
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
		
		//返回仓库入库单据类型
		public static DataTable LoadInBillType()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM StorageBillType where Direction='1'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//返回仓库出库单据类型
		public static DataTable LoadOutBillType()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM StorageBillType where Direction='2'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//获取所有部门，返回DataTable
		public static DataTable LoadDept()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM Department";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "DeptList");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//获取所有仓库部门，返回DataTable
		public static DataTable LoadStorageDept()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				//09=原料 99=物料
				if (TheAppExt.Chk_Kc_Wlgl && TheAppExt.Chk_Kc_Ylgl)
				{
					selectCMD.CommandText = "SELECT * FROM Department where depcode='09' or depcode='99'";
				}
				else if (TheAppExt.Chk_Kc_Wlgl && ! TheAppExt.Chk_Kc_Ylgl)
				{
					selectCMD.CommandText = "SELECT * FROM Department where depcode='99'";
				}
				else if (TheAppExt.Chk_Kc_Ylgl && ! TheAppExt.Chk_Kc_Wlgl)
				{
					selectCMD.CommandText = "SELECT * FROM Department where depcode='09'";
				}
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "StorageDeptList");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//获取供应商列表
		public static DataTable LoadVendor()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT vendorname FROM vendor where disabled<>'1' order by vendorname";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//获取审核人列表
		public static DataTable LoadManager()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT empid FROM employee where disabled<>'1' and manager='1'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//获取采购员列表
		public static DataTable LoadPurchase()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT name FROM employee order by name";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//返回系统单据总数
		public static int GetCurrentTableNoBillsCount(string tableno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT count(*) FROM salebill";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				int count;
				count = int.Parse(dbDS.Tables[0].Rows[0][0].ToString());
				return count;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return 0;
		}
		
		//获取所有物品类别，返回DataTable
		public static DataTable LoadMaterialType(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (deptname != "全部")
				{
					selectCMD.CommandText = "SELECT * FROM MaterialType where depcode ='" + GetDeptCode(deptname) + "'";
				}
				else
				{
					selectCMD.CommandText = "SELECT * FROM MaterialType";
				}
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//返回菜品编码长度
		public static string GetMaterialCodeLenth(string StorageTypeName)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (StorageTypeName == "物料仓库")
				{
					selectCMD.CommandText = "SELECT value FROM syssetup where parametercode='WMatCodeLen'";
				}
				else
				{
					selectCMD.CommandText = "SELECT value FROM syssetup where parametercode='YMatCodeLen'";
				}
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回部门编码
		public static string GetDeptCode(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT depcode FROM department where deptname='" + deptname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回部门名称
		public static string GetDeptName(string deptcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret ="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT deptname FROM department where depcode='" + deptcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回物品类别编码
		public static string GetMaterialTypeCode(string MaterialTypename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT materialtypecode FROM materialtype where name='" + MaterialTypename + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回物品名称
		public static string GetMaterialName(string MaterialCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT materialname FROM materials where materialcode='" + MaterialCode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回物品单位
		public static string GetMaterialUnit(string MaterialCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT unit FROM materials where materialcode='" + MaterialCode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回物品所属类别编码
		public static string GetTheMaterialTypeCode(string MaterialCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT materialtypecode FROM materials where MaterialCode='" + MaterialCode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回物品类别所属部门编码
		public static string GetMaterialTypeCodeDeptCode(string MaterialTypeCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT depcode FROM materialtype where MaterialTypeCode='" + MaterialTypeCode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回仓库单据类型名称
		public static string GetStorageBillType(string StorageBillTypeCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT name FROM StorageBillType where StorageBillTypeCode='" + StorageBillTypeCode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回仓库单据类型编码
		public static string GetStorageBillTypeCode(string StorageBillType)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT StorageBillTypeCode FROM StorageBillType where name='" + StorageBillType + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回仓库单据类型名称
		public static string GetStorageBillTypeName(string StorageBillTypecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT name FROM StorageBillType where StorageBillTypeCode='" + StorageBillTypecode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回仓库单据类型的单据名称
		public static string GetStorageBillTypeCaptionName(string StorageBillTypecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT formcaption FROM StorageBillType where StorageBillTypeCode='" + StorageBillTypecode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
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
		
		//返回供应商名称
		public static string GetVendorName(string VendorCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT vendorname FROM vendor where VendorCode='" + VendorCode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception)
			{
				//MessageBox.Show(ex.tostring)
			}
			finally
			{
				conn.Close();
			}
            return ret;
		}
		
		//返回供应商编码
		public static string GetVendorCode(string vendorname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT vendorcode FROM vendor where vendorname='" + vendorname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception)
			{
				//MessageBox.Show(ex.tostring)
			}
			finally
			{
				conn.Close();
			}
            return ret;
		}
		
		//返回雇员名称
		public static string GetEmployeeName(string empid)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT name FROM employee where empid='" + empid + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception)
			{
				//MessageBox.Show(ex.tostring)
			}
			finally
			{
				conn.Close();
			}
            return ret;
		}
		
		//返回雇员编码
		public static string GetEmployeeID(string name)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT empid FROM employee where name='" + name + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				ret=dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception)
			{
				//MessageBox.Show(ex.tostring)
			}
			finally
			{
				conn.Close();
			}
            return ret;
		}
		
		//返回系统设置
		public static string GetSysSetup(string parametercode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT value FROM syssetup where parametercode='" + parametercode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0]["value"].ToString();
				
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
		
		//系统设置
		public static bool SetSysSetup(string parametercode, string value)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "update syssetup set value='" + value + "' where parametercode='" + parametercode + "'";
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				return true;
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
		
		//返回物品当月入库单价，当月若没有该物品取以往平均价
		public static string GetCurrMonthMtrlPrice(string materialcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT price FROM storage_inventory where yearmonth= convert(char(4),getdate(),102)+convert(char(2),getdate(),00) and materialcode='" + materialcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					ret=dbDS.Tables[0].Rows[0][0].ToString();
				}
				else
				{
					selectCMD.CommandText = "SELECT avg(price) FROM storage_inventory where materialcode='" + materialcode + "'";
					dbDA.Fill(dbDS, "t1");
				}
				
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
		
		//返回服务器自动生成的库存单据号
		public static string GenNewStorageBillNo(int billtype, string storagebilltypecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				System.Data.SqlClient.SqlCommand MysqlProc;
				MysqlProc = new System.Data.SqlClient.SqlCommand();
				MysqlProc.CommandType = CommandType.StoredProcedure;
				MysqlProc.CommandText = "NewStorageBillNo";
				MysqlProc.Connection = conn;
				
				System.Data.SqlClient.SqlParameter sparam1;
				sparam1 = new System.Data.SqlClient.SqlParameter();
				sparam1.ParameterName = "@billtype";
				sparam1.SqlDbType = SqlDbType.SmallInt;
				sparam1.Value = billtype;
				MysqlProc.Parameters.Add(sparam1);
				
				System.Data.SqlClient.SqlParameter sparam2;
				sparam2 = new System.Data.SqlClient.SqlParameter();
				sparam2.ParameterName = "@storagebilltypecode";
				sparam2.SqlDbType = SqlDbType.VarChar;
				sparam2.Size = 10;
				sparam2.Value = storagebilltypecode;
				MysqlProc.Parameters.Add(sparam2);
				
				System.Data.SqlClient.SqlParameter sparam;
				sparam = new System.Data.SqlClient.SqlParameter();
				sparam.ParameterName = "@BillNo";
				sparam.Size = 50;
				sparam.SqlDbType = SqlDbType.VarChar;
				sparam.Direction = ParameterDirection.Output;
				MysqlProc.Parameters.Add(sparam);
				
				conn.Open();
				MysqlProc.ExecuteNonQuery();
				ret=sparam.Value.ToString();
				
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
			if (AppPath[AppPath.Length - 1] != '\\')
			{
				AppPath += "\\";
			}
			
			return AppPath;
		}
		
	}
	
	
	
}
