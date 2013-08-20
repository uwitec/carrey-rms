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
	public class frmEditFoodOperandi : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=编辑做法 2=编辑当前菜品做法
		public string foodcode;
		public string oldcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditFoodOperandi()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.DataGrid dgFoodOperandi;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button Button6;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditFoodOperandi));
			this.dgFoodOperandi = new System.Windows.Forms.DataGrid();
			base.Load += new System.EventHandler(frmEditFoodOperandi_Load);
			this.dgFoodOperandi.DoubleClick += new System.EventHandler(this.dgFoodOperandi_DoubleClick);
			base.Closed += new System.EventHandler(frmEditFoodOperandi_Closed);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label5 = new System.Windows.Forms.Label();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			((System.ComponentModel.ISupportInitialize) this.dgFoodOperandi).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//dgFoodOperandi
			//
			this.dgFoodOperandi.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodOperandi.BackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodOperandi.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgFoodOperandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgFoodOperandi.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgFoodOperandi.CaptionForeColor = System.Drawing.Color.White;
			this.dgFoodOperandi.DataMember = "";
			this.dgFoodOperandi.FlatMode = true;
			this.dgFoodOperandi.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgFoodOperandi.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodOperandi.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgFoodOperandi.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodOperandi.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgFoodOperandi.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgFoodOperandi.LinkColor = System.Drawing.Color.Teal;
			this.dgFoodOperandi.Location = new System.Drawing.Point(8, 16);
			this.dgFoodOperandi.Name = "dgFoodOperandi";
			this.dgFoodOperandi.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgFoodOperandi.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodOperandi.ReadOnly = true;
			this.dgFoodOperandi.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgFoodOperandi.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgFoodOperandi.Size = new System.Drawing.Size(184, 280);
			this.dgFoodOperandi.TabIndex = 0;
			this.dgFoodOperandi.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgFoodOperandi;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "foodoperandi";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "做法编码";
			this.DataGridTextBoxColumn1.MappingName = "operandicode";
			this.DataGridTextBoxColumn1.Width = 60;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "做法";
			this.DataGridTextBoxColumn2.MappingName = "name";
			this.DataGridTextBoxColumn2.Width = 68;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 16);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "做法编码：";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(8, 50);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(71, 16);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "做法名称：";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(70, 22);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(70, 48);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Button5);
			this.Panel1.Controls.Add(this.Button4);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.TextBox2);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Location = new System.Drawing.Point(200, 16);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(200, 280);
			this.Panel1.TabIndex = 2;
			//
			//Label5
			//
			this.Label5.ForeColor = System.Drawing.Color.Teal;
			this.Label5.Location = new System.Drawing.Point(0, 246);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(200, 33);
			this.Label5.TabIndex = 7;
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(128, 112);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(56, 23);
			this.Button5.TabIndex = 4;
			this.Button5.Text = "删除(&D)";
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(72, 112);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(56, 23);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "更新(&U)";
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(16, 112);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(56, 23);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "添加(&A)";
			//
			//Panel2
			//
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Button6);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.TextBox3);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Location = new System.Drawing.Point(200, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(200, 280);
			this.Panel2.TabIndex = 1;
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(114, 112);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(63, 23);
			this.Button6.TabIndex = 3;
			this.Button6.Text = "清空(&L)";
			//
			//Label4
			//
			this.Label4.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label4.ForeColor = System.Drawing.Color.Navy;
			this.Label4.Location = new System.Drawing.Point(8, 8);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(184, 48);
			this.Label4.TabIndex = 0;
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(8, 72);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(184, 21);
			this.TextBox3.TabIndex = 2;
			this.TextBox3.Text = "";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(8, 56);
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 1;
			this.Label3.Text = "做法：";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(248, 312);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(320, 312);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(64, 23);
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//frmEditFoodOperandi
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(410, 350);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgFoodOperandi);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditFoodOperandi";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			((System.ComponentModel.ISupportInitialize) this.dgFoodOperandi).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		
		//返回做法列表
		private void LoadFoodOperandi()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM foodoperandi", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "FoodOperandi");
				dgFoodOperandi.DataSource = null;
				dgFoodOperandi.DataSource = dbDS;
				dgFoodOperandi.DataMember = "FoodOperandi";
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
		
		//添加做法
		private bool AddOperandi(string operandicode, string operandi)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select operandicode from foodoperandi where operandicode='" + operandicode + "'", conn);
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
					selectCMD.CommandText = "insert into foodoperandi " + "(operandicode,name) " + "values (" + "'" + operandicode + "'" + "," + "'" + operandi + "'" + ")";
					
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
		
		//编辑做法
		private bool EditOperandi(string newoperandicode, string operandi)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldcode == newoperandicode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update foodoperandi set " + "name='" + operandi + "'" + "where operandicode='" + oldcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select operandicode from foodoperandi where operandicode='" + newoperandicode + "'";
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
						selectCMD.CommandText = "update foodoperandi set " + "operandicode='" + newoperandicode + "'" + "," + "name='" + operandi + "'" + "where operandicode='" + oldcode + "'";
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
		
		//删除雇员
		private bool DelOperandi(string operandicode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from foodoperandi where operandicode='" + operandicode + "'";
				selectCMD.CommandTimeout = 30;
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
		
		private void frmEditFoodOperandi_Load(System.Object sender, System.EventArgs e)
		{
			LoadFoodOperandi();
			if (frmMode == 1) //1=编辑做法
			{
				Panel1.Visible = true;
				Panel2.Visible = false;
				Panel1.BringToFront();
				this.Text = "编辑做法";
			}
			else if (frmMode == 2) //2=编辑当前菜品做法
			{
				Panel1.Visible = false;
				Panel2.Visible = true;
				Panel2.BringToFront();
				//返回当前菜品的做法
				this.Text = "设置当前菜品的做法";
				TextBox3.Text = rms_var.GetCurrentFoodOperandi(foodcode);
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 1) //1=编辑做法
			{
				this.DialogResult = DialogResult.OK;
			}
			else if (frmMode == 2) //2=编辑当前菜品做法
			{
				if (MessageBox.Show("确定要修改当前菜品的默认做法吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (rms_var.SetCurrentFoodOperandi(foodcode, TextBox3.Text))
					{
						MessageBox.Show("编辑菜品做法成功");
						this.DialogResult = DialogResult.OK;
					}
				}
				else
				{
					this.DialogResult = DialogResult.Cancel;
				}
				
			}
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("做法编码不能为空！");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("做法不能为空！");
				TextBox2.Focus();
				TextBox2.SelectAll();
				return;
			}
			
			if (AddOperandi(TextBox1.Text, TextBox2.Text))
			{
				Label5.Text = "添加成功！";
				LoadFoodOperandi();
				TextBox1.Text = "";
				TextBox2.Text = "";
				TextBox1.Focus();
				TextBox1.SelectAll();
			}
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("做法编码不能为空！");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("做法不能为空！");
				TextBox2.Focus();
				TextBox2.SelectAll();
				return;
			}
			if (MessageBox.Show("确定要修改当前做法吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				if (EditOperandi(TextBox1.Text, TextBox2.Text))
				{
					Label5.Text = "更新成功！";
					LoadFoodOperandi();
					TextBox1.Text = "";
					TextBox2.Text = "";
					TextBox1.Focus();
					TextBox1.SelectAll();
				}
			}
			
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			if (! (dgFoodOperandi.CurrentRowIndex < 0))
			{
                if (MessageBox.Show("确定要删除当前选中的编号为 " + dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 0].ToString().Trim() + " 的菜品做法吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
                    if (DelOperandi(dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 0].ToString()))
					{
						Label5.Text = "删除成功！";
						LoadFoodOperandi();
					}
				}
			}
		}
		
		private void dgFoodOperandi_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgFoodOperandi.CurrentRowIndex < 0))
			{
				if (frmMode == 1) //1=编辑做法
				{
					oldcode = dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 0].ToString();
					TextBox1.Text = dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 0].ToString();
                    TextBox2.Text = dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 1].ToString();
				}
				else if (frmMode == 2) //2=编辑当前菜品做法
				{
					if (TextBox3.Text.Trim() == "")
					{
                        TextBox3.Text = dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 1].ToString();
					}
					else
					{
						TextBox3.Text = TextBox3.Text + "," + dgFoodOperandi[dgFoodOperandi.CurrentRowIndex, 1];
					}
				}
			}
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			TextBox3.Clear();
		}
		
		private void frmEditFoodOperandi_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmfoodop = null;
		}
	}
	
}
