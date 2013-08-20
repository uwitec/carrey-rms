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
	public class frmCancelRsn : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCancelRsn()
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
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.DataGrid dgCancelReason;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCancelRsn));
			this.dgCancelReason = new System.Windows.Forms.DataGrid();
			base.Load += new System.EventHandler(frmCancelRsn_Load);
			this.dgCancelReason.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dgCancelReason_Navigate);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) this.dgCancelReason).BeginInit();
			this.SuspendLayout();
			//
			//dgCancelReason
			//
			this.dgCancelReason.AlternatingBackColor = System.Drawing.Color.Gainsboro;
			this.dgCancelReason.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgCancelReason.BackColor = System.Drawing.Color.Silver;
			this.dgCancelReason.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgCancelReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgCancelReason.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.dgCancelReason.CaptionFont = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgCancelReason.CaptionForeColor = System.Drawing.Color.White;
			this.dgCancelReason.DataMember = "";
			this.dgCancelReason.FlatMode = true;
			this.dgCancelReason.ForeColor = System.Drawing.Color.Black;
			this.dgCancelReason.GridLineColor = System.Drawing.Color.White;
			this.dgCancelReason.HeaderBackColor = System.Drawing.Color.DarkGray;
			this.dgCancelReason.HeaderForeColor = System.Drawing.Color.Black;
			this.dgCancelReason.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.dgCancelReason.Location = new System.Drawing.Point(8, 8);
			this.dgCancelReason.Name = "dgCancelReason";
			this.dgCancelReason.ParentRowsBackColor = System.Drawing.Color.Black;
			this.dgCancelReason.ParentRowsForeColor = System.Drawing.Color.White;
			this.dgCancelReason.ReadOnly = true;
			this.dgCancelReason.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.dgCancelReason.SelectionForeColor = System.Drawing.Color.White;
			this.dgCancelReason.Size = new System.Drawing.Size(320, 184);
			this.dgCancelReason.TabIndex = 4;
			this.dgCancelReason.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgCancelReason;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "CancelReason";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "取消编码";
			this.DataGridTextBoxColumn1.MappingName = "cancelcode";
			this.DataGridTextBoxColumn1.Width = 55;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "取消原因";
			this.DataGridTextBoxColumn2.MappingName = "reason";
			this.DataGridTextBoxColumn2.Width = 200;
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(160, 200);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 5;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(240, 200);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 6;
			this.Button2.Text = "取消(&C)";
			//
			//frmCancelRsn
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(336, 238);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgCancelReason);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCancelRsn";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择取消原因";
			((System.ComponentModel.ISupportInitialize) this.dgCancelReason).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回取消列表
		private void LoadCancelList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM CancelReason", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "CancelReason");
				dgCancelReason.DataSource = null;
				dgCancelReason.DataSource = dbDS;
				dgCancelReason.DataMember = "CancelReason";
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
		
		private void frmCancelRsn_Load(System.Object sender, System.EventArgs e)
		{
			LoadCancelList();
		}
		
		private void dgCancelReason_Navigate(System.Object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}
	}
	
}
