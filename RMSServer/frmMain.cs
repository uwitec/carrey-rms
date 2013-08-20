using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Microsoft.Win32;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Data.SqlClient;
//using Nox.Net.Apis;
using System.Drawing.Printing;

//引用以下名称空间

namespace RMSServer
{
	public class frmMain : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new frmMain());
		}
		private string queuePath;
		
		public AppExt.CAppExt TheAppExt; //类库中的对象
		
		public string ConnStr;
		public ReportDocument cr_PrintFood;
        internal System.Windows.Forms.Label Label7;
        internal DataGridTableStyle dataGridTableStyle2;
        internal DataGridTextBoxColumn dataGridTextBoxColumn5;
        internal DataGridTextBoxColumn dataGridTextBoxColumn6;
        internal DataGridTextBoxColumn dataGridTextBoxColumn7;
        internal DataGridTextBoxColumn dataGridTextBoxColumn8;
        internal DataGridTextBoxColumn dataGridTextBoxColumn9;
        private NotifyIcon notifyIcon1;
		
		const string regSubKey = "SOFTWARE\\Rithia Software\\RMS";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmMain()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化
			InitialApp();
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
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal RMSServer.FoodInfo foodInfo1;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.DataGrid DataGrid1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label9 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.foodInfo1 = new RMSServer.FoodInfo();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Location = new System.Drawing.Point(384, 288);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "退出(&Q)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(479, 24);
            this.Label1.TabIndex = 3;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 3000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.Red;
            this.Label9.Location = new System.Drawing.Point(0, 24);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(479, 24);
            this.Label9.TabIndex = 15;
            this.Label9.Text = "状态：空闲";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(8, 56);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(455, 216);
            this.TabControl1.TabIndex = 16;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(447, 190);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "选项";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label5.Location = new System.Drawing.Point(17, 96);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(414, 41);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "服务程序是餐厅管家系统的重要组成部分，它提供了远程传菜以及自动分单打印功能。";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.NumericUpDown2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(414, 72);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(72, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 23);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "通信侦听端口：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(168, 16);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(64, 21);
            this.NumericUpDown2.TabIndex = 9;
            this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown2.Value = new decimal(new int[] {
            8023,
            0,
            0,
            0});
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 40);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(144, 23);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "自动分单打印响应时间：";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(232, 40);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 23);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "毫秒";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(168, 40);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(64, 21);
            this.NumericUpDown1.TabIndex = 6;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.ComboBox1);
            this.TabPage3.Controls.Add(this.DataGrid1);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(447, 190);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "分类打印机";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Location = new System.Drawing.Point(73, 73);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 20);
            this.ComboBox1.TabIndex = 2;
            this.ComboBox1.Text = "ComboBox1";
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // DataGrid1
            // 
            this.DataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid1.CaptionText = "分类打印机";
            this.DataGrid1.DataMember = "";
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(8, 8);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.Size = new System.Drawing.Size(431, 176);
            this.DataGrid1.TabIndex = 0;
            this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle2});
            this.DataGrid1.CurrentCellChanged += new System.EventHandler(this.DataGrid1_CurrentCellChanged);
            this.DataGrid1.Click += new System.EventHandler(this.DataGrid1_Click);
            this.DataGrid1.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGrid1_Paint);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.DataGrid = this.DataGrid1;
            this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn5,
            this.dataGridTextBoxColumn6,
            this.dataGridTextBoxColumn7,
            this.dataGridTextBoxColumn8,
            this.dataGridTextBoxColumn9});
            this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle2.MappingName = "printer";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "类型代码";
            this.dataGridTextBoxColumn5.MappingName = "TypeCode";
            this.dataGridTextBoxColumn5.Width = 75;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "类型名称";
            this.dataGridTextBoxColumn6.MappingName = "TypeName";
            this.dataGridTextBoxColumn6.Width = 75;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "部门代码";
            this.dataGridTextBoxColumn7.MappingName = "DeptCode";
            this.dataGridTextBoxColumn7.Width = 75;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "打印机";
            this.dataGridTextBoxColumn8.MappingName = "typeprinter";
            this.dataGridTextBoxColumn8.Width = 75;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "打印机(备用)";
            this.dataGridTextBoxColumn9.MappingName = "typeprinterbak";
            this.dataGridTextBoxColumn9.Width = 75;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.ListBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(447, 190);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "历史记录";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.HorizontalScrollbar = true;
            this.ListBox1.ItemHeight = 12;
            this.ListBox1.Location = new System.Drawing.Point(0, 0);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(447, 196);
            this.ListBox1.TabIndex = 0;
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = null;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4});
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "printer";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "类别编码";
            this.DataGridTextBoxColumn1.MappingName = "typecode";
            this.DataGridTextBoxColumn1.NullText = "";
            this.DataGridTextBoxColumn1.Width = 65;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "菜品类别";
            this.DataGridTextBoxColumn2.MappingName = "typename";
            this.DataGridTextBoxColumn2.NullText = "";
            this.DataGridTextBoxColumn2.Width = 85;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "打印机名称";
            this.DataGridTextBoxColumn3.MappingName = "typeprinter";
            this.DataGridTextBoxColumn3.NullText = "";
            this.DataGridTextBoxColumn3.Width = 160;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "备用打印机名称";
            this.DataGridTextBoxColumn4.MappingName = "typeprinterbak";
            this.DataGridTextBoxColumn4.NullText = "";
            this.DataGridTextBoxColumn4.Width = 160;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.Navy;
            this.Label6.Location = new System.Drawing.Point(6, 305);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(304, 16);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "版本：";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(8, 275);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(404, 30);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Label7";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RMS Server";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(478, 329);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "服务程序 v2.0";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		
		#endregion
		
	
		//读写注册表
		public string ReadStrfromReg(string KeyName, string defaultvalue)
		{
			RegistryKey reg;
            string ret = "";
			reg = Registry.CurrentUser.OpenSubKey(regSubKey.ToString(), false);
            if (reg != null)
            {
                ret=reg.GetValue(KeyName, defaultvalue).ToString();
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
		
		private void EnsureQueueExists(string queuePath)
		{
            try
            {
                if (!System.Messaging.MessageQueue.Exists(queuePath))
                {
                    System.Messaging.MessageQueue.Create(queuePath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
		}
		
		//程序初始化操作
		public void InitialApp()
		{
			//读取数据库连接选项
			ConnStr = "workstation id=" + (ReadStrfromReg("Wkst_Id", "") + ";") + "packet size=" + (ReadStrfromReg("pkt_size", "") + ";") + "user id=" + (ReadStrfromReg("SQL_User", "") + ";") + "data source=" + (ReadStrfromReg("SQLServerName", "") + ";") + "persist security info=" + (ReadStrfromReg("ps_info", "") + ";") + "initial catalog=" + (ReadStrfromReg("DataBaseName", "") + ";") + "password=" + ReadStrfromReg("SQL_PSW", "");
		}
		
		//更新菜品传送标志
		public void UpdateFoodTransSign(string barcode)
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
		
		//返回打印菜品的打印机名
		private string GetFoodPrinterName(string foodname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT deptprinter,typeprinter FROM view_FoodList where foodname ='" + foodname + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0][1].ToString(); //若返回部门打印机名则 Return dbDS.Tables(0).Rows(0).Item(0).ToString
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
		
		//返回打印菜品的备用打印机名
		private string GetFoodBakPrinterName(string foodname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret = "";
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT deptprinter,typeprinterbak FROM view_FoodList where foodname ='" + foodname + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0][1].ToString(); //若返回部门打印机名则 Return dbDS.Tables(0).Rows(0).Item(0).ToString
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
		
		//返回雇员名称
		private string GetEmpName(string operatorid)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT name FROM view_operator where operatorid ='" + operatorid + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				ret=dbDS.Tables[0].Rows[0][0].ToString();
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
		public string GetAppPath()
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
		
		private string GetPrintFoodReportFile()
		{
			//获取报表路径信息
			return GetAppPath() + "FoodInfo.rpt";
		}
		
		//打印操作
		private void PrintFood(string operatecode, string billno, string tableno, string PsnCount, string foodname, string unit, string quantity, string operandi, string taste, string operatorid, string barcode)
			{
			
			if (cr_PrintFood == null)
			{
				cr_PrintFood = new ReportDocument();
			}
			else
			{
				cr_PrintFood.Close();
				cr_PrintFood = null;
				cr_PrintFood = new ReportDocument();
			}
			//检测报表文件是否存在
			string reportFile;
			reportFile = GetPrintFoodReportFile();
			//MessageBox.Show(reportFile)
			if (File.Exists(reportFile))
			{
				cr_PrintFood.Load(reportFile);
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查当前服务程序的运行路径下有无 FoodInfo.rpt 文件。如果问题依然存在，请联系系统供应商。");
				return;
			}
			//根据菜品名称返回菜品类别所属打印机(或所属部门打印机)，准备由该打印机进行打印
			string printername1; //默认打印机及备用打印机
			string printername2;
			
			printername1 = GetFoodPrinterName(foodname);
			printername2 = GetFoodBakPrinterName(foodname);
			
			if (printername1 == "" || printername1 == "无") //没有分配打印机
			{
				ListBox1.Items.Add(DateTime.Now + " 菜品：" + foodname + " 所属类别没有设置打印机，打印操作不能进行。");
				ListBox1.Refresh();
				return; //如果类别打印机是空，不打印该菜品
			}
			
			TableLogOnInfo logOnInfo = new TableLogOnInfo();
			int i;
			
			// 对报表中的每个表依次循环。
			for (i = 0; i <= cr_PrintFood.Database.Tables.Count - 1; i++)
			{
				// 设置当前表的连接信息。
				logOnInfo.ConnectionInfo.ServerName = ReadStrfromReg("SQLServerName", "");
				logOnInfo.ConnectionInfo.DatabaseName = ReadStrfromReg("DataBaseName", "");
				logOnInfo.ConnectionInfo.UserID = ReadStrfromReg("SQL_User", "");
				logOnInfo.ConnectionInfo.Password = ReadStrfromReg("SQL_PSW", "");
				cr_PrintFood.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
			}
			
			ParameterFieldDefinitions crParameterFieldDefinitions;
			ParameterFieldDefinition crParameterFieldDefinition;
			ParameterValues crParameterValues;
			ParameterDiscreteValue crParameterDiscreteValue;
			
			crParameterFieldDefinitions = cr_PrintFood.DataDefinition.ParameterFields;
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@billno"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "单据号：" + billno;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@tableno"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "桌台号：" + tableno;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@foodname"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "菜品名称：" + foodname;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@unit"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "单位：" + unit;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@quantity"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "数量：" + quantity;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@operandi"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "做法：" + operandi;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@taste"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "口味：" + taste;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@operatorid"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "操作员ID：" + GetEmpName(operatorid);
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@barcode"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = barcode;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@psncount"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = "人数：" + PsnCount;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			string printtile="";
			//OperateCode = 0 传菜 OperateCode = 1 催菜 OperateCode = 2 缓菜 OperateCode = 3 退菜
			switch (operatecode)
			{
				case ("0"):
					printtile = "传菜单";
					break;
				case ("1"):
					printtile = "催菜单";
					break;
				case ("2"):
					printtile = "缓菜单";
					break;
				case ("3"):
					printtile = "退菜单";
					break;
			}
			
			crParameterFieldDefinition = crParameterFieldDefinitions["@title"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = printtile;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			//检测当前打印机是否有效
			PrintDocument pd1 = new PrintDocument();
			
			pd1.PrinterSettings.PrinterName = printername1;
			
			if (pd1.PrinterSettings.IsValid) //打印到指定打印机
			{
				cr_PrintFood.PrintOptions.PrinterName = printername1;
				cr_PrintFood.PrintToPrinter(1, true, 1, 1);
			}
			else //无效，检测备用打印机
			{
				PrintDocument pd2 = new PrintDocument();
				
				pd2.PrinterSettings.PrinterName = printername2;
				if (pd2.PrinterSettings.IsValid)
				{
					cr_PrintFood.PrintOptions.PrinterName = printername2;
					cr_PrintFood.PrintToPrinter(1, true, 1, 1);
				}
				else //备用机同样无效，显示错误
				{
					ListBox1.Items.Add(DateTime.Now + " 打印失败！来自 " + tableno + " 号桌台，单据号为 " + billno + " 的" + printtile + "，菜品名称：" + foodname + " 数量：" + quantity + " -> 操作员：" + operatorid);
					ListBox1.Refresh();
					return;
				}
			}
			
			ListBox1.Items.Add(DateTime.Now + " 已成功打印来自 " + tableno + " 号桌台，单据号为 " + billno + " 的" + printtile + "，菜品名称：" + foodname + " 数量：" + quantity + " -> 操作员：" + operatorid);
			ListBox1.Refresh();
		}
		
		//接收要打印的菜品信息
		private void ReceiveFood()
		{
			System.Messaging.MessageQueue queue = new System.Messaging.MessageQueue(queuePath);
			queue.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] {typeof(AppExt.CAppExt.FoodInfo)});
			
			foreach (System.Messaging.Message msg in queue)
			{
				AppExt.CAppExt.FoodInfo Food = (AppExt.CAppExt.FoodInfo) msg.Body;
				
				switch (Food.OperateCode)
				{
					case 0: //传菜
						Label9.Text = "正在接收并打印 传菜单......";
						Label9.Refresh();
						//对该菜品进行 传菜 打印处理
						
						PrintFood(Food.OperateCode.ToString(), Food.Billno, Food.Tableno, Food.PsnCount, Food.FoodName, Food.unit, Food.quantity, Food.operandi, Food.taste, Food.operatorid, Food.BarCode);
						
						ListBox1.Items.Add(DateTime.Now + " 已成功接收并处理来自 " + Food.Tableno + " 号桌台，单据号为 " + Food.Billno + " 的传菜单，菜品名称：" + Food.FoodName + " 数量：" + Food.quantity + " -> 操作员：" + Food.operatorid);
						ListBox1.Refresh();
						break;
					case 1: //催菜
						Label9.Text = "正在接收并打印 催菜单......";
						Label9.Refresh();
						//对该菜品进行 催菜 打印处理
						
						PrintFood(Food.OperateCode.ToString(), Food.Billno, Food.Tableno, Food.PsnCount, Food.FoodName, Food.unit, Food.quantity, Food.operandi, Food.taste, Food.operatorid, Food.BarCode);
						
						ListBox1.Items.Add(DateTime.Now + " 已成功接收并处理来自 " + Food.Tableno + " 号桌台的 催菜单，菜品名称：" + Food.FoodName + " 数量：" + Food.quantity + " -> 操作员：" + Food.operatorid);
						ListBox1.Refresh();
						break;
						
					case 2: //缓菜
						Label9.Text = "正在接收并打印 退菜单......";
						Label9.Refresh();
						//对该菜品进行 缓菜 打印处理
						
						PrintFood(Food.OperateCode.ToString(), Food.Billno, Food.Tableno, Food.PsnCount, Food.FoodName, Food.unit, Food.quantity, Food.operandi, Food.taste, Food.operatorid, Food.BarCode);
						
						ListBox1.Items.Add(DateTime.Now + " 已成功接收并处理来自 " + Food.Tableno + " 号桌台的 缓菜单，菜品名称：" + Food.FoodName + " 数量：" + Food.quantity + " -> 操作员：" + Food.operatorid);
						ListBox1.Refresh();
						break;
						
					case 3: //退菜
						Label9.Text = "正在接收并打印 退菜单......";
						Label9.Refresh();
						//对该菜品进行 退菜 打印处理
						
						PrintFood(Food.OperateCode.ToString(), Food.Billno, Food.Tableno, Food.PsnCount, Food.FoodName, Food.unit, Food.quantity, Food.operandi, Food.taste, Food.operatorid, Food.BarCode);
						
						ListBox1.Items.Add(DateTime.Now + " 已成功接收并处理来自 " + Food.Tableno + " 号桌台的 退菜单，菜品名称：" + Food.FoodName + " 数量：" + Food.quantity + " ，退菜原因：" + Food.CancelRsn + " -> 操作员：" + Food.operatorid);
						ListBox1.Refresh();
						break;
				}
				queue.ReceiveById(msg.Id);
			}
			Label9.Text = "状态：空闲";
			Label9.Refresh();
		}
		
		//注册远程服务
		private bool RegRMSServer()
		{
			bool returnValue;
			returnValue = false;
			
			//当错误发生时，转向错误处理语句
            try
            {
                //定义一个Tcp通道
                TcpChannel tChannel = new TcpChannel(Convert.ToInt32(NumericUpDown2.Value));
                //注册通道
                ChannelServices.RegisterChannel(tChannel);
                //注册服务
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(CRmsSvr.CRMSServer), "RMSServer", WellKnownObjectMode.Singleton);

                returnValue = true;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return returnValue;
		}
		
		//更新打印机
		private bool UpdateTypePrinter(string typecode, string printername)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "update foodtype set typeprinter='" + printername + "'" + " where typecode='" + typecode + "'";
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				LoadPrinter();
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
		
		//更新备用打印机
		private bool UpdateTypePrinterBak(string typecode, string printername)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "update foodtype set typeprinterbak='" + printername + "'" + " where typecode='" + typecode + "'";
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				LoadPrinter();
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
		
		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			Timer1.Enabled = false;
			ReceiveFood();
			Timer1.Enabled = true;
		}
		
		//获取分类打印机
		private void LoadPrinter()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM foodtype"; //返回菜品所属类别打印机
				//selectCMD.CommandText = "SELECT * FROM department" '返回菜品所属部门打印机
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "printer");
				DataGrid1.DataSource = null;
				DataGrid1.DataSource = dbDS;
				DataGrid1.DataMember = "printer";
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
		
		//返回系统单据总数
		public int GetCurrentTableNoBillsCount(string tableno)
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
		
		private void Form1_Load(System.Object sender, System.EventArgs e)
		{
			//创建类库对象的实例，只创建这一次
			TheAppExt = new AppExt.CAppExt();
			
			TheAppExt.LogModule = 6; //报告登录的是->RMS 服务程序模块
#if	NEEDLOGIN		
			string rtn = TheAppExt.ShowLogForm("服务程序");
			if (rtn.Trim() =="-1")
			{
                Application.Exit();
			}
#endif

			ConnStr = TheAppExt.GetConnStr; //复制远程连接字符串

			if (GetCurrentTableNoBillsCount("") >= 200)
			{
				return;
			}
			queuePath = ".\\private$\\RMS";
			EnsureQueueExists(queuePath);
			//MessageBox.Show("1")
			//LoadSetting
			System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
			string ver;
			ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
			Label6.Text = "版本：" + ver;
			if (RegRMSServer())
			{
				//在文本框显示注册成功信息
				Label1.Text = "注册成功！正在运行服务....";
				Timer1.Interval = System.Convert.ToInt32(NumericUpDown1.Value);
				NumericUpDown2.Enabled = false;
				Timer1.Enabled = true;
			}
			//读取设置
			ReadStrfromReg("RemoteRMSServerPort", "8023");
			ReadStrfromReg("AutoPrintInterval", "1000");
			//MessageBox.Show("2")
			LoadPrinter();
			//返回所有打印机列表
			ComboBox1.Visible = false;
			ComboBox1.Items.Clear();
			for (int i = 0; i <= PrinterSettings.InstalledPrinters.Count - 1; i++)
			{
				ComboBox1.Items.Add(PrinterSettings.InstalledPrinters[i]);
			}
			ComboBox1.Items.Add("无");
			Label7.Text = "当前报表文件路径：" + GetPrintFoodReportFile();
			//MessageBox.Show("3")
		}
		
		private void NumericUpDown1_ValueChanged(System.Object sender, System.EventArgs e)
		{
			Timer1.Enabled = false;
			Timer1.Interval = System.Convert.ToInt32(NumericUpDown1.Value);
			Timer1.Enabled = true;
		}
		
		private void NumericUpDown1_KeyUp(System.Object sender, System.Windows.Forms.KeyEventArgs e)
		{
			Timer1.Enabled = false;
			Timer1.Interval = System.Convert.ToInt32(NumericUpDown1.Value);
			Timer1.Enabled = true;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
            //this.Close();
            if (MessageBox.Show("警告：退出服务程序 会导致餐饮系统出现严重问题！强烈建议您不要退出该程序。" + '\r' + '\r' + "您确定要退出服务程序吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //保存设置
                WriteStrToReg("RemoteRMSServerPort", NumericUpDown2.Text);
                WriteStrToReg("AutoPrintInterval", NumericUpDown1.Text);
                this.notifyIcon1.Visible = false;
                Application.Exit();
            }
            
		}
		
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            e.Cancel = true;
            //if (MessageBox.Show("警告：退出服务程序 会导致餐饮系统出现严重问题！强烈建议您不要退出该程序。" + '\r' + '\r' + "您确定要退出服务程序吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //{
            //    //保存设置
            //    WriteStrToReg("RemoteRMSServerPort", NumericUpDown2.Text);
            //    WriteStrToReg("AutoPrintInterval", NumericUpDown1.Text);
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
		}
		
		private void DataGrid1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (DataGrid1.CurrentCell.ColumnNumber == 3 || DataGrid1.CurrentCell.ColumnNumber == 4)
			{
				ComboBox1.Width = DataGrid1.GetCurrentCellBounds().Width + 2;
			}
		}
		
		private void DataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			if (DataGrid1.CurrentCell.ColumnNumber == 3 || DataGrid1.CurrentCell.ColumnNumber == 4)
			{
				ComboBox1.Visible = false;
				ComboBox1.Width = 0;
				ComboBox1.Left = DataGrid1.GetCurrentCellBounds().Left + 7;
				ComboBox1.Top = DataGrid1.GetCurrentCellBounds().Top + 7;
				ComboBox1.Text = DataGrid1[DataGrid1.CurrentCell].ToString() + "";
				ComboBox1.Visible = true;
			}
			else
			{
				ComboBox1.Visible = false;
				ComboBox1.Width = 0;
			}
		}
		
		private void DataGrid1_Scroll(object sender, System.EventArgs e)
		{
			ComboBox1.Visible = false;
			ComboBox1.Width = 0;
		}
		
		private void DataGrid1_Click(object sender, System.EventArgs e)
		{
			ComboBox1.Visible = false;
			ComboBox1.Width = 0;
		}
		
		private void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (DataGrid1.CurrentCell.ColumnNumber == 3)
			{
				ComboBox1.Visible = false;
                UpdateTypePrinter(DataGrid1[DataGrid1.CurrentRowIndex, 0].ToString(), ComboBox1.Text);
			}
			
			if (DataGrid1.CurrentCell.ColumnNumber == 4)
			{
				ComboBox1.Visible = false;
                UpdateTypePrinterBak(DataGrid1[DataGrid1.CurrentRowIndex, 0].ToString(), ComboBox1.Text);
			}
		}

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.notifyIcon1.Visible = false;
        }
	}
	
}
