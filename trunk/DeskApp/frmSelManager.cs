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
	public class frmSelManager : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelManager()
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
		internal System.Windows.Forms.DataGrid DataGrid1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSelManager));
			this.Button2 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmSelManager_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.DataGrid1 = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).BeginInit();
			this.SuspendLayout();
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(200, 208);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 5;
			this.Button2.Text = "取消(&C)";
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(120, 208);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 4;
			this.Button1.Text = "确定(&O)";
			//
			//DataGrid1
			//
			this.DataGrid1.AlternatingBackColor = System.Drawing.Color.Gainsboro;
			this.DataGrid1.BackColor = System.Drawing.Color.Silver;
			this.DataGrid1.BackgroundColor = System.Drawing.Color.Lavender;
			this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.DataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.0F);
			this.DataGrid1.CaptionForeColor = System.Drawing.Color.White;
			this.DataGrid1.DataMember = "";
			this.DataGrid1.FlatMode = true;
			this.DataGrid1.ForeColor = System.Drawing.Color.Black;
			this.DataGrid1.GridLineColor = System.Drawing.Color.White;
			this.DataGrid1.HeaderBackColor = System.Drawing.Color.DarkGray;
			this.DataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.DataGrid1.Location = new System.Drawing.Point(8, 8);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Black;
			this.DataGrid1.ParentRowsForeColor = System.Drawing.Color.White;
			this.DataGrid1.ReadOnly = true;
			this.DataGrid1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.DataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.DataGrid1.Size = new System.Drawing.Size(280, 192);
			this.DataGrid1.TabIndex = 3;
			this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.DataGrid1;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3});
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "manager";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "雇员编码";
			this.DataGridTextBoxColumn1.MappingName = "empid";
			this.DataGridTextBoxColumn1.Width = 55;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "姓名";
			this.DataGridTextBoxColumn2.MappingName = "name";
			this.DataGridTextBoxColumn2.Width = 80;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "所属部门";
			this.DataGridTextBoxColumn3.MappingName = "deptname";
			this.DataGridTextBoxColumn3.Width = 85;
			//
			//frmSelManager
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(296, 248);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.DataGrid1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelManager";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择批准人";
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void LoadManagerList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM view_Employee where manager='1' and disabled<>'1'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "Manager");
				DataGrid1.DataSource = null;
				DataGrid1.DataSource = dbDS;
				DataGrid1.DataMember = "Manager";
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
		
		private void frmSelManager_Load(System.Object sender, System.EventArgs e)
		{
			LoadManagerList();
		}
	}
	
}
