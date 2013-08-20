using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace StorageApp
{
	public class frmAddPayVendor : System.Windows.Forms.Form
	{
		
		public int frmmode; //0 = add , 1 = query
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAddPayVendor()
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAddPayVendor));
			this.Label2 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmAddPayVendor_Load);
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(88, 176);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(256, 23);
			this.Label2.TabIndex = 26;
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//ComboBox2
			//
			this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.Location = new System.Drawing.Point(88, 208);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(104, 20);
			this.ComboBox2.TabIndex = 6;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(88, 152);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(256, 21);
			this.TextBox2.TabIndex = 5;
			this.TextBox2.Text = "";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(88, 120);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(104, 21);
			this.NumericUpDown1.TabIndex = 4;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(88, 88);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(256, 20);
			this.ComboBox1.TabIndex = 3;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(88, 56);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(104, 21);
			this.DateTimePicker1.TabIndex = 1;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(88, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(16, 208);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(72, 23);
			this.Label8.TabIndex = 32;
			this.Label8.Text = "审核：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(16, 176);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(72, 23);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "操作员：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 152);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(72, 23);
			this.Label6.TabIndex = 30;
			this.Label6.Text = "备注：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 120);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 29;
			this.Label5.Text = "支付金额：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 88);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 28;
			this.Label4.Text = "供货商：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 56);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 27;
			this.Label3.Text = "时间：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker2.Location = new System.Drawing.Point(192, 56);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.ShowUpDown = true;
			this.DateTimePicker2.Size = new System.Drawing.Size(80, 21);
			this.DateTimePicker2.TabIndex = 2;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "单据号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(200, 256);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(280, 256);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.NumericUpDown1);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(360, 240);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "付款单";
			//
			//frmAddPayVendor
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(376, 288);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddPayVendor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "付供应商";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//添加
		private bool AddData(string billno, string vendorcode, string payedtime, double cost, string note, string @operator, string checkman)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select billno from payvendor where billno='" + billno + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					MessageBox.Show("单据号已经存在！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into payvendor (billno,vendorcode,payedtime,cost,note,operator,checkman) " + "values (" + "'" + billno + "'" + "," + "'" + vendorcode + "'" + "," + "'" + payedtime + "'" + "," + cost.ToString() + "," + "'" + note + "'" + "," + "'" + @operator + "'" + "," + "'" + checkman + "'" + ")";
					
					selectCMD.ExecuteNonQuery();
					//更新供应商累计支付金额
					selectCMD.CommandText = "update vendor set stock_payed=stock_payed+" + cost.ToString() + " where vendorcode='" + vendorcode + "'";
					
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
		
		private void frmAddPayVendor_Load(System.Object sender, System.EventArgs e)
		{
			ComboBox1.Items.Clear();
			DataTable vendorlst;
			vendorlst = rms_var.LoadVendor();
			for (int i = 0; i <= vendorlst.Rows.Count - 1; i++)
			{
				ComboBox1.Items.Add(vendorlst.Rows[i]["VendorName"]);
			}
			if (ComboBox1.Items.Count > 0)
			{
				ComboBox1.SelectedIndex = 0;
			}
			
			ComboBox2.Items.Clear();
			DataTable mnglst;
			mnglst = rms_var.LoadManager();
			for (int i = 0; i <= mnglst.Rows.Count - 1; i++)
			{
				ComboBox2.Items.Add(mnglst.Rows[i]["empid"]);
			}
			if (ComboBox2.Items.Count > 0)
			{
				ComboBox2.SelectedIndex = 0;
			}
			
			Label2.Text = rms_var.opinfo.OpID;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmmode == 0) //添加
			{
				if (TextBox1.Text == "")
				{
					MessageBox.Show("单据号不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (ComboBox1.Text == "")
				{
					MessageBox.Show("供应商不能为空！");
					ComboBox1.Focus();
					return;
				}
				if (NumericUpDown1.Value <= 0)
				{
					MessageBox.Show("支付金额不能为小于或等于 0");
					NumericUpDown1.Focus();
					return;
				}
				if (ComboBox2.Text == "")
				{
					MessageBox.Show("审核不能为空！");
					ComboBox2.Focus();
					return;
				}
				if (AddData(TextBox1.Text, rms_var.GetVendorCode(ComboBox1.Text), DateTimePicker1.Text + " " + DateTimePicker2.Text, (double) NumericUpDown1.Value, TextBox2.Text, Label2.Text, ComboBox2.Text))
					{
					MessageBox.Show("保存成功");
					this.DialogResult = DialogResult.OK;
				}
				
			}
		}
	}
	
}
