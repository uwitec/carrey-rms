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
	public class frmSysSetup : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSysSetup()
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
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.CheckBox CheckBox3;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.RadioButton RadioButton5;
		internal System.Windows.Forms.RadioButton RadioButton4;
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.CheckBox CheckBox8;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.CheckBox CheckBox4;
		internal System.Windows.Forms.CheckBox CheckBox6;
		internal System.Windows.Forms.CheckBox CheckBox7;
		internal System.Windows.Forms.CheckBox CheckBox9;
		internal System.Windows.Forms.ComboBox ComboBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSysSetup));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(frmSysSetup_Load);
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.CheckBox6 = new System.Windows.Forms.CheckBox();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.CheckBox7 = new System.Windows.Forms.CheckBox();
			this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label6 = new System.Windows.Forms.Label();
			this.CheckBox3 = new System.Windows.Forms.CheckBox();
			this.CheckBox2 = new System.Windows.Forms.CheckBox();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.RadioButton5 = new System.Windows.Forms.RadioButton();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.CheckBox9 = new System.Windows.Forms.CheckBox();
			this.CheckBox4 = new System.Windows.Forms.CheckBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.CheckBox8 = new System.Windows.Forms.CheckBox();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.TabPage3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Location = new System.Drawing.Point(16, 16);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(384, 264);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.CheckBox6);
			this.TabPage1.Controls.Add(this.TextBox5);
			this.TabPage1.Controls.Add(this.TextBox4);
			this.TabPage1.Controls.Add(this.TextBox3);
			this.TabPage1.Controls.Add(this.TextBox2);
			this.TabPage1.Controls.Add(this.TextBox1);
			this.TabPage1.Controls.Add(this.Label5);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Location = new System.Drawing.Point(4, 21);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(376, 239);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = " 酒店信息 ";
			//
			//CheckBox6
			//
			this.CheckBox6.Location = new System.Drawing.Point(104, 48);
			this.CheckBox6.Name = "CheckBox6";
			this.CheckBox6.Size = new System.Drawing.Size(224, 24);
			this.CheckBox6.TabIndex = 5;
			this.CheckBox6.Text = "将酒店信息同时保存在注册表里";
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(104, 152);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(224, 21);
			this.TextBox5.TabIndex = 4;
			this.TextBox5.Text = "";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(104, 128);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(224, 21);
			this.TextBox4.TabIndex = 3;
			this.TextBox4.Text = "";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(104, 104);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(224, 21);
			this.TextBox3.TabIndex = 2;
			this.TextBox3.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(104, 80);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(224, 21);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(104, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(224, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(32, 152);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "网址：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(32, 128);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "电子邮件：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(32, 104);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "联系电话：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(32, 80);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "通信地址：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(32, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "酒店名称：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.CheckBox1);
			this.TabPage2.Controls.Add(this.CheckBox7);
			this.TabPage2.Controls.Add(this.NumericUpDown3);
			this.TabPage2.Controls.Add(this.NumericUpDown2);
			this.TabPage2.Controls.Add(this.Label8);
			this.TabPage2.Controls.Add(this.Label7);
			this.TabPage2.Controls.Add(this.NumericUpDown1);
			this.TabPage2.Controls.Add(this.Label6);
			this.TabPage2.Controls.Add(this.CheckBox3);
			this.TabPage2.Controls.Add(this.CheckBox2);
			this.TabPage2.Location = new System.Drawing.Point(4, 21);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new System.Drawing.Size(376, 239);
			this.TabPage2.TabIndex = 3;
			this.TabPage2.Text = " 单据/编码 ";
			//
			//CheckBox1
			//
			this.CheckBox1.Location = new System.Drawing.Point(200, 16);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(160, 24);
			this.CheckBox1.TabIndex = 0;
			this.CheckBox1.Text = "前台单据号自动生成";
			//
			//CheckBox7
			//
			this.CheckBox7.Location = new System.Drawing.Point(24, 16);
			this.CheckBox7.Name = "CheckBox7";
			this.CheckBox7.Size = new System.Drawing.Size(176, 24);
			this.CheckBox7.TabIndex = 9;
			this.CheckBox7.Text = "点菜后自动传送远程传菜单";
			//
			//NumericUpDown3
			//
			this.NumericUpDown3.Location = new System.Drawing.Point(128, 152);
			this.NumericUpDown3.Maximum = new decimal(new int[] {12, 0, 0, 0});
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new System.Drawing.Size(93, 21);
			this.NumericUpDown3.TabIndex = 5;
			this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.Location = new System.Drawing.Point(128, 124);
			this.NumericUpDown2.Maximum = new decimal(new int[] {12, 0, 0, 0});
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new System.Drawing.Size(93, 21);
			this.NumericUpDown2.TabIndex = 4;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(32, 151);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(96, 23);
			this.Label8.TabIndex = 8;
			this.Label8.Text = "物料编码长度：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(32, 123);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(96, 23);
			this.Label7.TabIndex = 7;
			this.Label7.Text = "原料编码长度：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(128, 96);
			this.NumericUpDown1.Maximum = new decimal(new int[] {15, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(93, 21);
			this.NumericUpDown1.TabIndex = 3;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(32, 95);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(96, 23);
			this.Label6.TabIndex = 6;
			this.Label6.Text = "菜例编码长度：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//CheckBox3
			//
			this.CheckBox3.Location = new System.Drawing.Point(200, 48);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new System.Drawing.Size(160, 24);
			this.CheckBox3.TabIndex = 2;
			this.CheckBox3.Text = "入库/直拨单读最近进价";
			//
			//CheckBox2
			//
			this.CheckBox2.Location = new System.Drawing.Point(24, 48);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new System.Drawing.Size(160, 24);
			this.CheckBox2.TabIndex = 1;
			this.CheckBox2.Text = "库存单据号自动生成";
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.GroupBox4);
			this.TabPage3.Controls.Add(this.GroupBox2);
			this.TabPage3.Location = new System.Drawing.Point(4, 21);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(376, 239);
			this.TabPage3.TabIndex = 4;
			this.TabPage3.Text = " 高级 ";
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.RadioButton5);
			this.GroupBox4.Controls.Add(this.RadioButton4);
			this.GroupBox4.Controls.Add(this.RadioButton3);
			this.GroupBox4.Location = new System.Drawing.Point(8, 176);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(360, 56);
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "菜品成本算法";
			//
			//RadioButton5
			//
			this.RadioButton5.Location = new System.Drawing.Point(240, 19);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new System.Drawing.Size(112, 24);
			this.RadioButton5.TabIndex = 2;
			this.RadioButton5.Text = "库存原料平均价";
			//
			//RadioButton4
			//
			this.RadioButton4.Location = new System.Drawing.Point(112, 19);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(128, 24);
			this.RadioButton4.TabIndex = 1;
			this.RadioButton4.Text = "读取最近原料进价";
			//
			//RadioButton3
			//
			this.RadioButton3.Location = new System.Drawing.Point(8, 19);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.TabIndex = 0;
			this.RadioButton3.Text = "手动指定成本";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.ComboBox1);
			this.GroupBox2.Controls.Add(this.CheckBox9);
			this.GroupBox2.Controls.Add(this.CheckBox4);
			this.GroupBox2.Controls.Add(this.GroupBox3);
			this.GroupBox2.Location = new System.Drawing.Point(8, 8);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(360, 160);
			this.GroupBox2.TabIndex = 0;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "结帐设置";
			//
			//ComboBox1
			//
			this.ComboBox1.Items.AddRange(new object[] {"实际支付金额", "支付金额抹去角分", "支付金额四舍五入到元"});
			this.ComboBox1.Location = new System.Drawing.Point(24, 16);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(152, 20);
			this.ComboBox1.TabIndex = 6;
			this.ComboBox1.Text = "ComboBox1";
			//
			//CheckBox9
			//
			this.CheckBox9.Location = new System.Drawing.Point(176, 16);
			this.CheckBox9.Name = "CheckBox9";
			this.CheckBox9.Size = new System.Drawing.Size(176, 24);
			this.CheckBox9.TabIndex = 5;
			this.CheckBox9.Text = "允许优惠及特价菜品折上折";
			this.CheckBox9.Visible = false;
			//
			//CheckBox4
			//
			this.CheckBox4.Location = new System.Drawing.Point(24, 40);
			this.CheckBox4.Name = "CheckBox4";
			this.CheckBox4.Size = new System.Drawing.Size(312, 24);
			this.CheckBox4.TabIndex = 4;
			this.CheckBox4.Text = "当客户消费金额低于最低消费时最低消费结账";
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.CheckBox8);
			this.GroupBox3.Controls.Add(this.RadioButton2);
			this.GroupBox3.Controls.Add(this.RadioButton1);
			this.GroupBox3.Location = new System.Drawing.Point(8, 72);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(344, 80);
			this.GroupBox3.TabIndex = 3;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "客户/会员结帐";
			//
			//CheckBox8
			//
			this.CheckBox8.Location = new System.Drawing.Point(24, 48);
			this.CheckBox8.Name = "CheckBox8";
			this.CheckBox8.Size = new System.Drawing.Size(232, 24);
			this.CheckBox8.TabIndex = 2;
			this.CheckBox8.Text = "累计签单金额大于签单限额允许结帐";
			//
			//RadioButton2
			//
			this.RadioButton2.Location = new System.Drawing.Point(160, 17);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(144, 24);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "固定折扣";
			//
			//RadioButton1
			//
			this.RadioButton1.Location = new System.Drawing.Point(24, 17);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(128, 24);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.Text = "会员累计金额折扣";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(224, 296);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(304, 296);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//frmSysSetup
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(416, 334);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSysSetup";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "系统设置";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.TabPage3.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回系统设置信息
		private void LoadSysSetupInfo()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
            try
            {
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA = new SqlDataAdapter();
				DataSet dbDS = new DataSet();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				
				//companyname
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='companyname'";
				dbDA.SelectCommand = selectCMD;
				
				dbDA.Fill(dbDS, "t");
				TextBox1.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				TextBox1.Text = rms_var.ReadStrfromReg("RestaurantName", "");
				
				//address
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='address'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				TextBox2.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//telphone
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='telphone'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				TextBox3.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//email
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='email'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				TextBox4.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//webpage
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='webpage'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				TextBox5.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//autobalancebill 前台单据号自动生成
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='autobalancebill'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				CheckBox1.Checked =dbDS.Tables[0].Rows[0]["value"].ToString()=="1"?true:false;
				
				//autostorebill 库存单据号自动生成
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='autostorebill'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                CheckBox2.Checked = dbDS.Tables[0].Rows[0]["value"].ToString() == "1" ? true : false;
				
				//showlastprice 入库直拨的单价从商品库中读最新进价
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='showlastprice'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                CheckBox3.Checked = dbDS.Tables[0].Rows[0]["value"].ToString() == "1" ? true : false;
				
				//foodcodelenth 菜例代码长度
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='foodcodelenth'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				NumericUpDown1.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//YMatCodeLen 原料物品代码长度
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='YMatCodeLen'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				NumericUpDown2.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//WMatCodeLen 物料物品代码长度
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='WMatCodeLen'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                NumericUpDown3.Text = dbDS.Tables[0].Rows[0]["value"].ToString();
				
				//autotmpcost 结账 自动抹零 四舍五入
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='autotmpcost'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				ComboBox1.SelectedIndex = int.Parse(dbDS.Tables[0].Rows[0]["value"].ToString());
				
				//lowerpay 当客户消费低于最低最低消费用最低消费结账
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='lowerpay'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                CheckBox4.Checked = dbDS.Tables[0].Rows[0]["value"].ToString() == "1" ? true : false;
				
				//clubfixedderate 会员卡固定折扣
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='clubfixedderate'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				if (Convert.ToInt32(dbDS.Tables[0].Rows[0]["value"]) == 1)
				{
					RadioButton2.Checked = true;
				}
				else
				{
					RadioButton1.Checked = true;
				}
				
				//SignFullBalance 签单金额累计超过限额,是否允许签单结账
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='SignFullBalance'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                CheckBox8.Checked = dbDS.Tables[0].Rows[0]["value"].ToString() == "1" ? true : false;
				
				//DiscountOnDiscount 允许优惠菜品特价菜品折上折
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='DiscountOnDiscount'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                CheckBox9.Checked = dbDS.Tables[0].Rows[0]["value"].ToString() == "1" ? true : false;
				
				//foodcodecost 菜例成本卡计算方法
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='foodcodecost'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
				if (Convert.ToInt32(dbDS.Tables[0].Rows[0]["value"]) == 1)
				{
					RadioButton3.Checked = true;
				}
				else if (Convert.ToInt32(dbDS.Tables[0].Rows[0]["value"]) == 2)
				{
					RadioButton4.Checked = true;
				}
				else if (Convert.ToInt32(dbDS.Tables[0].Rows[0]["value"]) == 3)
				{
					RadioButton5.Checked = true;
				}
				
				//autoPrintFood 自动打印传菜单
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='autoPrintFood'";
				dbDA.SelectCommand = selectCMD;
				dbDS.Clear();
				dbDA.Fill(dbDS, "t");
                CheckBox7.Checked = dbDS.Tables[0].Rows[0]["value"].ToString() == "1" ? true : false;
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
		
		//保存系统设置信息
		private void SaveSysSetupInfo()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				//Dim dbDA As SqlDataAdapter = New SqlDataAdapter
				//Dim dbDS As DataSet = New DataSet
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				
				//CompanyName
				selectCMD.CommandText = "update syssetup set value='" + TextBox1.Text + "' " + "where parametercode='companyname'";
				
				selectCMD.ExecuteNonQuery();
				
				if (CheckBox6.Checked) //同时保存到注册表里
				{
					rms_var.WriteStrToReg("RestaurantName", TextBox1.Text);
				}
				
				//address
				selectCMD.CommandText = "update syssetup set value='" + TextBox2.Text + "' " + "where parametercode='address'";
				
				selectCMD.ExecuteNonQuery();
				
				//telphone
				selectCMD.CommandText = "update syssetup set value='" + TextBox3.Text + "' " + "where parametercode='telphone'";
				
				selectCMD.ExecuteNonQuery();
				
				//email
				selectCMD.CommandText = "update syssetup set value='" + TextBox4.Text + "' " + "where parametercode='email'";
				
				selectCMD.ExecuteNonQuery();
				
				//webpage
				selectCMD.CommandText = "update syssetup set value='" + TextBox5.Text + "' " + "where parametercode='webpage'";
				
				selectCMD.ExecuteNonQuery();
				
				//autobalancebill 前台单据号自动生成
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox1.Checked)).ToString() + "' " + "where parametercode='autobalancebill'";
				
				selectCMD.ExecuteNonQuery();
				
				//autostorebill 库存单据号自动生成
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox2.Checked)).ToString() + "' " + "where parametercode='autostorebill'";
				
				selectCMD.ExecuteNonQuery();
				
				//showlastprice 入库直拨的单价从商品库中读最新进价
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox3.Checked)).ToString() + "' " + "where parametercode='showlastprice'";
				
				selectCMD.ExecuteNonQuery();
				
				//foodcodelenth 菜例代码长度
				selectCMD.CommandText = "update syssetup set value='" + NumericUpDown1.Text + "' " + "where parametercode='foodcodelenth'";
				
				selectCMD.ExecuteNonQuery();
				
				//YMatCodeLen 原料物品代码长度
				selectCMD.CommandText = "update syssetup set value='" + NumericUpDown2.Text + "' " + "where parametercode='YMatCodeLen'";
				
				selectCMD.ExecuteNonQuery();
				
				//WMatCodeLen 物料物品代码长度
				selectCMD.CommandText = "update syssetup set value='" + NumericUpDown3.Text + "' " + "where parametercode='WMatCodeLen'";
				
				selectCMD.ExecuteNonQuery();
				
				//autotmpcost 结账自动抹零
				selectCMD.CommandText = "update syssetup set value='" + ComboBox1.SelectedIndex.ToString() + "' " + "where parametercode='autotmpcost'";
				
				selectCMD.ExecuteNonQuery();
				
				//lowerpay 当客户消费低于最低最低消费用最低消费结账
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox4.Checked)).ToString() + "' " + "where parametercode='lowerpay'";
				
				selectCMD.ExecuteNonQuery();
				
				//clubfixedderate 会员卡固定折扣
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(RadioButton2.Checked)).ToString() + "' " + "where parametercode='clubfixedderate'";
				
				selectCMD.ExecuteNonQuery();
				
				//SignFullBalance 签单金额累计超过限额,是否允许签单结账
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox8.Checked)).ToString() + "' " + "where parametercode='SignFullBalance'";
				
				selectCMD.ExecuteNonQuery();
				
				//DiscountOnDiscount 允许优惠菜品特价菜品折上折
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox9.Checked)).ToString() + "' " + "where parametercode='DiscountOnDiscount'";
				
				selectCMD.ExecuteNonQuery();
				
				//foodcodecost 菜例成本卡计算方法
				if (RadioButton3.Checked)
				{
					selectCMD.CommandText = "update syssetup set value='1' " + "where parametercode='foodcodecost'";
					
					selectCMD.ExecuteNonQuery();
				}
				else if (RadioButton4.Checked)
				{
					selectCMD.CommandText = "update syssetup set value='2' " + "where parametercode='foodcodecost'";
					
					selectCMD.ExecuteNonQuery();
				}
				else if (RadioButton5.Checked)
				{
					selectCMD.CommandText = "update syssetup set value='3' " + "where parametercode='foodcodecost'";
					
					selectCMD.ExecuteNonQuery();
				}
				
				//autoPrintFood 自动打印传菜单
				selectCMD.CommandText = "update syssetup set value='" + Math.Abs(System.Convert.ToInt32(CheckBox7.Checked)).ToString() + "' " + "where parametercode='autoPrintFood'";
				
				selectCMD.ExecuteNonQuery();
				
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
		
		private void frmSysSetup_Load(System.Object sender, System.EventArgs e)
		{
			LoadSysSetupInfo();
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			SaveSysSetupInfo();
			if (CheckBox6.Checked) //将数据包存在数据库里
			{
				
			}
			this.DialogResult = DialogResult.OK;
		}
		
		private void GroupBox2_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
