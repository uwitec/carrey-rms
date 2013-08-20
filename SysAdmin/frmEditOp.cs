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
	public class frmEditOp : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=add 2=edit
		public string OldOPCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditOp()
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.TextBox TextBox7;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditOp));
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(20, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "操作员登录帐号：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(128, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(120, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(32, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "雇员姓名：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Location = new System.Drawing.Point(128, 56);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 20);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 1;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(48, 192);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(112, 24);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.Text = "暂停使用该帐号";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(112, 224);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(192, 224);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "取消(&C)";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.CheckBox2);
            this.GroupBox2.Controls.Add(this.TextBox7);
            this.GroupBox2.Location = new System.Drawing.Point(24, 88);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(256, 96);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "登录无线网络";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(16, 56);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 23);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "PPC登录密码：";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBox2
            // 
            this.CheckBox2.Location = new System.Drawing.Point(24, 24);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(112, 24);
            this.CheckBox2.TabIndex = 0;
            this.CheckBox2.Text = "允许登录PPC";
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // TextBox7
            // 
            this.TextBox7.Enabled = false;
            this.TextBox7.Location = new System.Drawing.Point(104, 56);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(120, 21);
            this.TextBox7.TabIndex = 1;
            // 
            // frmEditOp
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(306, 264);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditOp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//获取雇员记录，填充下拉列表框
		public void GetEmplList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT name FROM employee", conn);
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
		private bool AddData(string operatorid, string empid, bool disabled, bool ppc, string ppc_psw)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select operatorid from operator where operatorid='" + operatorid + "'", conn);
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
					selectCMD.CommandText = "insert into operator " + "(operatorid,empid,disabled,ppc,ppc_psw) " + "values (" + "'" + operatorid + "'" + "," + "'" + empid + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(ppc)).ToString() + "'" + "," + "'" + ppc_psw + "'" + ")";
					
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
		private bool EditData(string oldcode, string newcode, string empid, bool disabled, bool PPC, string PPC_PSW)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldcode == newcode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update operator set " + "empid='" + empid + "'" + "," + "disabled='" + (disabled?"1":"0")+ "'" + "," + "PPC='" + (PPC?"1":"0") + "'" + "," + "PPC_PSW='" + PPC_PSW + "' " + "where operatorid='" + oldcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select empid from employee where empid='" + newcode + "'";
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
						TextBox1.Focus();
						TextBox1.SelectAll();
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update operator set " + "operatorid='" + newcode + "'" + "," + "empid='" + empid + "'" + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "," + "PPC='" + Math.Abs(System.Convert.ToInt32(PPC)).ToString() + "'" + "," + "PPC_PSW='" + PPC_PSW + "' " + "where operatorid='" + oldcode + "'";
						selectCMD.ExecuteNonQuery();
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 1) //添加记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("登录帐号不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("雇员姓名不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (CheckBox2.Checked)
				{
					if (TextBox7.Text == "")
					{
						MessageBox.Show("PPC登录密码不能为空!");
						TextBox7.Focus();
						TextBox7.SelectAll();
						return;
					}
				}
				
				if (AddData(TextBox1.Text, rms_var.GetEmplCode(ComboBox1.Text), CheckBox1.Checked, CheckBox2.Checked, TextBox7.Text))
				{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新的操作员吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						TextBox1.Text = "";
						ComboBox1.Text = "";
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
			else if (frmMode == 2) //修改记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("登录帐号不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("雇员姓名不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (CheckBox2.Checked)
				{
					if (TextBox7.Text == "")
					{
						MessageBox.Show("PPC登录密码不能为空!");
						TextBox7.Focus();
						TextBox7.SelectAll();
						return;
					}
				}
				if (MessageBox.Show("确定要修改当前操作员信息吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(OldOPCode, TextBox1.Text, rms_var.GetEmplCode(ComboBox1.Text), CheckBox1.Checked, CheckBox2.Checked, TextBox7.Text))
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
				TextBox7.Enabled = true;
			}
			else
			{
				TextBox7.Enabled = false;
			}
		}
		
	}
	
}
