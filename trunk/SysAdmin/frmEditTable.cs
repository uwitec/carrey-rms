using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace SysAdmin
{
	public class frmEditTable : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=添加 2=修改 3=查询
        public string OldTablecode;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label17;
        private Label label18;
        private NumericUpDown nud_RelayLine;
        private NumericUpDown nud_RelayAddress;
        private ComboBox cb_RelayPort;
        private Label label19;
        private Button button3;
        private TextBox txtCallerAddress;
        private Label label20;
        private ComboBox cb_CallerPort;
        private Label label21;
        internal CheckBox ckb_Relay;
        internal CheckBox ckb_Caller;
		public string oldTablename;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditTable()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化
			
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
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.RadioButton RadioButton4;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.ComboBox ComboBox3;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown4;
		internal System.Windows.Forms.NumericUpDown NumericUpDown5;
		internal System.Windows.Forms.NumericUpDown NumericUpDown6;
		internal System.Windows.Forms.NumericUpDown NumericUpDown7;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.NumericUpDown NumericUpDown8;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.ComboBox ComboBox4;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label16;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTable));
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.Label12 = new System.Windows.Forms.Label();
            this.NumericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.ComboBox4 = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.Label13 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cb_RelayPort = new System.Windows.Forms.ComboBox();
            this.nud_RelayAddress = new System.Windows.Forms.NumericUpDown();
            this.nud_RelayLine = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCallerAddress = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_CallerPort = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ckb_Relay = new System.Windows.Forms.CheckBox();
            this.ckb_Caller = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown4)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown7)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RelayAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RelayLine)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.Location = new System.Drawing.Point(104, 24);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(104, 20);
            this.ComboBox1.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.NumericUpDown6);
            this.GroupBox1.Controls.Add(this.NumericUpDown5);
            this.GroupBox1.Controls.Add(this.NumericUpDown4);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.ComboBox1);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(432, 104);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "一般信息";
            // 
            // NumericUpDown6
            // 
            this.NumericUpDown6.Location = new System.Drawing.Point(304, 73);
            this.NumericUpDown6.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDown6.Name = "NumericUpDown6";
            this.NumericUpDown6.Size = new System.Drawing.Size(104, 21);
            this.NumericUpDown6.TabIndex = 5;
            this.NumericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown5
            // 
            this.NumericUpDown5.Location = new System.Drawing.Point(104, 73);
            this.NumericUpDown5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDown5.Name = "NumericUpDown5";
            this.NumericUpDown5.Size = new System.Drawing.Size(104, 21);
            this.NumericUpDown5.TabIndex = 4;
            this.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown4
            // 
            this.NumericUpDown4.Location = new System.Drawing.Point(304, 49);
            this.NumericUpDown4.Name = "NumericUpDown4";
            this.NumericUpDown4.Size = new System.Drawing.Size(104, 21);
            this.NumericUpDown4.TabIndex = 3;
            this.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(104, 49);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(104, 21);
            this.TextBox2.TabIndex = 2;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(304, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(104, 21);
            this.TextBox1.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(208, 72);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "包房费/附加费：";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(8, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "最低消费：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(208, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "最大载客数：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "桌台名称：";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "桌台类别/位置：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(208, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "桌台编码：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.NumericUpDown8);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.NumericUpDown7);
            this.GroupBox2.Controls.Add(this.CheckBox2);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.RadioButton2);
            this.GroupBox2.Controls.Add(this.RadioButton1);
            this.GroupBox2.Location = new System.Drawing.Point(8, 126);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(432, 98);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "服务费";
            // 
            // NumericUpDown8
            // 
            this.NumericUpDown8.Enabled = false;
            this.NumericUpDown8.Location = new System.Drawing.Point(304, 64);
            this.NumericUpDown8.Name = "NumericUpDown8";
            this.NumericUpDown8.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown8.TabIndex = 4;
            this.NumericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(224, 64);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(80, 23);
            this.Label12.TabIndex = 6;
            this.Label12.Text = "消费百分比：";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericUpDown7
            // 
            this.NumericUpDown7.Enabled = false;
            this.NumericUpDown7.Location = new System.Drawing.Point(304, 40);
            this.NumericUpDown7.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDown7.Name = "NumericUpDown7";
            this.NumericUpDown7.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown7.TabIndex = 2;
            this.NumericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CheckBox2
            // 
            this.CheckBox2.Location = new System.Drawing.Point(48, 16);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(104, 24);
            this.CheckBox2.TabIndex = 0;
            this.CheckBox2.Text = "收取服务费";
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(224, 40);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 23);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "固定服务费：";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RadioButton2
            // 
            this.RadioButton2.Enabled = false;
            this.RadioButton2.Location = new System.Drawing.Point(48, 64);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(168, 24);
            this.RadioButton2.TabIndex = 3;
            this.RadioButton2.Text = "按消费额度收取服务费";
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.Checked = true;
            this.RadioButton1.Enabled = false;
            this.RadioButton1.Location = new System.Drawing.Point(48, 40);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(168, 24);
            this.RadioButton1.TabIndex = 1;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "收取固定额度服务费";
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.ComboBox4);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.NumericUpDown2);
            this.GroupBox3.Controls.Add(this.NumericUpDown3);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.ComboBox3);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.RadioButton4);
            this.GroupBox3.Controls.Add(this.ComboBox2);
            this.GroupBox3.Controls.Add(this.RadioButton3);
            this.GroupBox3.Controls.Add(this.NumericUpDown1);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.CheckBox1);
            this.GroupBox3.Location = new System.Drawing.Point(8, 239);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(432, 144);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "计时收费";
            // 
            // Label16
            // 
            this.Label16.Enabled = false;
            this.Label16.Location = new System.Drawing.Point(400, 104);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(24, 23);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "%";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.Enabled = false;
            this.Label15.Location = new System.Drawing.Point(360, 80);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(24, 23);
            this.Label15.TabIndex = 13;
            this.Label15.Text = "元";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(200, 104);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(16, 23);
            this.Label14.TabIndex = 14;
            this.Label14.Text = "每";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox4
            // 
            this.ComboBox4.Enabled = false;
            this.ComboBox4.Items.AddRange(new object[] {
            "分钟",
            "小时"});
            this.ComboBox4.Location = new System.Drawing.Point(216, 104);
            this.ComboBox4.Name = "ComboBox4";
            this.ComboBox4.Size = new System.Drawing.Size(56, 20);
            this.ComboBox4.TabIndex = 7;
            this.ComboBox4.Text = "小时";
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(200, 80);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(16, 23);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "每";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Enabled = false;
            this.NumericUpDown2.Location = new System.Drawing.Point(304, 80);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(56, 21);
            this.NumericUpDown2.TabIndex = 5;
            this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown3
            // 
            this.NumericUpDown3.Enabled = false;
            this.NumericUpDown3.Location = new System.Drawing.Point(352, 104);
            this.NumericUpDown3.Name = "NumericUpDown3";
            this.NumericUpDown3.Size = new System.Drawing.Size(48, 21);
            this.NumericUpDown3.TabIndex = 8;
            this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(272, 80);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(32, 23);
            this.Label13.TabIndex = 12;
            this.Label13.Text = "收取";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox3
            // 
            this.ComboBox3.Enabled = false;
            this.ComboBox3.Items.AddRange(new object[] {
            "分钟",
            "小时"});
            this.ComboBox3.Location = new System.Drawing.Point(216, 80);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(56, 20);
            this.ComboBox3.TabIndex = 4;
            this.ComboBox3.Text = "小时";
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(216, 48);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(128, 23);
            this.Label11.TabIndex = 10;
            this.Label11.Text = "后开始计时收费";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(272, 104);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 23);
            this.Label10.TabIndex = 15;
            this.Label10.Text = "消费百分比：";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RadioButton4
            // 
            this.RadioButton4.Enabled = false;
            this.RadioButton4.Location = new System.Drawing.Point(24, 104);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(184, 24);
            this.RadioButton4.TabIndex = 6;
            this.RadioButton4.Text = "按消费额度一次性收取加时费";
            this.RadioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.Enabled = false;
            this.ComboBox2.Items.AddRange(new object[] {
            "分钟",
            "小时"});
            this.ComboBox2.Location = new System.Drawing.Point(160, 48);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(56, 20);
            this.ComboBox2.TabIndex = 2;
            this.ComboBox2.Text = "小时";
            // 
            // RadioButton3
            // 
            this.RadioButton3.Checked = true;
            this.RadioButton3.Enabled = false;
            this.RadioButton3.Location = new System.Drawing.Point(24, 80);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(160, 24);
            this.RadioButton3.TabIndex = 3;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "按时间累计收取费用";
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Enabled = false;
            this.NumericUpDown1.Location = new System.Drawing.Point(112, 48);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(48, 21);
            this.NumericUpDown1.TabIndex = 1;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(40, 48);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 23);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "开台超过：";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(48, 16);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(87, 24);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "按计时收费";
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(354, 526);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "取消(&C)";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(274, 526);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckb_Relay);
            this.groupBox4.Controls.Add(this.nud_RelayLine);
            this.groupBox4.Controls.Add(this.nud_RelayAddress);
            this.groupBox4.Controls.Add(this.cb_RelayPort);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(8, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 131);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "智能开关";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckb_Caller);
            this.groupBox5.Controls.Add(this.cb_CallerPort);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.txtCallerAddress);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(227, 389);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 131);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "呼叫器";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "端口：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "地址：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "线路：";
            // 
            // cb_RelayPort
            // 
            this.cb_RelayPort.FormattingEnabled = true;
            this.cb_RelayPort.Location = new System.Drawing.Point(48, 48);
            this.cb_RelayPort.Name = "cb_RelayPort";
            this.cb_RelayPort.Size = new System.Drawing.Size(149, 20);
            this.cb_RelayPort.Sorted = true;
            this.cb_RelayPort.TabIndex = 3;
            // 
            // nud_RelayAddress
            // 
            this.nud_RelayAddress.Location = new System.Drawing.Point(48, 74);
            this.nud_RelayAddress.Name = "nud_RelayAddress";
            this.nud_RelayAddress.Size = new System.Drawing.Size(149, 21);
            this.nud_RelayAddress.TabIndex = 4;
            // 
            // nud_RelayLine
            // 
            this.nud_RelayLine.Location = new System.Drawing.Point(48, 99);
            this.nud_RelayLine.Name = "nud_RelayLine";
            this.nud_RelayLine.Size = new System.Drawing.Size(149, 21);
            this.nud_RelayLine.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "地址：";
            // 
            // txtCallerAddress
            // 
            this.txtCallerAddress.Location = new System.Drawing.Point(53, 74);
            this.txtCallerAddress.Name = "txtCallerAddress";
            this.txtCallerAddress.Size = new System.Drawing.Size(149, 21);
            this.txtCallerAddress.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "扫描";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cb_CallerPort
            // 
            this.cb_CallerPort.FormattingEnabled = true;
            this.cb_CallerPort.Location = new System.Drawing.Point(53, 45);
            this.cb_CallerPort.Name = "cb_CallerPort";
            this.cb_CallerPort.Size = new System.Drawing.Size(149, 20);
            this.cb_CallerPort.Sorted = true;
            this.cb_CallerPort.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 4;
            this.label21.Text = "端口：";
            // 
            // ckb_Relay
            // 
            this.ckb_Relay.Location = new System.Drawing.Point(10, 18);
            this.ckb_Relay.Name = "ckb_Relay";
            this.ckb_Relay.Size = new System.Drawing.Size(59, 21);
            this.ckb_Relay.TabIndex = 6;
            this.ckb_Relay.Text = "启用";
            this.ckb_Relay.CheckedChanged += new System.EventHandler(this.ckb_Relay_CheckedChanged);
            // 
            // ckb_Caller
            // 
            this.ckb_Caller.Location = new System.Drawing.Point(15, 18);
            this.ckb_Caller.Name = "ckb_Caller";
            this.ckb_Caller.Size = new System.Drawing.Size(87, 21);
            this.ckb_Caller.TabIndex = 7;
            this.ckb_Caller.Text = "启用";
            this.ckb_Caller.CheckedChanged += new System.EventHandler(this.ckb_Caller_CheckedChanged);
            // 
            // frmEditTable
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(449, 561);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditTable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEditTable_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown4)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown7)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RelayAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RelayLine)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion
		
		//获取桌台类别记录，填充下拉列表框
		public void GetTableTypeList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT name FROM tabletype", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					ComboBox1.Items.Add(dbDS.Tables[0].Rows[i]["name"]);
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
		
		//添加
		private bool AddData(string tabletype, string newtableno, string tablename, string PeopleNumber, string lower_pay, string addprice, bool server, string serverstate, string server_pay, bool overtime, string overtimenum, string overtimetype, string overtimestate, string pertype, string pertypeprice)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select tableno from tablestatus where tableno='" + newtableno + "' or tablename='" + tablename + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
				{
					MessageBox.Show("编码或名称重复！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into tablestatus " + "(TableTypeCode,tableno,tablename,PeopleNumber,lower_pay,addprice," + "server,serverstate,server_pay," + "overtime,overtimenum,overtimetype," + "overtimestate,pertype,pertypeprice) " + "values (" + "'" + rms_var.GetTableTypeCode(tabletype) + "'" + "," + "'" + newtableno + "'" + "," + "'" + tablename + "'" + "," + PeopleNumber + "," + lower_pay + "," + addprice + "," + "'" + Math.Abs(System.Convert.ToInt32(server)).ToString() + "'" + "," + "'" + serverstate + "'" + "," + server_pay + "," + "'" + Math.Abs(System.Convert.ToInt32(overtime)).ToString() + "'" + "," + overtimenum + "," + "'" + overtimetype + "'" + "," + "'" + overtimestate + "'" + "," + "'" + pertype + "'" + "," + pertypeprice + ")";
					
					selectCMD.ExecuteNonQuery();
					
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
				conn.Close();
			}
		}
		
		//修改
		private bool EditData(string tabletype, string OldTableno, string newtableno, string tablename, string PeopleNumber, string lower_pay, string addprice, bool server, string serverstate, string server_pay, bool overtime, string overtimenum, string overtimetype, string overtimestate, string pertype, string pertypeprice)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (OldTableno == newtableno && tablename == oldTablename) //编码和名称没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					
					selectCMD.CommandText = "update tablestatus set " + "TableTypeCode='" + rms_var.GetTableTypeCode(tabletype) + "'" + "," + "PeopleNumber=" + PeopleNumber + "," + "lower_pay=" + lower_pay + "," + "addprice=" + addprice + "," + "server='" + Math.Abs(System.Convert.ToInt32(server)).ToString() + "'" + "," + "serverstate='" + serverstate + "'" + "," + "server_pay=" + server_pay + "," + "overtime='" + Math.Abs(System.Convert.ToInt32(overtime)).ToString() + "'" + "," + "overtimenum=" + overtimenum + "," + "overtimetype='" + overtimetype + "'" + "," + "overtimestate='" + overtimestate + "'" + "," + "pertype='" + pertype + "' " + "," + "pertypeprice=" + pertypeprice + " " + "where tableno='" + OldTableno + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select tableno from tablestatus where tableno='" + newtableno + "' and tableno<>'" + OldTableno + "'" + " or tablename='" + tablename + "'" + " and tablename<>'" + oldTablename + "'";
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					
					if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
					{
						MessageBox.Show("编码或名称重复！");
						TextBox1.Focus();
						TextBox1.SelectAll();
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update tablestatus set " + "tableno='" + newtableno + "'" + "," + "TableTypeCode='" + rms_var.GetTableTypeCode(tabletype) + "'" + "," + "tablename='" + tablename + "'" + "," + "PeopleNumber=" + PeopleNumber + "," + "lower_pay=" + lower_pay + "," + "addprice=" + addprice + "," + "server='" + Math.Abs(System.Convert.ToInt32(server)).ToString() + "'" + "," + "serverstate='" + serverstate + "'" + "," + "server_pay=" + server_pay + "," + "overtime='" + Math.Abs(System.Convert.ToInt32(overtime)).ToString() + "'" + "," + "overtimenum=" + overtimenum + "," + "overtimetype='" + overtimetype + "'" + "," + "overtimestate='" + overtimestate + "'" + "," + "pertype='" + pertype + "' " + "," + "pertypeprice=" + pertypeprice + " " + "where tableno='" + OldTableno + "'";
						selectCMD.ExecuteNonQuery();
						
						return true;
					}
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
		
		private void frmEditTable_Load(System.Object sender, System.EventArgs e)
		{
            cb_RelayPort.Items.AddRange(DevExt.Control.GetSerialPorts());
            cb_CallerPort.Items.AddRange(DevExt.Control.GetSerialPorts());
        }
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 1) //添加记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("桌台编码不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("桌台名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("桌台类别不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				string serverstate;
				string server_pay;
				
				if (RadioButton1.Checked)
				{
					serverstate = "0";
					server_pay = NumericUpDown7.Text;
				}
				else
				{
					serverstate = "1";
					server_pay = NumericUpDown8.Text;
				}
				
				string overtimestate;
				string pertype;
				string pertypeprice;
				
				if (RadioButton3.Checked)
				{
					overtimestate = "0";
					pertype = ComboBox3.SelectedIndex.ToString();
					pertypeprice = NumericUpDown2.Text;
				}
				else
				{
					overtimestate = "1";
					pertype = ComboBox4.SelectedIndex.ToString();
					pertypeprice = NumericUpDown3.Text;
				}
				
				if (AddData(ComboBox1.Text, TextBox1.Text, TextBox2.Text, NumericUpDown4.Text, NumericUpDown5.Text, NumericUpDown6.Text, CheckBox2.Checked, serverstate, server_pay, CheckBox1.Checked, NumericUpDown1.Text, ComboBox2.SelectedIndex.ToString(), overtimestate, pertype, pertypeprice))
					{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新的桌台吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						TextBox1.Text = "";
						TextBox2.Text = "";
						NumericUpDown4.Value = 0;
						NumericUpDown5.Value = 0;
						NumericUpDown6.Value = 0;
						
						CheckBox2.Checked = false;
						RadioButton1.Checked = false;
						RadioButton2.Checked = false;
						NumericUpDown7.Value = 0;
						NumericUpDown8.Value = 0;
						
						CheckBox1.Checked = false;
						NumericUpDown1.Value = 0;
						ComboBox2.Text = "";
						RadioButton3.Checked = false;
						RadioButton4.Checked = false;
						ComboBox3.Text = "";
						ComboBox4.Text = "";
						NumericUpDown2.Value = 0;
						NumericUpDown3.Value = 0;
						ComboBox1.Focus();
					}
					else
					{
						this.DialogResult = DialogResult.OK;
					}
				}
				
			}
			else if (frmMode == 2) //修改记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("桌台编码不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("桌台名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("桌台类别不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (MessageBox.Show("确定要修改当前桌台信息吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					string serverstate;
					string server_pay;
					
					if (RadioButton1.Checked)
					{
						serverstate = "0";
						server_pay = NumericUpDown7.Text;
					}
					else
					{
						serverstate = "1";
						server_pay = NumericUpDown8.Text;
					}
					
					string overtimestate;
					string pertype;
					string pertypeprice;
					
					if (RadioButton3.Checked)
					{
						overtimestate = "0";
						pertype = ComboBox3.SelectedIndex.ToString();
						pertypeprice = NumericUpDown2.Text;
					}
					else
					{
						overtimestate = "1";
						pertype = ComboBox4.SelectedIndex.ToString();
						pertypeprice = NumericUpDown3.Text;
					}
					
					if (EditData(ComboBox1.Text, OldTablecode, TextBox1.Text, TextBox2.Text, NumericUpDown4.Text, NumericUpDown5.Text, NumericUpDown6.Text, CheckBox2.Checked, serverstate, server_pay, CheckBox1.Checked, NumericUpDown1.Text, ComboBox2.SelectedIndex.ToString(), overtimestate, pertype, pertypeprice))
						{
						MessageBox.Show("修改记录成功！");
						this.DialogResult = DialogResult.OK;
					}
				}
				
			}
			else if (frmMode == 3) //查询
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void CheckBox2_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (CheckBox2.Checked)
			{
				RadioButton1.Enabled = CheckBox2.Checked;
				RadioButton2.Enabled = CheckBox2.Checked;
				NumericUpDown7.Enabled = RadioButton1.Checked;
				NumericUpDown8.Enabled = RadioButton2.Checked;
			}
			else
			{
				RadioButton1.Enabled = CheckBox2.Checked;
				RadioButton2.Enabled = CheckBox2.Checked;
				NumericUpDown7.Enabled = false;
				NumericUpDown8.Enabled = false;
			}
		}
		
		private void RadioButton1_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown7.Enabled = RadioButton1.Checked;
		}
		
		private void RadioButton2_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown8.Enabled = RadioButton2.Checked;
		}
		
		private void CheckBox1_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (CheckBox1.Checked)
			{
				NumericUpDown1.Enabled = CheckBox1.Checked;
				ComboBox2.Enabled = CheckBox1.Checked;
				
				RadioButton3.Enabled = CheckBox1.Checked;
				RadioButton4.Enabled = CheckBox1.Checked;
				
				ComboBox3.Enabled = RadioButton3.Checked;
				NumericUpDown2.Enabled = RadioButton3.Checked;
				
				ComboBox4.Enabled = RadioButton4.Checked;
				NumericUpDown3.Enabled = RadioButton4.Checked;
			}
			else
			{
				NumericUpDown1.Enabled = CheckBox1.Checked;
				ComboBox2.Enabled = CheckBox1.Checked;
				
				RadioButton3.Enabled = CheckBox1.Checked;
				RadioButton4.Enabled = CheckBox1.Checked;
				
				ComboBox3.Enabled = false;
				NumericUpDown2.Enabled = false;
				
				ComboBox4.Enabled = false;
				NumericUpDown3.Enabled = false;
			}
		}
		
		private void RadioButton3_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			ComboBox3.Enabled = RadioButton3.Checked;
			NumericUpDown2.Enabled = RadioButton3.Checked;
		}
		
		private void RadioButton4_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			ComboBox4.Enabled = RadioButton4.Checked;
			NumericUpDown3.Enabled = RadioButton4.Checked;
		}

        private void ckb_Relay_CheckedChanged(object sender, EventArgs e)
        {
            cb_RelayPort.Enabled = ckb_Relay.Checked;
            nud_RelayAddress.Enabled = ckb_Relay.Checked;
            nud_RelayLine.Enabled = ckb_Relay.Checked;
        }

        private void ckb_Caller_CheckedChanged(object sender, EventArgs e)
        {
            cb_CallerPort.Enabled = ckb_Caller.Checked;
            txtCallerAddress.Enabled = ckb_Caller.Checked;
        }
	}
	
}
