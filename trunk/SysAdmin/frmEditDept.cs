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
	public class frmEditDept : System.Windows.Forms.Form
	{
		
		public int frmMode; //0=edit 1=add
		public string OldDeptCode;
		public string OldDeptName;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditDept()
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditDept));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(32, 24);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 6;
			this.Label1.Text = "部门编码：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(32, 48);
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 7;
			this.Label2.Text = "部门名称：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(32, 72);
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 8;
			this.Label3.Text = "部门类别：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//CheckBox1
			//
			this.CheckBox1.Location = new System.Drawing.Point(128, 104);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.TabIndex = 3;
			this.CheckBox1.Text = "商品部门";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(64, 144);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 4;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(152, 144);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 5;
			this.Button2.Text = "取消(&C)";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(128, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(104, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(128, 48);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(104, 21);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Items.AddRange(new object[] {"财务", "菜品制作", "仓库", "经理", "客户服务", "其它"});
			this.ComboBox1.Location = new System.Drawing.Point(128, 72);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(104, 20);
			this.ComboBox1.Sorted = true;
			this.ComboBox1.TabIndex = 2;
			//
			//frmEditDept
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(290, 184);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditDept";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "修改部门";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//添加 dept
		private bool AddDept(string deptcode, string deptname, string depttype, bool secstock)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select depcode from department where depcode='" + deptcode + "' or deptname='" + deptname + "'", conn);
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
					selectCMD.CommandText = "insert into department (depcode,deptname,depttype,issecondarystock) " + "values (" + "'" + deptcode + "'" + "," + "'" + deptname + "'" + "," + "'" + depttype + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(secstock)).ToString() + "'" + ")";
					
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
		
		//修改 dept
		private bool EditTheDept(string olddeptcode, string newdeptcode, string deptname, string depttype, bool secstock)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (olddeptcode == newdeptcode && OldDeptName == deptname) //没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update department set " + "deptname='" + deptname + "'" + "," + "depttype='" + depttype + "'" + "," + "issecondarystock='" + Math.Abs(System.Convert.ToInt32(secstock)).ToString() + "' " + "where depcode='" + olddeptcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select depcode from department where depcode='" + newdeptcode + "' and depcode<>'" + olddeptcode + "'" + " or deptname='" + deptname + "'" + " and deptname<>'" + OldDeptName + "'";
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
						selectCMD.CommandText = "update department set " + "depcode='" + newdeptcode + "'" + "," + "deptname='" + deptname + "'" + "," + "depttype='" + depttype + "'" + "," + "issecondarystock='" + Math.Abs(System.Convert.ToInt32(secstock)).ToString() + "'" + "where depcode='" + olddeptcode + "'";
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
			if (ComboBox1.Text.Trim() == "")
			{
				MessageBox.Show("not blank");
				ComboBox1.Focus();
				ComboBox1.SelectAll();
				return;
			}
			if (frmMode == 0) //修改记录
			{
				if (EditTheDept(OldDeptCode, TextBox1.Text, TextBox2.Text, ComboBox1.Text, CheckBox1.Checked))
				{
					MessageBox.Show("修改记录成功！");
					this.DialogResult = DialogResult.OK;
				}
			}
			else //添加记录
			{
				if (AddDept(TextBox1.Text, TextBox2.Text, ComboBox1.Text, CheckBox1.Checked))
				{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新部门吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						TextBox1.Text = "";
						TextBox2.Text = "";
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
		}
		
	}
	
}
