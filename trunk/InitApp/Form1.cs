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
using System.Net;


namespace InitApp
{
	public class Form1 : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new Form1());
		}
		
		const string mdfFilename = "RMS.mdf";
		const string ldfFilename = "RMS.ldf";
		const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
		
		public AppExt.CAppExt TheAppExt; //类库中的对象
		
		private string BackupDbFile;
		private string AppPath;
        private GroupBox groupBox4;
        internal PictureBox pictureBox7;
        private TextBox txtSN;
        private TextBox txtUUID;
        private Label label13;
        private Label label14;
		private string RestoreDbPath;
		
		#region  Windows 窗体设计器生成的代码
		
		public Form1()
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
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.PictureBox PictureBox4;
		internal System.Windows.Forms.PictureBox PictureBox5;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
		internal System.Windows.Forms.PictureBox PictureBox6;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Location = new System.Drawing.Point(267, 558);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "初始化(&I)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(48, 34);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(176, 24);
            this.CheckBox1.TabIndex = 1;
            this.CheckBox1.Text = "初始化 SQL Server 数据库";
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TextBox6);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(48, 184);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(368, 128);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "登录本机/远程 SQL Server";
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(176, 24);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(144, 21);
            this.TextBox6.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(8, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(168, 23);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "主机名称：";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(176, 48);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(144, 21);
            this.TextBox3.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(152, 23);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "SQL Server 服务器名称：";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(176, 96);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '*';
            this.TextBox2.Size = new System.Drawing.Size(144, 21);
            this.TextBox2.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(104, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "密码：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(176, 72);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 21);
            this.TextBox1.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(104, 72);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "登录帐号：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(40, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "餐厅/酒店名称：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(136, 9);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(192, 21);
            this.TextBox4.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(48, 368);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(128, 23);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "报表文件所在路径：";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(48, 384);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(320, 21);
            this.TextBox5.TabIndex = 6;
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(48, 336);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(320, 21);
            this.TextBox7.TabIndex = 4;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(48, 320);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(120, 23);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "运行路径：";
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(347, 558);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "退出(&Q)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(24, 13);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(12, 12);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(24, 40);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(12, 12);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 11;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(24, 184);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(12, 12);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 12;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox4.Image")));
            this.PictureBox4.Location = new System.Drawing.Point(24, 320);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(12, 12);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox4.TabIndex = 14;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(24, 368);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(12, 12);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox5.TabIndex = 15;
            this.PictureBox5.TabStop = false;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(376, 336);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(32, 23);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "...";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(376, 384);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(32, 23);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "...";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Label9
            // 
            this.Label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label9.Location = new System.Drawing.Point(0, 590);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(434, 23);
            this.Label9.TabIndex = 14;
            this.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button6);
            this.GroupBox2.Controls.Add(this.Button5);
            this.GroupBox2.Controls.Add(this.TextBox9);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.TextBox8);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Enabled = false;
            this.GroupBox2.Location = new System.Drawing.Point(48, 64);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(368, 112);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "数据库文件";
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(328, 80);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(32, 23);
            this.Button6.TabIndex = 3;
            this.Button6.Text = "...";
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(328, 40);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(32, 23);
            this.Button5.TabIndex = 1;
            this.Button5.Text = "...";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // TextBox9
            // 
            this.TextBox9.Location = new System.Drawing.Point(8, 80);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(312, 21);
            this.TextBox9.TabIndex = 2;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(8, 64);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(104, 23);
            this.Label11.TabIndex = 5;
            this.Label11.Text = "数据库还原路径：";
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(8, 40);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(312, 21);
            this.TextBox8.TabIndex = 0;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(8, 24);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(256, 23);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "已备份的SQL Server 数据库备份：";
            // 
            // PictureBox6
            // 
            this.PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox6.Image")));
            this.PictureBox6.Location = new System.Drawing.Point(24, 416);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(12, 12);
            this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox6.TabIndex = 16;
            this.PictureBox6.TabStop = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.NumericUpDown1);
            this.GroupBox3.Controls.Add(this.TextBox10);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Location = new System.Drawing.Point(48, 416);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(368, 56);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "连接服务程序";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(264, 24);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(64, 21);
            this.NumericUpDown1.TabIndex = 1;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.Value = new decimal(new int[] {
            8023,
            0,
            0,
            0});
            // 
            // TextBox10
            // 
            this.TextBox10.Location = new System.Drawing.Point(88, 24);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new System.Drawing.Size(104, 21);
            this.TextBox10.TabIndex = 0;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(200, 26);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(64, 16);
            this.Label12.TabIndex = 3;
            this.Label12.Text = "端口号：";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(8, 26);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 16);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "远程主机名：";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSN);
            this.groupBox4.Controls.Add(this.txtUUID);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(48, 478);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 74);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "激活";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(24, 487);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(12, 12);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(61, 17);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(299, 21);
            this.txtSN.TabIndex = 15;
            // 
            // txtUUID
            // 
            this.txtUUID.Location = new System.Drawing.Point(61, 44);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(299, 21);
            this.txtUUID.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "激活码:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "序列号:";
            // 
            // Form1
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(434, 613);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.PictureBox6);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.CheckBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - 系统初始化";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//读写注册表
		public string ReadStrfromReg(string KeyName, string defaultvalue)
		{
			RegistryKey reg;
			
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
			string ret="";
			if (reg != null)
			{
				ret=reg.GetValue(KeyName, defaultvalue).ToString();
//				reg.Close();
			}
            return ret;
		}
		
		public int ReadIntfromReg(string KeyName)
		{
			RegistryKey reg;
			
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
			int ret=0;
			if (reg != null)
			{
				ret=Convert.ToInt32(reg.GetValue(KeyName, 0).ToString());
//				reg.Close();
			}
            return ret;
		}
		
		public void WriteStrToReg(string KeyName, string KeyValue)
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
		
		public void WriteIntToReg(string KeyName, int KeyValue)
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
		
		private bool InitDB()
		{
			Label9.Text = "正在登录 SQL Server 服务器......";
			Label9.Refresh();
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			string tmpstr;
			tmpstr = "workstation id=" + (TextBox6.Text + ";") + "packet size=" + ("4096" + ";") + "user id=" + (TextBox1.Text + ";") + "data source=" + (TextBox3.Text + ";") + "persist security info=" + ("true" + ";") + "initial catalog=master;" + "password=" + TextBox2.Text;
			conn.ConnectionString = tmpstr;
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
				Label9.Text = "连接 SQL Server 服务器失败！";
				Label9.Refresh();
				return false;
			}
			
			try
			{
				Label9.Text = "正在删除原有SQL Server 数据库......";
				Label9.Refresh();
				selectCMD.CommandText = "DROP DATABASE RMS";
				selectCMD.ExecuteNonQuery();
			}
			catch (Exception)
			{
				//MessageBox.Show(ex.ToString)
			}
			
			try
			{
				Label9.Text = "正在初始化并还原 SQL Server 数据库......";
				Label9.Refresh();
				selectCMD.CommandText = "RESTORE DATABASE RMS " + "FROM DISK =" + "'" + BackupDbFile + "' " + "WITH MOVE " + "'" + "RMS_Data" + "'" + " TO " + "'" + RestoreDbPath + mdfFilename + "'" + "," + "MOVE " + "'" + "RMS_Log" + "'" + " TO " + "'" + RestoreDbPath + ldfFilename + "'" + ",Replace";
				selectCMD.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				Label9.Text = "数据库初始化操作失败！";
				Label9.Refresh();
				MessageBox.Show("数据库初始化操作失败！" + "\r\n" + "\r\n" + ex.ToString());
				return false;
			}
			
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			OpenFileDialog1.Title = "选择SQL Server 数据库备份文件";
			OpenFileDialog1.Filter = "数据库备份文件 (*.dat,*.bak)|*.dat;*.bak";
			if (TextBox8.Text != "")
			{
				OpenFileDialog1.FileName = TextBox8.Text;
			}
			if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				TextBox8.Text = OpenFileDialog1.FileName;
			}
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			FolderBrowserDialog1.Description = "选择将数据库备份还原到的路径：";
			if (TextBox9.Text != "")
			{
				FolderBrowserDialog1.SelectedPath = TextBox9.Text;
			}
			if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				TextBox9.Text = FolderBrowserDialog1.SelectedPath;
			}
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			FolderBrowserDialog1.Description = "选择运行路径：";
			if (TextBox7.Text != "")
			{
				FolderBrowserDialog1.SelectedPath = TextBox7.Text;
			}
			if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				TextBox7.Text = FolderBrowserDialog1.SelectedPath;
			}
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			FolderBrowserDialog1.Description = "选择报表所在的路径：";
			if (TextBox5.Text != "")
			{
				FolderBrowserDialog1.SelectedPath = TextBox5.Text;
			}
			if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				TextBox5.Text = FolderBrowserDialog1.SelectedPath;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
            //if (!Authorize.GetValidityUUID(txtUUID.Text))
            //{
            //    MessageBox.Show("授权无效");
            //    return;

            //}

			if (MessageBox.Show("确定要初始化？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				this.Enabled = false;

                WriteStrToReg("Key", txtUUID.Text.Trim());

				if (CheckBox1.Checked)
				{
					Label9.Text = "正在检查数据库备份文件和还原路径是否正确......";
					Label9.Refresh();
					//先检测数据库文件和路径是否存在
					if (! File.Exists(TextBox8.Text))
					{
						MessageBox.Show("数据库备份文件没有找到，初始化操作不能进行。");
						TextBox8.Focus();
						TextBox8.SelectAll();
						Label9.Text = "";
						Label9.Refresh();
						this.Enabled = true;
						return;
					}
					if (! Directory.Exists(TextBox9.Text))
					{
						MessageBox.Show("数据库还原路径没有找到，初始化操作不能进行。");
						TextBox9.Focus();
						TextBox9.SelectAll();
						Label9.Text = "";
						Label9.Refresh();
						this.Enabled = true;
						return;
					}
					BackupDbFile = TextBox8.Text;
					RestoreDbPath = TextBox9.Text;
					if (RestoreDbPath[RestoreDbPath.Length - 1] != '\\')
					{
						RestoreDbPath += "\\";
					}
					Label9.Text = "数据库备份文件和还原路径检查完毕......";
					Label9.Refresh();
				}
				
				Label9.Text = "正在保存信息......";
				Label9.Refresh();
				
				//写酒店名称
				if (TextBox4.Text.Trim() == "")
				{
					MessageBox.Show("餐厅/酒店名称为空，初始化操作不能进行。");
					TextBox4.Focus();
					TextBox4.SelectAll();
					Label9.Text = "";
					Label9.Refresh();
					this.Enabled = true;
					return;
				}
				else
				{
					WriteStrToReg("RestaurantName", TextBox4.Text);
				}
				
				//写SQL登录信息
				if (TextBox6.Text.Trim() == "")
				{
					MessageBox.Show("SQL Server 计算机名称为空，初始化操作不能进行。");
					TextBox6.Focus();
					TextBox6.SelectAll();
					Label9.Text = "";
					Label9.Refresh();
					this.Enabled = true;
					return;
				}
				else
				{
					WriteStrToReg("Wkst_Id", TextBox6.Text);
				}
				
				if (TextBox3.Text.Trim() == "")
				{
					MessageBox.Show("SQL Server 服务器名称为空，初始化操作不能进行。");
					TextBox3.Focus();
					TextBox3.SelectAll();
					Label9.Text = "";
					Label9.Refresh();
					this.Enabled = true;
					return;
				}
				else
				{
					WriteStrToReg("SQLServerName", TextBox3.Text);
				}
				
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("SQL Server 登录帐号为空，初始化操作不能进行。");
					TextBox1.Focus();
					TextBox1.SelectAll();
					Label9.Text = "";
					Label9.Refresh();
					this.Enabled = true;
					return;
				}
				else
				{
					WriteStrToReg("SQL_User", TextBox1.Text);
				}
				
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("SQL Server 登录密码为空。系统不提倡使用空密码。");
				}
				WriteStrToReg("SQL_PSW", TextBox2.Text);
				
				//AppPath 运行路径
				if (TextBox7.Text.Trim() == "" || ! Directory.Exists(TextBox7.Text))
				{
					MessageBox.Show("运行路径不正确，初始化操作不能进行。");
					TextBox7.Focus();
					TextBox7.SelectAll();
					Label9.Text = "";
					Label9.Refresh();
					this.Enabled = true;
					return;
				}
				else
				{
					AppPath = TextBox7.Text;
					if (AppPath[AppPath.Length - 1] != '\\')
					{
						AppPath += "\\";
					}
					//检测运行路径下有无主文件存在
					if (File.Exists((AppPath + "DeskApp.exe").ToUpper()) || File.Exists((AppPath + "StorageApp.exe").ToUpper()) || File.Exists((AppPath + "SysAdmin.exe").ToUpper()))
						{
						//文件存在，记录运行路径
						WriteStrToReg("AppPath", TextBox7.Text);
					}
					else
					{
						MessageBox.Show("运行路径下没有找到相关的程序文件，初始化操作不能进行。");
						TextBox7.Focus();
						TextBox7.SelectAll();
						Label9.Text = "";
						Label9.Refresh();
						this.Enabled = true;
						return;
					}
				}
				
				//报表路径
				if (TextBox5.Text.Trim() == "" || ! Directory.Exists(TextBox5.Text))
				{
					MessageBox.Show("报表路径不正确，与报表相关的功能不能正确使用。");
				}
				else
				{
					WriteStrToReg("ReportPath", TextBox5.Text);
				}
				
				if (CheckBox1.Checked)
				{
					Label9.Text = "正在准备初始化并还原 SQL Server 数据库......";
					Label9.Refresh();
					//初始化数据库
					if (MessageBox.Show("警告：数据库初始化操作将删除原有SQL Server 数据库，所有原先保存的数据都将会丢失，并且无法恢复。" + '\r' + "如果您已经安装并初始化，请您提前做好数据库备份工作。" + '\r' + '\r' + "确定要初始化并还原 SQL Server 数据库？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! InitDB())
						{
							this.Enabled = true;
							return;
						}
					}
				}
				
				//数据库备份文件位置
				if (TextBox8.Text.Trim() == "" || ! File.Exists(TextBox8.Text))
				{
					//MsgBox("RMS 2.0 备份文件没有找到。")
				}
				else
				{
					WriteStrToReg("BackupedDBFileName", TextBox8.Text);
				}
				
				//数据库还原路径
				if (TextBox9.Text.Trim() == "" || ! Directory.Exists(TextBox9.Text))
				{
					//MsgBox("RMS 2.0 备份文件没有找到。")
				}
				else
				{
					WriteStrToReg("DBPath", TextBox9.Text);
				}
				
				//记录RMS Server信息
				WriteStrToReg("RemoteRMSServerName", TextBox10.Text);
				WriteStrToReg("RemoteRMSServerPort", NumericUpDown1.Text);
				
				//记录额外的注册表信息
				WriteStrToReg("DataBaseName", "RMS");
				WriteStrToReg("pkt_size", "4096");
				WriteStrToReg("ps_info", "true");
				
				Label9.Text = "系统初始化操作顺利完成！";
				Label9.Refresh();
				MessageBox.Show("系统初始化操作顺利完成！");
				
				this.Enabled = true;
				this.Close();
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
            //获取硬件序列号
            //String sn;
            //sn = Authorize.GetSerial();
            //txtSN.Text = sn;
            //txtUUID.Text = ReadStrfromReg("Key", "");

			//创建类库对象的实例，只创建这一次
			TheAppExt = new AppExt.CAppExt();
			
			//显示OEM Apptitle
			this.Text = TheAppExt.GetAppTitle + this.Text;
			
			//返回注册表中信息
			TextBox4.Text = ReadStrfromReg("RestaurantName", "餐厅管家");
			TextBox6.Text = ReadStrfromReg("Wkst_Id", Dns.GetHostName());
			TextBox3.Text = ReadStrfromReg("SQLServerName", Dns.GetHostName());
			TextBox1.Text = ReadStrfromReg("SQL_User", "sa");
			TextBox2.Text = ReadStrfromReg("SQL_PSW", "");
			TextBox7.Text = ReadStrfromReg("AppPath", Directory.GetCurrentDirectory());
			TextBox5.Text = ReadStrfromReg("ReportPath", Directory.GetCurrentDirectory());
			TextBox10.Text = ReadStrfromReg("RemoteRMSServerName", Dns.GetHostName());
			TextBox8.Text = ReadStrfromReg("BackupedDBFileName", Directory.GetCurrentDirectory());
			TextBox9.Text = ReadStrfromReg("DBPath", Directory.GetCurrentDirectory());
			NumericUpDown1.Text = ReadStrfromReg("RemoteRMSServerPort", "8023");
		}
		
		private void CheckBox1_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			GroupBox2.Enabled = CheckBox1.Checked;
		}
	}
	
}
