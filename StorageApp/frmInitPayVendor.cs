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
	public class frmInitPayVendor : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmInitPayVendor()
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
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmInitPayVendor));
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			base.Load += new System.EventHandler(frmInitPayVendor_Load);
			this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(112, 16);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(160, 20);
			this.ComboBox1.TabIndex = 0;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(112, 48);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(88, 21);
			this.NumericUpDown1.TabIndex = 1;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(208, 48);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "保存(&S)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(200, 104);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 3;
			this.Button2.Text = "确定(&O)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 23);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "供应商：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 23);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "建账应付金额：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmInitPayVendor
			//
			this.AcceptButton = this.Button2;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(306, 144);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInitPayVendor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "供应商建账应付金额";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private string GetVendorInitPay(string vendorname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
            string ret="";
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT inipay FROM vendor where vendorname= '" + vendorname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					ret=dbDS.Tables[0].Rows[0][0].ToString();
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
            return ret;
		}
		
		private bool SetVendorInitPay(string vendorname, string InitPayCost)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				selectCMD.CommandText = "update vendor set inipay=" + InitPayCost + " where vendorname='" + vendorname + "'";
				conn.Open();
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
		
		private void frmInitPayVendor_Load(System.Object sender, System.EventArgs e)
		{
			//返回供应商列表
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
			string startdate;
			startdate = rms_var.GetSysSetup("begindate");
			if (startdate != "") //已启用库存管理
			{
				Button1.Enabled = false;
			}
		}
		
		private void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown1.Text = GetVendorInitPay(ComboBox1.Text);
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			SetVendorInitPay(ComboBox1.Text, NumericUpDown1.Text);
		}
	}
	
}
