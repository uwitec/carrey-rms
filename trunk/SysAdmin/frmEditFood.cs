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
	public class frmEditFood : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=添加 2=修改 3=查询
		public string OldFoodCode;
		public string OldFoodName;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditFood()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown4;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.CheckBox CheckBox4;
		internal System.Windows.Forms.CheckBox CheckBox3;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.NumericUpDown NumericUpDown5;
		internal System.Windows.Forms.NumericUpDown NumericUpDown6;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.CheckBox CheckBox5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFood));
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.NumericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.NumericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.NumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.Label11 = new System.Windows.Forms.Label();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Location = new System.Drawing.Point(80, 24);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(136, 20);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(80, 48);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(136, 21);
            this.TextBox1.TabIndex = 1;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(80, 72);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(136, 21);
            this.TextBox2.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CheckBox5);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.NumericUpDown6);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.ComboBox1);
            this.GroupBox1.Controls.Add(this.NumericUpDown5);
            this.GroupBox1.Controls.Add(this.NumericUpDown2);
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.ComboBox2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.NumericUpDown4);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.CheckBox4);
            this.GroupBox1.Controls.Add(this.CheckBox3);
            this.GroupBox1.Controls.Add(this.CheckBox2);
            this.GroupBox1.Controls.Add(this.NumericUpDown3);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(432, 240);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "菜品信息";
            // 
            // CheckBox5
            // 
            this.CheckBox5.Location = new System.Drawing.Point(291, 145);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(104, 24);
            this.CheckBox5.TabIndex = 29;
            this.CheckBox5.Text = "允许前台定制";
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(144, 208);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(80, 23);
            this.Label14.TabIndex = 28;
            this.Label14.Text = "-1为没有限制";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(8, 208);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(72, 23);
            this.Label13.TabIndex = 27;
            this.Label13.Text = "数量限制：";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericUpDown6
            // 
            this.NumericUpDown6.Location = new System.Drawing.Point(80, 208);
            this.NumericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericUpDown6.Name = "NumericUpDown6";
            this.NumericUpDown6.Size = new System.Drawing.Size(56, 21);
            this.NumericUpDown6.TabIndex = 13;
            this.NumericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(80, 96);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(136, 21);
            this.TextBox3.TabIndex = 3;
            // 
            // NumericUpDown5
            // 
            this.NumericUpDown5.Enabled = false;
            this.NumericUpDown5.Location = new System.Drawing.Point(296, 96);
            this.NumericUpDown5.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown5.Name = "NumericUpDown5";
            this.NumericUpDown5.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown5.TabIndex = 6;
            this.NumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(296, 120);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown2.TabIndex = 7;
            this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(296, 72);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown1.TabIndex = 5;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComboBox2
            // 
            this.ComboBox2.Items.AddRange(new object[] {
            "9寸碟",
            "包",
            "杯",
            "碟",
            "个",
            "瓶",
            "桶"});
            this.ComboBox2.Location = new System.Drawing.Point(296, 48);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(120, 20);
            this.ComboBox2.Sorted = true;
            this.ComboBox2.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Navy;
            this.Label3.Location = new System.Drawing.Point(296, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 23);
            this.Label3.TabIndex = 20;
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(224, 96);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(72, 23);
            this.Label12.TabIndex = 23;
            this.Label12.Text = "成本价：";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericUpDown4
            // 
            this.NumericUpDown4.Enabled = false;
            this.NumericUpDown4.Location = new System.Drawing.Point(185, 172);
            this.NumericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown4.Name = "NumericUpDown4";
            this.NumericUpDown4.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown4.TabIndex = 9;
            this.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(113, 172);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(72, 23);
            this.Label11.TabIndex = 26;
            this.Label11.Text = "时价价格：";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBox4
            // 
            this.CheckBox4.Location = new System.Drawing.Point(15, 172);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(104, 24);
            this.CheckBox4.TabIndex = 11;
            this.CheckBox4.Text = "此菜为时价菜";
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.Location = new System.Drawing.Point(15, 146);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(104, 24);
            this.CheckBox3.TabIndex = 10;
            this.CheckBox3.Text = "此菜为特价菜";
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.Location = new System.Drawing.Point(232, 208);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(104, 24);
            this.CheckBox2.TabIndex = 14;
            this.CheckBox2.Text = "暂不出售";
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(291, 171);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(88, 24);
            this.CheckBox1.TabIndex = 12;
            this.CheckBox1.Text = "此菜不优惠";
            // 
            // NumericUpDown3
            // 
            this.NumericUpDown3.Enabled = false;
            this.NumericUpDown3.Location = new System.Drawing.Point(185, 146);
            this.NumericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown3.Name = "NumericUpDown3";
            this.NumericUpDown3.Size = new System.Drawing.Size(88, 21);
            this.NumericUpDown3.TabIndex = 8;
            this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(113, 146);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 23);
            this.Label10.TabIndex = 25;
            this.Label10.Text = "特价价格：";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(224, 120);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(72, 23);
            this.Label9.TabIndex = 24;
            this.Label9.Text = "提成：";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(8, 96);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 23);
            this.Label8.TabIndex = 18;
            this.Label8.Text = "拼音码：";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(224, 72);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(72, 23);
            this.Label7.TabIndex = 22;
            this.Label7.Text = "单价：";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(8, 72);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 23);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "菜品名称：";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(224, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 23);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "单位：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 23);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "菜品编码：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(224, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 23);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "归属部门：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 23);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "菜品类别：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(248, 264);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(328, 264);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "取消(&C)";
            // 
            // frmEditFood
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(448, 304);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditFood";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditFood";
            this.Load += new System.EventHandler(this.frmEditFood_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion
		
		//获取菜品类别记录，填充下拉列表框
		public void GetFoodTypeList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT typename FROM foodtype", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					ComboBox1.Items.Add(dbDS.Tables[0].Rows[i]["typename"]);
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
		private bool AddData(string foodcode, string foodtypename, string deptname, string foodname, string spell, string unit, string price, string cost, string deduct, bool specialfood, bool currentfood, string specialprice, string currentprice, bool nodiscount, bool disabled, string remain, bool customfood)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select foodcode from foodlist where foodcode='" + foodcode + "' or foodname='" + foodname + "'", conn);
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
					selectCMD.CommandText = "insert into foodlist " + "(foodcode,foodtypecode,depcode,foodname,spell, " + "unit,price,cost,deduct,specialfood,currentfood,specialprice,currentprice," + "nodiscount,disabled,remain,isunicode) " + "values (" + "'" + foodcode + "'" + "," + "'" + rms_var.GetFoodTypeCode(foodtypename) + "'" + "," + "'" + rms_var.GetDeptCode(deptname) + "'" + "," + "'" + foodname + "'" + "," + "'" + spell + "'" + "," + "'" + unit + "'" + "," + price + "," + cost + "," + deduct + "," + "'" + Math.Abs(System.Convert.ToInt32(specialfood)).ToString() + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(currentfood)).ToString() + "'" + "," + specialprice + "," + currentprice + "," + "'" + Math.Abs(System.Convert.ToInt32(nodiscount)).ToString() + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "," + remain + "," + Math.Abs(System.Convert.ToInt32(customfood)).ToString() + ")";
					
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
		private bool EditData(string oldfoodcode, string newfoodcode, string foodtypename, string deptname, string foodname, string spell, string unit, string price, string cost, string deduct, bool specialfood, bool currentfood, string specialprice, string currentprice, bool nodiscount, bool disabled, string remain, bool customfood)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldfoodcode == newfoodcode && foodname == OldFoodName) //没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					
					selectCMD.CommandText = "update foodlist set " + "foodtypecode='" + rms_var.GetFoodTypeCode(foodtypename) + "'" + "," + "depcode='" + rms_var.GetDeptCode(deptname) + "' " + "," + "spell='" + spell + "' " + "," + "unit='" + unit + "' " + "," + "price=" + price + "," + "cost=" + cost + "," + "deduct=" + deduct + "," + "specialfood='" + Math.Abs(System.Convert.ToInt32(specialfood)).ToString() + "' " + "," + "currentfood='" + Math.Abs(System.Convert.ToInt32(currentfood)).ToString() + "' " + "," + "specialprice=" + specialprice + "," + "currentprice=" + currentprice + "," + "nodiscount='" + Math.Abs(System.Convert.ToInt32(nodiscount)).ToString() + "' " + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "," + "remain=" + remain + "," + "isunicode=" + Math.Abs(System.Convert.ToInt32(customfood)).ToString() + " " + "where foodcode='" + oldfoodcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select foodcode from foodlist where foodcode='" + newfoodcode + "' and foodcode<>'" + oldfoodcode + "'" + " or foodname='" + foodname + "'" + " and foodname<>'" + OldFoodName + "'";
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
						selectCMD.CommandText = "update foodlist set " + "foodcode='" + newfoodcode + "'" + "," + "foodtypecode='" + rms_var.GetFoodTypeCode(foodtypename) + "'" + "," + "depcode='" + rms_var.GetDeptCode(deptname) + "' " + "," + "foodname='" + foodname + "' " + "," + "spell='" + spell + "' " + "," + "unit='" + unit + "' " + "," + "price=" + price + "," + "cost=" + cost + "," + "deduct=" + deduct + "," + "specialfood='" + Math.Abs(System.Convert.ToInt32(specialfood)).ToString() + "' " + "," + "currentfood='" + Math.Abs(System.Convert.ToInt32(currentfood)).ToString() + "' " + "," + "specialprice=" + specialprice + "," + "currentprice=" + currentprice + "," + "nodiscount='" + Math.Abs(System.Convert.ToInt32(nodiscount)).ToString() + "' " + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where foodcode='" + oldfoodcode + "'";
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
		
		private void frmEditFood_Load(System.Object sender, System.EventArgs e)
		{
			//设置菜例编码长度
			TextBox1.MaxLength = int.Parse(rms_var.GetFoodCodeLenth());
			//是否允许编辑菜品成本
			if (rms_var.GetFoodCostMethodCode() == 1) //1：手工指定，2：读取原料最近进价，3：仓库原料平均价
			{
				NumericUpDown5.Enabled = true;
			}
		}
		
		private void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			//返回菜品类别所属部门
			Label3.Text = rms_var.GetFoodTypeDeptName(ComboBox1.Text);
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 1) //添加记录
			{
				
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("菜品编码不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("菜品名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (TextBox3.Text.Trim() == "")
				{
					MessageBox.Show("拼音码不能为空！");
					TextBox3.Focus();
					TextBox3.SelectAll();
					return;
				}
				if (ComboBox2.Text.Trim() == "")
				{
					MessageBox.Show("单位不能为空！");
					ComboBox2.Focus();
					ComboBox2.SelectAll();
					return;
				}
				
				
				if (NumericUpDown1.Value == 0) //单价为空
				{
					if (MessageBox.Show("单价为空，确定要添加吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (AddData(TextBox1.Text, ComboBox1.Text, Label3.Text, TextBox2.Text, TextBox3.Text, ComboBox2.Text, NumericUpDown1.Text, NumericUpDown5.Text, NumericUpDown2.Text, CheckBox3.Checked, CheckBox4.Checked, NumericUpDown3.Text, NumericUpDown4.Text, CheckBox1.Checked, CheckBox1.Checked, NumericUpDown6.Text, CheckBox5.Checked))
							{
							MessageBox.Show("添加记录成功！");
							if (MessageBox.Show("继续添加新菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
							{
								TextBox1.Text = "";
								TextBox2.Text = "";
								TextBox3.Text = "";
								
								ComboBox1.Text = "";
								ComboBox2.Text = "";
								
								NumericUpDown1.Value = 0;
								NumericUpDown2.Value = 0;
								NumericUpDown3.Value = 0;
								NumericUpDown4.Value = 0;
								NumericUpDown5.Value = 0;
								
								CheckBox1.Checked = false;
								CheckBox2.Checked = false;
								CheckBox3.Checked = false;
								CheckBox4.Checked = false;
								
								ComboBox1.Focus();
							}
							else
							{
								this.DialogResult = DialogResult.OK;
							}
						}
					}
					else
					{
						return;
					}
				}
				else //单价不为空
				{
					if (AddData(TextBox1.Text, ComboBox1.Text, Label3.Text, TextBox2.Text, TextBox3.Text, ComboBox2.Text, NumericUpDown1.Text, NumericUpDown5.Text, NumericUpDown2.Text, CheckBox3.Checked, CheckBox4.Checked, NumericUpDown3.Text, NumericUpDown4.Text, CheckBox1.Checked, CheckBox1.Checked, NumericUpDown6.Text, CheckBox5.Checked))
						{
						MessageBox.Show("添加记录成功！");
						if (MessageBox.Show("继续添加新菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
						{
							TextBox1.Text = "";
							TextBox2.Text = "";
							TextBox3.Text = "";
							
							ComboBox1.Text = "";
							ComboBox2.Text = "";
							
							NumericUpDown1.Value = 0;
							NumericUpDown2.Value = 0;
							NumericUpDown3.Value = 0;
							NumericUpDown4.Value = 0;
							NumericUpDown5.Value = 0;
							
							CheckBox1.Checked = false;
							CheckBox2.Checked = false;
							CheckBox3.Checked = false;
							CheckBox4.Checked = false;
							
							ComboBox1.Focus();
						}
						else
						{
							this.DialogResult = DialogResult.OK;
						}
					}
				}
				
			}
			else if (frmMode == 2) //修改记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("菜品编码不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("菜品名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (TextBox3.Text.Trim() == "")
				{
					MessageBox.Show("拼音码不能为空！");
					TextBox3.Focus();
					TextBox3.SelectAll();
					return;
				}
				if (ComboBox2.Text.Trim() == "")
				{
					MessageBox.Show("单位不能为空！");
					ComboBox2.Focus();
					ComboBox2.SelectAll();
					return;
				}
				if (MessageBox.Show("确定要修改当前菜品信息吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (NumericUpDown1.Value == 0)
					{
						if (MessageBox.Show("单价为空，确定要添加吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							if (EditData(OldFoodCode, TextBox1.Text, ComboBox1.Text, Label3.Text, TextBox2.Text, TextBox3.Text, ComboBox2.Text, NumericUpDown1.Text, NumericUpDown5.Text, NumericUpDown2.Text, CheckBox3.Checked, CheckBox4.Checked, NumericUpDown3.Text, NumericUpDown4.Text, CheckBox1.Checked, CheckBox2.Checked, NumericUpDown6.Text, CheckBox5.Checked))
								{
								MessageBox.Show("修改记录成功！");
								this.DialogResult = DialogResult.OK;
							}
						}
						else
						{
							return;
						}
					}
					else
					{
						if (EditData(OldFoodCode, TextBox1.Text, ComboBox1.Text, Label3.Text, TextBox2.Text, TextBox3.Text, ComboBox2.Text, NumericUpDown1.Text, NumericUpDown5.Text, NumericUpDown2.Text, CheckBox3.Checked, CheckBox4.Checked, NumericUpDown3.Text, NumericUpDown4.Text, CheckBox1.Checked, CheckBox2.Checked, NumericUpDown6.Text, CheckBox5.Checked))
							{
							MessageBox.Show("修改记录成功！");
							this.DialogResult = DialogResult.OK;
						}
					}
				}
				
			}
			else if (frmMode == 3) //查询
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void CheckBox3_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown3.Enabled = CheckBox3.Checked;
		}
		
		private void CheckBox4_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown4.Enabled = CheckBox4.Checked;
		}
	}
	
}
