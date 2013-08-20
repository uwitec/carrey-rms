using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace StorageApp
{
	public class frmDeptStorageInventory : System.Windows.Forms.Form
	{
		
		public string CurrentStorageDeptName;
        public string CurrentDeptName;
		
		private DataTable SelectedMaterials;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmDeptStorageInventory()
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
		internal System.Windows.Forms.DataGrid dgMaterials;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeptStorageInventory));
            this.dgMaterials = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMaterials
            // 
            this.dgMaterials.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dgMaterials.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgMaterials.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgMaterials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgMaterials.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgMaterials.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterials.CaptionVisible = false;
            this.dgMaterials.DataMember = "";
            this.dgMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMaterials.FlatMode = true;
            this.dgMaterials.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgMaterials.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterials.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dgMaterials.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgMaterials.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterials.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgMaterials.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgMaterials.LinkColor = System.Drawing.Color.Teal;
            this.dgMaterials.Location = new System.Drawing.Point(0, 53);
            this.dgMaterials.Name = "dgMaterials";
            this.dgMaterials.ParentRowsBackColor = System.Drawing.Color.White;
            this.dgMaterials.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterials.ReadOnly = true;
            this.dgMaterials.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgMaterials.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgMaterials.Size = new System.Drawing.Size(584, 377);
            this.dgMaterials.TabIndex = 7;
            this.dgMaterials.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.DataGridTableStyle1.DataGrid = this.dgMaterials;
            this.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4,
            this.DataGridTextBoxColumn5,
            this.DataGridTextBoxColumn6});
            this.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Black;
            this.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.Silver;
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "MaterialsList";
            this.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            this.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "物品编码";
            this.DataGridTextBoxColumn1.MappingName = "materialcode";
            this.DataGridTextBoxColumn1.Width = 65;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "物品名称";
            this.DataGridTextBoxColumn2.MappingName = "materialname";
            this.DataGridTextBoxColumn2.Width = 110;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "单位";
            this.DataGridTextBoxColumn3.MappingName = "unit";
            this.DataGridTextBoxColumn3.Width = 50;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "数量";
            this.DataGridTextBoxColumn4.MappingName = "quantity";
            this.DataGridTextBoxColumn4.Width = 60;
            // 
            // DataGridTextBoxColumn5
            // 
            this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn5.Format = "";
            this.DataGridTextBoxColumn5.FormatInfo = null;
            this.DataGridTextBoxColumn5.HeaderText = "单价";
            this.DataGridTextBoxColumn5.MappingName = "price";
            this.DataGridTextBoxColumn5.Width = 75;
            // 
            // DataGridTextBoxColumn6
            // 
            this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn6.Format = "";
            this.DataGridTextBoxColumn6.FormatInfo = null;
            this.DataGridTextBoxColumn6.HeaderText = "合计";
            this.DataGridTextBoxColumn6.MappingName = "totalprice";
            this.DataGridTextBoxColumn6.Width = 90;
            // 
            // ToolBar1
            // 
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton3,
            this.ToolBarButton2,
            this.ToolBarButton4,
            this.ToolBarButton5,
            this.ToolBarButton6,
            this.ToolBarButton7});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(584, 53);
            this.ToolBar1.TabIndex = 6;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "添加";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 1;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "删除";
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.ImageIndex = 2;
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Text = "保存";
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
            this.ToolBarButton5.Text = "打印";
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 4;
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Text = "关闭";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            // 
            // frmDeptStorageInventory
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(584, 430);
            this.Controls.Add(this.dgMaterials);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeptStorageInventory";
            this.Text = "部门期初建账";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closed += new System.EventHandler(this.frmDeptStorageInventory_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		public void init()
		{
			if (SelectedMaterials == null)
			{
				SelectedMaterials = new DataTable();
			}
			else
			{
				SelectedMaterials.Rows.Clear();
			}
			SelectedMaterials = LoadMaterialsInventory();
			dgMaterials.DataSource = SelectedMaterials;
			string startdate;
			startdate = rms_var.GetSysSetup("begindate");
			if (startdate != "") //已启用库存管理
			{
				ToolBar1.Buttons[0].Enabled = false;
				ToolBar1.Buttons[1].Enabled = false;
				ToolBar1.Buttons[2].Enabled = false;
			}
		}
		
		//返回当前部门物品仓库盘存记录
		private DataTable LoadMaterialsInventory()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT MaterialCode,MaterialName,Unit,Quantity,totalprice/quantity as Price,totalprice FROM view_SecStorage_Inventory " + "where deptname='" + CurrentStorageDeptName + "' and yearmonth='" + rms_var.GetSysSetup("Begindate") + "' and depcode2='" + rms_var.GetDeptCode(CurrentDeptName) + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "MaterialsList");
				//检测是否存在记录 若有 禁止添加与删除
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					ToolBar1.Buttons[0].Enabled = false;
					ToolBar1.Buttons[1].Enabled = false;
					ToolBar1.Buttons[2].Enabled = false;
				}
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		//保存单据物品记录
		private bool SaveMaterials(string yearmonth)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "delete from secstorage_inventory where yearmonth='" + yearmonth + "' and depcode='" + rms_var.GetDeptCode(CurrentDeptName) + "'";
				selectCMD.ExecuteNonQuery();
				for (int i = 0; i <= dgMaterials.VisibleRowCount - 1; i++)
				{
					selectCMD.CommandText = "insert into secstorage_inventory (yearmonth,MaterialCode,Quantity,Price,totalprice,depcode) " + "values (" + "'" + yearmonth + "'" + "," + "'" + dgMaterials[i, 0] + "'" + "," + dgMaterials[i, 3].ToString() + "," + dgMaterials[i, 4].ToString() + "," + dgMaterials[i, 5].ToString() + "," + "'" + rms_var.GetDeptCode(CurrentDeptName) + "'" + ")";
					
					selectCMD.ExecuteNonQuery();
				}
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
		
		//删除物品
		private bool DeleteMaterial(string materialcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "delete from secstorage_inventory where materialcode='" + materialcode + "' and yearmonth='" + rms_var.GetSysSetup("Begindate") + "' and depcode='" + rms_var.GetDeptCode(CurrentDeptName) + "'";
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
		
		private void frmDeptStorageInventory_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmDeptStorageInvent = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0:
					frmSelMaterial frmselmtrl = new frmSelMaterial();
					frmselmtrl.CurrentStorageDeptName = CurrentStorageDeptName;
					frmselmtrl.CreateSelectedMaterialsTable();
					frmselmtrl.ShowDialog();
					if (frmselmtrl.DialogResult == DialogResult.OK)
					{
						if (frmselmtrl.dgSelMaterials.VisibleRowCount > 0)
						{
							DataRowCollection rc;
							DataRow myNewRow;
							object[] rowVals = new object[6];
							for (int i = 0; i <= frmselmtrl.SelectedMaterials.Rows.Count - 1; i++)
							{
								rc = SelectedMaterials.Rows;
								rowVals[0] = frmselmtrl.SelectedMaterials.Rows[i][0];
								rowVals[1] = frmselmtrl.SelectedMaterials.Rows[i][1];
								rowVals[2] = frmselmtrl.SelectedMaterials.Rows[i][2];
								rowVals[3] = frmselmtrl.SelectedMaterials.Rows[i][3];
								rowVals[4] = frmselmtrl.SelectedMaterials.Rows[i][4];
								rowVals[5] = frmselmtrl.SelectedMaterials.Rows[i][5];
								myNewRow = rc.Add(rowVals);
							}
							dgMaterials.DataSource = SelectedMaterials;
						}
					}
					break;
				case 1:
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (MessageBox.Show("确定要删除当前选中的物品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
                            if (DeleteMaterial(dgMaterials[dgMaterials.CurrentRowIndex, 0].ToString()))
							{
								MessageBox.Show("删除成功");
								//获取物品记录
								SelectedMaterials = LoadMaterialsInventory();
								dgMaterials.DataSource = SelectedMaterials;
							}
						}
					}
					break;
				case 2:
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (SaveMaterials(DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString()))
						{
							MessageBox.Show("单据保存成功");
						}
					}
					break;
					
				case 6:
					this.Close();
					break;
			}
		}
	}
	
}
