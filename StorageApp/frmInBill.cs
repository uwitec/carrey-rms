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
	public class frmInBill : System.Windows.Forms.Form
	{
		
		public string CurrentInBillTypeCode;
		private DataTable BillList;
		private DataTable SelectedMaterials;
		private int BillCount = 0;
		private int CurrentBillRecNo = -1;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmInBill()
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
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.ComboBox cbInStorageDept;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ToolBarButton ToolBarButton13;
		internal System.Windows.Forms.DataGrid dgMaterials;
		internal System.Windows.Forms.ComboBox cbVendor;
		internal System.Windows.Forms.ComboBox cbPurchase;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton14;
		internal System.Windows.Forms.ToolBarButton ToolBarButton15;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.TextBox TextBox3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Closed += new System.EventHandler(frmInComeBill_Closed);
			base.Load += new System.EventHandler(frmInBill_Load);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmInBill));
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.cbPurchase = new System.Windows.Forms.ComboBox();
			this.cbVendor = new System.Windows.Forms.ComboBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbInStorageDept = new System.Windows.Forms.ComboBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dgMaterials = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Label10 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgMaterials).BeginInit();
			this.SuspendLayout();
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton6, this.ToolBarButton13, this.ToolBarButton12, this.ToolBarButton3, this.ToolBarButton11, this.ToolBarButton14, this.ToolBarButton15, this.ToolBarButton4, this.ToolBarButton5, this.ToolBarButton2, this.ToolBarButton7, this.ToolBarButton8, this.ToolBarButton9, this.ToolBarButton10});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(544, 55);
			this.ToolBar1.TabIndex = 0;
			//
			//ToolBarButton1
			//
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Text = "新增";
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.ImageIndex = 1;
			this.ToolBarButton6.Text = "添加";
			//
			//ToolBarButton13
			//
			this.ToolBarButton13.ImageIndex = 2;
			this.ToolBarButton13.Text = "保存";
			//
			//ToolBarButton12
			//
			this.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton3
			//
			this.ToolBarButton3.ImageIndex = 3;
			this.ToolBarButton3.Text = "删单据";
			//
			//ToolBarButton11
			//
			this.ToolBarButton11.ImageIndex = 4;
			this.ToolBarButton11.Text = "删物品";
			//
			//ToolBarButton14
			//
			this.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton15
			//
			this.ToolBarButton15.ImageIndex = 5;
			this.ToolBarButton15.Text = "审核";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 6;
			this.ToolBarButton5.Text = "前单据";
			//
			//ToolBarButton2
			//
			this.ToolBarButton2.ImageIndex = 7;
			this.ToolBarButton2.Text = "后单据";
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton8
			//
			this.ToolBarButton8.ImageIndex = 8;
			this.ToolBarButton8.Text = "打印";
			//
			//ToolBarButton9
			//
			this.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton10
			//
			this.ToolBarButton10.ImageIndex = 9;
			this.ToolBarButton10.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.cbPurchase);
			this.GroupBox1.Controls.Add(this.cbVendor);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.cbInStorageDept);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.GroupBox1.Location = new System.Drawing.Point(8, 64);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(528, 176);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "入库单";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(344, 24);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ReadOnly = true;
			this.TextBox3.Size = new System.Drawing.Size(120, 21);
			this.TextBox3.TabIndex = 18;
			this.TextBox3.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(112, 121);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(352, 21);
			this.TextBox2.TabIndex = 6;
			this.TextBox2.Text = "";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(336, 96);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(128, 23);
			this.Label9.TabIndex = 17;
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//cbPurchase
			//
			this.cbPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPurchase.Location = new System.Drawing.Point(112, 97);
			this.cbPurchase.Name = "cbPurchase";
			this.cbPurchase.Size = new System.Drawing.Size(128, 20);
			this.cbPurchase.TabIndex = 5;
			//
			//cbVendor
			//
			this.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVendor.Location = new System.Drawing.Point(112, 72);
			this.cbVendor.Name = "cbVendor";
			this.cbVendor.Size = new System.Drawing.Size(352, 20);
			this.cbVendor.TabIndex = 4;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(112, 48);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(128, 21);
			this.DateTimePicker1.TabIndex = 2;
			//
			//cbInStorageDept
			//
			this.cbInStorageDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbInStorageDept.Location = new System.Drawing.Point(344, 48);
			this.cbInStorageDept.Name = "cbInStorageDept";
			this.cbInStorageDept.Size = new System.Drawing.Size(120, 20);
			this.cbInStorageDept.TabIndex = 3;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(112, 25);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(128, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//CheckBox1
			//
			this.CheckBox1.Enabled = false;
			this.CheckBox1.Location = new System.Drawing.Point(392, 144);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(128, 24);
			this.CheckBox1.TabIndex = 7;
			this.CheckBox1.Text = "已审核";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(40, 120);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(72, 23);
			this.Label8.TabIndex = 7;
			this.Label8.Text = "备注：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(256, 96);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(80, 23);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "操作员：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(40, 96);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(72, 23);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "采购人：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(40, 71);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "供应商：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(264, 47);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 23);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "入库仓库：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(40, 47);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "入库时间：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(264, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 23);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "入库类型：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(40, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "单据号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//dgMaterials
			//
			this.dgMaterials.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dgMaterials.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgMaterials.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgMaterials.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgMaterials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgMaterials.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgMaterials.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.CaptionVisible = false;
			this.dgMaterials.DataMember = "";
			this.dgMaterials.FlatMode = true;
			this.dgMaterials.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgMaterials.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dgMaterials.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgMaterials.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgMaterials.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgMaterials.LinkColor = System.Drawing.Color.Teal;
			this.dgMaterials.Location = new System.Drawing.Point(8, 240);
			this.dgMaterials.Name = "dgMaterials";
			this.dgMaterials.ParentRowsBackColor = System.Drawing.Color.White;
			this.dgMaterials.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.ReadOnly = true;
			this.dgMaterials.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgMaterials.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgMaterials.Size = new System.Drawing.Size(528, 248);
			this.dgMaterials.TabIndex = 2;
			this.dgMaterials.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.DataGridTableStyle1.DataGrid = this.dgMaterials;
			this.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6});
			this.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Black;
			this.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.Silver;
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "MaterialsList";
			this.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Navy;
			this.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
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
			this.DataGridTextBoxColumn2.Width = 110;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "单位";
			this.DataGridTextBoxColumn3.MappingName = "unit";
			this.DataGridTextBoxColumn3.Width = 50;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "数量";
			this.DataGridTextBoxColumn4.MappingName = "quantity";
			this.DataGridTextBoxColumn4.Width = 60;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "单价";
			this.DataGridTextBoxColumn5.MappingName = "price";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "合计";
			this.DataGridTextBoxColumn6.MappingName = "totalprice";
			this.DataGridTextBoxColumn6.Width = 90;
			//
			//Label10
			//
			this.Label10.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Label10.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label10.Location = new System.Drawing.Point(376, 490);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(152, 23);
			this.Label10.TabIndex = 7;
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmInBill
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(544, 518);
			this.Controls.Add(this.dgMaterials);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInBill";
			this.Text = "入库";
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgMaterials).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//初始化入库窗口
		public void init(string inbilltypcode)
		{
            try
            {
                //返回允许访问的仓库部门
                cbInStorageDept.Items.Clear();
                DataTable instoragedeptlst;
                instoragedeptlst = rms_var.LoadStorageDept();
                for (int i = 0; i <= instoragedeptlst.Rows.Count - 1; i++)
                {
                    cbInStorageDept.Items.Add(instoragedeptlst.Rows[i]["DeptName"]);
                }

                //返回供应商列表
                cbVendor.Items.Clear();
                DataTable vendorlst;
                vendorlst = rms_var.LoadVendor();
                for (int i = 0; i <= vendorlst.Rows.Count - 1; i++)
                {
                    cbVendor.Items.Add(vendorlst.Rows[i]["VendorName"]);
                }

                //返回采购员列表
                cbPurchase.Items.Clear();
                DataTable purchaselst;
                purchaselst = rms_var.LoadPurchase();
                for (int i = 0; i <= purchaselst.Rows.Count - 1; i++)
                {
                    cbPurchase.Items.Add(purchaselst.Rows[i]["Name"]);
                }

                cbInStorageDept.SelectedIndex = 0;
                Label9.Text = rms_var.opinfo.OpID;
                //获取当月相应类型单据的单据记录
                LoadCurrentMonthBill(inbilltypcode);
                //CurrentBillMaterials = New DataTable
                if (SelectedMaterials == null)
                {
                    SelectedMaterials = new DataTable();
                }
                else
                {
                    SelectedMaterials.Rows.Clear();
                }

                SelectedMaterials = LoadCurrentBillMaterials(TextBox1.Text);
                dgMaterials.DataSource = SelectedMaterials;
                BillCount = BillList.Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
		}
		
		//返回当月入库单记录
		private void LoadCurrentMonthBill(string intypecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT billno,storagebilltypecode,indate,depcode,vendorcode,processman,operator,note,audited FROM InStorageBill where storagebilltypecode='" + intypecode + "'";
				//selectCMD.CommandText = "SELECT billno,storagebilltypecode,indate,depcode,vendorcode,processman,operator,note,audited FROM instoragebill where " + _
				//                        "DATEPART(year,indate)='" + Now.Year.ToString + "'" + _
				//                        " and DATEPART(month,indate)='" + Now.Month.ToString + "' and storagebilltypecode='" + intypecode + "'"
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "BillList");
				BillList = dbDS.Tables[0];
				BillCount = BillList.Rows.Count;
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
		
		//返回当前单据物品列表
		private DataTable LoadCurrentBillMaterials(string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT MaterialCode,MaterialName,Unit,Quantity,Price,quantity*price as totalprice FROM view_InStorageMaterials where billno='" + billno + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "MaterialsList");
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
		
		//新建采购入库单据
		public void NewIncomeBill()
		{
			if (SelectedMaterials == null)
			{
				SelectedMaterials = new DataTable();
			}
			else
			{
				SelectedMaterials.Rows.Clear();
			}
			//检测库存单据是否自动编号
			if (rms_var.GetSysSetup("autostorebill") == "1") //自动生成库存单据编号
			{
				TextBox1.Text = rms_var.GenNewStorageBillNo(0, "I"); //0=入库单据 1=出库单据
			}
			else
			{
				TextBox1.Text = "";
			}
			RefreshTotalPrice();
			CurrentBillRecNo = BillCount;
			
			TextBox3.Text = rms_var.GetStorageBillTypeName(CurrentInBillTypeCode);
			cbVendor.DropDownStyle = ComboBoxStyle.DropDownList;
			if (cbVendor.Items.Count > 0)
			{
				cbVendor.SelectedIndex = 0;
			}
			cbVendor.Enabled = true;
			
			cbPurchase.DropDownStyle = ComboBoxStyle.DropDownList;
			cbPurchase.SelectedIndex = 0;
			cbPurchase.Enabled = true;
			
			DateTimePicker1.Value = DateTime.Now;
			TextBox2.Text = "";
			CheckBox1.Checked = false;
			Label9.Text = rms_var.opinfo.OpID;
			TextBox1.Enabled = true;
			TextBox1.Focus();
			TextBox1.SelectAll();
		}
		
		//新建仓库报溢单据
		public void NewOverFlowBill()
		{
			if (SelectedMaterials == null)
			{
				SelectedMaterials = new DataTable();
			}
			else
			{
				SelectedMaterials.Rows.Clear();
			}
			//检测库存单据是否自动编号
			if (rms_var.GetSysSetup("autostorebill") == "1") //自动生成库存单据编号
			{
				TextBox1.Text = rms_var.GenNewStorageBillNo(0, "M"); //0=入库单据 1=出库单据
			}
			else
			{
				TextBox1.Text = "";
			}
			RefreshTotalPrice();
			CurrentBillRecNo = BillCount;
			
			TextBox3.Text = rms_var.GetStorageBillTypeName(CurrentInBillTypeCode);
			
			cbVendor.DropDownStyle = ComboBoxStyle.Simple;
			cbVendor.Text = "";
			cbVendor.Enabled = false;
			
			cbPurchase.DropDownStyle = ComboBoxStyle.Simple;
			cbPurchase.Text = "";
			cbPurchase.Enabled = false;
			
			//ComboBox1.Enabled = True
			DateTimePicker1.Value = DateTime.Now;
			TextBox2.Text = "";
			CheckBox1.Checked = false;
			Label9.Text = rms_var.opinfo.OpID;
			TextBox1.Enabled = true;
			TextBox1.Focus();
			TextBox1.SelectAll();
		}
		
		private void AddVendorPayCost(string vendorcode, string cost)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandTimeout = 30;
				selectCMD.Connection = conn;
				conn.Open();
				selectCMD.CommandText = "update vendor set stock_paying=stock_paying+" + cost + " where vendorcode='" + vendorcode + "'";
				
				selectCMD.ExecuteNonQuery();
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
		
		//保存 采购入库 单据
		private bool SaveBill(string billno, string StorageBillTypeCode, string Indate, string VendorCode, string ProcessMan, string Operator, string DepCode, bool Audited, string note)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select billno from instoragebill where billno='" + billno + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					if (MessageBox.Show("单据已经存在，更新当前物品列表吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					if (StorageBillTypeCode == "I") //采购入库
					{
						selectCMD.CommandText = "insert into instoragebill (billno,StorageBillTypeCode,Indate,VendorCode,ProcessMan,Operator,DepCode,note,Audited) " + "values (" + "'" + billno + "'" + "," + "'" + StorageBillTypeCode + "'" + "," + "'" + Indate + "'" + "," + "'" + VendorCode + "'" + "," + "'" + ProcessMan + "'" + "," + "'" + Operator + "'" + "," + "'" + DepCode + "'" + "," + "'" + note + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(Audited)).ToString() + "'" + ")";
						selectCMD.ExecuteNonQuery();
						//计算物品合计，更新供应商应付款
						double totalcost = 0;
						for (int i = 0; i <= dgMaterials.VisibleRowCount - 1; i++)
						{
							totalcost = totalcost + System.Convert.ToDouble(dgMaterials[i, 5]);
						}
						AddVendorPayCost(VendorCode, totalcost.ToString());
						
					}
					else if (StorageBillTypeCode == "M") //仓库报溢
					{
						selectCMD.CommandText = "insert into instoragebill (billno,StorageBillTypeCode,Indate,Operator,DepCode,note,Audited) " + "values (" + "'" + billno + "'" + "," + "'" + StorageBillTypeCode + "'" + "," + "'" + Indate + "'" + "," + "'" + Operator + "'" + "," + "'" + DepCode + "'" + "," + "'" + note + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(Audited)).ToString() + "'" + ")";
						selectCMD.ExecuteNonQuery();
					}
					
					return true;
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
			
			return false;
		}
		
		//保存单据物品记录
		private bool SaveBillsMaterials(string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "delete from instoragematerials where billno='" + billno + "'";
				selectCMD.ExecuteNonQuery();
				for (int i = 0; i <= dgMaterials.VisibleRowCount - 1; i++)
				{
                    selectCMD.CommandText = "insert into instoragematerials (billno,MaterialCode,MaterialTypeCode,Quantity,Price,TotalPrice) " + "values (" + "'" + billno + "'" + "," + "'" + dgMaterials[i, 0] + "'" + "," + "'" + rms_var.GetTheMaterialTypeCode(dgMaterials[i, 0].ToString()) + "'" + "," + dgMaterials[i, 3].ToString() + "," + dgMaterials[i, 4].ToString() + "," + dgMaterials[i, 5].ToString() + ")";
					
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
		
		//更新审核标志,更新供应商应付款累计
		private bool UpdateAuditSign(string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "update instoragebill set audited='1' where billno='" + billno + "'";
				selectCMD.ExecuteNonQuery();
				if (cbVendor.Text != "")
				{
					switch (rms_var.GetStorageBillTypeCode(TextBox3.Text))
					{
						case "I": //采购入库
							//计算入库物品价格合计，将应付款更新到vendor表中
							double totalcost = 0;
							for (int i = 0; i <= dgMaterials.VisibleRowCount - 1; i++)
							{
								totalcost = totalcost + System.Convert.ToDouble(dgMaterials[i, 5]);
							}
							selectCMD.CommandText = "update vendor set stock_paying=stock_paying+" + totalcost.ToString() + " where vendorcode='" + rms_var.GetVendorCode(cbVendor.Text) + "'";
							
							selectCMD.ExecuteNonQuery();
							break;
					}
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
		
		//删除单据
		private bool DeleteBill(string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "delete from instoragebill where billno='" + billno + "'";
				selectCMD.ExecuteNonQuery();
				selectCMD.CommandText = "delete from instoragematerials where billno='" + billno + "'";
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
		
		//删除单据中物品
		private bool DeleteBillsMaterial(string billno, string materialcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "delete from instoragematerials where billno='" + billno + "' and materialcode='" + materialcode + "'";
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
		
		private void RefreshTotalPrice()
		{
			//计算合计
			double totalprice = 0;
			for (int i = 0; i <= dgMaterials.VisibleRowCount - 1; i++)
			{
				totalprice = totalprice + double.Parse(dgMaterials[i, 5].ToString());
			}
			Label10.Text = "合计：" + string.Format("{0:N2}",totalprice);
		}
		
		private void frmInComeBill_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmTheInBill = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //新建单据
					if (CurrentInBillTypeCode == "I") //采购入库
					{
						NewIncomeBill();
					}
					else if (CurrentInBillTypeCode == "M") //仓库报溢
					{
						NewOverFlowBill();
					}
					break;
					
				case 1: //添加物品
					if (CurrentInBillTypeCode == "I")
					{
						if (TextBox1.Text == "")
						{
							MessageBox.Show("单据号不能为空！");
							TextBox1.Focus();
							TextBox1.SelectAll();
							return;
						}
						if (cbVendor.Text == "")
						{
							MessageBox.Show("供应商不能为空！");
							cbVendor.Focus();
							cbVendor.SelectAll();
							return;
						}
						if (cbPurchase.Text == "")
						{
							MessageBox.Show("采购人不能为空！");
							cbPurchase.Focus();
							cbPurchase.SelectAll();
							return;
						}
					}
					else if (CurrentInBillTypeCode == "M")
					{
						if (TextBox1.Text == "")
						{
							MessageBox.Show("单据号不能为空！");
							TextBox1.Focus();
							TextBox1.SelectAll();
							return;
						}
					}
					
					if (! CheckBox1.Checked)
					{
						frmSelMaterial frmselmtrl = new frmSelMaterial();
						frmselmtrl.CurrentStorageDeptName = cbInStorageDept.Text;
						frmselmtrl.CreateSelectedMaterialsTable();
						frmselmtrl.BillTypeCode = CurrentInBillTypeCode;
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
								//刷新物品价格
								RefreshTotalPrice();
							}
						}
					}
					else
					{
						MessageBox.Show("已审核单据不能添加物品");
					}
					break;
					
				case 2: //保存当前单据
					if (CurrentInBillTypeCode == "I")
					{
						if (TextBox1.Text == "")
						{
							MessageBox.Show("单据号不能为空！");
							TextBox1.Focus();
							TextBox1.SelectAll();
							return;
						}
						if (cbVendor.Text == "")
						{
							MessageBox.Show("供应商不能为空！");
							cbVendor.Focus();
							cbVendor.SelectAll();
							return;
						}
						if (cbPurchase.Text == "")
						{
							MessageBox.Show("采购人不能为空！");
							cbPurchase.Focus();
							cbPurchase.SelectAll();
							return;
						}
					}
					else if (CurrentInBillTypeCode == "M")
					{
						if (TextBox1.Text == "")
						{
							MessageBox.Show("单据号不能为空！");
							TextBox1.Focus();
							TextBox1.SelectAll();
							return;
						}
					}
					
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (! CheckBox1.Checked)
						{
							if (SaveBill(TextBox1.Text, CurrentInBillTypeCode, DateTimePicker1.Value.ToString(), rms_var.GetVendorCode(cbVendor.Text), rms_var.GetEmployeeID(cbPurchase.Text), Label9.Text, rms_var.GetDeptCode(cbInStorageDept.Text), false, TextBox2.Text))
								{
								//添加单据物品列表
								if (SaveBillsMaterials(TextBox1.Text))
								{
									LoadCurrentMonthBill(CurrentInBillTypeCode);
									CurrentBillRecNo = BillCount;
									MessageBox.Show("单据保存成功");
								}
							}
						}
						else
						{
							MessageBox.Show("已审核单据不能进行修改");
						}
					}
					else
					{
						MessageBox.Show("入库物品列表为空，请添加物品");
					}
					break;
					
				case 4: //删单据
					if (TextBox1.Text != "")
					{
						if (! CheckBox1.Checked)
						{
							if (MessageBox.Show("确定要删除当前单据吗？" +"\r\n"+ "注意：删除单据将会影响菜品成本以及部门成本的核算！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								if (DeleteBill(TextBox1.Text))
								{
									MessageBox.Show("删除成功");
									LoadCurrentMonthBill(CurrentInBillTypeCode);
									CurrentBillRecNo = BillCount;
									if (CurrentInBillTypeCode == "I")
									{
										NewIncomeBill();
									}
									else
									{
										NewOverFlowBill();
									}
								}
							}
						}
						else
						{
							MessageBox.Show("已审核单据不能删除");
						}
					}
					break;
					
				case 5: //删物品
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (! CheckBox1.Checked)
						{
							if (MessageBox.Show("确定要删除单据中的当前物品吗？" +"\r\n"+ "注意：删除单据将会影响菜品成本以及部门成本的核算！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
                                if (DeleteBillsMaterial(TextBox1.Text, dgMaterials[dgMaterials.CurrentRowIndex, 0].ToString()))
								{
									MessageBox.Show("删除成功");
									//获取物品记录
									SelectedMaterials = LoadCurrentBillMaterials(TextBox1.Text);
									dgMaterials.DataSource = SelectedMaterials;
									RefreshTotalPrice();
								}
							}
						}
						else
						{
							MessageBox.Show("已审核单据不能删除");
						}
					}
					break;
					
				case 7: //审核
					//If CurrentBillRecNo <> -1 And CurrentBillRecNo <> BillCount Then
					if (CurrentBillRecNo != -1)
					{
						if (dgMaterials.VisibleRowCount > 0)
						{
							if (CheckBox1.Checked == false)
							{
								//检测有无审核权
								if (rms_var.AllowAudit())
								{
									if (MessageBox.Show("确定要审核当前单据吗？" +"\r\n"+ "注意：经审核过的单据将不能再进行修改！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
									{
										CheckBox1.Checked = true;
										//更新审核标志
										if (UpdateAuditSign(TextBox1.Text))
										{
											LoadCurrentMonthBill(CurrentInBillTypeCode);
											MessageBox.Show("审核成功");
										}
									}
								}
								else
								{
									MessageBox.Show("您没有审核权。");
									return;
								}
							}
							else
							{
								MessageBox.Show("已经审核了");
							}
						}
					}
					break;
					
				case 9: //前一单据
                    try
                    {
                        if (CurrentBillRecNo == 0)
                        {
                            return;
                        }
                        CurrentBillRecNo--;
                        if (CurrentBillRecNo != -1)
                        {
                            TextBox1.Enabled = false;
                            //billno,storagebilltypecode,indate,depcode,vendorcode,processman,operator,note,audited
                            TextBox1.Text = BillList.Rows[CurrentBillRecNo][0].ToString();
                            TextBox3.Text = rms_var.GetStorageBillType(BillList.Rows[CurrentBillRecNo][1].ToString());
                            DateTimePicker1.Text = BillList.Rows[CurrentBillRecNo][2].ToString();
                            cbInStorageDept.Text = rms_var.GetDeptName(BillList.Rows[CurrentBillRecNo][3].ToString());
                            cbVendor.Text = rms_var.GetVendorName(BillList.Rows[CurrentBillRecNo][4].ToString());
                            cbPurchase.Text = rms_var.GetEmployeeName(BillList.Rows[CurrentBillRecNo][5].ToString());
                            Label9.Text = BillList.Rows[CurrentBillRecNo][6].ToString();
                            TextBox2.Text = BillList.Rows[CurrentBillRecNo][7].ToString();
                            CheckBox1.Checked =BillList.Rows[CurrentBillRecNo][8].ToString().Trim()=="1"?true:false;

                            //获取物品记录
                            SelectedMaterials = LoadCurrentBillMaterials(TextBox1.Text);
                            dgMaterials.DataSource = SelectedMaterials;
                            RefreshTotalPrice();
                        }
                        else
                        {
                            CurrentBillRecNo = 0;
                        }
                    }
                    catch(Exception err){}
					break;
				case 10: //后一单据
					if (CurrentBillRecNo >= BillCount - 1)
					{
						return;
					}
					CurrentBillRecNo++;
					if (CurrentBillRecNo < BillCount)
					{
						TextBox1.Enabled = false;
						//billno,storagebilltypecode,indate,depcode,vendorcode,processman,operator,note,audited
						TextBox1.Text = BillList.Rows[CurrentBillRecNo][0].ToString();
						TextBox3.Text = rms_var.GetStorageBillType(BillList.Rows[CurrentBillRecNo][1].ToString());
						DateTimePicker1.Text = BillList.Rows[CurrentBillRecNo][2].ToString();
						cbInStorageDept.Text = rms_var.GetDeptName(BillList.Rows[CurrentBillRecNo][3].ToString());
						cbVendor.Text = rms_var.GetVendorName(BillList.Rows[CurrentBillRecNo][4].ToString());
						cbPurchase.Text = rms_var.GetEmployeeName(BillList.Rows[CurrentBillRecNo][5].ToString());
						Label9.Text = BillList.Rows[CurrentBillRecNo][6].ToString();
						TextBox2.Text = BillList.Rows[CurrentBillRecNo][7].ToString();
						CheckBox1.Checked =BillList.Rows[CurrentBillRecNo][8].ToString().Trim()=="1"?true:false;
						
						//获取物品记录
						SelectedMaterials = LoadCurrentBillMaterials(TextBox1.Text);
						dgMaterials.DataSource = SelectedMaterials;
						RefreshTotalPrice();
					}
					break;
				case 12:
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (MessageBox.Show("确定要打印当前单据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							if (! PrintReport("SELECT MaterialCode,MaterialName,Unit,name,Quantity,Price,quantity*price as totalprice FROM view_InStorageMaterials where billno='" + TextBox1.Text + "'"))
							{
								MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
							}
						}
					}
					else
					{
						MessageBox.Show("单据没有保存，请首先添加物品并保存单据后再进行打印操作。");
					}
					break;
					
				case 14:
					this.Close();
					break;
					
			}
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.inbill_cr == null)
			{
				report_var.inbill_cr = new ReportDocument();
			}
			else
			{
				report_var.inbill_cr.Close();
				report_var.inbill_cr = null;
				report_var.inbill_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.inbill_rpt_filename))
			{
				report_var.inbill_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.inbill_rpt_filename, sql, "view_InStorageMaterials");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.inbill_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.inbill_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				ParameterFieldDefinitions crParameterFieldDefinitions;
				ParameterFieldDefinition crParameterFieldDefinition;
				ParameterValues crParameterValues;
				ParameterDiscreteValue crParameterDiscreteValue;
				
				crParameterFieldDefinitions = report_var.inbill_cr.DataDefinition.ParameterFields;
				
				crParameterFieldDefinition = crParameterFieldDefinitions["title"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "入库单";
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["billno"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = TextBox1.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["inbilltype"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = TextBox3.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["inbilldate"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = DateTimePicker1.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["instoragedept"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = cbInStorageDept.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["vendor"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = cbVendor.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["purchase"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = cbPurchase.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["opid"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = Label9.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["note"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = TextBox2.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["audit"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				if (CheckBox1.Checked)
				{
					crParameterDiscreteValue.Value = "已审核";
				}
				else
				{
					crParameterDiscreteValue.Value = "还未审核";
				}
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				report_var.inbill_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
		
		private void frmInBill_Load(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
