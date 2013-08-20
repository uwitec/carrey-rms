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
	public class frmEditCust : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=添加 2=修改 3=查询
		public string OldCustCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditCust()
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
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.CheckBox CheckBox2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditCust));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			this.Label11 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.TextBox10 = new System.Windows.Forms.TextBox();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.CheckBox2 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "客户类别：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(224, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "客户编码：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(24, 40);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 17;
			this.Label3.Text = "客户名称：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(224, 40);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "单位名称：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(24, 64);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "个人电话：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(224, 64);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(72, 23);
			this.Label6.TabIndex = 20;
			this.Label6.Text = "单位电话：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(24, 88);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(72, 23);
			this.Label7.TabIndex = 21;
			this.Label7.Text = "联系人：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(224, 88);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(72, 23);
			this.Label8.TabIndex = 22;
			this.Label8.Text = "联系地址：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(8, 136);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(88, 23);
			this.Label9.TabIndex = 23;
			this.Label9.Text = "身份证号码：";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(152, 208);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(72, 23);
			this.Label10.TabIndex = 25;
			this.Label10.Text = "签单限额：";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//CheckBox1
			//
			this.CheckBox1.Location = new System.Drawing.Point(40, 208);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.TabIndex = 10;
			this.CheckBox1.Text = "签单权";
			//
			//Label11
			//
			this.Label11.Location = new System.Drawing.Point(16, 167);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(80, 23);
			this.Label11.TabIndex = 24;
			this.Label11.Text = "备注：";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(248, 288);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 13;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(328, 288);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 14;
			this.Button2.Text = "取消(&C)";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(96, 41);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(112, 21);
			this.TextBox2.TabIndex = 2;
			this.TextBox2.Text = "";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(96, 65);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(112, 21);
			this.TextBox3.TabIndex = 4;
			this.TextBox3.Text = "";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(96, 89);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(112, 21);
			this.TextBox4.TabIndex = 6;
			this.TextBox4.Text = "";
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(96, 137);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(312, 21);
			this.TextBox5.TabIndex = 8;
			this.TextBox5.Text = "";
			//
			//TextBox6
			//
			this.TextBox6.Location = new System.Drawing.Point(296, 17);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(112, 21);
			this.TextBox6.TabIndex = 1;
			this.TextBox6.Text = "";
			//
			//TextBox7
			//
			this.TextBox7.Location = new System.Drawing.Point(296, 41);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(112, 21);
			this.TextBox7.TabIndex = 3;
			this.TextBox7.Text = "";
			//
			//TextBox8
			//
			this.TextBox8.Location = new System.Drawing.Point(296, 65);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new System.Drawing.Size(112, 21);
			this.TextBox8.TabIndex = 5;
			this.TextBox8.Text = "";
			//
			//TextBox9
			//
			this.TextBox9.Location = new System.Drawing.Point(296, 89);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new System.Drawing.Size(112, 21);
			this.TextBox9.TabIndex = 7;
			this.TextBox9.Text = "";
			//
			//TextBox10
			//
			this.TextBox10.Location = new System.Drawing.Point(96, 168);
			this.TextBox10.Name = "TextBox10";
			this.TextBox10.Size = new System.Drawing.Size(312, 21);
			this.TextBox10.TabIndex = 9;
			this.TextBox10.Text = "";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.DecimalPlaces = 2;
			this.NumericUpDown1.Location = new System.Drawing.Point(224, 208);
			this.NumericUpDown1.Maximum = new decimal(new int[] {100000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(80, 21);
			this.NumericUpDown1.TabIndex = 11;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(96, 17);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(112, 20);
			this.ComboBox1.TabIndex = 0;
			//
			//CheckBox2
			//
			this.CheckBox2.Location = new System.Drawing.Point(40, 240);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new System.Drawing.Size(120, 24);
			this.CheckBox2.TabIndex = 12;
			this.CheckBox2.Text = "暂停管理该客户";
			//
			//frmEditCust
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(426, 328);
			this.Controls.Add(this.CheckBox2);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.TextBox10);
			this.Controls.Add(this.TextBox9);
			this.Controls.Add(this.TextBox8);
			this.Controls.Add(this.TextBox7);
			this.Controls.Add(this.TextBox6);
			this.Controls.Add(this.TextBox5);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditCust";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmEditCust";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//添加
		private bool AddData(string custtype, string custcode, string custname, string company, string phonenumber1, string phonenumber2, string contacter, string address, string idcardno, bool signed, string signupcost, string note, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select customercode from customer where customercode='" + custcode + "'", conn);
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
					selectCMD.CommandText = "insert into customer " + "(customercode,customername,customertype,company,phonenumber1,phonenumber2,contacter,address1,idcardno,signed,signupcost,note,disabled) " + "values (" + "'" + custcode + "'" + "," + "'" + custname + "'" + "," + "'" + rms_var.GetCustTypeCode(custtype) + "'" + "," + "'" + company + "'" + "," + "'" + phonenumber1 + "'" + "," + "'" + phonenumber2 + "'" + "," + "'" + contacter + "'" + "," + "'" + address + "'" + "," + "'" + idcardno + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(signed)).ToString() + "'" + "," + signupcost + "," + "'" + note + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + ")";
					
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
		private bool EditData(string custtype, string oldcustcode, string newcustcode, string custname, string company, string phonenumber1, string phonenumber2, string contacter, string address, string idcardno, bool signed, string signupcost, string note, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldcustcode == newcustcode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update customer set " + "customername='" + custname + "'" + "," + "customertype='" + rms_var.GetCustTypeCode(custtype) + "' " + "," + "company='" + company + "' " + "," + "phonenumber1='" + phonenumber1 + "' " + "," + "phonenumber2='" + phonenumber2 + "' " + "," + "contacter='" + contacter + "' " + "," + "address1='" + address + "' " + "," + "idcardno='" + idcardno + "' " + "," + "signed='" + Math.Abs(System.Convert.ToInt32(signed)).ToString() + "' " + "," + "signupcost=" + signupcost + "," + "note='" + note + "'" + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where customercode='" + oldcustcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select customercode from customer where customercode='" + newcustcode + "'";
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
						TextBox6.Focus();
						TextBox6.SelectAll();
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update customer set " + "customercode='" + newcustcode + "'" + "," + "customername='" + custname + "'" + "," + "customertype='" + rms_var.GetCustTypeCode(custtype) + "' " + "," + "company='" + company + "' " + "," + "phonenumber1='" + phonenumber1 + "' " + "," + "phonenumber2='" + phonenumber2 + "' " + "," + "contacter='" + contacter + "' " + "," + "address1='" + address + "' " + "," + "idcardno='" + idcardno + "' " + "," + "signed='" + Math.Abs(System.Convert.ToInt32(signed)).ToString() + "' " + "," + "signupcost=" + signupcost + "," + "note='" + note + "'" + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "' " + "where customercode='" + oldcustcode + "'";
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
		
		//获取客户类别记录，填充下拉列表框
		public void GetCustTypeList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT typename FROM custtype", conn);
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 1) //添加记录
			{
				if (TextBox6.Text.Trim() == "")
				{
					MessageBox.Show("客户编号不能为空！");
					TextBox6.Focus();
					TextBox6.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("客户姓名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("所属类别不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				
				if (AddData(ComboBox1.Text, TextBox6.Text, TextBox2.Text, TextBox7.Text, TextBox3.Text, TextBox8.Text, TextBox4.Text, TextBox9.Text, TextBox5.Text, CheckBox1.Checked, NumericUpDown1.Text, TextBox10.Text, CheckBox2.Checked))
					{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新客户吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						ComboBox1.Text = "";
						TextBox2.Text = "";
						TextBox3.Text = "";
						TextBox4.Text = "";
						TextBox5.Text = "";
						TextBox6.Text = "";
						TextBox7.Text = "";
						TextBox8.Text = "";
						TextBox9.Text = "";
						TextBox10.Text = "";
						NumericUpDown1.Value = 0;
						CheckBox1.Checked = false;
						CheckBox2.Checked = false;
						
						ComboBox1.Focus();
					}
					else
					{
						this.DialogResult = DialogResult.OK;
					}
				}
			}
			else if (frmMode == 2) //修改记录
			{
				if (TextBox6.Text.Trim() == "")
				{
					MessageBox.Show("客户编号不能为空！");
					TextBox6.Focus();
					TextBox6.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("客户姓名不能为空！");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("所属类别不能为空！");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (MessageBox.Show("确定要修改当前的客户信息吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(ComboBox1.Text, OldCustCode, TextBox6.Text, TextBox2.Text, TextBox7.Text, TextBox3.Text, TextBox8.Text, TextBox4.Text, TextBox9.Text, TextBox5.Text, CheckBox1.Checked, NumericUpDown1.Text, TextBox10.Text, CheckBox2.Checked))
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
		
		private void CheckBox1_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			NumericUpDown1.Enabled = CheckBox1.Checked;
		}
	}
	
}
