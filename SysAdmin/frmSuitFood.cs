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
	public class frmSuitFood : System.Windows.Forms.Form
	{
		
		private string oldcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSuitFood()
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

        private System.ComponentModel.IContainer components;

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.DataGrid dgSuitFood;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuitFood));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgSuitFood = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuitFood)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton5,
            this.ToolBarButton6,
            this.ToolBarButton7});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(505, 54);
            this.ToolBar1.TabIndex = 0;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "添加";
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.ImageIndex = 1;
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Text = "修改";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 2;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "删除";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.ImageIndex = 3;
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Text = "菜品";
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 4;
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Text = "关闭";
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
            // 
            // dgSuitFood
            // 
            this.dgSuitFood.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgSuitFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSuitFood.BackColor = System.Drawing.Color.GhostWhite;
            this.dgSuitFood.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgSuitFood.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgSuitFood.CaptionForeColor = System.Drawing.Color.White;
            this.dgSuitFood.DataMember = "";
            this.dgSuitFood.FlatMode = true;
            this.dgSuitFood.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgSuitFood.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgSuitFood.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgSuitFood.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgSuitFood.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgSuitFood.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgSuitFood.LinkColor = System.Drawing.Color.Teal;
            this.dgSuitFood.Location = new System.Drawing.Point(0, 56);
            this.dgSuitFood.Name = "dgSuitFood";
            this.dgSuitFood.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgSuitFood.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgSuitFood.ReadOnly = true;
            this.dgSuitFood.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgSuitFood.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgSuitFood.Size = new System.Drawing.Size(505, 188);
            this.dgSuitFood.TabIndex = 1;
            this.dgSuitFood.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgSuitFood.DoubleClick += new System.EventHandler(this.dgSuitFood_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgSuitFood;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4,
            this.DataGridTextBoxColumn5,
            this.DataGridBoolColumn1});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "suit";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "套餐编码";
            this.DataGridTextBoxColumn1.MappingName = "suitcode";
            this.DataGridTextBoxColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "套餐名称";
            this.DataGridTextBoxColumn2.MappingName = "suitname";
            this.DataGridTextBoxColumn2.Width = 75;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "就餐人数";
            this.DataGridTextBoxColumn3.MappingName = "mannum";
            this.DataGridTextBoxColumn3.Width = 75;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "每人标准";
            this.DataGridTextBoxColumn4.MappingName = "eachstandard";
            this.DataGridTextBoxColumn4.Width = 75;
            // 
            // DataGridTextBoxColumn5
            // 
            this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn5.Format = "";
            this.DataGridTextBoxColumn5.FormatInfo = null;
            this.DataGridTextBoxColumn5.HeaderText = "合计";
            this.DataGridTextBoxColumn5.MappingName = "standardsum";
            this.DataGridTextBoxColumn5.Width = 75;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "暂停使用";
            this.DataGridBoolColumn1.MappingName = "disabled";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 75;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.NumericUpDown3);
            this.Panel1.Controls.Add(this.NumericUpDown2);
            this.Panel1.Controls.Add(this.NumericUpDown1);
            this.Panel1.Controls.Add(this.CheckBox1);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TextBox2);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(0, 247);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(505, 161);
            this.Panel1.TabIndex = 2;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(428, 82);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(28, 23);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "元";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(428, 55);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(28, 23);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "元";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(428, 30);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(28, 23);
            this.Label7.TabIndex = 14;
            this.Label7.Text = "人";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericUpDown3
            // 
            this.NumericUpDown3.Location = new System.Drawing.Point(339, 83);
            this.NumericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown3.Name = "NumericUpDown3";
            this.NumericUpDown3.Size = new System.Drawing.Size(87, 21);
            this.NumericUpDown3.TabIndex = 4;
            this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown3.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
            this.NumericUpDown3.Leave += new System.EventHandler(this.NumericUpDown3_Leave);
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(339, 56);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(87, 21);
            this.NumericUpDown2.TabIndex = 3;
            this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            this.NumericUpDown2.Leave += new System.EventHandler(this.NumericUpDown2_Leave);
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(339, 30);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(87, 21);
            this.NumericUpDown1.TabIndex = 1;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            this.NumericUpDown1.Leave += new System.EventHandler(this.NumericUpDown1_Leave);
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(150, 83);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(96, 24);
            this.CheckBox1.TabIndex = 5;
            this.CheckBox1.Text = "暂停该套餐";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(270, 82);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(69, 23);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "套餐标准：";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(270, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 23);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "每人标准：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(270, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 23);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "适宜人数：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(135, 56);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(125, 21);
            this.TextBox2.TabIndex = 2;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(135, 30);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(125, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(69, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 23);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "套餐编码：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(69, 55);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 23);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "套餐名称：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Teal;
            this.Label3.Location = new System.Drawing.Point(7, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Label3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(404, 120);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 23);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "隐藏(&H)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(340, 120);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(58, 23);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "保存(&S)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmSuitFood
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(505, 408);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgSuitFood);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuitFood";
            this.Text = "套餐";
            this.Load += new System.EventHandler(this.frmSuitFood_Load);
            this.Closed += new System.EventHandler(this.frmSuitFood_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgSuitFood)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回套餐列表
		private void LoadSuitsList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM suit", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "Suit");
				dgSuitFood.DataSource = null;
				dgSuitFood.DataSource = dbDS;
				dgSuitFood.DataMember = "Suit";
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
		
		//添加 套餐
		private bool AddData(string suitcode, string suitname, string mannum, string eachstandard, string standardsum, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select suitcode from suit where suitcode='" + suitcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
				{
					MessageBox.Show("编码重复！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into suit (suitcode,suitname,mannum,eachstandard,standardsum,disabled) " + "values (" + "'" + suitcode + "'" + "," + "'" + suitname + "'" + "," + mannum + "," + eachstandard + "," + standardsum + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + ")";
					
					selectCMD.ExecuteNonQuery();
					
					return true;
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
			return false;
		}
		
		//修改 套餐
		private bool EditData(string oldsuitcode, string newsuitcode, string suitname, string mannum, string eachstandard, string standardsum, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldsuitcode == newsuitcode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update suit set " + "suitname='" + suitname + "'" + "," + "mannum=" + mannum + "," + "eachstandard=" + eachstandard + "," + "standardsum=" + standardsum + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where suitcode='" + oldsuitcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select suitcode from suit where suitcode='" + newsuitcode + "'";
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					
					if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
					{
						MessageBox.Show("编码重复！");
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update suit set " + "suitcode='" + newsuitcode + "'" + "," + "suitname='" + suitname + "'" + "," + "mannum=" + mannum + "," + "eachstandard=" + eachstandard + "," + "standardsum=" + standardsum + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where suitcode='" + oldsuitcode + "'";
						selectCMD.ExecuteNonQuery();
						
						return true;
					}
					
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
			return false;
		}
		
		//删除 套餐
		private bool DelSuit(string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from suit where suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				selectCMD.CommandText = "delete from suitfoods where suitcode='" + suitcode + "'";
				selectCMD.ExecuteNonQuery();
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
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
			Panel1.Visible = false;
		}
		
		private void frmSuitFood_Load(System.Object sender, System.EventArgs e)
		{
			LoadSuitsList();
		}
		
		private void frmSuitFood_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmsuit = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					Button2_Click(sender, e);
					if (! Panel1.Visible)
					{
						Label3.Text = "添加记录";
						TextBox1.Text = "";
						TextBox2.Text = "";
						NumericUpDown1.Value = 0;
						NumericUpDown2.Value = 0;
						NumericUpDown3.Value = 0;
						CheckBox1.Checked = false;
						dgSuitFood.Height = dgSuitFood.Height - Panel1.Height - 5;
						Panel1.Visible = true;
						this.AcceptButton = Button1;
						this.CancelButton = Button2;
						TextBox1.Focus();
					}
					break;
					
				case 1: //修改数据
					if (! (dgSuitFood.CurrentRowIndex < 0))
					{
						Button2_Click(sender, e);
						if (! Panel1.Visible)
						{
							Label3.Text = "修改记录";
							TextBox1.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 0].ToString();
							oldcode = TextBox1.Text;
							TextBox2.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 1].ToString();
							NumericUpDown1.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 2].ToString();
							NumericUpDown2.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 3].ToString();
                            NumericUpDown3.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 4].ToString();
                            CheckBox1.Checked = dgSuitFood[dgSuitFood.CurrentRowIndex, 5].ToString() == "1" ? true : false;
							dgSuitFood.Height = dgSuitFood.Height - Panel1.Height - 5;
							Panel1.Visible = true;
							this.AcceptButton = Button1;
							this.CancelButton = Button2;
							
							TextBox1.Focus();
						}
					}
					break;
				case 2: //删除当前数据
					if (! (dgSuitFood.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgSuitFood[dgSuitFood.CurrentRowIndex, 0].ToString().Trim() + " 的套餐吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelSuit(dgSuitFood[dgSuitFood.CurrentRowIndex, 0].ToString()))
							{
								LoadSuitsList();
							}
						}
					}
					break;
				case 4:
					if (! (dgSuitFood.CurrentRowIndex < 0))
					{
						frmAddSuitFood frmaddsf = new frmAddSuitFood();
						frmaddsf.Label1.Text = "套餐名称：" + dgSuitFood[dgSuitFood.CurrentRowIndex, 1] + "    " + "套餐金额：" + dgSuitFood[dgSuitFood.CurrentRowIndex, 4].ToString();
                        frmaddsf.suitcode = dgSuitFood[dgSuitFood.CurrentRowIndex, 0].ToString();
						frmaddsf.suitprice = System.Convert.ToDouble(dgSuitFood[dgSuitFood.CurrentRowIndex, 4]);
						frmaddsf.ShowDialog();
					}
					break;
				case 6:
					this.Close();
					break;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("套餐编码不能为空！");
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("套餐名称不能为空！");
				return;
			}
			if (NumericUpDown3.Value <= 0)
			{
				if (MessageBox.Show("套餐金额 等于或小于 0 ！确认当前套餐金额吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (Label3.Text == "添加记录")
					{
						if (AddData(TextBox1.Text, TextBox2.Text, NumericUpDown1.Text, NumericUpDown2.Text, NumericUpDown3.Text, CheckBox1.Checked))
						{
							MessageBox.Show("添加记录成功！");
							dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
							Panel1.Visible = false;
							LoadSuitsList();
							TextBox1.Text = "";
							TextBox2.Text = "";
							NumericUpDown1.Value = 0;
							NumericUpDown2.Value = 0;
							NumericUpDown3.Value = 0;
							CheckBox1.Checked = false;
							
							if (MessageBox.Show("继续添加新的套餐吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
							{
								TextBox1.Focus();
								TextBox1.SelectAll();
							}
							else
							{
								dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
								Panel1.Visible = false;
							}
						}
					}
					else
					{
						if (MessageBox.Show("确定要修改当前套餐吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							if (EditData(oldcode, TextBox1.Text, TextBox2.Text, NumericUpDown1.Text, NumericUpDown2.Text, NumericUpDown3.Text, CheckBox1.Checked))
							{
								MessageBox.Show("修改记录成功！");
								dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
								Panel1.Visible = false;
								LoadSuitsList();
								TextBox1.Text = "";
								TextBox2.Text = "";
								NumericUpDown1.Value = 0;
								NumericUpDown2.Value = 0;
								NumericUpDown3.Value = 0;
								CheckBox1.Checked = false;
							}
						}
						
					}
				}
			}
			else
			{
				if (Label3.Text == "添加记录")
				{
					if (AddData(TextBox1.Text, TextBox2.Text, NumericUpDown1.Text, NumericUpDown2.Text, NumericUpDown3.Text, CheckBox1.Checked))
					{
						MessageBox.Show("添加记录成功！");
						dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
						Panel1.Visible = false;
						LoadSuitsList();
						this.DialogResult = DialogResult.OK;
					}
				}
				else
				{
					if (EditData(oldcode, TextBox1.Text, TextBox2.Text, NumericUpDown1.Text, NumericUpDown2.Text, NumericUpDown3.Text, CheckBox1.Checked))
					{
						MessageBox.Show("修改记录成功！");
						dgSuitFood.Height = rms_var.frmsuit.Height - rms_var.frmsuit.ToolBar1.Height - 35;
						Panel1.Visible = false;
						LoadSuitsList();
						this.DialogResult = DialogResult.OK;
					}
				}
			}
		}
		
		private void dgSuitFood_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgSuitFood.CurrentRowIndex < 0))
			{
				Button2_Click(sender, e);
				if (! Panel1.Visible)
				{
					Label3.Text = "修改记录";
					TextBox1.Text =dgSuitFood[dgSuitFood.CurrentRowIndex, 0].ToString();
					oldcode = TextBox1.Text;
                    TextBox2.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 1].ToString();
					NumericUpDown1.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 2].ToString();
					NumericUpDown2.Text =dgSuitFood[dgSuitFood.CurrentRowIndex, 3].ToString();
                    NumericUpDown3.Text = dgSuitFood[dgSuitFood.CurrentRowIndex, 4].ToString();
					CheckBox1.Checked = dgSuitFood[dgSuitFood.CurrentRowIndex, 5].ToString()=="1"?true:false;
					dgSuitFood.Height = dgSuitFood.Height - Panel1.Height - 5;
					Panel1.Visible = true;
					this.AcceptButton = Button1;
					this.CancelButton = Button2;
					
					TextBox1.Focus();
				}
			}
		}
		
		private void NumericUpDown1_ValueChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown3.Value = NumericUpDown1.Value * NumericUpDown2.Value;
			if (NumericUpDown1.Value != 0)
			{
				NumericUpDown2.Value = NumericUpDown3.Value / NumericUpDown1.Value;
			}
		}
		
		private void NumericUpDown2_ValueChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown3.Value = NumericUpDown1.Value * NumericUpDown2.Value;
		}
		
		private void NumericUpDown3_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown1.Value != 0)
			{
				NumericUpDown2.Value = NumericUpDown3.Value / NumericUpDown1.Value;
			}
		}
		
		private void NumericUpDown1_Leave(object sender, System.EventArgs e)
		{
			NumericUpDown3.Value = NumericUpDown1.Value * NumericUpDown2.Value;
			if (NumericUpDown1.Value != 0)
			{
				NumericUpDown2.Value = NumericUpDown3.Value / NumericUpDown1.Value;
			}
		}
		
		private void NumericUpDown2_Leave(object sender, System.EventArgs e)
		{
			NumericUpDown3.Value = NumericUpDown1.Value * NumericUpDown2.Value;
		}
		
		private void NumericUpDown3_Leave(object sender, System.EventArgs e)
		{
			if (NumericUpDown1.Value != 0)
			{
				NumericUpDown2.Value = NumericUpDown3.Value / NumericUpDown1.Value;
			}
		}
	}
	
}
