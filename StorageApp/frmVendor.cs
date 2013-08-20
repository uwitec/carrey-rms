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
	public class frmVendor : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmVendor()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.DataGrid dgVendor;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendor));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgVendor = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton5});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(528, 54);
            this.ToolBar1.TabIndex = 3;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "添加";
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.ImageIndex = 1;
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Text = "修改";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 2;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "删除";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.ImageIndex = 3;
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Text = "关闭";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            // 
            // dgVendor
            // 
            this.dgVendor.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVendor.BackColor = System.Drawing.Color.GhostWhite;
            this.dgVendor.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgVendor.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgVendor.CaptionForeColor = System.Drawing.Color.White;
            this.dgVendor.DataMember = "";
            this.dgVendor.FlatMode = true;
            this.dgVendor.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgVendor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgVendor.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgVendor.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgVendor.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgVendor.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgVendor.LinkColor = System.Drawing.Color.Teal;
            this.dgVendor.Location = new System.Drawing.Point(0, 56);
            this.dgVendor.Name = "dgVendor";
            this.dgVendor.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgVendor.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgVendor.ReadOnly = true;
            this.dgVendor.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgVendor.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgVendor.Size = new System.Drawing.Size(528, 342);
            this.dgVendor.TabIndex = 4;
            this.dgVendor.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgVendor.DoubleClick += new System.EventHandler(this.dgVendor_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgVendor;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4,
            this.DataGridBoolColumn1});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "vendor";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "供应商编码";
            this.DataGridTextBoxColumn1.MappingName = "vendorcode";
            this.DataGridTextBoxColumn1.Width = 90;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "名称";
            this.DataGridTextBoxColumn2.MappingName = "vendorname";
            this.DataGridTextBoxColumn2.Width = 90;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "联系人";
            this.DataGridTextBoxColumn3.MappingName = "AttachMan";
            this.DataGridTextBoxColumn3.Width = 90;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "联系电话";
            this.DataGridTextBoxColumn4.MappingName = "Telephone";
            this.DataGridTextBoxColumn4.Width = 90;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "暂停使用";
            this.DataGridBoolColumn1.MappingName = "disabled";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 75;
            // 
            // frmVendor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(528, 398);
            this.Controls.Add(this.dgVendor);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendor";
            this.Text = "供应商";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendor_Load);
            this.Closed += new System.EventHandler(this.frmVendor_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回供应商记录
		private void LoadVendor()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM vendor";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "vendor");
				dgVendor.DataSource = null;
				dgVendor.DataSource = dbDS;
				dgVendor.DataMember = "vendor";
				
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
		
		//编辑物品类别
		private void EditData()
		{
			frmEditVendor frmev = new frmEditVendor();
			frmev.frmMode = 2;
			frmev.OldVendorCode = dgVendor[dgVendor.CurrentRowIndex, 0].ToString();
			frmev.TextBox1.Text = dgVendor[dgVendor.CurrentRowIndex, 0].ToString();
			frmev.TextBox2.Text = dgVendor[dgVendor.CurrentRowIndex, 1].ToString();
			frmev.TextBox3.Text = dgVendor[dgVendor.CurrentRowIndex, 2].ToString();
            frmev.TextBox4.Text = dgVendor[dgVendor.CurrentRowIndex, 3].ToString();
			if (dgVendor[dgVendor.CurrentRowIndex, 4].ToString() == "1")
			{
				frmev.CheckBox1.Checked = true;
			}
			else
			{
				frmev.CheckBox1.Checked = false;
			}
			frmev.Text = "编辑供应商";
			frmev.ShowDialog();
			if (frmev.DialogResult == DialogResult.OK)
			{
				LoadVendor();
			}
		}
		
		//删除类别
		private bool DelVendor(string vendorcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select count(*) from instoragebill where vendorcode='" + vendorcode + "'";
				dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (int.Parse(dbDS.Tables[0].Rows[0][0].ToString()) > 0) //存在记录
				{
					MessageBox.Show("有属于该供应商的入库单，不能执行删除操作");
					return false;
				}
				else
				{
					
					selectCMD.CommandText = "delete from vendor where vendorcode='" + vendorcode + "'";
					selectCMD.CommandTimeout = 30;
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
		
		private void frmVendor_Load(System.Object sender, System.EventArgs e)
		{
			LoadVendor();
		}
		
		private void frmVendor_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmVndor = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditVendor frmev = new frmEditVendor();
					frmev.frmMode = 1; //add
					frmev.Text = "添加供应商";
					frmev.ShowDialog();
					if (frmev.DialogResult == DialogResult.OK)
					{
						LoadVendor();
					}
					break;
				case 1: //修改数据
					EditData();
					break;
				case 2: //删除当前数据
					if (MessageBox.Show("确定要删除当前选中的编号为 " + dgVendor[dgVendor.CurrentRowIndex, 0].ToString().Trim() + " 的供应商吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
                        if (DelVendor(dgVendor[dgVendor.CurrentRowIndex, 0].ToString()))
						{
							LoadVendor();
						}
					}
					break;
					
				case 4:
					this.Close();
					break;
			}
		}
		
		private void dgVendor_DoubleClick(object sender, System.EventArgs e)
		{
			EditData();
		}
	}
	
}
