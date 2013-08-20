using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
using System.IO;


namespace SysAdmin
{
	public class frmSysAdmin : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new frmSysAdmin());
		}
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSysAdmin()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化
			
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
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.MenuItem MenuItem4;
		internal System.Windows.Forms.MenuItem MenuItem6;
		internal System.Windows.Forms.MenuItem MenuItem7;
		internal System.Windows.Forms.MenuItem MenuItem9;
		internal System.Windows.Forms.MenuItem MenuItem10;
		internal System.Windows.Forms.MenuItem MenuItem11;
		internal System.Windows.Forms.MenuItem MenuItem12;
		internal System.Windows.Forms.MenuItem MenuItem14;
		internal System.Windows.Forms.MenuItem MenuItem15;
		internal System.Windows.Forms.MenuItem MenuItem16;
		internal System.Windows.Forms.MenuItem MenuItem17;
		internal System.Windows.Forms.MenuItem MenuItem19;
		internal System.Windows.Forms.MenuItem MenuItem20;
		internal System.Windows.Forms.MenuItem MenuItem21;
		internal System.Windows.Forms.MenuItem MenuItem22;
		internal System.Windows.Forms.MenuItem MenuItem23;
		internal System.Windows.Forms.MenuItem MenuItem24;
		internal System.Windows.Forms.MenuItem MenuItem25;
		internal System.Windows.Forms.MenuItem MenuItem29;
		internal System.Windows.Forms.MenuItem MenuItem30;
		internal System.Windows.Forms.MenuItem MenuItem31;
		internal System.Windows.Forms.MenuItem MenuItem32;
		internal System.Windows.Forms.MenuItem MenuItem33;
		internal System.Windows.Forms.MenuItem MenuItem34;
		internal System.Windows.Forms.MenuItem MenuItem35;
		internal System.Windows.Forms.MenuItem MenuItem36;
		internal System.Windows.Forms.MenuItem MenuItem37;
		internal System.Windows.Forms.MenuItem MenuItem39;
		internal System.Windows.Forms.MenuItem MenuItem40;
		internal System.Windows.Forms.MenuItem MenuItem44;
		internal System.Windows.Forms.MenuItem MenuItem45;
		internal System.Windows.Forms.MenuItem MenuItem46;
		internal System.Windows.Forms.MenuItem MenuItem49;
		internal System.Windows.Forms.MenuItem MenuItem50;
		internal System.Windows.Forms.MenuItem MenuItem51;
		internal System.Windows.Forms.MenuItem MenuItem52;
		internal System.Windows.Forms.MenuItem MenuItem53;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.StatusBar StatusBar1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel5;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel6;
		internal System.Windows.Forms.MenuItem mnu_sys_sz;
		internal System.Windows.Forms.MenuItem spt_1;
		internal System.Windows.Forms.MenuItem mnu_sys_khgl;
		internal System.Windows.Forms.MenuItem mnu_Sys_rygl;
		internal System.Windows.Forms.MenuItem mnu_sys_cpgl;
		internal System.Windows.Forms.MenuItem mnu_sys_qtgl;
		internal System.Windows.Forms.MenuItem mnu_sys_sjgl;
		internal System.Windows.Forms.MenuItem MenuItem5;
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton16;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Timers.Timer Timer1;
		internal System.Windows.Forms.MenuItem mnuAbout;
		internal System.Windows.Forms.MenuItem MenuItem8;
		internal System.Windows.Forms.MenuItem MenuItem13;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysAdmin));
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_sys_sz = new System.Windows.Forms.MenuItem();
            this.spt_1 = new System.Windows.Forms.MenuItem();
            this.MenuItem5 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.MenuItem4 = new System.Windows.Forms.MenuItem();
            this.mnu_sys_khgl = new System.Windows.Forms.MenuItem();
            this.MenuItem6 = new System.Windows.Forms.MenuItem();
            this.MenuItem7 = new System.Windows.Forms.MenuItem();
            this.MenuItem9 = new System.Windows.Forms.MenuItem();
            this.MenuItem10 = new System.Windows.Forms.MenuItem();
            this.MenuItem11 = new System.Windows.Forms.MenuItem();
            this.MenuItem12 = new System.Windows.Forms.MenuItem();
            this.mnu_Sys_rygl = new System.Windows.Forms.MenuItem();
            this.MenuItem14 = new System.Windows.Forms.MenuItem();
            this.MenuItem15 = new System.Windows.Forms.MenuItem();
            this.MenuItem16 = new System.Windows.Forms.MenuItem();
            this.MenuItem17 = new System.Windows.Forms.MenuItem();
            this.mnu_sys_cpgl = new System.Windows.Forms.MenuItem();
            this.MenuItem19 = new System.Windows.Forms.MenuItem();
            this.MenuItem20 = new System.Windows.Forms.MenuItem();
            this.MenuItem21 = new System.Windows.Forms.MenuItem();
            this.MenuItem22 = new System.Windows.Forms.MenuItem();
            this.MenuItem24 = new System.Windows.Forms.MenuItem();
            this.MenuItem23 = new System.Windows.Forms.MenuItem();
            this.MenuItem25 = new System.Windows.Forms.MenuItem();
            this.mnu_sys_qtgl = new System.Windows.Forms.MenuItem();
            this.MenuItem29 = new System.Windows.Forms.MenuItem();
            this.MenuItem30 = new System.Windows.Forms.MenuItem();
            this.MenuItem31 = new System.Windows.Forms.MenuItem();
            this.MenuItem32 = new System.Windows.Forms.MenuItem();
            this.MenuItem33 = new System.Windows.Forms.MenuItem();
            this.MenuItem34 = new System.Windows.Forms.MenuItem();
            this.MenuItem35 = new System.Windows.Forms.MenuItem();
            this.MenuItem36 = new System.Windows.Forms.MenuItem();
            this.MenuItem37 = new System.Windows.Forms.MenuItem();
            this.mnu_sys_sjgl = new System.Windows.Forms.MenuItem();
            this.MenuItem40 = new System.Windows.Forms.MenuItem();
            this.MenuItem8 = new System.Windows.Forms.MenuItem();
            this.MenuItem13 = new System.Windows.Forms.MenuItem();
            this.MenuItem39 = new System.Windows.Forms.MenuItem();
            this.MenuItem49 = new System.Windows.Forms.MenuItem();
            this.MenuItem50 = new System.Windows.Forms.MenuItem();
            this.MenuItem51 = new System.Windows.Forms.MenuItem();
            this.MenuItem52 = new System.Windows.Forms.MenuItem();
            this.MenuItem53 = new System.Windows.Forms.MenuItem();
            this.MenuItem44 = new System.Windows.Forms.MenuItem();
            this.MenuItem45 = new System.Windows.Forms.MenuItem();
            this.MenuItem46 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
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
            this.ToolBarButton16 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
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
            this.mnu_sys_khgl,
            this.mnu_Sys_rygl,
            this.mnu_sys_cpgl,
            this.mnu_sys_qtgl,
            this.mnu_sys_sjgl,
            this.MenuItem49,
            this.MenuItem44});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_sys_sz,
            this.spt_1,
            this.MenuItem5,
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem4});
            this.MenuItem1.Text = "系统(&S)";
            // 
            // mnu_sys_sz
            // 
            this.mnu_sys_sz.Index = 0;
            this.mnu_sys_sz.Text = "系统设置 (&1)";
            this.mnu_sys_sz.Click += new System.EventHandler(this.mnu_sys_sz_Click);
            // 
            // spt_1
            // 
            this.spt_1.Index = 1;
            this.spt_1.Text = "-";
            // 
            // MenuItem5
            // 
            this.MenuItem5.Index = 2;
            this.MenuItem5.Text = "更改个人密码 (&2)";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 3;
            this.MenuItem2.Text = "注销/重新登录(&3)";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Index = 4;
            this.MenuItem3.Text = "-";
            // 
            // MenuItem4
            // 
            this.MenuItem4.Index = 5;
            this.MenuItem4.Text = "退出 (&4)";
            this.MenuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
            // 
            // mnu_sys_khgl
            // 
            this.mnu_sys_khgl.Index = 1;
            this.mnu_sys_khgl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem6,
            this.MenuItem7,
            this.MenuItem9,
            this.MenuItem10,
            this.MenuItem11,
            this.MenuItem12});
            this.mnu_sys_khgl.Text = "客户管理(&C)";
            // 
            // MenuItem6
            // 
            this.MenuItem6.Index = 0;
            this.MenuItem6.Text = "客户类别 (&1)";
            this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // MenuItem7
            // 
            this.MenuItem7.Index = 1;
            this.MenuItem7.Text = "客户/会员管理 (&2)";
            this.MenuItem7.Click += new System.EventHandler(this.MenuItem7_Click);
            // 
            // MenuItem9
            // 
            this.MenuItem9.Index = 2;
            this.MenuItem9.Text = "-";
            // 
            // MenuItem10
            // 
            this.MenuItem10.Index = 3;
            this.MenuItem10.Text = "会员卡管理 (&3)";
            this.MenuItem10.Click += new System.EventHandler(this.MenuItem10_Click);
            // 
            // MenuItem11
            // 
            this.MenuItem11.Index = 4;
            this.MenuItem11.Text = "会员卡累计折让比率 (&4)";
            this.MenuItem11.Click += new System.EventHandler(this.MenuItem11_Click);
            // 
            // MenuItem12
            // 
            this.MenuItem12.Index = 5;
            this.MenuItem12.Text = "会员卡续存查询 (&5)";
            this.MenuItem12.Click += new System.EventHandler(this.MenuItem12_Click);
            // 
            // mnu_Sys_rygl
            // 
            this.mnu_Sys_rygl.Index = 2;
            this.mnu_Sys_rygl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem14,
            this.MenuItem15,
            this.MenuItem16,
            this.MenuItem17});
            this.mnu_Sys_rygl.Text = "人员管理(&E)";
            // 
            // MenuItem14
            // 
            this.MenuItem14.Index = 0;
            this.MenuItem14.Text = "部门管理 (&1)";
            this.MenuItem14.Click += new System.EventHandler(this.MenuItem14_Click);
            // 
            // MenuItem15
            // 
            this.MenuItem15.Index = 1;
            this.MenuItem15.Text = "公司雇员 (&2)";
            this.MenuItem15.Click += new System.EventHandler(this.MenuItem15_Click);
            // 
            // MenuItem16
            // 
            this.MenuItem16.Index = 2;
            this.MenuItem16.Text = "-";
            // 
            // MenuItem17
            // 
            this.MenuItem17.Index = 3;
            this.MenuItem17.Text = "操作员帐号及权限设置 (&3)";
            this.MenuItem17.Click += new System.EventHandler(this.MenuItem17_Click);
            // 
            // mnu_sys_cpgl
            // 
            this.mnu_sys_cpgl.Index = 3;
            this.mnu_sys_cpgl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem19,
            this.MenuItem20,
            this.MenuItem21,
            this.MenuItem22,
            this.MenuItem24,
            this.MenuItem23,
            this.MenuItem25});
            this.mnu_sys_cpgl.Text = "菜品管理(&F)";
            // 
            // MenuItem19
            // 
            this.MenuItem19.Index = 0;
            this.MenuItem19.Text = "菜品类别 (&1)";
            this.MenuItem19.Click += new System.EventHandler(this.MenuItem19_Click);
            // 
            // MenuItem20
            // 
            this.MenuItem20.Index = 1;
            this.MenuItem20.Text = "菜品信息 (&2)";
            this.MenuItem20.Click += new System.EventHandler(this.MenuItem20_Click);
            // 
            // MenuItem21
            // 
            this.MenuItem21.Index = 2;
            this.MenuItem21.Text = "做法设置 (&3)";
            this.MenuItem21.Click += new System.EventHandler(this.MenuItem21_Click);
            // 
            // MenuItem22
            // 
            this.MenuItem22.Index = 3;
            this.MenuItem22.Text = "口味设置 (&4)";
            this.MenuItem22.Click += new System.EventHandler(this.MenuItem22_Click);
            // 
            // MenuItem24
            // 
            this.MenuItem24.Index = 4;
            this.MenuItem24.Text = "菜品优惠 (&5)";
            this.MenuItem24.Click += new System.EventHandler(this.MenuItem24_Click);
            // 
            // MenuItem23
            // 
            this.MenuItem23.Index = 5;
            this.MenuItem23.Text = "-";
            // 
            // MenuItem25
            // 
            this.MenuItem25.Index = 6;
            this.MenuItem25.Text = "套餐设置 (&6)";
            this.MenuItem25.Click += new System.EventHandler(this.MenuItem25_Click);
            // 
            // mnu_sys_qtgl
            // 
            this.mnu_sys_qtgl.Index = 4;
            this.mnu_sys_qtgl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem29,
            this.MenuItem30,
            this.MenuItem31,
            this.MenuItem32,
            this.MenuItem33,
            this.MenuItem34,
            this.MenuItem35,
            this.MenuItem36,
            this.MenuItem37});
            this.mnu_sys_qtgl.Text = "前台信息(&R)";
            // 
            // MenuItem29
            // 
            this.MenuItem29.Index = 0;
            this.MenuItem29.Text = "单据设置 (&1)";
            this.MenuItem29.Click += new System.EventHandler(this.MenuItem29_Click);
            // 
            // MenuItem30
            // 
            this.MenuItem30.Index = 1;
            this.MenuItem30.Text = "营业时段 (&2)";
            this.MenuItem30.Click += new System.EventHandler(this.MenuItem30_Click);
            // 
            // MenuItem31
            // 
            this.MenuItem31.Index = 2;
            this.MenuItem31.Text = "结账方式 (&3)";
            this.MenuItem31.Click += new System.EventHandler(this.MenuItem31_Click);
            // 
            // MenuItem32
            // 
            this.MenuItem32.Index = 3;
            this.MenuItem32.Text = "-";
            // 
            // MenuItem33
            // 
            this.MenuItem33.Index = 4;
            this.MenuItem33.Text = "减免原因 (&4)";
            this.MenuItem33.Click += new System.EventHandler(this.MenuItem33_Click);
            // 
            // MenuItem34
            // 
            this.MenuItem34.Index = 5;
            this.MenuItem34.Text = "取消原因 (&5)";
            this.MenuItem34.Click += new System.EventHandler(this.MenuItem34_Click);
            // 
            // MenuItem35
            // 
            this.MenuItem35.Index = 6;
            this.MenuItem35.Text = "-";
            // 
            // MenuItem36
            // 
            this.MenuItem36.Index = 7;
            this.MenuItem36.Text = "桌台类别/位置 (&6)";
            this.MenuItem36.Click += new System.EventHandler(this.MenuItem36_Click);
            // 
            // MenuItem37
            // 
            this.MenuItem37.Index = 8;
            this.MenuItem37.Text = "桌台管理 (&7)";
            this.MenuItem37.Click += new System.EventHandler(this.MenuItem37_Click);
            // 
            // mnu_sys_sjgl
            // 
            this.mnu_sys_sjgl.Index = 5;
            this.mnu_sys_sjgl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem40,
            this.MenuItem8,
            this.MenuItem13,
            this.MenuItem39});
            this.mnu_sys_sjgl.Text = "数据库(&D)";
            // 
            // MenuItem40
            // 
            this.MenuItem40.Index = 0;
            this.MenuItem40.Text = "清除营业数据 (&1)";
            this.MenuItem40.Click += new System.EventHandler(this.MenuItem40_Click);
            // 
            // MenuItem8
            // 
            this.MenuItem8.Index = 1;
            this.MenuItem8.Text = "清空全部数据(&2)";
            this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
            // 
            // MenuItem13
            // 
            this.MenuItem13.Index = 2;
            this.MenuItem13.Text = "-";
            // 
            // MenuItem39
            // 
            this.MenuItem39.Index = 3;
            this.MenuItem39.Text = "数据备份 (&3)";
            this.MenuItem39.Click += new System.EventHandler(this.MenuItem39_Click);
            // 
            // MenuItem49
            // 
            this.MenuItem49.Index = 6;
            this.MenuItem49.MdiList = true;
            this.MenuItem49.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem50,
            this.MenuItem51,
            this.MenuItem52,
            this.MenuItem53});
            this.MenuItem49.Text = "窗口(&W)";
            // 
            // MenuItem50
            // 
            this.MenuItem50.Index = 0;
            this.MenuItem50.Text = "排列 (&A)";
            this.MenuItem50.Click += new System.EventHandler(this.MenuItem50_Click);
            // 
            // MenuItem51
            // 
            this.MenuItem51.Index = 1;
            this.MenuItem51.Text = "层叠 (&C)";
            this.MenuItem51.Click += new System.EventHandler(this.MenuItem51_Click);
            // 
            // MenuItem52
            // 
            this.MenuItem52.Index = 2;
            this.MenuItem52.Text = "水平平铺 (&H)";
            this.MenuItem52.Click += new System.EventHandler(this.MenuItem52_Click);
            // 
            // MenuItem53
            // 
            this.MenuItem53.Index = 3;
            this.MenuItem53.Text = "垂直平铺 (&V)";
            this.MenuItem53.Click += new System.EventHandler(this.MenuItem53_Click);
            // 
            // MenuItem44
            // 
            this.MenuItem44.Index = 7;
            this.MenuItem44.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem45,
            this.MenuItem46,
            this.mnuAbout});
            this.MenuItem44.Text = "帮助(&H)";
            // 
            // MenuItem45
            // 
            this.MenuItem45.Index = 0;
            this.MenuItem45.Text = "帮助主题";
            this.MenuItem45.Click += new System.EventHandler(this.MenuItem45_Click);
            // 
            // MenuItem46
            // 
            this.MenuItem46.Index = 1;
            this.MenuItem46.Text = "-";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 2;
            this.mnuAbout.Text = "关于";
            this.mnuAbout.Click += new System.EventHandler(this.MenuItem48_Click);
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton4,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton5,
            this.ToolBarButton6,
            this.ToolBarButton7,
            this.ToolBarButton8,
            this.ToolBarButton9,
            this.ToolBarButton10,
            this.ToolBarButton11,
            this.ToolBarButton12,
            this.ToolBarButton13,
            this.ToolBarButton14,
            this.ToolBarButton16,
            this.ToolBarButton15});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(58, 55);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(656, 56);
            this.ToolBar1.TabIndex = 1;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "系统设置";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.ImageIndex = 1;
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Text = "客户管理";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 2;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "会员卡";
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.ImageIndex = 3;
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Text = "公司雇员";
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 4;
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Text = "操作权限";
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
            this.ToolBarButton9.Text = "菜品信息";
            // 
            // ToolBarButton10
            // 
            this.ToolBarButton10.Name = "ToolBarButton10";
            this.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton11
            // 
            this.ToolBarButton11.ImageIndex = 6;
            this.ToolBarButton11.Name = "ToolBarButton11";
            this.ToolBarButton11.Text = "桌台位置";
            // 
            // ToolBarButton12
            // 
            this.ToolBarButton12.ImageIndex = 7;
            this.ToolBarButton12.Name = "ToolBarButton12";
            this.ToolBarButton12.Text = "桌台管理";
            // 
            // ToolBarButton13
            // 
            this.ToolBarButton13.Name = "ToolBarButton13";
            this.ToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton14
            // 
            this.ToolBarButton14.ImageIndex = 8;
            this.ToolBarButton14.Name = "ToolBarButton14";
            this.ToolBarButton14.Text = "关于";
            // 
            // ToolBarButton16
            // 
            this.ToolBarButton16.Name = "ToolBarButton16";
            this.ToolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton15
            // 
            this.ToolBarButton15.ImageIndex = 9;
            this.ToolBarButton15.Name = "ToolBarButton15";
            this.ToolBarButton15.Text = "退出";
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
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 244);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel2,
            this.StatusBarPanel3,
            this.StatusBarPanel4,
            this.StatusBarPanel5,
            this.StatusBarPanel6});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(656, 22);
            this.StatusBar1.TabIndex = 7;
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
            this.StatusBarPanel5.Width = 212;
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
            // frmSysAdmin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(656, 266);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.MainMenu1;
            this.Name = "frmSysAdmin";
            this.Text = " - 系统管理";
            this.Load += new System.EventHandler(this.mainform_Load);
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
		
		//打开客户类别窗口
		private void ShowCustTypeForm()
		{
			if (rms_var.frmCustTyp == null)
			{
				rms_var.frmCustTyp = new frmCustType();
				rms_var.frmCustTyp.MdiParent = this;
				rms_var.frmCustTyp.dgCustType.Height = rms_var.frmCustTyp.Height - rms_var.frmCustTyp.ToolBar1.Height - 35;
				rms_var.frmCustTyp.Panel1.Visible = false;
				rms_var.frmCustTyp.Show();
			}
			else
			{
				rms_var.frmCustTyp.BringToFront();
				rms_var.frmCustTyp.WindowState = FormWindowState.Normal;
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
		
		//打开会员卡管理窗口
		private void ShowCardForm()
		{
			if (rms_var.frmcard == null)
			{
				rms_var.frmcard = new frmClubCard();
				rms_var.frmcard.MdiParent = this;
				rms_var.frmcard.Show();
			}
			else
			{
				rms_var.frmcard.BringToFront();
				rms_var.frmcard.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开会员累计折让比率窗口
		private void ShowCardAddupDisc()
		{
			if (rms_var.frmCardAUD == null)
			{
				rms_var.frmCardAUD = new frmCardAddupDisc();
				rms_var.frmCardAUD.MdiParent = this;
				rms_var.frmCardAUD.dgCardAddUpdis.Height = rms_var.frmCardAUD.Height - rms_var.frmCardAUD.ToolBar1.Height - 35;
				rms_var.frmCardAUD.Panel1.Visible = false;
				rms_var.frmCardAUD.Show();
			}
			else
			{
				rms_var.frmCardAUD.BringToFront();
				rms_var.frmCardAUD.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开查询会员充值记录窗口
		private void ShowSrchCardSplForm()
		{
			if (rms_var.frmscspl == null)
			{
				rms_var.frmscspl = new frmSrchCardSpl();
				rms_var.frmscspl.MdiParent = this;
				rms_var.frmscspl.Show();
			}
			else
			{
				rms_var.frmscspl.BringToFront();
				rms_var.frmscspl.WindowState = FormWindowState.Normal;
			}
		}
		
		//*******"
		
		//打开部门窗口
		private void ShowDeptForm()
		{
			if (rms_var.frmDepartment == null)
			{
				rms_var.frmDepartment = new frmDept();
				rms_var.frmDepartment.MdiParent = this;
				rms_var.frmDepartment.Show();
			}
			else
			{
				rms_var.frmDepartment.BringToFront();
				rms_var.frmDepartment.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开雇员窗口
		private void ShowEmployeeForm()
		{
			if (rms_var.frmEmpl == null)
			{
				rms_var.frmEmpl = new frmEmployee();
				rms_var.frmEmpl.MdiParent = this;
				rms_var.frmEmpl.Show();
			}
			else
			{
				rms_var.frmEmpl.BringToFront();
				rms_var.frmEmpl.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开帐号/权限窗口
		private void ShowAccessForm()
		{
			if (rms_var.frmacs == null)
			{
				rms_var.frmacs = new frmAccess();
				rms_var.frmacs.MdiParent = this;
				rms_var.frmacs.Show();
			}
			else
			{
				rms_var.frmacs.BringToFront();
				rms_var.frmacs.WindowState = FormWindowState.Normal;
			}
		}
		
		//*******"
		
		//打开菜品类别窗口
		private void ShowFoodTypeForm()
		{
			if (rms_var.frmfoodtyp == null)
			{
				rms_var.frmfoodtyp = new frmFoodType();
				rms_var.frmfoodtyp.MdiParent = this;
				rms_var.frmfoodtyp.dgFoodType.Height = rms_var.frmfoodtyp.Height - rms_var.frmfoodtyp.ToolBar1.Height - 35;
				rms_var.frmfoodtyp.Panel1.Visible = false;
				rms_var.frmfoodtyp.Show();
			}
			else
			{
				rms_var.frmfoodtyp.BringToFront();
				rms_var.frmfoodtyp.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开菜品列表窗口
		private void ShowFoodListForm()
		{
			if (rms_var.frmfoodlst == null)
			{
				rms_var.frmfoodlst = new frmFoodList();
				rms_var.frmfoodlst.MdiParent = this;
				rms_var.frmfoodlst.Show();
			}
			else
			{
				rms_var.frmfoodlst.BringToFront();
				rms_var.frmfoodlst.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开菜品做法窗口
		private void ShowFoodOperandiForm()
		{
			//Dim frmfoodop As New frmEditFoodOperandi
			//frmfoodop.frmMode = 1 '1=编辑做法
			//frmfoodop.ShowDialog()
			
			if (rms_var.frmfoodop == null)
			{
				rms_var.frmfoodop = new frmEditFoodOperandi();
				rms_var.frmfoodop.frmMode = 1; //1=编辑做法
				rms_var.frmfoodop.Label5.Text = "若要修改做法，请双击相应做法条目的导航列，然后更新。";
				rms_var.frmfoodop.MdiParent = this;
				rms_var.frmfoodop.Show();
			}
			else
			{
				rms_var.frmfoodop.BringToFront();
				rms_var.frmfoodop.WindowState = FormWindowState.Normal;
			}
			
		}
		
		//打开菜品口味窗口
		private void ShowFoodTasteForm()
		{
			//Dim frmfoodtst As New frmEditFoodTaste
			//frmfoodtst.frmMode = 1 '1=编辑口味
			//frmfoodtst.ShowDialog()
			
			if (rms_var.frmfoodtst == null)
			{
				rms_var.frmfoodtst = new frmEditFoodTaste();
				rms_var.frmfoodtst.frmMode = 1; //1=编辑口味
				rms_var.frmfoodtst.Label5.Text = "若要修改口味，请双击相应口味条目的导航列，然后更新。";
				rms_var.frmfoodtst.MdiParent = this;
				rms_var.frmfoodtst.Show();
			}
			else
			{
				rms_var.frmfoodtst.BringToFront();
				rms_var.frmfoodtst.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开菜品优惠窗口
		private void ShowFoodDiscountForm()
		{
			if (rms_var.frmFoodDisc == null)
			{
				rms_var.frmFoodDisc = new frmFoodDiscount();
				rms_var.frmFoodDisc.MdiParent = this;
				rms_var.frmFoodDisc.dgFoodDiscount.Height = rms_var.frmFoodDisc.Height - rms_var.frmFoodDisc.ToolBar1.Height - 35;
				rms_var.frmFoodDisc.Panel1.Visible = false;
				rms_var.frmFoodDisc.Show();
			}
			else
			{
				rms_var.frmFoodDisc.BringToFront();
				rms_var.frmFoodDisc.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开套餐设置窗口
		private void ShowSuitFoodForm()
		{
			if (rms_var.frmsuit == null)
			{
				rms_var.frmsuit = new frmSuitFood();
				rms_var.frmsuit.MdiParent = this;
				rms_var.frmsuit.dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
				rms_var.frmsuit.Panel1.Visible = false;
				rms_var.frmsuit.Show();
			}
			else
			{
				rms_var.frmsuit.BringToFront();
				rms_var.frmsuit.WindowState = FormWindowState.Normal;
			}
		}
		
		//*******"
		
		//打开单据类别窗口
		private void ShowBillTypeForm()
		{
			if (rms_var.frmBilltyp == null)
			{
				rms_var.frmBilltyp = new frmBillType();
				rms_var.frmBilltyp.MdiParent = this;
				rms_var.frmBilltyp.dgBillType.Height = rms_var.frmBilltyp.Height - rms_var.frmBilltyp.ToolBar1.Height - 35;
				rms_var.frmBilltyp.Panel1.Visible = false;
				rms_var.frmBilltyp.Show();
			}
			else
			{
				rms_var.frmBilltyp.BringToFront();
				rms_var.frmBilltyp.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开时间段窗口
		private void ShowTimeBlockForm()
		{
			if (rms_var.frmTimeblk == null)
			{
				rms_var.frmTimeblk = new frmTimeBlock();
				rms_var.frmTimeblk.MdiParent = this;
				rms_var.frmTimeblk.dgTimeBlock.Height = rms_var.frmTimeblk.Height - rms_var.frmTimeblk.ToolBar1.Height - 35;
				rms_var.frmTimeblk.Panel1.Visible = false;
				rms_var.frmTimeblk.Show();
			}
			else
			{
				rms_var.frmTimeblk.BringToFront();
				rms_var.frmTimeblk.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开结账方式窗口
		private void ShowPayTypeForm()
		{
			if (rms_var.frmPayTyp == null)
			{
				rms_var.frmPayTyp = new frmPayType();
				rms_var.frmPayTyp.MdiParent = this;
				rms_var.frmPayTyp.dgPayType.Height = rms_var.frmPayTyp.Height - rms_var.frmPayTyp.ToolBar1.Height - 35;
				rms_var.frmPayTyp.Panel1.Visible = false;
				rms_var.frmPayTyp.Show();
			}
			else
			{
				rms_var.frmPayTyp.BringToFront();
				rms_var.frmPayTyp.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开减免原因窗口
		private void ShowDerateReasonForm()
		{
			if (rms_var.frmDerateRsn == null)
			{
				rms_var.frmDerateRsn = new frmDerateReason();
				rms_var.frmDerateRsn.MdiParent = this;
				rms_var.frmDerateRsn.dgDerateReason.Height = rms_var.frmDerateRsn.Height - rms_var.frmDerateRsn.ToolBar1.Height - 35;
				rms_var.frmDerateRsn.Panel1.Visible = false;
				rms_var.frmDerateRsn.Show();
			}
			else
			{
				rms_var.frmDerateRsn.BringToFront();
				rms_var.frmDerateRsn.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开取消原因窗口
		private void ShowCancelReasonForm()
		{
			if (rms_var.frmCancelRsn == null)
			{
				rms_var.frmCancelRsn = new frmCancelReason();
				rms_var.frmCancelRsn.MdiParent = this;
				rms_var.frmCancelRsn.dgCancelReason.Height = rms_var.frmCancelRsn.Height - rms_var.frmCancelRsn.ToolBar1.Height - 35;
				rms_var.frmCancelRsn.Panel1.Visible = false;
				rms_var.frmCancelRsn.Show();
			}
			else
			{
				rms_var.frmCancelRsn.BringToFront();
				rms_var.frmCancelRsn.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开桌台类别窗口
		private void ShowTableTypeForm()
		{
			if (rms_var.frmTabletyp == null)
			{
				rms_var.frmTabletyp = new frmTableType();
				rms_var.frmTabletyp.MdiParent = this;
				rms_var.frmTabletyp.dgTableType.Height = rms_var.frmTabletyp.Height - rms_var.frmTabletyp.ToolBar1.Height - 35;
				rms_var.frmTabletyp.Panel1.Visible = false;
				rms_var.frmTabletyp.Show();
			}
			else
			{
				rms_var.frmTabletyp.BringToFront();
				rms_var.frmTabletyp.WindowState = FormWindowState.Normal;
			}
		}
		
		//打开桌台类别窗口
		private void ShowTableListForm()
		{
			if (rms_var.frmTablelst == null)
			{
				rms_var.frmTablelst = new frmTableList();
				rms_var.frmTablelst.MdiParent = this;
				rms_var.frmTablelst.Show();
			}
			else
			{
				rms_var.frmTablelst.BringToFront();
				rms_var.frmTablelst.WindowState = FormWindowState.Normal;
			}
		}
		
		private void mainform_Load(System.Object sender, System.EventArgs e)
		{
			rms_var.mainfrm = this;
			//创建类库对象的实例，只创建这一次
			rms_var.TheAppExt = new AppExt.CAppExt();
			this.Text = rms_var.TheAppExt.GetAppTitle + this.Text;
			mnuAbout.Text = "关于 " + rms_var.TheAppExt.GetAppTitle;
			
			rms_var.TheAppExt.LogModule = 1; //报告登录的是->系统管理模块
			string rtn = rms_var.TheAppExt.ShowLogForm("系统管理");
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
			
			//检测数据管理权限和操作权限
			//系统设置
			mnu_sys_sz.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
			spt_1.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
			ToolBarButton1.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
			ToolBarButton4.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
			
			//客户管理权限
			mnu_sys_khgl.Visible = rms_var.TheAppExt.Chk_Sys_khgl;
			ToolBarButton2.Visible = rms_var.TheAppExt.Chk_Sys_khgl;
			
			//人员管理
			mnu_Sys_rygl.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
			ToolBarButton3.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
			ToolBarButton5.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
			ToolBarButton6.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
			ToolBarButton7.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
			ToolBarButton8.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
			
			//菜品管理
			mnu_sys_cpgl.Visible = rms_var.TheAppExt.Chk_Sys_cpgl;
			ToolBarButton9.Visible = rms_var.TheAppExt.Chk_Sys_cpgl;
			ToolBarButton10.Visible = rms_var.TheAppExt.Chk_Sys_cpgl;
			
			//前台信息管理
			mnu_sys_qtgl.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
			ToolBarButton11.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
			ToolBarButton12.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
			ToolBarButton13.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
			
			//数据管理
			mnu_sys_sjgl.Visible = rms_var.TheAppExt.Chk_Sys_sjgl;
		}
		
		private void MenuItem14_Click(System.Object sender, System.EventArgs e)
		{
			ShowDeptForm();
		}
		
		private void MenuItem50_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
		}
		
		private void MenuItem51_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}
		
		private void MenuItem52_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}
		
		private void MenuItem53_Click(System.Object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}
		
		private void MenuItem15_Click(System.Object sender, System.EventArgs e)
		{
			ShowEmployeeForm();
		}
		
		private void MenuItem17_Click(System.Object sender, System.EventArgs e)
		{
			ShowAccessForm();
		}
		
		private void MenuItem2_Click(System.Object sender, System.EventArgs e)
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
				
				rms_var.TheAppExt.LogModule = 1; //报告登录的是->系统管理模块
				string rtn = rms_var.TheAppExt.ShowLogForm("系统管理");
				if (rtn.Trim() == "-1")
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
				
				//检测数据管理权限和操作权限
				//系统设置
				mnu_sys_sz.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
				spt_1.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
				ToolBarButton1.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
				ToolBarButton4.Visible = rms_var.TheAppExt.Chk_Sys_xtsz;
				
				//客户管理权限
				mnu_sys_khgl.Visible = rms_var.TheAppExt.Chk_Sys_khgl;
				ToolBarButton2.Visible = rms_var.TheAppExt.Chk_Sys_khgl;
				
				//人员管理
				mnu_Sys_rygl.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
				ToolBarButton3.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
				ToolBarButton5.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
				ToolBarButton6.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
				ToolBarButton7.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
				ToolBarButton8.Visible = rms_var.TheAppExt.Chk_Sys_rygl;
				
				//菜品管理
				mnu_sys_cpgl.Visible = rms_var.TheAppExt.Chk_Sys_cpgl;
				ToolBarButton9.Visible = rms_var.TheAppExt.Chk_Sys_cpgl;
				ToolBarButton10.Visible = rms_var.TheAppExt.Chk_Sys_cpgl;
				
				//前台信息管理
				mnu_sys_qtgl.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
				ToolBarButton11.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
				ToolBarButton12.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
				ToolBarButton13.Visible = rms_var.TheAppExt.Chk_Sys_qtgl;
				
				//数据管理
				mnu_sys_sjgl.Visible = rms_var.TheAppExt.Chk_Sys_sjgl;
			}
		}
		
		private void MenuItem4_Click(System.Object sender, System.EventArgs e)
		{
            Application.Exit();
		}
		
		private void mnu_sys_sz_Click(System.Object sender, System.EventArgs e)
		{
			frmSysSetup frmsysstp = new frmSysSetup();
			frmsysstp.ShowDialog();
		}
		
		private void MenuItem6_Click(System.Object sender, System.EventArgs e)
		{
			ShowCustTypeForm();
		}
		
		private void MenuItem7_Click(System.Object sender, System.EventArgs e)
		{
			ShowCustForm();
		}
		
		private void MenuItem10_Click(System.Object sender, System.EventArgs e)
		{
			ShowCardForm();
		}
		
		private void MenuItem11_Click(System.Object sender, System.EventArgs e)
		{
			ShowCardAddupDisc();
		}
		
		private void MenuItem12_Click(System.Object sender, System.EventArgs e)
		{
			ShowSrchCardSplForm();
		}
		
		private void MenuItem19_Click(System.Object sender, System.EventArgs e)
		{
			ShowFoodTypeForm();
		}
		
		private void MenuItem20_Click(System.Object sender, System.EventArgs e)
		{
			ShowFoodListForm();
		}
		
		private void MenuItem21_Click(System.Object sender, System.EventArgs e)
		{
			ShowFoodOperandiForm();
		}
		
		private void MenuItem22_Click(System.Object sender, System.EventArgs e)
		{
			ShowFoodTasteForm();
		}
		
		private void MenuItem24_Click(System.Object sender, System.EventArgs e)
		{
			ShowFoodDiscountForm();
		}
		
		private void MenuItem25_Click(System.Object sender, System.EventArgs e)
		{
			ShowSuitFoodForm();
		}
		
		private void MenuItem29_Click(System.Object sender, System.EventArgs e)
		{
			ShowBillTypeForm();
		}
		
		private void MenuItem30_Click(System.Object sender, System.EventArgs e)
		{
			ShowTimeBlockForm();
		}
		
		private void MenuItem5_Click(System.Object sender, System.EventArgs e)
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
		
		private void MenuItem31_Click(System.Object sender, System.EventArgs e)
		{
			ShowPayTypeForm();
		}
		
		private void MenuItem33_Click(System.Object sender, System.EventArgs e)
		{
			ShowDerateReasonForm();
		}
		
		private void MenuItem34_Click(System.Object sender, System.EventArgs e)
		{
			ShowCancelReasonForm();
		}
		
		private void MenuItem36_Click(System.Object sender, System.EventArgs e)
		{
			ShowTableTypeForm();
		}
		
		private void MenuItem37_Click(System.Object sender, System.EventArgs e)
		{
			ShowTableListForm();
		}
		
		private void MenuItem48_Click(System.Object sender, System.EventArgs e)
		{
			System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
			string ver;
			
			ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
			
			rms_var.TheAppExt.ShowAboutForm(ver, "98b0");
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //系统设置
					mnu_sys_sz_Click(sender, e);
					break;
				case 2: //客户管理
					MenuItem7_Click(sender, e);
					break;
				case 3: //会员卡管理
					MenuItem10_Click(sender, e);
					break;
				case 5: //公司雇员管理
					MenuItem15_Click(sender, e);
					break;
				case 6: //操作权限
					MenuItem17_Click(sender, e);
					break;
				case 8: //菜品信息管理
					MenuItem20_Click(sender, e);
					break;
				case 10: //桌台位置管理
					MenuItem36_Click(sender, e);
					break;
				case 11: //桌台管理
					MenuItem37_Click(sender, e);
					break;
				case 13: //关于
					MenuItem48_Click(sender, e);
					break;
				case 15: //关闭
					this.Close();
					break;
			}
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
		
		private void MenuItem45_Click(System.Object sender, System.EventArgs e)
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
		
		private void MenuItem39_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("确定要备份数据库吗？" + '\r' + '\r' + "备份文件将会保存在 安装文件夹\\RMS\\DB 下。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string CurrentPath;
				
				CurrentPath = Directory.GetCurrentDirectory();
				if (CurrentPath[CurrentPath.Length - 1] !='\\')
				{
					CurrentPath += "\\";
				}
				if (rms_var.BackupDB(rms_var.GetAppPath() + "db\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bak"))
				{
					MessageBox.Show("备份操作顺利完成。");
				}
			}
		}
		
		private void MenuItem40_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("确定要清除所有营业数据吗？" + '\r' + '\r' + "该操作仅删除营业数据，将数据库信息恢复到初始状态，所有基本数据都将会保留。该操作不可逆，请谨慎操作！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (rms_var.ClearDB(0))
				{
					MessageBox.Show("清除营业数据操作顺利完成。");
				}
			}
			
		}
		
		private void MenuItem8_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("确定要清空全部数据吗？" + '\r' + '\r' + "该操作会删除系统中所有数据，删除营业数据的同时还删除所有基本数据。该操作不可逆，请谨慎操作！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				if (MessageBox.Show("再次确定要清空全部数据吗？" + '\r' + '\r' + "清空全部数据后系统的启动和运行有可能会出现问题，请谨慎操作！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (rms_var.ClearDB(1))
					{
						MessageBox.Show("清空全部数据操作顺利完成。");
					}
				}
			}
		}
	}
	
	
	
}
