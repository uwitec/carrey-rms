using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace StorageApp
{
	public class frmPayVendor : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmPayVendor()
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

        private System.ComponentModel.IContainer components;

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.DataGrid dgPayVendor;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayVendor));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgPayVendor = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton3,
            this.ToolBarButton10});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(589, 54);
            this.ToolBar1.TabIndex = 2;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "新增";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton10
            // 
            this.ToolBarButton10.ImageIndex = 1;
            this.ToolBarButton10.Name = "ToolBarButton10";
            this.ToolBarButton10.Text = "关闭";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            // 
            // dgPayVendor
            // 
            this.dgPayVendor.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dgPayVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPayVendor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgPayVendor.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgPayVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgPayVendor.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgPayVendor.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgPayVendor.CaptionVisible = false;
            this.dgPayVendor.DataMember = "";
            this.dgPayVendor.FlatMode = true;
            this.dgPayVendor.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgPayVendor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgPayVendor.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dgPayVendor.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgPayVendor.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgPayVendor.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPayVendor.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgPayVendor.LinkColor = System.Drawing.Color.Teal;
            this.dgPayVendor.Location = new System.Drawing.Point(0, 56);
            this.dgPayVendor.Name = "dgPayVendor";
            this.dgPayVendor.ParentRowsBackColor = System.Drawing.Color.White;
            this.dgPayVendor.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgPayVendor.ReadOnly = true;
            this.dgPayVendor.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgPayVendor.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgPayVendor.Size = new System.Drawing.Size(589, 343);
            this.dgPayVendor.TabIndex = 4;
            this.dgPayVendor.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.DataGridTableStyle1.DataGrid = this.dgPayVendor;
            this.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4,
            this.DataGridTextBoxColumn5,
            this.DataGridTextBoxColumn6,
            this.DataGridTextBoxColumn8});
            this.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Black;
            this.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.Silver;
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "PayList";
            this.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            this.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "单据号";
            this.DataGridTextBoxColumn1.MappingName = "billno";
            this.DataGridTextBoxColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "供应商名称";
            this.DataGridTextBoxColumn2.MappingName = "vendorname";
            this.DataGridTextBoxColumn2.Width = 120;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "支付时间";
            this.DataGridTextBoxColumn3.MappingName = "payedtime";
            this.DataGridTextBoxColumn3.Width = 90;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "支付金额";
            this.DataGridTextBoxColumn4.MappingName = "cost";
            this.DataGridTextBoxColumn4.Width = 75;
            // 
            // DataGridTextBoxColumn5
            // 
            this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn5.Format = "";
            this.DataGridTextBoxColumn5.FormatInfo = null;
            this.DataGridTextBoxColumn5.HeaderText = "备注";
            this.DataGridTextBoxColumn5.MappingName = "note";
            this.DataGridTextBoxColumn5.Width = 90;
            // 
            // DataGridTextBoxColumn6
            // 
            this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn6.Format = "";
            this.DataGridTextBoxColumn6.FormatInfo = null;
            this.DataGridTextBoxColumn6.HeaderText = "操作员";
            this.DataGridTextBoxColumn6.MappingName = "operator";
            this.DataGridTextBoxColumn6.Width = 75;
            // 
            // DataGridTextBoxColumn8
            // 
            this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn8.Format = "";
            this.DataGridTextBoxColumn8.FormatInfo = null;
            this.DataGridTextBoxColumn8.MappingName = "审核人";
            this.DataGridTextBoxColumn8.Width = 75;
            // 
            // DataGridTextBoxColumn7
            // 
            this.DataGridTextBoxColumn7.Format = "";
            this.DataGridTextBoxColumn7.FormatInfo = null;
            this.DataGridTextBoxColumn7.MappingName = "checkman";
            this.DataGridTextBoxColumn7.Width = 75;
            // 
            // frmPayVendor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(589, 399);
            this.Controls.Add(this.dgPayVendor);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayVendor";
            this.Text = "付款单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPayVendor_Load);
            this.Closed += new System.EventHandler(this.frmPayVendor_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private void LoadPayVendor()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM view_PayVendor order by payedtime";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "PayList");
				dgPayVendor.DataSource = dbDS;
				dgPayVendor.DataMember = "PayList";
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
		
		private void frmPayVendor_Load(System.Object sender, System.EventArgs e)
		{
			LoadPayVendor();
		}
		
		private void frmPayVendor_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmPayVD = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0:
					frmAddPayVendor frmadv = new frmAddPayVendor();
					frmadv.frmmode = 0;
					frmadv.ShowDialog();
					if (frmadv.DialogResult == DialogResult.OK)
					{
						LoadPayVendor();
					}
					break;
				case 2:
					this.Close();
					break;
					
			}
		}
	}
	
}
