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
	public class frmMaterialType : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmMaterialType()
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ComboBox cbStorageDept;
		internal System.Windows.Forms.DataGrid dgMaterialType;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialType));
            this.cbStorageDept = new System.Windows.Forms.ComboBox();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.dgMaterialType = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialType)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStorageDept
            // 
            this.cbStorageDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStorageDept.Location = new System.Drawing.Point(96, 64);
            this.cbStorageDept.Name = "cbStorageDept";
            this.cbStorageDept.Size = new System.Drawing.Size(136, 20);
            this.cbStorageDept.TabIndex = 1;
            this.cbStorageDept.SelectedIndexChanged += new System.EventHandler(this.cbStorageDept_SelectedIndexChanged);
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
            this.ToolBar1.Size = new System.Drawing.Size(456, 54);
            this.ToolBar1.TabIndex = 2;
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
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 23);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "选择仓库部门：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgMaterialType
            // 
            this.dgMaterialType.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMaterialType.BackColor = System.Drawing.Color.GhostWhite;
            this.dgMaterialType.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgMaterialType.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgMaterialType.CaptionForeColor = System.Drawing.Color.White;
            this.dgMaterialType.DataMember = "";
            this.dgMaterialType.FlatMode = true;
            this.dgMaterialType.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgMaterialType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterialType.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgMaterialType.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterialType.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgMaterialType.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgMaterialType.LinkColor = System.Drawing.Color.Teal;
            this.dgMaterialType.Location = new System.Drawing.Point(0, 88);
            this.dgMaterialType.Name = "dgMaterialType";
            this.dgMaterialType.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgMaterialType.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterialType.ReadOnly = true;
            this.dgMaterialType.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgMaterialType.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgMaterialType.Size = new System.Drawing.Size(456, 294);
            this.dgMaterialType.TabIndex = 0;
            this.dgMaterialType.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgMaterialType.DoubleClick += new System.EventHandler(this.dgMaterialType_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgMaterialType;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridBoolColumn1});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "MaterialTypeList";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "类别编码";
            this.DataGridTextBoxColumn1.MappingName = "materialtypecode";
            this.DataGridTextBoxColumn1.Width = 90;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "类别名称";
            this.DataGridTextBoxColumn2.MappingName = "name";
            this.DataGridTextBoxColumn2.Width = 90;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "归属部门编码";
            this.DataGridTextBoxColumn3.MappingName = "depcode";
            this.DataGridTextBoxColumn3.Width = 80;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "属于原料";
            this.DataGridBoolColumn1.MappingName = "issalecost";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 90;
            // 
            // frmMaterialType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(456, 382);
            this.Controls.Add(this.dgMaterialType);
            this.Controls.Add(this.cbStorageDept);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterialType";
            this.Text = "物品类别";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaterialType_Load);
            this.Closed += new System.EventHandler(this.frmMaterialType_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回物品类别记录
		private void LoadMaterialType(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (deptname == "全部")
				{
					selectCMD.CommandText = "SELECT * FROM materialtype";
				}
				else
				{
					selectCMD.CommandText = "SELECT * FROM materialtype where depcode='" + rms_var.GetDeptCode(deptname) + "'";
				}
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "MaterialTypeList");
				dgMaterialType.DataSource = null;
				dgMaterialType.DataSource = dbDS;
				dgMaterialType.DataMember = "MaterialTypeList";
				
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
			frmEditMaterialType frmemt = new frmEditMaterialType();
			DataTable strgdept;
			strgdept = rms_var.LoadStorageDept();
			for (int i = 0; i <= strgdept.Rows.Count - 1; i++)
			{
				frmemt.ComboBox1.Items.Add(strgdept.Rows[i]["DeptName"]);
			}
			frmemt.frmMode = 0; //add
			frmemt.OldMaterialTypeCode =dgMaterialType[dgMaterialType.CurrentRowIndex, 0].ToString();
			frmemt.OldMaterialTypeName = dgMaterialType[dgMaterialType.CurrentRowIndex, 1].ToString();
			frmemt.TextBox1.Text = dgMaterialType[dgMaterialType.CurrentRowIndex, 0].ToString();
			frmemt.TextBox2.Text = dgMaterialType[dgMaterialType.CurrentRowIndex, 1].ToString();
			frmemt.ComboBox1.Text = rms_var.GetDeptName(dgMaterialType[dgMaterialType.CurrentRowIndex, 2].ToString());
			if (dgMaterialType[dgMaterialType.CurrentRowIndex, 3].ToString() == "1")
			{
				frmemt.CheckBox1.Checked = true;
			}
			else
			{
				frmemt.CheckBox1.Checked = false;
			}
			frmemt.Text = "编辑物品类别";
			frmemt.ShowDialog();
			if (frmemt.DialogResult == DialogResult.OK)
			{
				LoadMaterialType(cbStorageDept.Text);
			}
		}
		
		//删除类别
		private bool DelMaterialType(string materialtypecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select count(*) from materials  where materialtypecode='" + materialtypecode + "'";
				dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (int.Parse(dbDS.Tables[0].Rows[0][0].ToString())> 0) //存在属于该部门的雇员记录
				{
					MessageBox.Show("有属于该类别的物品，不能执行删除操作");
					return false;
				}
				else
				{
					
					selectCMD.CommandText = "delete from materialtype where materialtypecode='" + materialtypecode + "'";
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
		
		private void frmMaterialType_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmMaterTyp = null;
		}
		
		private void frmMaterialType_Load(System.Object sender, System.EventArgs e)
		{
			DataTable strgdept;
			strgdept = rms_var.LoadStorageDept();
			for (int i = 0; i <= strgdept.Rows.Count - 1; i++)
			{
				cbStorageDept.Items.Add(strgdept.Rows[i]["DeptName"]);
			}
			if (rms_var.TheAppExt.Chk_Kc_Wlgl && rms_var.TheAppExt.Chk_Kc_Ylgl)
			{
				cbStorageDept.Items.Add("全部");
			}
			
			cbStorageDept.SelectedIndex = 0;
		}
		
		private void cbStorageDept_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			LoadMaterialType(cbStorageDept.Text);
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditMaterialType frmemt = new frmEditMaterialType();
					frmemt.frmMode = 1; //add
					DataTable strgdept;
					strgdept = rms_var.LoadStorageDept();
					for (int i = 0; i <= strgdept.Rows.Count - 1; i++)
					{
						frmemt.ComboBox1.Items.Add(strgdept.Rows[i]["DeptName"]);
					}
                    if (frmemt.ComboBox1.Items.Count > 0)
                    {
                        frmemt.ComboBox1.SelectedIndex = 0;
                    }
					frmemt.Text = "添加物品类别";
					frmemt.ShowDialog();
                    if (frmemt.DialogResult == DialogResult.OK)
                    {
					    LoadMaterialType(cbStorageDept.Text);
                    }
					break;
				case 1: //修改数据
					EditData();
					break;
				case 2: //删除当前数据
					if (MessageBox.Show("确定要删除当前选中的编号为 " + dgMaterialType[dgMaterialType.CurrentRowIndex, 0].ToString().Trim()+ " 的物品类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (DelMaterialType(dgMaterialType[dgMaterialType.CurrentRowIndex, 0].ToString()))
						{
							LoadMaterialType(cbStorageDept.Text);
						}
					}
					break;
					
				case 4:
					this.Close();
					break;
			}
		}
		
		private void dgMaterialType_DoubleClick(object sender, System.EventArgs e)
		{
			EditData();
		}
	}
	
}
