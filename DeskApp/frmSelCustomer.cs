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
	public class frmSelCustomer : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelCustomer()
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
		internal System.Windows.Forms.DataGrid dgCustomer;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSelCustomer));
			this.Button2 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmSelCustomer_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.dgCustomer = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.dgCustomer).BeginInit();
			this.SuspendLayout();
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(216, 192);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 8;
			this.Button2.Text = "取消(&C)";
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(136, 192);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 7;
			this.Button1.Text = "确定(&O)";
			//
			//dgCustomer
			//
			this.dgCustomer.AlternatingBackColor = System.Drawing.Color.Gainsboro;
			this.dgCustomer.BackColor = System.Drawing.Color.Silver;
			this.dgCustomer.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgCustomer.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.dgCustomer.CaptionFont = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgCustomer.CaptionForeColor = System.Drawing.Color.White;
			this.dgCustomer.DataMember = "";
			this.dgCustomer.FlatMode = true;
			this.dgCustomer.ForeColor = System.Drawing.Color.Black;
			this.dgCustomer.GridLineColor = System.Drawing.Color.White;
			this.dgCustomer.HeaderBackColor = System.Drawing.Color.DarkGray;
			this.dgCustomer.HeaderForeColor = System.Drawing.Color.Black;
			this.dgCustomer.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.dgCustomer.Location = new System.Drawing.Point(8, 8);
			this.dgCustomer.Name = "dgCustomer";
			this.dgCustomer.ParentRowsBackColor = System.Drawing.Color.Black;
			this.dgCustomer.ParentRowsForeColor = System.Drawing.Color.White;
			this.dgCustomer.ReadOnly = true;
			this.dgCustomer.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.dgCustomer.SelectionForeColor = System.Drawing.Color.White;
			this.dgCustomer.Size = new System.Drawing.Size(296, 176);
			this.dgCustomer.TabIndex = 9;
			this.dgCustomer.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgCustomer;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "customer";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "客户编码";
			this.DataGridTextBoxColumn1.MappingName = "customercode";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "客户名称";
			this.DataGridTextBoxColumn2.MappingName = "customername";
			this.DataGridTextBoxColumn2.Width = 90;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "签单数量";
			this.DataGridTextBoxColumn3.MappingName = "signed";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//frmSelCustomer
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(312, 230);
			this.Controls.Add(this.dgCustomer);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelCustomer";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择客户";
			((System.ComponentModel.ISupportInitialize) this.dgCustomer).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void LoadCustomerList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT customercode,customername,signed FROM customer where disabled<>'1'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "Customer");
				dgCustomer.DataSource = null;
				dgCustomer.DataSource = dbDS;
				dgCustomer.DataMember = "Customer";
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
		
		private void frmSelCustomer_Load(System.Object sender, System.EventArgs e)
		{
			LoadCustomerList();
		}
	}
	
}
