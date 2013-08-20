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
	public class frmSelMaterial : System.Windows.Forms.Form
	{
		
		// "A", "D", "H", "F", "B", "G"
		// 向 领料单 ，直拨单，部门退仓库，部门退供应商，仓库退供应商  仓库报损 添加物品
		public string BillTypeCode;
		public string CurrentStorageDeptName;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelMaterial()
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
		internal System.Windows.Forms.DataGrid dgMaterial;
		internal System.Windows.Forms.ComboBox cbMaterialType;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGrid dgSelMaterials;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSelMaterial));
			this.cbMaterialType = new System.Windows.Forms.ComboBox();
			base.Load += new System.EventHandler(frmSelMaterial_Load);
			this.cbMaterialType.SelectedIndexChanged += new System.EventHandler(this.cbMaterialType_SelectedIndexChanged);
			this.dgMaterial = new System.Windows.Forms.DataGrid();
			this.dgMaterial.DoubleClick += new System.EventHandler(this.dgMaterial_DoubleClick);
			this.dgMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgMaterial_KeyPress);
			this.DataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.dgSelMaterials = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgMaterial).BeginInit();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgSelMaterials).BeginInit();
			this.SuspendLayout();
			//
			//cbMaterialType
			//
			this.cbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMaterialType.Location = new System.Drawing.Point(184, 16);
			this.cbMaterialType.Name = "cbMaterialType";
			this.cbMaterialType.Size = new System.Drawing.Size(128, 20);
			this.cbMaterialType.TabIndex = 1;
			//
			//dgMaterial
			//
			this.dgMaterial.AllowNavigation = false;
			this.dgMaterial.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgMaterial.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgMaterial.BackColor = System.Drawing.Color.GhostWhite;
			this.dgMaterial.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgMaterial.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgMaterial.CaptionForeColor = System.Drawing.Color.White;
			this.dgMaterial.CaptionVisible = false;
			this.dgMaterial.CausesValidation = false;
			this.dgMaterial.DataMember = "";
			this.dgMaterial.FlatMode = true;
			this.dgMaterial.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgMaterial.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterial.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgMaterial.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterial.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgMaterial.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgMaterial.LinkColor = System.Drawing.Color.Teal;
			this.dgMaterial.Location = new System.Drawing.Point(8, 112);
			this.dgMaterial.Name = "dgMaterial";
			this.dgMaterial.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgMaterial.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterial.ReadOnly = true;
			this.dgMaterial.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgMaterial.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgMaterial.Size = new System.Drawing.Size(472, 192);
			this.dgMaterial.TabIndex = 0;
			this.dgMaterial.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle2});
			//
			//DataGridTableStyle2
			//
			this.DataGridTableStyle2.DataGrid = this.dgMaterial;
			this.DataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6});
			this.DataGridTableStyle2.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle2.MappingName = "MaterialsList";
			this.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.Navy;
			this.DataGridTableStyle2.SelectionForeColor = System.Drawing.Color.White;
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "物品编码";
			this.DataGridTextBoxColumn1.MappingName = "materialcode";
			this.DataGridTextBoxColumn1.Width = 65;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "物品名称";
			this.DataGridTextBoxColumn2.MappingName = "materialname";
			this.DataGridTextBoxColumn2.Width = 90;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "物品类别";
			this.DataGridTextBoxColumn3.MappingName = "name";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "单位";
			this.DataGridTextBoxColumn4.MappingName = "unit";
			this.DataGridTextBoxColumn4.Width = 50;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "所属仓库";
			this.DataGridTextBoxColumn5.MappingName = "deptname";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "拼音码";
			this.DataGridTextBoxColumn6.MappingName = "spell";
			this.DataGridTextBoxColumn6.Width = 55;
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.RadioButton3);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Controls.Add(this.cbMaterialType);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(472, 96);
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "物品过滤方式";
			//
			//TextBox2
			//
			this.TextBox2.Enabled = false;
			this.TextBox2.Location = new System.Drawing.Point(184, 64);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(128, 21);
			this.TextBox2.TabIndex = 5;
			this.TextBox2.Text = "";
			//
			//TextBox1
			//
			this.TextBox1.Enabled = false;
			this.TextBox1.Location = new System.Drawing.Point(184, 40);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(128, 21);
			this.TextBox1.TabIndex = 3;
			this.TextBox1.Text = "";
			//
			//RadioButton3
			//
			this.RadioButton3.Location = new System.Drawing.Point(56, 64);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(120, 24);
			this.RadioButton3.TabIndex = 4;
			this.RadioButton3.Text = "按物品编码过滤";
			//
			//RadioButton2
			//
			this.RadioButton2.Location = new System.Drawing.Point(56, 40);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(128, 24);
			this.RadioButton2.TabIndex = 2;
			this.RadioButton2.Text = "按物品拼音码过滤";
			//
			//RadioButton1
			//
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(56, 16);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(120, 24);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "按物品类别过滤";
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(320, 584);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 5;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(400, 584);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 6;
			this.Button2.Text = "取消(&C)";
			//
			//dgSelMaterials
			//
			this.dgSelMaterials.AllowNavigation = false;
			this.dgSelMaterials.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgSelMaterials.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgSelMaterials.BackColor = System.Drawing.Color.GhostWhite;
			this.dgSelMaterials.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgSelMaterials.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgSelMaterials.CaptionForeColor = System.Drawing.Color.White;
			this.dgSelMaterials.CaptionVisible = false;
			this.dgSelMaterials.CausesValidation = false;
			this.dgSelMaterials.DataMember = "";
			this.dgSelMaterials.FlatMode = true;
			this.dgSelMaterials.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgSelMaterials.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSelMaterials.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgSelMaterials.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgSelMaterials.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgSelMaterials.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgSelMaterials.LinkColor = System.Drawing.Color.Teal;
			this.dgSelMaterials.Location = new System.Drawing.Point(8, 344);
			this.dgSelMaterials.Name = "dgSelMaterials";
			this.dgSelMaterials.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgSelMaterials.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSelMaterials.ReadOnly = true;
			this.dgSelMaterials.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgSelMaterials.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgSelMaterials.Size = new System.Drawing.Size(472, 168);
			this.dgSelMaterials.TabIndex = 2;
			this.dgSelMaterials.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgSelMaterials;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn7, this.DataGridTextBoxColumn8, this.DataGridTextBoxColumn9, this.DataGridTextBoxColumn10, this.DataGridTextBoxColumn11, this.DataGridTextBoxColumn12});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "MaterialsList";
			this.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Navy;
			this.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "物品编码";
			this.DataGridTextBoxColumn7.MappingName = "materialcode";
			this.DataGridTextBoxColumn7.Width = 65;
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "物品名称";
			this.DataGridTextBoxColumn8.MappingName = "materialname";
			this.DataGridTextBoxColumn8.Width = 90;
			//
			//DataGridTextBoxColumn9
			//
			this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn9.Format = "";
			this.DataGridTextBoxColumn9.FormatInfo = null;
			this.DataGridTextBoxColumn9.HeaderText = "单位";
			this.DataGridTextBoxColumn9.MappingName = "unit";
			this.DataGridTextBoxColumn9.Width = 50;
			//
			//DataGridTextBoxColumn10
			//
			this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn10.Format = "";
			this.DataGridTextBoxColumn10.FormatInfo = null;
			this.DataGridTextBoxColumn10.HeaderText = "数量";
			this.DataGridTextBoxColumn10.MappingName = "quantity";
			this.DataGridTextBoxColumn10.Width = 60;
			//
			//DataGridTextBoxColumn11
			//
			this.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn11.Format = "";
			this.DataGridTextBoxColumn11.FormatInfo = null;
			this.DataGridTextBoxColumn11.HeaderText = "单价";
			this.DataGridTextBoxColumn11.MappingName = "price";
			this.DataGridTextBoxColumn11.Width = 65;
			//
			//DataGridTextBoxColumn12
			//
			this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn12.Format = "";
			this.DataGridTextBoxColumn12.FormatInfo = null;
			this.DataGridTextBoxColumn12.HeaderText = "合计金额";
			this.DataGridTextBoxColumn12.MappingName = "totalprice";
			this.DataGridTextBoxColumn12.Width = 80;
			//
			//Button4
			//
			this.Button4.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button4.Location = new System.Drawing.Point(416, 312);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(56, 24);
			this.Button4.TabIndex = 1;
			this.Button4.Text = "添加";
			//
			//Button5
			//
			this.Button5.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button5.Location = new System.Drawing.Point(352, 544);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(56, 24);
			this.Button5.TabIndex = 3;
			this.Button5.Text = "删除";
			//
			//Button6
			//
			this.Button6.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button6.Location = new System.Drawing.Point(416, 544);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(56, 24);
			this.Button6.TabIndex = 4;
			this.Button6.Text = "清空";
			//
			//Label1
			//
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Label1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.Location = new System.Drawing.Point(360, 512);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 23);
			this.Label1.TabIndex = 18;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmSelMaterial
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(488, 622);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.dgSelMaterials);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.dgMaterial);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MinimizeBox = false;
			this.Name = "frmSelMaterial";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择物品";
			((System.ComponentModel.ISupportInitialize) this.dgMaterial).EndInit();
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgSelMaterials).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public DataTable SelectedMaterials;
		
		//创建临时存储的已选择的物品记录表
		public void CreateSelectedMaterialsTable()
		{
			SelectedMaterials = new DataTable("MaterialsList");
			
			DataColumn Column3 = new DataColumn();
			Column3.DataType = System.Type.GetType("System.String");
			Column3.AllowDBNull = true;
			Column3.ReadOnly = true;
			Column3.ColumnName = "MaterialCode";
			SelectedMaterials.Columns.Add(Column3);
			
			DataColumn Column4 = new DataColumn();
			Column4.DataType = System.Type.GetType("System.String");
			Column4.AllowDBNull = true;
			Column4.ReadOnly = true;
			Column4.ColumnName = "MaterialName";
			SelectedMaterials.Columns.Add(Column4);
			
			DataColumn Column5 = new DataColumn();
			Column5.DataType = System.Type.GetType("System.String");
			Column5.AllowDBNull = true;
			Column5.ReadOnly = true;
			Column5.ColumnName = "Unit";
			SelectedMaterials.Columns.Add(Column5);
			
			DataColumn Column6 = new DataColumn();
			Column6.DataType = System.Type.GetType("System.String");
			Column6.AllowDBNull = true;
			Column6.ReadOnly = true;
			Column6.ColumnName = "Quantity";
			SelectedMaterials.Columns.Add(Column6);
			
			DataColumn Column7 = new DataColumn();
			Column7.DataType = System.Type.GetType("System.String");
			Column7.AllowDBNull = true;
			Column7.ReadOnly = true;
			Column7.ColumnName = "Price";
			SelectedMaterials.Columns.Add(Column7);
			
			DataColumn Column8 = new DataColumn();
			Column8.DataType = System.Type.GetType("System.String");
			Column8.AllowDBNull = true;
			Column8.ReadOnly = true;
			Column8.ColumnName = "TotalPrice";
			SelectedMaterials.Columns.Add(Column8);
		}
		
		//添加临时物品记录
		public void AddMaterials(string MaterialCode, string MaterialName, string Unit, string Quantity, string price, string totalprice)
			{
			DataRow myRow;
			
			myRow = SelectedMaterials.NewRow();
			myRow["MaterialCode"] = MaterialCode;
			myRow["MaterialName"] = MaterialName;
			myRow["Unit"] = Unit;
			myRow["Quantity"] = Quantity;
			myRow["Price"] = price;
			myRow["totalprice"] = totalprice;
			SelectedMaterials.Rows.Add(myRow);
		}
		
		//返回物品记录
		private void LoadMaterials(string BillTypeCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				switch (BillTypeCode)
				{
					case "A": //领料单,仓库退供货商
					case "B":
					case "G":
					case "M":
						if (RadioButton1.Checked) //按类别过滤
						{
							selectCMD.CommandText = "SELECT * FROM view_Storage_Inventory where yearmonth= convert(char(4),getdate(),102)+convert(char(2),getdate(),00) and name ='" + cbMaterialType.Text + "'" + " and deptname='" + CurrentStorageDeptName + "'";
						}
						else if (RadioButton2.Checked) //按拼音码过滤
						{
							selectCMD.CommandText = "SELECT * FROM view_Storage_Inventory where yearmonth= convert(char(4),getdate(),102)+convert(char(2),getdate(),00) and spell like '%" + TextBox1.Text + "%' and deptname='" + CurrentStorageDeptName + "'";
						}
						else if (RadioButton3.Checked)
						{
							selectCMD.CommandText = "SELECT * FROM view_Storage_Inventory where yearmonth= convert(char(4),getdate(),102)+convert(char(2),getdate(),00) and materialcode like '%" + TextBox2.Text + "%' and deptname='" + CurrentStorageDeptName + "'";
						}
						break;
					case "C":
					case "D":
					case "F":
					case "H":
					case "I":
					case "E":
						if (RadioButton1.Checked) //按类别过滤
						{
							selectCMD.CommandText = "SELECT * FROM view_Materials where name ='" + cbMaterialType.Text + "'" + " and deptname='" + CurrentStorageDeptName + "'";
						}
						else if (RadioButton2.Checked) //按拼音码过滤
						{
							selectCMD.CommandText = "SELECT * FROM view_Materials where spell like '%" + TextBox1.Text + "%' and deptname='" + CurrentStorageDeptName + "'";
						}
						else if (RadioButton3.Checked)
						{
							selectCMD.CommandText = "SELECT * FROM view_Materials where materialcode like '%" + TextBox2.Text + "%' and deptname='" + CurrentStorageDeptName + "'";
						}
						break;
				}
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				if (selectCMD.CommandText != "")
				{
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "MaterialsList");
					dgMaterial.DataSource = null;
					dgMaterial.DataSource = dbDS;
					dgMaterial.DataMember = "MaterialsList";
				}
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
		
		private void RefreshTotalPrice()
		{
			//计算合计
			double total = System.Convert.ToDouble(0);
			for (int i = 0; i <= dgSelMaterials.VisibleRowCount - 1; i++)
			{
				total = total + System.Convert.ToDouble(dgSelMaterials[i, 5]);
			}
            Label1.Text = "合计：" + string.Format("{0:N2}", total);
		}
		
		private void frmSelMaterial_Load(System.Object sender, System.EventArgs e)
		{
			DataTable tlbmaterialtype;
			tlbmaterialtype = rms_var.LoadMaterialType(CurrentStorageDeptName);
			for (int i = 0; i <= tlbmaterialtype.Rows.Count - 1; i++)
			{
				cbMaterialType.Items.Add(tlbmaterialtype.Rows[i]["Name"]);
			}
			dgSelMaterials.DataSource = SelectedMaterials;
			if (cbMaterialType.Items.Count > 0)
			{
				cbMaterialType.SelectedIndex = 0;
			}
		}
		
		private void cbMaterialType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			LoadMaterials(BillTypeCode);
		}
		
		private void TextBox1_TextChanged(System.Object sender, System.EventArgs e)
		{
			LoadMaterials(BillTypeCode);
		}
		
		private void TextBox2_TextChanged(System.Object sender, System.EventArgs e)
		{
			LoadMaterials(BillTypeCode);
		}
		
		private void RadioButton1_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			cbMaterialType.Enabled = true;
			TextBox1.Enabled = false;
			TextBox2.Enabled = false;
			cbMaterialType.Focus();
		}
		
		private void RadioButton2_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			cbMaterialType.Enabled = false;
			TextBox1.Enabled = true;
			TextBox2.Enabled = false;
			TextBox1.Focus();
			TextBox1.SelectAll();
		}
		
		private void RadioButton3_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			cbMaterialType.Enabled = false;
			TextBox1.Enabled = false;
			TextBox2.Enabled = true;
			TextBox2.Focus();
			TextBox2.SelectAll();
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			if (dgMaterial.VisibleRowCount > 0)
			{
				frmInputMaterialQty frmimqty = new frmInputMaterialQty();
                frmimqty.Label1.Text = dgMaterial[dgMaterial.CurrentRowIndex, 1].ToString();
                frmimqty.Label5.Text = dgMaterial[dgMaterial.CurrentRowIndex, 3].ToString();
				
				switch (BillTypeCode)
				{
					case "A":
					case "B":
					case "F":
					case "G":
					case "H":
					case "M":
						frmimqty.NumericUpDown2.Enabled = false;
						frmimqty.NumericUpDown3.Enabled = false;

                        frmimqty.NumericUpDown2.Text = rms_var.GetCurrMonthMtrlPrice(dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString());
						frmimqty.ShowDialog();
						if (frmimqty.DialogResult == DialogResult.OK)
						{
                            AddMaterials(dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString(), dgMaterial[dgMaterial.CurrentRowIndex, 1].ToString(), dgMaterial[dgMaterial.CurrentRowIndex, 3].ToString(), frmimqty.NumericUpDown1.Text, frmimqty.NumericUpDown2.Text, System.Convert.ToString(frmimqty.NumericUpDown2.Value * frmimqty.NumericUpDown1.Value));
							RefreshTotalPrice();
						}
						break;
					case "I":
					case "D":
						if (rms_var.GetSysSetup("showlastprice") == "1")
						{
                            frmimqty.NumericUpDown2.Text = rms_var.GetCurrMonthMtrlPrice(dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString());
						}
						frmimqty.ShowDialog();
						if (frmimqty.DialogResult == DialogResult.OK)
						{
                            AddMaterials(dgMaterial[dgMaterial.CurrentRowIndex, 0].ToString(), dgMaterial[dgMaterial.CurrentRowIndex, 1].ToString(), dgMaterial[dgMaterial.CurrentRowIndex, 3].ToString(), frmimqty.NumericUpDown1.Text, frmimqty.NumericUpDown2.Text, System.Convert.ToString(frmimqty.NumericUpDown2.Value * frmimqty.NumericUpDown1.Value));
							RefreshTotalPrice();
						}
						break;
				}
				
			}
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			if (dgSelMaterials.VisibleRowCount > 0)
			{
				if (MessageBox.Show("确定要清空当前所有已选物品记录吗？ ", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					SelectedMaterials.Rows.Clear();
					RefreshTotalPrice();
				}
			}
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			if (dgSelMaterials.VisibleRowCount > 0)
			{
				if (MessageBox.Show("确定要删除当前选中的物品记录吗？ ", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					SelectedMaterials.Rows.RemoveAt(dgSelMaterials.CurrentRowIndex);
					RefreshTotalPrice();
				}
			}
		}
		
		private void dgMaterial_DoubleClick(object sender, System.EventArgs e)
		{
			Button4_Click(sender, e);
		}
		
		private void dgMaterial_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)27)
			{
				Button4_Click(sender, e);
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
