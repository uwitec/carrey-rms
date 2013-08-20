using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
using System.IO;

//文档自述

//汇总统计模块 DecisionApp.exe
//该项目需要水晶报表的支持(Crystal Report)
//查询和统计一定时间范围内的营业信息、库存信息和成本利润信息


namespace DecisionApp
{
	public class mainform : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new mainform());
		}
		
		#region  Windows 窗体设计器生成的代码
		
		public mainform()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化

            rms_var.InitialApp();
		}
		
		//窗体重写 dispose 以清理组件列表。
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.MainMenu MainMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.MenuItem MenuItem4;
		internal System.Windows.Forms.MenuItem MenuItem5;
		internal System.Windows.Forms.MenuItem MenuItem6;
		internal System.Windows.Forms.MenuItem MenuItem7;
		internal System.Windows.Forms.MenuItem MenuItem9;
		internal System.Windows.Forms.StatusBar StatusBar1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel5;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel6;
		internal System.Windows.Forms.MenuItem MenuItem11;
		internal System.Windows.Forms.MenuItem MenuItem12;
		internal System.Windows.Forms.MenuItem MenuItem13;
		internal System.Windows.Forms.MenuItem MenuItem14;
		internal System.Windows.Forms.MenuItem MenuItem15;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ToolBarButton ToolBarButton13;
		internal System.Windows.Forms.ToolBarButton ToolBarButton14;
		internal System.Windows.Forms.ToolBarButton ToolBarButton15;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Timers.Timer Timer1;
		internal System.Windows.Forms.MenuItem mnuAbout;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(mainform_Load);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mainform));
			this.MainMenu1 = new System.Windows.Forms.MainMenu();
			this.MenuItem1 = new System.Windows.Forms.MenuItem();
			this.MenuItem2 = new System.Windows.Forms.MenuItem();
			this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
			this.MenuItem3 = new System.Windows.Forms.MenuItem();
			this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
			this.MenuItem4 = new System.Windows.Forms.MenuItem();
			this.MenuItem5 = new System.Windows.Forms.MenuItem();
			this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
			this.MenuItem11 = new System.Windows.Forms.MenuItem();
			this.MenuItem12 = new System.Windows.Forms.MenuItem();
			this.MenuItem12.Click += new System.EventHandler(this.MenuItem12_Click);
			this.MenuItem13 = new System.Windows.Forms.MenuItem();
			this.MenuItem13.Click += new System.EventHandler(this.MenuItem13_Click);
			this.MenuItem14 = new System.Windows.Forms.MenuItem();
			this.MenuItem14.Click += new System.EventHandler(this.MenuItem14_Click);
			this.MenuItem15 = new System.Windows.Forms.MenuItem();
			this.MenuItem15.Click += new System.EventHandler(this.MenuItem15_Click);
			this.MenuItem6 = new System.Windows.Forms.MenuItem();
			this.MenuItem7 = new System.Windows.Forms.MenuItem();
			this.MenuItem7.Click += new System.EventHandler(this.MenuItem7_Click);
			this.MenuItem9 = new System.Windows.Forms.MenuItem();
			this.mnuAbout = new System.Windows.Forms.MenuItem();
			this.mnuAbout.Click += new System.EventHandler(this.MenuItem10_Click);
			this.StatusBar1 = new System.Windows.Forms.StatusBar();
			this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			this.StatusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
			this.StatusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
			this.StatusBarPanel6 = new System.Windows.Forms.StatusBarPanel();
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.Timer1 = new System.Timers.Timer();
			this.Timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel4).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel5).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel6).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Timer1).BeginInit();
			this.SuspendLayout();
			//
			//MainMenu1
			//
			this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem1, this.MenuItem11, this.MenuItem6});
			//
			//MenuItem1
			//
			this.MenuItem1.Index = 0;
			this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem2, this.MenuItem3, this.MenuItem4, this.MenuItem5});
			this.MenuItem1.Text = "系统(&S)";
			//
			//MenuItem2
			//
			this.MenuItem2.Index = 0;
			this.MenuItem2.Text = "更改个人密码 (&1)";
			//
			//MenuItem3
			//
			this.MenuItem3.Index = 1;
			this.MenuItem3.Text = "注销/重新登录 (&2)";
			//
			//MenuItem4
			//
			this.MenuItem4.Index = 2;
			this.MenuItem4.Text = "-";
			//
			//MenuItem5
			//
			this.MenuItem5.Index = 3;
			this.MenuItem5.Text = "退出(&Q)";
			//
			//MenuItem11
			//
			this.MenuItem11.Index = 1;
			this.MenuItem11.MdiList = true;
			this.MenuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem12, this.MenuItem13, this.MenuItem14, this.MenuItem15});
			this.MenuItem11.Text = "窗口(&W)";
			//
			//MenuItem12
			//
			this.MenuItem12.Index = 0;
			this.MenuItem12.Text = "排列 (&A)";
			//
			//MenuItem13
			//
			this.MenuItem13.Index = 1;
			this.MenuItem13.Text = "层叠 (&C)";
			//
			//MenuItem14
			//
			this.MenuItem14.Index = 2;
			this.MenuItem14.Text = "水平平铺 (&H)";
			//
			//MenuItem15
			//
			this.MenuItem15.Index = 3;
			this.MenuItem15.Text = "垂直平铺 (&V)";
			//
			//MenuItem6
			//
			this.MenuItem6.Index = 2;
			this.MenuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem7, this.MenuItem9, this.mnuAbout});
			this.MenuItem6.Text = "帮助(&H)";
			//
			//MenuItem7
			//
			this.MenuItem7.Index = 0;
			this.MenuItem7.Text = "帮助主题";
			//
			//MenuItem9
			//
			this.MenuItem9.Index = 1;
			this.MenuItem9.Text = "-";
			//
			//mnuAbout
			//
			this.mnuAbout.Index = 2;
			this.mnuAbout.Text = "关于";
			//
			//StatusBar1
			//
			this.StatusBar1.Location = new System.Drawing.Point(0, 427);
			this.StatusBar1.Name = "StatusBar1";
			this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {this.StatusBarPanel2, this.StatusBarPanel3, this.StatusBarPanel4, this.StatusBarPanel5, this.StatusBarPanel6});
			this.StatusBar1.ShowPanels = true;
			this.StatusBar1.Size = new System.Drawing.Size(696, 22);
			this.StatusBar1.TabIndex = 9;
			this.StatusBar1.Text = "StatusBar1";
			//
			//StatusBarPanel2
			//
			this.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.StatusBarPanel2.Text = "StatusBarPanel2";
			this.StatusBarPanel2.Width = 107;
			//
			//StatusBarPanel3
			//
			this.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.StatusBarPanel3.Text = "StatusBarPanel3";
			this.StatusBarPanel3.Width = 107;
			//
			//StatusBarPanel4
			//
			this.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.StatusBarPanel4.Text = "StatusBarPanel4";
			this.StatusBarPanel4.Width = 107;
			//
			//StatusBarPanel5
			//
			this.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.StatusBarPanel5.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.StatusBarPanel5.Width = 252;
			//
			//StatusBarPanel6
			//
			this.StatusBarPanel6.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.StatusBarPanel6.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.StatusBarPanel6.Text = "StatusBarPanel6";
			this.StatusBarPanel6.Width = 107;
			//
			//ToolBar1
			//
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton4, this.ToolBarButton5, this.ToolBarButton6, this.ToolBarButton7, this.ToolBarButton8, this.ToolBarButton9, this.ToolBarButton10, this.ToolBarButton11, this.ToolBarButton12, this.ToolBarButton13, this.ToolBarButton14, this.ToolBarButton15});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(58, 55);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(696, 61);
			this.ToolBar1.TabIndex = 11;
			//
			//ToolBarButton1
			//
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Text = "营业报表";
			//
			//ToolBarButton2
			//
			this.ToolBarButton2.ImageIndex = 1;
			this.ToolBarButton2.Text = "结帐汇总";
			//
			//ToolBarButton3
			//
			this.ToolBarButton3.ImageIndex = 2;
			this.ToolBarButton3.Text = "收款汇总";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 3;
			this.ToolBarButton5.Text = "菜品销售";
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.ImageIndex = 4;
			this.ToolBarButton6.Text = "返台率";
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 5;
			this.ToolBarButton7.Text = "厅堂汇总";
			//
			//ToolBarButton8
			//
			this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton9
			//
			this.ToolBarButton9.ImageIndex = 6;
			this.ToolBarButton9.Text = "销售报表";
			//
			//ToolBarButton10
			//
			this.ToolBarButton10.ImageIndex = 7;
			this.ToolBarButton10.Text = "消耗报表";
			//
			//ToolBarButton11
			//
			this.ToolBarButton11.ImageIndex = 8;
			this.ToolBarButton11.Text = "利润汇总";
			//
			//ToolBarButton12
			//
			this.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton13
			//
			this.ToolBarButton13.ImageIndex = 9;
			this.ToolBarButton13.Text = "关于";
			//
			//ToolBarButton14
			//
			this.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton15
			//
			this.ToolBarButton15.ImageIndex = 10;
			this.ToolBarButton15.Text = "退出";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(30, 30);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 480000;
			this.Timer1.SynchronizingObject = this;
			//
			//mainform
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(696, 449);
			this.Controls.Add(this.ToolBar1);
			this.Controls.Add(this.StatusBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.IsMdiContainer = true;
			this.Menu = this.MainMenu1;
			this.Name = "mainform";
			this.Text = " - 汇总统计";
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel4).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel5).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StatusBarPanel6).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Timer1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//显示营业报表
		public void ShowYybb()
		{
			if (rms_var.frm_Yybb == null)
			{
				rms_var.frm_Yybb = new frmYYBB();
				rms_var.frm_Yybb.MdiParent = rms_var.mainfrm;
				rms_var.frm_Yybb.Show();
			}
			else
			{
				if (rms_var.frm_Yybb.WindowState != FormWindowState.Minimized)
				{
					rms_var.frm_Yybb.BringToFront();
				}
				else
				{
					rms_var.frm_Yybb.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 结帐查询
		public void ShowBalanceQry()
		{
			if (rms_var.frmblncqry == null)
			{
				rms_var.frmblncqry = new frmBalanceQry();
				rms_var.frmblncqry.MdiParent = rms_var.mainfrm;
				rms_var.frmblncqry.Show();
			}
			else
			{
				if (rms_var.frmblncqry.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmblncqry.BringToFront();
				}
				else
				{
					rms_var.frmblncqry.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 收款/结帐类别查询
		public void ShowBalanceTypeQry()
		{
			if (rms_var.frmblnctypqry == null)
			{
				rms_var.frmblnctypqry = new frmBalanceTypeQry();
				rms_var.frmblnctypqry.MdiParent = rms_var.mainfrm;
				rms_var.frmblnctypqry.Show();
			}
			else
			{
				if (rms_var.frmblnctypqry.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmblnctypqry.BringToFront();
				}
				else
				{
					rms_var.frmblnctypqry.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 菜品销售报表
		public void ShowFoodSaleRpt()
		{
			if (rms_var.frmRptFoodSale == null)
			{
				rms_var.frmRptFoodSale = new frmFoodSale();
				rms_var.frmRptFoodSale.MdiParent = rms_var.mainfrm;
				rms_var.frmRptFoodSale.Show();
			}
			else
			{
				if (rms_var.frmRptFoodSale.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmRptFoodSale.BringToFront();
				}
				else
				{
					rms_var.frmRptFoodSale.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 桌台使用率报表
		public void ShowTableUseFreqRpt()
		{
			if (rms_var.frmTblUseFreq == null)
			{
				rms_var.frmTblUseFreq = new frmTableUseFreq();
				rms_var.frmTblUseFreq.MdiParent = rms_var.mainfrm;
				rms_var.frmTblUseFreq.Show();
			}
			else
			{
				if (rms_var.frmTblUseFreq.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmTblUseFreq.BringToFront();
				}
				else
				{
					rms_var.frmTblUseFreq.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 厅堂使用率收入报表
		public void ShowTableTypeRpt()
		{
			if (rms_var.frmTblType == null)
			{
				rms_var.frmTblType = new frmTableType();
				rms_var.frmTblType.MdiParent = rms_var.mainfrm;
				rms_var.frmTblType.Show();
			}
			else
			{
				if (rms_var.frmTblType.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmTblType.BringToFront();
				}
				else
				{
					rms_var.frmTblType.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 部门销售统计报表
		public void ShowDeptSaleRpt()
		{
			if (rms_var.frmDeptSl == null)
			{
				rms_var.frmDeptSl = new frmDeptSale();
				rms_var.frmDeptSl.MdiParent = rms_var.mainfrm;
				rms_var.frmDeptSl.Show();
			}
			else
			{
				if (rms_var.frmDeptSl.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmDeptSl.BringToFront();
				}
				else
				{
					rms_var.frmDeptSl.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 部门消耗统计报表
		public void ShowDeptCostRpt()
		{
			if (rms_var.frmDeptcst == null)
			{
				rms_var.frmDeptcst = new frmDeptCost();
				rms_var.frmDeptcst.MdiParent = rms_var.mainfrm;
				rms_var.frmDeptcst.Show();
			}
			else
			{
				if (rms_var.frmDeptcst.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmDeptcst.BringToFront();
				}
				else
				{
					rms_var.frmDeptcst.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示 部门毛利润报表
		public void ShowDeptStatRpt()
		{
			if (rms_var.frmDeptSt == null)
			{
				rms_var.frmDeptSt = new frmDeptStat();
				rms_var.frmDeptSt.MdiParent = rms_var.mainfrm;
				rms_var.frmDeptSt.Show();
			}
			else
			{
				if (rms_var.frmDeptSt.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmDeptSt.BringToFront();
				}
				else
				{
					rms_var.frmDeptSt.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//主窗口启动，首先打开登录窗口，并验证登录信息
		private void mainform_Load(System.Object sender, System.EventArgs e)
		{
			rms_var.mainfrm = this;
			//创建类库对象的实例，只创建这一次
			rms_var.TheAppExt = new AppExt.CAppExt();
			this.Text = rms_var.TheAppExt.GetAppTitle + this.Text;
			mnuAbout.Text = "关于 " + rms_var.TheAppExt.GetAppTitle;
			
			rms_var.TheAppExt.LogModule = 4; //报告登录的是->汇总统计模块
			string rtn = rms_var.TheAppExt.ShowLogForm("汇总统计"); //显示登录窗口，验证过程在类库 CAppExt.dll 中进行
			if (rtn.Trim()== "-1")
			{
				Application.Exit();
			}
			else
			{
				rms_var.ConnStr = rms_var.TheAppExt.GetConnStr; //复制远程连接字符串
				if (rms_var.GetCurrentTableNoBillsCount("") >= 200)
				{
					return;
				}
				rms_var.ReceiveOperatorInfo(rtn);
				this.WindowState = FormWindowState.Maximized;
				
				StatusBar1.Panels[0].Text = "登录用户ID：" + rms_var.opinfo.OpID;
				StatusBar1.Panels[1].Text = "姓名：" + rms_var.opinfo.EmployeeName;
				StatusBar1.Panels[2].Text = "所属部门：" + rms_var.opinfo.Department;
				StatusBar1.Panels[4].Text = "登录时间：" + DateTime.Now.ToString();
			}
		}
		
		//显示about窗口，传送appid报告是哪一模块需要调用about窗口
		private void MenuItem10_Click(System.Object sender, System.EventArgs e)
		{
			System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
			string ver;
			
			ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
			
			rms_var.TheAppExt.ShowAboutForm(ver, "19ea"); //报告当前模块为 汇总统计
		}
		
		//更新当前操作员帐号的密码
		private void MenuItem2_Click(System.Object sender, System.EventArgs e)
		{
			frmEditPsw frmeditpassword = new frmEditPsw();
			frmeditpassword.ShowDialog();
			if (frmeditpassword.DialogResult == DialogResult.OK)
			{
				//更新当前操作员帐号的密码
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "update Operator set " + "password='" + rms_var.MD5Crypt(frmeditpassword.TextBox1.Text) + "' " + "where operatorid='" + rms_var.opinfo.OpID + "'";
					selectCMD.CommandTimeout = 30;
					conn.Open();
					selectCMD.ExecuteNonQuery();
					MessageBox.Show("密码修改成功！");
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
		}
		
		//注销当前登录用户，并重新打开登录窗口
		private void MenuItem3_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("确定要注销当前登录的用户，并且重新登录系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				//关闭所有mdi子窗口
				Form childform;
				for (int i = 0; i <= this.MdiChildren.Length - 1; i++)
				{
					childform = this.MdiChildren[0];
					if (childform != null)
					{
						childform.Close();
					}
				}
				
				rms_var.TheAppExt.LogModule = 4; //报告登录的是->汇总统计模块
				string rtn = rms_var.TheAppExt.ShowLogForm("汇总统计");
				if (rtn.Trim() =="-1")
				{
                    Application.Exit();
				}
				else
				{
					rms_var.ReceiveOperatorInfo(rtn);
					this.WindowState = FormWindowState.Maximized;
					
					StatusBar1.Panels[0].Text = "登录用户ID：" + rms_var.opinfo.OpID;
					StatusBar1.Panels[1].Text = "姓名：" + rms_var.opinfo.EmployeeName;
					StatusBar1.Panels[2].Text = "所属部门：" + rms_var.opinfo.Department;
					StatusBar1.Panels[4].Text = "登录时间：" + DateTime.Now.ToString();
				}
			}
		}
		
		//结束当前程序
		private void MenuItem5_Click(System.Object sender, System.EventArgs e)
		{
            Application.Exit();
		}
		
		//工具栏按钮事件
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //营业报表
					ShowYybb();
					break;
				case 1: //结帐查询
					ShowBalanceQry();
					break;
				case 2: //收款/结帐类别查询
					ShowBalanceTypeQry();
					break;
				case 4: // 菜品销售
					ShowFoodSaleRpt();
					break;
				case 5: // 桌台使用率
					ShowTableUseFreqRpt();
					break;
				case 6: //厅堂使用收入汇总
					ShowTableTypeRpt();
					break;
					
				case 8: //部门销售统计汇总
					ShowDeptSaleRpt();
					break;
				case 9: //部门消耗统计汇总
					ShowDeptCostRpt();
					break;
				case 10: //部门毛利润汇总
					ShowDeptStatRpt();
					break;
				case 12: //关于
					MenuItem10_Click(sender, e);
					break;
				case 14:
					this.Close();
					break;
					
			}
		}
		
		//随机终止应用程序
		private void Timer1_Elapsed(System.Object sender, System.Timers.ElapsedEventArgs e)
		{
			//Timer1.Enabled = False
			
			//Dim MyValue As Integer
			//Randomize()
			//MyValue = CInt(Int((9 * Rnd()) + 1)) Mod 2
			
			//If MyValue = 1 Then
			//Me.Enabled = False
			//MsgBox("当前系统为试用版本，请向软件供应商索取正式版本。")
			//Me.Close()
			//End If
			
			//Timer1.Enabled = True
		}
		
		private void MenuItem12_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
		}
		
		private void MenuItem13_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}
		
		private void MenuItem14_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}
		
		private void MenuItem15_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}
		
		private void MenuItem7_Click(System.Object sender, System.EventArgs e)
		{
			string CurrentPath;
			
			CurrentPath = Directory.GetCurrentDirectory();
			if (CurrentPath[CurrentPath.Length - 1] != '\\')
			{
				CurrentPath += "\\";
			}
			
			try
			{
				System.Diagnostics.Process.Start(rms_var.GetAppPath() + "Help.chm");
			}
			catch (Exception)
			{
				MessageBox.Show("启动帮助文档出现错误，没有找到帮助文件！");
			}
		}
	}
	
}
