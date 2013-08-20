using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Text;
using System.Security.Cryptography;
using System.IO;


namespace Kitchen
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
		internal System.Windows.Forms.StatusBar StatusBar1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel1;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel2;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel3;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel4;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel5;
		internal System.Windows.Forms.StatusBarPanel StatusBarPanel6;
		internal System.Timers.Timer Timer1;
		internal System.Windows.Forms.MainMenu MainMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.MenuItem MenuItem4;
		internal System.Windows.Forms.MenuItem MenuItem44;
		internal System.Windows.Forms.MenuItem MenuItem45;
		internal System.Windows.Forms.MenuItem MenuItem46;
		internal System.Windows.Forms.MenuItem MenuItem5;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGrid DataGrid1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.DataGrid DataGrid2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.DataGrid DataGrid3;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.TextBox txtFoodCode;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn14;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn15;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn16;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn17;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn18;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn19;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn20;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn21;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn22;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn23;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn24;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn25;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn26;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn27;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn28;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn29;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn30;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn31;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn32;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn33;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn34;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn35;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn36;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn37;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn38;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn39;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn40;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn41;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.MenuItem mnuAbout;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.StatusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
            this.StatusBarPanel6 = new System.Windows.Forms.StatusBarPanel();
            this.Timer1 = new System.Timers.Timer();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem5 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.MenuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem44 = new System.Windows.Forms.MenuItem();
            this.MenuItem45 = new System.Windows.Forms.MenuItem();
            this.MenuItem46 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DataGrid2 = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.txtFoodCode = new System.Windows.Forms.TextBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DataGrid3 = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.DataGridTextBoxColumn28 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn29 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn30 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn31 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn32 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn33 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn34 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn35 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn36 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn37 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn38 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn39 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn40 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn41 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 403);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel1,
            this.StatusBarPanel2,
            this.StatusBarPanel3,
            this.StatusBarPanel4,
            this.StatusBarPanel5,
            this.StatusBarPanel6});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(648, 22);
            this.StatusBar1.SizingGrip = false;
            this.StatusBar1.TabIndex = 1;
            this.StatusBar1.Text = "StatusBar1";
            // 
            // StatusBarPanel1
            // 
            this.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.StatusBarPanel1.Name = "StatusBarPanel1";
            this.StatusBarPanel1.Width = 10;
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
            this.StatusBarPanel5.Width = 210;
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
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem44});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem5,
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem4});
            this.MenuItem1.Text = "系统(&S)";
            // 
            // MenuItem5
            // 
            this.MenuItem5.Index = 0;
            this.MenuItem5.Text = "更改个人密码 (&2)";
            this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.Text = "注销/重新登录(&3)";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Index = 2;
            this.MenuItem3.Text = "-";
            // 
            // MenuItem4
            // 
            this.MenuItem4.Index = 3;
            this.MenuItem4.Text = "退出 (&4)";
            this.MenuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
            // 
            // MenuItem44
            // 
            this.MenuItem44.Index = 1;
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
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.ItemSize = new System.Drawing.Size(72, 20);
            this.TabControl1.Location = new System.Drawing.Point(8, 16);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(632, 384);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TextBox1);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.DataGrid1);
            this.TabPage1.Controls.Add(this.Button1);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.ListBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(624, 356);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = " 条码上菜 ";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(80, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(184, 21);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.Teal;
            this.Label2.Location = new System.Drawing.Point(8, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(608, 96);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "扫描条码或在编辑框中输入条码数字，回车即可完成出菜";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGrid1
            // 
            this.DataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid1.CaptionVisible = false;
            this.DataGrid1.DataMember = "";
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(8, 152);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(608, 192);
            this.DataGrid1.TabIndex = 2;
            this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.DataGrid1;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4,
            this.DataGridTextBoxColumn5,
            this.DataGridTextBoxColumn6,
            this.DataGridTextBoxColumn7,
            this.DataGridTextBoxColumn8,
            this.DataGridTextBoxColumn9,
            this.DataGridTextBoxColumn10,
            this.DataGridTextBoxColumn14,
            this.DataGridTextBoxColumn11,
            this.DataGridTextBoxColumn12,
            this.DataGridTextBoxColumn13});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "barcodefoods";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "单据号";
            this.DataGridTextBoxColumn1.MappingName = "billno";
            this.DataGridTextBoxColumn1.NullText = "";
            this.DataGridTextBoxColumn1.Width = 120;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "单据类别";
            this.DataGridTextBoxColumn2.MappingName = "name";
            this.DataGridTextBoxColumn2.NullText = "";
            this.DataGridTextBoxColumn2.Width = 75;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "桌台号";
            this.DataGridTextBoxColumn3.MappingName = "tableno";
            this.DataGridTextBoxColumn3.NullText = "";
            this.DataGridTextBoxColumn3.Width = 75;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "桌台名称";
            this.DataGridTextBoxColumn4.MappingName = "foodcode";
            this.DataGridTextBoxColumn4.NullText = "";
            this.DataGridTextBoxColumn4.Width = 105;
            // 
            // DataGridTextBoxColumn5
            // 
            this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn5.Format = "";
            this.DataGridTextBoxColumn5.FormatInfo = null;
            this.DataGridTextBoxColumn5.HeaderText = "菜品名称";
            this.DataGridTextBoxColumn5.MappingName = "foodname";
            this.DataGridTextBoxColumn5.NullText = "";
            this.DataGridTextBoxColumn5.Width = 150;
            // 
            // DataGridTextBoxColumn6
            // 
            this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn6.Format = "";
            this.DataGridTextBoxColumn6.FormatInfo = null;
            this.DataGridTextBoxColumn6.HeaderText = "类别编码";
            this.DataGridTextBoxColumn6.MappingName = "foodtypecode";
            this.DataGridTextBoxColumn6.NullText = "";
            this.DataGridTextBoxColumn6.Width = 55;
            // 
            // DataGridTextBoxColumn7
            // 
            this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn7.Format = "";
            this.DataGridTextBoxColumn7.FormatInfo = null;
            this.DataGridTextBoxColumn7.HeaderText = "拼音码";
            this.DataGridTextBoxColumn7.MappingName = "spell";
            this.DataGridTextBoxColumn7.NullText = "";
            this.DataGridTextBoxColumn7.Width = 55;
            // 
            // DataGridTextBoxColumn8
            // 
            this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn8.Format = "";
            this.DataGridTextBoxColumn8.FormatInfo = null;
            this.DataGridTextBoxColumn8.HeaderText = "单位";
            this.DataGridTextBoxColumn8.MappingName = "unit";
            this.DataGridTextBoxColumn8.NullText = "";
            this.DataGridTextBoxColumn8.Width = 55;
            // 
            // DataGridTextBoxColumn9
            // 
            this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn9.Format = "";
            this.DataGridTextBoxColumn9.FormatInfo = null;
            this.DataGridTextBoxColumn9.HeaderText = "数量";
            this.DataGridTextBoxColumn9.MappingName = "addquantity";
            this.DataGridTextBoxColumn9.NullText = "";
            this.DataGridTextBoxColumn9.Width = 55;
            // 
            // DataGridTextBoxColumn10
            // 
            this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn10.Format = "";
            this.DataGridTextBoxColumn10.FormatInfo = null;
            this.DataGridTextBoxColumn10.HeaderText = "单价";
            this.DataGridTextBoxColumn10.MappingName = "price";
            this.DataGridTextBoxColumn10.NullText = "";
            this.DataGridTextBoxColumn10.Width = 75;
            // 
            // DataGridTextBoxColumn14
            // 
            this.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn14.Format = "";
            this.DataGridTextBoxColumn14.FormatInfo = null;
            this.DataGridTextBoxColumn14.HeaderText = "条码";
            this.DataGridTextBoxColumn14.MappingName = "barcode";
            this.DataGridTextBoxColumn14.NullText = "";
            this.DataGridTextBoxColumn14.Width = 75;
            // 
            // DataGridTextBoxColumn11
            // 
            this.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn11.Format = "";
            this.DataGridTextBoxColumn11.FormatInfo = null;
            this.DataGridTextBoxColumn11.HeaderText = "做法";
            this.DataGridTextBoxColumn11.MappingName = "operandi";
            this.DataGridTextBoxColumn11.NullText = "";
            this.DataGridTextBoxColumn11.Width = 140;
            // 
            // DataGridTextBoxColumn12
            // 
            this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn12.Format = "";
            this.DataGridTextBoxColumn12.FormatInfo = null;
            this.DataGridTextBoxColumn12.HeaderText = "口味";
            this.DataGridTextBoxColumn12.MappingName = "taste";
            this.DataGridTextBoxColumn12.NullText = "";
            this.DataGridTextBoxColumn12.Width = 140;
            // 
            // DataGridTextBoxColumn13
            // 
            this.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn13.Format = "";
            this.DataGridTextBoxColumn13.FormatInfo = null;
            this.DataGridTextBoxColumn13.HeaderText = "点菜时间";
            this.DataGridTextBoxColumn13.MappingName = "begintime";
            this.DataGridTextBoxColumn13.NullText = "";
            this.DataGridTextBoxColumn13.Width = 120;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(270, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 38);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "上菜(&S)";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(16, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "菜品条码：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.ItemHeight = 12;
            this.ListBox1.Location = new System.Drawing.Point(8, 352);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(608, 4);
            this.ListBox1.TabIndex = 3;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.NumericUpDown1);
            this.TabPage2.Controls.Add(this.Button2);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Controls.Add(this.ComboBox1);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.DataGrid2);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(624, 356);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = " 超时未上菜查询 ";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(48, 17);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(56, 21);
            this.NumericUpDown1.TabIndex = 0;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button2.Location = new System.Drawing.Point(296, 16);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "查询(&F)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.Location = new System.Drawing.Point(184, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 23);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "还未上菜的记录";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Items.AddRange(new object[] {
            "分钟",
            "小时"});
            this.ComboBox1.Location = new System.Drawing.Point(112, 17);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(64, 20);
            this.ComboBox1.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.Location = new System.Drawing.Point(16, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 23);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "超过";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGrid2
            // 
            this.DataGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid2.DataMember = "";
            this.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid2.Location = new System.Drawing.Point(8, 48);
            this.DataGrid2.Name = "DataGrid2";
            this.DataGrid2.ReadOnly = true;
            this.DataGrid2.Size = new System.Drawing.Size(608, 301);
            this.DataGrid2.TabIndex = 3;
            this.DataGrid2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle2});
            // 
            // DataGridTableStyle2
            // 
            this.DataGridTableStyle2.DataGrid = this.DataGrid2;
            this.DataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn15,
            this.DataGridTextBoxColumn16,
            this.DataGridTextBoxColumn17,
            this.DataGridTextBoxColumn18,
            this.DataGridTextBoxColumn19,
            this.DataGridTextBoxColumn20,
            this.DataGridTextBoxColumn21,
            this.DataGridTextBoxColumn22,
            this.DataGridTextBoxColumn23,
            this.DataGridTextBoxColumn24,
            this.DataGridTextBoxColumn25,
            this.DataGridTextBoxColumn26,
            this.DataGridTextBoxColumn27});
            this.DataGridTableStyle2.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle2.MappingName = "overtimefoods";
            // 
            // DataGridTextBoxColumn15
            // 
            this.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn15.Format = "";
            this.DataGridTextBoxColumn15.FormatInfo = null;
            this.DataGridTextBoxColumn15.HeaderText = "单据号";
            this.DataGridTextBoxColumn15.MappingName = "billno";
            this.DataGridTextBoxColumn15.NullText = "";
            this.DataGridTextBoxColumn15.Width = 120;
            // 
            // DataGridTextBoxColumn16
            // 
            this.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn16.Format = "";
            this.DataGridTextBoxColumn16.FormatInfo = null;
            this.DataGridTextBoxColumn16.HeaderText = "单据类别";
            this.DataGridTextBoxColumn16.MappingName = "name";
            this.DataGridTextBoxColumn16.NullText = "";
            this.DataGridTextBoxColumn16.Width = 75;
            // 
            // DataGridTextBoxColumn17
            // 
            this.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn17.Format = "";
            this.DataGridTextBoxColumn17.FormatInfo = null;
            this.DataGridTextBoxColumn17.HeaderText = "桌台号";
            this.DataGridTextBoxColumn17.MappingName = "tableno";
            this.DataGridTextBoxColumn17.NullText = "";
            this.DataGridTextBoxColumn17.Width = 75;
            // 
            // DataGridTextBoxColumn18
            // 
            this.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn18.Format = "";
            this.DataGridTextBoxColumn18.FormatInfo = null;
            this.DataGridTextBoxColumn18.HeaderText = "桌台名称";
            this.DataGridTextBoxColumn18.MappingName = "foodcode";
            this.DataGridTextBoxColumn18.NullText = "";
            this.DataGridTextBoxColumn18.Width = 105;
            // 
            // DataGridTextBoxColumn19
            // 
            this.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn19.Format = "";
            this.DataGridTextBoxColumn19.FormatInfo = null;
            this.DataGridTextBoxColumn19.HeaderText = "菜品名称";
            this.DataGridTextBoxColumn19.MappingName = "foodname";
            this.DataGridTextBoxColumn19.NullText = "";
            this.DataGridTextBoxColumn19.Width = 150;
            // 
            // DataGridTextBoxColumn20
            // 
            this.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn20.Format = "";
            this.DataGridTextBoxColumn20.FormatInfo = null;
            this.DataGridTextBoxColumn20.HeaderText = "类别编码";
            this.DataGridTextBoxColumn20.MappingName = "foodtypecode";
            this.DataGridTextBoxColumn20.NullText = "";
            this.DataGridTextBoxColumn20.Width = 55;
            // 
            // DataGridTextBoxColumn21
            // 
            this.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn21.Format = "";
            this.DataGridTextBoxColumn21.FormatInfo = null;
            this.DataGridTextBoxColumn21.HeaderText = "拼音码";
            this.DataGridTextBoxColumn21.MappingName = "spell";
            this.DataGridTextBoxColumn21.NullText = "";
            this.DataGridTextBoxColumn21.Width = 55;
            // 
            // DataGridTextBoxColumn22
            // 
            this.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn22.Format = "";
            this.DataGridTextBoxColumn22.FormatInfo = null;
            this.DataGridTextBoxColumn22.HeaderText = "单位";
            this.DataGridTextBoxColumn22.MappingName = "unit";
            this.DataGridTextBoxColumn22.NullText = "";
            this.DataGridTextBoxColumn22.Width = 55;
            // 
            // DataGridTextBoxColumn23
            // 
            this.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn23.Format = "";
            this.DataGridTextBoxColumn23.FormatInfo = null;
            this.DataGridTextBoxColumn23.HeaderText = "数量";
            this.DataGridTextBoxColumn23.MappingName = "addquantity";
            this.DataGridTextBoxColumn23.NullText = "";
            this.DataGridTextBoxColumn23.Width = 55;
            // 
            // DataGridTextBoxColumn24
            // 
            this.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn24.Format = "";
            this.DataGridTextBoxColumn24.FormatInfo = null;
            this.DataGridTextBoxColumn24.HeaderText = "单价";
            this.DataGridTextBoxColumn24.MappingName = "price";
            this.DataGridTextBoxColumn24.NullText = "";
            this.DataGridTextBoxColumn24.Width = 75;
            // 
            // DataGridTextBoxColumn25
            // 
            this.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn25.Format = "";
            this.DataGridTextBoxColumn25.FormatInfo = null;
            this.DataGridTextBoxColumn25.HeaderText = "做法";
            this.DataGridTextBoxColumn25.MappingName = "operandi";
            this.DataGridTextBoxColumn25.NullText = "";
            this.DataGridTextBoxColumn25.Width = 140;
            // 
            // DataGridTextBoxColumn26
            // 
            this.DataGridTextBoxColumn26.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn26.Format = "";
            this.DataGridTextBoxColumn26.FormatInfo = null;
            this.DataGridTextBoxColumn26.HeaderText = "口味";
            this.DataGridTextBoxColumn26.MappingName = "taste";
            this.DataGridTextBoxColumn26.NullText = "";
            this.DataGridTextBoxColumn26.Width = 140;
            // 
            // DataGridTextBoxColumn27
            // 
            this.DataGridTextBoxColumn27.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn27.Format = "";
            this.DataGridTextBoxColumn27.FormatInfo = null;
            this.DataGridTextBoxColumn27.HeaderText = "点菜时间";
            this.DataGridTextBoxColumn27.MappingName = "begintime";
            this.DataGridTextBoxColumn27.NullText = "";
            this.DataGridTextBoxColumn27.Width = 120;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.txtFoodCode);
            this.TabPage3.Controls.Add(this.LinkLabel1);
            this.TabPage3.Controls.Add(this.DataGrid3);
            this.TabPage3.Location = new System.Drawing.Point(4, 24);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(624, 356);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = " 菜品查询 ";
            // 
            // txtFoodCode
            // 
            this.txtFoodCode.Location = new System.Drawing.Point(80, 16);
            this.txtFoodCode.Name = "txtFoodCode";
            this.txtFoodCode.Size = new System.Drawing.Size(136, 21);
            this.txtFoodCode.TabIndex = 0;
            this.txtFoodCode.TextChanged += new System.EventHandler(this.txtFoodCode_TextChanged);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Location = new System.Drawing.Point(16, 16);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(72, 23);
            this.LinkLabel1.TabIndex = 2;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "菜品过滤：";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // DataGrid3
            // 
            this.DataGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid3.DataMember = "";
            this.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid3.Location = new System.Drawing.Point(8, 48);
            this.DataGrid3.Name = "DataGrid3";
            this.DataGrid3.ReadOnly = true;
            this.DataGrid3.Size = new System.Drawing.Size(608, 301);
            this.DataGrid3.TabIndex = 1;
            this.DataGrid3.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle3});
            // 
            // DataGridTableStyle3
            // 
            this.DataGridTableStyle3.DataGrid = this.DataGrid3;
            this.DataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridBoolColumn1,
            this.DataGridTextBoxColumn28,
            this.DataGridTextBoxColumn29,
            this.DataGridTextBoxColumn30,
            this.DataGridTextBoxColumn31,
            this.DataGridTextBoxColumn32,
            this.DataGridTextBoxColumn33,
            this.DataGridTextBoxColumn34,
            this.DataGridTextBoxColumn35,
            this.DataGridTextBoxColumn36,
            this.DataGridTextBoxColumn37,
            this.DataGridTextBoxColumn38,
            this.DataGridTextBoxColumn39,
            this.DataGridTextBoxColumn40,
            this.DataGridTextBoxColumn41});
            this.DataGridTableStyle3.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle3.MappingName = "saledfoods";
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "已上菜";
            this.DataGridBoolColumn1.MappingName = "transfered";
            this.DataGridBoolColumn1.NullText = "";
            this.DataGridBoolColumn1.NullValue = "1";
            this.DataGridBoolColumn1.TrueValue = "2";
            this.DataGridBoolColumn1.Width = 55;
            // 
            // DataGridTextBoxColumn28
            // 
            this.DataGridTextBoxColumn28.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn28.Format = "";
            this.DataGridTextBoxColumn28.FormatInfo = null;
            this.DataGridTextBoxColumn28.HeaderText = "单据号";
            this.DataGridTextBoxColumn28.MappingName = "billno";
            this.DataGridTextBoxColumn28.NullText = "";
            this.DataGridTextBoxColumn28.Width = 120;
            // 
            // DataGridTextBoxColumn29
            // 
            this.DataGridTextBoxColumn29.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn29.Format = "";
            this.DataGridTextBoxColumn29.FormatInfo = null;
            this.DataGridTextBoxColumn29.HeaderText = "单据类别";
            this.DataGridTextBoxColumn29.MappingName = "name";
            this.DataGridTextBoxColumn29.NullText = "";
            this.DataGridTextBoxColumn29.Width = 75;
            // 
            // DataGridTextBoxColumn30
            // 
            this.DataGridTextBoxColumn30.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn30.Format = "";
            this.DataGridTextBoxColumn30.FormatInfo = null;
            this.DataGridTextBoxColumn30.HeaderText = "桌台号";
            this.DataGridTextBoxColumn30.MappingName = "tableno";
            this.DataGridTextBoxColumn30.NullText = "";
            this.DataGridTextBoxColumn30.Width = 75;
            // 
            // DataGridTextBoxColumn31
            // 
            this.DataGridTextBoxColumn31.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn31.Format = "";
            this.DataGridTextBoxColumn31.FormatInfo = null;
            this.DataGridTextBoxColumn31.HeaderText = "桌台名称";
            this.DataGridTextBoxColumn31.MappingName = "foodcode";
            this.DataGridTextBoxColumn31.NullText = "";
            this.DataGridTextBoxColumn31.Width = 105;
            // 
            // DataGridTextBoxColumn32
            // 
            this.DataGridTextBoxColumn32.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn32.Format = "";
            this.DataGridTextBoxColumn32.FormatInfo = null;
            this.DataGridTextBoxColumn32.HeaderText = "菜品名称";
            this.DataGridTextBoxColumn32.MappingName = "foodname";
            this.DataGridTextBoxColumn32.NullText = "";
            this.DataGridTextBoxColumn32.Width = 150;
            // 
            // DataGridTextBoxColumn33
            // 
            this.DataGridTextBoxColumn33.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn33.Format = "";
            this.DataGridTextBoxColumn33.FormatInfo = null;
            this.DataGridTextBoxColumn33.HeaderText = "类别编码";
            this.DataGridTextBoxColumn33.MappingName = "foodtypecode";
            this.DataGridTextBoxColumn33.NullText = "";
            this.DataGridTextBoxColumn33.Width = 55;
            // 
            // DataGridTextBoxColumn34
            // 
            this.DataGridTextBoxColumn34.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn34.Format = "";
            this.DataGridTextBoxColumn34.FormatInfo = null;
            this.DataGridTextBoxColumn34.HeaderText = "拼音码";
            this.DataGridTextBoxColumn34.MappingName = "spell";
            this.DataGridTextBoxColumn34.NullText = "";
            this.DataGridTextBoxColumn34.Width = 55;
            // 
            // DataGridTextBoxColumn35
            // 
            this.DataGridTextBoxColumn35.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn35.Format = "";
            this.DataGridTextBoxColumn35.FormatInfo = null;
            this.DataGridTextBoxColumn35.HeaderText = "单位";
            this.DataGridTextBoxColumn35.MappingName = "unit";
            this.DataGridTextBoxColumn35.NullText = "";
            this.DataGridTextBoxColumn35.Width = 55;
            // 
            // DataGridTextBoxColumn36
            // 
            this.DataGridTextBoxColumn36.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn36.Format = "";
            this.DataGridTextBoxColumn36.FormatInfo = null;
            this.DataGridTextBoxColumn36.HeaderText = "数量";
            this.DataGridTextBoxColumn36.MappingName = "addquantity";
            this.DataGridTextBoxColumn36.NullText = "";
            this.DataGridTextBoxColumn36.Width = 55;
            // 
            // DataGridTextBoxColumn37
            // 
            this.DataGridTextBoxColumn37.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn37.Format = "";
            this.DataGridTextBoxColumn37.FormatInfo = null;
            this.DataGridTextBoxColumn37.HeaderText = "单价";
            this.DataGridTextBoxColumn37.MappingName = "price";
            this.DataGridTextBoxColumn37.NullText = "";
            this.DataGridTextBoxColumn37.Width = 75;
            // 
            // DataGridTextBoxColumn38
            // 
            this.DataGridTextBoxColumn38.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn38.Format = "";
            this.DataGridTextBoxColumn38.FormatInfo = null;
            this.DataGridTextBoxColumn38.HeaderText = "条码";
            this.DataGridTextBoxColumn38.MappingName = "barcode";
            this.DataGridTextBoxColumn38.NullText = "";
            this.DataGridTextBoxColumn38.Width = 75;
            // 
            // DataGridTextBoxColumn39
            // 
            this.DataGridTextBoxColumn39.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn39.Format = "";
            this.DataGridTextBoxColumn39.FormatInfo = null;
            this.DataGridTextBoxColumn39.HeaderText = "做法";
            this.DataGridTextBoxColumn39.MappingName = "operandi";
            this.DataGridTextBoxColumn39.NullText = "";
            this.DataGridTextBoxColumn39.Width = 140;
            // 
            // DataGridTextBoxColumn40
            // 
            this.DataGridTextBoxColumn40.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn40.Format = "";
            this.DataGridTextBoxColumn40.FormatInfo = null;
            this.DataGridTextBoxColumn40.HeaderText = "口味";
            this.DataGridTextBoxColumn40.MappingName = "taste";
            this.DataGridTextBoxColumn40.NullText = "";
            this.DataGridTextBoxColumn40.Width = 140;
            // 
            // DataGridTextBoxColumn41
            // 
            this.DataGridTextBoxColumn41.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn41.Format = "";
            this.DataGridTextBoxColumn41.FormatInfo = null;
            this.DataGridTextBoxColumn41.HeaderText = "点菜时间";
            this.DataGridTextBoxColumn41.MappingName = "begintime";
            this.DataGridTextBoxColumn41.NullText = "";
            this.DataGridTextBoxColumn41.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(648, 425);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.StatusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = " - 后厨上菜";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid3)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion
		
		//返回系统单据总数
		public int GetCurrentTableNoBillsCount(string tableno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
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
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
			rms_var.TheAppExt = new AppExt.CAppExt();
			this.Text = rms_var.TheAppExt.GetAppTitle + this.Text;
			mnuAbout.Text = "关于 " + rms_var.TheAppExt.GetAppTitle;
			rms_var.TheAppExt.LogModule = 5; //报告登录的是->后厨上菜模块
			string rtn = rms_var.TheAppExt.ShowLogForm("后厨上菜");
			if (rtn.Trim() == "-1")
			{
                Application.Exit();
			}
			else
			{
				rms_var.ConnStr = rms_var.TheAppExt.GetConnStr; //复制远程连接字符串
				if (GetCurrentTableNoBillsCount("") >= 200)
				{
					return;
				}
				rms_var.ReceiveOperatorInfo(rtn);
				StatusBar1.Panels[1].Text = "登录用户ID：" + rms_var.opinfo.OpID;
				StatusBar1.Panels[2].Text = "姓名：" + rms_var.opinfo.EmployeeName;
				StatusBar1.Panels[3].Text = "所属部门：" + rms_var.opinfo.Department;
				StatusBar1.Panels[5].Text = "登录时间：" + DateTime.Now.ToString();
				this.WindowState = FormWindowState.Maximized;
			}
			ComboBox1.SelectedIndex = 0;
			TextBox1.Focus();
			TextBox1.SelectAll();
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
				
				rms_var.TheAppExt.LogModule = 5; //报告登录的是->后厨上菜模块
				string rtn = rms_var.TheAppExt.ShowLogForm("后厨上菜");
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
			}
		}
		
		private void MenuItem4_Click(System.Object sender, System.EventArgs e)
		{
            Application.Exit();
		}
		
		private void MenuItem48_Click(System.Object sender, System.EventArgs e)
		{
			System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
			string ver;
			
			ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
			
			rms_var.TheAppExt.ShowAboutForm(ver, "a6c0");
		}
		
		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
			{
				TabControl1.SelectedIndex = 0;
				TextBox1.Focus();
				TextBox1.SelectAll();
			}
		}
		
		private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Button1_Click(sender, e);
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				
				int OverMinuteTime;
				if (ComboBox1.SelectedIndex == 0) //分钟
				{
					OverMinuteTime = System.Convert.ToInt32(NumericUpDown1.Value);
				}
				else //小时
				{
					OverMinuteTime = System.Convert.ToInt32(NumericUpDown1.Value * 60);
				}
				
				selectCMD.CommandText = "SELECT * FROM (SELECT *, DATEDIFF([minute], begintime, GETDATE()) AS no_of_min FROM saledfoods)  DERIVEDTBL WHERE no_of_min >" + OverMinuteTime.ToString() + " and transfered<>'2'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "overtimefoods");
				DataGrid2.DataSource = null;
				DataGrid2.DataSource = dbDS;
				DataGrid2.DataMember = "overtimefoods";
				
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
		
		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			InputMode inputmode = new InputMode();
			switch (rms_var.FoodInputMode) //0 菜品编码 1 菜品拼音码 2 菜品类别编码
			{
				case 0:
					inputmode.RadioButton1.Checked = true;
					break;
				case 1:
					inputmode.RadioButton2.Checked = true;
					break;
				case 2:
					inputmode.RadioButton3.Checked = true;
					break;
			}
			inputmode.ShowDialog();
			txtFoodCode.Focus();
			txtFoodCode.SelectAll();
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGrid1.VisibleRowCount == 1)
			{
				//检测条码是否合法
				if (rms_var.CheckBarcode(TextBox1.Text))
				{
					//开始更新
					System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
					conn.ConnectionString = rms_var.ConnStr;
					try
					{
						SqlCommand selectCMD = new SqlCommand();
						selectCMD.Connection = conn;
						selectCMD.CommandText = "update salelist_t set transfered='2' where barcode='" + TextBox1.Text + "'";
						selectCMD.CommandTimeout = 30;
						conn.Open();
						selectCMD.ExecuteNonQuery();
						
						Label2.ForeColor = Color.DarkBlue;
						Label2.Text = rms_var.GetTablenofromBarcode(TextBox1.Text) + " 号桌台 " + rms_var.GetFoodnamefromBarcode(TextBox1.Text) + " 已经成功出菜";
						Label2.Refresh();
						ListBox1.Items.Add(DateTime.Now + "：  " + Label2.Text);
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
				else
				{
					Label2.ForeColor = Color.Red;
					Label2.Text = "没有找到菜品！请检查条码然后重新扫描或重新输入。";
					Label2.Refresh();
					TextBox1.Focus();
					TextBox1.SelectAll();
				}
			}
			else
			{
				Label2.ForeColor = Color.Red;
				Label2.Text = "没有找到菜品！请检查条码然后重新扫描或重新输入。";
				Label2.Refresh();
				TextBox1.Focus();
				TextBox1.SelectAll();
			}
		}
		
		private void txtFoodCode_TextChanged(object sender, System.EventArgs e)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				switch (rms_var.FoodInputMode) //0 菜品编码 1 菜品拼音码 2 菜品类别编码
				{
					case 0:
						selectCMD.CommandText = "SELECT * FROM SaledFoods where foodcode like '%" + txtFoodCode.Text + "%'";
						break;
						
					case 1:
						selectCMD.CommandText = "SELECT * FROM SaledFoods where spell like '%" + txtFoodCode.Text + "%'";
						break;
						
					case 2:
						selectCMD.CommandText = "SELECT * FROM SaledFoods where foodtypecode like '%" + txtFoodCode.Text + "%'";
						break;
						
				}
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "saledfoods");
				DataGrid3.DataSource = null;
				DataGrid3.DataSource = dbDS;
				DataGrid3.DataMember = "saledfoods";
				
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
		
		private void TabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (TabControl1.SelectedIndex)
			{
				case 0:
					TextBox1.Focus();
					TextBox1.SelectAll();
					break;
				case 1:
					Button2.Focus();
					break;
				case 2:
					txtFoodCode.Focus();
					txtFoodCode.SelectAll();
					break;
			}
		}
		
		private void TextBox1_TextChanged(System.Object sender, System.EventArgs e)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM SaledFoods where barcode like '%" + TextBox1.Text + "%' and transfered='1'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "barcodefoods");
				DataGrid1.DataSource = null;
				DataGrid1.DataSource = dbDS;
				DataGrid1.DataMember = "barcodefoods";
				
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
		
		private void MenuItem45_Click(System.Object sender, System.EventArgs e)
		{
			string CurrentPath;
			
			CurrentPath = Directory.GetCurrentDirectory();
			if (CurrentPath[CurrentPath.Length - 1] !='\\')
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
