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


namespace TouchScreen
{
	namespace MySpace
	{
		sealed class rms_var
		{
			
			public static string ConnStr;
			const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
			
			public static AppExt.CAppExt TheAppExt; //类库中的对象
			
			public static int FoodInputMode = 3; //0 菜品编码 1 菜品拼音码 2 菜品类别编码 3 菜品类别名称
			
			public static Form1 frmMain;
			public static frmCancelRsn frmCancelReason;
			public static frmSuitFood frmSuit;
			public static AddFood frmAddFood;
			
			//窗口
			//Public mainfrm As mainform
			//Public frmAppnt As frmAppoint
			//Public frmInputBill As InputBill
			//Public frmTableST As frmTableStatus
			//Public frmbrssfod As frmBrsSpecialFood
			//Public frmbrscfod As frmBrsCurrentFood
			
			//Public frmCust As frmCustomer
			
			//Public frmSP As frmQuerySignPay
			//Public frmCF As frmCustomerFreq
			
			//综合查询
			//Public frmblncqry As frmBalanceQry
			//Public frmblnctypqry As frmBalanceTypeQry
			
			public struct OperatorInfo
			{
				public string OpID;
				public string EmpID;
				public string DeptNo;
				public string EmployeeName;
				public string Department;
			}
			
			public static string PayCustomerCode = "";
			public static string PayCustomerName = "";
			public static string PayCustomerSignedCount = "";
			public static string PayClubCardNo = "";
			public static string PayClubCardDiscountRate = "";
			
			public static OperatorInfo opinfo;
			
			public static bool AllowRemoteOperation = true;
			public static CRmsSvr.CRMSServer svrobj;
			public static ManualResetEvent e;
			public delegate bool  MyDelegate(string name);
			public delegate bool  TransFoodDelegate(string FoodCode, string TableType, string Tableno, string PsnCount, string billno, string FoodName, string TypeName, string DeptName, string unit, string quantity, string operandi, string taste, string operatorid, string barcode, int OperateCode, string CancelRsn);
			
			//读写注册表
			public static string ReadStrfromReg(string KeyName, string DefaultValue)
			{
				RegistryKey reg;
				
				reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
				string ret="";
				if (reg != null)
				{
					ret=reg.GetValue(KeyName, DefaultValue).ToString();
//					reg.Close();
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
//					reg.Close();
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
			
			//连接RMS远程服务程序
			public static bool ConnectSvr()
			{
                try
                {
                    //错误处理
                    //On Error Goto Errorhandler VBConversions Warning: On Error Goto not supported in C#
                    //客户端不需要定义通道
                    //按指定的URI创建远程对象代理
                    svrobj = (CRmsSvr.CRMSServer)(Activator.GetObject(typeof(CRmsSvr.CRMSServer), "tcp://" + ReadStrfromReg("RemoteRMSServerName", "localhost") + ":" + ReadStrfromReg("RemoteRMSServerPort", "8023") + "/RMSServer"));
                    //判断代理是否被创建，如果不成功，引发错误，否则调用服务方法
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
				if (svrobj == null)
				{
					//引发错误
					//Err.Raise(8000, "无法创建代理")
					return false;
				}
				//创建成功
				//MsgBox("建立代理成功")
				return true;				
			}
			
			//向远程服务程序传递信息
			public static bool TransMsg(string msg)
			{
				if (!AllowRemoteOperation)
				{
					return false;
				}
				//On Error Goto Errorhandler VBConversions Warning: On Error Goto not supported in C#
				string clientname;
				clientname = "qiantai"; //返回当前电脑名称
				//判断代理是否被创建
				if (svrobj == null)
				{
					//引发错误
					//Err.Raise(8000, "无法创建代理")
					return false;
				}
				//代理创建成功
				if (svrobj.AddtoMsgQue(msg))
				{
					MessageBox.Show("成功");
                    return true;
				}
                return false;
			}
			
			//传菜 - 调用远程服务
			public static bool TransFood_Rmt(string FoodCode, string TableType, string Tableno, string PsnCount, string billno, string FoodName, string TypeName, string DeptName, string unit, string quantity, string operandi, string taste, string operatorid, string barcode, int OperateCode, string CancelRsn)
			{
				if (!AllowRemoteOperation)
				{
					return false;
				}
				//On Error Goto Errorhandler VBConversions Warning: On Error Goto not supported in C#
				string clientname;
				clientname = "qiantai"; //返回当前电脑名称
				//判断代理是否被创建
				if (svrobj == null)
				{
					//引发错误
					//Err.Raise(8000, "无法创建代理")
					return false;
				}
				//代理创建成功
				if (svrobj.TransFood(FoodCode, TableType, Tableno, PsnCount, billno, FoodName, TypeName, DeptName, unit, quantity, operandi, taste, operatorid, barcode, OperateCode, CancelRsn))
				{
					return true;
				}
				
				return false;
			}
			
			//传菜 - 调用远程服务 - 异步传输
			public static bool TransFood_Rmt_Async(string FoodCode, string TableType, string Tableno, string PsnCount, string billno, string FoodName, string TypeName, string DeptName, string unit, string quantity, string operandi, string taste, string operatorid, string barcode, int OperateCode, string CancelRsn)
			{
                try
                {
                    if (!AllowRemoteOperation)
                    {
                        return false;
                    }
                    //On Error Goto Errorhandler VBConversions Warning: On Error Goto not supported in C#
                    //判断代理是否被创建
                    if (svrobj == null)
                    {
                        //引发错误
                        //Err.Raise(8000, "无法创建代理")
                        return false;
                    }
                    //代理创建成功

                    AsyncCallback cb;
                    cb = new AsyncCallback(TransFoodCallBack);
                    TransFoodDelegate d;
                    d = new TransFoodDelegate(svrobj.TransFood);
                    IAsyncResult ar;
                    ar = d.BeginInvoke(FoodCode, TableType, Tableno, PsnCount, billno, FoodName, TypeName, DeptName, unit, quantity, operandi, taste, operatorid, barcode, OperateCode, CancelRsn, cb, 0);

                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + '\r' + '\r' + "如果问题依然存在请联系系统供应商。");
                    return false;
                }
			}
			
			//异步传输信息
			public static bool TransMsg_Async(string msg)
			{
                bool ret=false;
				if (!AllowRemoteOperation)
				{
					ret=false;
				}
				//On Error Goto Errorhandler VBConversions Warning: On Error Goto not supported in C#
				string clientname;
				clientname = "qiantai"; //返回当前电脑名称
				//判断代理是否被创建
				if (svrobj == null)
				{
					//引发错误
					//Err.Raise(8000, "无法创建代理")
					ret=false;
				}
				//代理创建成功
                try
                {
				    AsyncCallback cb;
				    cb = new AsyncCallback(MyCallBack);
				    MyDelegate d;
				    d = new MyDelegate(svrobj.AddtoMsgQue);
				    IAsyncResult ar;
				    ar = d.BeginInvoke(msg, cb, 0);
    				
				    MessageBox.Show("成功");
				    ret=false;
                }
               catch(Exception err)
               {
				    MessageBox.Show(err.Message.ToString());
               }
               return ret;
			}
			
			public static void EnsureQueueExists(string queuePath)
			{
				if (! System.Messaging.MessageQueue.Exists(queuePath))
				{
					System.Messaging.MessageQueue.Create(queuePath);
				}
			}
			
			//直接向远程主机消息队列发送消息
			public static bool TransFood(string FoodCode, string TableType, string Tableno, string PsnCount, string billno, string FoodName, string TypeName, string DeptName, string unit, string quantity, string operandi, string taste, string operatorid, string barcode, int OperateCode, string CancelRsn)
			{
				bool returnValue;
				//OperteCode = 0 传菜 OperteCode = 1 催菜 OperteCode = 2 退菜
				
				returnValue = false;
				string queuePath = ".\\Private$\\RMS"; //可自定义
				EnsureQueueExists(queuePath);
				
				System.Messaging.MessageQueue queue = new System.Messaging.MessageQueue(queuePath);
				queue.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] {typeof(AppExt.CAppExt.FoodInfo)});
				
				AppExt.CAppExt.FoodInfo orderRequest = new AppExt.CAppExt.FoodInfo();
				
				orderRequest.FoodCode = FoodCode;
				orderRequest.TableType = TableType;
				orderRequest.Tableno = Tableno;
				orderRequest.PsnCount = PsnCount;
				orderRequest.Billno = billno;
				orderRequest.FoodName = FoodName;
				orderRequest.TypeName = TypeName;
				orderRequest.DeptName = DeptName;
				orderRequest.unit = unit;
				orderRequest.quantity = quantity;
				orderRequest.operandi = operandi;
				orderRequest.taste = taste;
				orderRequest.operatorid = operatorid;
				orderRequest.BarCode = barcode;
				orderRequest.OperateCode = OperateCode; //OperateCode = 0 传菜 OperateCode = 1 催菜 OperateCode = 2 缓菜 OperateCode = 3 退菜
				orderRequest.CancelRsn = CancelRsn;
				
				queue.Send(orderRequest);
				returnValue = true;
				return returnValue;
			}
			
			public static void MyCallBack(IAsyncResult ar)
			{
                //AsyncResult result = (AsyncResult)ar;
				//MyDelegate d=result.AsyncDelegate;
                //MyDelegate d=new MyDelegate(result.AsyncDelegate);

                MyDelegate d=(MyDelegate)((AsyncResult)ar).AsyncDelegate;
				Console.WriteLine(d.EndInvoke(ar));
				e.Set();
			}
			
			public static void TransFoodCallBack(IAsyncResult ar)
			{
				TransFoodDelegate d =(TransFoodDelegate)((AsyncResult)ar).AsyncDelegate;
				//Console.WriteLine(d.EndInvoke(ar))
				e.Set();
			}
			
			//返回系统设置
			public static string GetSysSetup(string parametercode)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT value FROM syssetup where parametercode='" + parametercode + "'", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					return  dbDS.Tables[0].Rows[0]["value"].ToString();
					
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
			
			//返回报表路径
			public static string GetReportPath()
			{
				//获取报表路径信息
				string ReportPath;
				
				ReportPath = ReadStrfromReg("ReportPath", Directory.GetCurrentDirectory());
				if (ReportPath[ReportPath.Length - 1] != '\'')
				{
					ReportPath += "\\";
				}
				
				return ReportPath;
			}
			
			//程序初始化操作
			static public void InitialApp()
			{
				//读取数据库连接选项
				ConnStr = "workstation id=" + (ReadStrfromReg("Wkst_Id", "") + ";") + "packet size=" + (ReadStrfromReg("pkt_size", "") + ";") + "user id=" + (ReadStrfromReg("SQL_User", "") + ";") + "data source=" + (ReadStrfromReg("SQLServerName", "") + ";") + "persist security info=" + (ReadStrfromReg("ps_info", "") + ";") + "initial catalog=" + (ReadStrfromReg("DataBaseName", "") + ";") + "password=" + ReadStrfromReg("SQL_PSW", "");
				//初始化远程对象 连接RMS远程服务程序
				if (AllowRemoteOperation)
				{
					ConnectSvr();
				}
			}
			
			//返回部门编码
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
					return "";
				}
				finally
				{
					conn.Close();
				}
			}
			
			//获取所有部门，返回DataTable
			public static DataTable LoadDept(bool LoadSecStrg)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					if (LoadSecStrg)
					{
						selectCMD.CommandText = "SELECT * FROM Department where IsSecondarystock='1'";
					}
					else
					{
						selectCMD.CommandText = "SELECT * FROM Department";
					}
					
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
			
			//未结账是否允许删单据和菜品 df
			public static bool AllowDeleteBillFood()
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT count(*) FROM op_acs where operatorid='" + opinfo.OpID + "' and access='df'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (Convert.ToInt32(dbDS1.Tables[0].Rows[0][0]) > 0)
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
			
			//获取桌台类别/位置，返回dataview
			public static DataTable LoadTableType()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM TableType", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "TableTypeList");
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
			
			//获取菜品类别，返回dataview
			public static DataTable LoadFoodType()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM foodtype", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "TableTypeList");
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
			
			//获取操作员，返回dataview
			public static DataTable LoadOperator()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT operatorid FROM operator order by operatorid", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "OperatorList");
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
			
			//获取时间段，返回dataview
			public static DataTable LoadTimeBlock()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT name FROM timeblock", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "TimeBlockList");
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
			
			public static bool EmpIdExists(string empid)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM Employee where " + "EmpID=" + "'" + empid + "'", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (dbDS.Tables[0].Rows.Count > 0) //该雇员存在
					{
						return true;
					}
					else //雇员不存在
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
			
			//检测桌台使用状态
			//0=空闲，1=使用，2=预定中，-1=不存在该桌台 与桌台列表单击事件的返回值不同！
			public static int GetTableStatus(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
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
						return  Convert.ToInt32(dbDS.Tables[0].Rows[0]["status"]);
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
                return 0;
			}
			
			//返回相应桌台类别/位置名称的ID编码
			public static string GetTableTypeCode(string Typename)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT TableTypeCode FROM TableType where name='" + Typename + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					return dbDS1.Tables[0].Rows[0][0].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回桌台的类别/位置名称
			public static string GetTableTypeName(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT tablename FROM view_tablelist where tableno='" + tableno + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					return  dbDS1.Tables[0].Rows[0][0].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回单据类型名称
			public static string GetBillTypeName(string BillTypeCode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT name FROM BillType where billtypecode='" + BillTypeCode + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					return dbDS1.Tables[0].Rows[0][0].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回单据类型编码
			public static string GetBillTypeCode(string BillTypeName)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT BillTypeCode FROM BillType where name='" + BillTypeName + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					return dbDS1.Tables[0].Rows[0][0].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回时间段编码
			public static string GetTimeBlockCode(string timeblock)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT timeblockCode FROM timeblock where name='" + timeblock + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					return dbDS1.Tables[0].Rows[0][0].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//获取相应桌台类别的桌台记录
			public static DataTable LoadTableList(string TableTypeName)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT tableno,tablename,status,begintime FROM TableStatus";
					if (TableTypeName != "全部")
					{
						selectCMD.CommandText = selectCMD.CommandText + " where TabletypeCode='" + GetTableTypeCode(TableTypeName) + "'";
					}
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "TableListView");
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
			
			//返回服务器的全局唯一标识符
			public static string GenUniqueCode()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					System.Data.SqlClient.SqlCommand MysqlProc;
					MysqlProc = new System.Data.SqlClient.SqlCommand();
					MysqlProc.CommandType = CommandType.StoredProcedure;
					MysqlProc.CommandText = "genUNIQUE_ID";
					MysqlProc.Connection = conn;
					
					System.Data.SqlClient.SqlParameter sparam;
					sparam = new System.Data.SqlClient.SqlParameter();
					sparam.ParameterName = "@rtn_id";
					sparam.Size = 50;
					sparam.SqlDbType = SqlDbType.VarChar;
					sparam.Direction = ParameterDirection.Output;
					MysqlProc.Parameters.Add(sparam);
					
					conn.Open();
					MysqlProc.ExecuteNonQuery();
					return sparam.Value.ToString();
					
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
			
			//检测当前客户是否允许签单
			public static bool AllowSignPay(string customercode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT signed FROM customer where customercode='" + customercode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					if (dbDS1.Tables[0].Rows[0][0].ToString() == "1")
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
			
			//检测签单金额是否超过限额
			public static bool CustOverSign(string customercode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT totalcost,payingcost,signupcost FROM customer where customercode='" + customercode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					if ((System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["totalcost"])) - System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["payingcost"]) >= System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["signupcost"]))
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
			
			//检测有无该服务员
			public static bool EmpExists(string empid)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT count(*) FROM employee where empid='" + empid + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					if (Convert.ToInt32(dbDS1.Tables[0].Rows[0][0]) > 0)
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
			
			//开台操作
			public static bool ExeOpenTable(string tableno, int PsnNum, string EmpId)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					conn.Open();
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					SQLCMD.CommandText = "Update tablestatus set status =1,PeopleNumber=" + PsnNum.ToString() + ",begintime='" + DateTime.Now.ToString() + "'" + "  where tableno ='" + tableno + "'";
					SQLCMD.ExecuteNonQuery();
					
					return true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn.Close();
				}
				
				return false;
			}
			
			//检测当前桌台是否存在消费单据
			public static bool TableConsumeBillExists(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT count(*) FROM view_salebill_t where tableno='" + tableno + "' and consumebill='1'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					if (Convert.ToInt32(dbDS1.Tables[0].Rows[0][0]) > 0) //具备消费单据
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
			
			public static bool IsSuitFood(string barcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT count(*) FROM SaleList_t where barcode='" + barcode + "' and suitcode<>''";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (int.Parse(dbDS1.Tables[0].Rows[0][0].ToString()) > 0)
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
			
			//执行加单操作
			public static bool AddSaleBill(string SerialNo, string Tableno, string Billno, string BillTypeCode, string EmpID)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					SQLCMD.CommandText = "insert into salebill_t (serialno,tableno,Billno,billtypecode,empid) " + "values (" + "'" + SerialNo + "'" + "," + "'" + Tableno + "'" + "," + "'" + Billno + "'" + "," + "'" + BillTypeCode + "'" + "," + "'" + EmpID + "'" + ")";
					conn.Open();
					SQLCMD.ExecuteNonQuery();
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
			
			//检测当前单据号和单据类型是否已经存在于当前营业表中
			public static bool SameBillinSale(string billno, string billtypename)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT serialno FROM salebill_all where billno='" + billno + "' and billtypecode='" + GetBillTypeCode(billtypename) + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					if (dbDS1.Tables[0].Rows.Count > 0)
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
			
			//记录开台信息
			public static void AddBalanceTable(string SerialNo, string Tableno, string OpenPsn, string EmpID)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					SQLCMD.CommandText = "insert into BalanceTable_t (serialno,tableno,OpenPsn,empid,begintime) " + "values (" + "'" + SerialNo + "'" + "," + "'" + Tableno + "'" + "," + OpenPsn + "," + "'" + EmpID + "'" + "," + "'" + DateTime.Now.ToString() + "'" + ")";
					conn.Open();
					SQLCMD.ExecuteNonQuery();
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
			
			//返回已开台桌台的开台人数
			public static int GetOpenTablePsn(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT PeopleNumber FROM TableStatus where tableno='" + tableno + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return  Convert.ToInt32(dbDS1.Tables[0].Rows[0][0]);
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return 0;
			}
			
			public static bool UpdateAppointTable(string timeblockcode)
			{
				//检测桌台预订状态并更新 tablestatus 表
				//返回当前日期
				string currentdate;
				currentdate = DateTime.Now.ToShortDateString();
				
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					selectCMD1.CommandText = "SELECT tableno FROM view_AppointTable where status='0' and " + "arrivedate='" + currentdate + "' and timeblockcode='" + timeblockcode + "'";
					
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t1");
					//更新实际桌台状态
					//先清除所有预订标记
					selectCMD1.CommandText = "update tablestatus set status='0' where status='2'";
					selectCMD1.ExecuteNonQuery();
					//遍历所有到期的预订桌台，更新预订标记
					
					//先检测桌台是否正在使用
					for (int i = 0; i <= dbDS1.Tables[0].Rows.Count - 1; i++)
					{
						if (GetTableStatus(dbDS1.Tables[0].Rows[i][0].ToString()) == 1) //正在使用中
						{
							MessageBox.Show("在当前 " + currentdate + " " + GetSysSetup("CurrentTimeblockName") + " 预订到期的 " + dbDS1.Tables[0].Rows[i][0] + " 号桌台正在使用，更新预订操作不能完成！");
							
							return false;
						}
					}
					
					for (int i = 0; i <= dbDS1.Tables[0].Rows.Count - 1; i++)
					{
						selectCMD1.CommandText = "update tablestatus set status='2' where tableno='" + dbDS1.Tables[0].Rows[i][0] + "'";
						selectCMD1.ExecuteNonQuery();
					}
					
					return true;
					
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
			
			//完成预定将预订桌台转为开台
			public static bool CompleteAppoint(string appointno)
			{
				if (MessageBox.Show("确定要完成选中的预定订单，并将预订的桌台状态设为使用吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
					conn.ConnectionString = ConnStr;
					try
					{
						SqlCommand selectCMD = new SqlCommand();
						selectCMD.Connection = conn;
						conn.Open();
						
						string tableno;
						
						selectCMD.CommandText = "update appointbill set status='1' where appointno='" + appointno + "'";
						selectCMD.ExecuteNonQuery();
						
						selectCMD.CommandText = "select tableno from view_appointtable where appointno='" + appointno + "'";
						
						SqlDataAdapter dbDA = new SqlDataAdapter();
						dbDA.SelectCommand = selectCMD;
						DataSet dbDS = new DataSet();
						dbDA.Fill(dbDS, "t1");
						
						//遍历所有当前预订到期的桌台
						//同一桌台使用相同的 serialno 等同于 并台
						string serialno;
						serialno = GenUniqueCode();
						
						for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
						{
							if (GetTableStatus(dbDS.Tables[0].Rows[i][0].ToString()) == 1) //正在使用中
							{
								MessageBox.Show("在当前 " + DateTime.Now.ToShortDateString() + " " + GetSysSetup("CurrentTimeblockName") + " 预订到期的 " + dbDS.Tables[0].Rows[i][0] + " 号桌台正在使用，更新预订操作不能完成！");
								return false;
							}
						}
						
						for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
						{
							tableno = dbDS.Tables[0].Rows[i][0].ToString();
							//打开开台、单据录入窗口
							AddForm addfrm = new AddForm();
							addfrm.Text = "开台/新建单据";
							addfrm.frmmode = 1;
							addfrm.GetConsumeBillTypeList(); //开台新建单据只允许添加消费单据
							addfrm.TextBox3.Text = GetTableMaxPeopleNumber(tableno); //返回桌台最大载客数
							addfrm.Label6.Text = addfrm.BillTypeList[0].ToString();
							addfrm.CurrentBillTypeName = addfrm.BillTypeList[0].ToString();
							addfrm.Label5.Text = "请为 " + tableno + " 号桌台开台并添加消费单据";
							
							addfrm.ShowDialog();
							if (addfrm.DialogResult == DialogResult.OK)
							{
								ExeOpenTable(tableno, int.Parse(addfrm.TextBox3.Text), addfrm.TextBox2.Text);
								//准备添加第一张单据
								if (! SameBillinSale(addfrm.TextBox1.Text, addfrm.CurrentBillTypeName))
								{
									
									AddSaleBill(serialno, tableno, addfrm.TextBox1.Text, GetBillTypeCode(addfrm.CurrentBillTypeName), addfrm.TextBox2.Text);
									AddBalanceTable(serialno, tableno, addfrm.TextBox3.Text, addfrm.TextBox2.Text);
									
									//遍历所有当前预订到期的订单菜品，添加到当前单据及桌台中
									selectCMD.CommandText = "select foodcode,price,quantity,oprandi,taste from view_appointfood where appointno='" + appointno + "'";
									SqlDataAdapter dbDA1 = new SqlDataAdapter();
									dbDA1.SelectCommand = selectCMD;
									DataSet dbDS1 = new DataSet();
									dbDA1.Fill(dbDS1, "t");
									
									for (int j = 0; j <= dbDS1.Tables[0].Rows.Count - 1; j++)
									{
										AddFoodtoBill(serialno, GenUniqueCode(), addfrm.TextBox1.Text, GetBillTypeCode(addfrm.CurrentBillTypeName), dbDS1.Tables[0].Rows[j][0].ToString(), dbDS1.Tables[0].Rows[j][1].ToString(), System.Convert.ToDouble(dbDS1.Tables[0].Rows[j][2]), 0, dbDS1.Tables[0].Rows[j][3].ToString(), dbDS1.Tables[0].Rows[j][4].ToString(), opinfo.OpID, "", 0);
									}
									
								}
								else
								{
									MessageBox.Show("已经存在同类型的单据了");
								}
							}
							else
							{
								return false;
							}
							addfrm.Dispose();
						}
						
						selectCMD.CommandText = "update appointbill set status='1' where appointno='" + appointno + "'";
						selectCMD.ExecuteNonQuery();
						
						MessageBox.Show("预订转开台操作顺利完成！");
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
                return false;
			}
			
			//返回单据类型是否为消费单
			public static bool IsConsumeBill(string billtypecode, string billtypename)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					if (billtypename == "")
					{
						selectCMD1.CommandText = "SELECT ConsumeBill FROM billtype where billtypecode='" + billtypecode + "'";
					}
					else
					{
						selectCMD1.CommandText = "SELECT ConsumeBill FROM billtype where name='" + billtypename + "'";
						
					}
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows[0][0].ToString() == "1")
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
				}
				finally
				{
					conn1.Close();
				}
				return false;
			}
			
			//返回单据类型是否为取消单
			public static bool IsCancelBill(string billtypecode, string billtypename)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					if (billtypename == "")
					{
						selectCMD1.CommandText = "SELECT CancelBill FROM billtype where billtypecode='" + billtypecode + "'";
					}
					else
					{
						selectCMD1.CommandText = "SELECT CancelBill FROM billtype where name='" + billtypename + "'";
						
					}
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows[0][0].ToString() == "1")
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
				}
				finally
				{
					conn1.Close();
				}
				return false;
			}
			
			//返回单据类型是否为赠送单
			public static bool IsPresentBill(string billtypecode, string billtypename)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					if (billtypename == "")
					{
						selectCMD1.CommandText = "SELECT PresentBill FROM billtype where billtypecode='" + billtypecode + "'";
					}
					else
					{
						selectCMD1.CommandText = "SELECT PresentBill FROM billtype where name='" + billtypename + "'";
						
					}
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows[0][0].ToString() == "1")
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
				}
				finally
				{
					conn1.Close();
				}
				return false;
			}
			
			//返回单据类型
			public static string GetBillNoTypeCode(string billno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT billtypecode FROM salebill_t where billno='" + billno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return  dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//执行加菜操作
			public static string AddFoodtoBill(string serialno, string FoodGuid, string BillNo, string billtypecode, string foodcode, string foodprice, double addquantity, double decquantity, string operandi, string taste, string OperatorID, string suitcode, double suitquantity)
			{
				string barcode;
				//检测菜品剩余数量
				double foodremain; //若跟踪菜品数量，该值应该 > 0，若不跟踪 该值为 -1
				
				foodremain = GetFoodRemainQuantity(foodcode);
				
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					System.Data.SqlClient.SqlCommand MysqlProc;
					MysqlProc = new System.Data.SqlClient.SqlCommand();
					MysqlProc.CommandType = CommandType.StoredProcedure;
					MysqlProc.CommandText = "proc_AddFoodtoBill";
					MysqlProc.Connection = conn;
					
					System.Data.SqlClient.SqlParameter sparam1;
					sparam1 = new System.Data.SqlClient.SqlParameter();
					sparam1.ParameterName = "@SerialNo";
					sparam1.Size = 50;
					sparam1.SqlDbType = SqlDbType.VarChar;
					sparam1.Value = serialno;
					MysqlProc.Parameters.Add(sparam1);
					
					System.Data.SqlClient.SqlParameter sparam16;
					sparam16 = new System.Data.SqlClient.SqlParameter();
					sparam16.ParameterName = "@FoodGuid";
					sparam16.Size = 50;
					sparam16.SqlDbType = SqlDbType.VarChar;
					sparam16.Value = FoodGuid;
					MysqlProc.Parameters.Add(sparam16);
					
					System.Data.SqlClient.SqlParameter sparam2;
					sparam2 = new System.Data.SqlClient.SqlParameter();
					sparam2.ParameterName = "@Billno";
					sparam2.Size = 50;
					sparam2.SqlDbType = SqlDbType.VarChar;
					sparam2.Value = BillNo;
					MysqlProc.Parameters.Add(sparam2);
					
					System.Data.SqlClient.SqlParameter sparam3;
					sparam3 = new System.Data.SqlClient.SqlParameter();
					sparam3.ParameterName = "@BillTypeCode";
					sparam3.Size = 10;
					sparam3.SqlDbType = SqlDbType.VarChar;
					sparam3.Value = billtypecode;
					MysqlProc.Parameters.Add(sparam3);
					
					System.Data.SqlClient.SqlParameter sparam4;
					sparam4 = new System.Data.SqlClient.SqlParameter();
					sparam4.ParameterName = "@FoodCode";
					sparam4.Size = 50;
					sparam4.SqlDbType = SqlDbType.VarChar;
					sparam4.Value = foodcode;
					MysqlProc.Parameters.Add(sparam4);
					
					System.Data.SqlClient.SqlParameter sparam12;
					sparam12 = new System.Data.SqlClient.SqlParameter();
					sparam12.ParameterName = "@FoodPrice";
					sparam12.Size = 10;
					sparam12.SqlDbType = SqlDbType.VarChar;
					sparam12.Value = foodprice;
					MysqlProc.Parameters.Add(sparam12);
					
					System.Data.SqlClient.SqlParameter sparam5;
					sparam5 = new System.Data.SqlClient.SqlParameter();
					sparam5.ParameterName = "@Operandi";
					sparam5.Size = 50;
					sparam5.SqlDbType = SqlDbType.VarChar;
					sparam5.Value = operandi;
					MysqlProc.Parameters.Add(sparam5);
					
					System.Data.SqlClient.SqlParameter sparam6;
					sparam6 = new System.Data.SqlClient.SqlParameter();
					sparam6.ParameterName = "@Taste";
					sparam6.Size = 50;
					sparam6.SqlDbType = SqlDbType.VarChar;
					sparam6.Value = taste;
					MysqlProc.Parameters.Add(sparam6);
					
					System.Data.SqlClient.SqlParameter sparam7;
					sparam7 = new System.Data.SqlClient.SqlParameter();
					sparam7.ParameterName = "@AddQuantity";
					//sparam7.Size = 50
					sparam7.SqlDbType = SqlDbType.Float;
					sparam7.Value = addquantity;
					MysqlProc.Parameters.Add(sparam7);
					
					System.Data.SqlClient.SqlParameter sparam8;
					sparam8 = new System.Data.SqlClient.SqlParameter();
					sparam8.ParameterName = "@DecQuantity";
					//sparam8.Size = 50
					sparam8.SqlDbType = SqlDbType.Float;
					sparam8.Value = decquantity;
					MysqlProc.Parameters.Add(sparam8);
					
					System.Data.SqlClient.SqlParameter sparam9;
					sparam9 = new System.Data.SqlClient.SqlParameter();
					sparam9.ParameterName = "@OperatorID";
					sparam9.Size = 50;
					sparam9.SqlDbType = SqlDbType.VarChar;
					sparam9.Value = OperatorID;
					MysqlProc.Parameters.Add(sparam9);
					
					System.Data.SqlClient.SqlParameter sparam10;
					sparam10 = new System.Data.SqlClient.SqlParameter();
					sparam10.ParameterName = "@TimeBlock";
					sparam10.Size = 50;
					sparam10.SqlDbType = SqlDbType.VarChar;
					sparam10.Value = GetSysSetup("CurrentTimeblockName");
					MysqlProc.Parameters.Add(sparam10);
					
					System.Data.SqlClient.SqlParameter sparam14;
					sparam14 = new System.Data.SqlClient.SqlParameter();
					sparam14.ParameterName = "@suitcode";
					sparam14.Size = 50;
					sparam14.SqlDbType = SqlDbType.VarChar;
					sparam14.Value = suitcode;
					MysqlProc.Parameters.Add(sparam14);
					
					System.Data.SqlClient.SqlParameter sparam15;
					sparam15 = new System.Data.SqlClient.SqlParameter();
					sparam15.ParameterName = "@suitquantity";
					sparam15.SqlDbType = SqlDbType.Float;
					sparam15.Value = suitquantity;
					MysqlProc.Parameters.Add(sparam15);
					
					System.Data.SqlClient.SqlParameter sparam13;
					sparam13 = new System.Data.SqlClient.SqlParameter();
					sparam13.ParameterName = "@barcode";
					sparam13.Size = 10;
					sparam13.SqlDbType = SqlDbType.VarChar;
					sparam13.Direction = ParameterDirection.Output;
					//sparam13.Value = barcode
					MysqlProc.Parameters.Add(sparam13);
					
					System.Data.SqlClient.SqlParameter sparam11;
					sparam11 = new System.Data.SqlClient.SqlParameter();
					sparam11.ParameterName = "@OperationCode";
					sparam11.Size = 2;
					sparam11.SqlDbType = SqlDbType.Char;
					
					if (IsCancelBill(GetBillNoTypeCode(BillNo), ""))
					{
						sparam11.Value = -1; //减菜
						
						MysqlProc.Parameters.Add(sparam11);
						
						conn.Open();
						MysqlProc.ExecuteNonQuery();
						
						if (foodremain > -1) //跟踪菜品，将剩余菜品数量加一
						{
							UpdateFoodRemainQuantity(foodcode, decquantity, 1);
						}
						
					}
					else
					{
						sparam11.Value = 1; //加菜
						
						if (foodremain > -1) //检测是否跟踪菜品 跟踪
						{
							if (foodremain >= addquantity) //检测剩余数量是否允许加菜，允许
							{
								MysqlProc.Parameters.Add(sparam11);
								
								conn.Open();
								MysqlProc.ExecuteNonQuery();
								//更新数量
								UpdateFoodRemainQuantity(foodcode, addquantity, 0);
								
							}
							else //菜品剩余数量不够，显示错误
							{
								MessageBox.Show("菜品剩余数量不够，加菜操作不能完成！", "提示", MessageBoxButtons.OK);
								return "";
							}
						}
						else //不跟踪，直接加菜
						{
							MysqlProc.Parameters.Add(sparam11);
							
							conn.Open();
							MysqlProc.ExecuteNonQuery();
						}
						
					}
					barcode = (string) sparam13.Value;
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
			
			//返回服务器自动生成的预定单据号
			public static string GenNewAppointBillNo()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					System.Data.SqlClient.SqlCommand MysqlProc;
					MysqlProc = new System.Data.SqlClient.SqlCommand();
					MysqlProc.CommandType = CommandType.StoredProcedure;
					MysqlProc.CommandText = "NewAppointBillNo";
					MysqlProc.Connection = conn;
					
					System.Data.SqlClient.SqlParameter sparam;
					sparam = new System.Data.SqlClient.SqlParameter();
					sparam.ParameterName = "@BillNo";
					sparam.Size = 50;
					sparam.SqlDbType = SqlDbType.VarChar;
					sparam.Direction = ParameterDirection.Output;
					MysqlProc.Parameters.Add(sparam);
					
					conn.Open();
					MysqlProc.ExecuteNonQuery();
					return sparam.Value.ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn.Close();
				}
                return string.Empty;
			}
			
			//是否为定制菜品
			public static bool IsCustomFood(string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT isunicode FROM foodlist where foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows.Count > 0)
					{
						//检测是否是特价菜或者时价菜
						if (dbDS1.Tables[0].Rows[0][0].ToString() == "1")
						{
							return true;
						}
						else
						{
							return false;
						}
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
			
			//返回菜品是否跟踪及菜品剩余数量
			public static double GetFoodRemainQuantity(string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT remain FROM foodlist where foodcode='" + foodcode + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return  Convert.ToDouble(dbDS1.Tables[0].Rows[0]["remain"]);
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return 0;
			}
			
			//更新菜品剩余数量
			public static void UpdateFoodRemainQuantity(string foodcode, double quantity, int opt)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					if (opt == 1) //加操作
					{
						SQLCMD.CommandText = "update foodlist set remain=remain+" + quantity.ToString() + " where foodcode='" + foodcode + "'";
					}
					else if (opt == 0) //减操作
					{
						SQLCMD.CommandText = "update foodlist set remain=remain-" + quantity.ToString() + " where foodcode='" + foodcode + "'";
					}
					
					conn.Open();
					SQLCMD.ExecuteNonQuery();
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
			
			//返回当前桌台最大载客数
			public static string GetTableMaxPeopleNumber(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT * FROM tablestatus where tableno='" + tableno + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return  dbDS1.Tables[0].Rows[0]["peoplenumber"].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回当前桌台开台时间
			public static string GetTableOpenTime(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT * FROM tablestatus where tableno='" + tableno + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return  dbDS1.Tables[0].Rows[0]["begintime"].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
                return "";
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
			
			//返回当前单据金额
			public static string GetBillPrice1(string tableno, string billno, int billtype)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					//！！单据类型不再区分，price为单价*数量的乘积！！保留代码结构不变。
					if (billtype == 0) //消费单据
					{
						selectCMD.CommandText = "SELECT sum(price) as billtotal FROM saledfoods where tableno='" + tableno + "'" + " and billno='" + billno + "'";
					}
					else //取消单据
					{
						selectCMD.CommandText = "SELECT sum(price) as billtotal FROM saledfoods where tableno='" + tableno + "'" + " and billno='" + billno + "'";
					}
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (dbDS.Tables[0].Rows[0][0].ToString() == "")
					{
                        return string.Format("{0:N2}", 0);
					}
					else
					{
                        return string.Format("{0:N2}", Convert.ToDouble(dbDS.Tables[0].Rows[0][0]));
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
				return "";
			}
			
			private static string GetSuitName(string suitcode)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT suitname FROM suit where suitcode='" + suitcode + "'";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (dbDS.Tables[0].Rows.Count > 0)
					{
						return dbDS.Tables[0].Rows[0][0].ToString();
					}
					else
					{
						return "";
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
				return "";
			}
			
			private static double GetSuitPrice(string suitcode)
			{
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
					if (dbDS.Tables[0].Rows.Count > 0)
					{
						return double.Parse(dbDS.Tables[0].Rows[0][0].ToString());
					}
					else
					{
						return 0;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return 0;
				}
				finally
				{
					conn.Close();
				}
			}
			
			//返回当前单据金额
			public static string GetBillPrice(string tableno, string billno, int billtype)
			{
				//将所有需要结帐的菜品和套餐加入临时表
				//遍历菜品记录
				double TotalFoodPrice = 0;
				double TotalSuitPrice = 0;
				string currenttableserialno;
				currenttableserialno = GetCurrentTableSerialNo(tableno);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					int NormalFoodCount;
					int SuitCount;
					int SuitRecCount;
					int TotalCount;
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					//非套餐菜品
					selectCMD.CommandText = "select billno,billtypecode,billtypename,foodname,unit,add_dec*decquantity+addquantity as quantity,price as totalprice from view_salelist_t where serialno='" + currenttableserialno + "' and billno='" + billno + "' and suitcode=''";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t1");
					NormalFoodCount = dbDS.Tables[0].Rows.Count;
					//返回所有套餐suitcode
					selectCMD.CommandText = "select suitcode,suitquantity from view_salelist_t where serialno='" + currenttableserialno + "' and billno='" + billno + "' and suitcode<>'' group by suitcode,suitquantity ";
					dbDA.SelectCommand = selectCMD;
					dbDA.Fill(dbDS, "t2");
					SuitRecCount = dbDS.Tables["t2"].Rows.Count;
					SuitCount = 0;
					for (int i = 0; i <= dbDS.Tables["t2"].Rows.Count - 1; i++)
					{
						SuitCount = SuitCount + int.Parse(dbDS.Tables["t2"].Rows[i]["suitquantity"].ToString());
					}
					TotalCount = NormalFoodCount + SuitCount;
					selectCMD.CommandText = "delete from salelist_tmp where serialno='" + currenttableserialno + "'";
					selectCMD.ExecuteNonQuery();
					//准备向salelist_tt中添加结帐显示套餐
					for (int i = 0; i <= SuitRecCount - 1; i++)
					{
						selectCMD.CommandText = "insert into salelist_tmp (serialno,billno,billtypecode,billtypename,foodname,unit,quantity,price) values ('" + currenttableserialno + "','" + billno + "','" + GetBillNoTypeCode(billno) + "','" + GetBillTypeName(GetBillNoTypeCode(billno)) + "','" + GetSuitName(dbDS.Tables[1].Rows[i][0].ToString()) + "','份'," + dbDS.Tables[1].Rows[i][1].ToString() + "," + (System.Convert.ToString((System.Convert.ToDouble(dbDS.Tables[1].Rows[i][1])) * GetSuitPrice(dbDS.Tables[1].Rows[i][0].ToString()))) + ")";
						//selectCMD.ExecuteNonQuery()
						TotalSuitPrice = TotalSuitPrice + (System.Convert.ToDouble(dbDS.Tables[1].Rows[i][1])) * GetSuitPrice(dbDS.Tables[1].Rows[i][0].ToString());
					}
					//向salelist_tt中添加结帐显示菜品
					for (int i = 0; i <= NormalFoodCount - 1; i++)
					{
						selectCMD.CommandText = "insert into salelist_tmp (serialno,billno,billtypecode,billtypename,foodname,unit,quantity,price) values ('" + currenttableserialno + "','" + billno + "','" + GetBillNoTypeCode(billno) + "','" + GetBillTypeName(GetBillNoTypeCode(billno)) + "','" + dbDS.Tables[0].Rows[i]["foodname"].ToString() + "','" + dbDS.Tables[0].Rows[i]["unit"].ToString() + "'," + dbDS.Tables[0].Rows[i]["quantity"].ToString() + "," + dbDS.Tables[0].Rows[i]["totalprice"].ToString() + ")";
						//selectCMD.ExecuteNonQuery()
						TotalFoodPrice = TotalFoodPrice + double.Parse(dbDS.Tables[0].Rows[i]["totalprice"].ToString());
					}
					//计算菜品总计
                    return string.Format("{0:N2}", TotalSuitPrice + TotalFoodPrice);
				}
				catch (Exception)
				{
                    return string.Format("{0:N2}", 0);
				}
			}
			
			//返回当前桌台赠送单金额
			public static string GetPresentBillPrice(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					string billno;
					double billtotal = 0;
					
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT * FROM view_salebill_t where tableno='" + tableno + "'";
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "TableBills");
					//当前桌台的所有单据
					for (int i = 0; i <= dbDS.Tables["tablebills"].Rows.Count - 1; i++) //遍历所有单据
					{
						billno = dbDS.Tables["tablebills"].Rows[i]["billno"].ToString();
						if (IsPresentBill(GetBillNoTypeCode(billno), ""))
						{
							billtotal = billtotal + Convert.ToDouble(GetBillPrice(tableno, billno, 0));
						}
					}

                    return string.Format("{0:N2}", billtotal);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn.Close();
				}
			}
			
			//返回当前桌台所有金额
			public static string GetTablePrice(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					string billno;
					double billtotal = 0;
					
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT * FROM view_salebill_t where tableno='" + tableno + "'";
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "TableBills");
					//当前桌台的所有单据
					for (int i = 0; i <= dbDS.Tables["tablebills"].Rows.Count - 1; i++) //遍历所有单据
					{
						billno = dbDS.Tables["tablebills"].Rows[i]["billno"].ToString();
						if (! IsCancelBill(GetBillNoTypeCode(billno), ""))
						{
							//If Not IsPresentBill(GetBillNoTypeCode(billno)) Then '既不是取消单也不是赠送单
							billtotal = billtotal + Convert.ToDouble(GetBillPrice(tableno, billno, 0));
							//End If
						}
						else
						{
							billtotal = billtotal + Convert.ToDouble(GetBillPrice(tableno, billno, 1));
						}
					}

                    return string.Format("{0:N2}", billtotal);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn.Close();
				}
			}
			
			//检测当前已开桌台有无该菜品
			public static bool CurrentTableExistsFood(string tableno, string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT count(*) FROM saledfoods where tableno='" + tableno + "' and foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (Convert.ToInt32(dbDS1.Tables[0].Rows[0][0])> 0) //已经存在
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
			
			//检测当前菜品的允许退菜的数量
			public static double GetCurrentTableAllowCancelFoodQty(string tableno, string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT sum(addquantity) as t1,sum(decquantity) as t2 FROM saledfoods where tableno='" + tableno + "' and foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					
					return (System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["t1"])) - System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["t2"]);
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return 0;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回桌台就餐人数
			public static string GetTablePsnCount(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT peoplenumber FROM tablestatus where tableno='" + tableno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return "1";
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回桌台开台时间
			public static string GetTableBeginTime(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT BeginTime FROM tablestatus where tableno='" + tableno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return DateTime.Now.ToString();
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//更新桌台人数
			public static void UpdateTablePsnCount(string tableno, int count)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					SQLCMD.CommandText = "update TableStatus set peoplenumber=" + count.ToString() + " where tableno='" + tableno + "'";
					conn.Open();
					SQLCMD.ExecuteNonQuery();
					SQLCMD.CommandText = "update BalanceTable_t set Openpsn=" + count.ToString() + " where tableno='" + tableno + "'";
					SQLCMD.ExecuteNonQuery();
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
			
			//返回桌台最低消费金额
			public static string GetTableLowPay(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT lower_pay FROM tablestatus where tableno='" + tableno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
                    return string.Format("{0:N2}", Convert.ToDouble(dbDS1.Tables[0].Rows[0][0]));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回桌台包房/附加费
			public static string GetTableRoomPay(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT foldroom FROM tablestatus where tableno='" + tableno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
                    return string.Format("{0:N2}", Convert.ToDouble(dbDS1.Tables[0].Rows[0][0]));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回当前桌台的服务费
			public static string GetTableServerPay(string tableno, double ConsumePrice)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT server,serverstate,server_pay FROM tablestatus where tableno='" + tableno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					
					bool needserver;
                    needserver = dbDS1.Tables[0].Rows[0]["server"].ToString() == "1" ? true : false;
					
					if (needserver) //需要支付服务费，检查支付类型
					{
						if (Convert.ToInt32(dbDS1.Tables[0].Rows[0]["serverstate"])== 0) //收取固定服务费
						{
                            return string.Format("{0:N2}", System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["server_pay"]));
						}
						else if (Convert.ToInt32(dbDS1.Tables[0].Rows[0]["serverstate"])== 1) //按消费额度收取服务费
						{
                            return string.Format("{0:N2}", (System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["server_pay"])) / 100 * ConsumePrice);
						}
					}
					else
					{
                        return string.Format("{0:N2}", 0);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回当前桌台的超时费
			public static string GetTableOverTimePay(string tableno, double ConsumePrice)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT begintime,overtime,overtimenum,overtimetype,overtimestate,pertype,pertypeprice FROM tablestatus where tableno='" + tableno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					
					bool needpayOvertime;
                    needpayOvertime = dbDS1.Tables[0].Rows[0]["overtime"].ToString() == "1" ? true : false;
					
					if (needpayOvertime) //需要支付超时费，检查支付类型
					{
						//返回开台时间与现在时间的差
						DateTime opentime;
						int difftime;
						if (dbDS1.Tables[0].Rows[0]["begintime"].ToString() == "")
						{
							return "0";
						}
						opentime = Convert.ToDateTime(dbDS1.Tables[0].Rows[0]["begintime"]);
						difftime = DateTime.Now.Subtract(opentime).Hours; //返回小时差
						
						int overtimetype;
						int overtimestate;
						int pertype;
						double overtimenum;
						double pertypeprice;
						
						overtimetype =Convert.ToInt32(dbDS1.Tables[0].Rows[0]["overtimetype"]); //返回超过时限是分钟还是小时 0=分钟 1=小时
						overtimenum = System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["overtimenum"]); //超过时限
						overtimestate = Convert.ToInt32(dbDS1.Tables[0].Rows[0]["overtimestate"]); //支付类型 0=所超时限收取超时费 1=消费百分比收取
						pertype = Convert.ToInt32(dbDS1.Tables[0].Rows[0]["pertype"]);
						pertypeprice = System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["pertypeprice"]);
						
						if (overtimetype == 0) //分钟
						{
							if (difftime * 60 > overtimenum) //超时了 overtimenum 的单位是分钟
							{
								//计算超时费
								if (overtimestate == 0) //收取固定费用
								{
									if (pertype == 0) //加收方法 - 分钟
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime * 60 - overtimenum) * pertypeprice);

                                        return string.Format("{0:N2}", overprice);
									}
									else if (pertype == 1) //小时
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime * 60 - overtimenum) / 60 * pertypeprice);

                                        return string.Format("{0:N2}", overprice);
									}
								}
								else //消费百分比
								{
									if (pertype == 0) //加收方法同超时设置一致 - 分钟
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime * 60 - overtimenum) * ConsumePrice * pertypeprice / 100);

                                        return string.Format("{0:N2}", overprice);
									}
									else if (pertype == 1) //小时
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime * 60 - overtimenum) / 60 * ConsumePrice * pertypeprice / 100);

                                        return string.Format("{0:N2}", overprice);
									}
								}
							}
							else
							{
                                return string.Format("{0:N2}", 0);
							}
						}
						else //小时
						{
							if (difftime > overtimenum) //超时了 overtimenum 的单位是小时
							{
								//计算超时费
								if (overtimestate == 0) //收取固定费用
								{
									if (pertype == 0) //加收方法 - 分钟
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime - overtimenum) * 60 * pertypeprice);
										
										return overprice.ToString();
									}
									else if (pertype == 1) //小时
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime - overtimenum) * pertypeprice);

                                        return string.Format("{0:N2}", overprice);
									}
								}
								else //消费百分比
								{
									if (pertype == 0) //加收方法同超时设置一致 - 分钟
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime - overtimenum) * 60 * ConsumePrice * pertypeprice / 100);
										
										return overprice.ToString();
									}
									else if (pertype == 1) //小时
									{
										double overprice;
										overprice = System.Convert.ToDouble((difftime - overtimenum) * ConsumePrice * pertypeprice / 100);

                                        return string.Format("{0:N2}", overprice);
									}
								}
							}
							else
							{
                                return string.Format("{0:N2}", 0);
							}
						}
					}
					else
					{
                        return string.Format("{0:N2}", 0);
					}
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn1.Close();
				}
                return "";
			}
			
			//返回当前桌台营业全局唯一流水线号
			public static string GetCurrentTableSerialNo(string tableno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT serialno FROM BalanceTable_t where tableno='" + tableno + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows.Count > 0)
					{
						return dbDS1.Tables[0].Rows[0]["serialno"].ToString();
					}
					else
					{
						return GenUniqueCode();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return "0";
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回独立菜品售价
			public static string GetFoodPrice(string foodcode, bool suit)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					if (! suit) //不是获取套餐中的菜品价格
					{
						selectCMD1.CommandText = "SELECT specialfood,specialprice,currentfood,currentprice,price FROM foodlist where foodcode='" + foodcode + "'";
					}
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows.Count > 0)
					{
						//检测是否是特价菜或者时价菜
						if (dbDS1.Tables[0].Rows[0]["specialfood"].ToString() == "1") //是特价菜
						{
                            return string.Format("{0:N2}", System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["specialprice"]));
						}
						else if (dbDS1.Tables[0].Rows[0]["currentfood"].ToString() == "1") //是时价菜
						{
                            return string.Format("{0:N2}", System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["currentprice"]));
						}
						else
						{
                            return string.Format("{0:N2}", System.Convert.ToDouble(dbDS1.Tables[0].Rows[0]["price"]));
						}
					}
					else
					{
                        return string.Format("{0:N2}", 0);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
                    return string.Format("{0:N2}", 0);
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回菜品名称
			public static string GetFoodName(string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT foodname FROM view_FoodList where foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return null;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回菜品类别
			public static string GetFoodTypeName(string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT typename FROM view_FoodList where foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return null;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回菜品所属制作部门
			public static string GetFoodDeptName(string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT deptname FROM view_FoodList where foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return null;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回菜品单位
			public static string GetFoodUnit(string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT unit FROM view_FoodList where foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return null;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回菜品营业条码
			public static string GetSaledFoodBarcode(string billno, string foodcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT barcode FROM SaleList_t where billno='" + billno + "' and foodcode='" + foodcode + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return null;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//删除单据
			public static bool DeleteBill(string tableno, string billno, string delrsn)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					conn.Open();
					//先删除该单据下所有菜品，并记录
					SqlDataAdapter dbDA = new SqlDataAdapter();
					SQLCMD.CommandText = "select foodcode,addquantity,decquantity,barcode from salelist_t where billno='" + billno + "'";
					dbDA.SelectCommand = SQLCMD;
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					//删除单品
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						if (! IsSuitFood(dbDS.Tables[0].Rows[i][3].ToString()))
						{
                            DeleteFood(tableno, billno, dbDS.Tables[0].Rows[i][0].ToString(), System.Convert.ToString((System.Convert.ToDouble(dbDS.Tables[0].Rows[i][1])) - System.Convert.ToDouble(dbDS.Tables[0].Rows[i][2])), "删除单据操作所包含的套餐，单据号：" + billno,dbDS.Tables[0].Rows[i][3].ToString(), false);
						}
					}
					//删除套餐
					SQLCMD.CommandText = "select foodguid,suitcode from salelist_t where billno='" + billno + "' group by foodguid,suitcode";
					dbDA.Fill(dbDS, "t1");
					for (int i = 0; i <= dbDS.Tables[1].Rows.Count - 1; i++)
					{
						DeleteSuit(tableno, billno, "删除单据操作所包含的菜品，单据号：" + billno, dbDS.Tables[0].Rows[i][3].ToString(), false);
					}
					
					SQLCMD.CommandText = "delete from salebill_t where billno='" + billno + "'";
					SQLCMD.ExecuteNonQuery();
					
					SQLCMD.CommandText = "insert into dlst (deletedate,deleteop,deletetype,deletersn,deletecontent) values ('" + DateTime.Now.ToString() + "','" + opinfo.OpID + "','" + "删除单据" + "','" + delrsn + "','" + "单据号：" + billno + "')";
					SQLCMD.ExecuteNonQuery();
					
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
			
			//删除菜品
			public static bool DeleteFood(string tableno, string billno, string foodcode, string quantity, string delrsn, string barcode, bool needprint)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					SQLCMD.CommandText = "delete from salelist_t where " + "barcode='" + barcode + "'";
					conn.Open();
					SQLCMD.ExecuteNonQuery();
					
					SQLCMD.CommandText = "insert into dlst (deletedate,deleteop,deletetype,deletersn,deletecontent) values ('" + DateTime.Now.ToString() + "','" + opinfo.OpID + "','" + "删除菜品" + "','" + delrsn + "','" + "菜品编码：:" + foodcode + ",菜品名称：" + GetFoodName(foodcode) + ",数量：" + quantity + "')";
					SQLCMD.ExecuteNonQuery();
					
					if (needprint) //是否需要远程打印退菜单
					{
						if (TransFood(foodcode, GetTableTypeName(tableno), tableno, GetTablePsnCount(tableno), billno, GetFoodName(foodcode), GetFoodTypeName(foodcode), GetFoodDeptName(foodcode), GetFoodUnit(foodcode), quantity, "", "", opinfo.OpID, barcode, 2, delrsn))
						{
						}
					}
					
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
			
			public static string GetSaledFoodGuid(string barcode)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand("SELECT FoodGuid FROM salelist_t where barcode='" + barcode + "'", conn1);
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
				return "";
			}
			
			//删除套餐
			public static bool DeleteSuit(string tableno, string billno, string delrsn, string barcode, bool needprint)
			{
				//1、根据foodguid从view_salelist_t中返回当前桌台所点套餐suitcode和suitquantity
				string FoodGuid = GetSaledFoodGuid(barcode);
				
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA = new SqlDataAdapter();
				DataSet dbDS = new DataSet();
				try
				{
					selectCMD.Connection = conn;
					selectCMD.CommandText = "select suitcode,suitquantity from view_salelist_t where serialno='" + GetCurrentTableSerialNo(tableno) + "' and billno='" + billno + "' and foodguid='" + FoodGuid + "' group by suitcode,suitquantity ";
					selectCMD.CommandTimeout = 30;
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					dbDA.Fill(dbDS, "t1");
				}
				catch (Exception)
				{
					conn.Close();
					return false;
				}
				
				string suitcode = dbDS.Tables["t1"].Rows[0][0].ToString();
				double suitquantity = double.Parse(dbDS.Tables["t1"].Rows[0][1].ToString());
				
				//检测suitquantity值，若=1则删除营业菜品中当前serialno下的suitcode的记录
				//若>1则更新当前serialno下的suitcode下的suitquantity=suitquantity-1
				if (suitquantity == 1)
				{
					selectCMD.CommandText = "delete from salelist_t where suitcode='" + suitcode + "' and foodguid='" + FoodGuid + "' and serialno='" + GetCurrentTableSerialNo(tableno) + "'";
					selectCMD.ExecuteNonQuery();
				}
				else
				{
					selectCMD.CommandText = "update salelist_t set suitquantity=suitquantity-1 where suitcode='" + suitcode + "' and foodguid='" + FoodGuid + "' and serialno='" + GetCurrentTableSerialNo(tableno) + "'";
					selectCMD.ExecuteNonQuery();
					selectCMD.CommandText = "delete from salelist_t where suitcode='" + suitcode + "' and foodguid='" + FoodGuid + "' and serialno='" + GetCurrentTableSerialNo(tableno) + "'";
					selectCMD.ExecuteNonQuery();
				}
				selectCMD.CommandText = "insert into dlst (deletedate,deleteop,deletetype,deletersn,deletecontent) values (" + "'" + DateTime.Now.ToString() + "'" + "," + "'" + opinfo.OpID + "'" + "," + "'" + "删除套餐" + "'" + "," + "'" + delrsn + "'" + "," + "'" + "套餐编码：:" + suitcode + ",数量：" + suitquantity.ToString() + "'" + ")";
				selectCMD.ExecuteNonQuery();
				return false;
			}
			
			//返回结账方式编码
			public static string GetPayTypeCode(string paytypename)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT paytypecode FROM paytype where name='" + paytypename + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return null;
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回已点消费单据中菜品的优惠金额
			public static string UpdateAndGetSaledFoodDiscountPrice(string tableno)
			{
				double DiscountPrice = 0;
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT * FROM saledfoods where tableno='" + tableno + "'";
					
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					for (int i = 0; i <= dbDS1.Tables["t"].Rows.Count - 1; i++)
					{
                        if (IsConsumeBill(dbDS1.Tables["t"].Rows[i]["billtypecode"].ToString(), "")) //确定统计的是消费单
						{
							string deptcode;
							string foodcode;
							double foodprice;
                            foodcode = dbDS1.Tables["t"].Rows[i]["foodcode"].ToString();
							foodprice = System.Convert.ToDouble(dbDS1.Tables["t"].Rows[i]["price"]);
                            deptcode = dbDS1.Tables["t"].Rows[i]["depcode"].ToString(); //返回当前菜品所属部门
							selectCMD1.CommandText = "select * from view_discount where deptcode='" + deptcode + "'" + " and disabled='0'";
							dbDA1.Fill(dbDS1, "t1");
							if (dbDS1.Tables["t1"].Rows.Count > 0)
							{
								double discountrate;
								discountrate = System.Convert.ToDouble(dbDS1.Tables["t1"].Rows[0]["discountrate"]);
								//更新每条菜品折扣率
								selectCMD1.CommandText = "update salelist_t set discountrate=" + discountrate.ToString() + " where foodcode='" + foodcode + "'";
								selectCMD1.ExecuteNonQuery();
								DiscountPrice = DiscountPrice + foodprice * (1 - discountrate / 100);
							}
							dbDS1.Tables["t1"].Rows.Clear();
						}
					}
                    return string.Format("{0:N2}", DiscountPrice);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn1.Close();
				}
				return "";
			}
			
			//更新菜品传送标志
			public static void UpdateFoodTransSign(string barcode)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					SqlCommand SQLCMD = new SqlCommand();
					SQLCMD.Connection = conn;
					SQLCMD.CommandTimeout = 30;
					SQLCMD.CommandText = "update salelist_t set transfered='1' where barcode='" + barcode + "'";
					conn.Open();
					SQLCMD.ExecuteNonQuery();
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
			
			//检测是否抹零
			public static bool FixCost()
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT value FROM syssetup where parametercode='autotmpcost'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows[0][0].ToString() == "1") //自动抹零
					{
						return true;
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
				return false;
			}
			
			//返回会员卡固定打折率
			public static string GetClubDiscountrate(string clubcardno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT discountrate FROM clubcard where clubcardno='" + clubcardno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return "0";
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回会员卡累计折扣率
			public static string GetClubAddUpDiscountrate(string clubcardno)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					//先返回累计消费额
					selectCMD1.CommandText = "SELECT totalcost,discountrate FROM clubcard where clubcardno='" + clubcardno + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					double cardtotalcost;
					double carddiscountrate;
					cardtotalcost = System.Convert.ToDouble(dbDS1.Tables[0].Rows[0][0]);
					carddiscountrate = System.Convert.ToDouble(dbDS1.Tables[0].Rows[0][1]);
					
					//返回开始折扣的累计金额
					selectCMD1.CommandText = "SELECT cost,discountrate FROM ClubAddUpDisc where cost< =" + cardtotalcost.ToString();
					dbDA1.Fill(dbDS1, "t1");
					if (dbDS1.Tables[1].Rows.Count > 0) //达到累计折扣
					{
						return dbDS1.Tables[1].Rows[0][1].ToString();
					}
					else
					{
						return dbDS1.Tables[0].Rows[0][1].ToString();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return "0";
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//返回客户名称编码
			public static string GetCustomerCode(string Customername)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT customercode FROM customer where customername='" + Customername + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					return dbDS1.Tables[0].Rows[0][0].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return "0";
				}
				finally
				{
					conn1.Close();
				}
			}
			
			//检测该雇员是否是管理人员，具备审批权
			public static bool ExistsMngr(string empname)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					selectCMD1.CommandText = "SELECT manager FROM employee where name='" + empname + "'";
					selectCMD1.CommandTimeout = 30;
					SqlDataAdapter dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD1;
					conn1.Open();
					DataSet dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows.Count > 0)
					{
						if (dbDS1.Tables[0].Rows[0][0].ToString() == "1")
						{
							return true;
						}
						else
						{
							return false;
						}
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
			
			//结账操作 - '向支付表中添加记录 总金额
			public static bool AddToBalance(string tableno, string FoodCost, string DiscountCost, string ServerCost, string AddCost, string OvertimeCost, string OddCost, string PresentCost, string NeedCost, string DerateCost, string BalanceCost, string DerateRsn, string DerateMngr)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					selectCMD1.CommandText = "insert into balance (serialno,tableno,begintime,paytime,foodcost,DiscountCost," + "ServerCost,AddCost,OvertimeCost,OddCost,PresentCost,NeedCost," + "DerateCost,BalanceCost,DerateRsn,DerateMngr,operator,timeblockcode) values (" + "'" + GetCurrentTableSerialNo(tableno) + "'" + "," + "'" + tableno + "'" + "," + "'" + GetTableOpenTime(tableno) + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + FoodCost + "," + DiscountCost + "," + ServerCost + "," + AddCost + "," + OvertimeCost + "," + OddCost + "," + PresentCost + "," + NeedCost + "," + DerateCost + "," + BalanceCost + "," + "'" + DerateRsn + "'" + "," + "'" + DerateMngr + "'" + "," + "'" + opinfo.OpID + "'" + "," + "'" + GetTimeBlockCode(GetSysSetup("CurrentTimeblockName")) + "'" + ")";
					
					selectCMD1.CommandTimeout = 30;
					conn1.Open();
					selectCMD1.ExecuteNonQuery();
					return true;
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
			
			//结账操作 - '向支付类型表中添加记录 各类型金额
			public static bool AddToBalanceType(string serialno, string PayTypeCode, string PayedCost, string BankName, string BankAccount, string CustomerCode, string Sign_Payed, string clubcardno, string discountrate)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					selectCMD1.CommandText = "insert into balancetype (serialno,PayTypeCode,PayedCost,BankName," + "BankAccount,CustomerCode," + "Sign_Payed,clubcardno,discountrate) values (" + "'" + serialno + "'" + "," + "'" + PayTypeCode + "'" + "," + PayedCost + "," + "'" + BankName + "'" + "," + "'" + BankAccount + "'" + "," + "'" + CustomerCode + "'" + "," + "'" + Sign_Payed + "'" + "," + "'" + clubcardno + "'" + "," + discountrate + ")";
					
					selectCMD1.CommandTimeout = 30;
					conn1.Open();
					selectCMD1.ExecuteNonQuery();
					return true;
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
			
			//结账操作 - '更新 Customer 表签单金额
			public static bool UpdateCustomerSignPay(string CustomerCode, string PayedCost)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					selectCMD1.CommandText = "update customer set totalcost=totalcost+" + PayedCost + " where customercode='" + CustomerCode + "'";
					
					selectCMD1.CommandTimeout = 30;
					conn1.Open();
					selectCMD1.ExecuteNonQuery();
					return true;
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
			
			//结账操作 - '更新 clubcard 表刷卡金额
			public static bool UpdateClubCardPay(string ClubCardno, string PayedCost)
			{
				System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
				conn1.ConnectionString = ConnStr;
				try
				{
					SqlCommand selectCMD1 = new SqlCommand();
					selectCMD1.Connection = conn1;
					
					selectCMD1.CommandText = "update clubcard set totalcost=totalcost+" + PayedCost + ",remaincost=remaincost-" + PayedCost + " where clubcardno='" + ClubCardno + "'";
					
					selectCMD1.CommandTimeout = 30;
					conn1.Open();
					selectCMD1.ExecuteNonQuery();
					return true;
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
			
			//返回服务器自动生成的前台单据号
			public static string GenNewBalanceBillNo()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = ConnStr;
				try
				{
					System.Data.SqlClient.SqlCommand MysqlProc;
					MysqlProc = new System.Data.SqlClient.SqlCommand();
					MysqlProc.CommandType = CommandType.StoredProcedure;
					MysqlProc.CommandText = "NewBalanceBillNo";
					MysqlProc.Connection = conn;
					
					System.Data.SqlClient.SqlParameter sparam;
					sparam = new System.Data.SqlClient.SqlParameter();
					sparam.ParameterName = "@BillNo";
					sparam.Size = 50;
					sparam.SqlDbType = SqlDbType.VarChar;
					sparam.Direction = ParameterDirection.Output;
					MysqlProc.Parameters.Add(sparam);
					
					conn.Open();
					MysqlProc.ExecuteNonQuery();
					return  sparam.Value.ToString();
					
				}
				catch (Exception)
				{
					//MessageBox.Show(ex.ToString)
				}
				finally
				{
					conn.Close();
				}
                return "";
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
	
	
}
