using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
//using System.Array;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace DeskApp
{
	public class InputBill : System.Windows.Forms.Form
	{
		
		private string[] BillList;
		private int BillCount = 0;
		private int CurrentBillNum = 0;
		private string CurrentTableNo;
		private string CurrentBillNo;
        private string CurrentBillTypename;
		private bool CurrentBillIsCancel = false;
		
		#region  Windows 窗体设计器生成的代码
		
		public InputBill()
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
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.ComboBox cbTableType;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.DataGrid dgTableStatus;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGrid dgFoodList;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.DataGrid dgSaleFoods;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn14;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn15;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn16;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn17;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn18;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn19;
		internal System.Windows.Forms.Button btnNext;
		internal System.Windows.Forms.Button btnPrior;
		internal System.Windows.Forms.Label lblBillno;
		internal System.Windows.Forms.Label lblBillTypeName;
		internal System.Windows.Forms.Label lblOpenDate;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label lblOpenpsn;
		internal System.Windows.Forms.Label lblTableno;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.TextBox txtFoodCode;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn2;
		internal System.Windows.Forms.ContextMenu ContextMenu1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton2;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton15;
		internal System.Windows.Forms.ToolBarButton ToolBarButton20;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ToolBarButton ToolBarButton18;
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton19;
		internal System.Windows.Forms.ToolBarButton ToolBarButton17;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton13;
		internal System.Windows.Forms.ToolBarButton ToolBarButton14;
		internal System.Windows.Forms.ToolBarButton ToolBarButton16;
		internal System.Windows.Forms.ComboBox cbFoodType;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox cbDeptList;
		internal System.Windows.Forms.NumericUpDown numOpenPsn;
		internal System.Windows.Forms.ToolBarButton ToolBarButton21;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBill));
            this.dgTableStatus = new System.Windows.Forms.DataGrid();
            this.ContextMenu1 = new System.Windows.Forms.ContextMenu();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.numOpenPsn = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblBillno = new System.Windows.Forms.Label();
            this.lblOpenpsn = new System.Windows.Forms.Label();
            this.lblTableno = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrior = new System.Windows.Forms.Button();
            this.lblBillTypeName = new System.Windows.Forms.Label();
            this.dgSaleFoods = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgFoodList = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cbTableType = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtFoodCode = new System.Windows.Forms.TextBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton20 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton21 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton18 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton19 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton17 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton16 = new System.Windows.Forms.ToolBarButton();
            this.cbFoodType = new System.Windows.Forms.ComboBox();
            this.cbDeptList = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableStatus)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpenPsn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTableStatus
            // 
            this.dgTableStatus.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dgTableStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgTableStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgTableStatus.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgTableStatus.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgTableStatus.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTableStatus.CaptionText = "桌台列表";
            this.dgTableStatus.ContextMenu = this.ContextMenu1;
            this.dgTableStatus.DataMember = "";
            this.dgTableStatus.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgTableStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTableStatus.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dgTableStatus.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgTableStatus.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgTableStatus.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgTableStatus.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgTableStatus.LinkColor = System.Drawing.Color.Teal;
            this.dgTableStatus.Location = new System.Drawing.Point(8, 88);
            this.dgTableStatus.Name = "dgTableStatus";
            this.dgTableStatus.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dgTableStatus.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTableStatus.ReadOnly = true;
            this.dgTableStatus.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgTableStatus.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgTableStatus.Size = new System.Drawing.Size(216, 536);
            this.dgTableStatus.TabIndex = 0;
            this.dgTableStatus.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgTableStatus.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dgTableStatus_Navigate);
            this.dgTableStatus.DoubleClick += new System.EventHandler(this.dgTableStatus_DoubleClick);
            // 
            // ContextMenu1
            // 
            this.ContextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.Text = "刷新";
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgTableStatus;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridBoolColumn1});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "tablestatus";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "桌台号";
            this.DataGridTextBoxColumn1.MappingName = "tableno";
            this.DataGridTextBoxColumn1.Width = 50;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "桌台名称";
            this.DataGridTextBoxColumn2.MappingName = "tablename";
            this.DataGridTextBoxColumn2.Width = 60;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "占用";
            this.DataGridBoolColumn1.MappingName = "status";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 50;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.btnNext);
            this.Panel1.Controls.Add(this.btnPrior);
            this.Panel1.Controls.Add(this.lblBillTypeName);
            this.Panel1.Controls.Add(this.dgSaleFoods);
            this.Panel1.Location = new System.Drawing.Point(232, 64);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(360, 552);
            this.Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.numOpenPsn);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Panel3);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.lblBillno);
            this.Panel2.Controls.Add(this.lblOpenpsn);
            this.Panel2.Controls.Add(this.lblTableno);
            this.Panel2.Controls.Add(this.lblOpenDate);
            this.Panel2.Location = new System.Drawing.Point(8, 72);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(344, 128);
            this.Panel2.TabIndex = 15;
            // 
            // numOpenPsn
            // 
            this.numOpenPsn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numOpenPsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numOpenPsn.Location = new System.Drawing.Point(168, 35);
            this.numOpenPsn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpenPsn.Name = "numOpenPsn";
            this.numOpenPsn.Size = new System.Drawing.Size(88, 21);
            this.numOpenPsn.TabIndex = 15;
            this.numOpenPsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOpenPsn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpenPsn.Visible = false;
            this.numOpenPsn.ValueChanged += new System.EventHandler(this.numOpenPsn_ValueChanged);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(128, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(208, 56);
            this.Label2.TabIndex = 14;
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Location = new System.Drawing.Point(8, 56);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(326, 3);
            this.Panel3.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(32, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 56);
            this.Label1.TabIndex = 12;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBillno
            // 
            this.lblBillno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillno.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBillno.Location = new System.Drawing.Point(88, 8);
            this.lblBillno.Name = "lblBillno";
            this.lblBillno.Size = new System.Drawing.Size(248, 32);
            this.lblBillno.TabIndex = 11;
            this.lblBillno.Text = "单据号：";
            // 
            // lblOpenpsn
            // 
            this.lblOpenpsn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpenpsn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOpenpsn.Location = new System.Drawing.Point(88, 40);
            this.lblOpenpsn.Name = "lblOpenpsn";
            this.lblOpenpsn.Size = new System.Drawing.Size(248, 18);
            this.lblOpenpsn.TabIndex = 10;
            this.lblOpenpsn.Text = "开台人数：";
            // 
            // lblTableno
            // 
            this.lblTableno.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTableno.Location = new System.Drawing.Point(8, 40);
            this.lblTableno.Name = "lblTableno";
            this.lblTableno.Size = new System.Drawing.Size(256, 18);
            this.lblTableno.TabIndex = 9;
            this.lblTableno.Text = "桌台号：";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOpenDate.Location = new System.Drawing.Point(8, 8);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(256, 32);
            this.lblOpenDate.TabIndex = 8;
            this.lblOpenDate.Text = "日期：";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(296, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 48);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrior
            // 
            this.btnPrior.Enabled = false;
            this.btnPrior.Location = new System.Drawing.Point(8, 16);
            this.btnPrior.Name = "btnPrior";
            this.btnPrior.Size = new System.Drawing.Size(56, 48);
            this.btnPrior.TabIndex = 13;
            this.btnPrior.Text = "<<";
            this.btnPrior.Click += new System.EventHandler(this.btnPrior_Click);
            // 
            // lblBillTypeName
            // 
            this.lblBillTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillTypeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillTypeName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBillTypeName.ForeColor = System.Drawing.Color.Navy;
            this.lblBillTypeName.Location = new System.Drawing.Point(72, 16);
            this.lblBillTypeName.Name = "lblBillTypeName";
            this.lblBillTypeName.Size = new System.Drawing.Size(216, 48);
            this.lblBillTypeName.TabIndex = 7;
            this.lblBillTypeName.Text = "点菜单";
            this.lblBillTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgSaleFoods
            // 
            this.dgSaleFoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSaleFoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgSaleFoods.CaptionVisible = false;
            this.dgSaleFoods.DataMember = "";
            this.dgSaleFoods.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSaleFoods.Location = new System.Drawing.Point(8, 208);
            this.dgSaleFoods.Name = "dgSaleFoods";
            this.dgSaleFoods.ReadOnly = true;
            this.dgSaleFoods.Size = new System.Drawing.Size(344, 336);
            this.dgSaleFoods.TabIndex = 6;
            this.dgSaleFoods.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle4});
            // 
            // DataGridTableStyle4
            // 
            this.DataGridTableStyle4.ColumnHeadersVisible = false;
            this.DataGridTableStyle4.DataGrid = this.dgSaleFoods;
            this.DataGridTableStyle4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn13,
            this.DataGridTextBoxColumn14,
            this.DataGridTextBoxColumn15,
            this.DataGridTextBoxColumn16,
            this.DataGridTextBoxColumn17,
            this.DataGridTextBoxColumn18,
            this.DataGridTextBoxColumn19,
            this.DataGridBoolColumn2,
            this.DataGridTextBoxColumn4});
            this.DataGridTableStyle4.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle4.MappingName = "salefoods";
            // 
            // DataGridTextBoxColumn13
            // 
            this.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn13.Format = "";
            this.DataGridTextBoxColumn13.FormatInfo = null;
            this.DataGridTextBoxColumn13.HeaderText = "菜品编码";
            this.DataGridTextBoxColumn13.MappingName = "foodcode";
            this.DataGridTextBoxColumn13.Width = 60;
            // 
            // DataGridTextBoxColumn14
            // 
            this.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn14.Format = "";
            this.DataGridTextBoxColumn14.FormatInfo = null;
            this.DataGridTextBoxColumn14.HeaderText = "菜品名称";
            this.DataGridTextBoxColumn14.MappingName = "foodname";
            this.DataGridTextBoxColumn14.Width = 85;
            // 
            // DataGridTextBoxColumn15
            // 
            this.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn15.Format = "";
            this.DataGridTextBoxColumn15.FormatInfo = null;
            this.DataGridTextBoxColumn15.HeaderText = "单位";
            this.DataGridTextBoxColumn15.MappingName = "unit";
            this.DataGridTextBoxColumn15.Width = 40;
            // 
            // DataGridTextBoxColumn16
            // 
            this.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn16.Format = "";
            this.DataGridTextBoxColumn16.FormatInfo = null;
            this.DataGridTextBoxColumn16.HeaderText = "数量";
            this.DataGridTextBoxColumn16.MappingName = "addquantity";
            this.DataGridTextBoxColumn16.Width = 40;
            // 
            // DataGridTextBoxColumn17
            // 
            this.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn17.Format = "";
            this.DataGridTextBoxColumn17.FormatInfo = null;
            this.DataGridTextBoxColumn17.HeaderText = "价格";
            this.DataGridTextBoxColumn17.MappingName = "price";
            this.DataGridTextBoxColumn17.Width = 60;
            // 
            // DataGridTextBoxColumn18
            // 
            this.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn18.Format = "";
            this.DataGridTextBoxColumn18.FormatInfo = null;
            this.DataGridTextBoxColumn18.HeaderText = "做法";
            this.DataGridTextBoxColumn18.MappingName = "operandi";
            this.DataGridTextBoxColumn18.Width = 60;
            // 
            // DataGridTextBoxColumn19
            // 
            this.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn19.Format = "";
            this.DataGridTextBoxColumn19.FormatInfo = null;
            this.DataGridTextBoxColumn19.HeaderText = "口味";
            this.DataGridTextBoxColumn19.MappingName = "taste";
            this.DataGridTextBoxColumn19.Width = 60;
            // 
            // DataGridBoolColumn2
            // 
            this.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn2.FalseValue = "0";
            this.DataGridBoolColumn2.HeaderText = "已上菜";
            this.DataGridBoolColumn2.MappingName = "transfered";
            this.DataGridBoolColumn2.NullText = "";
            this.DataGridBoolColumn2.NullValue = "1";
            this.DataGridBoolColumn2.TrueValue = "2";
            this.DataGridBoolColumn2.Width = 45;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.MappingName = "barcode";
            this.DataGridTextBoxColumn4.Width = 0;
            // 
            // dgFoodList
            // 
            this.dgFoodList.AllowNavigation = false;
            this.dgFoodList.AllowSorting = false;
            this.dgFoodList.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dgFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFoodList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgFoodList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgFoodList.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgFoodList.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodList.CaptionText = "菜品列表";
            this.dgFoodList.DataMember = "";
            this.dgFoodList.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgFoodList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodList.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dgFoodList.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgFoodList.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodList.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgFoodList.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgFoodList.LinkColor = System.Drawing.Color.Teal;
            this.dgFoodList.Location = new System.Drawing.Point(600, 112);
            this.dgFoodList.Name = "dgFoodList";
            this.dgFoodList.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dgFoodList.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodList.ReadOnly = true;
            this.dgFoodList.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgFoodList.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgFoodList.Size = new System.Drawing.Size(240, 512);
            this.dgFoodList.TabIndex = 2;
            this.dgFoodList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle3});
            this.dgFoodList.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dgFoodList_Navigate);
            this.dgFoodList.DoubleClick += new System.EventHandler(this.dgFoodList_DoubleClick);
            // 
            // DataGridTableStyle3
            // 
            this.DataGridTableStyle3.DataGrid = this.dgFoodList;
            this.DataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn7,
            this.DataGridTextBoxColumn8,
            this.DataGridTextBoxColumn9,
            this.DataGridTextBoxColumn10,
            this.DataGridTextBoxColumn11,
            this.DataGridTextBoxColumn12,
            this.DataGridTextBoxColumn3});
            this.DataGridTableStyle3.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle3.MappingName = "foodlist";
            // 
            // DataGridTextBoxColumn7
            // 
            this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn7.Format = "";
            this.DataGridTextBoxColumn7.FormatInfo = null;
            this.DataGridTextBoxColumn7.HeaderText = "菜品编码";
            this.DataGridTextBoxColumn7.MappingName = "foodcode";
            this.DataGridTextBoxColumn7.Width = 55;
            // 
            // DataGridTextBoxColumn8
            // 
            this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn8.Format = "";
            this.DataGridTextBoxColumn8.FormatInfo = null;
            this.DataGridTextBoxColumn8.HeaderText = "菜品名称";
            this.DataGridTextBoxColumn8.MappingName = "foodname";
            this.DataGridTextBoxColumn8.Width = 75;
            // 
            // DataGridTextBoxColumn9
            // 
            this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn9.Format = "";
            this.DataGridTextBoxColumn9.FormatInfo = null;
            this.DataGridTextBoxColumn9.HeaderText = "单位";
            this.DataGridTextBoxColumn9.MappingName = "unit";
            this.DataGridTextBoxColumn9.Width = 40;
            // 
            // DataGridTextBoxColumn10
            // 
            this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn10.Format = "";
            this.DataGridTextBoxColumn10.FormatInfo = null;
            this.DataGridTextBoxColumn10.HeaderText = "价格";
            this.DataGridTextBoxColumn10.MappingName = "price";
            this.DataGridTextBoxColumn10.Width = 50;
            // 
            // DataGridTextBoxColumn11
            // 
            this.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn11.Format = "";
            this.DataGridTextBoxColumn11.FormatInfo = null;
            this.DataGridTextBoxColumn11.HeaderText = "拼音码";
            this.DataGridTextBoxColumn11.MappingName = "spell";
            this.DataGridTextBoxColumn11.Width = 50;
            // 
            // DataGridTextBoxColumn12
            // 
            this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn12.Format = "";
            this.DataGridTextBoxColumn12.FormatInfo = null;
            this.DataGridTextBoxColumn12.HeaderText = "类别编码";
            this.DataGridTextBoxColumn12.MappingName = "foodtypecode";
            this.DataGridTextBoxColumn12.Width = 50;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "菜品类别";
            this.DataGridTextBoxColumn3.MappingName = "typename";
            this.DataGridTextBoxColumn3.Width = 75;
            // 
            // cbTableType
            // 
            this.cbTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableType.Location = new System.Drawing.Point(104, 64);
            this.cbTableType.MaxDropDownItems = 15;
            this.cbTableType.Name = "cbTableType";
            this.cbTableType.Size = new System.Drawing.Size(120, 20);
            this.cbTableType.TabIndex = 12;
            this.cbTableType.SelectedIndexChanged += new System.EventHandler(this.cbTableType_SelectedIndexChanged);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(8, 64);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "桌台类别/位置：";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFoodCode
            // 
            this.txtFoodCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodCode.Location = new System.Drawing.Point(672, 88);
            this.txtFoodCode.Name = "txtFoodCode";
            this.txtFoodCode.Size = new System.Drawing.Size(168, 21);
            this.txtFoodCode.TabIndex = 18;
            this.txtFoodCode.Visible = false;
            this.txtFoodCode.TextChanged += new System.EventHandler(this.txtFoodCode_TextChanged);
            this.txtFoodCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFoodCode_KeyDown);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabel1.Location = new System.Drawing.Point(600, 88);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(72, 23);
            this.LinkLabel1.TabIndex = 19;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "菜品过滤：";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
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
            this.ImageList1.Images.SetKeyName(6, "");
            this.ImageList1.Images.SetKeyName(7, "");
            this.ImageList1.Images.SetKeyName(8, "");
            this.ImageList1.Images.SetKeyName(9, "");
            this.ImageList1.Images.SetKeyName(10, "");
            this.ImageList1.Images.SetKeyName(11, "");
            this.ImageList1.Images.SetKeyName(12, "");
            this.ImageList1.Images.SetKeyName(13, "");
            this.ImageList1.Images.SetKeyName(14, "");
            // 
            // ToolBar1
            // 
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton15,
            this.ToolBarButton20,
            this.ToolBarButton6,
            this.ToolBarButton7,
            this.ToolBarButton21,
            this.ToolBarButton8,
            this.ToolBarButton12,
            this.ToolBarButton18,
            this.ToolBarButton9,
            this.ToolBarButton10,
            this.ToolBarButton5,
            this.ToolBarButton19,
            this.ToolBarButton17,
            this.ToolBarButton11,
            this.ToolBarButton13,
            this.ToolBarButton14,
            this.ToolBarButton16});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(848, 53);
            this.ToolBar1.TabIndex = 20;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "开台";
            this.ToolBarButton1.ToolTipText = "对选中桌台进行开台操作";
            // 
            // ToolBarButton2
            // 
            this.ToolBarButton2.ImageIndex = 1;
            this.ToolBarButton2.Name = "ToolBarButton2";
            this.ToolBarButton2.Text = "加单";
            this.ToolBarButton2.ToolTipText = "向选中桌台进行加单操作";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 2;
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Text = "加菜";
            this.ToolBarButton3.ToolTipText = "向选中桌台及当前单据进行加菜操作";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.ImageIndex = 3;
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Text = "传菜";
            this.ToolBarButton4.ToolTipText = "对选中菜品进行传菜操作";
            // 
            // ToolBarButton15
            // 
            this.ToolBarButton15.ImageIndex = 12;
            this.ToolBarButton15.Name = "ToolBarButton15";
            this.ToolBarButton15.Text = "催菜";
            this.ToolBarButton15.ToolTipText = "对选中菜品进行催菜操作";
            // 
            // ToolBarButton20
            // 
            this.ToolBarButton20.Name = "ToolBarButton20";
            this.ToolBarButton20.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.ImageIndex = 4;
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Text = "转台";
            this.ToolBarButton6.ToolTipText = "对选中桌台进行转台操作";
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 5;
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Text = "并台";
            this.ToolBarButton7.ToolTipText = "对选中桌台进行并台操作";
            // 
            // ToolBarButton21
            // 
            this.ToolBarButton21.ImageIndex = 4;
            this.ToolBarButton21.Name = "ToolBarButton21";
            this.ToolBarButton21.Text = "转并台";
            // 
            // ToolBarButton8
            // 
            this.ToolBarButton8.Name = "ToolBarButton8";
            this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton12
            // 
            this.ToolBarButton12.ImageIndex = 6;
            this.ToolBarButton12.Name = "ToolBarButton12";
            this.ToolBarButton12.Text = "套餐";
            this.ToolBarButton12.ToolTipText = "向选中桌台及当前单据添加套餐";
            // 
            // ToolBarButton18
            // 
            this.ToolBarButton18.Name = "ToolBarButton18";
            this.ToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton9
            // 
            this.ToolBarButton9.ImageIndex = 9;
            this.ToolBarButton9.Name = "ToolBarButton9";
            this.ToolBarButton9.Text = "删单据";
            this.ToolBarButton9.ToolTipText = "删除当前单据";
            // 
            // ToolBarButton10
            // 
            this.ToolBarButton10.ImageIndex = 10;
            this.ToolBarButton10.Name = "ToolBarButton10";
            this.ToolBarButton10.Text = "删菜品";
            this.ToolBarButton10.ToolTipText = "删除当前选中的菜品";
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton19
            // 
            this.ToolBarButton19.ImageIndex = 14;
            this.ToolBarButton19.Name = "ToolBarButton19";
            this.ToolBarButton19.Text = "消费单";
            // 
            // ToolBarButton17
            // 
            this.ToolBarButton17.ImageIndex = 8;
            this.ToolBarButton17.Name = "ToolBarButton17";
            this.ToolBarButton17.Text = "结帐";
            this.ToolBarButton17.ToolTipText = "对当前桌台进行结账操作";
            // 
            // ToolBarButton11
            // 
            this.ToolBarButton11.Name = "ToolBarButton11";
            this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton13
            // 
            this.ToolBarButton13.ImageIndex = 13;
            this.ToolBarButton13.Name = "ToolBarButton13";
            this.ToolBarButton13.Text = "返位";
            this.ToolBarButton13.ToolTipText = "将已结帐的桌台重新设为开台状态并还原结帐金额";
            // 
            // ToolBarButton14
            // 
            this.ToolBarButton14.Name = "ToolBarButton14";
            this.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton16
            // 
            this.ToolBarButton16.ImageIndex = 11;
            this.ToolBarButton16.Name = "ToolBarButton16";
            this.ToolBarButton16.Text = "关闭";
            this.ToolBarButton16.ToolTipText = "关闭当前窗口";
            // 
            // cbFoodType
            // 
            this.cbFoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodType.Location = new System.Drawing.Point(672, 88);
            this.cbFoodType.MaxDropDownItems = 15;
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.Size = new System.Drawing.Size(168, 20);
            this.cbFoodType.TabIndex = 21;
            this.cbFoodType.SelectedIndexChanged += new System.EventHandler(this.cbFoodType_SelectedIndexChanged);
            // 
            // cbDeptList
            // 
            this.cbDeptList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDeptList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeptList.Location = new System.Drawing.Point(672, 64);
            this.cbDeptList.MaxDropDownItems = 15;
            this.cbDeptList.Name = "cbDeptList";
            this.cbDeptList.Size = new System.Drawing.Size(168, 20);
            this.cbDeptList.TabIndex = 22;
            this.cbDeptList.SelectedIndexChanged += new System.EventHandler(this.cbDeptList_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.Location = new System.Drawing.Point(608, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 23);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "部门：";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputBill
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(848, 630);
            this.Controls.Add(this.cbDeptList);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ToolBar1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.cbTableType);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dgFoodList);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgTableStatus);
            this.Controls.Add(this.cbFoodType);
            this.Controls.Add(this.txtFoodCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "InputBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入单据";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closed += new System.EventHandler(this.InputBill_Closed);
            this.Load += new System.EventHandler(this.InputBill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBill_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableStatus)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOpenPsn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		
		
		//获取桌台类别/位置，返回dataview
		public DataTable LoadTableType()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM TableType", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
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
		
		//获取部门列表
		public DataTable LoadDeptList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT deptname FROM department where depttype='菜品制作' order by deptname", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
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
		
		//获取菜品类别
		public DataTable LoadFoodType(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (deptname == "全部")
				{
					selectCMD.CommandText = "SELECT typename FROM view_foodtype order by typename";
				}
				else
				{
					selectCMD.CommandText = "SELECT typename FROM view_foodtype where deptname='" + deptname + "' order by typename";
				}
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
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
		
		//返回相应桌台类别/位置的桌台列表，并填充桌台列表
		private void GetTableList(string tabletypename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT tableno,tablename,status FROM TableStatus";
				if (tabletypename != "全部")
				{
					selectCMD.CommandText = selectCMD.CommandText + " where TabletypeCode='" + rms_var.GetTableTypeCode(tabletypename) + "'";
				}
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "TableStatus");
				dgTableStatus.DataSource = null;
				dgTableStatus.DataSource = dbDS;
				dgTableStatus.DataMember = "tablestatus";
				
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
		
		//返回相应菜品类别的菜品列表
		//OrderFood表示是菜品库还是该桌台已点菜品列表 1=原始菜品库 0=已点菜品列表
		private void GetFoodList(string filter, int FilterMode, int OrderFood, string Tableno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (OrderFood == 1) //返回原始菜品库
				{
					selectCMD.CommandText = "SELECT * FROM view_FoodList";
					if (filter != "")
					{
						switch (FilterMode)
						{
							case 0: //菜品编码
								selectCMD.CommandText = selectCMD.CommandText + " where foodCode like '" + filter + "%'";
								break;
							case 1: //菜品拼音码
								selectCMD.CommandText = selectCMD.CommandText + " where spell like '" + filter + "%'";
								break;
							case 2: //菜品类别编码
								selectCMD.CommandText = selectCMD.CommandText + " where foodtypeCode like '" + filter + "%'";
								break;
							case 3: //菜品类别名称
								if (filter != "全部")
								{
									selectCMD.CommandText = selectCMD.CommandText + " where typename like '" + filter + "%'";
								}
								break;
						}
					}
				}
				else //已点菜品列表
				{
					selectCMD.CommandText = "SELECT * FROM salelist_t";
					if (filter != "")
					{
						switch (FilterMode)
						{
							case 0: //菜品编码
								selectCMD.CommandText = selectCMD.CommandText + " where foodCode like '" + filter + "%'";
								break;
							case 1: //菜品拼音码
								selectCMD.CommandText = selectCMD.CommandText + " where spell like '" + filter + "%'";
								break;
							case 2: //菜品类别编码
								selectCMD.CommandText = selectCMD.CommandText + " where foodtypeCode like '" + filter + "%'";
								break;
							case 3: //菜品类别名称
								if (filter != "全部")
								{
									selectCMD.CommandText = selectCMD.CommandText + " where typename like '" + filter + "%'";
								}
								break;
						}
					}
				}
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "FoodList");
				dgFoodList.DataSource = null;
				dgFoodList.DataSource = dbDS;
				dgFoodList.DataMember = "FoodList";
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
		
		//返回当前桌台的单据列表
		private void GetTableBills(string Tableno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT billno FROM view_salebill_t where tableno='" + Tableno + "'";
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "TableBills");
				//填充该桌台的单据列表
				BillList = new string[dbDS.Tables[0].Rows.Count - 1 + 1];
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					BillList[i] = dbDS.Tables[0].Rows[i]["billno"].ToString();
				}
				BillCount = dbDS.Tables[0].Rows.Count;
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
		
		//返回第一条单据
		private void SetFirstBillNum()
		{
			if (BillCount > 0)
			{
				if (BillCount == 1)
				{
					btnPrior.Enabled = false;
					btnNext.Enabled = false;
				}
				else
				{
					btnPrior.Enabled = false;
					btnNext.Enabled = true;
				}
				//返回第一条单据
				CurrentBillNo = BillList[0];
				CurrentBillNum = 0;
			}
			else
			{
				CurrentBillNo = "";
			}
		}
		
		//返回最后一条单据
		private void SetLastBillNum()
		{
			if (BillCount > 0)
			{
				if (BillCount == 1)
				{
					btnPrior.Enabled = false;
					btnNext.Enabled = false;
				}
				else
				{
					btnPrior.Enabled = true;
					btnNext.Enabled = false;
				}
				
				CurrentBillNo = BillList[BillList.GetUpperBound(0)];
				CurrentBillNum = BillList.GetUpperBound(0);
			}
			else
			{
				CurrentBillNo = "";
			}
		}
		
		//返回相关桌台和单据号的菜品列表
		private void GetRelateFoods(string tableno, string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM saledfoods where tableno='" + tableno + "'" + " and billno='" + billno + "'";
				
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "SaleFoods");
				//填充该桌台的单据列表
				dgSaleFoods.DataSource = null;
				dgSaleFoods.DataSource = dbDS;
				dgSaleFoods.DataMember = "SaleFoods";
				
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
		
		//开台
		private bool OpenTableAndAddBill(string tableno)
		{
			//打开开台、单据录入窗口
			AddForm addfrm = new AddForm();
			addfrm.Text = "开台/新建单据";
			addfrm.frmmode = 1;
			addfrm.GetConsumeBillTypeList(); //开台新建单据只允许添加消费单据
            addfrm.ComboBox1.Text = addfrm.ComboBox1.Items[0].ToString();
			addfrm.Label5.Text = "请为 " + tableno + " 号桌台开台并添加消费单据";
			
			addfrm.ShowDialog();
			if (addfrm.DialogResult == DialogResult.OK)
			{
				rms_var.ExeOpenTable(tableno, System.Convert.ToInt32(addfrm.NumericUpDown1.Value), addfrm.TextBox2.Text);
				string serialno;
				serialno = rms_var.GenUniqueCode();
				rms_var.AddBalanceTable(serialno, tableno, addfrm.NumericUpDown1.Value.ToString(), addfrm.TextBox2.Text);
				GetTableList(cbTableType.Text);
				//准备添加第一张单据
				if (! rms_var.SameBillinSale(addfrm.TextBox1.Text, addfrm.ComboBox1.Text))
				{
					if (rms_var.AddSaleBill(serialno, tableno, addfrm.TextBox1.Text, rms_var.GetBillTypeCode(addfrm.ComboBox1.Text), addfrm.TextBox2.Text))
					{
						CurrentTableNo = tableno;
						CurrentBillNo = addfrm.TextBox1.Text;
						CurrentBillTypename = addfrm.ComboBox1.Text;
					}
					else
					{
						MessageBox.Show("加单操作失败！已分配的单据号可能已被其他客户端抢先使用，请重新执行加单操作。");
					}
				}
				else
				{
					MessageBox.Show("开台已成功但加单失败（存在同号单据），请手动执行加单操作。");
				}
                //这里添加桌台的其他信息



                //End
				return true;
			}
			else
			{
				return false;
			}
		}
		
		//转台 使用 - 空闲
		private void MoveTable(string SerialNo, string srcTableno)
		{
			//检测桌台属性
			//0=空闲，1=使用，2=预定中，-1=不存在该桌台
			
			dgSaleFoods.DataSource = null;
			
			int srcts;
			srcts = rms_var.GetTableStatus(srcTableno);
			switch (srcts)
			{
				case 0: //原桌台空闲
					MessageBox.Show("原桌台空闲，您不可以为该桌台进行转台操作。请首先进行开台操作。");
					return;
				case 1: //原桌台使用中
					//检测目标桌台状态
					frmDestTableno frmdt = new frmDestTableno();
					frmdt.ShowDialog();
					if (frmdt.DialogResult == DialogResult.OK)
					{
						string dstTableno;
						int dstts;
						
						dstTableno = frmdt.TextBox1.Text;
						dstts = rms_var.GetTableStatus(dstTableno);
						switch (dstts)
						{
							case 0: //目标桌台空闲，允许转台
								//转台操作
								System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
								conn.ConnectionString = rms_var.ConnStr;
								try
								{
									SqlCommand SQLCMD = new SqlCommand();
									SQLCMD.Connection = conn;
									SQLCMD.CommandTimeout = 30;
									SQLCMD.CommandText = "update salebill_t set tableno='" + dstTableno + "' where serialno='" + SerialNo + "' and tableno='" + srcTableno + "'";
									conn.Open();
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "update BalanceTable_t set tableno='" + dstTableno + "' where serialno='" + SerialNo + "' and tableno='" + srcTableno + "'";
									
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "update tablestatus set status='0' where tableno='" + srcTableno + "'";
									
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "update tablestatus set status='1',peoplenumber=" + rms_var.GetTablePsnCount(srcTableno) + ",begintime='" + rms_var.GetTableBeginTime(srcTableno) + "' where tableno='" + dstTableno + "'";
									
									SQLCMD.ExecuteNonQuery();
									
									MessageBox.Show("转台操作顺利完成");
									GetTableList(cbTableType.Text);
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.ToString());
								}
								finally
								{
									conn.Close();
								}
								break;
							case 1: //目标桌台使用中 不允许转台
								MessageBox.Show("目标桌台为使用状态，您不可以为该桌台进行转台操作。请选择状态为空闲的目标桌台进行操作。");
								return;
							case 2: //目标桌台预定中 不允许转台
								MessageBox.Show("目标桌台为预定状态，您不可以为该桌台进行转台操作。请选择状态为空闲的目标桌台进行操作。");
								return;
							case -1:
								MessageBox.Show("目标桌台不存在");
								break;
						}
					}
					break;
				case 2: //原桌台预定中
					MessageBox.Show("原桌台预定中，您不可以为该桌台进行进行转台操作。请首先进行开台操作。");
					return;
			}
		}
		
		//转台 使用 - 使用
		private void MoveTable1(string SrcSerialNo, string srcTableno)
		{
			//检测桌台属性
			//0=空闲，1=使用，2=预定中，-1=不存在该桌台
			
			dgSaleFoods.DataSource = null;
			
			int srcts;
			srcts = rms_var.GetTableStatus(srcTableno);
			switch (srcts)
			{
				case 0: //原桌台空闲
					MessageBox.Show("原桌台空闲，您不可以为该桌台进行转台操作。请首先进行开台操作。");
					return;
				case 1: //原桌台使用中
					//检测目标桌台状态
					frmDestTableno frmdt = new frmDestTableno();
					frmdt.ShowDialog();
					if (frmdt.DialogResult == DialogResult.OK)
					{
						string dstTableno;
						int dstts;
						
						dstTableno = frmdt.TextBox1.Text;
						string DstTableSerialno;
						DstTableSerialno = rms_var.GetCurrentTableSerialNo(dstTableno);
						dstts = rms_var.GetTableStatus(dstTableno);
						switch (dstts)
						{
							case 0: //目标桌台空闲，不允许转台
								MessageBox.Show("目标桌台为空闲状态，您不可以为该桌台进行转台操作。请选择状态为使用的目标桌台进行操作。");
								return;
							case 1: //目标桌台使用中 允许转台
								//转台操作
								System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
								conn.ConnectionString = rms_var.ConnStr;
								try
								{
									SqlCommand SQLCMD = new SqlCommand();
									SQLCMD.Connection = conn;
									SQLCMD.CommandTimeout = 30;
									SQLCMD.CommandText = "update salebill_t set tableno='" + dstTableno + "',serialno='" + DstTableSerialno + "'" + " where serialno='" + SrcSerialNo + "' and tableno='" + srcTableno + "'";
									conn.Open();
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "update salelist_t set serialno='" + DstTableSerialno + "' where serialno='" + SrcSerialNo + "'";
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "delete BalanceTable_t  where serialno='" + SrcSerialNo + "' and tableno='" + srcTableno + "'";
									
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "update tablestatus set status='0' where tableno='" + srcTableno + "'";
									
									SQLCMD.ExecuteNonQuery();
									SQLCMD.CommandText = "update tablestatus set status='1',peoplenumber=" + (int.Parse(rms_var.GetTablePsnCount(srcTableno)) + int.Parse(rms_var.GetTablePsnCount(dstTableno))).ToString() + ",begintime='" + rms_var.GetTableBeginTime(srcTableno) + "' where tableno='" + dstTableno + "'";
									
									SQLCMD.ExecuteNonQuery();
									MessageBox.Show("转台操作顺利完成");
									GetTableList(cbTableType.Text);
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.ToString());
								}
								finally
								{
									conn.Close();
								}
								break;
							case 2: //目标桌台预定中 不允许转台
								MessageBox.Show("目标桌台为预定状态，您不可以为该桌台进行转台操作。请选择状态为空闲的目标桌台进行操作。");
								return;
							case -1:
								MessageBox.Show("目标桌台不存在");
								break;
						}
					}
					break;
				case 2: //原桌台预定中
					MessageBox.Show("原桌台预定中，您不可以为该桌台进行转台操作。请首先进行开台操作。");
					return;
			}
		}
		
		//并台
		private void CompineTable(string SrcSerialNo, string srcTableno)
		{
			//检测桌台属性
			//0=空闲，1=使用，2=预定中，-1=不存在该桌台
			
			dgSaleFoods.DataSource = null;
			
			int srcts;
			srcts = rms_var.GetTableStatus(srcTableno);
			switch (srcts)
			{
				case 0: //原桌台空闲
					MessageBox.Show("原桌台空闲，您不可以为该桌台进行并台操作。请首先进行开台操作。");
					return;
				case 1: //原桌台使用中
					//检测目标桌台状态
					frmDestTableno frmdt = new frmDestTableno();
					frmdt.ShowDialog();
					if (frmdt.DialogResult == DialogResult.OK)
					{
						string dstTableno;
						int dstts;
						
						dstTableno = frmdt.TextBox1.Text;
						dstts = rms_var.GetTableStatus(dstTableno);
						switch (dstts)
						{
							case 0: //目标桌台空闲，不允许并台
								MessageBox.Show("目标桌台为空闲状态，您不可以为该桌台进行并台操作。请选择状态为使用的目标桌台进行操作。");
								return;
							case 1: //目标桌台使用中 允许并台
								if (MessageBox.Show("原桌台的服务费和超时费将会丢失，确定要并台吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
								{
									System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
									conn.ConnectionString = rms_var.ConnStr;
									try
									{
										string DstTableSerialno;
										DstTableSerialno = rms_var.GetCurrentTableSerialNo(dstTableno);
										
										//将两个桌台的 serialno 进行统一
										
										SqlCommand SQLCMD = new SqlCommand();
										SQLCMD.Connection = conn;
										SQLCMD.CommandTimeout = 30;
										conn.Open();
										
										SQLCMD.CommandText = "update balancetable_t set serialno='" + DstTableSerialno + "' where serialno='" + SrcSerialNo + "'";
										SQLCMD.ExecuteNonQuery();
										
										SQLCMD.CommandText = "update salebill_t set serialno='" + DstTableSerialno + "' where serialno='" + SrcSerialNo + "'";
										SQLCMD.ExecuteNonQuery();
										
										SQLCMD.CommandText = "update salelist_t set serialno='" + DstTableSerialno + "' where serialno='" + SrcSerialNo + "'";
										SQLCMD.ExecuteNonQuery();
										
										MessageBox.Show("并台操作顺利完成");
										GetTableList(cbTableType.Text);
										
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
								break;
							case 2: //目标桌台预定中 不允许并台
								MessageBox.Show("目标桌台为预定状态，您不可以为该桌台进行并台操作。请选择状态为使用的目标桌台进行操作。");
								return;
							case -1:
								MessageBox.Show("目标桌台不存在");
								break;
						}
					}
					break;
				case 2: //原桌台预定中
					MessageBox.Show("原桌台预定中，您不可以为该桌台进行并台操作。请首先进行开台操作。");
					return;
			}
		}
		
		//加单
		private void AddBill(string tableno)
		{
			//打开单据录入窗口
			AddForm addfrm = new AddForm();
			addfrm.Text = "添加单据";
			addfrm.frmmode = 0;
			//Dim tableno As String
			//tableno = dgTableStatus.Item(dgTableStatus.CurrentRowIndex, 0)
			CurrentTableNo = tableno;
			//检测当前桌台是否有消费单据
			if (rms_var.TableConsumeBillExists(tableno))
			{
				addfrm.GetBillTypeList();
			}
			else
			{
				addfrm.GetConsumeBillTypeList();
			}
			
			addfrm.NumericUpDown1.Visible = false;
			addfrm.Label3.Visible = false;
			addfrm.Label5.Text = "请为 " + tableno + " 号桌台加单";

            addfrm.ComboBox1.Text = addfrm.ComboBox1.Items[0].ToString();
			addfrm.ShowDialog();
			if (addfrm.DialogResult == DialogResult.OK)
			{
				//准备添加单据
				if (! rms_var.SameBillinSale(addfrm.TextBox1.Text, addfrm.ComboBox1.Text))
				{
					if (rms_var.AddSaleBill(rms_var.GetCurrentTableSerialNo(tableno), tableno, addfrm.TextBox1.Text, rms_var.GetBillTypeCode(addfrm.ComboBox1.Text), addfrm.TextBox2.Text))
					{
						CurrentBillNo = addfrm.TextBox1.Text;
						MessageBox.Show("加单操作顺利完成");
						//刷新桌台的单据列表
						ShowBill(CurrentTableNo, "last");
					}
					else
					{
						MessageBox.Show("加单操作失败！已分配的单据号可能已被其他客户端抢先使用，请重新执行加单操作。");
					}
				}
				else
				{
					MessageBox.Show("加单操作失败！已经存在同号单据，请重新执行加单操作。");
				}
			}
		}
		
		//向点菜单添加菜品
		private void AddFoodToConsumeBill(string tableno, string billno, string billtypename)
		{
			//不允许超过6条
			//If dgSaleFoods.VisibleRowCount >= 10 Then
			//MsgBox("抱歉，非正式版本只允许添加10道菜品！")
			//Exit Sub
			//End If
			
			AddFood frmOrderFoodInfo = new AddFood();
            frmOrderFoodInfo.Label1.Text = dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString();
            frmOrderFoodInfo.Label5.Text = "单位：" + dgFoodList[dgFoodList.CurrentRowIndex, 2].ToString();
			
			//定制菜，允许前台任意修改菜品价格
            if (rms_var.IsCustomFood(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()))
			{
                frmOrderFoodInfo.numFoodPrice.Value = decimal.Parse(rms_var.GetFoodPrice(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(), false));
				frmOrderFoodInfo.numFoodPrice.BringToFront();
				frmOrderFoodInfo.numFoodPrice.Show();
			}
			else
			{
				frmOrderFoodInfo.Label7.Text = rms_var.GetFoodPrice(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(), false);
				frmOrderFoodInfo.numFoodPrice.BringToFront();
			}
			
			frmOrderFoodInfo.ShowDialog();
			if (frmOrderFoodInfo.DialogResult == DialogResult.OK)
			{
                rms_var.AddFoodtoBill(rms_var.GetCurrentTableSerialNo(tableno), rms_var.GenUniqueCode(), billno, rms_var.GetBillTypeCode(billtypename), dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(), System.Convert.ToString(frmOrderFoodInfo.FoodQuantity * frmOrderFoodInfo.FoodUnitPrice), frmOrderFoodInfo.FoodQuantity, 0, frmOrderFoodInfo.FoodOperandi, frmOrderFoodInfo.FoodTaste, rms_var.opinfo.OpID, "", 0);
				GetRelateFoods(tableno, billno);
				GetOpenedTableInfo(tableno, billno);
				
				
				//检测是否自动传菜
				if (rms_var.GetSysSetup("autoPrintFood") == "1") //点菜后自动传菜
				{
					//传送当前菜品
                    if (rms_var.TransFood_Rmt_Async(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(), rms_var.GetTableTypeName(tableno), tableno, rms_var.GetTablePsnCount(tableno), billno, rms_var.GetFoodName(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()), rms_var.GetFoodTypeName(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()), rms_var.GetFoodDeptName(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()), rms_var.GetFoodUnit(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()), frmOrderFoodInfo.FoodQuantity.ToString(), frmOrderFoodInfo.FoodOperandi, frmOrderFoodInfo.FoodTaste, rms_var.opinfo.OpID, rms_var.GetSaledFoodBarcode(CurrentBillNo, dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()), 0, ""))
						{
						
						//更新菜品传送标记
                            rms_var.UpdateFoodTransSign(rms_var.GetSaledFoodBarcode(CurrentBillNo, dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()));
						ShowTable(tableno);
                        MessageBox.Show("菜品 " + rms_var.GetFoodName(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()) + " 传送成功！");
					}
				}
			}
		}
		
		//向取消单中添加菜品
		private void AddFoodToCancelBill(string tableno, string billno, string billtypename)
		{
			//先检测当前桌台有无该菜品，有则允许减菜，并返回已经点菜的数量
            if (rms_var.CurrentTableExistsFood(tableno, dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()))
			{
				//返回当前菜品已点的数量
				frmCancelFoodQty frmcfq = new frmCancelFoodQty();
				double maxCancelqty;
				//Dim Cancelqty As Double
				
				maxCancelqty = rms_var.GetCurrentTableAllowCancelFoodQty(tableno,dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString());
				
				frmcfq.NumericUpDown1.Maximum = (decimal) maxCancelqty;
				frmcfq.ShowDialog();
				if (frmcfq.DialogResult == DialogResult.OK)
				{
					if (!(double.Parse(frmcfq.NumericUpDown1.Value.ToString())> maxCancelqty))
					{
						rms_var.AddFoodtoBill(rms_var.GetCurrentTableSerialNo(tableno), rms_var.GenUniqueCode(), billno, rms_var.GetBillTypeCode(billtypename),dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(),(double.Parse(frmcfq.NumericUpDown1.Value.ToString()) * double.Parse(rms_var.GetFoodPrice(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(), false))).ToString(), 0, (double) frmcfq.NumericUpDown1.Value, "", "", rms_var.opinfo.OpID, "", 0);
						MessageBox.Show("加菜操作顺利完成");
						GetRelateFoods(tableno, billno);
						GetOpenedTableInfo(tableno, billno);
					}
					else
					{
						MessageBox.Show("退菜数量不能大于已点菜品的最大数量");
					}
				}
			}
			else
			{
				MessageBox.Show("当前桌台没有点该菜品，您不能将没有点过的菜品加到退菜单中。");
			}
		}
		
		private double SuitInBillCount(string serialno, string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
			conn1.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn1;
				selectCMD1.CommandText = "select count(*),suitquantity from salelist_t where serialno='" + serialno + "' and suitcode='" + suitcode + "' group by suitcode,suitquantity";
				selectCMD1.CommandTimeout = 30;
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				dbDA1.SelectCommand = selectCMD1;
				conn1.Open();
				DataSet dbDS1 = new DataSet();
				dbDA1.Fill(dbDS1, "t");
				return double.Parse(dbDS1.Tables[0].Rows[0]["suitquantity"].ToString());
			}
			catch (Exception)
			{
				//MessageBox.Show(ex.ToString)
				return 0;
			}
			finally
			{
				conn1.Close();
			}
		}
		
		//向消费单中添加套餐
		private void AddSuitToBill(string suitcode, string tableno, string billno, double suitquantity)
		{
			//获取套餐中菜品
			System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
			conn1.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn1;
				selectCMD1.CommandText = "SELECT foodcode,foodname,unit,foodqty,foodprice FROM view_suitfoods where suitcode='" + suitcode + "'";
				selectCMD1.CommandTimeout = 30;
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				dbDA1.SelectCommand = selectCMD1;
				conn1.Open();
				DataSet dbDS1 = new DataSet();
				dbDA1.Fill(dbDS1, "t");
				//检测当前serialno下有无相同suitcode的套餐
				string CurrentTableSerialNo = rms_var.GetCurrentTableSerialNo(tableno);
				double suitcount = SuitInBillCount(CurrentTableSerialNo, suitcode);
				//若有则 suitcount会 > 0，添加菜品时更新 suitquantity = suitquantity + suitcount
				double totalsuitquantity = suitquantity + suitcount;
				string SuitFoodGuid = rms_var.GenUniqueCode();
				for (int i = 0; i <= dbDS1.Tables[0].Rows.Count - 1; i++)
				{
					//添加套餐中的菜品
					rms_var.AddFoodtoBill(CurrentTableSerialNo, SuitFoodGuid, billno, rms_var.GetBillNoTypeCode(billno),dbDS1.Tables[0].Rows[i]["foodcode"].ToString(),dbDS1.Tables[0].Rows[i]["foodprice"].ToString(), suitquantity * double.Parse(dbDS1.Tables[0].Rows[i]["foodqty"].ToString()), 0, "", "", rms_var.opinfo.OpID, suitcode, suitquantity);
					
				}
				selectCMD1.CommandText = "update salelist_t set suitquantity=" + totalsuitquantity.ToString() + " where serialno='" + CurrentTableSerialNo + "' and suitcode='" + suitcode + "'";
				selectCMD1.ExecuteNonQuery();
				MessageBox.Show("加菜操作顺利完成");
				GetRelateFoods(tableno, billno);
				GetOpenedTableInfo(tableno, billno);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn1.Close();
			}
		}
		
		private void ClearBill()
		{
			lblBillno.Text = "单据号：";
			lblBillTypeName.Text = "没有单据";
			lblOpenDate.Text = "开台日期：";
			lblTableno.Text = "桌台号：";
			lblOpenpsn.Text = "开台人数：";
			numOpenPsn.Hide();
			dgSaleFoods.DataSource = null;
			Label1.Text = "";
			Label2.Text = "";
		}
		
		//更新窗口
		private void ShowBill(string tableno, string recno)
		{
			CurrentTableNo = tableno;
			GetTableBills(tableno);
			if (recno == "first")
			{
				SetFirstBillNum();
			}
			else if (recno == "last")
			{
				SetLastBillNum();
			}
			
			if (CurrentBillNo != "")
			{
                lblBillno.Text = "单据号：" + CurrentBillNo;
				CurrentBillTypename = rms_var.GetBillTypeName(rms_var.GetBillNoTypeCode(CurrentBillNo));
				lblBillTypeName.Text = CurrentBillTypename;
				lblOpenDate.Text = "开台日期：" + rms_var.GetTableOpenTime(CurrentTableNo);
				lblTableno.Text = "桌台号：" + CurrentTableNo;
				lblOpenpsn.Text = "开台人数："; //+ GetOpenTablePsn(CurrentTableNo).ToString
				numOpenPsn.Value = rms_var.GetOpenTablePsn(CurrentTableNo);
				numOpenPsn.Show();
				
				if (rms_var.IsCancelBill(rms_var.GetBillNoTypeCode(CurrentBillNo),""))
				{
					CurrentBillIsCancel = true;
					DataGridTextBoxColumn16.MappingName = "decquantity";
				}
				else
				{
					CurrentBillIsCancel = false;
					DataGridTextBoxColumn16.MappingName = "addquantity";
				}
				
				//获得当前桌台及单据菜品记录
				GetRelateFoods(CurrentTableNo, CurrentBillNo);
				GetOpenedTableInfo(CurrentTableNo, CurrentBillNo);
			}
			else
			{
				lblBillno.Text = "单据号：";
				lblBillTypeName.Text = "没有单据";
				lblOpenDate.Text = "开台日期：";
				lblTableno.Text = "桌台号：";
				lblOpenpsn.Text = "开台人数：";
				numOpenPsn.Hide();
				//获得当前桌台及单据菜品记录
				GetRelateFoods(CurrentTableNo, CurrentBillNo);
				Label1.Text = "";
				Label2.Text = "";
			}
		}
		
		//返回桌台信息
		private void GetOpenedTableInfo(string tableno, string billno)
		{
			if (CurrentBillNo != "")
			{
				Label1.Text = "单据数量： " + BillCount.ToString() + "\r\n";
				Label1.Text = Label1.Text + "当前单据菜品数量： " + dgSaleFoods.VisibleRowCount.ToString() + "\r\n";
				if (BillCount > 0)
				{
					if (!rms_var.IsCancelBill(rms_var.GetBillNoTypeCode(billno),""))
					{
						Label2.Text = "当前单据金额： "+rms_var.GetBillPrice(tableno, billno,0)+"\r\n";
					}
					else
					{
						Label2.Text = "当前单据金额： " +rms_var.GetBillPrice(tableno, billno, 1)+"\r\n";
					}
					Label2.Text = Label2.Text + "当前桌台菜品总金额： "+rms_var.GetTablePrice(tableno)+"\r\n";
				}
			}
		}
		
		//tablestatus 桌台操作
		public void ShowTable(string tableno)
		{
			int ts;
			ts = rms_var.GetTableStatus(tableno);
			switch (ts)
			{
				case 0: //桌台空闲
					//准备开台
					if (OpenTableAndAddBill(tableno))
					{
						GetTableBills(CurrentTableNo);
						SetFirstBillNum();
						ShowBill(CurrentTableNo, CurrentBillNo);						
                        //MessageBox.Show("开台操作顺利完成");
					}
					break;
				case 1: //桌台使用中
					//返回使用中桌台的单据列表
					CurrentTableNo = tableno;
					GetTableBills(tableno);
					SetFirstBillNum();
					ShowBill(tableno, CurrentBillNo);
					break;
				case 2: //原桌台预定中
					//返回预订订单号
					System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
					conn1.ConnectionString = rms_var.ConnStr;
					try
					{
						SqlCommand selectCMD1 = new SqlCommand();
						selectCMD1.CommandText = "SELECT top 1 appointno FROM view_appointtable where status='0' and arrivedate='" + DateTime.Now.ToShortDateString() + "' and timeblockcode='" + rms_var.GetTimeBlockCode(rms_var.TimeBlock) + "' and tableno='" + tableno + "'";
						selectCMD1.Connection = conn1;
						selectCMD1.CommandTimeout = 30;
						SqlDataAdapter dbDA1 = new SqlDataAdapter();
						dbDA1.SelectCommand = selectCMD1;
						conn1.Open();
						DataSet dbDS1 = new DataSet();
						dbDA1.Fill(dbDS1, "t");
						string appointno;
						appointno = dbDS1.Tables[0].Rows[0][0].ToString();
						if (rms_var.CompleteAppoint(appointno))
						{
							GetTableList(cbTableType.Text);
							//返回使用中桌台的单据列表
							CurrentTableNo = tableno;
							GetTableBills(tableno);
							SetFirstBillNum();
							ShowBill(tableno, CurrentBillNo);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
					finally
					{
						conn1.Close();
					}
					break;
			}
		}
		
		private void InputBill_Load(System.Object sender, System.EventArgs e)
		{
			DataTable ftabletype;
			ftabletype = LoadTableType();
			//桌台位置获取完毕填充下拉列表框
			for (int i = 0; i <= ftabletype.Rows.Count - 1; i++)
			{
				this.cbTableType.Items.Add(ftabletype.Rows[i]["name"]);
			}
			cbTableType.Items.Add("全部");
			cbTableType.SelectedIndex = 0;
			
			DataTable deptlist;
			deptlist = LoadDeptList();
			for (int i = 0; i <= deptlist.Rows.Count - 1; i++)
			{
				cbDeptList.Items.Add(deptlist.Rows[i]["DeptName"]);
			}
			cbDeptList.Items.Add("全部");
			cbDeptList.SelectedIndex = cbDeptList.Items.Count - 1;
			
			DataTable foodtype;
			foodtype = LoadFoodType(cbDeptList.Text);
			for (int i = 0; i <= foodtype.Rows.Count - 1; i++)
			{
				cbFoodType.Items.Add(foodtype.Rows[i]["TypeName"]);
			}
			//cbFoodType.Items.Add("全部")
			cbFoodType.SelectedIndex = 0; //cbFoodType.Items.Count - 1
			GetFoodList("", 1, 1, "");
		}
		
		private void cbTableType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			GetTableList(cbTableType.Text);
		}
		
		private void dgTableStatus_DoubleClick(object sender, System.EventArgs e)
		{
            ShowTable(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
		}
		
		//点菜
		private void dgFoodList_DoubleClick(object sender, System.EventArgs e)
		{
			if (CurrentBillNo!= "")
			{
				if (!CurrentBillIsCancel)
				{
					AddFoodToConsumeBill(CurrentTableNo, CurrentBillNo, CurrentBillTypename);
				}
				else
				{
					//有无向取消单添加菜品的权限 退菜权限
					if (rms_var.TheAppExt.Chk_op_tc)
					{
						//MsgBox("向取消单中添加菜品")
						AddFoodToCancelBill(CurrentTableNo, CurrentBillNo, CurrentBillTypename);
					}
					else
					{
						MessageBox.Show("您没有退菜的权限。");
					}
				}
			}
			txtFoodCode.Focus();
			txtFoodCode.SelectAll();
		}
		
		//菜品编码输入框
		private void txtFoodCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				//If Not CurrentBillIsCancel Then
				dgFoodList.CurrentRowIndex++;
				dgFoodList.UnSelect(dgFoodList.CurrentRowIndex - 1);
				dgFoodList.Select(dgFoodList.CurrentRowIndex);
				//End If
			}
			
			if (e.KeyCode == Keys.Up)
			{
				//If Not CurrentBillIsCancel Then
				if (dgFoodList.CurrentRowIndex == 0)
				{
					return;
				}
				dgFoodList.CurrentRowIndex--;
				dgFoodList.UnSelect(dgFoodList.CurrentRowIndex + 1);
				dgFoodList.Select(dgFoodList.CurrentRowIndex);
				//End If
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				if (CurrentBillNo != "")
				{
					if (dgFoodList.CurrentRowIndex != -1) //选中菜品条目
					{
						if (! CurrentBillIsCancel)
						{
							AddFoodToConsumeBill(CurrentTableNo, CurrentBillNo, CurrentBillTypename);
						}
						else
						{
							//有无向取消单添加菜品的权限 退菜权限
							if (rms_var.TheAppExt.Chk_op_tc)
							{
								//MsgBox("向取消单中添加菜品")
								AddFoodToCancelBill(CurrentTableNo, CurrentBillNo, CurrentBillTypename);
							}
							else
							{
								MessageBox.Show("您没有退菜的权限。");
							}
						}
					}
				}
				txtFoodCode.Focus();
				txtFoodCode.SelectAll();
			}
		}
		
		private void txtFoodCode_TextChanged(object sender, System.EventArgs e)
		{
			GetFoodList(txtFoodCode.Text, rms_var.FoodInputMode, 1, "");
		}
		
		//上一条单据
		private void btnPrior_Click(System.Object sender, System.EventArgs e)
		{
			if (CurrentBillNum != 0)
			{
				btnNext.Enabled = true;
				//返回上一条单据
				CurrentBillNo = BillList[CurrentBillNum - 1];
				CurrentBillNum--;
				if (CurrentBillNum == 0)
				{
					btnPrior.Enabled = false;
				}
			}
			ShowBill(CurrentTableNo, "0");
		}
		
		//下一条单据
		private void btnNext_Click(System.Object sender, System.EventArgs e)
		{
			if (BillCount > 0 && CurrentBillNum < BillCount - 1)
			{
				btnPrior.Enabled = true;
				//返回下一条单据
				CurrentBillNo = BillList[CurrentBillNum + 1];
				CurrentBillNum++;
				if (CurrentBillNum == BillCount - 1)
				{
					btnNext.Enabled = false;
				}
			}
			ShowBill(CurrentTableNo, "0");
		}
		
		private void InputBill_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmInputBill = null;
		}
		
		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			InputMode inputmode = new InputMode();
			switch (rms_var.FoodInputMode)
			{
				case 0:
					inputmode.RadioButton1.Checked = true;
					break;
				case 1:
					inputmode.RadioButton2.Checked = true;
					break;
				case 2:
					inputmode.RadioButton3.Checked = true;
					break;
				case 3:
					inputmode.RadioButton4.Checked = true;
					break;
			}
			inputmode.ShowDialog();
			if (rms_var.FoodInputMode == 3)
			{
				cbFoodType.Show();
				cbFoodType.BringToFront();
				cbFoodType.Focus();
			}
			else
			{
				txtFoodCode.Show();
				txtFoodCode.BringToFront();
				txtFoodCode.Focus();
				txtFoodCode.SelectAll();
			}
		}
		
		//工具栏按钮
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //开台
					int ts_1;
                    ts_1 = rms_var.GetTableStatus(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					switch (ts_1)
					{
						case 0: //桌台空闲
							//准备开台
                            if (OpenTableAndAddBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString()))
							{
								GetTableBills(CurrentTableNo);
								ShowBill(CurrentTableNo, "first");
                                //MessageBox.Show("开台操作顺利完成");
							}
							break;
						case 1: //桌台使用中
							MessageBox.Show("该桌台已经开台");
							//返回使用中桌台的单据列表
							ShowBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString(), "first");
							break;
						case 2: //原桌台预定中
							break;
							
					}
					break;
				case 1: //加单
					int ts_2;
                    ts_2 = rms_var.GetTableStatus(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					switch (ts_2)
					{
						case 0: //桌台空闲
							//准备开台
                            OpenTableAndAddBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
							break;
						case 1: //桌台使用中
							//先显示单据
                            ShowBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString(), "first");
							//准备加单
                            AddBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
							break;
						case 2: //原桌台预定中
							break;
							
					}
					break;
				case 2: //加菜
					int ts_3;
                    ts_3 = rms_var.GetTableStatus(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					switch (ts_3)
					{
						case 0: //桌台空闲
							//准备开台
                            OpenTableAndAddBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
							break;
						case 1: //桌台使用中
							//返回使用中桌台的单据列表
                            ShowBill(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString(), "first");
							txtFoodCode.Focus();
							txtFoodCode.SelectAll();
							break;
						case 2: //原桌台预定中
							break;
							
					}
					break;
				case 3: //传菜
					//先检测当前单据不是取消单
					if (CurrentBillIsCancel)
					{
						MessageBox.Show("不能对取消单中的菜品进行传菜操作。");
						return;
					}
					
					if (dgSaleFoods.VisibleRowCount > 0)
					{
						if (!dgSaleFoods.IsSelected(dgSaleFoods.CurrentRowIndex))
						{
							MessageBox.Show("请选中需要传菜的菜品记录");
							return;
						}
						if (MessageBox.Show("确定要对选中的菜品进行传菜操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							for (int i = 0; i <= dgSaleFoods.VisibleRowCount - 1; i++)
							{
								if (dgSaleFoods.IsSelected(i))
								{
									//检测是否已经传菜
									if (dgSaleFoods[i, 7].ToString() == "") //已传菜
									{
										MessageBox.Show("当前菜品" + dgSaleFoods[i, 1] + " 已经被传送，不能再进行传菜操作。");
									}
									else if  (dgSaleFoods[i, 7].ToString()=="1") //已上菜)
									{
										MessageBox.Show("当前菜品 " + dgSaleFoods[i, 1] + " 已上菜，因此您不能再进行传菜操作。");
									}
									else
									{
										//传送当前菜品
                                        if (rms_var.TransFood_Rmt_Async(dgSaleFoods[i, 0].ToString(), cbTableType.Text, CurrentTableNo, rms_var.GetTablePsnCount(CurrentTableNo), CurrentBillNo, dgSaleFoods[i, 1].ToString(), rms_var.GetFoodTypeName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodDeptName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodUnit(dgSaleFoods[i, 0].ToString()), dgSaleFoods[i, 3].ToString(), dgSaleFoods[i, 5].ToString(), dgSaleFoods[i, 6].ToString(), rms_var.opinfo.OpID, dgSaleFoods[i, 8].ToString(), 0, ""))
											{
											
											//更新菜品传送标记
                                                rms_var.UpdateFoodTransSign(dgSaleFoods[i, 8].ToString());
											MessageBox.Show("菜品 " + dgSaleFoods[i, 1] + " 传送成功！");
										}
									}
								}
							}
							GetRelateFoods(CurrentTableNo, CurrentBillNo);
						}
					}
					break;
					
				case 4: //催菜
					//先检测当前单据不是取消单
					if (CurrentBillIsCancel)
					{
						MessageBox.Show("不能对取消单中的菜品进行催菜操作。");
						return;
					}
					
					if (dgSaleFoods.VisibleRowCount > 0)
					{
						if (! dgSaleFoods.IsSelected(dgSaleFoods.CurrentRowIndex))
						{
							MessageBox.Show("请选中需要催菜的菜品记录");
							return;
						}
						if (MessageBox.Show("确定要对选中的菜品进行催菜操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							for (int i = 0; i <= dgSaleFoods.VisibleRowCount - 1; i++)
							{
								if (dgSaleFoods.IsSelected(i))
								{
									//检测是否已经传菜
									if (dgSaleFoods[i, 7].ToString() == "") //已传菜
									{
										//催菜当前菜品
                                        if (rms_var.TransFood_Rmt_Async(dgSaleFoods[i, 0].ToString(), cbTableType.Text, CurrentTableNo, rms_var.GetTablePsnCount(CurrentTableNo), CurrentBillNo, dgSaleFoods[i, 1].ToString(), rms_var.GetFoodTypeName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodDeptName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodUnit(dgSaleFoods[i, 0].ToString()), dgSaleFoods[i, 3].ToString(), dgSaleFoods[i, 5].ToString(), dgSaleFoods[i, 6].ToString(), rms_var.opinfo.OpID, dgSaleFoods[i, 8].ToString(), 1, ""))
											{
											MessageBox.Show("菜品 " + dgSaleFoods[i, 1] + " 催菜成功！");
										}
									}
                                    else if (dgSaleFoods[i, 7].ToString() == "1") //已上菜)
									{
										MessageBox.Show("当前菜品 " + dgSaleFoods[i, 1] + " 已上菜，因此您不能再进行催菜操作。");
									}
									else
									{
										MessageBox.Show("当前菜品 " + dgSaleFoods[i, 1] + " 还未被传送，因此您不能进行催菜操作，请首先进行传菜操作。");
									}
								}
							}
							GetRelateFoods(CurrentTableNo, CurrentBillNo);
						}
					}
					break;
					
				case 6: //转台
                    MoveTable(rms_var.GetCurrentTableSerialNo(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString()), dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					//dgTableStatus_DoubleClick(sender, e)
					ClearBill();
					break;
				case 7: //并台
                    CompineTable(rms_var.GetCurrentTableSerialNo(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString()), dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					dgTableStatus_DoubleClick(sender, e);
					break;
				case 8: //转并台
                    MoveTable1(rms_var.GetCurrentTableSerialNo(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString()), dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					//dgTableStatus_DoubleClick(sender, e)
					ClearBill();
					break;
				case 10: //选择套餐
					//检测桌台状态
					//0=空闲，1=使用，2=预定中，-1=不存在该桌台
					int ts;
                    ts = rms_var.GetTableStatus(dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString());
					switch (ts)
					{
						case 0: //桌台空闲
							MessageBox.Show("桌台空闲，您不可以为该桌台进行加套餐操作。请首先进行开台操作。");
							return;
						case 1: //桌台使用中
							//检测是否选中消费单据
							if (! (BillCount > 0))
							{
								MessageBox.Show("没有消费单据，您不可以为该桌台进行加套餐操作。请首先进行加单操作。");
								return;
							}
							else
							{
								if (rms_var.IsCancelBill(rms_var.GetBillNoTypeCode(CurrentBillNo), ""))
								{
									//取消单
									MessageBox.Show("不能向取消单中添加套餐");
									return;
								}
								else //开始添加套餐
								{
									if (txtFoodCode.Enabled)
									{
										frmSuitFood frmsf = new frmSuitFood();
										frmsf.ShowDialog();
										if (frmsf.DialogResult == DialogResult.OK)
										{
											if (MessageBox.Show("真的要添加套餐吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
											{
                                                AddSuitToBill(frmsf.dgSuitFood[frmsf.dgSuitFood.CurrentRowIndex, 0].ToString(), CurrentTableNo, CurrentBillNo, (double)frmsf.NumericUpDown1.Value);
											}
										}
									}
								}
							}
							break;
						case 2: //原桌台预定中
							MessageBox.Show("桌台预定中，您不可以为该桌台进行加套餐操作。请首先进行开台操作。");
							return;
					}
					break;
				case 12: //删除单据
					if (BillCount > 0)
					{
						if (rms_var.TheAppExt.Chk_op_df)
						{
							if (MessageBox.Show("真的要删除当前选中的单据及其所有菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
								frmCancelRsn frmcr = new frmCancelRsn();
								frmcr.ShowDialog();
								if (frmcr.DialogResult == DialogResult.OK)
								{
                                    if (rms_var.DeleteBill(CurrentTableNo, CurrentBillNo, frmcr.dgCancelReason[frmcr.dgCancelReason.CurrentRowIndex, 1].ToString()))
										{
										GetTableBills(CurrentTableNo);
										ShowBill(CurrentTableNo, "first");
										MessageBox.Show("删除单据操作顺利完成");
									}
								}
							}
						}
						else
						{
							MessageBox.Show("您没有删除单据的权限。");
							return;
						}
					}
					break;
				case 13: //删菜品
					if (BillCount > 0)
					{
						if (rms_var.TheAppExt.Chk_op_df)
						{
							if (rms_var.IsSuitFood(dgSaleFoods[dgSaleFoods.CurrentRowIndex, 8].ToString()))
							{
								if (MessageBox.Show("注意：当前菜品为套餐中菜品，该操作会删除包含该菜品的套餐，真的要删除当前选中的套餐吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
								{
									frmCancelRsn frmcr = new frmCancelRsn();
									frmcr.ShowDialog();
									if (frmcr.DialogResult == DialogResult.OK)
									{
                                        rms_var.DeleteSuit(CurrentTableNo, CurrentBillNo, frmcr.dgCancelReason[frmcr.dgCancelReason.CurrentRowIndex, 1].ToString(), dgSaleFoods[dgSaleFoods.CurrentRowIndex, 8].ToString(), false);
										GetRelateFoods(CurrentTableNo, CurrentBillNo);
										GetOpenedTableInfo(CurrentTableNo, CurrentBillNo);
										MessageBox.Show("删除套餐操作顺利完成");
									}
								}
							}
							else
							{
								if (MessageBox.Show("真的要删除当前选中的菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
								{
									frmCancelRsn frmcr = new frmCancelRsn();
									frmcr.ShowDialog();
									if (frmcr.DialogResult == DialogResult.OK)
									{
                                        if (rms_var.DeleteFood(CurrentTableNo, CurrentBillNo, dgSaleFoods[dgSaleFoods.CurrentRowIndex, 0].ToString(), dgSaleFoods[dgSaleFoods.CurrentRowIndex, 3].ToString(), frmcr.dgCancelReason[frmcr.dgCancelReason.CurrentRowIndex, 1].ToString(), dgSaleFoods[dgSaleFoods.CurrentRowIndex, 8].ToString(), false))
											{
											GetRelateFoods(CurrentTableNo, CurrentBillNo);
											GetOpenedTableInfo(CurrentTableNo, CurrentBillNo);
											MessageBox.Show("删除菜品操作顺利完成");
										}
									}
								}
							}
						}
						else
						{
							MessageBox.Show("您没有删除菜品的权限。");
							return;
						}
					}
					break;
				case 15: //消费单
					if (CurrentTableNo != "")
					{
						if (MessageBox.Show("确定要打印当前桌台所有消费单据吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							//获取当前桌台所有单据
							
							//遍历每一个单据，获取当前单据的所有菜品信息
							
							
							Cursor = Cursors.WaitCursor;
							
							string sqlstr;
							sqlstr = "SELECT * from view_salebillsfoods_t where tableno='" + CurrentTableNo + "' order by tableno,billno,foodname";
							
							ParameterFieldDefinitions crParameterFieldDefinitions;
							ParameterFieldDefinition crParameterFieldDefinition;
							ParameterValues crParameterValues;
							ParameterDiscreteValue crParameterDiscreteValue;
							ReportDocument cr_salebillsfoods = new ReportDocument();
							
							//检测报表文件是否存在
							if (File.Exists(rms_var.GetReportPath() + report_var.BalanceQry_rpt_filename))
							{
								cr_salebillsfoods = report_var.LoadReport(rms_var.GetReportPath() + report_var.SaleBillsFoods_rpt_filename, sqlstr, "view_salebillsfoods_t");
							}
							else
							{
								MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
								return;
							}
							
							crParameterFieldDefinitions = cr_salebillsfoods.DataDefinition.ParameterFields;
							
							crParameterFieldDefinition = crParameterFieldDefinitions["酒店名称"];
							crParameterValues = crParameterFieldDefinition.CurrentValues;
							crParameterDiscreteValue = new ParameterDiscreteValue();
							crParameterDiscreteValue.Value = rms_var.GetSysSetup("CompanyName");
							crParameterValues.Add(crParameterDiscreteValue);
							crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
							
							crParameterFieldDefinition = crParameterFieldDefinitions["酒店地址"];
							crParameterValues = crParameterFieldDefinition.CurrentValues;
							crParameterDiscreteValue = new ParameterDiscreteValue();
							crParameterDiscreteValue.Value = rms_var.GetSysSetup("address");
							crParameterValues.Add(crParameterDiscreteValue);
							crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
							
							crParameterFieldDefinition = crParameterFieldDefinitions["酒店电话"];
							crParameterValues = crParameterFieldDefinition.CurrentValues;
							crParameterDiscreteValue = new ParameterDiscreteValue();
							crParameterDiscreteValue.Value = rms_var.GetSysSetup("telphone");
							crParameterValues.Add(crParameterDiscreteValue);
							crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
							
							Cursor = Cursors.Default;
							
							cr_salebillsfoods.PrintToPrinter(1, true, 1, 1);
						}
					}
					break;
				case 16: //结账
					DoPay();
					break;
				case 18: //返位
					if (rms_var.TheAppExt.Chk_op_fw)
					{
						frmBacktable frmbt = new frmBacktable();
						frmbt.ShowDialog();
						if (frmbt.DialogResult == DialogResult.OK)
						{
							GetTableList(cbTableType.Text);
                            CurrentTableNo = dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString();
							GetTableBills(CurrentTableNo);
							ShowBill(CurrentTableNo, "first");
						}
						frmbt.Dispose();
					}
					else
					{
						MessageBox.Show("您没有返位权！");
						return;
					}
					break;
				case 20:
                    try
                    {
                        rms_var.frmTableST.RefreshTable();
                    }
                    catch { }
					this.Close();
					break;
			}
		}
		
		private void DoPay()
		{
			if (CurrentTableNo != "")
			{
				//检测是否有结帐权
				if (rms_var.TheAppExt.Chk_op_jz)
				{
					frmPayFor frmpf = new frmPayFor();
					//首先返回当前桌台的 serialno ,检测当前 serialno 下的桌台费用
					string CurrentTableSerialno;
					CurrentTableSerialno = rms_var.GetCurrentTableSerialNo(CurrentTableNo);
					
					System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
					conn.ConnectionString = rms_var.ConnStr;
					try
					{
						SqlCommand selectCMD = new SqlCommand("SELECT tableno FROM balancetable_t where serialno='" + CurrentTableSerialno + "' group by serialno,tableno", conn);
						selectCMD.CommandTimeout = 30;
						SqlDataAdapter dbDA = new SqlDataAdapter();
						dbDA.SelectCommand = selectCMD;
						conn.Open();
						DataSet dbDS = new DataSet();
						dbDA.Fill(dbDS, "TableList");

                        frmpf.TablePayFor = new frmPayFor.structTablePayFor[dbDS.Tables[0].Rows.Count - 1 + 1];
						
						//获取所有需要结算的桌台
						for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
						{
                            frmpf.TablePayFor[i].tableno = dbDS.Tables[0].Rows[i][0].ToString();
						}
						
						//计算所有桌台的相关费用
						for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
						{
							//计算菜品金额
							frmpf.TablePayFor[i].foodcost = double.Parse(rms_var.GetTablePrice(frmpf.TablePayFor[i].tableno));
							//菜品优惠金额(部门优惠)
							frmpf.TablePayFor[i].fooddiscountcost = double.Parse(rms_var.UpdateAndGetSaledFoodDiscountPrice(frmpf.TablePayFor[i].tableno));
							//赠送单累计金额
							frmpf.TablePayFor[i].presentcost = double.Parse(rms_var.GetPresentBillPrice(frmpf.TablePayFor[i].tableno));
							//服务费
							frmpf.TablePayFor[i].servercost = double.Parse(rms_var.GetTableServerPay(frmpf.TablePayFor[i].tableno, double.Parse(rms_var.GetTablePrice(frmpf.TablePayFor[i].tableno))));
							//附加费/包房费
							frmpf.TablePayFor[i].addcost = double.Parse(rms_var.GetTableRoomPay(frmpf.TablePayFor[i].tableno));
							//超时费
							frmpf.TablePayFor[i].overcost = double.Parse(rms_var.GetTableOverTimePay(frmpf.TablePayFor[i].tableno, double.Parse(rms_var.GetTablePrice(frmpf.TablePayFor[i].tableno))));
							//最低消费
							frmpf.TablePayFor[i].lowpay = double.Parse(rms_var.GetTableLowPay(frmpf.TablePayFor[i].tableno));
						}
						
						frmpf.CreatePayForTable();
						//frmpf.AddNewPayFor("1", "现金", CDbl(frmpf.lblTotal.Text))
						
						//检测是否允许自由打折
						frmFreeDiscount frmfd = new frmFreeDiscount();
						if (!rms_var.TheAppExt.Chk_op_dz) //不存在自由打折
						{
							frmfd.NumericUpDown1.Value = (decimal)(rms_var.GetEmplDiscount(rms_var.opinfo.EmpID));
							frmfd.NumericUpDown1.Enabled = false;
							frmfd.ComboBox1.Items.Add("不打折");
							frmfd.ComboBox1.Items.Add("99%");
							frmfd.ComboBox1.Items.Add("98%");
							frmfd.ComboBox1.Items.Add("97%");
							frmfd.ComboBox1.Items.Add("96%");
							frmfd.ComboBox1.Items.Add("95%");
							frmfd.ComboBox1.Items.Add("94%");
							frmfd.ComboBox1.Items.Add("93%");
							frmfd.ComboBox1.Items.Add("92%");
							frmfd.ComboBox1.Items.Add("91%");
							frmfd.ComboBox1.Items.Add("90%");
							frmfd.ComboBox1.Items.Add("89%");
							frmfd.ComboBox1.Items.Add("88%");
							frmfd.ComboBox1.Items.Add("87%");
							frmfd.ComboBox1.Items.Add("86%");
							frmfd.ComboBox1.Items.Add("85%");
							frmfd.ComboBox1.Items.Add("84%");
							frmfd.ComboBox1.Items.Add("83%");
							frmfd.ComboBox1.Items.Add("82%");
							frmfd.ComboBox1.Items.Add("81%");
							frmfd.ComboBox1.Items.Add("80%");
							frmfd.ComboBox1.Items.Add("79%");
							frmfd.ComboBox1.Items.Add("78%");
							frmfd.ComboBox1.Items.Add("77%");
							frmfd.ComboBox1.Items.Add("76%");
							frmfd.ComboBox1.Items.Add("75%");
							frmfd.ComboBox1.Items.Add("74%");
							frmfd.ComboBox1.Items.Add("73%");
							frmfd.ComboBox1.Items.Add("72%");
							frmfd.ComboBox1.Items.Add("71%");
							frmfd.ComboBox1.Items.Add("70%");
							frmfd.ComboBox1.Items.Add("69%");
							frmfd.ComboBox1.Items.Add("68%");
							frmfd.ComboBox1.Items.Add("67%");
							frmfd.ComboBox1.Items.Add("66%");
							frmfd.ComboBox1.Items.Add("65%");
							frmfd.ComboBox1.Items.Add("64%");
							frmfd.ComboBox1.Items.Add("63%");
							frmfd.ComboBox1.Items.Add("62%");
							frmfd.ComboBox1.Items.Add("61%");
							frmfd.ComboBox1.Items.Add("60%");
							frmfd.ComboBox1.Items.Add("59%");
							frmfd.ComboBox1.Items.Add("58%");
							frmfd.ComboBox1.Items.Add("57%");
							frmfd.ComboBox1.Items.Add("56%");
							frmfd.ComboBox1.Items.Add("54%");
							frmfd.ComboBox1.Items.Add("53%");
							frmfd.ComboBox1.Items.Add("52%");
							frmfd.ComboBox1.Items.Add("51%");
							frmfd.ComboBox1.Items.Add("50%");
							frmfd.ComboBox1.Items.Add("49%");
							frmfd.ComboBox1.Items.Add("48%");
							frmfd.ComboBox1.Items.Add("47%");
							frmfd.ComboBox1.Items.Add("46%");
							frmfd.ComboBox1.Items.Add("45%");
							frmfd.ComboBox1.Items.Add("44%");
							frmfd.ComboBox1.Items.Add("43%");
							frmfd.ComboBox1.Items.Add("42%");
							frmfd.ComboBox1.Items.Add("41%");
							frmfd.ComboBox1.Items.Add("40%");
							frmfd.ComboBox1.Items.Add("39%");
							frmfd.ComboBox1.Items.Add("38%");
							frmfd.ComboBox1.Items.Add("37%");
							frmfd.ComboBox1.Items.Add("36%");
							frmfd.ComboBox1.Items.Add("35%");
							frmfd.ComboBox1.Items.Add("34%");
							frmfd.ComboBox1.Items.Add("33%");
							frmfd.ComboBox1.Items.Add("32%");
							frmfd.ComboBox1.Items.Add("31%");
							frmfd.ComboBox1.Items.Add("30%");
							frmfd.ComboBox1.Items.Add("29%");
							frmfd.ComboBox1.Items.Add("28%");
							frmfd.ComboBox1.Items.Add("27%");
							frmfd.ComboBox1.Items.Add("26%");
							frmfd.ComboBox1.Items.Add("25%");
							frmfd.ComboBox1.Items.Add("24%");
							frmfd.ComboBox1.Items.Add("23%");
							frmfd.ComboBox1.Items.Add("22%");
							frmfd.ComboBox1.Items.Add("21%");
							frmfd.ComboBox1.Items.Add("20%");
							frmfd.ComboBox1.Items.Add("10%");
						}
						else //存在自由打折
						{
							frmfd.ComboBox1.Items.Add("不打折");
							frmfd.ComboBox1.Items.Add("99%");
							frmfd.ComboBox1.Items.Add("98%");
							frmfd.ComboBox1.Items.Add("97%");
							frmfd.ComboBox1.Items.Add("96%");
							frmfd.ComboBox1.Items.Add("95%");
							frmfd.ComboBox1.Items.Add("94%");
							frmfd.ComboBox1.Items.Add("93%");
							frmfd.ComboBox1.Items.Add("92%");
							frmfd.ComboBox1.Items.Add("91%");
							frmfd.ComboBox1.Items.Add("90%");
							frmfd.ComboBox1.Items.Add("89%");
							frmfd.ComboBox1.Items.Add("88%");
							frmfd.ComboBox1.Items.Add("87%");
							frmfd.ComboBox1.Items.Add("86%");
							frmfd.ComboBox1.Items.Add("85%");
							frmfd.ComboBox1.Items.Add("84%");
							frmfd.ComboBox1.Items.Add("83%");
							frmfd.ComboBox1.Items.Add("82%");
							frmfd.ComboBox1.Items.Add("81%");
							frmfd.ComboBox1.Items.Add("80%");
							frmfd.ComboBox1.Items.Add("79%");
							frmfd.ComboBox1.Items.Add("78%");
							frmfd.ComboBox1.Items.Add("77%");
							frmfd.ComboBox1.Items.Add("76%");
							frmfd.ComboBox1.Items.Add("75%");
							frmfd.ComboBox1.Items.Add("74%");
							frmfd.ComboBox1.Items.Add("73%");
							frmfd.ComboBox1.Items.Add("72%");
							frmfd.ComboBox1.Items.Add("71%");
							frmfd.ComboBox1.Items.Add("70%");
							frmfd.ComboBox1.Items.Add("69%");
							frmfd.ComboBox1.Items.Add("68%");
							frmfd.ComboBox1.Items.Add("67%");
							frmfd.ComboBox1.Items.Add("66%");
							frmfd.ComboBox1.Items.Add("65%");
							frmfd.ComboBox1.Items.Add("64%");
							frmfd.ComboBox1.Items.Add("63%");
							frmfd.ComboBox1.Items.Add("62%");
							frmfd.ComboBox1.Items.Add("61%");
							frmfd.ComboBox1.Items.Add("60%");
							frmfd.ComboBox1.Items.Add("59%");
							frmfd.ComboBox1.Items.Add("58%");
							frmfd.ComboBox1.Items.Add("57%");
							frmfd.ComboBox1.Items.Add("56%");
							frmfd.ComboBox1.Items.Add("54%");
							frmfd.ComboBox1.Items.Add("53%");
							frmfd.ComboBox1.Items.Add("52%");
							frmfd.ComboBox1.Items.Add("51%");
							frmfd.ComboBox1.Items.Add("50%");
							frmfd.ComboBox1.Items.Add("49%");
							frmfd.ComboBox1.Items.Add("48%");
							frmfd.ComboBox1.Items.Add("47%");
							frmfd.ComboBox1.Items.Add("46%");
							frmfd.ComboBox1.Items.Add("45%");
							frmfd.ComboBox1.Items.Add("44%");
							frmfd.ComboBox1.Items.Add("43%");
							frmfd.ComboBox1.Items.Add("42%");
							frmfd.ComboBox1.Items.Add("41%");
							frmfd.ComboBox1.Items.Add("40%");
							frmfd.ComboBox1.Items.Add("39%");
							frmfd.ComboBox1.Items.Add("38%");
							frmfd.ComboBox1.Items.Add("37%");
							frmfd.ComboBox1.Items.Add("36%");
							frmfd.ComboBox1.Items.Add("35%");
							frmfd.ComboBox1.Items.Add("34%");
							frmfd.ComboBox1.Items.Add("33%");
							frmfd.ComboBox1.Items.Add("32%");
							frmfd.ComboBox1.Items.Add("31%");
							frmfd.ComboBox1.Items.Add("30%");
							frmfd.ComboBox1.Items.Add("29%");
							frmfd.ComboBox1.Items.Add("28%");
							frmfd.ComboBox1.Items.Add("27%");
							frmfd.ComboBox1.Items.Add("26%");
							frmfd.ComboBox1.Items.Add("25%");
							frmfd.ComboBox1.Items.Add("24%");
							frmfd.ComboBox1.Items.Add("23%");
							frmfd.ComboBox1.Items.Add("22%");
							frmfd.ComboBox1.Items.Add("21%");
							frmfd.ComboBox1.Items.Add("20%");
							frmfd.ComboBox1.Items.Add("10%");
						}
						frmfd.ComboBox1.SelectedIndex = 0;
						frmfd.ShowDialog();
						double blcCost = 0; //支付金额
						int blcCostInt = 0; //优惠金额抹零后金额 170.2 ->170
						double blcCostTmp = 0; //优惠金额的领头金额 0.2
						if (frmfd.DialogResult == DialogResult.OK) //存在，并设置了自由打折
						{
							for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
							{
								if (frmfd.ComboBox1.Text == "不打折")
								{
									frmpf.TablePayFor[i].discountrate = 1;
								}
								else if (frmfd.ComboBox1.Text == "99%")
								{
									frmpf.TablePayFor[i].discountrate = 0.99;
									
								}
								else if (frmfd.ComboBox1.Text == "98%")
								{
									frmpf.TablePayFor[i].discountrate = 0.98;
									
								}
								else if (frmfd.ComboBox1.Text == "97%")
								{
									frmpf.TablePayFor[i].discountrate = 0.97;
									
								}
								else if (frmfd.ComboBox1.Text == "96%")
								{
									frmpf.TablePayFor[i].discountrate = 0.96;
									
								}
								else if (frmfd.ComboBox1.Text == "95%")
								{
									frmpf.TablePayFor[i].discountrate = 0.95;
									
								}
								else if (frmfd.ComboBox1.Text == "94%")
								{
									frmpf.TablePayFor[i].discountrate = 0.94;
									
								}
								else if (frmfd.ComboBox1.Text == "93%")
								{
									frmpf.TablePayFor[i].discountrate = 0.93;
									
								}
								else if (frmfd.ComboBox1.Text == "92%")
								{
									frmpf.TablePayFor[i].discountrate = 0.92;
									
								}
								else if (frmfd.ComboBox1.Text == "91%")
								{
									frmpf.TablePayFor[i].discountrate = 0.91;
									
								}
								else if (frmfd.ComboBox1.Text == "90%")
								{
									frmpf.TablePayFor[i].discountrate = 0.9;
									
								}
								else if (frmfd.ComboBox1.Text == "89%")
								{
									frmpf.TablePayFor[i].discountrate = 0.89;
									
								}
								else if (frmfd.ComboBox1.Text == "88%")
								{
									frmpf.TablePayFor[i].discountrate = 0.88;
									
								}
								else if (frmfd.ComboBox1.Text == "87%")
								{
									frmpf.TablePayFor[i].discountrate = 0.87;
									
								}
								else if (frmfd.ComboBox1.Text == "86%")
								{
									frmpf.TablePayFor[i].discountrate = 0.86;
									
								}
								else if (frmfd.ComboBox1.Text == "85%")
								{
									frmpf.TablePayFor[i].discountrate = 0.85;
									
								}
								else if (frmfd.ComboBox1.Text == "84%")
								{
									frmpf.TablePayFor[i].discountrate = 0.84;
									
								}
								else if (frmfd.ComboBox1.Text == "83%")
								{
									frmpf.TablePayFor[i].discountrate = 0.83;
									
								}
								else if (frmfd.ComboBox1.Text == "82%")
								{
									frmpf.TablePayFor[i].discountrate = 0.82;
									
								}
								else if (frmfd.ComboBox1.Text == "81%")
								{
									frmpf.TablePayFor[i].discountrate = 0.81;
									
								}
								else if (frmfd.ComboBox1.Text == "80%")
								{
									frmpf.TablePayFor[i].discountrate = 0.8;
									
								}
								else if (frmfd.ComboBox1.Text == "79%")
								{
									frmpf.TablePayFor[i].discountrate = 0.79;
									
								}
								else if (frmfd.ComboBox1.Text == "78%")
								{
									frmpf.TablePayFor[i].discountrate = 0.78;
									
								}
								else if (frmfd.ComboBox1.Text == "77%")
								{
									frmpf.TablePayFor[i].discountrate = 0.77;
									
								}
								else if (frmfd.ComboBox1.Text == "76%")
								{
									frmpf.TablePayFor[i].discountrate = 0.76;
									
								}
								else if (frmfd.ComboBox1.Text == "75%")
								{
									frmpf.TablePayFor[i].discountrate = 0.75;
									
								}
								else if (frmfd.ComboBox1.Text == "74%")
								{
									frmpf.TablePayFor[i].discountrate = 0.74;
									
								}
								else if (frmfd.ComboBox1.Text == "73%")
								{
									frmpf.TablePayFor[i].discountrate = 0.73;
									
								}
								else if (frmfd.ComboBox1.Text == "72%")
								{
									frmpf.TablePayFor[i].discountrate = 0.72;
									
								}
								else if (frmfd.ComboBox1.Text == "71%")
								{
									frmpf.TablePayFor[i].discountrate = 0.71;
									
								}
								else if (frmfd.ComboBox1.Text == "70%")
								{
									frmpf.TablePayFor[i].discountrate = 0.7;
									
								}
								else if (frmfd.ComboBox1.Text == "69%")
								{
									frmpf.TablePayFor[i].discountrate = 0.69;
									
								}
								else if (frmfd.ComboBox1.Text == "68%")
								{
									frmpf.TablePayFor[i].discountrate = 0.68;
									
								}
								else if (frmfd.ComboBox1.Text == "67%")
								{
									frmpf.TablePayFor[i].discountrate = 0.67;
									
								}
								else if (frmfd.ComboBox1.Text == "66%")
								{
									frmpf.TablePayFor[i].discountrate = 0.66;
									
								}
								else if (frmfd.ComboBox1.Text == "65%")
								{
									frmpf.TablePayFor[i].discountrate = 0.65;
									
								}
								else if (frmfd.ComboBox1.Text == "64%")
								{
									frmpf.TablePayFor[i].discountrate = 0.64;
									
								}
								else if (frmfd.ComboBox1.Text == "63%")
								{
									frmpf.TablePayFor[i].discountrate = 0.63;
									
								}
								else if (frmfd.ComboBox1.Text == "62%")
								{
									frmpf.TablePayFor[i].discountrate = 0.62;
									
								}
								else if (frmfd.ComboBox1.Text == "61%")
								{
									frmpf.TablePayFor[i].discountrate = 0.61;
									
								}
								else if (frmfd.ComboBox1.Text == "60%")
								{
									frmpf.TablePayFor[i].discountrate = 0.6;
									
								}
								else if (frmfd.ComboBox1.Text == "59%")
								{
									frmpf.TablePayFor[i].discountrate = 0.59;
									
								}
								else if (frmfd.ComboBox1.Text == "58%")
								{
									frmpf.TablePayFor[i].discountrate = 0.58;
									
								}
								else if (frmfd.ComboBox1.Text == "57%")
								{
									frmpf.TablePayFor[i].discountrate = 0.57;
									
								}
								else if (frmfd.ComboBox1.Text == "56%")
								{
									frmpf.TablePayFor[i].discountrate = 0.56;
									
								}
								else if (frmfd.ComboBox1.Text == "55%")
								{
									frmpf.TablePayFor[i].discountrate = 0.55;
									
								}
								else if (frmfd.ComboBox1.Text == "54%")
								{
									frmpf.TablePayFor[i].discountrate = 0.54;
									
								}
								else if (frmfd.ComboBox1.Text == "53%")
								{
									frmpf.TablePayFor[i].discountrate = 0.53;
									
								}
								else if (frmfd.ComboBox1.Text == "52%")
								{
									frmpf.TablePayFor[i].discountrate = 0.52;
									
								}
								else if (frmfd.ComboBox1.Text == "51%")
								{
									frmpf.TablePayFor[i].discountrate = 0.51;
									
								}
								else if (frmfd.ComboBox1.Text == "50%")
								{
									frmpf.TablePayFor[i].discountrate = 0.5;
									
								}
								else if (frmfd.ComboBox1.Text == "49%")
								{
									frmpf.TablePayFor[i].discountrate = 0.49;
									
								}
								else if (frmfd.ComboBox1.Text == "48%")
								{
									frmpf.TablePayFor[i].discountrate = 0.48;
									
								}
								else if (frmfd.ComboBox1.Text == "47%")
								{
									frmpf.TablePayFor[i].discountrate = 0.47;
									
								}
								else if (frmfd.ComboBox1.Text == "46%")
								{
									frmpf.TablePayFor[i].discountrate = 0.46;
									
								}
								else if (frmfd.ComboBox1.Text == "45%")
								{
									frmpf.TablePayFor[i].discountrate = 0.45;
									
								}
								else if (frmfd.ComboBox1.Text == "44%")
								{
									frmpf.TablePayFor[i].discountrate = 0.44;
									
								}
								else if (frmfd.ComboBox1.Text == "43%")
								{
									frmpf.TablePayFor[i].discountrate = 0.43;
									
								}
								else if (frmfd.ComboBox1.Text == "42%")
								{
									frmpf.TablePayFor[i].discountrate = 0.42;
									
								}
								else if (frmfd.ComboBox1.Text == "41%")
								{
									frmpf.TablePayFor[i].discountrate = 0.41;
									
								}
								else if (frmfd.ComboBox1.Text == "40%")
								{
									frmpf.TablePayFor[i].discountrate = 0.4;
									
								}
								else if (frmfd.ComboBox1.Text == "39%")
								{
									frmpf.TablePayFor[i].discountrate = 0.39;
									
								}
								else if (frmfd.ComboBox1.Text == "38%")
								{
									frmpf.TablePayFor[i].discountrate = 0.38;
									
								}
								else if (frmfd.ComboBox1.Text == "37%")
								{
									frmpf.TablePayFor[i].discountrate = 0.37;
									
								}
								else if (frmfd.ComboBox1.Text == "36%")
								{
									frmpf.TablePayFor[i].discountrate = 0.36;
									
								}
								else if (frmfd.ComboBox1.Text == "35%")
								{
									frmpf.TablePayFor[i].discountrate = 0.35;
									
								}
								else if (frmfd.ComboBox1.Text == "34%")
								{
									frmpf.TablePayFor[i].discountrate = 0.34;
									
								}
								else if (frmfd.ComboBox1.Text == "33%")
								{
									frmpf.TablePayFor[i].discountrate = 0.33;
									
								}
								else if (frmfd.ComboBox1.Text == "32%")
								{
									frmpf.TablePayFor[i].discountrate = 0.32;
									
								}
								else if (frmfd.ComboBox1.Text == "31%")
								{
									frmpf.TablePayFor[i].discountrate = 0.31;
									
								}
								else if (frmfd.ComboBox1.Text == "30%")
								{
									frmpf.TablePayFor[i].discountrate = 0.3;
									
								}
								else if (frmfd.ComboBox1.Text == "29%")
								{
									frmpf.TablePayFor[i].discountrate = 0.29;
									
								}
								else if (frmfd.ComboBox1.Text == "28%")
								{
									frmpf.TablePayFor[i].discountrate = 0.28;
									
								}
								else if (frmfd.ComboBox1.Text == "27%")
								{
									frmpf.TablePayFor[i].discountrate = 0.27;
									
								}
								else if (frmfd.ComboBox1.Text == "26%")
								{
									frmpf.TablePayFor[i].discountrate = 0.26;
									
								}
								else if (frmfd.ComboBox1.Text == "25%")
								{
									frmpf.TablePayFor[i].discountrate = 0.25;
									
								}
								else if (frmfd.ComboBox1.Text == "24%")
								{
									frmpf.TablePayFor[i].discountrate = 0.24;
									
								}
								else if (frmfd.ComboBox1.Text == "23%")
								{
									frmpf.TablePayFor[i].discountrate = 0.23;
									
								}
								else if (frmfd.ComboBox1.Text == "22%")
								{
									frmpf.TablePayFor[i].discountrate = 0.22;
									
								}
								else if (frmfd.ComboBox1.Text == "21%")
								{
									frmpf.TablePayFor[i].discountrate = 0.21;
									
								}
								else if (frmfd.ComboBox1.Text == "20%")
								{
									frmpf.TablePayFor[i].discountrate = 0.2;
									
								}
								else if (frmfd.ComboBox1.Text == "10%")
								{
									frmpf.TablePayFor[i].discountrate = 0.1;
								}
								//frmpf.TablePayFor(i).discountrate = frmfd.NumericUpDown1.Value / 100
								//根据自由打折率计算当前桌台所有菜品的优惠金额
								//Dim DscntOnDscnt As String = GetSysSetup("DiscountOnDiscount") '允许折上折
								string DscntOnDscnt = "";
								if (frmfd.RadioButton2.Checked)
								{
									DscntOnDscnt = "1";
								}
								//Dim blcCost As Double '支付金额
								//Dim blcCostInt As Integer '优惠金额抹零后金额 170.2 ->170
								//Dim blcCostTmp As Double '优惠金额的领头金额 0.2
								blcCost = frmpf.TablePayFor[i].foodcost - frmpf.TablePayFor[i].presentcost;
								if (DscntOnDscnt == "1")
								{
									frmpf.TablePayFor[i].fooddiscountcost = blcCost * (1 - frmpf.TablePayFor[i].discountrate);
								}
								else
								{
									frmpf.TablePayFor[i].fooddiscountcost = double.Parse(rms_var.GetFoodsDiscountCost(frmpf.TablePayFor[i].tableno, blcCost, frmpf.TablePayFor[i].discountrate));
								}
								blcCostInt = System.Convert.ToInt32(frmpf.TablePayFor[i].fooddiscountcost);
								blcCostTmp = System.Convert.ToDouble(frmpf.TablePayFor[i].fooddiscountcost - blcCostInt);
								frmpf.TablePayFor[i].fooddiscountcost = blcCostInt;
								//将差额加回应付金额
							}
						}
						else
						{
							return;
						}
						
						//根据打折率，更新桌台支付金额
						for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
						{
							frmpf.TablePayFor[i].needpayforcost = frmpf.TablePayFor[i].foodcost + frmpf.TablePayFor[i].addcost + frmpf.TablePayFor[i].overcost + frmpf.TablePayFor[i].servercost - frmpf.TablePayFor[i].fooddiscountcost - frmpf.TablePayFor[i].presentcost;
							frmpf.TablePayFor[i].endprice = frmpf.TablePayFor[i].needpayforcost;
						}
						//允许自动抹零 0：数值不变；1：自动抹零；2：四舍五入
						string fixcostrtn = rms_var.FixCost();
						if (fixcostrtn == "1") //自动抹零
						{
							double afterfixprice = 0;
							for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
							{
								if (frmpf.TablePayFor[i].endprice >= frmpf.TablePayFor[i].lowpay)
								{
									//加上优惠抹零的金额
									frmpf.TablePayFor[i].needpayforcost =Convert.ToDouble(frmpf.TablePayFor[i].needpayforcost + blcCostTmp);
                                    afterfixprice = Math.Floor(frmpf.TablePayFor[i].needpayforcost);
									frmpf.TablePayFor[i].oddcost =Convert.ToDouble(frmpf.TablePayFor[i].needpayforcost - afterfixprice);
									frmpf.TablePayFor[i].endprice = afterfixprice;
								}
							}
						}
						else if (fixcostrtn == "2") //四舍五入
						{
							//Dim afterfixprice As Double = 0
							string r="0";
							for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
							{
								if (frmpf.TablePayFor[i].endprice >= frmpf.TablePayFor[i].lowpay)
								{
									//加上优惠抹零的金额
									frmpf.TablePayFor[i].needpayforcost =Convert.ToDouble(frmpf.TablePayFor[i].needpayforcost + blcCostTmp);
									string s = string.Format("{###0:N2}",frmpf.TablePayFor[i].needpayforcost);
									int s_index = s.IndexOf(".");
                                   
									if (s_index != -1)
									{
										short n = short.Parse(s.ToString().Substring(s_index + 1, s.Length - s_index - 1));
										if (n < 50)
										{
											r = s.Substring(0, s_index);
										}
										else
										{
											s=(Convert.ToInt32(s)+1).ToString();
											r = s.ToString().Substring(0, s_index);
										}
									}
									frmpf.TablePayFor[i].endprice = double.Parse(r);
								}
							}
						}
						
						//更新该桌台最终支付金额
						for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
						{
							if (frmpf.TablePayFor[i].endprice < frmpf.TablePayFor[i].lowpay)
							{
								frmpf.TablePayFor[i].balancecost = frmpf.TablePayFor[i].lowpay;
							}
							else
							{
								frmpf.TablePayFor[i].balancecost = frmpf.TablePayFor[i].endprice;
							}
						}
						
						//合计桌台消费金额，刷新结账窗口
						double foodcost_sum = 0;
						double fooddiscountcost_sum = 0;
						double servercost_sum = 0;
						double presentcost_sum = 0;
						double addcost_sum = 0;
						double oddcost_sum = 0;
						double overcost_sum = 0;
						double balancecost_sum = 0;
						
						for (int i = 0; i <= frmpf.TablePayFor.Length - 1; i++)
						{
							foodcost_sum = foodcost_sum + frmpf.TablePayFor[i].foodcost;
							fooddiscountcost_sum = fooddiscountcost_sum + frmpf.TablePayFor[i].fooddiscountcost;
							servercost_sum = servercost_sum + frmpf.TablePayFor[i].servercost;
							presentcost_sum = presentcost_sum + frmpf.TablePayFor[i].presentcost;
							addcost_sum = addcost_sum + frmpf.TablePayFor[i].addcost;
							oddcost_sum = oddcost_sum + frmpf.TablePayFor[i].oddcost;
							overcost_sum = overcost_sum + frmpf.TablePayFor[i].overcost;
							balancecost_sum = balancecost_sum + frmpf.TablePayFor[i].balancecost;
						}

                        frmpf.lblFoodCost.Text = string.Format("{0:N2}", foodcost_sum);
                        frmpf.lblDiscountCost.Text = string.Format("{0:N2}", fooddiscountcost_sum);
                        frmpf.lblServerCost.Text = string.Format("{0:N2}", servercost_sum);
                        frmpf.lblPresentCost.Text = string.Format("{0:N2}", presentcost_sum);
                        frmpf.lblAddCost.Text = string.Format("{0:N2}", addcost_sum);
                        frmpf.lblOddCost.Text = string.Format("{0:N2}", oddcost_sum);
                        frmpf.lblOverTimeCost.Text = string.Format("{0:N2}", overcost_sum);
                        frmpf.lblNeedCost.Text = string.Format("{0:N2}", balancecost_sum);
						
                        //在客显上显示应收金额
                        DevExt.PoleDisplayer.Display(frmpf.lblNeedCost.Text, DevExt.PoleDisplayType.Payment);
                        //显示结账窗口
						frmpf.ShowDialog();
						if (frmpf.DialogResult == DialogResult.OK)
						{
							GetTableList(cbTableType.Text);
                            CurrentTableNo = dgTableStatus[dgTableStatus.CurrentRowIndex, 0].ToString();
							GetTableBills(CurrentTableNo);
							ShowBill(CurrentTableNo, "first");
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
				else
				{
					MessageBox.Show("您没有结帐权！");
					return;
				}
			}
		}
		
		private void cbFoodType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			GetFoodList(cbFoodType.Text, rms_var.FoodInputMode, 1, "");
		}
		
		private void cbDeptList_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			DataTable foodtype;
			foodtype = LoadFoodType(cbDeptList.Text);
			cbFoodType.Items.Clear();
			for (int i = 0; i <= foodtype.Rows.Count - 1; i++)
			{
				cbFoodType.Items.Add(foodtype.Rows[i]["TypeName"]);
			}
			//cbFoodType.Items.Add("全部")
			cbFoodType.SelectedIndex = 0; //cbFoodType.Items.Count - 1
		}
		
		private void numOpenPsn_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (dgSaleFoods.VisibleRowCount > 0)
			{
				rms_var.UpdateTablePsnCount(CurrentTableNo, System.Convert.ToInt32(numOpenPsn.Value));
			}
		}
		
		private void InputBill_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == System.Windows.Forms.Keys.F8)
			{
				DoPay();
			}
		}
		
		private void dgFoodList_Navigate(System.Object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}
		
		private void dgTableStatus_Navigate(System.Object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}
	}
	
}
