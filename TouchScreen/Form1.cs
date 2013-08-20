using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;
//using System.Array;
using System.IO;


namespace TouchScreen
{
	namespace MySpace
	{
		public class Form1 : System.Windows.Forms.Form
		{
			[STAThread]
			static void Main()
			{
				System.Windows.Forms.Application.Run(new Form1());
			}
			
			private TextBox CurrentUsedTextBox;
			
			private int CapsStatus = 1; //0 = 小写 1= 大写
			private bool dragging;
			private int mousex;
			private int mousey;
			
			private frmInputPanel frminptForm;
			
			private ListViewItem[] lvitems;
			
			public string CurrentTableTypeName = "全部";
			public string CurrentTableNo;
			public string CurrentDeptName;
			public string CurrentSelectedFoodCode;
			public string CurrentSelectedFoodName;
			public string CurrentSelectedFoodUnit;
			
			private string[] BillList;
			private int BillCount = 0;
			private int CurrentBillNum = 0;
			
			private string CurrentBillNo;
			private string CurrentBillTypename;
			private bool CurrentBillIsCancel = false;
			
			private TableTypesButtonList TableTypesBtnList1;
			private TableTypesButtonList TableTypesBtnList2;
			private int TableTypeNamePageInterval1 = 30;
			private int TableTypeNamePageInterval2 = 30;
			
			private TablesButtonList TablesBtnList1;
			private TablesButtonList TablesBtnList2;
			private int TablePageInterval1 = 150;
			private int TablePageInterval2 = 150;
			
			private DeptButtonList DeptsBtnList;
			private int DeptsPageInterval = 50;
			
			private FoodTypesButtonList FoodTypesBtnList;
			private int FoodTypesPageInterval = 60;
			
			private FoodsButtonList FoodsBtnList;
			private int FoodsPageInterval = 200;
			
			#region  Windows 窗体设计器生成的代码
			
			public Form1()
			{
				
				//该调用是 Windows 窗体设计器所必需的。
				InitializeComponent();
				
				//在 InitializeComponent() 调用之后添加任何初始化
				
				rms_var.InitialApp();
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
			internal System.Windows.Forms.TabControl TabControl1;
			internal System.Windows.Forms.TabPage TabPage1;
			internal System.Windows.Forms.TabPage TabPage2;
			internal System.Windows.Forms.Panel Panel1;
			internal System.Windows.Forms.Panel Panel2;
			internal System.Windows.Forms.Label Label2;
			internal System.Windows.Forms.Panel Panel3;
			internal System.Windows.Forms.Label lblBillno;
			internal System.Windows.Forms.Label lblOpenpsn;
			internal System.Windows.Forms.Label lblTableno;
			internal System.Windows.Forms.Label lblOpenDate;
			internal System.Windows.Forms.Button btnNext;
			internal System.Windows.Forms.Button btnPrior;
			internal System.Windows.Forms.Label lblBillTypeName;
			internal System.Windows.Forms.DataGrid dgSaleFoods;
			internal System.Windows.Forms.LinkLabel LinkLabel1;
			internal System.Windows.Forms.ToolBar ToolBar1;
			internal System.Windows.Forms.TextBox txtFoodCode;
			internal System.Windows.Forms.ToolBarButton ToolBarButton1;
			internal System.Windows.Forms.ToolBarButton ToolBarButton2;
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
			internal System.Windows.Forms.ToolBarButton ToolBarButton11;
			internal System.Windows.Forms.ToolBarButton ToolBarButton21;
			internal System.Windows.Forms.ToolBarButton ToolBarButton5;
			internal System.Windows.Forms.ToolBarButton ToolBarButton22;
			internal System.Windows.Forms.Panel pnlInput;
			internal System.Windows.Forms.Button bHide;
			internal System.Windows.Forms.Button bDot;
			internal System.Windows.Forms.Button bCaps;
			internal System.Windows.Forms.Button bSpc;
			internal System.Windows.Forms.Button bM;
			internal System.Windows.Forms.Button bN;
			internal System.Windows.Forms.Button bB;
			internal System.Windows.Forms.Button bV;
			internal System.Windows.Forms.Button bC;
			internal System.Windows.Forms.Button bX;
			internal System.Windows.Forms.Button bZ;
			internal System.Windows.Forms.Button bL;
			internal System.Windows.Forms.Button bK;
			internal System.Windows.Forms.Button bJ;
			internal System.Windows.Forms.Button bH;
			internal System.Windows.Forms.Button bG;
			internal System.Windows.Forms.Button bF;
			internal System.Windows.Forms.Button bD;
			internal System.Windows.Forms.Button bS;
			internal System.Windows.Forms.Button bA;
			internal System.Windows.Forms.Button bBack;
			internal System.Windows.Forms.Button bP;
			internal System.Windows.Forms.Button bO;
			internal System.Windows.Forms.Button bI;
			internal System.Windows.Forms.Button bU;
			internal System.Windows.Forms.Button bY;
			internal System.Windows.Forms.Button bT;
			internal System.Windows.Forms.Button bR;
			internal System.Windows.Forms.Button bE;
			internal System.Windows.Forms.Button bW;
			internal System.Windows.Forms.Button bQ;
			internal System.Windows.Forms.Button b0;
			internal System.Windows.Forms.Button b9;
			internal System.Windows.Forms.Button b8;
			internal System.Windows.Forms.Button b7;
			internal System.Windows.Forms.Button b6;
			internal System.Windows.Forms.Button b5;
			internal System.Windows.Forms.Button b4;
			internal System.Windows.Forms.Button b3;
			internal System.Windows.Forms.Button b2;
			internal System.Windows.Forms.Button b1;
			internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle4;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn14;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn15;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn16;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn17;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn18;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn19;
			internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn2;
			internal System.Windows.Forms.ImageList ImageList2;
			internal System.Windows.Forms.ImageList ImageList1;
			internal System.Windows.Forms.Label Label1;
			internal System.Windows.Forms.Panel Panel4;
			internal System.Windows.Forms.Button Button1;
			internal System.Windows.Forms.Button Button2;
			internal System.Windows.Forms.Panel Panel5;
			internal System.Windows.Forms.Panel Panel6;
			internal System.Windows.Forms.Button Button3;
			internal System.Windows.Forms.Button Button4;
			internal System.Windows.Forms.Button Button5;
			internal System.Windows.Forms.Button Button6;
			internal System.Windows.Forms.Panel Panel7;
			internal System.Windows.Forms.Button Button7;
			internal System.Windows.Forms.Button Button8;
			internal System.Windows.Forms.Panel Panel8;
			internal System.Windows.Forms.Button Button9;
			internal System.Windows.Forms.Button Button10;
			internal System.Windows.Forms.ToolBarButton ToolBarButton13;
			internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
			internal System.Windows.Forms.Panel Panel9;
			internal System.Windows.Forms.Button Button11;
			internal System.Windows.Forms.Button Button12;
			internal System.Windows.Forms.Panel Panel10;
			internal System.Windows.Forms.Button Button13;
			internal System.Windows.Forms.Button Button14;
			internal System.Windows.Forms.TextBox numOpenPsn;
			internal System.Windows.Forms.Button Button15;
			internal System.Windows.Forms.ToolBarButton ToolBarButton3;
			internal System.Timers.Timer Timer1;
			[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
				this.components = new System.ComponentModel.Container();
				base.Load += new System.EventHandler(Form1_Load);
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
				this.TabControl1 = new System.Windows.Forms.TabControl();
				this.TabPage1 = new System.Windows.Forms.TabPage();
				this.Button13 = new System.Windows.Forms.Button();
				this.Button13.Click += new System.EventHandler(this.Button13_Click);
				this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
				this.Button14 = new System.Windows.Forms.Button();
				this.Button14.Click += new System.EventHandler(this.Button14_Click);
				this.Panel10 = new System.Windows.Forms.Panel();
				this.Button2 = new System.Windows.Forms.Button();
				this.Button2.Click += new System.EventHandler(this.Button2_Click);
				this.Button1 = new System.Windows.Forms.Button();
				this.Button1.Click += new System.EventHandler(this.Button1_Click);
				this.Panel4 = new System.Windows.Forms.Panel();
				this.TabPage2 = new System.Windows.Forms.TabPage();
				this.Button12 = new System.Windows.Forms.Button();
				this.Button12.Click += new System.EventHandler(this.Button12_Click);
				this.Button11 = new System.Windows.Forms.Button();
				this.Button11.Click += new System.EventHandler(this.Button11_Click);
				this.Panel9 = new System.Windows.Forms.Panel();
				this.Button10 = new System.Windows.Forms.Button();
				this.Button10.Click += new System.EventHandler(this.Button10_Click);
				this.Button9 = new System.Windows.Forms.Button();
				this.Button9.Click += new System.EventHandler(this.Button9_Click);
				this.Panel8 = new System.Windows.Forms.Panel();
				this.Button8 = new System.Windows.Forms.Button();
				this.Button8.Click += new System.EventHandler(this.Button8_Click);
				this.Button7 = new System.Windows.Forms.Button();
				this.Button7.Click += new System.EventHandler(this.Button7_Click);
				this.Panel7 = new System.Windows.Forms.Panel();
				this.Button6 = new System.Windows.Forms.Button();
				this.Button6.Click += new System.EventHandler(this.Button6_Click);
				this.Button5 = new System.Windows.Forms.Button();
				this.Button5.Click += new System.EventHandler(this.Button5_Click);
				this.Button4 = new System.Windows.Forms.Button();
				this.Button4.Click += new System.EventHandler(this.Button4_Click);
				this.Button3 = new System.Windows.Forms.Button();
				this.Button3.Click += new System.EventHandler(this.Button3_Click);
				this.Panel6 = new System.Windows.Forms.Panel();
				this.Panel5 = new System.Windows.Forms.Panel();
				this.Panel1 = new System.Windows.Forms.Panel();
				this.Panel2 = new System.Windows.Forms.Panel();
				this.Button15 = new System.Windows.Forms.Button();
				this.Button15.Click += new System.EventHandler(this.Button15_Click);
				this.numOpenPsn = new System.Windows.Forms.TextBox();
				this.numOpenPsn.TextChanged += new System.EventHandler(this.numOpenPsn_TextChanged);
				this.numOpenPsn.Enter += new System.EventHandler(this.numOpenPsn_Enter);
				this.numOpenPsn.Click += new System.EventHandler(this.numOpenPsn_Click);
				this.numOpenPsn.Leave += new System.EventHandler(this.numOpenPsn_Leave);
				this.Label2 = new System.Windows.Forms.Label();
				this.Panel3 = new System.Windows.Forms.Panel();
				this.Label1 = new System.Windows.Forms.Label();
				this.lblBillno = new System.Windows.Forms.Label();
				this.lblOpenpsn = new System.Windows.Forms.Label();
				this.lblTableno = new System.Windows.Forms.Label();
				this.lblOpenDate = new System.Windows.Forms.Label();
				this.btnNext = new System.Windows.Forms.Button();
				this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
				this.btnPrior = new System.Windows.Forms.Button();
				this.btnPrior.Click += new System.EventHandler(this.btnPrior_Click);
				this.lblBillTypeName = new System.Windows.Forms.Label();
				this.dgSaleFoods = new System.Windows.Forms.DataGrid();
				this.DataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
				this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
				this.DataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
				this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
				this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				this.ToolBar1 = new System.Windows.Forms.ToolBar();
				this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
				this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton20 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton18 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton21 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
				this.ToolBarButton22 = new System.Windows.Forms.ToolBarButton();
				this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
				this.txtFoodCode = new System.Windows.Forms.TextBox();
				this.txtFoodCode.TextChanged += new System.EventHandler(this.txtFoodCode_TextChanged);
				this.txtFoodCode.Leave += new System.EventHandler(this.txtFoodCode_Leave);
				this.txtFoodCode.Enter += new System.EventHandler(this.txtFoodCode_Enter);
				this.txtFoodCode.Click += new System.EventHandler(this.txtFoodCode_Click);
				this.pnlInput = new System.Windows.Forms.Panel();
				this.bHide = new System.Windows.Forms.Button();
				this.bHide.Click += new System.EventHandler(this.bHide_Click);
				this.bDot = new System.Windows.Forms.Button();
				this.bDot.Click += new System.EventHandler(this.bDot_Click);
				this.bCaps = new System.Windows.Forms.Button();
				this.bCaps.Click += new System.EventHandler(this.bCaps_Click);
				this.bSpc = new System.Windows.Forms.Button();
				this.bSpc.Click += new System.EventHandler(this.bSpc_Click);
				this.bM = new System.Windows.Forms.Button();
				this.bM.Click += new System.EventHandler(this.bM_Click);
				this.bN = new System.Windows.Forms.Button();
				this.bN.Click += new System.EventHandler(this.bN_Click);
				this.bB = new System.Windows.Forms.Button();
				this.bB.Click += new System.EventHandler(this.bB_Click);
				this.bV = new System.Windows.Forms.Button();
				this.bV.Click += new System.EventHandler(this.bV_Click);
				this.bC = new System.Windows.Forms.Button();
				this.bC.Click += new System.EventHandler(this.bC_Click);
				this.bX = new System.Windows.Forms.Button();
				this.bX.Click += new System.EventHandler(this.bX_Click);
				this.bZ = new System.Windows.Forms.Button();
				this.bZ.Click += new System.EventHandler(this.bZ_Click);
				this.bL = new System.Windows.Forms.Button();
				this.bL.Click += new System.EventHandler(this.bL_Click);
				this.bK = new System.Windows.Forms.Button();
				this.bK.Click += new System.EventHandler(this.bK_Click);
				this.bJ = new System.Windows.Forms.Button();
				this.bJ.Click += new System.EventHandler(this.bJ_Click);
				this.bH = new System.Windows.Forms.Button();
				this.bH.Click += new System.EventHandler(this.bH_Click);
				this.bG = new System.Windows.Forms.Button();
				this.bG.Click += new System.EventHandler(this.bG_Click);
				this.bF = new System.Windows.Forms.Button();
				this.bF.Click += new System.EventHandler(this.bF_Click);
				this.bD = new System.Windows.Forms.Button();
				this.bD.Click += new System.EventHandler(this.bD_Click);
				this.bS = new System.Windows.Forms.Button();
				this.bS.Click += new System.EventHandler(this.bS_Click);
				this.bA = new System.Windows.Forms.Button();
				this.bA.Click += new System.EventHandler(this.bA_Click);
				this.bBack = new System.Windows.Forms.Button();
				this.bBack.Click += new System.EventHandler(this.bBack_Click);
				this.bP = new System.Windows.Forms.Button();
				this.bP.Click += new System.EventHandler(this.bP_Click);
				this.bO = new System.Windows.Forms.Button();
				this.bO.Click += new System.EventHandler(this.bO_Click);
				this.bI = new System.Windows.Forms.Button();
				this.bI.Click += new System.EventHandler(this.bI_Click);
				this.bU = new System.Windows.Forms.Button();
				this.bU.Click += new System.EventHandler(this.bU_Click);
				this.bY = new System.Windows.Forms.Button();
				this.bY.Click += new System.EventHandler(this.bY_Click);
				this.bT = new System.Windows.Forms.Button();
				this.bT.Click += new System.EventHandler(this.bT_Click);
				this.bR = new System.Windows.Forms.Button();
				this.bR.Click += new System.EventHandler(this.bR_Click);
				this.bE = new System.Windows.Forms.Button();
				this.bE.Click += new System.EventHandler(this.bE_Click);
				this.bW = new System.Windows.Forms.Button();
				this.bW.Click += new System.EventHandler(this.bW_Click);
				this.bQ = new System.Windows.Forms.Button();
				this.bQ.Click += new System.EventHandler(this.bQ_Click);
				this.b0 = new System.Windows.Forms.Button();
				this.b0.Click += new System.EventHandler(this.b0_Click);
				this.b9 = new System.Windows.Forms.Button();
				this.b9.Click += new System.EventHandler(this.b9_Click);
				this.b8 = new System.Windows.Forms.Button();
				this.b8.Click += new System.EventHandler(this.b8_Click);
				this.b7 = new System.Windows.Forms.Button();
				this.b7.Click += new System.EventHandler(this.b7_Click);
				this.b6 = new System.Windows.Forms.Button();
				this.b6.Click += new System.EventHandler(this.b6_Click);
				this.b5 = new System.Windows.Forms.Button();
				this.b5.Click += new System.EventHandler(this.b5_Click);
				this.b4 = new System.Windows.Forms.Button();
				this.b4.Click += new System.EventHandler(this.b4_Click);
				this.b3 = new System.Windows.Forms.Button();
				this.b3.Click += new System.EventHandler(this.b3_Click);
				this.b2 = new System.Windows.Forms.Button();
				this.b2.Click += new System.EventHandler(this.b2_Click);
				this.b1 = new System.Windows.Forms.Button();
				this.b1.Click += new System.EventHandler(this.b1_Click);
				this.Timer1 = new System.Timers.Timer();
				this.Timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
				this.TabControl1.SuspendLayout();
				this.TabPage1.SuspendLayout();
				this.TabPage2.SuspendLayout();
				this.Panel1.SuspendLayout();
				this.Panel2.SuspendLayout();
				((System.ComponentModel.ISupportInitialize) this.dgSaleFoods).BeginInit();
				this.pnlInput.SuspendLayout();
				((System.ComponentModel.ISupportInitialize) this.Timer1).BeginInit();
				this.SuspendLayout();
				//
				//TabControl1
				//
				this.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
				this.TabControl1.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.TabControl1.Controls.Add(this.TabPage1);
				this.TabControl1.Controls.Add(this.TabPage2);
				this.TabControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.TabControl1.ItemSize = new System.Drawing.Size(0, 40);
				this.TabControl1.Location = new System.Drawing.Point(8, 7);
				this.TabControl1.Name = "TabControl1";
				this.TabControl1.SelectedIndex = 0;
				this.TabControl1.Size = new System.Drawing.Size(904, 585);
				this.TabControl1.TabIndex = 2;
				//
				//TabPage1
				//
				this.TabPage1.Controls.Add(this.Button13);
				this.TabPage1.Controls.Add(this.Button14);
				this.TabPage1.Controls.Add(this.Panel10);
				this.TabPage1.Controls.Add(this.Button2);
				this.TabPage1.Controls.Add(this.Button1);
				this.TabPage1.Controls.Add(this.Panel4);
				this.TabPage1.Location = new System.Drawing.Point(4, 4);
				this.TabPage1.Name = "TabPage1";
				this.TabPage1.Size = new System.Drawing.Size(896, 537);
				this.TabPage1.TabIndex = 0;
				this.TabPage1.Text = " 桌台状态 ";
				//
				//Button13
				//
				this.Button13.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
				this.Button13.BackColor = System.Drawing.Color.Lavender;
				this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button13.ImageIndex = 5;
				this.Button13.ImageList = this.ImageList1;
				this.Button13.Location = new System.Drawing.Point(772, 480);
				this.Button13.Name = "Button13";
				this.Button13.Size = new System.Drawing.Size(116, 40);
				this.Button13.TabIndex = 9;
				//
				//ImageList1
				//
				this.ImageList1.ImageSize = new System.Drawing.Size(32, 32);
				this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
				this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
				//
				//Button14
				//
				this.Button14.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
				this.Button14.BackColor = System.Drawing.Color.Lavender;
				this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button14.ImageIndex = 4;
				this.Button14.ImageList = this.ImageList1;
				this.Button14.Location = new System.Drawing.Point(656, 480);
				this.Button14.Name = "Button14";
				this.Button14.Size = new System.Drawing.Size(116, 40);
				this.Button14.TabIndex = 8;
				//
				//Panel10
				//
				this.Panel10.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel10.Location = new System.Drawing.Point(248, 8);
				this.Panel10.Name = "Panel10";
				this.Panel10.Size = new System.Drawing.Size(640, 472);
				this.Panel10.TabIndex = 7;
				//
				//Button2
				//
				this.Button2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
				this.Button2.BackColor = System.Drawing.Color.Lavender;
				this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button2.ImageIndex = 5;
				this.Button2.ImageList = this.ImageList1;
				this.Button2.Location = new System.Drawing.Point(124, 481);
				this.Button2.Name = "Button2";
				this.Button2.Size = new System.Drawing.Size(116, 40);
				this.Button2.TabIndex = 6;
				//
				//Button1
				//
				this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
				this.Button1.BackColor = System.Drawing.Color.Lavender;
				this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button1.ImageIndex = 4;
				this.Button1.ImageList = this.ImageList1;
				this.Button1.Location = new System.Drawing.Point(8, 481);
				this.Button1.Name = "Button1";
				this.Button1.Size = new System.Drawing.Size(116, 40);
				this.Button1.TabIndex = 5;
				//
				//Panel4
				//
				this.Panel4.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
				this.Panel4.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel4.Location = new System.Drawing.Point(8, 8);
				this.Panel4.Name = "Panel4";
				this.Panel4.Size = new System.Drawing.Size(232, 473);
				this.Panel4.TabIndex = 4;
				//
				//TabPage2
				//
				this.TabPage2.Controls.Add(this.Button12);
				this.TabPage2.Controls.Add(this.Button11);
				this.TabPage2.Controls.Add(this.Panel9);
				this.TabPage2.Controls.Add(this.Button10);
				this.TabPage2.Controls.Add(this.Button9);
				this.TabPage2.Controls.Add(this.Panel8);
				this.TabPage2.Controls.Add(this.Button8);
				this.TabPage2.Controls.Add(this.Button7);
				this.TabPage2.Controls.Add(this.Panel7);
				this.TabPage2.Controls.Add(this.Button6);
				this.TabPage2.Controls.Add(this.Button5);
				this.TabPage2.Controls.Add(this.Button4);
				this.TabPage2.Controls.Add(this.Button3);
				this.TabPage2.Controls.Add(this.Panel6);
				this.TabPage2.Controls.Add(this.Panel5);
				this.TabPage2.Controls.Add(this.Panel1);
				this.TabPage2.Controls.Add(this.LinkLabel1);
				this.TabPage2.Controls.Add(this.ToolBar1);
				this.TabPage2.Controls.Add(this.txtFoodCode);
				this.TabPage2.Location = new System.Drawing.Point(4, 4);
				this.TabPage2.Name = "TabPage2";
				this.TabPage2.Size = new System.Drawing.Size(896, 537);
				this.TabPage2.TabIndex = 1;
				this.TabPage2.Text = " 单据输入 ";
				this.TabPage2.Visible = false;
				//
				//Button12
				//
				this.Button12.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Button12.BackColor = System.Drawing.Color.Lavender;
				this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button12.ImageIndex = 5;
				this.Button12.ImageList = this.ImageList1;
				this.Button12.Location = new System.Drawing.Point(768, 200);
				this.Button12.Name = "Button12";
				this.Button12.Size = new System.Drawing.Size(120, 40);
				this.Button12.TabIndex = 47;
				//
				//Button11
				//
				this.Button11.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Button11.BackColor = System.Drawing.Color.Lavender;
				this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button11.ImageIndex = 4;
				this.Button11.ImageList = this.ImageList1;
				this.Button11.Location = new System.Drawing.Point(648, 200);
				this.Button11.Name = "Button11";
				this.Button11.Size = new System.Drawing.Size(120, 40);
				this.Button11.TabIndex = 46;
				//
				//Panel9
				//
				this.Panel9.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Panel9.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel9.Location = new System.Drawing.Point(648, 96);
				this.Panel9.Name = "Panel9";
				this.Panel9.Size = new System.Drawing.Size(240, 104);
				this.Panel9.TabIndex = 45;
				//
				//Button10
				//
				this.Button10.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
				this.Button10.BackColor = System.Drawing.Color.Lavender;
				this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button10.ImageIndex = 5;
				this.Button10.ImageList = this.ImageList1;
				this.Button10.Location = new System.Drawing.Point(768, 489);
				this.Button10.Name = "Button10";
				this.Button10.Size = new System.Drawing.Size(120, 40);
				this.Button10.TabIndex = 44;
				//
				//Button9
				//
				this.Button9.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
				this.Button9.BackColor = System.Drawing.Color.Lavender;
				this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button9.ImageIndex = 4;
				this.Button9.ImageList = this.ImageList1;
				this.Button9.Location = new System.Drawing.Point(648, 489);
				this.Button9.Name = "Button9";
				this.Button9.Size = new System.Drawing.Size(120, 40);
				this.Button9.TabIndex = 43;
				//
				//Panel8
				//
				this.Panel8.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right);
				this.Panel8.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel8.Location = new System.Drawing.Point(648, 416);
				this.Panel8.Name = "Panel8";
				this.Panel8.Size = new System.Drawing.Size(240, 73);
				this.Panel8.TabIndex = 42;
				//
				//Button8
				//
				this.Button8.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Button8.BackColor = System.Drawing.Color.Lavender;
				this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button8.ImageIndex = 5;
				this.Button8.ImageList = this.ImageList1;
				this.Button8.Location = new System.Drawing.Point(768, 376);
				this.Button8.Name = "Button8";
				this.Button8.Size = new System.Drawing.Size(120, 40);
				this.Button8.TabIndex = 40;
				//
				//Button7
				//
				this.Button7.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Button7.BackColor = System.Drawing.Color.Lavender;
				this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button7.ImageIndex = 4;
				this.Button7.ImageList = this.ImageList1;
				this.Button7.Location = new System.Drawing.Point(648, 376);
				this.Button7.Name = "Button7";
				this.Button7.Size = new System.Drawing.Size(120, 40);
				this.Button7.TabIndex = 39;
				//
				//Panel7
				//
				this.Panel7.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Panel7.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel7.Location = new System.Drawing.Point(648, 240);
				this.Panel7.Name = "Panel7";
				this.Panel7.Size = new System.Drawing.Size(240, 136);
				this.Panel7.TabIndex = 38;
				//
				//Button6
				//
				this.Button6.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
				this.Button6.BackColor = System.Drawing.Color.Lavender;
				this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button6.ImageIndex = 5;
				this.Button6.ImageList = this.ImageList1;
				this.Button6.Location = new System.Drawing.Point(116, 489);
				this.Button6.Name = "Button6";
				this.Button6.Size = new System.Drawing.Size(108, 40);
				this.Button6.TabIndex = 36;
				//
				//Button5
				//
				this.Button5.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
				this.Button5.BackColor = System.Drawing.Color.Lavender;
				this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button5.ImageIndex = 4;
				this.Button5.ImageList = this.ImageList1;
				this.Button5.Location = new System.Drawing.Point(8, 489);
				this.Button5.Name = "Button5";
				this.Button5.Size = new System.Drawing.Size(108, 40);
				this.Button5.TabIndex = 35;
				//
				//Button4
				//
				this.Button4.BackColor = System.Drawing.Color.Lavender;
				this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button4.ImageIndex = 5;
				this.Button4.ImageList = this.ImageList1;
				this.Button4.Location = new System.Drawing.Point(116, 232);
				this.Button4.Name = "Button4";
				this.Button4.Size = new System.Drawing.Size(108, 40);
				this.Button4.TabIndex = 34;
				//
				//Button3
				//
				this.Button3.BackColor = System.Drawing.Color.Lavender;
				this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button3.ImageIndex = 4;
				this.Button3.ImageList = this.ImageList1;
				this.Button3.Location = new System.Drawing.Point(8, 232);
				this.Button3.Name = "Button3";
				this.Button3.Size = new System.Drawing.Size(108, 40);
				this.Button3.TabIndex = 33;
				//
				//Panel6
				//
				this.Panel6.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
				this.Panel6.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel6.Location = new System.Drawing.Point(8, 280);
				this.Panel6.Name = "Panel6";
				this.Panel6.Size = new System.Drawing.Size(216, 209);
				this.Panel6.TabIndex = 32;
				//
				//Panel5
				//
				this.Panel5.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel5.Location = new System.Drawing.Point(8, 72);
				this.Panel5.Name = "Panel5";
				this.Panel5.Size = new System.Drawing.Size(216, 160);
				this.Panel5.TabIndex = 31;
				//
				//Panel1
				//
				this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.Panel1.Controls.Add(this.Panel2);
				this.Panel1.Controls.Add(this.btnNext);
				this.Panel1.Controls.Add(this.btnPrior);
				this.Panel1.Controls.Add(this.lblBillTypeName);
				this.Panel1.Controls.Add(this.dgSaleFoods);
				this.Panel1.Location = new System.Drawing.Point(224, 72);
				this.Panel1.Name = "Panel1";
				this.Panel1.Size = new System.Drawing.Size(424, 465);
				this.Panel1.TabIndex = 25;
				//
				//Panel2
				//
				this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel2.Controls.Add(this.Button15);
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
				this.Panel2.Size = new System.Drawing.Size(408, 128);
				this.Panel2.TabIndex = 15;
				//
				//Button15
				//
				this.Button15.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.Button15.Location = new System.Drawing.Point(328, 27);
				this.Button15.Name = "Button15";
				this.Button15.Size = new System.Drawing.Size(64, 23);
				this.Button15.TabIndex = 15;
				this.Button15.Text = "更新";
				this.Button15.Visible = false;
				//
				//numOpenPsn
				//
				this.numOpenPsn.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.numOpenPsn.BackColor = System.Drawing.Color.FromArgb((byte) (224), (byte) (224), (byte) (224));
				this.numOpenPsn.Location = new System.Drawing.Point(224, 27);
				this.numOpenPsn.Name = "numOpenPsn";
				this.numOpenPsn.TabIndex = 16;
				this.numOpenPsn.Text = "TextBox1";
				this.numOpenPsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				this.numOpenPsn.Visible = false;
				//
				//Label2
				//
				this.Label2.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.Label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label2.ForeColor = System.Drawing.Color.Red;
				this.Label2.Location = new System.Drawing.Point(224, 64);
				this.Label2.Name = "Label2";
				this.Label2.Size = new System.Drawing.Size(176, 56);
				this.Label2.TabIndex = 14;
				this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//Panel3
				//
				this.Panel3.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.Panel3.BackColor = System.Drawing.Color.Black;
				this.Panel3.Location = new System.Drawing.Point(8, 56);
				this.Panel3.Name = "Panel3";
				this.Panel3.Size = new System.Drawing.Size(390, 3);
				this.Panel3.TabIndex = 13;
				//
				//Label1
				//
				this.Label1.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.Label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label1.Location = new System.Drawing.Point(8, 64);
				this.Label1.Name = "Label1";
				this.Label1.Size = new System.Drawing.Size(168, 56);
				this.Label1.TabIndex = 12;
				this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//lblBillno
				//
				this.lblBillno.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.lblBillno.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.lblBillno.Location = new System.Drawing.Point(152, 8);
				this.lblBillno.Name = "lblBillno";
				this.lblBillno.Size = new System.Drawing.Size(240, 23);
				this.lblBillno.TabIndex = 11;
				this.lblBillno.Text = "单据号：";
				//
				//lblOpenpsn
				//
				this.lblOpenpsn.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.lblOpenpsn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.lblOpenpsn.Location = new System.Drawing.Point(152, 32);
				this.lblOpenpsn.Name = "lblOpenpsn";
				this.lblOpenpsn.Size = new System.Drawing.Size(240, 23);
				this.lblOpenpsn.TabIndex = 10;
				this.lblOpenpsn.Text = "开台人数：";
				//
				//lblTableno
				//
				this.lblTableno.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.lblTableno.Location = new System.Drawing.Point(8, 32);
				this.lblTableno.Name = "lblTableno";
				this.lblTableno.Size = new System.Drawing.Size(256, 23);
				this.lblTableno.TabIndex = 9;
				this.lblTableno.Text = "桌台号：";
				//
				//lblOpenDate
				//
				this.lblOpenDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.lblOpenDate.Location = new System.Drawing.Point(8, 8);
				this.lblOpenDate.Name = "lblOpenDate";
				this.lblOpenDate.Size = new System.Drawing.Size(256, 23);
				this.lblOpenDate.TabIndex = 8;
				this.lblOpenDate.Text = "日期：";
				//
				//btnNext
				//
				this.btnNext.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.btnNext.Enabled = false;
				this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btnNext.Location = new System.Drawing.Point(360, 16);
				this.btnNext.Name = "btnNext";
				this.btnNext.Size = new System.Drawing.Size(56, 48);
				this.btnNext.TabIndex = 14;
				this.btnNext.Text = ">>";
				//
				//btnPrior
				//
				this.btnPrior.Enabled = false;
				this.btnPrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btnPrior.Location = new System.Drawing.Point(8, 16);
				this.btnPrior.Name = "btnPrior";
				this.btnPrior.Size = new System.Drawing.Size(56, 48);
				this.btnPrior.TabIndex = 13;
				this.btnPrior.Text = "<<";
				//
				//lblBillTypeName
				//
				this.lblBillTypeName.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.lblBillTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.lblBillTypeName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.lblBillTypeName.ForeColor = System.Drawing.Color.Navy;
				this.lblBillTypeName.Location = new System.Drawing.Point(72, 16);
				this.lblBillTypeName.Name = "lblBillTypeName";
				this.lblBillTypeName.Size = new System.Drawing.Size(280, 48);
				this.lblBillTypeName.TabIndex = 7;
				this.lblBillTypeName.Text = "点菜单";
				this.lblBillTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				//
				//dgSaleFoods
				//
				this.dgSaleFoods.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
				this.dgSaleFoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.dgSaleFoods.CaptionVisible = false;
				this.dgSaleFoods.DataMember = "";
				this.dgSaleFoods.FlatMode = true;
				this.dgSaleFoods.Font = new System.Drawing.Font("宋体", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.dgSaleFoods.HeaderForeColor = System.Drawing.SystemColors.ControlText;
				this.dgSaleFoods.Location = new System.Drawing.Point(8, 208);
				this.dgSaleFoods.Name = "dgSaleFoods";
				this.dgSaleFoods.ReadOnly = true;
				this.dgSaleFoods.Size = new System.Drawing.Size(408, 248);
				this.dgSaleFoods.TabIndex = 6;
				this.dgSaleFoods.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle4});
				//
				//DataGridTableStyle4
				//
				this.DataGridTableStyle4.ColumnHeadersVisible = false;
				this.DataGridTableStyle4.DataGrid = this.dgSaleFoods;
				this.DataGridTableStyle4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn13, this.DataGridTextBoxColumn14, this.DataGridTextBoxColumn15, this.DataGridTextBoxColumn16, this.DataGridTextBoxColumn17, this.DataGridBoolColumn2, this.DataGridTextBoxColumn18, this.DataGridTextBoxColumn19, this.DataGridTextBoxColumn1});
				this.DataGridTableStyle4.HeaderFont = new System.Drawing.Font("宋体", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
				this.DataGridTableStyle4.MappingName = "salefoods";
				//
				//DataGridTextBoxColumn13
				//
				this.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn13.Format = "";
				this.DataGridTextBoxColumn13.FormatInfo = null;
				this.DataGridTextBoxColumn13.HeaderText = "菜品编码";
				this.DataGridTextBoxColumn13.MappingName = "foodcode";
				this.DataGridTextBoxColumn13.Width = 90;
				//
				//DataGridTextBoxColumn14
				//
				this.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn14.Format = "";
				this.DataGridTextBoxColumn14.FormatInfo = null;
				this.DataGridTextBoxColumn14.HeaderText = "菜品名称";
				this.DataGridTextBoxColumn14.MappingName = "foodname";
				this.DataGridTextBoxColumn14.Width = 120;
				//
				//DataGridTextBoxColumn15
				//
				this.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn15.Format = "";
				this.DataGridTextBoxColumn15.FormatInfo = null;
				this.DataGridTextBoxColumn15.HeaderText = "单位";
				this.DataGridTextBoxColumn15.MappingName = "unit";
				this.DataGridTextBoxColumn15.Width = 50;
				//
				//DataGridTextBoxColumn16
				//
				this.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn16.Format = "";
				this.DataGridTextBoxColumn16.FormatInfo = null;
				this.DataGridTextBoxColumn16.HeaderText = "数量";
				this.DataGridTextBoxColumn16.MappingName = "addquantity";
				this.DataGridTextBoxColumn16.Width = 50;
				//
				//DataGridTextBoxColumn17
				//
				this.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn17.Format = "";
				this.DataGridTextBoxColumn17.FormatInfo = null;
				this.DataGridTextBoxColumn17.HeaderText = "价格";
				this.DataGridTextBoxColumn17.MappingName = "price";
				this.DataGridTextBoxColumn17.Width = 65;
				//
				//DataGridBoolColumn2
				//
				this.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridBoolColumn2.FalseValue = "0";
				this.DataGridBoolColumn2.HeaderText = "已上菜";
				this.DataGridBoolColumn2.MappingName = "transfered";
				this.DataGridBoolColumn2.NullText = "";
				this.DataGridBoolColumn2.NullValue = "1";
				this.DataGridBoolColumn2.TrueValue = "2";
				this.DataGridBoolColumn2.Width = 55;
				//
				//DataGridTextBoxColumn18
				//
				this.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn18.Format = "";
				this.DataGridTextBoxColumn18.FormatInfo = null;
				this.DataGridTextBoxColumn18.HeaderText = "做法";
				this.DataGridTextBoxColumn18.MappingName = "operandi";
				this.DataGridTextBoxColumn18.Width = 120;
				//
				//DataGridTextBoxColumn19
				//
				this.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
				this.DataGridTextBoxColumn19.Format = "";
				this.DataGridTextBoxColumn19.FormatInfo = null;
				this.DataGridTextBoxColumn19.HeaderText = "口味";
				this.DataGridTextBoxColumn19.MappingName = "taste";
				this.DataGridTextBoxColumn19.Width = 120;
				//
				//DataGridTextBoxColumn1
				//
				this.DataGridTextBoxColumn1.Format = "";
				this.DataGridTextBoxColumn1.FormatInfo = null;
				this.DataGridTextBoxColumn1.MappingName = "barcode";
				this.DataGridTextBoxColumn1.Width = 0;
				//
				//LinkLabel1
				//
				this.LinkLabel1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.LinkLabel1.Location = new System.Drawing.Point(648, 72);
				this.LinkLabel1.Name = "LinkLabel1";
				this.LinkLabel1.Size = new System.Drawing.Size(80, 23);
				this.LinkLabel1.TabIndex = 24;
				this.LinkLabel1.TabStop = true;
				this.LinkLabel1.Text = "菜品类别：";
				this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				//
				//ToolBar1
				//
				this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton13, this.ToolBarButton4, this.ToolBarButton15, this.ToolBarButton20, this.ToolBarButton6, this.ToolBarButton7, this.ToolBarButton3, this.ToolBarButton8, this.ToolBarButton12, this.ToolBarButton18, this.ToolBarButton9, this.ToolBarButton10, this.ToolBarButton11, this.ToolBarButton21, this.ToolBarButton5, this.ToolBarButton22});
				this.ToolBar1.ButtonSize = new System.Drawing.Size(60, 56);
				this.ToolBar1.DropDownArrows = true;
				this.ToolBar1.ImageList = this.ImageList2;
				this.ToolBar1.Location = new System.Drawing.Point(0, 0);
				this.ToolBar1.Name = "ToolBar1";
				this.ToolBar1.ShowToolTips = true;
				this.ToolBar1.Size = new System.Drawing.Size(896, 63);
				this.ToolBar1.TabIndex = 21;
				this.ToolBar1.Wrappable = false;
				//
				//ToolBarButton1
				//
				this.ToolBarButton1.ImageIndex = 0;
				this.ToolBarButton1.Text = "开台";
				this.ToolBarButton1.ToolTipText = "对选中桌台进行开台操作";
				//
				//ToolBarButton2
				//
				this.ToolBarButton2.ImageIndex = 1;
				this.ToolBarButton2.Text = "加单";
				this.ToolBarButton2.ToolTipText = "向选中桌台进行加单操作";
				//
				//ToolBarButton13
				//
				this.ToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
				//
				//ToolBarButton4
				//
				this.ToolBarButton4.ImageIndex = 3;
				this.ToolBarButton4.Text = "传菜";
				this.ToolBarButton4.ToolTipText = "对选中菜品进行传菜操作";
				//
				//ToolBarButton15
				//
				this.ToolBarButton15.ImageIndex = 4;
				this.ToolBarButton15.Text = "催菜";
				this.ToolBarButton15.ToolTipText = "对选中菜品进行催菜操作";
				//
				//ToolBarButton20
				//
				this.ToolBarButton20.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
				//
				//ToolBarButton6
				//
				this.ToolBarButton6.ImageIndex = 5;
				this.ToolBarButton6.Text = "转台";
				this.ToolBarButton6.ToolTipText = "对选中桌台进行转台操作";
				//
				//ToolBarButton7
				//
				this.ToolBarButton7.ImageIndex = 6;
				this.ToolBarButton7.Text = "并台";
				this.ToolBarButton7.ToolTipText = "对选中桌台进行并台操作";
				//
				//ToolBarButton3
				//
				this.ToolBarButton3.ImageIndex = 5;
				this.ToolBarButton3.Text = "转并台";
				//
				//ToolBarButton8
				//
				this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
				//
				//ToolBarButton12
				//
				this.ToolBarButton12.ImageIndex = 7;
				this.ToolBarButton12.Text = "套餐";
				this.ToolBarButton12.ToolTipText = "向选中桌台及当前单据添加套餐";
				//
				//ToolBarButton18
				//
				this.ToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
				//
				//ToolBarButton9
				//
				this.ToolBarButton9.ImageIndex = 10;
				this.ToolBarButton9.Text = "删单据";
				this.ToolBarButton9.ToolTipText = "删除当前单据";
				//
				//ToolBarButton10
				//
				this.ToolBarButton10.ImageIndex = 11;
				this.ToolBarButton10.Text = "删菜品";
				this.ToolBarButton10.ToolTipText = "删除当前选中的菜品";
				//
				//ToolBarButton11
				//
				this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
				//
				//ToolBarButton21
				//
				this.ToolBarButton21.ImageIndex = 12;
				this.ToolBarButton21.Text = "注销";
				//
				//ToolBarButton5
				//
				this.ToolBarButton5.ImageIndex = 13;
				this.ToolBarButton5.Text = "关于";
				//
				//ToolBarButton22
				//
				this.ToolBarButton22.ImageIndex = 14;
				this.ToolBarButton22.Text = "退出";
				//
				//ImageList2
				//
				this.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
				this.ImageList2.ImageSize = new System.Drawing.Size(28, 28);
				this.ImageList2.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList2.ImageStream"));
				this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
				//
				//txtFoodCode
				//
				this.txtFoodCode.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
				this.txtFoodCode.Location = new System.Drawing.Point(728, 72);
				this.txtFoodCode.Name = "txtFoodCode";
				this.txtFoodCode.Size = new System.Drawing.Size(160, 23);
				this.txtFoodCode.TabIndex = 23;
				this.txtFoodCode.Text = "";
				this.txtFoodCode.Visible = false;
				//
				//pnlInput
				//
				this.pnlInput.BackColor = System.Drawing.Color.FromArgb((byte) (192), (byte) (192), (byte) (255));
				this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.pnlInput.Controls.Add(this.bHide);
				this.pnlInput.Controls.Add(this.bDot);
				this.pnlInput.Controls.Add(this.bCaps);
				this.pnlInput.Controls.Add(this.bSpc);
				this.pnlInput.Controls.Add(this.bM);
				this.pnlInput.Controls.Add(this.bN);
				this.pnlInput.Controls.Add(this.bB);
				this.pnlInput.Controls.Add(this.bV);
				this.pnlInput.Controls.Add(this.bC);
				this.pnlInput.Controls.Add(this.bX);
				this.pnlInput.Controls.Add(this.bZ);
				this.pnlInput.Controls.Add(this.bL);
				this.pnlInput.Controls.Add(this.bK);
				this.pnlInput.Controls.Add(this.bJ);
				this.pnlInput.Controls.Add(this.bH);
				this.pnlInput.Controls.Add(this.bG);
				this.pnlInput.Controls.Add(this.bF);
				this.pnlInput.Controls.Add(this.bD);
				this.pnlInput.Controls.Add(this.bS);
				this.pnlInput.Controls.Add(this.bA);
				this.pnlInput.Controls.Add(this.bBack);
				this.pnlInput.Controls.Add(this.bP);
				this.pnlInput.Controls.Add(this.bO);
				this.pnlInput.Controls.Add(this.bI);
				this.pnlInput.Controls.Add(this.bU);
				this.pnlInput.Controls.Add(this.bY);
				this.pnlInput.Controls.Add(this.bT);
				this.pnlInput.Controls.Add(this.bR);
				this.pnlInput.Controls.Add(this.bE);
				this.pnlInput.Controls.Add(this.bW);
				this.pnlInput.Controls.Add(this.bQ);
				this.pnlInput.Controls.Add(this.b0);
				this.pnlInput.Controls.Add(this.b9);
				this.pnlInput.Controls.Add(this.b8);
				this.pnlInput.Controls.Add(this.b7);
				this.pnlInput.Controls.Add(this.b6);
				this.pnlInput.Controls.Add(this.b5);
				this.pnlInput.Controls.Add(this.b4);
				this.pnlInput.Controls.Add(this.b3);
				this.pnlInput.Controls.Add(this.b2);
				this.pnlInput.Controls.Add(this.b1);
				this.pnlInput.Location = new System.Drawing.Point(224, 199);
				this.pnlInput.Name = "pnlInput";
				this.pnlInput.Size = new System.Drawing.Size(496, 216);
				this.pnlInput.TabIndex = 3;
				this.pnlInput.TabStop = true;
				this.pnlInput.Visible = false;
				//
				//bHide
				//
				this.bHide.BackColor = System.Drawing.SystemColors.Control;
				this.bHide.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bHide.Location = new System.Drawing.Point(400, 168);
				this.bHide.Name = "bHide";
				this.bHide.Size = new System.Drawing.Size(88, 40);
				this.bHide.TabIndex = 40;
				this.bHide.Text = "隐藏";
				//
				//bDot
				//
				this.bDot.BackColor = System.Drawing.SystemColors.Control;
				this.bDot.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bDot.Location = new System.Drawing.Point(392, 128);
				this.bDot.Name = "bDot";
				this.bDot.Size = new System.Drawing.Size(48, 40);
				this.bDot.TabIndex = 39;
				this.bDot.Tag = ".";
				this.bDot.Text = ".";
				//
				//bCaps
				//
				this.bCaps.BackColor = System.Drawing.SystemColors.Control;
				this.bCaps.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bCaps.Location = new System.Drawing.Point(8, 168);
				this.bCaps.Name = "bCaps";
				this.bCaps.Size = new System.Drawing.Size(88, 40);
				this.bCaps.TabIndex = 38;
				this.bCaps.Text = "Caps/小写";
				//
				//bSpc
				//
				this.bSpc.BackColor = System.Drawing.SystemColors.Control;
				this.bSpc.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bSpc.Location = new System.Drawing.Point(104, 168);
				this.bSpc.Name = "bSpc";
				this.bSpc.Size = new System.Drawing.Size(288, 40);
				this.bSpc.TabIndex = 37;
				this.bSpc.Tag = "";
				this.bSpc.Text = "SPACE/空格";
				//
				//bM
				//
				this.bM.BackColor = System.Drawing.SystemColors.Control;
				this.bM.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bM.Location = new System.Drawing.Point(344, 128);
				this.bM.Name = "bM";
				this.bM.Size = new System.Drawing.Size(48, 40);
				this.bM.TabIndex = 36;
				this.bM.Tag = "M";
				this.bM.Text = "M";
				//
				//bN
				//
				this.bN.BackColor = System.Drawing.SystemColors.Control;
				this.bN.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bN.Location = new System.Drawing.Point(296, 128);
				this.bN.Name = "bN";
				this.bN.Size = new System.Drawing.Size(48, 40);
				this.bN.TabIndex = 35;
				this.bN.Tag = "N";
				this.bN.Text = "N";
				//
				//bB
				//
				this.bB.BackColor = System.Drawing.SystemColors.Control;
				this.bB.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bB.Location = new System.Drawing.Point(248, 128);
				this.bB.Name = "bB";
				this.bB.Size = new System.Drawing.Size(48, 40);
				this.bB.TabIndex = 34;
				this.bB.Tag = "B";
				this.bB.Text = "B";
				//
				//bV
				//
				this.bV.BackColor = System.Drawing.SystemColors.Control;
				this.bV.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bV.Location = new System.Drawing.Point(200, 128);
				this.bV.Name = "bV";
				this.bV.Size = new System.Drawing.Size(48, 40);
				this.bV.TabIndex = 33;
				this.bV.Tag = "V";
				this.bV.Text = "V";
				//
				//bC
				//
				this.bC.BackColor = System.Drawing.SystemColors.Control;
				this.bC.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bC.Location = new System.Drawing.Point(152, 128);
				this.bC.Name = "bC";
				this.bC.Size = new System.Drawing.Size(48, 40);
				this.bC.TabIndex = 32;
				this.bC.Tag = "C";
				this.bC.Text = "C";
				//
				//bX
				//
				this.bX.BackColor = System.Drawing.SystemColors.Control;
				this.bX.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bX.Location = new System.Drawing.Point(104, 128);
				this.bX.Name = "bX";
				this.bX.Size = new System.Drawing.Size(48, 40);
				this.bX.TabIndex = 31;
				this.bX.Tag = "X";
				this.bX.Text = "X";
				//
				//bZ
				//
				this.bZ.BackColor = System.Drawing.SystemColors.Control;
				this.bZ.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bZ.Location = new System.Drawing.Point(56, 128);
				this.bZ.Name = "bZ";
				this.bZ.Size = new System.Drawing.Size(48, 40);
				this.bZ.TabIndex = 30;
				this.bZ.Tag = "Z";
				this.bZ.Text = "Z";
				//
				//bL
				//
				this.bL.BackColor = System.Drawing.SystemColors.Control;
				this.bL.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bL.Location = new System.Drawing.Point(416, 88);
				this.bL.Name = "bL";
				this.bL.Size = new System.Drawing.Size(48, 40);
				this.bL.TabIndex = 29;
				this.bL.Tag = "L";
				this.bL.Text = "L";
				//
				//bK
				//
				this.bK.BackColor = System.Drawing.SystemColors.Control;
				this.bK.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bK.Location = new System.Drawing.Point(368, 88);
				this.bK.Name = "bK";
				this.bK.Size = new System.Drawing.Size(48, 40);
				this.bK.TabIndex = 28;
				this.bK.Tag = "K";
				this.bK.Text = "K";
				//
				//bJ
				//
				this.bJ.BackColor = System.Drawing.SystemColors.Control;
				this.bJ.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bJ.Location = new System.Drawing.Point(320, 88);
				this.bJ.Name = "bJ";
				this.bJ.Size = new System.Drawing.Size(48, 40);
				this.bJ.TabIndex = 27;
				this.bJ.Tag = "J";
				this.bJ.Text = "J";
				//
				//bH
				//
				this.bH.BackColor = System.Drawing.SystemColors.Control;
				this.bH.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bH.Location = new System.Drawing.Point(272, 88);
				this.bH.Name = "bH";
				this.bH.Size = new System.Drawing.Size(48, 40);
				this.bH.TabIndex = 26;
				this.bH.Tag = "H";
				this.bH.Text = "H";
				//
				//bG
				//
				this.bG.BackColor = System.Drawing.SystemColors.Control;
				this.bG.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bG.Location = new System.Drawing.Point(224, 88);
				this.bG.Name = "bG";
				this.bG.Size = new System.Drawing.Size(48, 40);
				this.bG.TabIndex = 25;
				this.bG.Tag = "G";
				this.bG.Text = "G";
				//
				//bF
				//
				this.bF.BackColor = System.Drawing.SystemColors.Control;
				this.bF.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bF.Location = new System.Drawing.Point(176, 88);
				this.bF.Name = "bF";
				this.bF.Size = new System.Drawing.Size(48, 40);
				this.bF.TabIndex = 24;
				this.bF.Tag = "F";
				this.bF.Text = "F";
				//
				//bD
				//
				this.bD.BackColor = System.Drawing.SystemColors.Control;
				this.bD.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bD.Location = new System.Drawing.Point(128, 88);
				this.bD.Name = "bD";
				this.bD.Size = new System.Drawing.Size(48, 40);
				this.bD.TabIndex = 23;
				this.bD.Tag = "D";
				this.bD.Text = "D";
				//
				//bS
				//
				this.bS.BackColor = System.Drawing.SystemColors.Control;
				this.bS.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bS.Location = new System.Drawing.Point(80, 88);
				this.bS.Name = "bS";
				this.bS.Size = new System.Drawing.Size(48, 40);
				this.bS.TabIndex = 22;
				this.bS.Tag = "S";
				this.bS.Text = "S";
				//
				//bA
				//
				this.bA.BackColor = System.Drawing.SystemColors.Control;
				this.bA.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bA.Location = new System.Drawing.Point(32, 88);
				this.bA.Name = "bA";
				this.bA.Size = new System.Drawing.Size(48, 40);
				this.bA.TabIndex = 21;
				this.bA.Tag = "A";
				this.bA.Text = "A";
				//
				//bBack
				//
				this.bBack.BackColor = System.Drawing.SystemColors.Control;
				this.bBack.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bBack.Location = new System.Drawing.Point(416, 8);
				this.bBack.Name = "bBack";
				this.bBack.Size = new System.Drawing.Size(72, 32);
				this.bBack.TabIndex = 20;
				this.bBack.Text = "BACK Space";
				//
				//bP
				//
				this.bP.BackColor = System.Drawing.SystemColors.Control;
				this.bP.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bP.Location = new System.Drawing.Point(440, 48);
				this.bP.Name = "bP";
				this.bP.Size = new System.Drawing.Size(48, 40);
				this.bP.TabIndex = 19;
				this.bP.Tag = "P";
				this.bP.Text = "P";
				//
				//bO
				//
				this.bO.BackColor = System.Drawing.SystemColors.Control;
				this.bO.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bO.Location = new System.Drawing.Point(392, 48);
				this.bO.Name = "bO";
				this.bO.Size = new System.Drawing.Size(48, 40);
				this.bO.TabIndex = 18;
				this.bO.Tag = "O";
				this.bO.Text = "O";
				//
				//bI
				//
				this.bI.BackColor = System.Drawing.SystemColors.Control;
				this.bI.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bI.Location = new System.Drawing.Point(344, 48);
				this.bI.Name = "bI";
				this.bI.Size = new System.Drawing.Size(48, 40);
				this.bI.TabIndex = 17;
				this.bI.Tag = "I";
				this.bI.Text = "I";
				//
				//bU
				//
				this.bU.BackColor = System.Drawing.SystemColors.Control;
				this.bU.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bU.Location = new System.Drawing.Point(296, 48);
				this.bU.Name = "bU";
				this.bU.Size = new System.Drawing.Size(48, 40);
				this.bU.TabIndex = 16;
				this.bU.Tag = "U";
				this.bU.Text = "U";
				//
				//bY
				//
				this.bY.BackColor = System.Drawing.SystemColors.Control;
				this.bY.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bY.Location = new System.Drawing.Point(248, 48);
				this.bY.Name = "bY";
				this.bY.Size = new System.Drawing.Size(48, 40);
				this.bY.TabIndex = 15;
				this.bY.Tag = "Y";
				this.bY.Text = "Y";
				//
				//bT
				//
				this.bT.BackColor = System.Drawing.SystemColors.Control;
				this.bT.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bT.Location = new System.Drawing.Point(200, 48);
				this.bT.Name = "bT";
				this.bT.Size = new System.Drawing.Size(48, 40);
				this.bT.TabIndex = 14;
				this.bT.Tag = "T";
				this.bT.Text = "T";
				//
				//bR
				//
				this.bR.BackColor = System.Drawing.SystemColors.Control;
				this.bR.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bR.Location = new System.Drawing.Point(152, 48);
				this.bR.Name = "bR";
				this.bR.Size = new System.Drawing.Size(48, 40);
				this.bR.TabIndex = 13;
				this.bR.Tag = "R";
				this.bR.Text = "R";
				//
				//bE
				//
				this.bE.BackColor = System.Drawing.SystemColors.Control;
				this.bE.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bE.Location = new System.Drawing.Point(104, 48);
				this.bE.Name = "bE";
				this.bE.Size = new System.Drawing.Size(48, 40);
				this.bE.TabIndex = 12;
				this.bE.Tag = "E";
				this.bE.Text = "E";
				//
				//bW
				//
				this.bW.BackColor = System.Drawing.SystemColors.Control;
				this.bW.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bW.Location = new System.Drawing.Point(56, 48);
				this.bW.Name = "bW";
				this.bW.Size = new System.Drawing.Size(48, 40);
				this.bW.TabIndex = 11;
				this.bW.Tag = "W";
				this.bW.Text = "W";
				//
				//bQ
				//
				this.bQ.BackColor = System.Drawing.SystemColors.Control;
				this.bQ.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.bQ.Location = new System.Drawing.Point(8, 48);
				this.bQ.Name = "bQ";
				this.bQ.Size = new System.Drawing.Size(48, 40);
				this.bQ.TabIndex = 10;
				this.bQ.Tag = "Q";
				this.bQ.Text = "Q";
				//
				//b0
				//
				this.b0.BackColor = System.Drawing.SystemColors.Control;
				this.b0.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b0.Location = new System.Drawing.Point(368, 8);
				this.b0.Name = "b0";
				this.b0.Size = new System.Drawing.Size(40, 32);
				this.b0.TabIndex = 9;
				this.b0.Tag = "0";
				this.b0.Text = "0";
				//
				//b9
				//
				this.b9.BackColor = System.Drawing.SystemColors.Control;
				this.b9.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b9.Location = new System.Drawing.Point(328, 8);
				this.b9.Name = "b9";
				this.b9.Size = new System.Drawing.Size(40, 32);
				this.b9.TabIndex = 8;
				this.b9.Tag = "9";
				this.b9.Text = "9";
				//
				//b8
				//
				this.b8.BackColor = System.Drawing.SystemColors.Control;
				this.b8.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b8.Location = new System.Drawing.Point(288, 8);
				this.b8.Name = "b8";
				this.b8.Size = new System.Drawing.Size(40, 32);
				this.b8.TabIndex = 7;
				this.b8.Tag = "8";
				this.b8.Text = "8";
				//
				//b7
				//
				this.b7.BackColor = System.Drawing.SystemColors.Control;
				this.b7.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b7.Location = new System.Drawing.Point(248, 8);
				this.b7.Name = "b7";
				this.b7.Size = new System.Drawing.Size(40, 32);
				this.b7.TabIndex = 6;
				this.b7.Tag = "7";
				this.b7.Text = "7";
				//
				//b6
				//
				this.b6.BackColor = System.Drawing.SystemColors.Control;
				this.b6.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b6.Location = new System.Drawing.Point(208, 8);
				this.b6.Name = "b6";
				this.b6.Size = new System.Drawing.Size(40, 32);
				this.b6.TabIndex = 5;
				this.b6.Tag = "6";
				this.b6.Text = "6";
				//
				//b5
				//
				this.b5.BackColor = System.Drawing.SystemColors.Control;
				this.b5.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b5.Location = new System.Drawing.Point(168, 8);
				this.b5.Name = "b5";
				this.b5.Size = new System.Drawing.Size(40, 32);
				this.b5.TabIndex = 4;
				this.b5.Tag = "5";
				this.b5.Text = "5";
				//
				//b4
				//
				this.b4.BackColor = System.Drawing.SystemColors.Control;
				this.b4.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b4.Location = new System.Drawing.Point(128, 8);
				this.b4.Name = "b4";
				this.b4.Size = new System.Drawing.Size(40, 32);
				this.b4.TabIndex = 3;
				this.b4.Tag = "4";
				this.b4.Text = "4";
				//
				//b3
				//
				this.b3.BackColor = System.Drawing.SystemColors.Control;
				this.b3.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b3.Location = new System.Drawing.Point(88, 8);
				this.b3.Name = "b3";
				this.b3.Size = new System.Drawing.Size(40, 32);
				this.b3.TabIndex = 2;
				this.b3.Tag = "3";
				this.b3.Text = "3";
				//
				//b2
				//
				this.b2.BackColor = System.Drawing.SystemColors.Control;
				this.b2.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b2.Location = new System.Drawing.Point(48, 8);
				this.b2.Name = "b2";
				this.b2.Size = new System.Drawing.Size(40, 32);
				this.b2.TabIndex = 1;
				this.b2.Tag = "2";
				this.b2.Text = "2";
				//
				//b1
				//
				this.b1.BackColor = System.Drawing.SystemColors.Control;
				this.b1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.b1.Location = new System.Drawing.Point(8, 8);
				this.b1.Name = "b1";
				this.b1.Size = new System.Drawing.Size(40, 32);
				this.b1.TabIndex = 0;
				this.b1.Tag = "1";
				this.b1.Text = "1";
				//
				//Timer1
				//
				this.Timer1.Enabled = true;
				this.Timer1.Interval = 480000;
				this.Timer1.SynchronizingObject = this;
				//
				//Form1
				//
				this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
				this.ClientSize = new System.Drawing.Size(920, 598);
				this.ControlBox = false;
				this.Controls.Add(this.TabControl1);
				this.Controls.Add(this.pnlInput);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "Form1";
				this.Text = "餐厅管家 - 触摸屏客户端";
				this.TopMost = true;
				this.TabControl1.ResumeLayout(false);
				this.TabPage1.ResumeLayout(false);
				this.TabPage2.ResumeLayout(false);
				this.Panel1.ResumeLayout(false);
				this.Panel2.ResumeLayout(false);
				((System.ComponentModel.ISupportInitialize) this.dgSaleFoods).EndInit();
				this.pnlInput.ResumeLayout(false);
				((System.ComponentModel.ISupportInitialize) this.Timer1).EndInit();
				this.ResumeLayout(false);
				
			}
			
			#endregion
			
			//刷新桌台列表视图
			//Public Sub RefreshTableListView(ByVal TableTypeName As String)
			//Dim tablelist As DataTable
			//tablelist = LoadTableList(TableTypeName)
			
			//lvTablelist.Items.Clear()
			//ReDim lvitems(tablelist.Rows.Count - 1)
			//Dim ts As Integer
			//For i As Integer = 0 To tablelist.Rows.Count - 1
			//lvitems(i) = New ListViewItem
			//lvitems(i).Text = tablelist.Rows(i).Item(0)
			//ts = tablelist.Rows(i).Item(2)
			//If ts = 0 Then '空闲
			//lvitems(i).ImageIndex = 0
			//ElseIf ts = 1 Then '使用
			//lvitems(i).ImageIndex = 1
			//ElseIf ts = 2 Then '预订
			//lvitems(i).ImageIndex = 2
			//End If
			
			//lvTablelist.Items.Add(lvitems(i))
			//Next
			//End Sub
			
			//返回相应桌台类别/位置的桌台列表，并填充桌台列表
			public void GetTableList(string tabletypename)
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
					//dgTableStatus.DataSource = Nothing
					//dgTableStatus.DataSource = dbDS
					//dgTableStatus.DataMember = "tablestatus"
					
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
			public void GetFoodList(string filter, int FilterMode, int OrderFood, string Tableno)
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
					//dgFoodList.DataSource = Nothing
					//dgFoodList.DataSource = dbDS
					//dgFoodList.DataMember = "FoodList"
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
			
			//返回桌台信息
			private void GetOpenedTableInfo(string tableno, string billno)
			{
				if (CurrentBillNo != "")
				{
					Label1.Text = "单据数量： " + BillCount.ToString() + "\r\n";
					Label1.Text = Label1.Text + "当前单据菜品数量： " + dgSaleFoods.VisibleRowCount.ToString() + "\r\n";
					if (BillCount > 0)
					{
						if (! rms_var.IsCancelBill(rms_var.GetBillNoTypeCode(billno), ""))
						{
							Label2.Text = "当前单据金额： " + rms_var.GetBillPrice(tableno, billno, 0) + "\r\n";
						}
						else
						{
							Label2.Text = "当前单据金额： " + rms_var.GetBillPrice(tableno, billno, 1) + "\r\n";
						}
						Label2.Text = Label2.Text + "当前桌台菜品总金额： " + rms_var.GetTablePrice(tableno) + "\r\n";
					}
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
				Button15.Hide();
				//获得当前桌台及单据菜品记录
				GetRelateFoods(CurrentTableNo, CurrentBillNo);
				Label1.Text = "";
				Label2.Text = "";
			}
			
			//更新窗口
			public void ShowBill(string tableno, string recno)
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
					numOpenPsn.Text = rms_var.GetOpenTablePsn(CurrentTableNo).ToString();
					numOpenPsn.Show();
					Button15.Show();
					
					if (rms_var.IsCancelBill(rms_var.GetBillNoTypeCode(CurrentBillNo), ""))
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
					Button15.Hide();
					//获得当前桌台及单据菜品记录
					GetRelateFoods(CurrentTableNo, CurrentBillNo);
					Label1.Text = "";
					Label2.Text = "";
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
				addfrm.Label6.Text = addfrm.BillTypeList[0].ToString();
				addfrm.CurrentBillTypeName = addfrm.BillTypeList[0].ToString();
				addfrm.Label5.Text = "请为 " + tableno + " 号桌台开台并添加消费单据";
				addfrm.TextBox2.Text = rms_var.opinfo.OpID;
				
				addfrm.ShowDialog();
				if (addfrm.DialogResult == DialogResult.OK)
				{
					rms_var.ExeOpenTable(tableno, int.Parse(addfrm.TextBox3.Text), addfrm.TextBox2.Text);
					string serialno;
					serialno = rms_var.GenUniqueCode();
					rms_var.AddBalanceTable(serialno, tableno, addfrm.TextBox3.Text, addfrm.TextBox2.Text);
					GetTableList(CurrentTableTypeName);
					//准备添加第一张单据
					if (! rms_var.SameBillinSale(addfrm.TextBox1.Text, addfrm.CurrentBillTypeName))
					{
						if (rms_var.AddSaleBill(serialno, tableno, addfrm.TextBox1.Text, rms_var.GetBillTypeCode(addfrm.CurrentBillTypeName), addfrm.TextBox2.Text))
						{
							CurrentTableNo = tableno;
							CurrentBillNo = addfrm.TextBox1.Text;
							CurrentBillTypename = addfrm.CurrentBillTypeName;
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
					return true;
				}
				else
				{
					return false;
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
							selectCMD1.CommandText = "SELECT top 1 appointno FROM view_appointtable where status='0' and " + "arrivedate='" + DateTime.Now.ToShortDateString() + "' and " + "timeblockcode='" + rms_var.GetTimeBlockCode(rms_var.GetSysSetup("CurrentTimeblockName")) + "' and tableno='" + tableno + "'";
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
								GetTableList(CurrentTableTypeName);
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
			
			//转台 使用 - 空闲
			private void MoveTable(string SrcSerialNo, string srcTableno)
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
										SQLCMD.CommandText = "update salebill_t set " + "tableno='" + dstTableno + "'" + " where serialno='" + SrcSerialNo + "' and tableno='" + srcTableno + "'";
										conn.Open();
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "update BalanceTable_t set " + "tableno='" + dstTableno + "'" + " where serialno='" + SrcSerialNo + "' and tableno='" + srcTableno + "'";
										
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "update tablestatus set " + "status='0'" + " where tableno='" + srcTableno + "'";
										
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "update tablestatus set " + "status='1'" + "," + "peoplenumber=" + rms_var.GetTablePsnCount(srcTableno) + "," + "begintime='" + rms_var.GetTableBeginTime(srcTableno) + "'" + " where tableno='" + dstTableno + "'";
										
										SQLCMD.ExecuteNonQuery();
										
										MessageBox.Show("转台操作顺利完成");
										GetTableList(CurrentTableTypeName);
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
						MessageBox.Show("原桌台预定中，您不可以为该桌台进行转台操作。请首先进行开台操作。");
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
								case 0: //目标桌台空闲，允许转台
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
										SQLCMD.CommandText = "update salebill_t set " + "tableno='" + dstTableno + "'" + "," + "serialno='" + DstTableSerialno + "'" + " where serialno='" + SrcSerialNo + "' and tableno='" + srcTableno + "'";
										conn.Open();
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "update salelist_t set " + "serialno='" + DstTableSerialno + "' " + "where serialno='" + SrcSerialNo + "'";
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "delete BalanceTable_t " + " where serialno='" + SrcSerialNo + "' and tableno='" + srcTableno + "'";
										
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "update tablestatus set " + "status='0'" + " where tableno='" + srcTableno + "'";
										
										SQLCMD.ExecuteNonQuery();
										SQLCMD.CommandText = "update tablestatus set " + "status='1'" + "," + "peoplenumber=" + (System.Convert.ToString((int.Parse(rms_var.GetTablePsnCount(srcTableno))) + int.Parse(rms_var.GetTablePsnCount(dstTableno)))) + "," + "begintime='" + rms_var.GetTableBeginTime(srcTableno) + "'" + " where tableno='" + dstTableno + "'";
										
										SQLCMD.ExecuteNonQuery();
										MessageBox.Show("转台操作顺利完成");
										GetTableList(CurrentTableTypeName);
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
											
											SQLCMD.CommandText = "update balancetable_t set " + "serialno='" + DstTableSerialno + "' " + "where serialno='" + SrcSerialNo + "'";
											SQLCMD.ExecuteNonQuery();
											
											SQLCMD.CommandText = "update salebill_t set " + "serialno='" + DstTableSerialno + "' " + "where serialno='" + SrcSerialNo + "'";
											SQLCMD.ExecuteNonQuery();
											
											SQLCMD.CommandText = "update salelist_t set " + "serialno='" + DstTableSerialno + "' " + "where serialno='" + SrcSerialNo + "'";
											SQLCMD.ExecuteNonQuery();
											
											MessageBox.Show("并台操作顺利完成");
											GetTableList(CurrentTableTypeName);
											
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
					addfrm.Label6.Text = addfrm.BillTypeList[0].ToString();
					addfrm.CurrentBillTypeName = addfrm.BillTypeList[0].ToString();
				}
				else
				{
					addfrm.GetConsumeBillTypeList();
					addfrm.Label6.Text = addfrm.BillTypeList[0].ToString();
					addfrm.CurrentBillTypeName = addfrm.BillTypeList[0].ToString();
				}
				
				addfrm.TextBox3.Visible = false;
				addfrm.Label3.Visible = false;
				addfrm.Label5.Text = "请为 " + tableno + " 号桌台加单";
				
				addfrm.TextBox2.Text = rms_var.opinfo.OpID;
				addfrm.ShowDialog();
				if (addfrm.DialogResult == DialogResult.OK)
				{
					//准备添加单据
					if (! rms_var.SameBillinSale(addfrm.TextBox1.Text, addfrm.CurrentBillTypeName))
					{
						if (rms_var.AddSaleBill(rms_var.GetCurrentTableSerialNo(tableno), tableno, addfrm.TextBox1.Text, rms_var.GetBillTypeCode(addfrm.CurrentBillTypeName), addfrm.TextBox2.Text))
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
				frmOrderFoodInfo.Label1.Text = CurrentSelectedFoodName;
				frmOrderFoodInfo.Label5.Text = "单位：" + CurrentSelectedFoodUnit;
				if (rms_var.IsCustomFood(CurrentSelectedFoodCode))
				{
					frmOrderFoodInfo.numFoodPrice.Text = rms_var.GetFoodPrice(CurrentSelectedFoodCode, false).ToString();
					frmOrderFoodInfo.numFoodPrice.BringToFront();
					frmOrderFoodInfo.numFoodPrice.Show();
				}
				else
				{
					frmOrderFoodInfo.numFoodPrice.Text = rms_var.GetFoodPrice(CurrentSelectedFoodCode, false).ToString();
					frmOrderFoodInfo.Label7.Text = rms_var.GetFoodPrice(CurrentSelectedFoodCode, false);
					frmOrderFoodInfo.numFoodPrice.BringToFront();
				}
				frmOrderFoodInfo.ShowDialog();
				if (frmOrderFoodInfo.DialogResult == DialogResult.OK)
				{
					rms_var.AddFoodtoBill(rms_var.GetCurrentTableSerialNo(tableno), rms_var.GenUniqueCode(), billno, rms_var.GetBillTypeCode(billtypename), CurrentSelectedFoodCode, System.Convert.ToString(frmOrderFoodInfo.FoodQuantity * frmOrderFoodInfo.FoodUnitPrice), frmOrderFoodInfo.FoodQuantity, 0, frmOrderFoodInfo.FoodOperandi, frmOrderFoodInfo.FoodTaste, rms_var.opinfo.OpID, "", 0);
					GetRelateFoods(tableno, billno);
					GetOpenedTableInfo(tableno, billno);
					
					//检测是否自动传菜
					if (rms_var.GetSysSetup("autoPrintFood") == "1") //点菜后自动传菜
					{
						//传送当前菜品
						if (rms_var.TransFood_Rmt_Async(CurrentSelectedFoodCode, rms_var.GetTableTypeName(tableno), tableno, rms_var.GetTablePsnCount(tableno), billno, rms_var.GetFoodName(CurrentSelectedFoodCode), rms_var.GetFoodTypeName(CurrentSelectedFoodCode), rms_var.GetFoodDeptName(CurrentSelectedFoodCode), rms_var.GetFoodUnit(CurrentSelectedFoodCode), frmOrderFoodInfo.FoodQuantity.ToString(), frmOrderFoodInfo.FoodOperandi, frmOrderFoodInfo.FoodTaste, rms_var.opinfo.OpID, rms_var.GetSaledFoodBarcode(CurrentBillNo, CurrentSelectedFoodCode), 0, ""))
							{
							
							//更新菜品传送标记
							rms_var.UpdateFoodTransSign(rms_var.GetSaledFoodBarcode(CurrentBillNo, CurrentSelectedFoodCode));
							ShowTable(tableno);
							MessageBox.Show("菜品 " + rms_var.GetFoodName(CurrentSelectedFoodCode) + " 传送成功！");
						}
					}
				}
			}
			
			//向取消单中添加菜品
			private void AddFoodToCancelBill(string tableno, string billno, string billtypename)
			{
				//先检测当前桌台有无该菜品，有则允许减菜，并返回已经点菜的数量
				if (rms_var.CurrentTableExistsFood(tableno, CurrentSelectedFoodCode))
				{
					//返回当前菜品已点的数量
					frmCancelFoodQty frmcfq = new frmCancelFoodQty();
					double maxCancelqty;
					//Dim Cancelqty As Double
					
					maxCancelqty = rms_var.GetCurrentTableAllowCancelFoodQty(tableno, CurrentSelectedFoodCode);
					
					frmcfq.MaxCount = maxCancelqty;
					frmcfq.NumericUpDown1.Maximum = (decimal) maxCancelqty;
					frmcfq.ShowDialog();
					if (frmcfq.DialogResult == DialogResult.OK)
					{
						if (!(Convert.ToDouble(frmcfq.NumericUpDown1.Value) > maxCancelqty))
						{
							rms_var.AddFoodtoBill(rms_var.GetCurrentTableSerialNo(tableno), rms_var.GenUniqueCode(), billno, rms_var.GetBillTypeCode(billtypename), CurrentSelectedFoodCode, System.Convert.ToString(frmcfq.NumericUpDown1.Value * decimal.Parse(rms_var.GetFoodPrice(CurrentSelectedFoodCode, false))), 0, (double) frmcfq.NumericUpDown1.Value, "", "", rms_var.opinfo.OpID, "", 0);
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
					System.Double totalsuitquantity = suitquantity + suitcount;
					string SuitFoodGuid = rms_var.GenUniqueCode();
					for (int i = 0; i <= dbDS1.Tables[0].Rows.Count - 1; i++)
					{
                        rms_var.AddFoodtoBill(rms_var.GetCurrentTableSerialNo(tableno), SuitFoodGuid, billno, rms_var.GetBillNoTypeCode(billno), dbDS1.Tables[0].Rows[i]["foodcode"].ToString(), dbDS1.Tables[0].Rows[i]["foodprice"].ToString(), System.Convert.ToDouble(dbDS1.Tables[0].Rows[i]["foodqty"]), suitquantity * Convert.ToDouble(dbDS1.Tables[0].Rows[i]["foodqty"]), "", "", rms_var.opinfo.OpID, suitcode, suitquantity);
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
			
			private void Form1_Load(System.Object sender, System.EventArgs e)
			{
                //if (!Authorize.GetValidityUUID(rms_var.ReadStrfromReg("Key", "")))
                //{
                //    MessageBox.Show("授权无效");
                //    Application.Exit();
                //    return;

                //}

				rms_var.frmMain = this;
				bSpc.Tag = " ";
				
				frminptForm = new frmInputPanel();
				
				rms_var.TheAppExt = new AppExt.CAppExt();
				rms_var.TheAppExt.LogModule = 7; //报告登录的是->前台管理模块
				string rtn = rms_var.TheAppExt.ShowLogForm2("触摸屏客户端");
				if (rtn.Trim() == "-1")
				{
					Application.Exit();
				}
				else
				{
					rms_var.ConnStr = rms_var.TheAppExt.GetConnStr; //复制远程连接字符串
					if (rms_var.GetCurrentTableNoBillsCount("") >= 200)
					{
						return;
					}
					rms_var.ReceiveOperatorInfo(rtn);
					//获取首页桌台类别
					GetTableTypes1();
					TableTypesBtnList1.SelectItem(TableTypesBtnList1.Count - 1);
					//RefreshTableListView("全部")
					GetTablesInFirstView("全部");
					//获取桌台类别
					GetTableTypes2();
					TableTypesBtnList2.SelectItem(TableTypesBtnList2.Count - 1);
					GetTables("全部");
					GetDepartment();
					GetFoodTypes("全部");
					GetFoods("全部", 3);
					this.Top = 0;
					this.Left = 0;
					this.WindowState = FormWindowState.Maximized;
				}
			}
			
			#region 软件盘 事件
			
			private void bCaps_Click(System.Object sender, System.EventArgs e)
			{
				if (CapsStatus == 1) // 大写，改成小写
				{
					bA.Text = bA.Text.ToLower();
					bA.Tag = bA.Text;
					
					bB.Text = bB.Text.ToLower();
					bB.Tag = bB.Text;
					
					bC.Text = bC.Text.ToLower();
					bC.Tag = bC.Text;
					
					bD.Text = bD.Text.ToLower();
					bD.Tag = bD.Text;
					
					bE.Text = bE.Text.ToLower();
					bE.Tag = bE.Text;
					
					bF.Text = bF.Text.ToLower();
					bF.Tag = bF.Text;
					
					bG.Text = bG.Text.ToLower();
					bG.Tag = bG.Text;
					
					bH.Text = bH.Text.ToLower();
					bH.Tag = bH.Text;
					
					bI.Text = bI.Text.ToLower();
					bI.Tag = bI.Text;
					
					bJ.Text = bJ.Text.ToLower();
					bJ.Tag = bJ.Text;
					
					bK.Text = bK.Text.ToLower();
					bK.Tag = bK.Text;
					
					bL.Text = bL.Text.ToLower();
					bL.Tag = bL.Text;
					
					bM.Text = bM.Text.ToLower();
					bM.Tag = bM.Text;
					
					bN.Text = bN.Text.ToLower();
					bN.Tag = bN.Text;
					
					bO.Text = bO.Text.ToLower();
					bO.Tag = bO.Text;
					
					bP.Text = bP.Text.ToLower();
					bP.Tag = bP.Text;
					
					bQ.Text = bQ.Text.ToLower();
					bQ.Tag = bQ.Text;
					
					bR.Text = bR.Text.ToLower();
					bR.Tag = bR.Text;
					
					bS.Text = bS.Text.ToLower();
					bS.Tag = bS.Text;
					
					bT.Text = bT.Text.ToLower();
					bT.Tag = bT.Text;
					
					bU.Text = bU.Text.ToLower();
					bU.Tag = bU.Text;
					
					bV.Text = bV.Text.ToLower();
					bV.Tag = bV.Text;
					
					bW.Text = bW.Text.ToLower();
					bW.Tag = bW.Text;
					
					bX.Text = bX.Text.ToLower();
					bX.Tag = bX.Text;
					
					bY.Text = bY.Text.ToLower();
					bY.Tag = bY.Text;
					
					bZ.Text = bZ.Text.ToLower();
					bZ.Tag = bZ.Text;
					
					CapsStatus = 0;
					bCaps.Text = "Caps/小写";
				}
				else // 小写，改成大写
				{
					bA.Text = bA.Text.ToUpper();
					bA.Tag = bA.Text;
					
					bB.Text = bB.Text.ToUpper();
					bB.Tag = bB.Text;
					
					bC.Text = bC.Text.ToUpper();
					bC.Tag = bC.Text;
					
					bD.Text = bD.Text.ToUpper();
					bD.Tag = bD.Text;
					
					bE.Text = bE.Text.ToUpper();
					bE.Tag = bE.Text;
					
					bF.Text = bF.Text.ToUpper();
					bF.Tag = bF.Text;
					
					bG.Text = bG.Text.ToUpper();
					bG.Tag = bG.Text;
					
					bH.Text = bH.Text.ToUpper();
					bH.Tag = bH.Text;
					
					bI.Text = bI.Text.ToUpper();
					bI.Tag = bI.Text;
					
					bJ.Text = bJ.Text.ToUpper();
					bJ.Tag = bJ.Text;
					
					bK.Text = bK.Text.ToUpper();
					bK.Tag = bK.Text;
					
					bL.Text = bL.Text.ToUpper();
					bL.Tag = bL.Text;
					
					bM.Text = bM.Text.ToUpper();
					bM.Tag = bM.Text;
					
					bN.Text = bN.Text.ToUpper();
					bN.Tag = bN.Text;
					
					bO.Text = bO.Text.ToUpper();
					bO.Tag = bO.Text;
					
					bP.Text = bP.Text.ToUpper();
					bP.Tag = bP.Text;
					
					bQ.Text = bQ.Text.ToUpper();
					bQ.Tag = bQ.Text;
					
					bR.Text = bR.Text.ToUpper();
					bR.Tag = bR.Text;
					
					bS.Text = bS.Text.ToUpper();
					bS.Tag = bS.Text;
					
					bT.Text = bT.Text.ToUpper();
					bT.Tag = bT.Text;
					
					bU.Text = bU.Text.ToUpper();
					bU.Tag = bU.Text;
					
					bV.Text = bV.Text.ToUpper();
					bV.Tag = bV.Text;
					
					bW.Text = bW.Text.ToUpper();
					bW.Tag = bW.Text;
					
					bX.Text = bX.Text.ToUpper();
					bX.Tag = bX.Text;
					
					bY.Text = bY.Text.ToUpper();
					bY.Tag = bY.Text;
					
					bZ.Text = bZ.Text.ToUpper();
					bZ.Tag = bZ.Text;
					
					CapsStatus = 1;
					bCaps.Text = "Caps/大写";
				}
			}
			
			private void bHide_Click(System.Object sender, System.EventArgs e)
			{
				pnlInput.Hide();
			}
			
			private void InputButton_Click(System.Object sender, System.EventArgs e)
			{
				CurrentUsedTextBox.Text +=((Button)sender).Tag.ToString();
				CurrentUsedTextBox.Focus();
				CurrentUsedTextBox.Select(CurrentUsedTextBox.TextLength, 0);
			}
			
			private void bBack_Click(System.Object sender, System.EventArgs e)
			{
				if (CurrentUsedTextBox.TextLength > 0)
				{
					string txt = CurrentUsedTextBox.Text;
					int startIndex = txt.Length - 1;
					
					txt = txt.Remove(startIndex, 1);
					CurrentUsedTextBox.Text = txt;
					CurrentUsedTextBox.Focus();
					CurrentUsedTextBox.Select(CurrentUsedTextBox.TextLength, 0);
				}
				
			}
			
			private void b1_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b2_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b3_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b4_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b5_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b6_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b7_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b8_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b9_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void b0_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bQ_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bW_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bE_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bR_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bT_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bY_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bU_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bI_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bO_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bP_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bA_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bS_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bD_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bF_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bG_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bH_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bJ_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bK_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bL_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bZ_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bX_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bC_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bV_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bB_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bN_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bM_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bDot_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			private void bSpc_Click(System.Object sender, System.EventArgs e)
			{
				InputButton_Click(sender, e);
			}
			
			#endregion
			
			private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
			{
				switch (ToolBar1.Buttons.IndexOf(e.Button))
				{
					case 0: //开台
						int ts_1;
						ts_1 = rms_var.GetTableStatus(CurrentTableNo);
						switch (ts_1)
						{
							case 0: //桌台空闲
								//准备开台
								if (OpenTableAndAddBill(CurrentTableNo))
								{
									GetTables(CurrentTableTypeName);
									GetTableBills(CurrentTableNo);
									ShowBill(CurrentTableNo, "first");
                                    //MessageBox.Show("开台操作顺利完成");
								}
								break;
							case 1: //桌台使用中
								MessageBox.Show("该桌台已经开台");
								//返回使用中桌台的单据列表
								ShowBill(CurrentTableNo, "first");
								break;
							case 2: //原桌台预定中
								break;
								
						}
						break;
					case 1: //加单
						int ts_2;
						ts_2 = rms_var.GetTableStatus(CurrentTableNo);
						switch (ts_2)
						{
							case 0: //桌台空闲
								//准备开台
								OpenTableAndAddBill(CurrentTableNo);
								break;
							case 1: //桌台使用中
								//先显示单据
								ShowBill(CurrentTableNo, "first");
								//准备加单
								AddBill(CurrentTableNo);
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
						
						//不允许超过6条
						//If dgSaleFoods.VisibleRowCount >= 6 Then
						//MsgBox("抱歉，该操作已受限！请联系软件供应商。")
						//Exit Sub
						//End If
						
						if (dgSaleFoods.VisibleRowCount > 0)
						{
							if (! dgSaleFoods.IsSelected(dgSaleFoods.CurrentRowIndex))
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
										if (dgSaleFoods[i, 5].ToString() == "") //已传菜
										{
											MessageBox.Show("当前菜品" + dgSaleFoods[i, 1] + " 已经被传送，不能再进行传菜操作。");
										}
                                        else if (dgSaleFoods[i, 5].ToString() == "1") //已上菜)
										{
											MessageBox.Show("当前菜品 " + dgSaleFoods[i, 1] + " 已上菜，因此您不能再进行传菜操作。");
										}
										else
										{
											//传送当前菜品
                                            if (rms_var.TransFood_Rmt_Async(dgSaleFoods[i, 0].ToString(), CurrentTableTypeName, CurrentTableNo, rms_var.GetTablePsnCount(CurrentTableNo), CurrentBillNo, dgSaleFoods[i, 1].ToString(), rms_var.GetFoodTypeName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodDeptName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodUnit(dgSaleFoods[i, 0].ToString()), dgSaleFoods[i, 3].ToString(), dgSaleFoods[i, 6].ToString(), dgSaleFoods[i, 7].ToString(), rms_var.opinfo.OpID, dgSaleFoods[i, 8].ToString(), 0, ""))
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
										if (dgSaleFoods[i, 5].ToString() == "") //已传菜
										{
											//催菜当前菜品
                                            if (rms_var.TransFood_Rmt_Async(dgSaleFoods[i, 0].ToString(), CurrentTableTypeName, CurrentTableNo, rms_var.GetTablePsnCount(CurrentTableNo), CurrentBillNo, dgSaleFoods[i, 1].ToString(), rms_var.GetFoodTypeName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodDeptName(dgSaleFoods[i, 0].ToString()), rms_var.GetFoodUnit(dgSaleFoods[i, 0].ToString()), dgSaleFoods[i, 3].ToString(), dgSaleFoods[i, 6].ToString(), dgSaleFoods[i, 7].ToString(), rms_var.opinfo.OpID, dgSaleFoods[i, 8].ToString(), 1, ""))
												{
												MessageBox.Show("菜品 " + dgSaleFoods[i, 1] + " 催菜成功！");
											}
										}
                                        else if (dgSaleFoods[i, 5].ToString() == "1" ) //已上菜)
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
						MoveTable(rms_var.GetCurrentTableSerialNo(CurrentTableNo), CurrentTableNo);
						GetTables(CurrentTableTypeName);
						ClearBill();
						break;
					case 7: //并台
						CompineTable(rms_var.GetCurrentTableSerialNo(CurrentTableNo), CurrentTableNo);
						break;
					case 8: //转并台
						MoveTable1(rms_var.GetCurrentTableSerialNo(CurrentTableNo), CurrentTableNo);
						GetTables(CurrentTableTypeName);
						ClearBill();
						break;
					case 10: //选择套餐
						//检测桌台状态
						//0=空闲，1=使用，2=预定中，-1=不存在该桌台
						int ts;
						ts = rms_var.GetTableStatus(CurrentTableNo);
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
													AddSuitToBill(frmsf.SuitCode, CurrentTableNo, CurrentBillNo, frmsf.SuitQuantity);
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
										if (rms_var.DeleteBill(CurrentTableNo, CurrentBillNo, frmcr.CancelReason))
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
											rms_var.DeleteSuit(CurrentTableNo, CurrentBillNo, frmcr.CancelReason, dgSaleFoods[dgSaleFoods.CurrentRowIndex, 8].ToString(), false);
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
                                            if (rms_var.DeleteFood(CurrentTableNo, CurrentBillNo, dgSaleFoods[dgSaleFoods.CurrentRowIndex, 0].ToString(), dgSaleFoods[dgSaleFoods.CurrentRowIndex, 3].ToString(), frmcr.CancelReason, dgSaleFoods[dgSaleFoods.CurrentRowIndex, 8].ToString(), false))
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
					case 15: //注销
						if (MessageBox.Show("确定要注销当前登录的用户，并且重新登录系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							rms_var.TheAppExt.LogModule = 3; //报告登录的是->前台管理模块
							System.String rtn = rms_var.TheAppExt.ShowLogForm2("触摸屏客户端");
							if (rtn.Trim() == "-1")
							{
								Application.Exit();
							}
							else
							{
								//ConnStr = TheAppExt.GetConnStr '复制远程连接字符串
								//ReceiveOperatorInfo(rtn)
								//刷新桌台列表视图
								//RefreshTableListView(CurrentTableTypeName)
								//GetFoodList()
								this.Top = 0;
								this.Left = 0;
								this.WindowState = FormWindowState.Maximized;
							}
						}
						break;
					case 16: //关于
						System.Reflection.AssemblyName name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
						string ver;
						
						ver = string.Format("{0}.{1}.{2}.{3}", name.Version.Major, name.Version.Minor, name.Version.Build, name.Version.Revision);
						rms_var.TheAppExt.ShowAboutForm(ver, "30f7");
						break;
					case 17: //退出
						this.Close();
						break;
				}
			}
			
			public void AddFood()
			{
				if (CurrentBillNo != "")
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
			
			private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
			{
				InputMode inputmode = new InputMode();
				switch (rms_var.FoodInputMode)
				{
					case 0: //菜品编码
						inputmode.RadioButton1.Checked = true;
						break;
					case 1: //拼音码
						inputmode.RadioButton2.Checked = true;
						break;
					case 2: //类别编码
						inputmode.RadioButton3.Checked = true;
						break;
					case 3: //菜品类别
						inputmode.RadioButton4.Checked = true;
						break;
				}
				inputmode.ShowDialog();
				switch (rms_var.FoodInputMode)
				{
					case 0:
						LinkLabel1.Text = "菜品编码：";
						Panel9.Hide();
						Button11.Hide();
						Button12.Hide();
						Panel7.Hide();
						Button7.Hide();
						Button8.Hide();
						txtFoodCode.Show();
						txtFoodCode.BringToFront();
						txtFoodCode.Focus();
						txtFoodCode.SelectAll();
						Panel8.Top = txtFoodCode.Top + txtFoodCode.Height + 5;
						Panel8.Height = Panel1.Height - txtFoodCode.Height - 12;
						break;
					case 1:
						LinkLabel1.Text = "拼音码：";
						Panel9.Hide();
						Button11.Hide();
						Button12.Hide();
						Panel7.Hide();
						Button7.Hide();
						Button8.Hide();
						txtFoodCode.Show();
						txtFoodCode.BringToFront();
						txtFoodCode.Focus();
						txtFoodCode.SelectAll();
						Panel8.Top = txtFoodCode.Top + txtFoodCode.Height + 5;
						Panel8.Height = Panel1.Height - txtFoodCode.Height - 12;
						break;
					case 2:
						LinkLabel1.Text = "类别编码：";
						Panel9.Hide();
						Button11.Hide();
						Button12.Hide();
						Panel7.Hide();
						Button7.Hide();
						Button8.Hide();
						txtFoodCode.Show();
						txtFoodCode.BringToFront();
						txtFoodCode.Focus();
						txtFoodCode.SelectAll();
						Panel8.Top = txtFoodCode.Top + txtFoodCode.Height + 5;
						Panel8.Height = Panel1.Height - txtFoodCode.Height - 12;
						break;
					case 3:
						LinkLabel1.Text = "菜品类别：";
						txtFoodCode.Hide();
						Panel9.Show();
						Button11.Show();
						Button12.Show();
						Panel7.Show();
						Button7.Show();
						Button8.Show();
						Panel8.Top = Button7.Top + Button7.Height;
						Panel8.Height = Panel1.Height - Button7.Top - Button9.Height + 24;
						break;
				}
			}
			
			private void txtFoodCode_TextChanged(System.Object sender, System.EventArgs e)
			{
				//GetFoodList(txtFoodCode.Text, FoodInputMode)
				GetFoods(txtFoodCode.Text, rms_var.FoodInputMode);
			}
			
			private void ShowInputPanel(TextBox TargetControl)
			{
				Point controlLocation=Point.Empty;
				Point inputPanelLocation=Point.Empty;
				controlLocation = TargetControl.PointToScreen(controlLocation);
				Rectangle ScreenWorkArea = Screen.FromPoint(controlLocation).WorkingArea;
				//If Not frminptForm.Visible Then
				frminptForm.CurrentUsedControl = TargetControl;
				inputPanelLocation.X = controlLocation.X;
				inputPanelLocation.Y = controlLocation.Y + 30;
				if (controlLocation.X + frminptForm.Width > ScreenWorkArea.Width) //右边界超出屏幕
				{
					inputPanelLocation.X = ScreenWorkArea.Width - frminptForm.Width;
				}
				if (controlLocation.Y + TargetControl.Height + frminptForm.Height + 30 > ScreenWorkArea.Height) //下边界超出屏幕
				{
					inputPanelLocation.Y = controlLocation.Y - 30 - frminptForm.Height;
				}
				if (controlLocation.X < 0) //左边界超出屏幕
				{
					inputPanelLocation.X = 0;
				}
				frminptForm.SetBounds(inputPanelLocation.X, inputPanelLocation.Y, 592, 264);
				frminptForm.Show();
			}
			
			private void txtFoodCode_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void txtFoodCode_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(txtFoodCode);
			}
			
			private void txtFoodCode_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(txtFoodCode);
			}
			
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
			
			private void lvTablelist_DoubleClick(System.Object sender, System.EventArgs e)
			{
				TabControl1.SelectedIndex = 1;
				//ShowTable(lvTablelist.SelectedItems.Item(0).Text)
			}
			
			private void GetTableTypes1()
			{
				TableTypesBtnList1 = new TableTypesButtonList(Panel4, 115, 60, Color.FromArgb(128, 128, 255), Color.FromArgb(255, 128, 128), 2, 1);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT * FROM tabletype";
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						TableTypesBtnList1.AddNewButton(dbDS.Tables[0].Rows[i]["name"].ToString());
					}
					TableTypesBtnList1.AddNewButton("全部");
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
			
			private void GetTableTypes2()
			{
				TableTypesBtnList2 = new TableTypesButtonList(Panel5, 108, 50, Color.FromArgb(128, 128, 255), Color.FromArgb(255, 128, 128), 2, 2);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT * FROM tabletype";
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						TableTypesBtnList2.AddNewButton(dbDS.Tables[0].Rows[i]["name"].ToString());
					}
					TableTypesBtnList2.AddNewButton("全部");
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
			
			public void GetTablesInFirstView(string tabletypename)
			{
				if (TablesBtnList1 != null)
				{
					TablesBtnList1.RemoveAll();
					TablesBtnList1 = null;
				}
				TablesBtnList1 = new TablesButtonList(Panel10, 106, 50, 7, 1);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					if (tabletypename == "全部")
					{
						selectCMD.CommandText = "SELECT tableno,tablename,status FROM tablestatus";
					}
					else
					{
						selectCMD.CommandText = "SELECT tableno,tablename,status FROM view_tablelist where name='" + tabletypename + "'";
					}
					
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						TablesBtnList1.AddNewButton(dbDS.Tables[0].Rows[i]["tableno"].ToString(), dbDS.Tables[0].Rows[i]["tablename"].ToString(), int.Parse(dbDS.Tables[0].Rows[i]["status"].ToString()));
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
			
			public void GetTables(string tabletypename)
			{
				if (TablesBtnList2 != null)
				{
					TablesBtnList2.RemoveAll();
					TablesBtnList2 = null;
				}
				TablesBtnList2 = new TablesButtonList(Panel6, 72, 40, 3, 2);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					if (tabletypename == "全部")
					{
						selectCMD.CommandText = "SELECT tableno,tablename,status FROM tablestatus";
					}
					else
					{
						selectCMD.CommandText = "SELECT tableno,tablename,status FROM view_tablelist where name='" + tabletypename + "'";
					}
					
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						TablesBtnList2.AddNewButton(dbDS.Tables[0].Rows[i]["tableno"].ToString(), dbDS.Tables[0].Rows[i]["tablename"].ToString(), System.Convert.ToInt32(dbDS.Tables[0].Rows[i]["status"].ToString()));
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
			
			private void GetDepartment()
			{
				DeptsBtnList = new DeptButtonList(Panel9, 120, 50, Color.FromArgb(128, 128, 255), Color.FromArgb(255, 128, 128), 2);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT deptname FROM department where depttype='菜品制作' order by deptname";
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						DeptsBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["deptname"].ToString());
					}
					DeptsBtnList.AddNewButton("全部");
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
			
			public void GetFoodTypes(string deptname)
			{
				if (FoodTypesBtnList != null)
				{
					FoodTypesBtnList.RemoveAll();
					FoodTypesBtnList = null;
				}
				FoodTypesBtnList = new FoodTypesButtonList(Panel7, 80, 40, Color.FromArgb(128, 128, 255), Color.FromArgb(255, 128, 128), 3);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					if (deptname == "全部")
					{
						selectCMD.CommandText = "SELECT typename FROM view_foodtype";
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
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						FoodTypesBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["typename"].ToString());
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
			
			public void GetFoods(string QueryField, int inputmode)
			{
				if (FoodsBtnList != null)
				{
					FoodsBtnList.RemoveAll();
					FoodsBtnList = null;
				}
				FoodsBtnList = new FoodsButtonList(Panel8, 120, 55, Color.FromArgb(128, 128, 255), Color.FromArgb(255, 128, 128), 2);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					switch (inputmode)
					{
						case 0: //菜品编码
							selectCMD.CommandText = "SELECT foodcode,foodname,price,unit FROM view_foodlist where foodcode like '" + QueryField + "%'";
							break;
						case 1: //拼音码
							selectCMD.CommandText = "SELECT foodcode,foodname,price,unit FROM view_foodlist where spell like '" + QueryField + "%'";
							break;
						case 2: //类别编码
							selectCMD.CommandText = "SELECT foodcode,foodname,price,unit FROM view_foodlist where foodtypeCode like '" + QueryField + "%'";
							break;
						case 3: //菜品类别
							if (QueryField == "全部")
							{
								selectCMD.CommandText = "SELECT foodcode,foodname,price,unit FROM foodlist order by foodcode";
							}
							else
							{
								selectCMD.CommandText = "SELECT foodcode,foodname,price,unit FROM view_foodlist where typename='" + QueryField + "'  order by foodcode";
							}
							break;
					}
					
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						FoodsBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["foodcode"].ToString(), dbDS.Tables[0].Rows[i]["foodname"].ToString(), (System.Convert.ToDouble(dbDS.Tables[0].Rows[i]["price"]).ToString("{#,##0:N2}")), dbDS.Tables[0].Rows[i]["unit"].ToString());
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
			
			private void Button1_Click(System.Object sender, System.EventArgs e)
			{
				if (TableTypesBtnList1[0].Top != 0)
				{
					for (int i = 0; i <= TableTypesBtnList1.Count - 1; i++)
					{
						TableTypesBtnList1[i].Top += TableTypeNamePageInterval1;
						TableTypesBtnList1.CurrentBtnTop += TableTypeNamePageInterval1;
					}
					TableTypesBtnList1.CurrentBtnTop = System.Convert.ToInt32(TableTypesBtnList1[TableTypesBtnList1.Count - 1].Top);
				}
			}
			
			private void Button3_Click(System.Object sender, System.EventArgs e)
			{
				if (TableTypesBtnList2[0].Top != 0)
				{
					for (int i = 0; i <= TableTypesBtnList2.Count - 1; i++)
					{
						TableTypesBtnList2[i].Top += TableTypeNamePageInterval2;
						TableTypesBtnList2.CurrentBtnTop += TableTypeNamePageInterval2;
					}
					TableTypesBtnList2.CurrentBtnTop = System.Convert.ToInt32(TableTypesBtnList2[TableTypesBtnList2.Count - 1].Top);
				}
			}
			
			private void Button4_Click(System.Object sender, System.EventArgs e)
			{
				if ((TableTypesBtnList2[TableTypesBtnList2.Count - 1].Top + TableTypesBtnList2[TableTypesBtnList2.Count - 1].Height) > Panel5.Height)
				{
					for (int i = 0; i <= TableTypesBtnList2.Count - 1; i++)
					{
						TableTypesBtnList2[i].Top -= TableTypeNamePageInterval2;
						TableTypesBtnList2.CurrentBtnTop -= TableTypeNamePageInterval2;
					}
					TableTypesBtnList2.CurrentBtnTop = System.Convert.ToInt32(TableTypesBtnList2[TableTypesBtnList2.Count - 1].Top);
				}
			}
			
			private void Button2_Click(System.Object sender, System.EventArgs e)
			{
				if ((TableTypesBtnList1[TableTypesBtnList1.Count - 1].Top + TableTypesBtnList1[TableTypesBtnList1.Count - 1].Height) > Panel4.Height)
				{
					for (int i = 0; i <= TableTypesBtnList1.Count - 1; i++)
					{
						TableTypesBtnList1[i].Top -= TableTypeNamePageInterval1;
						TableTypesBtnList1.CurrentBtnTop -= TableTypeNamePageInterval1;
					}
					TableTypesBtnList1.CurrentBtnTop = System.Convert.ToInt32(TableTypesBtnList1[TableTypesBtnList1.Count - 1].Top);
				}
			}
			
			private void Button5_Click(System.Object sender, System.EventArgs e)
			{
				if (TablesBtnList2[0].Top != 0)
				{
					for (int i = 0; i <= TablesBtnList2.Count - 1; i++)
					{
						TablesBtnList2[i].Top += TablePageInterval2;
						TablesBtnList2.CurrentBtnTop += TablePageInterval2;
					}
					TablesBtnList2.CurrentBtnTop = System.Convert.ToInt32(TablesBtnList2[TablesBtnList2.Count - 1].Top);
				}
			}
			
			private void Button6_Click(System.Object sender, System.EventArgs e)
			{
				if ((TablesBtnList2[TablesBtnList2.Count - 1].Top + TablesBtnList2[TablesBtnList2.Count - 1].Height) > Panel6.Height)
				{
					for (int i = 0; i <= TablesBtnList2.Count - 1; i++)
					{
						TablesBtnList2[i].Top -= TablePageInterval2;
						TablesBtnList2.CurrentBtnTop -= TablePageInterval2;
					}
					TablesBtnList2.CurrentBtnTop = System.Convert.ToInt32(TablesBtnList2[TablesBtnList2.Count - 1].Top);
				}
			}
			
			private void Button7_Click(System.Object sender, System.EventArgs e)
			{
				if (FoodTypesBtnList[0].Top != 0)
				{
					for (int i = 0; i <= FoodTypesBtnList.Count - 1; i++)
					{
						FoodTypesBtnList[i].Top += FoodTypesPageInterval;
						FoodTypesBtnList.CurrentBtnTop += FoodTypesPageInterval;
					}
					FoodTypesBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodTypesBtnList[FoodTypesBtnList.Count - 1].Top);
				}
			}
			
			private void Button8_Click(System.Object sender, System.EventArgs e)
			{
				if ((FoodTypesBtnList[FoodTypesBtnList.Count - 1].Top + FoodTypesBtnList[FoodTypesBtnList.Count - 1].Height) > Panel7.Height)
				{
					for (int i = 0; i <= FoodTypesBtnList.Count - 1; i++)
					{
						FoodTypesBtnList[i].Top -= FoodTypesPageInterval;
						FoodTypesBtnList.CurrentBtnTop -= FoodTypesPageInterval;
					}
					FoodTypesBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodTypesBtnList[FoodTypesBtnList.Count - 1].Top);
				}
			}
			
			private void Button9_Click(System.Object sender, System.EventArgs e)
			{
				if (FoodsBtnList[0].Top != 0)
				{
					for (int i = 0; i <= FoodsBtnList.Count - 1; i++)
					{
						FoodsBtnList[i].Top += FoodsPageInterval;
						FoodsBtnList.CurrentBtnTop += FoodsPageInterval;
					}
					FoodsBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodsBtnList[FoodsBtnList.Count - 1].Top);
				}
			}
			
			private void Button10_Click(System.Object sender, System.EventArgs e)
			{
				if ((FoodsBtnList[FoodsBtnList.Count - 1].Top + FoodsBtnList[FoodsBtnList.Count - 1].Height) > Panel8.Height)
				{
					for (int i = 0; i <= FoodsBtnList.Count - 1; i++)
					{
						FoodsBtnList[i].Top -= FoodsPageInterval;
						FoodsBtnList.CurrentBtnTop -= FoodsPageInterval;
					}
					FoodsBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodsBtnList[FoodsBtnList.Count - 1].Top);
				}
			}
			
			private void Button11_Click(System.Object sender, System.EventArgs e)
			{
				if (DeptsBtnList[0].Top != 0)
				{
					for (int i = 0; i <= DeptsBtnList.Count - 1; i++)
					{
						DeptsBtnList[i].Top += DeptsPageInterval;
						DeptsBtnList.CurrentBtnTop += DeptsPageInterval;
					}
					DeptsBtnList.CurrentBtnTop = System.Convert.ToInt32(DeptsBtnList[DeptsBtnList.Count - 1].Top);
				}
			}
			
			private void Button12_Click(System.Object sender, System.EventArgs e)
			{
				if ((DeptsBtnList[DeptsBtnList.Count - 1].Top + DeptsBtnList[DeptsBtnList.Count - 1].Height) > Panel9.Height)
				{
					for (int i = 0; i <= DeptsBtnList.Count - 1; i++)
					{
						DeptsBtnList[i].Top -= DeptsPageInterval;
						DeptsBtnList.CurrentBtnTop -= DeptsPageInterval;
					}
					DeptsBtnList.CurrentBtnTop = System.Convert.ToInt32(DeptsBtnList[DeptsBtnList.Count - 1].Top);
				}
			}
			
			private void Button14_Click(System.Object sender, System.EventArgs e)
			{
				if (TablesBtnList1[0].Top != 0)
				{
					for (int i = 0; i <= TablesBtnList1.Count - 1; i++)
					{
						TablesBtnList1[i].Top += TablePageInterval1;
						TablesBtnList1.CurrentBtnTop += TablePageInterval1;
					}
					TablesBtnList1.CurrentBtnTop = System.Convert.ToInt32(TablesBtnList1[TablesBtnList1.Count - 1].Top);
				}
			}
			
			private void Button13_Click(System.Object sender, System.EventArgs e)
			{
				if ((TablesBtnList1[TablesBtnList1.Count - 1].Top + TablesBtnList1[TablesBtnList1.Count - 1].Height) > Panel10.Height)
				{
					for (int i = 0; i <= TablesBtnList1.Count - 1; i++)
					{
						TablesBtnList1[i].Top -= TablePageInterval1;
						TablesBtnList1.CurrentBtnTop -= TablePageInterval1;
					}
					TablesBtnList1.CurrentBtnTop = System.Convert.ToInt32(TablesBtnList1[TablesBtnList1.Count - 1].Top);
				}
			}
			
			private void numOpenPsn_TextChanged(System.Object sender, System.EventArgs e)
			{
				
			}
			
			private void numOpenPsn_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(numOpenPsn);
			}
			
			private void numOpenPsn_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(numOpenPsn);
			}
			
			private void numOpenPsn_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void Button15_Click(System.Object sender, System.EventArgs e)
			{
				int count;
				try
				{
					count = int.Parse(numOpenPsn.Text);
					rms_var.UpdateTablePsnCount(CurrentTableNo, count);
				}
				catch (Exception)
				{
					MessageBox.Show("人数输入有错误！请核对后重新输入。");
					numOpenPsn.Focus();
					numOpenPsn.SelectAll();
				}
			}
			
			private void Timer1_Elapsed(System.Object sender, System.Timers.ElapsedEventArgs e)
			{
				//Timer1.Enabled = False
				
				//Dim MyValue As Integer
				//Randomize()
				//MyValue = CInt(Int((9 * Rnd()) + 1)) Mod 2
				
				//If MyValue = 1 Then
				//Me.Enabled = False
				//MsgBox("当前系统为试用版本，请向软件供应商索取正式版本。")
				//Me.Close()
				//End If
				
				//Timer1.Enabled = True
			}
		}
		
	}
	
}
