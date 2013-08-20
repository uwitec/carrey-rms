using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class frmNewAppointBill : System.Windows.Forms.Form
	{
		
		public DataTable SelectedTables;
		public DataTable SelectedFoods;
		
		public string EditTimeBlock = "";
		public string EditOpID = "";
		
		
		#region  Windows 窗体设计器生成的代码
		
		public frmNewAppointBill()
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.Button Button8;
		internal System.Windows.Forms.Button Button9;
		internal System.Windows.Forms.Button Button11;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.ComboBox ComboBox3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.DataGrid dgTableList;
		internal System.Windows.Forms.DataGrid DataGrid2;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGrid dgFoodList;
		internal System.Windows.Forms.DataGrid DataGrid4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn14;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn15;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn16;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn17;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn18;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn19;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn20;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmNewAppointBill));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmNewAppointBill_Load);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.Label9 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Label7 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.DataGrid2 = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgTableList = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Button7 = new System.Windows.Forms.Button();
			this.Button7.Click += new System.EventHandler(this.Button7_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.ComboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			this.DataGrid4 = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFoodList = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button8 = new System.Windows.Forms.Button();
			this.Button8.Click += new System.EventHandler(this.Button8_Click);
			this.Button9 = new System.Windows.Forms.Button();
			this.Button9.Click += new System.EventHandler(this.Button9_Click);
			this.Button11 = new System.Windows.Forms.Button();
			this.Button11.Click += new System.EventHandler(this.Button11_Click);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.GroupBox1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGrid2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgTableList).BeginInit();
			this.TabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGrid4).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgFoodList).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "订单编号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(88, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(112, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(224, 24);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "操作员：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(368, 336);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 3;
			this.Button2.Text = "下一步(&N)";
			//
			//Button3
			//
			this.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button3.Location = new System.Drawing.Point(448, 336);
			this.Button3.Name = "Button3";
			this.Button3.TabIndex = 4;
			this.Button3.Text = "取消(&C)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(552, 64);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "一般信息";
			//
			//ComboBox2
			//
			this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.Location = new System.Drawing.Point(296, 24);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(121, 20);
			this.ComboBox2.TabIndex = 1;
			//
			//TabControl1
			//
			this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.ItemSize = new System.Drawing.Size(70, 22);
			this.TabControl1.Location = new System.Drawing.Point(8, 80);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(552, 240);
			this.TabControl1.TabIndex = 1;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.NumericUpDown2);
			this.TabPage1.Controls.Add(this.TextBox4);
			this.TabPage1.Controls.Add(this.TextBox6);
			this.TabPage1.Controls.Add(this.TextBox3);
			this.TabPage1.Controls.Add(this.Label11);
			this.TabPage1.Controls.Add(this.TextBox5);
			this.TabPage1.Controls.Add(this.DateTimePicker2);
			this.TabPage1.Controls.Add(this.Label9);
			this.TabPage1.Controls.Add(this.ComboBox1);
			this.TabPage1.Controls.Add(this.Button1);
			this.TabPage1.Controls.Add(this.Label7);
			this.TabPage1.Controls.Add(this.Label13);
			this.TabPage1.Controls.Add(this.NumericUpDown1);
			this.TabPage1.Controls.Add(this.Label5);
			this.TabPage1.Controls.Add(this.Label12);
			this.TabPage1.Controls.Add(this.Label6);
			this.TabPage1.Controls.Add(this.Label10);
			this.TabPage1.Controls.Add(this.Label8);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Location = new System.Drawing.Point(4, 26);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(544, 210);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "预订信息";
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.Location = new System.Drawing.Point(144, 88);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new System.Drawing.Size(128, 21);
			this.NumericUpDown2.TabIndex = 4;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(144, 40);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(128, 21);
			this.TextBox4.TabIndex = 2;
			this.TextBox4.Text = "";
			//
			//TextBox6
			//
			this.TextBox6.Location = new System.Drawing.Point(144, 128);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(336, 21);
			this.TextBox6.TabIndex = 8;
			this.TextBox6.Text = "";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(144, 16);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(128, 21);
			this.TextBox3.TabIndex = 0;
			this.TextBox3.Text = "";
			//
			//Label11
			//
			this.Label11.Location = new System.Drawing.Point(56, 128);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(88, 23);
			this.Label11.TabIndex = 33;
			this.Label11.Text = "备注：";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(360, 40);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(120, 21);
			this.TextBox5.TabIndex = 5;
			this.TextBox5.Text = "";
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker2.Location = new System.Drawing.Point(144, 64);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(128, 21);
			this.DateTimePicker2.TabIndex = 3;
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(56, 88);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(88, 23);
			this.Label9.TabIndex = 31;
			this.Label9.Text = "估计人数：";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(360, 64);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(120, 20);
			this.ComboBox1.TabIndex = 6;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(280, 16);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(32, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "...";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(264, 40);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(96, 23);
			this.Label7.TabIndex = 29;
			this.Label7.Text = "联系电话：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label13
			//
			this.Label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label13.Location = new System.Drawing.Point(144, 168);
			this.Label13.Name = "Label13";
			this.Label13.TabIndex = 9;
			this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(360, 88);
			this.NumericUpDown1.Maximum = new decimal(new int[] {100000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.TabIndex = 7;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(48, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(96, 23);
			this.Label5.TabIndex = 27;
			this.Label5.Text = "客户名称：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label12
			//
			this.Label12.Location = new System.Drawing.Point(104, 168);
			this.Label12.Name = "Label12";
			this.Label12.TabIndex = 35;
			this.Label12.Text = "状态：";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(48, 40);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(96, 23);
			this.Label6.TabIndex = 28;
			this.Label6.Text = "预订人：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(312, 88);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(48, 23);
			this.Label10.TabIndex = 32;
			this.Label10.Text = "定金：";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(48, 64);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(96, 23);
			this.Label8.TabIndex = 30;
			this.Label8.Text = "预订就餐时间：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(304, 64);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(56, 23);
			this.Label3.TabIndex = 25;
			this.Label3.Text = "时间段：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.DataGrid2);
			this.TabPage2.Controls.Add(this.dgTableList);
			this.TabPage2.Controls.Add(this.Button6);
			this.TabPage2.Controls.Add(this.Button7);
			this.TabPage2.Controls.Add(this.Button4);
			this.TabPage2.Controls.Add(this.ComboBox3);
			this.TabPage2.Location = new System.Drawing.Point(4, 26);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new System.Drawing.Size(544, 210);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "预订台位";
			//
			//DataGrid2
			//
			this.DataGrid2.CaptionVisible = false;
			this.DataGrid2.DataMember = "";
			this.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGrid2.Location = new System.Drawing.Point(296, 32);
			this.DataGrid2.Name = "DataGrid2";
			this.DataGrid2.ReadOnly = true;
			this.DataGrid2.Size = new System.Drawing.Size(240, 168);
			this.DataGrid2.TabIndex = 5;
			this.DataGrid2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle2});
			//
			//DataGridTableStyle2
			//
			this.DataGridTableStyle2.DataGrid = this.DataGrid2;
			this.DataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn7});
			this.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle2.MappingName = "AppointTablesList";
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "位置/厅堂";
			this.DataGridTextBoxColumn3.MappingName = "location";
			this.DataGridTextBoxColumn3.Width = 60;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "桌台号";
			this.DataGridTextBoxColumn5.MappingName = "tableno";
			this.DataGridTextBoxColumn5.Width = 60;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "桌台名称";
			this.DataGridTextBoxColumn6.MappingName = "tablename";
			this.DataGridTextBoxColumn6.Width = 60;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "就餐人数";
			this.DataGridTextBoxColumn7.MappingName = "allowpsn";
			this.DataGridTextBoxColumn7.Width = 55;
			//
			//dgTableList
			//
			this.dgTableList.CaptionVisible = false;
			this.dgTableList.DataMember = "";
			this.dgTableList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgTableList.Location = new System.Drawing.Point(8, 32);
			this.dgTableList.Name = "dgTableList";
			this.dgTableList.ReadOnly = true;
			this.dgTableList.Size = new System.Drawing.Size(240, 168);
			this.dgTableList.TabIndex = 1;
			this.dgTableList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgTableList;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn4});
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "AllowAppointTablelist";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "桌台号";
			this.DataGridTextBoxColumn1.MappingName = "tableno";
			this.DataGridTextBoxColumn1.Width = 60;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "桌台名称";
			this.DataGridTextBoxColumn2.MappingName = "tablename";
			this.DataGridTextBoxColumn2.Width = 60;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "就餐人数";
			this.DataGridTextBoxColumn4.MappingName = "peoplenumber";
			this.DataGridTextBoxColumn4.Width = 55;
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(256, 136);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(32, 23);
			this.Button6.TabIndex = 4;
			this.Button6.Text = "<<";
			//
			//Button7
			//
			this.Button7.Location = new System.Drawing.Point(256, 104);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(32, 23);
			this.Button7.TabIndex = 3;
			this.Button7.Text = "<";
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(256, 40);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(32, 23);
			this.Button4.TabIndex = 2;
			this.Button4.Text = ">";
			//
			//ComboBox3
			//
			this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox3.ItemHeight = 12;
			this.ComboBox3.Location = new System.Drawing.Point(8, 8);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(200, 20);
			this.ComboBox3.TabIndex = 0;
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.TextBox2);
			this.TabPage3.Controls.Add(this.DataGrid4);
			this.TabPage3.Controls.Add(this.dgFoodList);
			this.TabPage3.Controls.Add(this.Button8);
			this.TabPage3.Controls.Add(this.Button9);
			this.TabPage3.Controls.Add(this.Button11);
			this.TabPage3.Location = new System.Drawing.Point(4, 26);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(544, 210);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "预订菜品";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(8, 8);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(200, 21);
			this.TextBox2.TabIndex = 0;
			this.TextBox2.Text = "";
			//
			//DataGrid4
			//
			this.DataGrid4.CaptionVisible = false;
			this.DataGrid4.DataMember = "";
			this.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGrid4.Location = new System.Drawing.Point(296, 32);
			this.DataGrid4.Name = "DataGrid4";
			this.DataGrid4.ReadOnly = true;
			this.DataGrid4.Size = new System.Drawing.Size(240, 168);
			this.DataGrid4.TabIndex = 5;
			this.DataGrid4.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle4});
			//
			//DataGridTableStyle4
			//
			this.DataGridTableStyle4.DataGrid = this.DataGrid4;
			this.DataGridTableStyle4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn14, this.DataGridTextBoxColumn15, this.DataGridTextBoxColumn16, this.DataGridTextBoxColumn17, this.DataGridTextBoxColumn18, this.DataGridTextBoxColumn19, this.DataGridTextBoxColumn20});
			this.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle4.MappingName = "AppointFoodsList";
			//
			//DataGridTextBoxColumn14
			//
			this.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn14.Format = "";
			this.DataGridTextBoxColumn14.FormatInfo = null;
			this.DataGridTextBoxColumn14.HeaderText = "菜品编码";
			this.DataGridTextBoxColumn14.MappingName = "foodcode";
			this.DataGridTextBoxColumn14.Width = 55;
			//
			//DataGridTextBoxColumn15
			//
			this.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn15.Format = "";
			this.DataGridTextBoxColumn15.FormatInfo = null;
			this.DataGridTextBoxColumn15.HeaderText = "菜品名称";
			this.DataGridTextBoxColumn15.MappingName = "foodname";
			this.DataGridTextBoxColumn15.Width = 75;
			//
			//DataGridTextBoxColumn16
			//
			this.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn16.Format = "";
			this.DataGridTextBoxColumn16.FormatInfo = null;
			this.DataGridTextBoxColumn16.HeaderText = "单位";
			this.DataGridTextBoxColumn16.MappingName = "unit";
			this.DataGridTextBoxColumn16.Width = 45;
			//
			//DataGridTextBoxColumn17
			//
			this.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn17.Format = "";
			this.DataGridTextBoxColumn17.FormatInfo = null;
			this.DataGridTextBoxColumn17.HeaderText = "数量";
			this.DataGridTextBoxColumn17.MappingName = "quantity";
			this.DataGridTextBoxColumn17.Width = 55;
			//
			//DataGridTextBoxColumn18
			//
			this.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn18.Format = "";
			this.DataGridTextBoxColumn18.FormatInfo = null;
			this.DataGridTextBoxColumn18.HeaderText = "单价";
			this.DataGridTextBoxColumn18.MappingName = "price";
			this.DataGridTextBoxColumn18.Width = 50;
			//
			//DataGridTextBoxColumn19
			//
			this.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn19.Format = "";
			this.DataGridTextBoxColumn19.FormatInfo = null;
			this.DataGridTextBoxColumn19.HeaderText = "做法";
			this.DataGridTextBoxColumn19.MappingName = "oprandi";
			this.DataGridTextBoxColumn19.NullText = "";
			this.DataGridTextBoxColumn19.Width = 75;
			//
			//DataGridTextBoxColumn20
			//
			this.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn20.Format = "";
			this.DataGridTextBoxColumn20.FormatInfo = null;
			this.DataGridTextBoxColumn20.HeaderText = "口味";
			this.DataGridTextBoxColumn20.MappingName = "taste";
			this.DataGridTextBoxColumn20.NullText = "";
			this.DataGridTextBoxColumn20.Width = 75;
			//
			//dgFoodList
			//
			this.dgFoodList.CaptionVisible = false;
			this.dgFoodList.DataMember = "";
			this.dgFoodList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFoodList.Location = new System.Drawing.Point(8, 32);
			this.dgFoodList.Name = "dgFoodList";
			this.dgFoodList.ReadOnly = true;
			this.dgFoodList.Size = new System.Drawing.Size(240, 168);
			this.dgFoodList.TabIndex = 1;
			this.dgFoodList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle3});
			//
			//DataGridTableStyle3
			//
			this.DataGridTableStyle3.DataGrid = this.dgFoodList;
			this.DataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn8, this.DataGridTextBoxColumn9, this.DataGridTextBoxColumn10, this.DataGridTextBoxColumn11, this.DataGridTextBoxColumn12, this.DataGridTextBoxColumn13});
			this.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle3.MappingName = "FoodList";
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "菜品编码";
			this.DataGridTextBoxColumn8.MappingName = "foodcode";
			this.DataGridTextBoxColumn8.Width = 55;
			//
			//DataGridTextBoxColumn9
			//
			this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn9.Format = "";
			this.DataGridTextBoxColumn9.FormatInfo = null;
			this.DataGridTextBoxColumn9.HeaderText = "菜品名称";
			this.DataGridTextBoxColumn9.MappingName = "foodname";
			this.DataGridTextBoxColumn9.Width = 75;
			//
			//DataGridTextBoxColumn10
			//
			this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn10.Format = "";
			this.DataGridTextBoxColumn10.FormatInfo = null;
			this.DataGridTextBoxColumn10.HeaderText = "单位";
			this.DataGridTextBoxColumn10.MappingName = "unit";
			this.DataGridTextBoxColumn10.Width = 45;
			//
			//DataGridTextBoxColumn11
			//
			this.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn11.Format = "";
			this.DataGridTextBoxColumn11.FormatInfo = null;
			this.DataGridTextBoxColumn11.HeaderText = "所属部门";
			this.DataGridTextBoxColumn11.MappingName = "deptname";
			this.DataGridTextBoxColumn11.Width = 65;
			//
			//DataGridTextBoxColumn12
			//
			this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn12.Format = "";
			this.DataGridTextBoxColumn12.FormatInfo = null;
			this.DataGridTextBoxColumn12.HeaderText = "菜品类别";
			this.DataGridTextBoxColumn12.MappingName = "typename";
			this.DataGridTextBoxColumn12.Width = 65;
			//
			//DataGridTextBoxColumn13
			//
			this.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn13.Format = "";
			this.DataGridTextBoxColumn13.FormatInfo = null;
			this.DataGridTextBoxColumn13.HeaderText = "单价";
			this.DataGridTextBoxColumn13.MappingName = "price";
			this.DataGridTextBoxColumn13.Width = 50;
			//
			//Button8
			//
			this.Button8.Location = new System.Drawing.Point(256, 136);
			this.Button8.Name = "Button8";
			this.Button8.Size = new System.Drawing.Size(32, 23);
			this.Button8.TabIndex = 4;
			this.Button8.Text = "<<";
			//
			//Button9
			//
			this.Button9.Location = new System.Drawing.Point(256, 104);
			this.Button9.Name = "Button9";
			this.Button9.Size = new System.Drawing.Size(32, 23);
			this.Button9.TabIndex = 3;
			this.Button9.Text = "<";
			//
			//Button11
			//
			this.Button11.Location = new System.Drawing.Point(256, 40);
			this.Button11.Name = "Button11";
			this.Button11.Size = new System.Drawing.Size(32, 23);
			this.Button11.TabIndex = 2;
			this.Button11.Text = ">";
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Location = new System.Drawing.Point(8, 328);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(552, 4);
			this.Panel1.TabIndex = 2;
			//
			//frmNewAppointBill
			//
			this.AcceptButton = this.Button2;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button3;
			this.ClientSize = new System.Drawing.Size(570, 376);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewAppointBill";
			this.ShowInTaskbar = false;
			this.Text = "预订订单";
			this.GroupBox1.ResumeLayout(false);
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGrid2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgTableList).EndInit();
			this.TabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGrid4).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgFoodList).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//创建临时存储的已选择的桌台
		public void CreateSelectedTables()
		{
			SelectedTables = new DataTable("AppointTablesList");
			DataColumn[] keys = new DataColumn[1];
			
			DataColumn Column3 = new DataColumn();
			Column3.DataType = System.Type.GetType("System.String");
			Column3.AllowDBNull = true;
			Column3.ReadOnly = true;
			Column3.ColumnName = "Location";
			SelectedTables.Columns.Add(Column3);
			
			DataColumn Column4 = new DataColumn();
			Column4.DataType = System.Type.GetType("System.String");
			Column4.AllowDBNull = true;
			Column4.ReadOnly = true;
			Column4.ColumnName = "Tableno";
			SelectedTables.Columns.Add(Column4);
			keys[0] = Column4;
			
			DataColumn Column5 = new DataColumn();
			Column5.DataType = System.Type.GetType("System.String");
			Column5.AllowDBNull = true;
			Column5.ReadOnly = true;
			Column5.ColumnName = "TableName";
			SelectedTables.Columns.Add(Column5);
			
			DataColumn Column6 = new DataColumn();
			Column6.DataType = System.Type.GetType("System.String");
			Column6.AllowDBNull = true;
			Column6.ReadOnly = true;
			Column6.ColumnName = "AllowPsn";
			SelectedTables.Columns.Add(Column6);
			SelectedTables.PrimaryKey = keys;
			
		}
		
		//添加临时桌台记录
		public void AddTable(string location, string tableno, string tablename, string AllowPsn)
		{
			DataRow myRow;
			myRow = SelectedTables.NewRow();
			myRow["location"] = location;
			myRow["tableno"] = tableno;
			myRow["tablename"] = tablename;
			myRow["AllowPsn"] = AllowPsn;
			SelectedTables.Rows.Add(myRow);
		}
		
		//创建临时存储的已选择的菜品
		public void CreateSelectedFoods()
		{
			SelectedFoods = new DataTable("AppointFoodsList");
			DataColumn[] keys = new DataColumn[1];
			
			DataColumn Column3 = new DataColumn();
			Column3.DataType = System.Type.GetType("System.String");
			Column3.AllowDBNull = true;
			Column3.ReadOnly = true;
			Column3.ColumnName = "foodcode";
			SelectedFoods.Columns.Add(Column3);
			keys[0] = Column3;
			
			DataColumn Column4 = new DataColumn();
			Column4.DataType = System.Type.GetType("System.String");
			Column4.AllowDBNull = true;
			Column4.ReadOnly = true;
			Column4.ColumnName = "foodname";
			SelectedFoods.Columns.Add(Column4);
			
			DataColumn Column5 = new DataColumn();
			Column5.DataType = System.Type.GetType("System.String");
			Column5.AllowDBNull = true;
			Column5.ReadOnly = true;
			Column5.ColumnName = "unit";
			SelectedFoods.Columns.Add(Column5);
			
			DataColumn Column6 = new DataColumn();
			Column6.DataType = System.Type.GetType("System.String");
			Column6.AllowDBNull = true;
			Column6.ReadOnly = true;
			Column6.ColumnName = "quantity";
			SelectedFoods.Columns.Add(Column6);
			
			DataColumn Column7 = new DataColumn();
			Column7.DataType = System.Type.GetType("System.String");
			Column7.AllowDBNull = true;
			Column7.ReadOnly = true;
			Column7.ColumnName = "price";
			SelectedFoods.Columns.Add(Column7);
			
			DataColumn Column8 = new DataColumn();
			Column8.DataType = System.Type.GetType("System.String");
			Column8.AllowDBNull = true;
			Column8.ReadOnly = true;
			Column8.ColumnName = "oprandi";
			SelectedFoods.Columns.Add(Column8);
			
			DataColumn Column9 = new DataColumn();
			Column9.DataType = System.Type.GetType("System.String");
			Column9.AllowDBNull = true;
			Column9.ReadOnly = true;
			Column9.ColumnName = "taste";
			SelectedFoods.Columns.Add(Column9);
			
			SelectedFoods.PrimaryKey = keys;
		}
		
		//添加临时菜品记录
		public void AddFood(string foodcode, string foodname, string unit, string quantity, string price, string oprandi, string taste)
		{
			DataRow myRow;
			myRow = SelectedFoods.NewRow();
			myRow["foodcode"] = foodcode;
			myRow["foodname"] = foodname;
			myRow["unit"] = unit;
			myRow["quantity"] = quantity;
			myRow["price"] = price;
			myRow["oprandi"] = oprandi;
			myRow["taste"] = taste;
			SelectedFoods.Rows.Add(myRow);
		}
		
		//返回相应桌台类别/位置的桌台列表，并填充桌台列表
		private void GetTableList(string appointdate, string timeblockcode, string tabletypename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				//根据预定时间和时间段更新桌台列表
				selectCMD.CommandText = "select tableno,tablename,peoplenumber from tablestatus where status='0' order by tableno";
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "tablelist");
				selectCMD.CommandText = "delete from appointtable_tmp";
				selectCMD.ExecuteNonQuery();
				selectCMD.CommandText = "insert into appointtable_tmp (tableno,tablename,tabletypecode,peoplenumber ) select tableno,tablename,tabletypecode,peoplenumber from tablestatus";
				selectCMD.ExecuteNonQuery();
				
				selectCMD.CommandText = "select tableno,arrivedate,timeblockcode from view_AppointTable where arrivedate='" + appointdate + "' and timeblockcode='" + timeblockcode + "'";
				dbDA.Fill(dbDS, "appointtablelist");
				
				for (int i = 0; i <= dbDS.Tables["appointtablelist"].Rows.Count - 1; i++)
				{
					selectCMD.CommandText = "delete from appointtable_tmp where tableno='" + dbDS.Tables["appointtablelist"].Rows[i][0].ToString() + "'";
					selectCMD.ExecuteNonQuery();
				}
				
				selectCMD.CommandText = "SELECT tableno,tablename,peoplenumber FROM AppointTable_tmp";
				if (tabletypename != "全部")
				{
					selectCMD.CommandText = selectCMD.CommandText + " where TabletypeCode='" + rms_var.GetTableTypeCode(tabletypename) + "'";
				}
				dbDA.Fill(dbDS, "AllowAppointTablelist");
				
				dgTableList.DataSource = null;
				dgTableList.DataSource = dbDS;
				dgTableList.DataMember = "AllowAppointTablelist";
				
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
		
		private void frmNewAppointBill_Load(System.Object sender, System.EventArgs e)
		{
			//返回时间段列表
			DataTable tblTimeBlock = new DataTable();
			tblTimeBlock = rms_var.LoadTimeBlock();
			ComboBox1.Items.Clear();
			for (int i = 0; i <= tblTimeBlock.Rows.Count - 1; i++)
			{
				ComboBox1.Items.Add(tblTimeBlock.Rows[i][0]);
			}
			ComboBox1.SelectedIndex = 0;
			
			//返回操作员列表
			DataTable tblOperator = new DataTable();
			tblOperator = rms_var.LoadOperator();
			ComboBox2.Items.Clear();
			for (int i = 0; i <= tblOperator.Rows.Count - 1; i++)
			{
				ComboBox2.Items.Add(tblOperator.Rows[i][0]);
			}
			ComboBox2.SelectedIndex = 0;
			
			DataTable ftabletype;
			ftabletype = rms_var.LoadTableType();
			//桌台位置获取完毕填充下拉列表框
			for (int i = 0; i <= ftabletype.Rows.Count - 1; i++)
			{
				this.ComboBox3.Items.Add(ftabletype.Rows[i]["name"]);
			}
			ComboBox3.SelectedIndex = 0;
			
			GetFoodList("", 1);
			
			DataGrid2.DataSource = SelectedTables;
			DataGrid4.DataSource = SelectedFoods;
			
			if (EditTimeBlock != "")
			{
				ComboBox1.Text = EditTimeBlock;
			}
			
			if (EditOpID != "")
			{
				ComboBox2.Text = EditOpID;
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			SqlCommand selectCMD = new SqlCommand();
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			SqlDataAdapter dbDA = new SqlDataAdapter();
			DataSet dbDS = new DataSet();
			conn.ConnectionString = rms_var.ConnStr;
			conn.Open();
			selectCMD.Connection = conn;
			
			if (TextBox1.Enabled) //新建订单
			{
				//检测订单编号是否合法
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("编号不能为空");
					TabControl1.SelectedIndex = 0;
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				try
				{
					selectCMD.CommandText = "SELECT count(*) FROM appointbill where appointno='" + TextBox1.Text + "'";
					selectCMD.CommandTimeout = 30;
					dbDA.SelectCommand = selectCMD;
					
					dbDA.Fill(dbDS, "t");
					if (int.Parse(dbDS.Tables[0].Rows[0][0].ToString())!= 0) //编号 not 合法
					{
						MessageBox.Show("编号重复");
						TabControl1.SelectedIndex = 0;
						TextBox1.Focus();
						TextBox1.SelectAll();
						return;
					}
					else
					{
						if (TextBox3.Text == "")
						{
							MessageBox.Show("客户名称不能为空");
							TabControl1.SelectedIndex = 0;
							TextBox3.Focus();
							TextBox3.SelectAll();
							return;
						}
						if (NumericUpDown2.Value <= 0)
						{
							MessageBox.Show("订餐人数不能为 0");
							TabControl1.SelectedIndex = 0;
							NumericUpDown2.Focus();
							NumericUpDown2.Select(0, NumericUpDown2.Text.Length);
							return;
						}
						if (NumericUpDown1.Value <= 0)
						{
							if (! (MessageBox.Show("定金为 0，确定继续创建预订订单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
							{
								return;
							}
						}
						//创建当前预订订单
						selectCMD.CommandText = "insert into appointbill (AppointNo,orderdate,ArriveDate,Operator,CustomerName,OrderMan,OrderManTel,est_Quantity,TimeBlockCode,OrderMoney) values ('" + TextBox1.Text + "','" + DateTime.Now.Date.ToShortDateString() + "','" + DateTimePicker2.Value.ToShortDateString() + "','" + ComboBox2.Text + "','" + TextBox3.Text + "'" + ",'" + TextBox4.Text + "','" + TextBox5.Text + "'," + NumericUpDown2.Text + ",'" + rms_var.GetTimeBlockCode(ComboBox1.Text) + "'," + NumericUpDown1.Text + ")";
						selectCMD.ExecuteNonQuery();
						MessageBox.Show("单据创建成功");
						TextBox1.Enabled = false;
						ComboBox2.Enabled = false;
						GetTableList(DateTimePicker2.Value.ToShortDateString(), rms_var.GetTimeBlockCode(ComboBox1.Text), ComboBox3.Text);
						TabControl1.SelectedIndex = 1;
					}
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					
				}
			}
			else //已创建订单
			{
				if (TabControl1.SelectedIndex == 0)
				{
					//更新一般信息
					selectCMD.CommandText = "update appointbill set " + "arrivedate='" + DateTimePicker2.Value.ToShortDateString() + "',CustomerName='" + TextBox3.Text + "',OrderMan='" + TextBox4.Text + "'" + "," + "OrderManTel='" + TextBox5.Text + "',est_Quantity=" + NumericUpDown2.Text + ",TimeBlockCode='" + rms_var.GetTimeBlockCode(ComboBox1.Text) + "',OrderMoney=" + NumericUpDown1.Text + " where appointno='" + TextBox1.Text + "'";
					selectCMD.ExecuteNonQuery();
					TabControl1.SelectedIndex = 1;
				}
				else if (TabControl1.SelectedIndex == 1)
				{
					if (DataGrid2.VisibleRowCount > 0)
					{
						//将所预订的桌台添加进数据库
						try
						{
							selectCMD.CommandText = "delete from AppointTable where appointno='" + TextBox1.Text + "'";
							selectCMD.ExecuteNonQuery();
							for (int i = 0; i <= DataGrid2.VisibleRowCount - 1; i++)
							{
								selectCMD.CommandText = "insert into AppointTable (appointno,tableno) values ('" + TextBox1.Text + "','" + DataGrid2[i, 1].ToString() + "')";
								selectCMD.ExecuteNonQuery();
							}
							
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
						finally
						{
							
						}
					}
					TabControl1.SelectedIndex = 2;
				}
				else if (TabControl1.SelectedIndex == 2)
				{
					if (DataGrid4.VisibleRowCount > 0)
					{
						//将所预订的菜品添加进数据库
						try
						{
							selectCMD.CommandText = "delete from Appointfood where appointno='" + TextBox1.Text + "'";
							selectCMD.ExecuteNonQuery();
							for (int i = 0; i <= DataGrid4.VisibleRowCount - 1; i++)
							{
								selectCMD.CommandText = "insert into Appointfood (appointno,foodcode,quantity,price,oprandi,taste) values ('" + TextBox1.Text + "','" + DataGrid4[i, 0].ToString() + "'," + DataGrid4[i, 3].ToString() + "," + DataGrid4[i, 4].ToString() + ",'" + DataGrid4[i, 5].ToString() + "','" + DataGrid4[i, 6].ToString() + "')";
								selectCMD.ExecuteNonQuery();
							}
							MessageBox.Show("完成预定");
							this.DialogResult = DialogResult.OK;
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
						finally
						{
							
						}
					}
					else
					{
						MessageBox.Show("完成预定");
						this.DialogResult = DialogResult.OK;
					}
				}
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			frmCustomer frmcust = new frmCustomer();
			frmcust.ToolBar1.Visible = false;
			frmcust.dgCust.Dock = DockStyle.Fill;
			frmcust.Text = "客户信息";
			frmcust.MinimizeBox = false;
			
			frmcust.ShowDialog();
			if (frmcust.DialogResult == DialogResult.OK)
			{
				if (System.Convert.ToInt32(frmcust.dgCust[frmcust.dgCust.CurrentRowIndex, 14]) == 0)
				{
					TextBox3.Text = frmcust.dgCust[frmcust.dgCust.CurrentRowIndex, 1].ToString();
                    TextBox4.Text = frmcust.dgCust[frmcust.dgCust.CurrentRowIndex, 1].ToString();
					TextBox5.Text = frmcust.dgCust[frmcust.dgCust.CurrentRowIndex, 4].ToString();
				}
				else
				{
					TextBox3.Text = "";
					TextBox4.Text = "";
					TextBox5.Text = "";
				}
			}
		}
		
		private void ComboBox3_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (! TextBox1.Enabled)
			{
				GetTableList(DateTimePicker2.Value.ToShortDateString(), rms_var.GetTimeBlockCode(ComboBox1.Text), ComboBox3.Text);
			}
		}
		
		//返回相应菜品类别的菜品列表
		//OrderFood表示是菜品库还是该桌台已点菜品列表 1=原始菜品库 0=已点菜品列表
		private void GetFoodList(string filter, int FilterMode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM view_FoodList";
				if (filter != "")
				{
					switch (FilterMode)
					{
						case 0: //菜品编码
							selectCMD.CommandText = selectCMD.CommandText + " where foodCode like '" + filter + "%'";
							break;
						case 1: //菜品拼音码
							selectCMD.CommandText = selectCMD.CommandText + " where spell like '" + filter + "%'";
							break;
						case 2: //菜品类别编码
							selectCMD.CommandText = selectCMD.CommandText + " where foodtypeCode like '" + filter + "%'";
							break;
					}
				}
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "FoodList");
				dgFoodList.DataSource = null;
				dgFoodList.DataSource = dbDS;
				dgFoodList.DataMember = "FoodList";
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
		
		private void TextBox2_TextChanged(System.Object sender, System.EventArgs e)
		{
			GetFoodList(TextBox2.Text, 0);
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			DataRowCollection myDataRowCollection;
			//DataRow foundRow;
			
			myDataRowCollection = SelectedTables.Rows;
			if (myDataRowCollection.Contains(dgTableList[dgTableList.CurrentRowIndex, 0]))
			{
				MessageBox.Show("have row");
			}
			else
			{
				AddTable(ComboBox3.Text,dgTableList[dgTableList.CurrentRowIndex, 0].ToString(),dgTableList[dgTableList.CurrentRowIndex, 1].ToString(),dgTableList[dgTableList.CurrentRowIndex, 2].ToString());
			}
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			SelectedTables.Rows.Clear();
		}
		
		private void Button7_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGrid2.VisibleRowCount > 0)
			{
				DataRow foundRow;
				foundRow = SelectedTables.Rows.Find(DataGrid2[DataGrid2.CurrentRowIndex, 1]);
				SelectedTables.Rows.Remove(foundRow);
			}
		}
		
		private void Button11_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGrid2.VisibleRowCount > 0)
			{
				DataRowCollection myDataRowCollection;
				//DataRow foundRow;
				
				myDataRowCollection = SelectedFoods.Rows;
				if (myDataRowCollection.Contains(dgFoodList[dgFoodList.CurrentRowIndex, 0]))
				{
					MessageBox.Show("have row");
				}
				else
				{
					AddFood frmaddfood = new AddFood();
					frmaddfood.Label1.Text = dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString();
                    frmaddfood.Label5.Text = dgFoodList[dgFoodList.CurrentRowIndex, 2].ToString();
					frmaddfood.Label7.Text = rms_var.GetFoodPrice(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(), false);
					frmaddfood.ShowDialog();
					
					AddFood(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(),dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString(),dgFoodList[dgFoodList.CurrentRowIndex, 2].ToString(), frmaddfood.FoodQuantity.ToString(),dgFoodList[dgFoodList.CurrentRowIndex, 5].ToString(), frmaddfood.FoodOperandi, frmaddfood.FoodTaste);
				}
			}
			else
			{
				MessageBox.Show("没有预订桌台，请先预订桌台");
				TabControl1.SelectedIndex = 1;
			}
			
		}
		
		private void Button8_Click(System.Object sender, System.EventArgs e)
		{
			SelectedFoods.Rows.Clear();
		}
		
		private void Button9_Click(System.Object sender, System.EventArgs e)
		{
			if (DataGrid4.VisibleRowCount > 0)
			{
				DataRow foundRow;
				foundRow = SelectedFoods.Rows.Find(DataGrid4[DataGrid4.CurrentRowIndex, 0]);
				SelectedFoods.Rows.Remove(foundRow);
			}
		}
		
		private void TabControl1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Enabled)
			{
				if (TabControl1.SelectedIndex == 1 || TabControl1.SelectedIndex == 2)
				{
					TabControl1.SelectedIndex = 0;
					MessageBox.Show("单据没有保存");
				}
			}
		}
	}
	
}
