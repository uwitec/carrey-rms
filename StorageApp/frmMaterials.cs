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


namespace StorageApp
{
	public class frmMaterials : System.Windows.Forms.Form
	{
		
		private string CurrentMatrlLstSqlCode = "SELECT * FROM view_Materials ";
		private string CurrentSqlWhereCode = "";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmMaterials()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.DataGrid dgMaterial;
		internal System.Windows.Forms.ComboBox cbStorageDept;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterials));
            this.dgMaterial = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbStorageDept = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMaterial
            // 
            this.dgMaterial.AllowNavigation = false;
            this.dgMaterial.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMaterial.BackColor = System.Drawing.Color.GhostWhite;
            this.dgMaterial.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgMaterial.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgMaterial.CaptionForeColor = System.Drawing.Color.White;
            this.dgMaterial.CausesValidation = false;
            this.dgMaterial.DataMember = "";
            this.dgMaterial.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgMaterial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterial.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgMaterial.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterial.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgMaterial.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgMaterial.LinkColor = System.Drawing.Color.Teal;
            this.dgMaterial.Location = new System.Drawing.Point(0, 88);
            this.dgMaterial.Name = "dgMaterial";
            this.dgMaterial.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgMaterial.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgMaterial.ReadOnly = true;
            this.dgMaterial.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgMaterial.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgMaterial.Size = new System.Drawing.Size(608, 376);
            this.dgMaterial.TabIndex = 4;
            this.dgMaterial.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgMaterial.DoubleClick += new System.EventHandler(this.dgMaterial_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgMaterial;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4,
            this.DataGridTextBoxColumn5,
            this.DataGridTextBoxColumn6,
            this.DataGridBoolColumn1,
            this.DataGridTextBoxColumn7,
            this.DataGridTextBoxColumn8,
            this.DataGridTextBoxColumn9,
            this.DataGridTextBoxColumn10,
            this.DataGridTextBoxColumn11,
            this.DataGridTextBoxColumn12});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "MaterialsList";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "物品编码";
            this.DataGridTextBoxColumn1.MappingName = "materialcode";
            this.DataGridTextBoxColumn1.Width = 75;
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
            this.DataGridTextBoxColumn3.HeaderText = "型号";
            this.DataGridTextBoxColumn3.MappingName = "type";
            this.DataGridTextBoxColumn3.NullText = "";
            this.DataGridTextBoxColumn3.Width = 90;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "单位";
            this.DataGridTextBoxColumn4.MappingName = "unit";
            this.DataGridTextBoxColumn4.Width = 75;
            // 
            // DataGridTextBoxColumn5
            // 
            this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn5.Format = "";
            this.DataGridTextBoxColumn5.FormatInfo = null;
            this.DataGridTextBoxColumn5.MappingName = "materialtypecode";
            this.DataGridTextBoxColumn5.Width = 0;
            // 
            // DataGridTextBoxColumn6
            // 
            this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn6.Format = "";
            this.DataGridTextBoxColumn6.FormatInfo = null;
            this.DataGridTextBoxColumn6.HeaderText = "物品类别";
            this.DataGridTextBoxColumn6.MappingName = "name";
            this.DataGridTextBoxColumn6.Width = 90;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "属于原料";
            this.DataGridBoolColumn1.MappingName = "issalecost";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn7
            // 
            this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn7.Format = "";
            this.DataGridTextBoxColumn7.FormatInfo = null;
            this.DataGridTextBoxColumn7.MappingName = "depcode";
            this.DataGridTextBoxColumn7.Width = 0;
            // 
            // DataGridTextBoxColumn8
            // 
            this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn8.Format = "";
            this.DataGridTextBoxColumn8.FormatInfo = null;
            this.DataGridTextBoxColumn8.HeaderText = "所属部门";
            this.DataGridTextBoxColumn8.MappingName = "deptname";
            this.DataGridTextBoxColumn8.Width = 75;
            // 
            // DataGridTextBoxColumn9
            // 
            this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn9.Format = "";
            this.DataGridTextBoxColumn9.FormatInfo = null;
            this.DataGridTextBoxColumn9.HeaderText = "拼音码";
            this.DataGridTextBoxColumn9.MappingName = "spell";
            this.DataGridTextBoxColumn9.Width = 75;
            // 
            // DataGridTextBoxColumn10
            // 
            this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn10.Format = "";
            this.DataGridTextBoxColumn10.FormatInfo = null;
            this.DataGridTextBoxColumn10.HeaderText = "部门月领用限额";
            this.DataGridTextBoxColumn10.MappingName = "limitedqty";
            this.DataGridTextBoxColumn10.Width = 90;
            // 
            // DataGridTextBoxColumn11
            // 
            this.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn11.Format = "";
            this.DataGridTextBoxColumn11.FormatInfo = null;
            this.DataGridTextBoxColumn11.HeaderText = "库存上限";
            this.DataGridTextBoxColumn11.MappingName = "upperqty";
            this.DataGridTextBoxColumn11.Width = 90;
            // 
            // DataGridTextBoxColumn12
            // 
            this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn12.Format = "";
            this.DataGridTextBoxColumn12.FormatInfo = null;
            this.DataGridTextBoxColumn12.HeaderText = "库存下限";
            this.DataGridTextBoxColumn12.MappingName = "lowerqty";
            this.DataGridTextBoxColumn12.Width = 90;
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton5,
            this.ToolBarButton6,
            this.ToolBarButton7,
            this.ToolBarButton8,
            this.ToolBarButton9});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(608, 54);
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
            this.ToolBarButton5.Text = "查询";
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
            this.ToolBarButton7.Text = "打印";
            // 
            // ToolBarButton8
            // 
            this.ToolBarButton8.Name = "ToolBarButton8";
            this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton9
            // 
            this.ToolBarButton9.ImageIndex = 5;
            this.ToolBarButton9.Name = "ToolBarButton9";
            this.ToolBarButton9.Text = "关闭";
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
            this.ImageList1.Images.SetKeyName(5, "");
            // 
            // cbStorageDept
            // 
            this.cbStorageDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStorageDept.Location = new System.Drawing.Point(104, 65);
            this.cbStorageDept.Name = "cbStorageDept";
            this.cbStorageDept.Size = new System.Drawing.Size(128, 20);
            this.cbStorageDept.TabIndex = 5;
            this.cbStorageDept.SelectedIndexChanged += new System.EventHandler(this.cbMaterialType_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "选择仓库部门：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMaterials
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(608, 470);
            this.Controls.Add(this.cbStorageDept);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgMaterial);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterials";
            this.Text = "物品列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaterials_Load);
            this.Closed += new System.EventHandler(this.frmMaterials_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回物品记录
		private void LoadMaterials(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (deptname != "全部")
				{
					CurrentSqlWhereCode = "where deptname ='" + deptname + "'";
				}
				else
				{
					CurrentSqlWhereCode = "";
				}
				
				selectCMD.CommandText = CurrentMatrlLstSqlCode + CurrentSqlWhereCode + " order by materialcode";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "MaterialsList");
				dgMaterial.DataSource = null;
				dgMaterial.DataSource = dbDS;
				dgMaterial.DataMember = "MaterialsList";
				
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
		
		//编辑物品
		private void EditData()
		{
			frmEditMaterial frmem = new frmEditMaterial();
			DataTable tlbmaterialtype;
			tlbmaterialtype = rms_var.LoadMaterialType(cbStorageDept.Text);
			for (int i = 0; i <= tlbmaterialtype.Rows.Count - 1; i++)
			{
				frmem.ComboBox1.Items.Add(tlbmaterialtype.Rows[i]["Name"]);
			}
			frmem.frmMode = 2;
			frmem.OldMaterialCode =dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString();
			frmem.OldMaterialName =dgMaterial[dgMaterial.CurrentRowIndex, 1].ToString();
			frmem.TextBox1.Text = dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString();
			frmem.TextBox2.Text = dgMaterial[dgMaterial.CurrentRowIndex, 1].ToString();
            frmem.TextBox3.Text = dgMaterial[dgMaterial.CurrentRowIndex, 9].ToString();
			frmem.TextBox4.Text = dgMaterial[dgMaterial.CurrentRowIndex, 2].ToString();
			frmem.TextBox5.Text = dgMaterial[dgMaterial.CurrentRowIndex, 3].ToString();
			frmem.NumericUpDown1.Text =dgMaterial[dgMaterial.CurrentRowIndex, 11].ToString();
			frmem.NumericUpDown2.Text =dgMaterial[dgMaterial.CurrentRowIndex, 12].ToString();
			frmem.NumericUpDown3.Text =dgMaterial[dgMaterial.CurrentRowIndex, 10].ToString();
			frmem.ComboBox1.Text =dgMaterial[dgMaterial.CurrentRowIndex, 5].ToString();
			frmem.Text = "编辑物品";
			frmem.CurrentStorageDeptName = cbStorageDept.Text;
			frmem.ShowDialog();
			if (frmem.DialogResult == DialogResult.OK)
			{
				LoadMaterials(cbStorageDept.Text);
			}
		}
		
		//查询
		private void SearchData(string materialcode, string materialname, string materialtypecode, string spell)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				CurrentSqlWhereCode = " where " + "materialcode like '" + "%" + materialcode + "%'" + " and " + "materialname like '" + "%" + materialname + "%'" + " and " + "materialtypecode like '" + "%" + materialtypecode + "%'" + " and " + "spell like '" + "%" + spell + "%'";
				
				
				selectCMD.CommandText = CurrentMatrlLstSqlCode + CurrentSqlWhereCode;
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "MaterialsList");
				dgMaterial.DataSource = null;
				dgMaterial.DataSource = dbDS;
				dgMaterial.DataMember = "MaterialsList";
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
		
		//删除类别
		private bool DelMaterial(string materialcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select count(*) from InStorageMaterials  where materialcode='" + materialcode + "'";
				dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (int.Parse(dbDS.Tables[0].Rows[0][0].ToString()) > 0) //存在
				{
					MessageBox.Show("入库单中存在该物品，不能执行删除操作");
					return false;
				}
				else
				{
					selectCMD.CommandText = "select count(*) from OutStorageMaterials  where materialcode='" + materialcode + "'";
					dbDA.SelectCommand = selectCMD;
					dbDA.Fill(dbDS, "t1");
					if (int.Parse(dbDS.Tables["t1"].Rows[0][0].ToString()) > 0)
					{
						MessageBox.Show("出库单中存在该物品，不能执行删除操作");
						return false;
					}
					else
					{
						selectCMD.CommandText = "delete from materials where materialcode='" + materialcode + "'";
						selectCMD.CommandTimeout = 30;
						selectCMD.ExecuteNonQuery();
						return true;
					}
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
		
		private void frmMaterials_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmMtrls = null;
		}
		
		private void frmMaterials_Load(System.Object sender, System.EventArgs e)
		{
			DataTable strgdept;
			strgdept = rms_var.LoadStorageDept();
			for (int i = 0; i <= strgdept.Rows.Count - 1; i++)
			{
				cbStorageDept.Items.Add(strgdept.Rows[i]["deptname"]);
			}
			if (rms_var.TheAppExt.Chk_Kc_Wlgl && rms_var.TheAppExt.Chk_Kc_Ylgl)
			{
				cbStorageDept.Items.Add("全部");
			}
			cbStorageDept.SelectedIndex = 0;
		}
		
		private void cbMaterialType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			LoadMaterials(cbStorageDept.Text);
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
                    try
                    {
                        frmEditMaterial frmem_1 = new frmEditMaterial();
                        frmem_1.frmMode = 1; //add
                        DataTable strgdept_1;
                        strgdept_1 = rms_var.LoadMaterialType(cbStorageDept.Text);
                        for (int i = 0; i <= strgdept_1.Rows.Count - 1; i++)
                        {
                            frmem_1.ComboBox1.Items.Add(strgdept_1.Rows[i]["Name"]);
                        }
                        frmem_1.ComboBox1.SelectedIndex = 0;
                        frmem_1.Text = "添加物品";
                        frmem_1.CurrentStorageDeptName = cbStorageDept.Text;
                        frmem_1.ShowDialog();
                        if (frmem_1.DialogResult == DialogResult.OK)
                        {
                            LoadMaterials(cbStorageDept.Text);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
					break;
				case 1: //修改数据
					EditData();
					break;
				case 2: //删除当前数据
					if (MessageBox.Show("确定要删除当前选中的编号为 " + dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString().Trim() + " 的物品类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
                        if (DelMaterial(dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString()))
						{
							LoadMaterials(cbStorageDept.Text);
						}
					}
					break;
					
				case 4:
					frmEditMaterial frmem = new frmEditMaterial();
					DataTable strgdept;
					strgdept = rms_var.LoadMaterialType(cbStorageDept.Text);
					for (int i = 0; i <= strgdept.Rows.Count - 1; i++)
					{
						frmem.ComboBox1.Items.Add(strgdept.Rows[i]["Name"]);
					}
					frmem.ComboBox1.SelectedIndex = 0;
					
					frmem.frmMode = 3; //查询数据
					frmem.Text = "查询物品信息";
					
					frmem.ShowDialog();
					if (frmem.DialogResult == DialogResult.OK)
					{
						SearchData(frmem.TextBox1.Text, frmem.TextBox2.Text, rms_var.GetMaterialTypeCode(frmem.ComboBox1.Text), frmem.TextBox3.Text);
					}
					break;
				case 6:
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentMatrlLstSqlCode))
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
			if (report_var.materials_cr == null)
			{
				report_var.materials_cr = new ReportDocument();
			}
			else
			{
				report_var.materials_cr.Close();
				report_var.materials_cr = null;
				report_var.materials_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.materials_rpt_filename))
			{
				report_var.materials_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.materials_rpt_filename, sql, "view_Materials");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.materials_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.materials_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.materials_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
		
		private void dgMaterial_DoubleClick(object sender, System.EventArgs e)
		{
			EditData();
		}
	}
	
}
