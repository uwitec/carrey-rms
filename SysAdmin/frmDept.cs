using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;


namespace SysAdmin
{
	public class frmDept : System.Windows.Forms.Form
	{
		
		private string CurrentDeptListSqlCode = "SELECT * FROM department";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmDept()
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
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.DataGrid dgDept;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Closed += new System.EventHandler(frmDept_Closed);
			base.Load += new System.EventHandler(frmDept_Load);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDept));
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgDept = new System.Windows.Forms.DataGrid();
			this.dgDept.DoubleClick += new System.EventHandler(this.dgDept_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			((System.ComponentModel.ISupportInitialize) this.dgDept).BeginInit();
			this.SuspendLayout();
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton4, this.ToolBarButton5, this.ToolBarButton6, this.ToolBarButton7});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(391, 55);
			this.ToolBar1.TabIndex = 0;
			//
			//ToolBarButton1
			//
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Text = "添加";
			//
			//ToolBarButton2
			//
			this.ToolBarButton2.ImageIndex = 1;
			this.ToolBarButton2.Text = "修改";
			//
			//ToolBarButton3
			//
			this.ToolBarButton3.ImageIndex = 2;
			this.ToolBarButton3.Text = "删除";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 4;
			this.ToolBarButton5.Text = "打印";
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 5;
			this.ToolBarButton7.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//dgDept
			//
			this.dgDept.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgDept.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgDept.BackColor = System.Drawing.Color.GhostWhite;
			this.dgDept.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgDept.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgDept.CaptionForeColor = System.Drawing.Color.White;
			this.dgDept.DataMember = "";
			this.dgDept.FlatMode = true;
			this.dgDept.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgDept.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgDept.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgDept.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgDept.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgDept.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgDept.LinkColor = System.Drawing.Color.Teal;
			this.dgDept.Location = new System.Drawing.Point(0, 55);
			this.dgDept.Name = "dgDept";
			this.dgDept.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgDept.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgDept.ReadOnly = true;
			this.dgDept.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgDept.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgDept.Size = new System.Drawing.Size(391, 247);
			this.dgDept.TabIndex = 1;
			this.dgDept.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgDept;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridBoolColumn1});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "Department";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "部门编码";
			this.DataGridTextBoxColumn1.MappingName = "DepCode";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "部门名称";
			this.DataGridTextBoxColumn2.MappingName = "deptname";
			this.DataGridTextBoxColumn2.Width = 90;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "部门类型";
			this.DataGridTextBoxColumn3.MappingName = "depttype";
			this.DataGridTextBoxColumn3.Width = 80;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "是否商品部门";
			this.DataGridBoolColumn1.MappingName = "issecondarystock";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 80;
			//
			//frmDept
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(391, 302);
			this.Controls.Add(this.dgDept);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmDept";
			this.Text = "部门管理";
			((System.ComponentModel.ISupportInitialize) this.dgDept).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		
		//返回部门列表
		private void LoadDeptList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand(CurrentDeptListSqlCode, conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "Department");
				dgDept.DataSource = null;
				dgDept.DataSource = dbDS;
				dgDept.DataMember = "Department";
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
		
		//删除部门
		private bool DelDept(string deptcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//先检查有无雇员和菜品属于此部门
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select depcode from view_employee  where depcode='" + deptcode + "'";
				dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0) //存在属于该部门的雇员记录
				{
					MessageBox.Show("有属于该部门的雇员，不能执行删除操作");
					return false;
				}
				else
				{
					SqlDataAdapter dbDA1;
					DataSet dbDS1;
					
					selectCMD.Connection = conn;
					selectCMD.CommandText = "select depcode from foodlist  where depcode='" + deptcode + "'";
					dbDA1 = new SqlDataAdapter();
					dbDA1.SelectCommand = selectCMD;
					
					dbDS1 = new DataSet();
					dbDA1.Fill(dbDS1, "t");
					if (dbDS1.Tables[0].Rows.Count > 0) //存在属于该部门的菜品记录
					{
						MessageBox.Show("有属于该部门的菜品，不能执行删除操作");
						return false;
					}
					else
					{
						selectCMD.CommandText = "delete from department where depcode='" + deptcode + "'";
						selectCMD.CommandTimeout = 30;
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
		
		private void EditDeptInfo()
		{
			if (!(dgDept[dgDept.CurrentRowIndex, 0] == "09") || !(dgDept[dgDept.CurrentRowIndex, 0] == "99") || ! (dgDept[dgDept.CurrentRowIndex, 0] == "GL"))
				{
				frmEditDept editdept = new frmEditDept();
				editdept.TextBox1.Text = dgDept[dgDept.CurrentRowIndex, 0].ToString();
				editdept.TextBox2.Text = dgDept[dgDept.CurrentRowIndex, 1].ToString();
                editdept.ComboBox1.Text = dgDept[dgDept.CurrentRowIndex, 2].ToString();
                editdept.CheckBox1.Checked = dgDept[dgDept.CurrentRowIndex, 3].ToString() == "1" ? true : false;
				
				editdept.frmMode = 0; //修改记录
				editdept.Text = "修改部门";
				editdept.OldDeptCode = dgDept[dgDept.CurrentRowIndex, 0].ToString(); //保存原始部门编号
                editdept.OldDeptName = dgDept[dgDept.CurrentRowIndex, 1].ToString(); //保存原始部门名称
				editdept.ShowDialog();
				if (editdept.DialogResult == DialogResult.OK)
				{
					LoadDeptList();
				}
			}
			
		}
		
		private void frmDept_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmDepartment = null;
		}
		
		private void frmDept_Load(object sender, System.EventArgs e)
		{
			LoadDeptList();
		}
		
		private void dgDept_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgDept.CurrentRowIndex < 0))
			{
				EditDeptInfo();
			}
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加
					frmEditDept editdept = new frmEditDept();
					editdept.TextBox1.Text = dgDept[dgDept.CurrentRowIndex, 0].ToString();
					editdept.TextBox2.Text = dgDept[dgDept.CurrentRowIndex, 1].ToString();
                    editdept.ComboBox1.Text = dgDept[dgDept.CurrentRowIndex, 2].ToString();
                    editdept.CheckBox1.Checked = dgDept[dgDept.CurrentRowIndex, 3].ToString() == "1" ? true : false;
					
					editdept.frmMode = 1; //添加记录
					editdept.Text = "添加部门";
					
					editdept.TextBox1.Text = "";
					editdept.TextBox2.Text = "";
					editdept.ComboBox1.Text = "";
					editdept.CheckBox1.Checked = false;
					
					editdept.ShowDialog();
					if (editdept.DialogResult == DialogResult.OK)
					{
						LoadDeptList();
					}
					break;
					
				case 1: //修改
					if (! (dgDept.CurrentRowIndex < 0))
					{
						EditDeptInfo();
					}
					break;
				case 2: //删除
					
					if (! (dgDept.CurrentRowIndex < 0))
					{
						if (! (dgDept[dgDept.CurrentRowIndex, 0] == "09") || ! (dgDept[dgDept.CurrentRowIndex, 0] == "99") || ! (dgDept[dgDept.CurrentRowIndex, 0] == "GL"))
							{
                                if (MessageBox.Show("确定要删除当前选中的编号为 " + dgDept[dgDept.CurrentRowIndex, 0].ToString().Trim() + " 的部门吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								//'删除操作
                                if (DelDept(dgDept[dgDept.CurrentRowIndex, 0].ToString()))
								{
									LoadDeptList();
								}
							}
						}
					}
					break;
				case 4: //打印
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentDeptListSqlCode))
						{
							MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
						}
					}
					break;
				case 6: //关闭
					this.Close();
					break;
			}
			
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.dept_cr == null)
			{
				report_var.dept_cr = new ReportDocument();
			}
			else
			{
				report_var.dept_cr.Close();
				report_var.dept_cr = null;
				report_var.dept_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.dept_rpt_filename))
			{
				report_var.dept_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.dept_rpt_filename, sql, "Department");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.dept_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.dept_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.dept_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
	}
	
}
