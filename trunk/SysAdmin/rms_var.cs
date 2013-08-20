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


namespace SysAdmin
{
	sealed class rms_var
	{
		
		public static string ConnStr;
		const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
		
		public static AppExt.CAppExt TheAppExt; //类库中的对象
		
		//窗口变量
		public static frmSysAdmin mainfrm;
		
		//客户管理
		public static frmCustType frmCustTyp;
		public static frmCustomer frmCust;
		public static frmClubCard frmcard;
		public static frmCardAddupDisc frmCardAUD;
		public static frmSrchCardSpl frmscspl;
		
		//部门/雇员管理
		public static frmDept frmDepartment;
		public static frmEmployee frmEmpl;
		public static frmAccess frmacs;
		
		//菜例管理
		public static frmFoodType frmfoodtyp;
		public static frmFoodList frmfoodlst;
		public static frmEditFoodOperandi frmfoodop;
		public static frmEditFoodTaste frmfoodtst;
		public static frmFoodDiscount frmFoodDisc;
		public static frmSuitFood frmsuit;
		
		//前台信息
		public static frmBillType frmBilltyp;
		public static frmTimeBlock frmTimeblk;
		public static frmPayType frmPayTyp;
		public static frmDerateReason frmDerateRsn;
		public static frmCancelReason frmCancelRsn;
		public static frmTableType frmTabletyp;
		public static frmTableList frmTablelst;
		
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
			string ret="";
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
			
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
		
		///'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		
		//程序初始化操作
		static public void InitialApp()
		{
			//读取数据库连接选项
			ConnStr ="workstation id=" + (ReadStrfromReg("Wkst_Id", "") + ";") + "packet size=" + (ReadStrfromReg("pkt_size", "") + ";") + "user id=" + (ReadStrfromReg("SQL_User", "") + ";") + "data source=" + (ReadStrfromReg("SQLServerName", "") + ";") + "persist security info=" + (ReadStrfromReg("ps_info", "") + ";") + "initial catalog=" + (ReadStrfromReg("DataBaseName", "") + ";") + "password=" + ReadStrfromReg("SQL_PSW", "");
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
				opinfo.EmployeeName =dbDS.Tables[0].Rows[0]["name"].ToString();
				
				
				//返回部门名称
				string depno;
				depno =dbDS.Tables[0].Rows[0]["depcode"].ToString();
				selectCMD.Dispose();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM Department where depcode='" + depno + "'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                if (dbDS.Tables[0].Rows.Count > 0)
                {
                    opinfo.Department = dbDS.Tables[0].Rows[0]["deptname"].ToString();
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
		}
		
		//返回客户类别编码
		public static string GetCustTypeCode(string CustTypeName)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT typecode FROM custtype where typename='" + CustTypeName + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回部门编号
		public static string GetDeptCode(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT depcode FROM department where deptname='" + deptname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回部门名称
		public static string GetDeptName(string deptcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT deptname FROM department where depcode='" + deptcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回雇员编号
		public static string GetEmplCode(string empname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT empid FROM employee where name='" + empname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回菜品类别所属部门
		public static string GetFoodTypeDeptName(string FoodTypeName)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT deptname FROM view_FoodType where typename='" + FoodTypeName + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回菜品类别编码
		public static string GetFoodTypeCode(string FoodTypeName)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT typecode FROM foodtype where typename='" + FoodTypeName + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回菜品编码长度
		public static string GetFoodCodeLenth()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT value FROM syssetup where parametercode='FoodCodeLenth'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return "";
		}
		
		//返回菜品成本算法
		//1：手工指定，2：读取原料最近进价，3：仓库原料平均价
		public static int GetFoodCostMethodCode()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT value FROM syssetup where parametercode='foodcodecost'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				//1：手工指定，2：读取原料最近进价，3：仓库原料平均价
				return int.Parse(dbDS.Tables[0].Rows[0][0].ToString().Trim());
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
		
		//返回当前菜品的做法
		public static string GetCurrentFoodOperandi(string foodcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT DefaultOperandi FROM foodlist where foodcode='" + foodcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//设置当前菜品做法
		public static bool SetCurrentFoodOperandi(string foodcode, string operandi)
		{
			SqlCommand selectCMD;
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			try
			{
				conn.ConnectionString = ConnStr;
				
				selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "update foodlist set " + "defaultoperandi='" + operandi + "'" + "where foodcode='" + foodcode + "'";
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
		
		//返回当前菜品的口味
		public static string GetCurrentFoodTaste(string foodcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT DefaultTaste FROM foodlist where foodcode='" + foodcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//设置当前菜品口味
		public static bool SetCurrentFoodTaste(string foodcode, string taste)
		{
			SqlCommand selectCMD;
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			try
			{
				conn.ConnectionString = ConnStr;
				
				selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "update foodlist set " + "defaulttaste='" + taste + "'" + "where foodcode='" + foodcode + "'";
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
		
		//返回原料物料代码
		public static string GetMaterialCode(string materialname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT materialcode FROM materials where materialname='" + materialname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//返回原物料的单位
		public static string GetMaterialUnit(string materialname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT unit FROM materials where materialname='" + materialname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//返回原料物料代码
		public static string GetFoodCode(string foodname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT foodcode FROM foodlist where foodname='" + foodname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//返回菜品的单位
		public static string GetFoodUnit(string foodname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT unit FROM foodlist where foodname='" + foodname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//返回菜品单价
		public static string GetFoodPrice(string foodname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT price FROM foodlist where foodname='" + foodname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//更新套餐中菜品价格
		public static bool UpdateSuitFoodsPrice(string suitcode)
		{
			//返回套餐价格
			string suitprice;
			string foodcode;
			int foodcount = 0;
			double foodtotalprice = 0;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT standardsum FROM suit where suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                suitprice = dbDS.Tables[0].Rows[0][0].ToString().Trim();
				
				//返回套餐中菜品总价格
				selectCMD.CommandText = "SELECT foodcode,foodqty FROM suitfoods where suitcode='" + suitcode + "'";
				
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				DataSet dbDS1 = new DataSet();
				
				dbDA1.SelectCommand = selectCMD;
				dbDS1.Clear();
				dbDA1.Fill(dbDS1, "t1"); //当前套餐的所有菜品
				
				//返回套餐中菜品数量
				foodcount = dbDS1.Tables[0].Rows.Count;
				
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn;
				selectCMD1.CommandTimeout = 30;
				
				SqlDataAdapter dbDA2 = new SqlDataAdapter();
				DataSet dbDS2 = new DataSet();
				
				//套餐中菜品原单价合计
				for (int i = 0; i <= dbDS1.Tables[0].Rows.Count - 1; i++)
				{
					selectCMD1.CommandText = "select price from foodlist where foodcode='" + dbDS1.Tables[0].Rows[i][0] + "'";
					dbDA2.SelectCommand = selectCMD1;
					dbDS2.Clear();
					dbDA2.Fill(dbDS2, "t2");
					
					foodtotalprice = foodtotalprice + (System.Convert.ToDouble(dbDS2.Tables[0].Rows[0][0])) * System.Convert.ToDouble(dbDS1.Tables[0].Rows[i][1]);
				}
				
				//核算套餐中菜品单价
				selectCMD.CommandText = "update view_suitfoods set foodprice=price*foodqty-price*foodqty/" + double.Parse(foodtotalprice.ToString()) + "*" + (foodtotalprice - double.Parse(suitprice));
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
		
		//检测桌台使用状态
		//0=空闲，1=使用，2=预定中，-1=不存在该桌台 与桌台列表单击事件的返回值不同！
		public static int GetTableStatus(string tableno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            int ret=-1;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT status FROM Tablestatus where TableNo='" + tableno + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (! (dbDS.Tables[0].Rows.Count > 0)) //没有该桌台
				{
					return -1;
				}
				else
				{
					//0=空闲，1=使用，2=预定中
					ret=Convert.ToInt32(dbDS.Tables[0].Rows[0]["status"].ToString());
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
		
		//返回桌台类别代码
		public static string GetTableTypeCode(string TableType)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT tabletypecode FROM tabletype where name='" + TableType + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");

                return dbDS.Tables[0].Rows[0][0].ToString().Trim();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return "";
			}
			finally
			{
				conn.Close();
			}
		}
		
		//返回App运行路径
		public static string GetAppPath()
		{
			//获取报表路径信息
			string AppPath;
			
			AppPath = ReadStrfromReg("AppPath", Directory.GetCurrentDirectory());
			if (AppPath[AppPath.Length - 1] !='\\')
			{
				AppPath += "\\";
			}
			
			return AppPath;
		}
		
		//备份数据库
		public static bool BackupDB(string filename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			SqlCommand selectCMD = new SqlCommand();
			selectCMD.Connection = conn;
			selectCMD.CommandType = CommandType.Text;
			try
			{
				conn.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				conn.Close();
				return false;
			}
			
			try
			{
				selectCMD.CommandText = "BACKUP DATABASE RMS TO Disk ='" + filename + "'";
				selectCMD.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("数据库备份操作失败！" + "\r\n" + "\r\n" + ex.ToString());
				return false;
			}
		}
		
		//清空数据库
		public static bool ClearDB(int mode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			SqlCommand selectCMD = new SqlCommand();
			selectCMD.Connection = conn;
			selectCMD.CommandType = CommandType.Text;
			try
			{
				conn.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				conn.Close();
				return false;
			}
			
			try
			{
				selectCMD.CommandText = "delete from AppointBill";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from AppointFood";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from AppointTable";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from AppointTable_tmp";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Balance";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from BalanceTable";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from BalanceTable_t";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from CardSupply";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Dept_cost_sum";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Dept_sale_sum";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Dept_stat";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Dept_sum";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from InStorageBill";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from InStorageMaterials";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from OutStorageBill";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from OutStorageMaterials";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Reservation";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from ReservationFood";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from ReservationTable";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from SaleBill";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from SaleBill_t";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from SaleList";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from SaleList_t";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from SecStorage_Inventory";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from SignPayfor";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from Storage_Inventory";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from TableType_sum";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "delete from TableUseFreq";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "update tablestatus set status='0'";
				selectCMD.ExecuteNonQuery();
				
				//若清除全部数据则继续执行下面操作
				if (mode == 1) //清空全部数据
				{
					selectCMD.CommandText = "delete from BillType";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from CancelReason";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from ClubAddUpDisc";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from ClubCard";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Customer";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from CustType";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Department where depcode<>'GL'";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from DerateReason";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Discount";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from DiscountArea";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from dlst";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Employee where empid <>'001'";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from FoodCost";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from FoodCost_MList";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from FoodList";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from FoodOperandi";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from FoodTaste";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from FoodType";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Materials";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from MaterialType";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from op_acs where operatorid <>'001'";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Operator where operatorid <>'001'";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from PayType";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from PayVendor";
					selectCMD.ExecuteNonQuery();
					
					//selectCMD.CommandText = "delete from StorageBillType"
					//selectCMD.ExecuteNonQuery()
					
					selectCMD.CommandText = "delete from Suit";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from SuitFoods";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from TableStatus";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from TableType";
					selectCMD.ExecuteNonQuery();
					
					selectCMD.CommandText = "delete from Vendor";
					selectCMD.ExecuteNonQuery();
				}
				
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("数据库记录清除操作没有顺利完成！请检查当前数据是否有其他程序正在使用。" + "\r\n" + "\r\n" + ex.ToString());
				return false;
			}
		}
		
	}
	
	
}
