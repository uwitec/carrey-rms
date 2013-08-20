using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class frmBacktable : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmBacktable()
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
		internal System.Windows.Forms.DataGrid DataGrid1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBacktable));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmBacktable_Load);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.DataGrid1 = new System.Windows.Forms.DataGrid();
			this.DataGrid1.DoubleClick += new System.EventHandler(this.DataGrid1_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(136, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "结帐单据流水线号：";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(16, 32);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(472, 21);
			this.TextBox1.TabIndex = 1;
			this.TextBox1.Text = "";
			//
			//DataGrid1
			//
			this.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.DataGrid1.BackgroundColor = System.Drawing.Color.LightGray;
			this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.DataMember = "";
			this.DataGrid1.FlatMode = true;
			this.DataGrid1.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
			this.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.DataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.DataGrid1.Location = new System.Drawing.Point(16, 80);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.ReadOnly = true;
			this.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.DataGrid1.Size = new System.Drawing.Size(472, 224);
			this.DataGrid1.TabIndex = 2;
			this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.DataGrid1;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4});
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "salebill";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "GUID";
			this.DataGridTextBoxColumn1.MappingName = "serialno";
			this.DataGridTextBoxColumn1.Width = 225;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "桌台号";
			this.DataGridTextBoxColumn2.MappingName = "tableno";
			this.DataGridTextBoxColumn2.Width = 50;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "单据号";
			this.DataGridTextBoxColumn3.MappingName = "billno";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "服务员ID";
			this.DataGridTextBoxColumn4.MappingName = "empid";
			this.DataGridTextBoxColumn4.Width = 60;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(320, 312);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "返位(&B)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(400, 312);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(192, 23);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "选择要返位的最近50个营业单据：";
			//
			//frmBacktable
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(506, 350);
			this.Controls.Add(this.DataGrid1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBacktable";
			this.Text = "返位";
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//检测桌台使用状态
		//0=空闲，1=使用，2=预定中，-1=不存在该桌台 与桌台列表单击事件的返回值不同！
		public int GetTableStatus(string tableno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
            int ret = 0;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT status FROM Tablestatus where TableNo='" + tableno + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (! (dbDS.Tables[0].Rows.Count > 0)) //没有该桌台
				{
					ret=-1;
				}
				else
				{
					//0=空闲，1=使用，2=预定中
					ret=Convert.ToInt32(dbDS.Tables[0].Rows[0]["status"].ToString());
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text == "")
			{
				MessageBox.Show("结帐单据流水线号为空，请选择要返位的营业单据。");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			
			if (MessageBox.Show("真的要进行返位操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				//根据guid，返回所有桌台列表，检测当前桌台是否使用
				bool tableisblank = true;
				
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT tableno FROM balancetable where serialno='" + TextBox1.Text + "'";
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (dbDS.Tables[0].Rows.Count == 0) //没有可以返位的桌台
					{
						MessageBox.Show("没有可以返位的桌台，返位操作不能进行。");
						this.DialogResult = DialogResult.Cancel;
					}
					else
					{
						for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
						{
							if (GetTableStatus(dbDS.Tables[0].Rows[i][0].ToString()) != 0) //桌台非空闲不允许返位
							{
								tableisblank = false;
							}
						}
						//将所有信息添加到原始数据库表中 balancetable_t,SaleBill_t,SaleList_t
						if (tableisblank)
						{
							selectCMD.CommandText = "insert into balancetable_t select * from balancetable where serialno='" + TextBox1.Text + "'";
							selectCMD.ExecuteNonQuery();
							
							selectCMD.CommandText = "insert into SaleBill_t select * from SaleBill where serialno='" + TextBox1.Text + "'";
							selectCMD.ExecuteNonQuery();
							
							selectCMD.CommandText = "insert into SaleList_t select * from SaleList where serialno='" + TextBox1.Text + "'";
							selectCMD.ExecuteNonQuery();
						}
						else
						{
							MessageBox.Show("桌台非空闲不允许返位操作。");
						}
						//删除结账后的表的数据
						selectCMD.CommandText = "delete from balancetable where serialno='" + TextBox1.Text + "'";
						selectCMD.ExecuteNonQuery();
						
						selectCMD.CommandText = "delete from SaleBill where serialno='" + TextBox1.Text + "'";
						selectCMD.ExecuteNonQuery();
						
						selectCMD.CommandText = "delete from SaleList where serialno='" + TextBox1.Text + "'";
						selectCMD.ExecuteNonQuery();
						
						selectCMD.CommandText = "delete from balance where serialno='" + TextBox1.Text + "'";
						selectCMD.ExecuteNonQuery();
						
						selectCMD.CommandText = "delete from balancetype where serialno='" + TextBox1.Text + "'";
						selectCMD.ExecuteNonQuery();
						//更新桌台状态
						for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
						{
							selectCMD.CommandText = "update tablestatus set status='1' where tableno='" + dbDS.Tables[0].Rows[i][0].ToString() + "'";
							selectCMD.ExecuteNonQuery();
						}
						MessageBox.Show("返位成功。");
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
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				//Me.DialogResult = DialogResult.Cancel
			}
		}
		
		private void frmBacktable_Load(System.Object sender, System.EventArgs e)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT top 50 * FROM salebill order by billno desc";
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "salebill");
				DataGrid1.DataSource = null;
				DataGrid1.DataSource = dbDS;
				DataGrid1.DataMember = "salebill";
				
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
		
		private void DataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			if (DataGrid1.VisibleRowCount > 0)
			{
				TextBox1.Text = DataGrid1[DataGrid1.CurrentRowIndex, 0].ToString();
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
	
}
