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
	public class frmEditEmpl : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=添加 2=修改 3=查询
		public string OldEmplCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditEmpl()
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
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.CheckBox CheckBox3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.GroupBox GroupBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditEmpl));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.CheckBox3 = new System.Windows.Forms.CheckBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(75, 23);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "雇员编码：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(194, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 23);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "姓名：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 56);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(75, 23);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "身份证号：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 88);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(75, 23);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "家庭住址：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 120);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(75, 23);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "联系方式：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 152);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(75, 23);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "所属部门：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(16, 184);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(75, 23);
			this.Label7.TabIndex = 13;
			this.Label7.Text = "备注：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//CheckBox1
			//
			this.CheckBox1.Location = new System.Drawing.Point(256, 152);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(96, 24);
			this.CheckBox1.TabIndex = 6;
			this.CheckBox1.Text = "部门领导";
			//
			//CheckBox3
			//
			this.CheckBox3.Location = new System.Drawing.Point(16, 232);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new System.Drawing.Size(160, 24);
			this.CheckBox3.TabIndex = 2;
			this.CheckBox3.Text = "暂时停止该雇员工作";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(192, 272);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(272, 272);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(88, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(248, 24);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(96, 21);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(88, 56);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(256, 21);
			this.TextBox3.TabIndex = 2;
			this.TextBox3.Text = "";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(88, 88);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(256, 21);
			this.TextBox4.TabIndex = 3;
			this.TextBox4.Text = "";
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(88, 120);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(256, 21);
			this.TextBox5.TabIndex = 4;
			this.TextBox5.Text = "";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(88, 152);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(144, 20);
			this.ComboBox1.Sorted = true;
			this.ComboBox1.TabIndex = 5;
			//
			//TextBox6
			//
			this.TextBox6.Location = new System.Drawing.Point(88, 184);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(192, 21);
			this.TextBox6.TabIndex = 7;
			this.TextBox6.Text = "";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.TextBox4);
			this.GroupBox1.Controls.Add(this.TextBox5);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.TextBox6);
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(360, 216);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "雇员一般信息";
			//
			//frmEditEmpl
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(378, 312);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.CheckBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditEmpl";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmEditEmpl";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//获取部门记录，填充下拉列表框
		public void GetDeptList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT deptname FROM department", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					ComboBox1.Items.Add(dbDS.Tables[0].Rows[i]["deptname"]);
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
		private bool AddData(string empid, string emplname, string idcardno, string address, string contact, string deptcode, bool manager, string note, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select empid from employee where empid='" + empid + "'", conn);
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
					selectCMD.CommandText = "insert into employee " + "(empid,name,depcode,disabled,manager,address,note,contact,idcardno) " + "values (" + "'" + empid + "'" + "," + "'" + emplname + "'" + "," + "'" + deptcode + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(manager)).ToString() + "'" + "," + "'" + address + "'" + "," + "'" + note + "'" + "," + "'" + contact + "'" + "," + "'" + idcardno + "'" + ")";
					
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
		private bool EditData(string oldcode, string newcode, string emplname, string idcardno, string address, string contact, string deptcode, bool manager, string note, bool disabled)
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
					selectCMD.CommandText = "update employee set " + "name='" + emplname + "'" + "," + "idcardno='" + idcardno + "'" + "," + "address='" + address + "' " + "," + "contact='" + contact + "' " + "," + "depcode='" + deptcode + "' " + "," + "manager='" + Math.Abs(System.Convert.ToInt32(manager)).ToString() + "' " + "," + "note='" + note + "' " + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where empid='" + oldcode + "'";
					selectCMD.ExecuteNonQuery();
					
					//若暂停该雇员工作，同时暂停该雇员的操作员帐号
					if (disabled)
					{
						selectCMD.CommandText = "update operator set " + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where empid='" + oldcode + "'";
						selectCMD.ExecuteNonQuery();
					}
					
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
						selectCMD.CommandText = "update employee set " + "empid='" + newcode + "'" + "," + "name='" + emplname + "'" + "," + "idcardno='" + idcardno + "'" + "," + "address='" + address + "' " + "," + "contact='" + contact + "' " + "," + "depcode='" + deptcode + "' " + "," + "manager='" + Math.Abs(System.Convert.ToInt32(manager)).ToString() + "' " + "," + "note='" + note + "' " + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where empid='" + oldcode + "'";
						selectCMD.ExecuteNonQuery();
						
						//若暂停该雇员工作，同时暂停该雇员的操作员帐号
						if (disabled)
						{
							selectCMD.CommandText = "update operator set " + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where empid='" + oldcode + "'";
							selectCMD.ExecuteNonQuery();
						}
						
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
					MessageBox.Show("雇员编号不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("雇员姓名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("所属部门不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (AddData(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, rms_var.GetDeptCode(ComboBox1.Text), CheckBox1.Checked, TextBox6.Text, CheckBox3.Checked))
					{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新雇员吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						ComboBox1.Text = "";
						TextBox1.Text = "";
						TextBox2.Text = "";
						TextBox3.Text = "";
						TextBox4.Text = "";
						TextBox5.Text = "";
						TextBox6.Text = "";
						
						CheckBox1.Checked = false;
						CheckBox3.Checked = false;
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
					MessageBox.Show("雇员编号不能为空！");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("雇员姓名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("所属部门不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (MessageBox.Show("确定要修改当前的雇员信息吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(OldEmplCode, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, rms_var.GetDeptCode(ComboBox1.Text), CheckBox1.Checked, TextBox6.Text, CheckBox3.Checked))
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
		
	}
	
}
