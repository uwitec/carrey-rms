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
	public class frmEditFoodTaste : System.Windows.Forms.Form
	{
		
		public int frmMode; //1=编辑口味 2=编辑当前菜品口味
		public string foodcode;
		public string oldcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditFoodTaste()
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
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGrid dgFoodTaste;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditFoodTaste));
			this.Button2 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmEditFoodTaste_Load);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			base.Closed += new System.EventHandler(frmEditFoodTaste_Closed);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.dgFoodTaste = new System.Windows.Forms.DataGrid();
			this.dgFoodTaste.DoubleClick += new System.EventHandler(this.dgFoodTaste_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label5 = new System.Windows.Forms.Label();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgFoodTaste).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
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
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(248, 312);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//dgFoodTaste
			//
			this.dgFoodTaste.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodTaste.BackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodTaste.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgFoodTaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgFoodTaste.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgFoodTaste.CaptionForeColor = System.Drawing.Color.White;
			this.dgFoodTaste.DataMember = "";
			this.dgFoodTaste.FlatMode = true;
			this.dgFoodTaste.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgFoodTaste.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodTaste.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgFoodTaste.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodTaste.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgFoodTaste.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgFoodTaste.LinkColor = System.Drawing.Color.Teal;
			this.dgFoodTaste.Location = new System.Drawing.Point(8, 16);
			this.dgFoodTaste.Name = "dgFoodTaste";
			this.dgFoodTaste.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgFoodTaste.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodTaste.ReadOnly = true;
			this.dgFoodTaste.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgFoodTaste.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgFoodTaste.Size = new System.Drawing.Size(184, 280);
			this.dgFoodTaste.TabIndex = 0;
			this.dgFoodTaste.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgFoodTaste;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "foodtaste";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "口味编码";
			this.DataGridTextBoxColumn1.MappingName = "tastecode";
			this.DataGridTextBoxColumn1.Width = 60;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "口味";
			this.DataGridTextBoxColumn2.MappingName = "name";
			this.DataGridTextBoxColumn2.Width = 68;
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
			this.Label3.Text = "口味：";
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
			this.Panel1.TabIndex = 1;
			//
			//Label5
			//
			this.Label5.ForeColor = System.Drawing.Color.Teal;
			this.Label5.Location = new System.Drawing.Point(0, 248);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(200, 32);
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
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(70, 48);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(70, 22);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 16);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "口味编码：";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(8, 50);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(71, 16);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "口味名称：";
			//
			//frmEditFoodTaste
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(416, 350);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgFoodTaste);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditFoodTaste";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			((System.ComponentModel.ISupportInitialize) this.dgFoodTaste).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回口味列表
		private void LoadFoodTaste()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM foodtaste", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "FoodTaste");
				dgFoodTaste.DataSource = null;
				dgFoodTaste.DataSource = dbDS;
				dgFoodTaste.DataMember = "FoodTaste";
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
		
		//添加口味
		private bool AddTaste(string tastecode, string taste)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select tastecode from foodtaste where tastecode='" + tastecode + "'", conn);
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
					selectCMD.CommandText = "insert into foodtaste " + "(tastecode,name) " + "values (" + "'" + tastecode + "'" + "," + "'" + taste + "'" + ")";
					
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
		
		//编辑口味
		private bool EditTaste(string newtastecode, string taste)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldcode == newtastecode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update foodtaste set " + "name='" + taste + "'" + "where tastecode='" + oldcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select tastecode from foodtaste where tastecode='" + newtastecode + "'";
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
						selectCMD.CommandText = "update foodtaste set " + "tastecode='" + newtastecode + "'" + "," + "name='" + taste + "'" + "where tastecode='" + oldcode + "'";
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
		
		//删除口味
		private bool DelTaste(string Tastecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from foodTaste where Tastecode='" + Tastecode + "'";
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 1) //1=编辑口味
			{
				this.DialogResult = DialogResult.OK;
			}
			else if (frmMode == 2) //2=编辑当前菜品口味
			{
				if (MessageBox.Show("确定要修改当前菜品的默认口味吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (rms_var.SetCurrentFoodTaste(foodcode, TextBox3.Text))
					{
						MessageBox.Show("编辑菜品口味成功");
						this.DialogResult = DialogResult.OK;
					}
				}
				else
				{
					this.DialogResult = DialogResult.Cancel;
				}
				
			}
		}
		
		private void frmEditFoodTaste_Load(System.Object sender, System.EventArgs e)
		{
			LoadFoodTaste();
			if (frmMode == 1) //1=编辑口味
			{
				Panel1.Visible = true;
				Panel2.Visible = false;
				Panel1.BringToFront();
				this.Text = "编辑口味";
			}
			else if (frmMode == 2) //2=编辑当前菜品口味
			{
				Panel1.Visible = false;
				Panel2.Visible = true;
				Panel2.BringToFront();
				//返回当前菜品的口味
				this.Text = "设置当前菜品的口味";
				TextBox3.Text = rms_var.GetCurrentFoodTaste(foodcode);
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("口味编码不能为空！");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("口味不能为空！");
				TextBox2.Focus();
				TextBox2.SelectAll();
				return;
			}
			
			if (AddTaste(TextBox1.Text, TextBox2.Text))
			{
				Label5.Text = "添加成功！";
				LoadFoodTaste();
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
				MessageBox.Show("口味编码不能为空！");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("口味不能为空！");
				TextBox2.Focus();
				TextBox2.SelectAll();
				return;
			}
			if (MessageBox.Show("确定要修改当前口味吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				if (EditTaste(TextBox1.Text, TextBox2.Text))
				{
					Label5.Text = "更新成功！";
					LoadFoodTaste();
					TextBox1.Text = "";
					TextBox2.Text = "";
					TextBox1.Focus();
					TextBox1.SelectAll();
				}
			}
			
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			if (! (dgFoodTaste.CurrentRowIndex < 0))
			{
                if (MessageBox.Show("确定要删除当前选中的编号为 " + dgFoodTaste[dgFoodTaste.CurrentRowIndex, 0].ToString().Trim() + " 的菜品口味吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
                    if (DelTaste(dgFoodTaste[dgFoodTaste.CurrentRowIndex, 0].ToString()))
					{
						Label5.Text = "删除成功！";
						LoadFoodTaste();
					}
				}
			}
		}
		
		private void dgFoodTaste_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgFoodTaste.CurrentRowIndex < 0))
			{
				if (frmMode == 1) //1=编辑口味
				{
					oldcode = dgFoodTaste[dgFoodTaste.CurrentRowIndex, 0].ToString();
					TextBox1.Text = dgFoodTaste[dgFoodTaste.CurrentRowIndex, 0].ToString();
                    TextBox2.Text = dgFoodTaste[dgFoodTaste.CurrentRowIndex, 1].ToString();
				}
				else if (frmMode == 2) //2=编辑当前菜品口味
				{
					if (TextBox3.Text.Trim() == "")
					{
                        TextBox3.Text = dgFoodTaste[dgFoodTaste.CurrentRowIndex, 1].ToString();
					}
					else
					{
						TextBox3.Text = TextBox3.Text + "," + dgFoodTaste[dgFoodTaste.CurrentRowIndex, 1];
					}
				}
			}
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			TextBox3.Clear();
		}
		
		private void frmEditFoodTaste_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmfoodtst = null;
		}
	}
	
}
