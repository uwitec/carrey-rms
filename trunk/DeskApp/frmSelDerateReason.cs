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
	public class frmSelDerateReason : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelDerateReason()
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
		internal System.Windows.Forms.DataGrid dgDerateReason;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSelDerateReason));
			this.Button1 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmSelDerateReason_Load);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.dgDerateReason = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.dgDerateReason).BeginInit();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(136, 192);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(216, 192);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//dgDerateReason
			//
			this.dgDerateReason.AlternatingBackColor = System.Drawing.Color.Gainsboro;
			this.dgDerateReason.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgDerateReason.BackColor = System.Drawing.Color.Silver;
			this.dgDerateReason.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgDerateReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgDerateReason.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.dgDerateReason.CaptionFont = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgDerateReason.CaptionForeColor = System.Drawing.Color.White;
			this.dgDerateReason.DataMember = "";
			this.dgDerateReason.FlatMode = true;
			this.dgDerateReason.ForeColor = System.Drawing.Color.Black;
			this.dgDerateReason.GridLineColor = System.Drawing.Color.White;
			this.dgDerateReason.HeaderBackColor = System.Drawing.Color.DarkGray;
			this.dgDerateReason.HeaderForeColor = System.Drawing.Color.Black;
			this.dgDerateReason.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.dgDerateReason.Location = new System.Drawing.Point(8, 8);
			this.dgDerateReason.Name = "dgDerateReason";
			this.dgDerateReason.ParentRowsBackColor = System.Drawing.Color.Black;
			this.dgDerateReason.ParentRowsForeColor = System.Drawing.Color.White;
			this.dgDerateReason.ReadOnly = true;
			this.dgDerateReason.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.dgDerateReason.SelectionForeColor = System.Drawing.Color.White;
			this.dgDerateReason.Size = new System.Drawing.Size(288, 176);
			this.dgDerateReason.TabIndex = 5;
			this.dgDerateReason.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgDerateReason;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2});
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "DerateRsn";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "减免编码";
			this.DataGridTextBoxColumn1.MappingName = "deratecode";
			this.DataGridTextBoxColumn1.Width = 55;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "减免原因";
			this.DataGridTextBoxColumn2.MappingName = "reason";
			this.DataGridTextBoxColumn2.Width = 170;
			//
			//frmSelDerateReason
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(304, 230);
			this.Controls.Add(this.dgDerateReason);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelDerateReason";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择减免原因";
			((System.ComponentModel.ISupportInitialize) this.dgDerateReason).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void LoadDerateRsnList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM DerateReason", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "DerateRsn");
				dgDerateReason.DataSource = null;
				dgDerateReason.DataSource = dbDS;
				dgDerateReason.DataMember = "DerateRsn";
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
		
		private void frmSelDerateReason_Load(System.Object sender, System.EventArgs e)
		{
			LoadDerateRsnList();
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
