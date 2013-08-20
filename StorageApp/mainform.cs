using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
using System.IO;


namespace StorageApp
{
	public class Form1 : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new Form1());
		}
		
		#region  Windows 窗体设计器生成的代码
		
		public Form1()
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
		internal System.Windows.Forms.MainMenu MainMenu1;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.MenuItem MenuItem4;
		internal System.Windows.Forms.MenuItem MenuItem5;
		internal System.Windows.Forms.StatusBar StatusBar1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel5;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel6;
		internal System.Windows.Forms.MenuItem MenuItem6;
		internal System.Windows.Forms.MenuItem MenuItem7;
		internal System.Windows.Forms.MenuItem MenuItem8;
		internal System.Windows.Forms.MenuItem MenuItem9;
		internal System.Windows.Forms.MenuItem MenuItem10;
		internal System.Windows.Forms.MenuItem MenuItem11;
		internal System.Windows.Forms.MenuItem MenuItem12;
		internal System.Windows.Forms.MenuItem MenuItem13;
		internal System.Windows.Forms.MenuItem MenuItem14;
		internal System.Windows.Forms.MenuItem MenuItem15;
		internal System.Windows.Forms.MenuItem MenuItem16;
		internal System.Windows.Forms.MenuItem MenuItem17;
		internal System.Windows.Forms.MenuItem MenuItem18;
		internal System.Windows.Forms.MenuItem MenuItem19;
		internal System.Windows.Forms.MenuItem MenuItem20;
		internal System.Windows.Forms.MenuItem MenuItem21;
		internal System.Windows.Forms.MenuItem MenuItem22;
		internal System.Windows.Forms.MenuItem MenuItem23;
		internal System.Windows.Forms.MenuItem MenuItem24;
		internal System.Windows.Forms.MenuItem MenuItem25;
		internal System.Windows.Forms.MenuItem MenuItem27;
		internal System.Windows.Forms.MenuItem MenuItem29;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.MenuItem MenuItem30;
		internal System.Windows.Forms.MenuItem MenuItem31;
		internal System.Windows.Forms.MenuItem MenuItem32;
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
		internal System.Timers.Timer Timer1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
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
		internal System.Windows.Forms.MenuItem mnuAbout;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem20 = new System.Windows.Forms.MenuItem();
            this.MenuItem21 = new System.Windows.Forms.MenuItem();
            this.MenuItem22 = new System.Windows.Forms.MenuItem();
            this.MenuItem23 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.MenuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem5 = new System.Windows.Forms.MenuItem();
            this.MenuItem30 = new System.Windows.Forms.MenuItem();
            this.MenuItem31 = new System.Windows.Forms.MenuItem();
            this.MenuItem36 = new System.Windows.Forms.MenuItem();
            this.MenuItem37 = new System.Windows.Forms.MenuItem();
            this.MenuItem32 = new System.Windows.Forms.MenuItem();
            this.MenuItem33 = new System.Windows.Forms.MenuItem();
            this.MenuItem34 = new System.Windows.Forms.MenuItem();
            this.MenuItem6 = new System.Windows.Forms.MenuItem();
            this.MenuItem7 = new System.Windows.Forms.MenuItem();
            this.MenuItem29 = new System.Windows.Forms.MenuItem();
            this.MenuItem8 = new System.Windows.Forms.MenuItem();
            this.MenuItem9 = new System.Windows.Forms.MenuItem();
            this.MenuItem10 = new System.Windows.Forms.MenuItem();
            this.MenuItem11 = new System.Windows.Forms.MenuItem();
            this.MenuItem12 = new System.Windows.Forms.MenuItem();
            this.MenuItem13 = new System.Windows.Forms.MenuItem();
            this.MenuItem14 = new System.Windows.Forms.MenuItem();
            this.MenuItem15 = new System.Windows.Forms.MenuItem();
            this.MenuItem16 = new System.Windows.Forms.MenuItem();
            this.MenuItem19 = new System.Windows.Forms.MenuItem();
            this.MenuItem18 = new System.Windows.Forms.MenuItem();
            this.MenuItem17 = new System.Windows.Forms.MenuItem();
            this.MenuItem35 = new System.Windows.Forms.MenuItem();
            this.MenuItem38 = new System.Windows.Forms.MenuItem();
            this.MenuItem39 = new System.Windows.Forms.MenuItem();
            this.MenuItem40 = new System.Windows.Forms.MenuItem();
            this.MenuItem41 = new System.Windows.Forms.MenuItem();
            this.MenuItem42 = new System.Windows.Forms.MenuItem();
            this.MenuItem24 = new System.Windows.Forms.MenuItem();
            this.MenuItem25 = new System.Windows.Forms.MenuItem();
            this.MenuItem27 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton16 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel6 = new System.Windows.Forms.StatusBarPanel();
            this.Timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem6,
            this.MenuItem38,
            this.MenuItem24});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem20,
            this.MenuItem21,
            this.MenuItem22,
            this.MenuItem23});
            this.MenuItem1.Text = "系统(&S)";
            // 
            // MenuItem20
            // 
            this.MenuItem20.Index = 0;
            this.MenuItem20.Text = "更改个人密码 (&1)";
            this.MenuItem20.Click += new System.EventHandler(this.MenuItem20_Click);
            // 
            // MenuItem21
            // 
            this.MenuItem21.Index = 1;
            this.MenuItem21.Text = "注销/重新登录 (&2)";
            this.MenuItem21.Click += new System.EventHandler(this.MenuItem21_Click);
            // 
            // MenuItem22
            // 
            this.MenuItem22.Index = 2;
            this.MenuItem22.Text = "-";
            // 
            // MenuItem23
            // 
            this.MenuItem23.Index = 3;
            this.MenuItem23.Text = "退出 (&Q)";
            this.MenuItem23.Click += new System.EventHandler(this.MenuItem23_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem3,
            this.MenuItem4,
            this.MenuItem5,
            this.MenuItem30,
            this.MenuItem31});
            this.MenuItem2.Text = "基本信息(&I)";
            // 
            // MenuItem3
            // 
            this.MenuItem3.Index = 0;
            this.MenuItem3.Text = "物品类别 (&1)";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // MenuItem4
            // 
            this.MenuItem4.Index = 1;
            this.MenuItem4.Text = "物品信息 (&2)";
            this.MenuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
            // 
            // MenuItem5
            // 
            this.MenuItem5.Index = 2;
            this.MenuItem5.Text = "供应商信息 (&3)";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // MenuItem30
            // 
            this.MenuItem30.Index = 3;
            this.MenuItem30.Text = "-";
            // 
            // MenuItem31
            // 
            this.MenuItem31.Index = 4;
            this.MenuItem31.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem36,
            this.MenuItem37,
            this.MenuItem32,
            this.MenuItem33,
            this.MenuItem34});
            this.MenuItem31.Text = "期初建账 (&4)";
            // 
            // MenuItem36
            // 
            this.MenuItem36.Index = 0;
            this.MenuItem36.Text = "启用库存管理 (&A)";
            this.MenuItem36.Click += new System.EventHandler(this.MenuItem36_Click);
            // 
            // MenuItem37
            // 
            this.MenuItem37.Index = 1;
            this.MenuItem37.Text = "-";
            // 
            // MenuItem32
            // 
            this.MenuItem32.Index = 2;
            this.MenuItem32.Text = "仓库期初建账 (&B)";
            this.MenuItem32.Click += new System.EventHandler(this.MenuItem32_Click);
            // 
            // MenuItem33
            // 
            this.MenuItem33.Index = 3;
            this.MenuItem33.Text = "部门期初建账 (&C)";
            this.MenuItem33.Click += new System.EventHandler(this.MenuItem33_Click);
            // 
            // MenuItem34
            // 
            this.MenuItem34.Index = 4;
            this.MenuItem34.Text = "应付款期初建账 (&D)";
            this.MenuItem34.Click += new System.EventHandler(this.MenuItem34_Click);
            // 
            // MenuItem6
            // 
            this.MenuItem6.Index = 2;
            this.MenuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem7,
            this.MenuItem29,
            this.MenuItem8,
            this.MenuItem9,
            this.MenuItem10,
            this.MenuItem11,
            this.MenuItem12,
            this.MenuItem13,
            this.MenuItem14,
            this.MenuItem15,
            this.MenuItem16,
            this.MenuItem19,
            this.MenuItem18,
            this.MenuItem17,
            this.MenuItem35});
            this.MenuItem6.Text = "业务处理(&P)";
            // 
            // MenuItem7
            // 
            this.MenuItem7.Index = 0;
            this.MenuItem7.Text = "入库单 (&1)";
            this.MenuItem7.Click += new System.EventHandler(this.MenuItem7_Click);
            // 
            // MenuItem29
            // 
            this.MenuItem29.Index = 1;
            this.MenuItem29.Text = "-";
            // 
            // MenuItem8
            // 
            this.MenuItem8.Index = 2;
            this.MenuItem8.Text = "领料单 (&2)";
            this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
            // 
            // MenuItem9
            // 
            this.MenuItem9.Index = 3;
            this.MenuItem9.Text = "直拨单 (&3)";
            this.MenuItem9.Click += new System.EventHandler(this.MenuItem9_Click);
            // 
            // MenuItem10
            // 
            this.MenuItem10.Index = 4;
            this.MenuItem10.Text = "部门退仓库 (&4)";
            this.MenuItem10.Click += new System.EventHandler(this.MenuItem10_Click);
            // 
            // MenuItem11
            // 
            this.MenuItem11.Index = 5;
            this.MenuItem11.Text = "部门退供应商 (&5)";
            this.MenuItem11.Click += new System.EventHandler(this.MenuItem11_Click);
            // 
            // MenuItem12
            // 
            this.MenuItem12.Index = 6;
            this.MenuItem12.Text = "-";
            // 
            // MenuItem13
            // 
            this.MenuItem13.Index = 7;
            this.MenuItem13.Text = "仓库退供应商 (&6)";
            this.MenuItem13.Click += new System.EventHandler(this.MenuItem13_Click);
            // 
            // MenuItem14
            // 
            this.MenuItem14.Index = 8;
            this.MenuItem14.Text = "仓库报损 (&7)";
            this.MenuItem14.Click += new System.EventHandler(this.MenuItem14_Click);
            // 
            // MenuItem15
            // 
            this.MenuItem15.Index = 9;
            this.MenuItem15.Text = "仓库报溢 (&8)";
            this.MenuItem15.Click += new System.EventHandler(this.MenuItem15_Click);
            // 
            // MenuItem16
            // 
            this.MenuItem16.Index = 10;
            this.MenuItem16.Text = "-";
            // 
            // MenuItem19
            // 
            this.MenuItem19.Index = 11;
            this.MenuItem19.Text = "付供应商 (&9)";
            this.MenuItem19.Click += new System.EventHandler(this.MenuItem19_Click);
            // 
            // MenuItem18
            // 
            this.MenuItem18.Index = 12;
            this.MenuItem18.Text = "-";
            // 
            // MenuItem17
            // 
            this.MenuItem17.Index = 13;
            this.MenuItem17.Text = "部门盘存单  (&0)";
            this.MenuItem17.Click += new System.EventHandler(this.MenuItem17_Click);
            // 
            // MenuItem35
            // 
            this.MenuItem35.Index = 14;
            this.MenuItem35.Text = "仓库每月结转 (&A)";
            this.MenuItem35.Click += new System.EventHandler(this.MenuItem35_Click);
            // 
            // MenuItem38
            // 
            this.MenuItem38.Index = 3;
            this.MenuItem38.MdiList = true;
            this.MenuItem38.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem39,
            this.MenuItem40,
            this.MenuItem41,
            this.MenuItem42});
            this.MenuItem38.Text = "窗口(&W)";
            // 
            // MenuItem39
            // 
            this.MenuItem39.Index = 0;
            this.MenuItem39.Text = "排列 (&A)";
            this.MenuItem39.Click += new System.EventHandler(this.MenuItem39_Click);
            // 
            // MenuItem40
            // 
            this.MenuItem40.Index = 1;
            this.MenuItem40.Text = "层叠 (&C)";
            this.MenuItem40.Click += new System.EventHandler(this.MenuItem40_Click);
            // 
            // MenuItem41
            // 
            this.MenuItem41.Index = 2;
            this.MenuItem41.Text = "水平平铺 (&H)";
            this.MenuItem41.Click += new System.EventHandler(this.MenuItem41_Click);
            // 
            // MenuItem42
            // 
            this.MenuItem42.Index = 3;
            this.MenuItem42.Text = "垂直平铺 (&V)";
            this.MenuItem42.Click += new System.EventHandler(this.MenuItem42_Click);
            // 
            // MenuItem24
            // 
            this.MenuItem24.Index = 4;
            this.MenuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem25,
            this.MenuItem27,
            this.mnuAbout});
            this.MenuItem24.Text = "帮助(&H)";
            // 
            // MenuItem25
            // 
            this.MenuItem25.Index = 0;
            this.MenuItem25.Text = "帮助主题";
            this.MenuItem25.Click += new System.EventHandler(this.MenuItem25_Click);
            // 
            // MenuItem27
            // 
            this.MenuItem27.Index = 1;
            this.MenuItem27.Text = "-";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 2;
            this.mnuAbout.Text = "关于";
            this.mnuAbout.Click += new System.EventHandler(this.MenuItem28_Click);
            // 
            // ToolBar1
            // 
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton6,
            this.ToolBarButton5,
            this.ToolBarButton7,
            this.ToolBarButton8,
            this.ToolBarButton9,
            this.ToolBarButton10,
            this.ToolBarButton11,
            this.ToolBarButton12,
            this.ToolBarButton13,
            this.ToolBarButton14,
            this.ToolBarButton15,
            this.ToolBarButton16});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(58, 55);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(736, 55);
            this.ToolBar1.TabIndex = 1;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "物品类别";
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.ImageIndex = 1;
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Text = "物品信息";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 2;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "供应商";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.ImageIndex = 3;
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Text = "入库单";
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.ImageIndex = 4;
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Text = "领料单";
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 5;
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Text = "退库单";
            // 
            // ToolBarButton8
            // 
            this.ToolBarButton8.ImageIndex = 6;
            this.ToolBarButton8.Name = "ToolBarButton8";
            this.ToolBarButton8.Text = "退货单";
            // 
            // ToolBarButton9
            // 
            this.ToolBarButton9.ImageIndex = 7;
            this.ToolBarButton9.Name = "ToolBarButton9";
            this.ToolBarButton9.Text = "报损单";
            // 
            // ToolBarButton10
            // 
            this.ToolBarButton10.ImageIndex = 8;
            this.ToolBarButton10.Name = "ToolBarButton10";
            this.ToolBarButton10.Text = "报溢单";
            // 
            // ToolBarButton11
            // 
            this.ToolBarButton11.Name = "ToolBarButton11";
            this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton12
            // 
            this.ToolBarButton12.ImageIndex = 9;
            this.ToolBarButton12.Name = "ToolBarButton12";
            this.ToolBarButton12.Text = "支付";
            // 
            // ToolBarButton13
            // 
            this.ToolBarButton13.Name = "ToolBarButton13";
            this.ToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton14
            // 
            this.ToolBarButton14.ImageIndex = 10;
            this.ToolBarButton14.Name = "ToolBarButton14";
            this.ToolBarButton14.Text = "关于";
            // 
            // ToolBarButton15
            // 
            this.ToolBarButton15.Name = "ToolBarButton15";
            this.ToolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton16
            // 
            this.ToolBarButton16.ImageIndex = 11;
            this.ToolBarButton16.Name = "ToolBarButton16";
            this.ToolBarButton16.Text = "退出";
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
            this.ImageList1.Images.SetKeyName(11, "");
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 472);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel2,
            this.StatusBarPanel3,
            this.StatusBarPanel4,
            this.StatusBarPanel5,
            this.StatusBarPanel6});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(736, 22);
            this.StatusBar1.TabIndex = 8;
            this.StatusBar1.Text = "StatusBar1";
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
            this.StatusBarPanel5.Width = 292;
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
            this.Timer1.Interval = 480000;
            this.Timer1.SynchronizingObject = this;
            this.Timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(736, 494);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = " - 库存管理";
            this.Load += new System.EventHandler(this.Form1_Load);
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
		
		//显示物品类别窗口
		public void ShowMatreialType()
		{
			if (rms_var.frmMaterTyp == null)
			{
				rms_var.frmMaterTyp = new frmMaterialType();
				rms_var.frmMaterTyp.MdiParent = this;
				rms_var.frmMaterTyp.Show();
			}
			else
			{
				if (rms_var.frmMaterTyp.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmMaterTyp.BringToFront();
				}
				else
				{
					rms_var.frmMaterTyp.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示物品窗口
		public void ShowMatreials()
		{
			if (rms_var.frmMtrls == null)
			{
				rms_var.frmMtrls = new frmMaterials();
				rms_var.frmMtrls.MdiParent = this;
				rms_var.frmMtrls.Show();
			}
			else
			{
				if (rms_var.frmMtrls.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmMtrls.BringToFront();
				}
				else
				{
					rms_var.frmMtrls.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示供应商窗口
		public void ShowVendor()
		{
			if (rms_var.frmVndor == null)
			{
				rms_var.frmVndor = new frmVendor();
				rms_var.frmVndor.MdiParent = this;
				rms_var.frmVndor.Show();
			}
			else
			{
				if (rms_var.frmVndor.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmVndor.BringToFront();
				}
				else
				{
					rms_var.frmVndor.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示采购入库单窗口
		public void ShowInComeBill()
		{
			if (rms_var.frmTheInBill == null)
			{
				rms_var.frmTheInBill = new frmInBill();
				rms_var.frmTheInBill.MdiParent = this;
				rms_var.frmTheInBill.Text = rms_var.GetStorageBillTypeCaptionName("I");
				rms_var.frmTheInBill.init("I");
				rms_var.frmTheInBill.GroupBox1.Text = "采购入库单";
				rms_var.frmTheInBill.CurrentInBillTypeCode = "I";
				rms_var.frmTheInBill.NewIncomeBill();
				rms_var.frmTheInBill.Show();
			}
			else
			{
				rms_var.frmTheInBill.Text = rms_var.GetStorageBillTypeCaptionName("I");
				rms_var.frmTheInBill.init("I");
				rms_var.frmTheInBill.GroupBox1.Text = "采购入库单";
				rms_var.frmTheInBill.CurrentInBillTypeCode = "I";
				rms_var.frmTheInBill.NewIncomeBill();
				if (rms_var.frmTheInBill.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmTheInBill.BringToFront();
				}
				else
				{
					rms_var.frmTheInBill.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示仓库报溢单窗口
		public void ShowOverFlowBill()
		{
			if (rms_var.frmTheInBill == null)
			{
				rms_var.frmTheInBill = new frmInBill();
				rms_var.frmTheInBill.MdiParent = this;
				rms_var.frmTheInBill.Text = rms_var.GetStorageBillTypeCaptionName("M");
				rms_var.frmTheInBill.init("M");
				rms_var.frmTheInBill.GroupBox1.Text = "仓库报溢单";
				rms_var.frmTheInBill.CurrentInBillTypeCode = "M";
				rms_var.frmTheInBill.NewOverFlowBill();
				rms_var.frmTheInBill.Show();
			}
			else
			{
				rms_var.frmTheInBill.Text = rms_var.GetStorageBillTypeCaptionName("M");
				rms_var.frmTheInBill.init("M");
				rms_var.frmTheInBill.GroupBox1.Text = "仓库报溢单";
				rms_var.frmTheInBill.CurrentInBillTypeCode = "M";
				rms_var.frmTheInBill.NewOverFlowBill();
				if (rms_var.frmTheInBill.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmTheInBill.BringToFront();
				}
				else
				{
					rms_var.frmTheInBill.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		
		//显示出库单窗口
		public void ShowOutBill(string outbilltypecode)
		{
			if (rms_var.frmTheOutBill == null)
			{
				rms_var.frmTheOutBill = new frmOutBill();
				rms_var.frmTheOutBill.MdiParent = this;
				rms_var.frmTheOutBill.Text = rms_var.GetStorageBillTypeCaptionName(outbilltypecode);
				rms_var.frmTheOutBill.init(outbilltypecode);
				rms_var.frmTheOutBill.GroupBox1.Text = rms_var.GetStorageBillTypeName(outbilltypecode);
				rms_var.frmTheOutBill.CurrentOutBillTypeCode = outbilltypecode;
				rms_var.frmTheOutBill.NewOutBill();
				rms_var.frmTheOutBill.Show();
			}
			else
			{
				rms_var.frmTheOutBill.Text = rms_var.GetStorageBillTypeCaptionName(outbilltypecode);
				rms_var.frmTheOutBill.init(outbilltypecode);
				rms_var.frmTheOutBill.GroupBox1.Text = rms_var.GetStorageBillTypeName(outbilltypecode);
				rms_var.frmTheOutBill.CurrentOutBillTypeCode = outbilltypecode;
				rms_var.frmTheOutBill.NewOutBill();
				if (rms_var.frmTheOutBill.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmTheOutBill.BringToFront();
				}
				else
				{
					rms_var.frmTheOutBill.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示付供应商窗口
		public void ShowPayVendor()
		{
			if (rms_var.frmPayVD == null)
			{
				rms_var.frmPayVD = new frmPayVendor();
				rms_var.frmPayVD.MdiParent = this;
				rms_var.frmPayVD.Show();
			}
			else
			{
				if (rms_var.frmPayVD.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmPayVD.BringToFront();
				}
				else
				{
					rms_var.frmPayVD.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示仓库期初建账 盘存窗口
		public void ShowStorageInventory(string storagedeptname)
		{
			if (rms_var.frmStorageInvent == null)
			{
				rms_var.frmStorageInvent = new frmStorageInventory();
				rms_var.frmStorageInvent.MdiParent = this;
				rms_var.frmStorageInvent.CurrentStorageDeptName = storagedeptname;
				rms_var.frmStorageInvent.init();
				rms_var.frmStorageInvent.Show();
			}
			else
			{
				rms_var.frmStorageInvent.CurrentStorageDeptName = storagedeptname;
				rms_var.frmStorageInvent.init();
				
				if (rms_var.frmStorageInvent.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmStorageInvent.BringToFront();
				}
				else
				{
					rms_var.frmStorageInvent.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		//显示部门仓库期初建账 盘存窗口
		public void ShowDeptStorageInventory(string storagedeptname, string deptname)
		{
			if (rms_var.frmDeptStorageInvent == null)
			{
				rms_var.frmDeptStorageInvent = new frmDeptStorageInventory();
				rms_var.frmDeptStorageInvent.MdiParent = this;
				rms_var.frmDeptStorageInvent.CurrentStorageDeptName = storagedeptname;
				rms_var.frmDeptStorageInvent.CurrentDeptName = deptname;
				rms_var.frmDeptStorageInvent.init();
				rms_var.frmDeptStorageInvent.Show();
			}
			else
			{
				rms_var.frmDeptStorageInvent.CurrentStorageDeptName = storagedeptname;
				rms_var.frmDeptStorageInvent.CurrentDeptName = deptname;
				rms_var.frmDeptStorageInvent.init();
				
				if (rms_var.frmDeptStorageInvent.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmDeptStorageInvent.BringToFront();
				}
				else
				{
					rms_var.frmDeptStorageInvent.WindowState = FormWindowState.Maximized;
				}
			}
		}
		
		private void MenuItem3_Click(System.Object sender, System.EventArgs e)
		{
			ShowMatreialType();
		}
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
			//创建类库对象的实例，只创建这一次
			rms_var.TheAppExt = new AppExt.CAppExt();
			this.Text = rms_var.TheAppExt.GetAppTitle + this.Text;
			mnuAbout.Text = "关于 " + rms_var.TheAppExt.GetAppTitle;
			rms_var.TheAppExt.LogModule = 2; //报告登录的是->库存管理模块
			string rtn = rms_var.TheAppExt.ShowLogForm("库存管理");
			if (rtn.Trim() == "-1")
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
		
		private void MenuItem28_Click(System.Object sender, System.EventArgs e)
		{
			System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
			string ver;
			
			ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
			
			rms_var.TheAppExt.ShowAboutForm(ver, "c8f0");
		}
		
		private void MenuItem4_Click(System.Object sender, System.EventArgs e)
		{
			ShowMatreials();
		}
		
		private void MenuItem5_Click(System.Object sender, System.EventArgs e)
		{
			ShowVendor();
		}
		
		private void MenuItem7_Click(System.Object sender, System.EventArgs e)
		{
			ShowInComeBill();
		}
		
		private void MenuItem15_Click(System.Object sender, System.EventArgs e)
		{
			ShowOverFlowBill(); //仓库报溢
		}
		
		private void MenuItem8_Click(System.Object sender, System.EventArgs e)
		{
			ShowOutBill("A"); //领料单
		}
		
		private void MenuItem9_Click(System.Object sender, System.EventArgs e)
		{
			ShowOutBill("D"); //直拨单
		}
		
		private void MenuItem10_Click(System.Object sender, System.EventArgs e)
		{
			ShowOutBill("H"); //部门退仓库
		}
		
		private void MenuItem11_Click(System.Object sender, System.EventArgs e)
		{
			ShowOutBill("F"); //部门退供应商
		}
		
		private void MenuItem13_Click(System.Object sender, System.EventArgs e)
		{
			ShowOutBill("B"); //仓库退供应商
		}
		
		private void MenuItem14_Click(System.Object sender, System.EventArgs e)
		{
			ShowOutBill("G"); //仓库报损
		}
		
		private void MenuItem20_Click(System.Object sender, System.EventArgs e)
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
		
		private void MenuItem21_Click(System.Object sender, System.EventArgs e)
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
				
				rms_var.TheAppExt.LogModule = 2; //报告登录的是->库存管理模块
				System.String rtn = rms_var.TheAppExt.ShowLogForm("库存管理");
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
		
		private void MenuItem23_Click(System.Object sender, System.EventArgs e)
		{
            Application.Exit();
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //物品类别
					ShowMatreialType();
					break;
				case 1: //物品信息
					ShowMatreials();
					break;
				case 2: //供应商
					ShowVendor();
					break;
				case 4: //入库单
					ShowInComeBill();
					break;
				case 5:
					ShowOutBill("A"); //领料单
					break;
				case 6:
					ShowOutBill("H"); //部门退仓库
					break;
				case 7:
					ShowOutBill("F"); //部门退供应商
					break;
				case 8:
					ShowOutBill("G"); //仓库报损
					break;
				case 9:
					ShowOverFlowBill(); //仓库报溢
					break;
				case 11:
					ShowPayVendor(); //付供应商
					break;
				case 13:
					MenuItem28_Click(sender, e);
					break;
				case 15:
					this.Close();
					break;
			}
		}
		
		private void MenuItem32_Click(System.Object sender, System.EventArgs e)
		{
			frmSelStorageDept frmssd = new frmSelStorageDept();
			frmssd.ShowDialog();
			if (frmssd.DialogResult == DialogResult.OK)
			{
				ShowStorageInventory(frmssd.ComboBox1.Text);
			}
		}
		
		private void MenuItem33_Click(System.Object sender, System.EventArgs e)
		{
			frmSelDepartment frmsd = new frmSelDepartment();
			frmsd.ShowDialog();
			if (frmsd.DialogResult == DialogResult.OK)
			{
				ShowDeptStorageInventory(frmsd.ComboBox1.Text, frmsd.ComboBox2.Text);
			}
		}
		
		private void MenuItem17_Click(System.Object sender, System.EventArgs e)
		{
			frmSelInventoryDept frmsid = new frmSelInventoryDept();
			frmsid.ShowDialog();
			if (frmsid.DialogResult == DialogResult.OK)
			{
				//打开盘存物品窗口，盘存物品数量
				frmInventoryMaterials frmim = new frmInventoryMaterials();
				frmim.StorageDeptName = frmsid.ComboBox1.Text;
				frmim.DeptName = frmsid.ComboBox2.Text;
				frmim.InventoryDate = frmsid.DateTimePicker1.Text + " " + frmsid.DateTimePicker2.Text;
				frmim.ShowDialog();
			}
		}
		
		private void MenuItem35_Click(System.Object sender, System.EventArgs e)
		{
			string InvntDate;
			InvntDate = DateTime.Now.Year.ToString() + string.Format("{00}",DateTime.Now.Month); //结转本月及以前的仓库数据
			MessageBox.Show(InvntDate);
			frmSelStorageDept frmSelStrgDept = new frmSelStorageDept();
			frmSelStrgDept.ShowDialog();
			if (frmSelStrgDept.DialogResult != DialogResult.OK)
			{
				return;
			}
			
			string strgdeptname;
			strgdeptname = frmSelStrgDept.ComboBox1.Text;
			
			//检测 Storage_Inventory ，再根据入库、出库计算各物品数量
			System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
			conn1.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn1;
				//获取仓库前期期末结转时的日期
				selectCMD1.CommandText = "SELECT yearmonth FROM Storage_Inventory group by yearmonth order by yearmonth";
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
					//没有前期结转数据，统计全部出入库数据，并保存结转后的数据
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_InStorageMaterials " + "where depcode='" + rms_var.GetDeptCode(strgdeptname) + "' and (storagebilltypecode='H' or storagebilltypecode='I'or storagebilltypecode='M') and " + "convert(char(4),indate,102)+convert(char(2),indate,100)<='" + InvntDate + "'" + "group by materialcode";
					dbDA1.Fill(dbDS1, "instrg");
					//将所有入库数据添加进 storage_inventory
					for (int i = 0; i <= dbDS1.Tables["instrg"].Rows.Count - 1; i++)
					{
						selectCMD1.CommandText = "insert into storage_inventory (yearmonth,materialcode,quantity,price,totalprice) " + "values (" + "'" + InvntDate + "'" + "," + "'" + dbDS1.Tables["instrg"].Rows[i][0].ToString() + "'" + "," + dbDS1.Tables["instrg"].Rows[i][1].ToString() + "," + (System.Convert.ToString((double.Parse(dbDS1.Tables["instrg"].Rows[i][2].ToString())) / double.Parse(dbDS1.Tables["instrg"].Rows[i][1].ToString()))) + "," + dbDS1.Tables["instrg"].Rows[i][2].ToString() + ")";
						selectCMD1.ExecuteNonQuery();
					}
					//将出库数据 更新 storage_inventory
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_OutStorageMaterials " + "where outdepcode='" + rms_var.GetDeptCode(strgdeptname) + "' and (storagebilltypecode='A' or storagebilltypecode='B'or storagebilltypecode='D' or storagebilltypecode='G') and " + "convert(char(4),outdate,102)+convert(char(2),outdate,100)<='" + InvntDate + "'" + "group by materialcode";
					dbDA1.Fill(dbDS1, "outstrg");
					//将所有出库数据更新进 storage_inventory
					for (int i = 0; i <= dbDS1.Tables["outstrg"].Rows.Count - 1; i++)
					{
						selectCMD1.CommandText = "update storage_inventory set " + "quantity=quantity-" + dbDS1.Tables["outstrg"].Rows[i][1].ToString() + "," + "price=totalprice/quantity" + "," + "totalprice=totalprice-" + dbDS1.Tables["outstrg"].Rows[i][2].ToString() + " where yearmonth='" + InvntDate + "' and materialcode='" + dbDS1.Tables["outstrg"].Rows[i][0].ToString() + "'";
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
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_InStorageMaterials " + "where (storagebilltypecode='H' or storagebilltypecode='I'or storagebilltypecode='M') and " + "convert(char(4),indate,102)+convert(char(2),indate,100)>='" + LastInvntDate + "'" + " and convert(char(4),indate,102)+convert(char(2),indate,100)<='" + InvntDate + "'" + "group by materialcode";
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
						selectCMD1.CommandText = "SELECT materialcode,quantity,totalprice FROM storage_inventory where yearmonth='" + LastInvntDate + "' and materialcode='" + dbDS1.Tables["instrg"].Rows[i][0] + "'";
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
						selectCMD1.CommandText = "insert into storage_inventory (yearmonth,materialcode,quantity,price,totalprice) " + "values (" + "'" + InvntDate + "'" + "," + "'" + dbDS1.Tables["instrg"].Rows[i][0].ToString() + "'" + "," + (System.Convert.ToString(priorquantity + currentquantity)) + "," + (Convert.ToString(((priortotalprice + currenttotalprice) / (priorquantity + currentquantity)))) + "," + (System.Convert.ToString(priortotalprice + currenttotalprice)) + ")";
						selectCMD1.ExecuteNonQuery();
						
						
						dbDS1.Tables["priormaterial"].Rows.Clear();
					}
					//根据 LastInvntDate 和 InvntDate 日期区间结转所有出库物品
					selectCMD1.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice FROM view_OutStorageMaterials " + "where outdepcode='" + rms_var.GetDeptCode(strgdeptname) + "' and (storagebilltypecode='A' or storagebilltypecode='B'or storagebilltypecode='D' or storagebilltypecode='G') and " + "convert(char(4),outdate,102)+convert(char(2),outdate,100)<='" + InvntDate + "'" + "group by materialcode";
					dbDA1.Fill(dbDS1, "outstrg");
					for (int i = 0; i <= dbDS1.Tables["outstrg"].Rows.Count - 1; i++)
					{
						currentquantity = System.Convert.ToDouble(dbDS1.Tables["outstrg"].Rows[i][1]);
						currenttotalprice = System.Convert.ToDouble(dbDS1.Tables["outstrg"].Rows[i][2]);
						//返回前期物品数量
						selectCMD1.CommandText = "SELECT materialcode,quantity,totalprice FROM storage_inventory where yearmonth='" + InvntDate + "' and materialcode='" + dbDS1.Tables["outstrg"].Rows[i][0] + "'";
						dbDA1.Fill(dbDS1, "priormaterial");
						//在原有数量之上减去出库数量
						if (dbDS1.Tables["priormaterial"].Rows.Count > 0) //上期存在该物品，更新数量
						{
							//priorquantity = dbDS1.Tables("priormaterial").Rows(i).Item(1)
							//priortotalprice = dbDS1.Tables("priormaterial").Rows(i).Item(2)
							
							selectCMD1.CommandText = "update storage_inventory set " + "quantity=quantity-" + currentquantity.ToString() + "," + "price=totalprice/quantity" + "," + "totalprice=totalprice-" + currenttotalprice.ToString() + " where yearmonth='" + InvntDate + "' and materialcode='" + dbDS1.Tables["outstrg"].Rows[i][0].ToString() + "'";
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
		
		private void MenuItem36_Click(System.Object sender, System.EventArgs e)
		{
			frmInitDb frmid = new frmInitDb();
			frmid.ShowDialog();
		}
		
		private void MenuItem34_Click(System.Object sender, System.EventArgs e)
		{
			frmInitPayVendor frmipv = new frmInitPayVendor();
			frmipv.ShowDialog();
		}
		
		private void MenuItem19_Click(System.Object sender, System.EventArgs e)
		{
			ShowPayVendor();
		}
		
		private void MenuItem39_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
		}
		
		private void MenuItem40_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}
		
		private void MenuItem41_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}
		
		private void MenuItem42_Click(System.Object sender, System.EventArgs e)
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
		
		private void MenuItem25_Click(System.Object sender, System.EventArgs e)
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
