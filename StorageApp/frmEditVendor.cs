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
	public class frmEditVendor : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=add 2=edit
		public string OldVendorCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditVendor()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.GroupBox GroupBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditVendor));
			this.TextBox1 = new System.Windows.Forms.TextBox();
			base.Load += new System.EventHandler(frmEditVendor_Load);
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(104, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(152, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(104, 48);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(152, 21);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(104, 72);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(152, 21);
			this.TextBox3.TabIndex = 2;
			this.TextBox3.Text = "";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(104, 96);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(152, 21);
			this.TextBox4.TabIndex = 3;
			this.TextBox4.Text = "";
			//
			//CheckBox1
			//
			this.CheckBox1.Location = new System.Drawing.Point(152, 120);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.TabIndex = 4;
			this.CheckBox1.Text = "暂停使用";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(128, 168);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(208, 168);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(80, 23);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "供应商编码：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 23);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "名称：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(24, 72);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(80, 23);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "联系人：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(24, 96);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 23);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "联系电话：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.TextBox4);
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(280, 152);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			//
			//frmEditVendor
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(298, 208);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditVendor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "编辑供应商";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//添加
		private bool AddData(string vendorcode, string vendorname, string AttachMan, string Telephone, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select vendorcode from vendor where vendorcode='" + vendorcode + "' or vendorname='" + vendorname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					MessageBox.Show("编码或名称重复！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into vendor (vendorcode,vendorname,AttachMan,Telephone,disabled) " + "values (" + "'" + vendorcode + "'" + "," + "'" + vendorname + "'" + "," + "'" + AttachMan + "'" + "," + "'" + Telephone + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + ")";
					
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
		
		//修改
		private bool EditData(string oldvendorcode, string newvendorcode, string vendorname, string AttachMan, string Telephone, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldvendorcode == newvendorcode) //没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update vendor set " + "vendorname='" + vendorname + "'" + "," + "AttachMan='" + vendorname + "'" + "," + "Telephone='" + vendorname + "'" + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where vendorcode='" + oldvendorcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select vendorcode from vendor where vendorcode='" + newvendorcode + "'" + "' and vendorcode<>'" + oldvendorcode + "'";
					
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
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update vendor set " + "vendorcode='" + newvendorcode + "'" + "," + "vendorname='" + newvendorcode + "'" + "," + "AttachMan='" + newvendorcode + "'" + "," + "Telephone='" + Telephone + "'" + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "where vendorcode='" + oldvendorcode + "'";
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("not blank");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("not blank");
				TextBox2.Focus();
				TextBox2.SelectAll();
				return;
			}
			
			if (frmMode == 2) //修改记录
			{
				if (EditData(OldVendorCode, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, CheckBox1.Checked))
				{
					MessageBox.Show("修改记录成功！");
					this.DialogResult = DialogResult.OK;
				}
			}
			else //添加记录
			{
				if (AddData(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, CheckBox1.Checked))
				{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新物品类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						TextBox1.Text = "";
						TextBox2.Text = "";
						TextBox3.Text = "";
						TextBox4.Text = "";
						
						CheckBox1.Checked = false;
						
						TextBox1.Focus();
						TextBox1.SelectAll();
					}
					else
					{
						this.DialogResult = DialogResult.OK;
					}
				}
				
			}
		}
		
		private void frmEditVendor_Load(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
