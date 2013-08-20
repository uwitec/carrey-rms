using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;


namespace DeskApp
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

        private System.ComponentModel.IContainer components;

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.MainMenu MainMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.ContextMenu cmTableListView;
		internal System.Windows.Forms.MenuItem MenuItem4;
		internal System.Windows.Forms.MenuItem MenuItem5;
		internal System.Windows.Forms.MenuItem MenuItem6;
		internal System.Windows.Forms.MenuItem MenuItem7;
		internal System.Windows.Forms.MenuItem MenuItem8;
		internal System.Windows.Forms.StatusBar StatusBar1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel5;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.MenuItem MenuItem9;
		internal System.Windows.Forms.MenuItem MenuItem10;
		internal System.Windows.Forms.MenuItem MenuItem11;
		internal System.Windows.Forms.MenuItem MenuItem12;
		internal System.Windows.Forms.MenuItem MenuItem13;
		internal System.Windows.Forms.MenuItem MenuItem14;
		internal System.Windows.Forms.MenuItem MenuItem15;
		internal System.Windows.Forms.MenuItem MenuItem19;
		internal System.Windows.Forms.MenuItem MenuItem22;
		internal System.Windows.Forms.MenuItem MenuItem24;
		internal System.Windows.Forms.MenuItem MenuItem25;
		internal System.Windows.Forms.MenuItem MenuItem26;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.MenuItem MenuItem27;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.MenuItem MenuItem16;
		internal System.Windows.Forms.MenuItem MenuItem17;
		internal System.Windows.Forms.MenuItem MenuItem18;
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.MenuItem MenuItem33;
		internal System.Windows.Forms.MenuItem MenuItem34;
		internal System.Windows.Forms.MenuItem MenuItem35;
		internal System.Windows.Forms.MenuItem MenuItem36;
		internal System.Windows.Forms.MenuItem MenuItem37;
		internal System.Windows.Forms.MenuItem MenuItem38;
		internal System.Windows.Forms.MenuItem MenuItem39;
		internal System.Windows.Forms.MenuItem MenuItem40;
		internal System.Windows.Forms.MenuItem MenuItem41;
		internal System.Windows.Forms.MenuItem MenuItem42;
		internal System.Windows.Forms.MenuItem MenuItem45;
		internal System.Windows.Forms.MenuItem MenuItem46;
		internal System.Windows.Forms.MenuItem MenuItem48;
		internal System.Windows.Forms.MenuItem MenuItem30;
		internal System.Windows.Forms.MenuItem MenuItem31;
		internal System.Windows.Forms.MenuItem MenuItem32;
		internal System.Windows.Forms.MenuItem MenuItem49;
		internal System.Windows.Forms.MenuItem MenuItem50;
		internal System.Timers.Timer Timer1;
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton16;
		internal System.Windows.Forms.ToolBarButton ToolBarButton17;
		internal System.Windows.Forms.MenuItem MenuItem29;
		internal System.Windows.Forms.MenuItem MenuItem47;
		internal System.Windows.Forms.MenuItem MnuAbout;
        internal System.Windows.Forms.MenuItem MenuItem20;
        private ToolBarButton toolBarButton18;
        private ToolBarButton toolBarButton19;
		internal System.Windows.Forms.MenuItem MenuItem21;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.cmTableListView = new System.Windows.Forms.ContextMenu();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.MenuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem5 = new System.Windows.Forms.MenuItem();
            this.MenuItem6 = new System.Windows.Forms.MenuItem();
            this.MenuItem7 = new System.Windows.Forms.MenuItem();
            this.MenuItem8 = new System.Windows.Forms.MenuItem();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton16 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton17 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem25 = new System.Windows.Forms.MenuItem();
            this.MenuItem26 = new System.Windows.Forms.MenuItem();
            this.MenuItem27 = new System.Windows.Forms.MenuItem();
            this.MenuItem29 = new System.Windows.Forms.MenuItem();
            this.MenuItem33 = new System.Windows.Forms.MenuItem();
            this.MenuItem34 = new System.Windows.Forms.MenuItem();
            this.MenuItem36 = new System.Windows.Forms.MenuItem();
            this.MenuItem35 = new System.Windows.Forms.MenuItem();
            this.MenuItem9 = new System.Windows.Forms.MenuItem();
            this.MenuItem11 = new System.Windows.Forms.MenuItem();
            this.MenuItem12 = new System.Windows.Forms.MenuItem();
            this.MenuItem10 = new System.Windows.Forms.MenuItem();
            this.MenuItem13 = new System.Windows.Forms.MenuItem();
            this.MenuItem14 = new System.Windows.Forms.MenuItem();
            this.MenuItem15 = new System.Windows.Forms.MenuItem();
            this.MenuItem16 = new System.Windows.Forms.MenuItem();
            this.MenuItem17 = new System.Windows.Forms.MenuItem();
            this.MenuItem18 = new System.Windows.Forms.MenuItem();
            this.MenuItem20 = new System.Windows.Forms.MenuItem();
            this.MenuItem21 = new System.Windows.Forms.MenuItem();
            this.MenuItem37 = new System.Windows.Forms.MenuItem();
            this.MenuItem39 = new System.Windows.Forms.MenuItem();
            this.MenuItem40 = new System.Windows.Forms.MenuItem();
            this.MenuItem38 = new System.Windows.Forms.MenuItem();
            this.MenuItem45 = new System.Windows.Forms.MenuItem();
            this.MenuItem46 = new System.Windows.Forms.MenuItem();
            this.MenuItem47 = new System.Windows.Forms.MenuItem();
            this.MenuItem48 = new System.Windows.Forms.MenuItem();
            this.MenuItem41 = new System.Windows.Forms.MenuItem();
            this.MenuItem42 = new System.Windows.Forms.MenuItem();
            this.MenuItem30 = new System.Windows.Forms.MenuItem();
            this.MenuItem31 = new System.Windows.Forms.MenuItem();
            this.MenuItem32 = new System.Windows.Forms.MenuItem();
            this.MenuItem49 = new System.Windows.Forms.MenuItem();
            this.MenuItem50 = new System.Windows.Forms.MenuItem();
            this.MenuItem19 = new System.Windows.Forms.MenuItem();
            this.MenuItem22 = new System.Windows.Forms.MenuItem();
            this.MenuItem24 = new System.Windows.Forms.MenuItem();
            this.MnuAbout = new System.Windows.Forms.MenuItem();
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.StatusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel6 = new System.Windows.Forms.StatusBarPanel();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Timer1 = new System.Timers.Timer();
            this.toolBarButton18 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton19 = new System.Windows.Forms.ToolBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmTableListView
            // 
            this.cmTableListView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem3,
            this.MenuItem4,
            this.MenuItem2,
            this.MenuItem5,
            this.MenuItem6,
            this.MenuItem7,
            this.MenuItem8});
            // 
            // MenuItem3
            // 
            this.MenuItem3.DefaultItem = true;
            this.MenuItem3.Index = 0;
            this.MenuItem3.Text = "输入单据";
            // 
            // MenuItem4
            // 
            this.MenuItem4.Index = 1;
            this.MenuItem4.Text = "-";
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 2;
            this.MenuItem2.Text = "开台";
            // 
            // MenuItem5
            // 
            this.MenuItem5.Index = 3;
            this.MenuItem5.Text = "加单";
            // 
            // MenuItem6
            // 
            this.MenuItem6.Index = 4;
            this.MenuItem6.Text = "加菜";
            // 
            // MenuItem7
            // 
            this.MenuItem7.Index = 5;
            this.MenuItem7.Text = "-";
            // 
            // MenuItem8
            // 
            this.MenuItem8.Index = 6;
            this.MenuItem8.Text = "刷新";
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton5,
            this.ToolBarButton6,
            this.ToolBarButton7,
            this.ToolBarButton4,
            this.ToolBarButton3,
            this.ToolBarButton8,
            this.ToolBarButton9,
            this.ToolBarButton10,
            this.ToolBarButton11,
            this.ToolBarButton12,
            this.ToolBarButton13,
            this.ToolBarButton14,
            this.toolBarButton18,
            this.toolBarButton19,
            this.ToolBarButton15,
            this.ToolBarButton16,
            this.ToolBarButton17});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(58, 55);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(813, 56);
            this.ToolBar1.TabIndex = 5;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "营业时段";
            this.ToolBarButton1.ToolTipText = "更改营业时段";
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.ImageIndex = 1;
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Text = "新建预订";
            this.ToolBarButton5.ToolTipText = "新建预订订单";
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.ImageIndex = 2;
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Text = "预订管理";
            this.ToolBarButton6.ToolTipText = "对预订订单的修改、删除及完成操作";
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.ImageIndex = 3;
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Text = "桌台状态";
            this.ToolBarButton4.ToolTipText = "显示桌台状态窗口";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 4;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "输入单据";
            this.ToolBarButton3.ToolTipText = "完成对桌台、单据及菜品的餐务操作";
            // 
            // ToolBarButton8
            // 
            this.ToolBarButton8.Name = "ToolBarButton8";
            this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton9
            // 
            this.ToolBarButton9.ImageIndex = 5;
            this.ToolBarButton9.Name = "ToolBarButton9";
            this.ToolBarButton9.Text = "结帐查询";
            this.ToolBarButton9.ToolTipText = "结帐查询预览及打印";
            // 
            // ToolBarButton10
            // 
            this.ToolBarButton10.ImageIndex = 6;
            this.ToolBarButton10.Name = "ToolBarButton10";
            this.ToolBarButton10.Text = "收款查询";
            this.ToolBarButton10.ToolTipText = "收款查询预览及打印";
            // 
            // ToolBarButton11
            // 
            this.ToolBarButton11.Name = "ToolBarButton11";
            this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton12
            // 
            this.ToolBarButton12.ImageIndex = 7;
            this.ToolBarButton12.Name = "ToolBarButton12";
            this.ToolBarButton12.Text = "添加客户";
            this.ToolBarButton12.ToolTipText = "添加客户信息";
            // 
            // ToolBarButton13
            // 
            this.ToolBarButton13.ImageIndex = 8;
            this.ToolBarButton13.Name = "ToolBarButton13";
            this.ToolBarButton13.Text = "客户管理";
            this.ToolBarButton13.ToolTipText = "管理客户信息";
            // 
            // ToolBarButton14
            // 
            this.ToolBarButton14.Name = "ToolBarButton14";
            this.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton15
            // 
            this.ToolBarButton15.ImageIndex = 9;
            this.ToolBarButton15.Name = "ToolBarButton15";
            this.ToolBarButton15.Text = "关于";
            this.ToolBarButton15.ToolTipText = "关于程序作者及版权";
            // 
            // ToolBarButton16
            // 
            this.ToolBarButton16.Name = "ToolBarButton16";
            this.ToolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton17
            // 
            this.ToolBarButton17.ImageIndex = 10;
            this.ToolBarButton17.Name = "ToolBarButton17";
            this.ToolBarButton17.Text = "退出";
            this.ToolBarButton17.ToolTipText = "退出前台管理模块";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            this.ImageList1.Images.SetKeyName(6, "");
            this.ImageList1.Images.SetKeyName(7, "");
            this.ImageList1.Images.SetKeyName(8, "");
            this.ImageList1.Images.SetKeyName(9, "");
            this.ImageList1.Images.SetKeyName(10, "");
            this.ImageList1.Images.SetKeyName(11, "43515.ico");
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem33,
            this.MenuItem9,
            this.MenuItem16,
            this.MenuItem37,
            this.MenuItem45,
            this.MenuItem41,
            this.MenuItem30,
            this.MenuItem19});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem25,
            this.MenuItem26,
            this.MenuItem27,
            this.MenuItem29});
            this.MenuItem1.Text = "系统(&S)";
            // 
            // MenuItem25
            // 
            this.MenuItem25.Index = 0;
            this.MenuItem25.Text = "更改个人密码 (&1)";
            this.MenuItem25.Click += new System.EventHandler(this.MenuItem25_Click);
            // 
            // MenuItem26
            // 
            this.MenuItem26.Index = 1;
            this.MenuItem26.Text = "注销/重新登录 (&2)";
            this.MenuItem26.Click += new System.EventHandler(this.MenuItem26_Click);
            // 
            // MenuItem27
            // 
            this.MenuItem27.Index = 2;
            this.MenuItem27.Text = "-";
            // 
            // MenuItem29
            // 
            this.MenuItem29.Index = 3;
            this.MenuItem29.Text = "退出(&Q)";
            this.MenuItem29.Click += new System.EventHandler(this.MenuItem29_Click);
            // 
            // MenuItem33
            // 
            this.MenuItem33.Index = 1;
            this.MenuItem33.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem34,
            this.MenuItem36,
            this.MenuItem35});
            this.MenuItem33.Text = "预订管理(&A)";
            // 
            // MenuItem34
            // 
            this.MenuItem34.Index = 0;
            this.MenuItem34.Text = "新建订单 (&1)";
            this.MenuItem34.Click += new System.EventHandler(this.MenuItem34_Click);
            // 
            // MenuItem36
            // 
            this.MenuItem36.Index = 1;
            this.MenuItem36.Text = "-";
            // 
            // MenuItem35
            // 
            this.MenuItem35.Index = 2;
            this.MenuItem35.Text = "订单管理 (&2)";
            this.MenuItem35.Click += new System.EventHandler(this.MenuItem35_Click);
            // 
            // MenuItem9
            // 
            this.MenuItem9.Index = 2;
            this.MenuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem11,
            this.MenuItem12,
            this.MenuItem10,
            this.MenuItem13,
            this.MenuItem14,
            this.MenuItem15});
            this.MenuItem9.Text = "餐务操作(&P)";
            // 
            // MenuItem11
            // 
            this.MenuItem11.Index = 0;
            this.MenuItem11.Text = "桌台状态(&1)";
            this.MenuItem11.Click += new System.EventHandler(this.MenuItem11_Click);
            // 
            // MenuItem12
            // 
            this.MenuItem12.Index = 1;
            this.MenuItem12.Text = "-";
            // 
            // MenuItem10
            // 
            this.MenuItem10.Index = 2;
            this.MenuItem10.Text = "输入单据(&2)";
            this.MenuItem10.Click += new System.EventHandler(this.MenuItem10_Click);
            // 
            // MenuItem13
            // 
            this.MenuItem13.Index = 3;
            this.MenuItem13.Text = "-";
            // 
            // MenuItem14
            // 
            this.MenuItem14.Index = 4;
            this.MenuItem14.Text = "浏览特价菜(&3)";
            this.MenuItem14.Click += new System.EventHandler(this.MenuItem14_Click);
            // 
            // MenuItem15
            // 
            this.MenuItem15.Index = 5;
            this.MenuItem15.Text = "浏览时价菜(&4)";
            this.MenuItem15.Click += new System.EventHandler(this.MenuItem15_Click);
            // 
            // MenuItem16
            // 
            this.MenuItem16.Index = 3;
            this.MenuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem17,
            this.MenuItem18,
            this.MenuItem20,
            this.MenuItem21});
            this.MenuItem16.Text = "综合查询(&Q)";
            // 
            // MenuItem17
            // 
            this.MenuItem17.Index = 0;
            this.MenuItem17.Text = "结账查询 (&1)";
            this.MenuItem17.Click += new System.EventHandler(this.MenuItem17_Click);
            // 
            // MenuItem18
            // 
            this.MenuItem18.Index = 1;
            this.MenuItem18.Text = "收款查询 (&2)";
            this.MenuItem18.Click += new System.EventHandler(this.MenuItem18_Click);
            // 
            // MenuItem20
            // 
            this.MenuItem20.Index = 2;
            this.MenuItem20.Text = "-";
            // 
            // MenuItem21
            // 
            this.MenuItem21.Index = 3;
            this.MenuItem21.Text = "删除菜品记录(&3)";
            this.MenuItem21.Click += new System.EventHandler(this.MenuItem21_Click);
            // 
            // MenuItem37
            // 
            this.MenuItem37.Index = 4;
            this.MenuItem37.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem39,
            this.MenuItem40,
            this.MenuItem38});
            this.MenuItem37.Text = "客户管理(&C)";
            // 
            // MenuItem39
            // 
            this.MenuItem39.Index = 0;
            this.MenuItem39.Text = "添加客户 (&1)";
            this.MenuItem39.Click += new System.EventHandler(this.MenuItem39_Click);
            // 
            // MenuItem40
            // 
            this.MenuItem40.Index = 1;
            this.MenuItem40.Text = "-";
            // 
            // MenuItem38
            // 
            this.MenuItem38.Index = 2;
            this.MenuItem38.Text = "客户信息 (&2)";
            this.MenuItem38.Click += new System.EventHandler(this.MenuItem38_Click);
            // 
            // MenuItem45
            // 
            this.MenuItem45.Index = 5;
            this.MenuItem45.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem46,
            this.MenuItem47,
            this.MenuItem48});
            this.MenuItem45.Text = "签单管理(&G)";
            // 
            // MenuItem46
            // 
            this.MenuItem46.Index = 0;
            this.MenuItem46.Text = "签单结帐 (&1)";
            this.MenuItem46.Click += new System.EventHandler(this.MenuItem46_Click);
            // 
            // MenuItem47
            // 
            this.MenuItem47.Index = 1;
            this.MenuItem47.Text = "签单消费记录 (&2)";
            this.MenuItem47.Click += new System.EventHandler(this.MenuItem47_Click);
            // 
            // MenuItem48
            // 
            this.MenuItem48.Index = 2;
            this.MenuItem48.Text = "常客查询 (&3)";
            this.MenuItem48.Click += new System.EventHandler(this.MenuItem48_Click);
            // 
            // MenuItem41
            // 
            this.MenuItem41.Index = 6;
            this.MenuItem41.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem42});
            this.MenuItem41.Text = "商品库存(&M)";
            // 
            // MenuItem42
            // 
            this.MenuItem42.Index = 0;
            this.MenuItem42.Text = "每月结转 (&1)";
            this.MenuItem42.Click += new System.EventHandler(this.MenuItem42_Click);
            // 
            // MenuItem30
            // 
            this.MenuItem30.Index = 7;
            this.MenuItem30.MdiList = true;
            this.MenuItem30.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem31,
            this.MenuItem32,
            this.MenuItem49,
            this.MenuItem50});
            this.MenuItem30.Text = "窗口(&W)";
            // 
            // MenuItem31
            // 
            this.MenuItem31.Index = 0;
            this.MenuItem31.Text = "排列 (&A)";
            this.MenuItem31.Click += new System.EventHandler(this.MenuItem31_Click);
            // 
            // MenuItem32
            // 
            this.MenuItem32.Index = 1;
            this.MenuItem32.Text = "层叠 (&C)";
            this.MenuItem32.Click += new System.EventHandler(this.MenuItem32_Click);
            // 
            // MenuItem49
            // 
            this.MenuItem49.Index = 2;
            this.MenuItem49.Text = "水平平铺 (&H)";
            this.MenuItem49.Click += new System.EventHandler(this.MenuItem49_Click);
            // 
            // MenuItem50
            // 
            this.MenuItem50.Index = 3;
            this.MenuItem50.Text = "垂直平铺 (&V)";
            this.MenuItem50.Click += new System.EventHandler(this.MenuItem50_Click);
            // 
            // MenuItem19
            // 
            this.MenuItem19.Index = 8;
            this.MenuItem19.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem22,
            this.MenuItem24,
            this.MnuAbout});
            this.MenuItem19.Text = "帮助(&H)";
            // 
            // MenuItem22
            // 
            this.MenuItem22.Index = 0;
            this.MenuItem22.Text = "帮助主题";
            this.MenuItem22.Click += new System.EventHandler(this.MenuItem22_Click);
            // 
            // MenuItem24
            // 
            this.MenuItem24.Index = 1;
            this.MenuItem24.Text = "-";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Index = 2;
            this.MnuAbout.Text = "关于";
            this.MnuAbout.Click += new System.EventHandler(this.MenuItem20_Click);
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 414);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel1,
            this.StatusBarPanel2,
            this.StatusBarPanel3,
            this.StatusBarPanel4,
            this.StatusBarPanel5,
            this.StatusBarPanel6});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(813, 22);
            this.StatusBar1.SizingGrip = false;
            this.StatusBar1.TabIndex = 6;
            this.StatusBar1.Text = "StatusBar1";
            // 
            // StatusBarPanel1
            // 
            this.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.StatusBarPanel1.Name = "StatusBarPanel1";
            this.StatusBarPanel1.Text = "StatusBarPanel1";
            this.StatusBarPanel1.Width = 107;
            // 
            // StatusBarPanel2
            // 
            this.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.StatusBarPanel2.Name = "StatusBarPanel2";
            this.StatusBarPanel2.Text = "StatusBarPanel2";
            this.StatusBarPanel2.Width = 107;
            // 
            // StatusBarPanel3
            // 
            this.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.StatusBarPanel3.Name = "StatusBarPanel3";
            this.StatusBarPanel3.Text = "StatusBarPanel3";
            this.StatusBarPanel3.Width = 107;
            // 
            // StatusBarPanel4
            // 
            this.StatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.StatusBarPanel4.Name = "StatusBarPanel4";
            this.StatusBarPanel4.Text = "StatusBarPanel4";
            this.StatusBarPanel4.Width = 107;
            // 
            // StatusBarPanel5
            // 
            this.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.StatusBarPanel5.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.StatusBarPanel5.Name = "StatusBarPanel5";
            this.StatusBarPanel5.Width = 278;
            // 
            // StatusBarPanel6
            // 
            this.StatusBarPanel6.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.StatusBarPanel6.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.StatusBarPanel6.Name = "StatusBarPanel6";
            this.StatusBarPanel6.Text = "StatusBarPanel6";
            this.StatusBarPanel6.Width = 107;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 480000D;
            this.Timer1.SynchronizingObject = this;
            this.Timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
            // 
            // toolBarButton18
            // 
            this.toolBarButton18.ImageIndex = 11;
            this.toolBarButton18.Name = "toolBarButton18";
            this.toolBarButton18.Text = "设备管理";
            // 
            // toolBarButton19
            // 
            this.toolBarButton19.Name = "toolBarButton19";
            this.toolBarButton19.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // mainform
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(813, 436);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.MainMenu1;
            this.Name = "mainform";
            this.Text = " - 前台管理";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//显示预订管理窗口
		public void ShowAppoint()
		{
			if (rms_var.frmAppnt == null)
			{
				rms_var.frmAppnt = new frmAppoint();
				rms_var.frmAppnt.MdiParent = rms_var.mainfrm;
				rms_var.frmAppnt.Show();
			}
			else
			{
				if (rms_var.frmAppnt.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmAppnt.BringToFront();
				}
				else
				{
					rms_var.frmAppnt.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示输入单据窗口
		public void ShowInputBillForm()
		{
			if (rms_var.frmInputBill == null)
			{
				rms_var.frmInputBill = new InputBill();
				rms_var.frmInputBill.MdiParent = rms_var.mainfrm;
				rms_var.mainfrm = this;
				rms_var.frmInputBill.Show();
			}
			else
			{
				if (rms_var.frmInputBill.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmInputBill.BringToFront();
				}
				else
				{
					rms_var.frmInputBill.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示桌台状态窗口
		public void ShowTableSatus()
		{
			if (rms_var.frmTableST == null)
			{
				rms_var.frmTableST = new frmTableStatus();
				rms_var.frmTableST.MdiParent = rms_var.mainfrm;
				rms_var.frmTableST.Show();
			}
			else
			{
				if (rms_var.frmTableST.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmTableST.BringToFront();
				}
				else
				{
					rms_var.frmTableST.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示特价菜
		public void ShowSpecialFood()
		{
			if (rms_var.frmbrssfod == null)
			{
				rms_var.frmbrssfod = new frmBrsSpecialFood();
				rms_var.frmbrssfod.MdiParent = rms_var.mainfrm;
				rms_var.frmbrssfod.Show();
			}
			else
			{
				if (rms_var.frmbrssfod.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmbrssfod.BringToFront();
				}
				else
				{
					rms_var.frmbrssfod.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示时价菜
		public void ShowCurrentFood()
		{
			if (rms_var.frmbrscfod == null)
			{
				rms_var.frmbrscfod = new frmBrsCurrentFood();
				rms_var.frmbrscfod.MdiParent = rms_var.mainfrm;
				rms_var.frmbrscfod.Show();
			}
			else
			{
				if (rms_var.frmbrscfod.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmbrscfod.BringToFront();
				}
				else
				{
					rms_var.frmbrscfod.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示综合查询 - 结帐查询
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
		
		//显示综合查询 - 收款/结帐类别查询
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
		
		//打开客户信息窗口
		private void ShowCustForm()
		{
			if (rms_var.frmCust == null)
			{
				rms_var.frmCust = new frmCustomer();
				rms_var.frmCust.MdiParent = this;
				rms_var.frmCust.Show();
			}
			else
			{
				rms_var.frmCust.BringToFront();
				rms_var.frmCust.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开签单消费记录窗口
		private void ShowSignPayForm()
		{
			if (rms_var.frmSP == null)
			{
				rms_var.frmSP = new frmQuerySignPay();
				rms_var.frmSP.MdiParent = this;
				rms_var.frmSP.Show();
			}
			else
			{
				rms_var.frmSP.BringToFront();
				rms_var.frmSP.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开常客查询窗口
		private void ShowCustomerFreqForm()
		{
			if (rms_var.frmCF == null)
			{
				rms_var.frmCF = new frmCustomerFreq();
				rms_var.frmCF.MdiParent = this;
				rms_var.frmCF.Show();
			}
			else
			{
				rms_var.frmCF.BringToFront();
				rms_var.frmCF.WindowState = FormWindowState.Normal;
			}
		}
		
		private void mainform_Load(System.Object sender, System.EventArgs e)
		{
            //if (!Authorize.GetValidityUUID(rms_var.ReadStrfromReg("Key", "")))
            //{
            //    MessageBox.Show("授权无效");
            //    Application.Exit();
            //    return;
            //}
			rms_var.mainfrm = this;
			//创建类库对象的实例，只创建这一次
			rms_var.TheAppExt = new AppExt.CAppExt();
			//显示OEM Apptitle
			this.Text = rms_var.TheAppExt.GetAppTitle + this.Text;
			rms_var.TheAppExt.LogModule = 3; //报告登录的是->前台管理模块
			MnuAbout.Text ="关于 " + rms_var.TheAppExt.GetAppTitle;
			
			string rtn = rms_var.TheAppExt.ShowLogForm("前台管理");
			if (rtn.Trim() == "-1")
			{
                Application.Exit();
                return;
			}
			else
			{
				rms_var.ConnStr = rms_var.TheAppExt.GetConnStr; //复制远程连接字符串
				if (rms_var.GetCurrentTableNoBillsCount("") >= 200)
				{
					return;
				}
				rms_var.ReceiveOperatorInfo(rtn);
				//选择营业时段
				SelTimeBlock selecttimeblock = new SelTimeBlock();
				selecttimeblock.ShowDialog();
				StatusBar1.Panels[0].Text = "当前营业时段：" + rms_var.TimeBlock;
				StatusBar1.Panels[1].Text = "登录用户ID：" + rms_var.opinfo.OpID;
				StatusBar1.Panels[2].Text = "姓名：" + rms_var.opinfo.EmployeeName;
				StatusBar1.Panels[3].Text = "所属部门：" + rms_var.opinfo.Department;
				StatusBar1.Panels[5].Text = "登录时间：" + DateTime.Now.ToString();
				this.WindowState = FormWindowState.Maximized;
			}
		}
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //时间段
					//选择营业时段
					SelTimeBlock selecttimeblock = new SelTimeBlock();
					selecttimeblock.ShowDialog();
					StatusBar1.Panels[0].Text = "当前营业时段：" + rms_var.TimeBlock;
					break;
				case 2: //新建预订
					MenuItem34_Click(sender, e);
					break;
				case 3: //订单管理
					ShowAppoint();
					break;
				case 5: //桌台状态
					ShowTableSatus();
					break;
				case 6: //输入单据
					ShowInputBillForm();
					break;
				case 8: //结帐查询
					ShowBalanceQry();
					break;
				case 9: //收款查询
					ShowBalanceTypeQry();
					break;
				case 11: //添加客户
					MenuItem39_Click(sender, e);
					break;
				case 12: //客户管理
					ShowCustForm();
					break;
                case 14:
                    ShowDevForm();
                    break;
				case 16:
					MenuItem20_Click(sender, e);
					break;
				case 18: //关闭
					this.Close();
					break;
			}
		}
        private void ShowDevForm()
        {

        }

		private void MenuItem11_Click(System.Object sender, System.EventArgs e)
		{
			ShowTableSatus();
		}
		
		private void MenuItem20_Click(System.Object sender, System.EventArgs e)
		{
			System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
			string ver;
			
			ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
			
			rms_var.TheAppExt.ShowAboutForm(ver, "3f7a");
		}
		
		private void MenuItem25_Click(System.Object sender, System.EventArgs e)
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
					selectCMD.CommandText = "update Operator set password='" + rms_var.MD5Crypt(frmeditpassword.TextBox1.Text) + "' where operatorid='" + rms_var.opinfo.OpID + "'";
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
		
		private void MenuItem26_Click(System.Object sender, System.EventArgs e)
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
				
				rms_var.mainfrm = this;
				rms_var.TheAppExt.LogModule = 3; //报告登录的是->前台管理模块
				string rtn = rms_var.TheAppExt.ShowLogForm("前台管理");
				if (rtn.Trim() == "-1")
				{
					Application.Exit();
				}
				else
				{
					rms_var.ReceiveOperatorInfo(rtn);
					
					//选择营业时段
					SelTimeBlock selecttimeblock = new SelTimeBlock();
					selecttimeblock.ShowDialog();
					
					StatusBar1.Panels[0].Text = "当前营业时段：" + rms_var.TimeBlock;
					StatusBar1.Panels[1].Text = "登录用户ID：" + rms_var.opinfo.OpID;
					StatusBar1.Panels[2].Text = "姓名：" + rms_var.opinfo.EmployeeName;
					StatusBar1.Panels[3].Text = "所属部门：" + rms_var.opinfo.Department;
					StatusBar1.Panels[5].Text = "登录时间：" + DateTime.Now.ToString();
					
					this.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		private void MenuItem29_Click(System.Object sender, System.EventArgs e)
		{
            Application.Exit();
		}
		
		private void MenuItem14_Click(System.Object sender, System.EventArgs e)
		{
			ShowSpecialFood();
		}
		
		private void MenuItem15_Click(System.Object sender, System.EventArgs e)
		{
			ShowCurrentFood();
		}
		
		private void MenuItem17_Click(System.Object sender, System.EventArgs e)
		{
			ShowBalanceQry();
		}
		
		private void MenuItem10_Click(System.Object sender, System.EventArgs e)
		{
			ShowInputBillForm();
		}
		
		private void MenuItem35_Click(System.Object sender, System.EventArgs e)
		{
			ShowAppoint();
		}
		
		private void MenuItem38_Click(System.Object sender, System.EventArgs e)
		{
			ShowCustForm();
		}
		
		private void MenuItem39_Click(System.Object sender, System.EventArgs e)
		{
			frmEditCust editcust = new frmEditCust();
			editcust.GetCustTypeList();
			
			editcust.frmMode = 1; //添加记录
			editcust.Text = "添加客户信息";
			
			editcust.ShowDialog();
		}
		
		private void MenuItem42_Click(System.Object sender, System.EventArgs e)
		{
			string InvntDate;
			InvntDate = DateTime.Now.Year.ToString() + string.Format("00",DateTime.Now.Month); //结转本月及以前的仓库数据
			MessageBox.Show("当前自然月为： " + InvntDate);
			frmSelScdStrgDept frmSelStrgDept = new frmSelScdStrgDept();
			frmSelStrgDept.ShowDialog();
			if (frmSelStrgDept.DialogResult != DialogResult.OK)
			{
				return;
			}
			string strgdeptname;
			strgdeptname = frmSelStrgDept.ComboBox1.Text;
			
			//检测 SecStorage_Inventory ，再根据入库、出库计算各物品数量
			System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
			conn1.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn1;
				//获取仓库前期期末结转时的日期
				selectCMD1.CommandText = "SELECT yearmonth FROM SecStorage_Inventory group by yearmonth order by yearmonth";
				selectCMD1.CommandTimeout = 30;
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				dbDA1.SelectCommand = selectCMD1;
				conn1.Open();
				DataSet dbDS1 = new DataSet();
				dbDA1.Fill(dbDS1, "prioryearmonth");
				if (dbDS1.Tables["prioryearmonth"].Rows.Count == 0)
				{
					//先删除原有数据
					//selectCMD1.CommandText = "delete from storage_inventory where yearmonth='" + InvntDate + "'"
					//selectCMD1.ExecuteNonQuery()
					//没有前期结转数据，统计全部部门出入库数据，并保存结转后的数据
					
					//部门入库数据 C F H
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_InStorageMaterials where depcode='" + rms_var.GetDeptCode(strgdeptname) + "' and (storagebilltypecode='H' or storagebilltypecode='C'or storagebilltypecode='F') and convert(char(4),indate,102)+convert(char(2),indate,100)<='" + InvntDate + "'group by materialcode";
					dbDA1.Fill(dbDS1, "instrg");
					//将所有入库数据添加进 secstorage_inventory
					for (int i = 0; i <= dbDS1.Tables["instrg"].Rows.Count - 1; i++)
					{
						selectCMD1.CommandText = "insert into secstorage_inventory (yearmonth,materialcode,quantity,price,totalprice,depcode) values ('" + InvntDate + "','" + dbDS1.Tables["instrg"].Rows[i][0].ToString() + "'," + dbDS1.Tables["instrg"].Rows[i][1].ToString() + "," + (System.Convert.ToString((double.Parse(dbDS1.Tables["instrg"].Rows[i][2].ToString())) / double.Parse(dbDS1.Tables["instrg"].Rows[i][1].ToString()))) + "," + dbDS1.Tables["instrg"].Rows[i][2].ToString() + ",'" + rms_var.GetDeptCode(strgdeptname) + "')";
						selectCMD1.ExecuteNonQuery();
					}
					//部门出库数据  A D   将出库数据 更新 secstorage_inventory
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_OutStorageMaterials where outdepcode='" + rms_var.GetDeptCode(strgdeptname) + "' and (storagebilltypecode='A' or storagebilltypecode='D' or storagebilltypecode='G') and convert(char(4),outdate,102)+convert(char(2),outdate,100)<='" + InvntDate + "'group by materialcode";
					dbDA1.Fill(dbDS1, "outstrg");
					//将所有出库数据更新进 storage_inventory
					for (int i = 0; i <= dbDS1.Tables["outstrg"].Rows.Count - 1; i++)
					{
						selectCMD1.CommandText = "update secstorage_inventory set quantity=quantity-" + dbDS1.Tables["outstrg"].Rows[i][1].ToString() + ",price=totalprice/quantity,totalprice=totalprice-" + dbDS1.Tables["outstrg"].Rows[i][2].ToString() + " where yearmonth='" + InvntDate + "' and materialcode='" + dbDS1.Tables["outstrg"].Rows[i][0].ToString() + "' and depcode='" + rms_var.GetDeptCode(strgdeptname) + "'";
						selectCMD1.ExecuteNonQuery();
					}
					MessageBox.Show("结转成功");
				}
				else //存在前期结转数据，获取最后一次结转日期，根据该日期返回所有结转的物品数量
				{
					string LastInvntDate;
                    LastInvntDate = dbDS1.Tables["prioryearmonth"].Rows[dbDS1.Tables["prioryearmonth"].Rows.Count - 1][0].ToString();
					if (LastInvntDate == InvntDate) //当月已结转
					{
						MessageBox.Show("当月已结转");
						return;
					}
					//根据 LastInvntDate 和 InvntDate 日期区间结转所有入库物品
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_InStorageMaterials where (storagebilltypecode='H' or storagebilltypecode='C'or storagebilltypecode='F') and convert(char(4),indate,102)+convert(char(2),indate,100)>='" + LastInvntDate + "' and convert(char(4),indate,102)+convert(char(2),indate,100)<='" + InvntDate + "'group by materialcode";
					dbDA1.Fill(dbDS1, "instrg");
					
					//将所有入库数据与前期数据更新进 storage_inventory
					double priorquantity = 0;
					double priortotalprice = 0;
					double currentquantity = 0;
					double currenttotalprice = 0;
					
					for (int i = 0; i <= dbDS1.Tables["instrg"].Rows.Count - 1; i++)
					{
						currentquantity = System.Convert.ToDouble(dbDS1.Tables["instrg"].Rows[i][1]);
						currenttotalprice = System.Convert.ToDouble(dbDS1.Tables["instrg"].Rows[i][2]);
						//返回前期物品数量
						selectCMD1.CommandText = "SELECT materialcode,quantity,totalprice FROM secstorage_inventory where yearmonth='" + LastInvntDate + "' and materialcode='" + dbDS1.Tables["instrg"].Rows[i][0] + "' and depcode='" + rms_var.GetDeptCode(strgdeptname) + "'";
						dbDA1.Fill(dbDS1, "priormaterial");
						//在原有数量之上加上入库数量
						if (dbDS1.Tables["priormaterial"].Rows.Count > 0) //上期存在该物品，更新数量后再添加 = 前期数量+本期入库数量
						{
							priorquantity = System.Convert.ToDouble(dbDS1.Tables["priormaterial"].Rows[0][1]);
							priortotalprice = System.Convert.ToDouble(dbDS1.Tables["priormaterial"].Rows[0][2]);
							//selectCMD1.CommandText = "update storage_inventory set " + _
							//                         "quantity=" + CStr(priorquantity + currentquantity) + "," + _
							//                         "price=" + CStr((priortotalprice + currenttotalprice) / (priorquantity + currentquantity)) + "," + _
							//                         "totalprice=" + CStr(priortotalprice + currenttotalprice) + _
							//                         " where yearmonth='" + LastInvntDate + "' and materialcode='" + dbDS1.Tables("instrg").Rows(i).Item(0).ToString + "'"
							//selectCMD1.ExecuteNonQuery()
							//Else
						}
						selectCMD1.CommandText = "insert into secstorage_inventory (yearmonth,materialcode,quantity,price,totalprice,depcode) values ('" + InvntDate + "','" + dbDS1.Tables["instrg"].Rows[i][0].ToString() + "'," + (priorquantity + currentquantity).ToString() + "," + ((priortotalprice + currenttotalprice) / (priorquantity + currentquantity)).ToString() + "," + (priortotalprice + currenttotalprice).ToString() + ",'" + rms_var.GetDeptCode(strgdeptname) + "')";
						selectCMD1.ExecuteNonQuery();
						
						
						dbDS1.Tables["priormaterial"].Rows.Clear();
					}
					//根据 LastInvntDate 和 InvntDate 日期区间结转所有出库物品
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_OutStorageMaterials where outdepcode='" + rms_var.GetDeptCode(strgdeptname) + "' and (storagebilltypecode='A' or storagebilltypecode='D' or storagebilltypecode='G') and convert(char(4),outdate,102)+convert(char(2),outdate,100)<='" + InvntDate + "'group by materialcode";
					dbDA1.Fill(dbDS1, "outstrg");
					for (int i = 0; i <= dbDS1.Tables["outstrg"].Rows.Count - 1; i++)
					{
						currentquantity = System.Convert.ToDouble(dbDS1.Tables["outstrg"].Rows[i][1]);
						currenttotalprice = System.Convert.ToDouble(dbDS1.Tables["outstrg"].Rows[i][2]);
						//返回前期物品数量
						selectCMD1.CommandText = "SELECT materialcode,quantity,totalprice FROM secstorage_inventory where yearmonth='" + InvntDate + "' and materialcode='" + dbDS1.Tables["outstrg"].Rows[i][0] + "'" + " and depcode='" + rms_var.GetDeptCode(strgdeptname) + "'";
						dbDA1.Fill(dbDS1, "priormaterial");
						//在原有数量之上减去出库数量
						if (dbDS1.Tables["priormaterial"].Rows.Count > 0) //上期存在该物品，更新数量
						{
							//priorquantity = dbDS1.Tables("priormaterial").Rows(i).Item(1)
							//priortotalprice = dbDS1.Tables("priormaterial").Rows(i).Item(2)
							
							selectCMD1.CommandText = "update secstorage_inventory set quantity=quantity-" + currentquantity.ToString() + ",price=totalprice/quantity,totalprice=totalprice-" + currenttotalprice.ToString() + " where yearmonth='" + InvntDate + "' and materialcode='" + dbDS1.Tables["outstrg"].Rows[i][0].ToString() + "' and depcode='" + rms_var.GetDeptCode(strgdeptname) + "'";
							selectCMD1.ExecuteNonQuery();
						}
						
						dbDS1.Tables["priormaterial"].Rows.Clear();
					}
					MessageBox.Show("结转成功");
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
		}
		
		private void MenuItem34_Click(System.Object sender, System.EventArgs e)
		{
			frmNewAppointBill frmnab = new frmNewAppointBill();
			frmnab.CreateSelectedTables();
			frmnab.CreateSelectedFoods();
			frmnab.TextBox1.Text = rms_var.GenNewAppointBillNo();
			frmnab.Label13.Text = "预订";
			frmnab.ShowDialog();
		}
		
		private void MenuItem18_Click(System.Object sender, System.EventArgs e)
		{
			ShowBalanceTypeQry();
		}
		
		private void MenuItem31_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
		}
		
		private void MenuItem32_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}
		
		private void MenuItem49_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}
		
		private void MenuItem50_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}
		
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
		
		private void MenuItem46_Click(System.Object sender, System.EventArgs e)
		{
			frmSignPay frmsp = new frmSignPay();
			frmsp.ShowDialog();
			
			frmsp.Dispose();
		}
		
		private void MenuItem47_Click(System.Object sender, System.EventArgs e)
		{
			ShowSignPayForm();
		}
		
		private void MenuItem48_Click(System.Object sender, System.EventArgs e)
		{
			ShowCustomerFreqForm();
		}
		
		private void MenuItem22_Click(System.Object sender, System.EventArgs e)
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
		
		private void MenuItem21_Click(System.Object sender, System.EventArgs e)
		{
			frmDelList frmDlst = new frmDelList();
			frmDlst.ShowDialog();
		}
	}
	
}
