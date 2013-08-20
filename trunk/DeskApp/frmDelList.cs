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
	public class frmDelList : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmDelList()
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
		internal System.Windows.Forms.DataGrid DataGrid1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.DataGrid1 = new System.Windows.Forms.DataGrid();
			base.Load += new System.EventHandler(frmDelList_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).BeginInit();
			this.SuspendLayout();
			//
			//DataGrid1
			//
			this.DataGrid1.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGrid1.DataMember = "";
			this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGrid1.Location = new System.Drawing.Point(8, 8);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.ReadOnly = true;
			this.DataGrid1.Size = new System.Drawing.Size(736, 512);
			this.DataGrid1.TabIndex = 0;
			this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(648, 528);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定";
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.DataGrid1;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5});
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "dlst";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "删除日期";
			this.DataGridTextBoxColumn1.MappingName = "DeleteDate";
			this.DataGridTextBoxColumn1.Width = 120;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "操作员ID";
			this.DataGridTextBoxColumn2.MappingName = "DeleteOp";
			this.DataGridTextBoxColumn2.Width = 75;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "删除操作";
			this.DataGridTextBoxColumn3.MappingName = "DeleteType";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "原因";
			this.DataGridTextBoxColumn4.MappingName = "DeleteRsn";
			this.DataGridTextBoxColumn4.Width = 300;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "内容";
			this.DataGridTextBoxColumn5.MappingName = "DeleteContent";
			this.DataGridTextBoxColumn5.Width = 400;
			//
			//frmDelList
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(752, 566);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.DataGrid1);
			this.Name = "frmDelList";
			this.Text = "删除操作记录";
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void LoadDelLogData()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM dlst order by deletedate";
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "dlst");
				DataGrid1.DataSource = null;
				DataGrid1.DataSource = dbDS;
				DataGrid1.DataMember = "dlst";
				
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
		
		private void frmDelList_Load(System.Object sender, System.EventArgs e)
		{
			LoadDelLogData();
		}
	}
	
}
