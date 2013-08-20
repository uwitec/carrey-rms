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
	public class frmEmployee : System.Windows.Forms.Form
	{
		
		private string CurrentEmpLstSqlCode = "SELECT * FROM view_Employee";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEmployee()
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
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGrid dgEmpl;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn3;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmEmployee_Load);
			base.Closed += new System.EventHandler(frmEmployee_Closed);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEmployee));
			this.dgEmpl = new System.Windows.Forms.DataGrid();
			this.dgEmpl.DoubleClick += new System.EventHandler(this.dgEmpl_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn3 = new System.Windows.Forms.DataGridBoolColumn();
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize) this.dgEmpl).BeginInit();
			this.SuspendLayout();
			//
			//dgEmpl
			//
			this.dgEmpl.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgEmpl.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgEmpl.BackColor = System.Drawing.Color.GhostWhite;
			this.dgEmpl.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgEmpl.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgEmpl.CaptionForeColor = System.Drawing.Color.White;
			this.dgEmpl.DataMember = "";
			this.dgEmpl.FlatMode = true;
			this.dgEmpl.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgEmpl.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgEmpl.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgEmpl.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgEmpl.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgEmpl.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgEmpl.LinkColor = System.Drawing.Color.Teal;
			this.dgEmpl.Location = new System.Drawing.Point(0, 56);
			this.dgEmpl.Name = "dgEmpl";
			this.dgEmpl.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgEmpl.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgEmpl.ReadOnly = true;
			this.dgEmpl.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgEmpl.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgEmpl.Size = new System.Drawing.Size(500, 328);
			this.dgEmpl.TabIndex = 2;
			this.dgEmpl.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgEmpl;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridBoolColumn1, this.DataGridTextBoxColumn8, this.DataGridTextBoxColumn9, this.DataGridBoolColumn3});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "Employee";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "雇员编码";
			this.DataGridTextBoxColumn1.MappingName = "empid";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "姓名";
			this.DataGridTextBoxColumn2.MappingName = "name";
			this.DataGridTextBoxColumn2.Width = 75;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "所属部门";
			this.DataGridTextBoxColumn3.MappingName = "deptname";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "联系地址";
			this.DataGridTextBoxColumn5.MappingName = "address";
			this.DataGridTextBoxColumn5.NullText = "";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "通讯方式";
			this.DataGridTextBoxColumn6.MappingName = "contact";
			this.DataGridTextBoxColumn6.NullText = "";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "部门领导";
			this.DataGridBoolColumn1.MappingName = "manager";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 75;
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "身份证号";
			this.DataGridTextBoxColumn8.MappingName = "idcardno";
			this.DataGridTextBoxColumn8.NullText = "";
			this.DataGridTextBoxColumn8.Width = 75;
			//
			//DataGridTextBoxColumn9
			//
			this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn9.Format = "";
			this.DataGridTextBoxColumn9.FormatInfo = null;
			this.DataGridTextBoxColumn9.HeaderText = "备注";
			this.DataGridTextBoxColumn9.MappingName = "note";
			this.DataGridTextBoxColumn9.NullText = "";
			this.DataGridTextBoxColumn9.Width = 75;
			//
			//DataGridBoolColumn3
			//
			this.DataGridBoolColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn3.FalseValue = "0";
			this.DataGridBoolColumn3.HeaderText = "暂停";
			this.DataGridBoolColumn3.MappingName = "disabled";
			this.DataGridBoolColumn3.NullValue = resources.GetObject("DataGridBoolColumn3.NullValue");
			this.DataGridBoolColumn3.TrueValue = "1";
			this.DataGridBoolColumn3.Width = 75;
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
			//ToolBarButton9
			//
			this.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 5;
			this.ToolBarButton7.Text = "关闭";
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton9, this.ToolBarButton5, this.ToolBarButton4, this.ToolBarButton6, this.ToolBarButton8, this.ToolBarButton7});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(500, 55);
			this.ToolBar1.TabIndex = 1;
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 3;
			this.ToolBarButton5.Text = "查询";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.ImageIndex = 4;
			this.ToolBarButton6.Text = "打印";
			//
			//ToolBarButton8
			//
			this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//frmEmployee
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(500, 384);
			this.Controls.Add(this.dgEmpl);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmEmployee";
			this.Text = "雇员管理";
			((System.ComponentModel.ISupportInitialize) this.dgEmpl).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回雇员列表
		private void LoadEmplList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand(CurrentEmpLstSqlCode, conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "Employee");
				dgEmpl.DataSource = null;
				dgEmpl.DataSource = dbDS;
				dgEmpl.DataMember = "Employee";
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
		
		//查询雇员信息
		private void SearchEmpl(string empid, string emplname, string deptname)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				CurrentEmpLstSqlCode = "SELECT * FROM view_Employee where " + "empid like '" + "%" + empid + "%'" + " and " + "name like '" + "%" + emplname + "%'" + " and " + "deptname like '" + "%" + deptname + "%'";
				selectCMD.CommandText = CurrentEmpLstSqlCode;
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "Employee");
				dgEmpl.DataSource = null;
				dgEmpl.DataSource = dbDS;
				dgEmpl.DataMember = "Employee";
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
		
		//删除雇员
		private bool DelEmpl(string empid)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from employee where empid='" + empid + "'";
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				//删除操作帐号信息
				selectCMD.CommandText = "delete from operator where empid='" + empid + "'";
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
		
		//编辑雇员信息
		private void EditEmplInfo()
		{
			frmEditEmpl editempl = new frmEditEmpl();
			editempl.GetDeptList();
			editempl.TextBox1.Text = dgEmpl[dgEmpl.CurrentRowIndex, 0].ToString(); //编号
            editempl.TextBox2.Text = dgEmpl[dgEmpl.CurrentRowIndex, 1].ToString(); //姓名
			editempl.TextBox3.Text = dgEmpl[dgEmpl.CurrentRowIndex, 6].ToString(); //身份证号
			editempl.TextBox4.Text = dgEmpl[dgEmpl.CurrentRowIndex, 3].ToString(); //家庭住址
			editempl.TextBox5.Text = dgEmpl[dgEmpl.CurrentRowIndex, 4].ToString(); //联系方式

			editempl.ComboBox1.Text =dgEmpl[dgEmpl.CurrentRowIndex, 2].ToString(); //所属部门
			
			editempl.CheckBox1.Checked =dgEmpl[dgEmpl.CurrentRowIndex, 5].ToString()=="1"?true:false; //是否部门领导
			editempl.TextBox6.Text = dgEmpl[dgEmpl.CurrentRowIndex, 7].ToString(); //备注
			
			editempl.CheckBox3.Checked =dgEmpl[dgEmpl.CurrentRowIndex, 8].ToString()=="1"?true:false; //是否暂停该雇员工作
			
			editempl.frmMode = 2; //修改记录
			editempl.Text = "修改雇员信息";
			editempl.OldEmplCode =dgEmpl[dgEmpl.CurrentRowIndex, 0].ToString(); //保存原始编号
			
			editempl.ShowDialog();
			if (editempl.DialogResult == DialogResult.OK)
			{
				LoadEmplList();
			}
		}
		
		private void frmEmployee_Load(System.Object sender, System.EventArgs e)
		{
			LoadEmplList();
		}
		
		private void frmEmployee_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmEmpl = null;
		}
		
		private void dgEmpl_DoubleClick(System.Object sender, System.EventArgs e)
		{
			EditEmplInfo();
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditEmpl editempl_1 = new frmEditEmpl();
					editempl_1.GetDeptList();
					
					editempl_1.frmMode = 1; //添加记录
					editempl_1.Text = "添加雇员信息";
					
					editempl_1.ShowDialog();
					if (editempl_1.DialogResult == DialogResult.OK)
					{
						LoadEmplList();
					}
					break;
				case 1: //修改数据
					if (! (dgEmpl.CurrentRowIndex < 0))
					{
						EditEmplInfo();
					}
					break;
				case 2: //删除当前数据
					if (! (dgEmpl.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgEmpl[dgEmpl.CurrentRowIndex, 0].ToString().Trim() + " 的雇员吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//'删除操作
                            if (DelEmpl(dgEmpl[dgEmpl.CurrentRowIndex, 0].ToString()))
							{
								LoadEmplList();
							}
						}
					}
					break;
				case 4: //查询数据
					frmEditEmpl editempl = new frmEditEmpl();
					editempl.GetDeptList();
					
					editempl.frmMode = 3; //查询数据
					editempl.Text = "查询雇员信息";
					
					editempl.ShowDialog();
					if (editempl.DialogResult == DialogResult.OK)
					{
						SearchEmpl(editempl.TextBox1.Text, editempl.TextBox2.Text, editempl.ComboBox1.Text);
					}
					break;
				case 6: //打印
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentEmpLstSqlCode))
						{
							MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
						}
					}
					break;
				case 8:
					this.Close();
					break;
			}
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.employee_cr == null)
			{
				report_var.employee_cr = new ReportDocument();
			}
			else
			{
				report_var.employee_cr.Close();
				report_var.employee_cr = null;
				report_var.employee_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.employee_rpt_filename))
			{
				report_var.employee_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.employee_rpt_filename, sql, "view_Employee");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.employee_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.employee_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.employee_cr.PrintToPrinter(1, true, 1, 1);
				
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
