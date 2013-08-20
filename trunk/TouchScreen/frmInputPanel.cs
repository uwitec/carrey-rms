using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace TouchScreen
{
	public class frmInputPanel : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmInputPanel()
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.pnlInput = new System.Windows.Forms.Panel();
			base.Load += new System.EventHandler(frmInputPanel_Load);
			this.pnlInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlInput_MouseDown);
			this.pnlInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlInput_MouseMove);
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
			this.pnlInput.SuspendLayout();
			this.SuspendLayout();
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
			this.pnlInput.Location = new System.Drawing.Point(8, 8);
			this.pnlInput.Name = "pnlInput";
			this.pnlInput.Size = new System.Drawing.Size(576, 248);
			this.pnlInput.TabIndex = 3;
			this.pnlInput.TabStop = true;
			//
			//bHide
			//
			this.bHide.BackColor = System.Drawing.SystemColors.Control;
			this.bHide.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bHide.Location = new System.Drawing.Point(448, 200);
			this.bHide.Name = "bHide";
			this.bHide.Size = new System.Drawing.Size(88, 40);
			this.bHide.TabIndex = 40;
			this.bHide.Text = "隐藏";
			//
			//bDot
			//
			this.bDot.BackColor = System.Drawing.SystemColors.Control;
			this.bDot.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bDot.Location = new System.Drawing.Point(448, 152);
			this.bDot.Name = "bDot";
			this.bDot.Size = new System.Drawing.Size(56, 48);
			this.bDot.TabIndex = 39;
			this.bDot.Tag = ".";
			this.bDot.Text = ".";
			//
			//bCaps
			//
			this.bCaps.BackColor = System.Drawing.SystemColors.Control;
			this.bCaps.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bCaps.Location = new System.Drawing.Point(32, 200);
			this.bCaps.Name = "bCaps";
			this.bCaps.Size = new System.Drawing.Size(88, 40);
			this.bCaps.TabIndex = 38;
			this.bCaps.Text = "Caps/小写";
			//
			//bSpc
			//
			this.bSpc.BackColor = System.Drawing.SystemColors.Control;
			this.bSpc.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bSpc.Location = new System.Drawing.Point(120, 200);
			this.bSpc.Name = "bSpc";
			this.bSpc.Size = new System.Drawing.Size(328, 40);
			this.bSpc.TabIndex = 37;
			this.bSpc.Tag = "";
			this.bSpc.Text = "SPACE/空格";
			//
			//bM
			//
			this.bM.BackColor = System.Drawing.SystemColors.Control;
			this.bM.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bM.Location = new System.Drawing.Point(392, 152);
			this.bM.Name = "bM";
			this.bM.Size = new System.Drawing.Size(56, 48);
			this.bM.TabIndex = 36;
			this.bM.Tag = "M";
			this.bM.Text = "M";
			//
			//bN
			//
			this.bN.BackColor = System.Drawing.SystemColors.Control;
			this.bN.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bN.Location = new System.Drawing.Point(336, 152);
			this.bN.Name = "bN";
			this.bN.Size = new System.Drawing.Size(56, 48);
			this.bN.TabIndex = 35;
			this.bN.Tag = "N";
			this.bN.Text = "N";
			//
			//bB
			//
			this.bB.BackColor = System.Drawing.SystemColors.Control;
			this.bB.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bB.Location = new System.Drawing.Point(280, 152);
			this.bB.Name = "bB";
			this.bB.Size = new System.Drawing.Size(56, 48);
			this.bB.TabIndex = 34;
			this.bB.Tag = "B";
			this.bB.Text = "B";
			//
			//bV
			//
			this.bV.BackColor = System.Drawing.SystemColors.Control;
			this.bV.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bV.Location = new System.Drawing.Point(224, 152);
			this.bV.Name = "bV";
			this.bV.Size = new System.Drawing.Size(56, 48);
			this.bV.TabIndex = 33;
			this.bV.Tag = "V";
			this.bV.Text = "V";
			//
			//bC
			//
			this.bC.BackColor = System.Drawing.SystemColors.Control;
			this.bC.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bC.Location = new System.Drawing.Point(168, 152);
			this.bC.Name = "bC";
			this.bC.Size = new System.Drawing.Size(56, 48);
			this.bC.TabIndex = 32;
			this.bC.Tag = "C";
			this.bC.Text = "C";
			//
			//bX
			//
			this.bX.BackColor = System.Drawing.SystemColors.Control;
			this.bX.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bX.Location = new System.Drawing.Point(112, 152);
			this.bX.Name = "bX";
			this.bX.Size = new System.Drawing.Size(56, 48);
			this.bX.TabIndex = 31;
			this.bX.Tag = "X";
			this.bX.Text = "X";
			//
			//bZ
			//
			this.bZ.BackColor = System.Drawing.SystemColors.Control;
			this.bZ.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bZ.Location = new System.Drawing.Point(56, 152);
			this.bZ.Name = "bZ";
			this.bZ.Size = new System.Drawing.Size(56, 48);
			this.bZ.TabIndex = 30;
			this.bZ.Tag = "Z";
			this.bZ.Text = "Z";
			//
			//bL
			//
			this.bL.BackColor = System.Drawing.SystemColors.Control;
			this.bL.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bL.Location = new System.Drawing.Point(480, 104);
			this.bL.Name = "bL";
			this.bL.Size = new System.Drawing.Size(56, 48);
			this.bL.TabIndex = 29;
			this.bL.Tag = "L";
			this.bL.Text = "L";
			//
			//bK
			//
			this.bK.BackColor = System.Drawing.SystemColors.Control;
			this.bK.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bK.Location = new System.Drawing.Point(424, 104);
			this.bK.Name = "bK";
			this.bK.Size = new System.Drawing.Size(56, 48);
			this.bK.TabIndex = 28;
			this.bK.Tag = "K";
			this.bK.Text = "K";
			//
			//bJ
			//
			this.bJ.BackColor = System.Drawing.SystemColors.Control;
			this.bJ.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bJ.Location = new System.Drawing.Point(368, 104);
			this.bJ.Name = "bJ";
			this.bJ.Size = new System.Drawing.Size(56, 48);
			this.bJ.TabIndex = 27;
			this.bJ.Tag = "J";
			this.bJ.Text = "J";
			//
			//bH
			//
			this.bH.BackColor = System.Drawing.SystemColors.Control;
			this.bH.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bH.Location = new System.Drawing.Point(312, 104);
			this.bH.Name = "bH";
			this.bH.Size = new System.Drawing.Size(56, 48);
			this.bH.TabIndex = 26;
			this.bH.Tag = "H";
			this.bH.Text = "H";
			//
			//bG
			//
			this.bG.BackColor = System.Drawing.SystemColors.Control;
			this.bG.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bG.Location = new System.Drawing.Point(256, 104);
			this.bG.Name = "bG";
			this.bG.Size = new System.Drawing.Size(56, 48);
			this.bG.TabIndex = 25;
			this.bG.Tag = "G";
			this.bG.Text = "G";
			//
			//bF
			//
			this.bF.BackColor = System.Drawing.SystemColors.Control;
			this.bF.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bF.Location = new System.Drawing.Point(200, 104);
			this.bF.Name = "bF";
			this.bF.Size = new System.Drawing.Size(56, 48);
			this.bF.TabIndex = 24;
			this.bF.Tag = "F";
			this.bF.Text = "F";
			//
			//bD
			//
			this.bD.BackColor = System.Drawing.SystemColors.Control;
			this.bD.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bD.Location = new System.Drawing.Point(144, 104);
			this.bD.Name = "bD";
			this.bD.Size = new System.Drawing.Size(56, 48);
			this.bD.TabIndex = 23;
			this.bD.Tag = "D";
			this.bD.Text = "D";
			//
			//bS
			//
			this.bS.BackColor = System.Drawing.SystemColors.Control;
			this.bS.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bS.Location = new System.Drawing.Point(88, 104);
			this.bS.Name = "bS";
			this.bS.Size = new System.Drawing.Size(56, 48);
			this.bS.TabIndex = 22;
			this.bS.Tag = "S";
			this.bS.Text = "S";
			//
			//bA
			//
			this.bA.BackColor = System.Drawing.SystemColors.Control;
			this.bA.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bA.Location = new System.Drawing.Point(32, 104);
			this.bA.Name = "bA";
			this.bA.Size = new System.Drawing.Size(56, 48);
			this.bA.TabIndex = 21;
			this.bA.Tag = "A";
			this.bA.Text = "A";
			//
			//bBack
			//
			this.bBack.BackColor = System.Drawing.SystemColors.Control;
			this.bBack.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bBack.Location = new System.Drawing.Point(488, 8);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(80, 40);
			this.bBack.TabIndex = 20;
			this.bBack.Text = "BACK Space";
			//
			//bP
			//
			this.bP.BackColor = System.Drawing.SystemColors.Control;
			this.bP.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bP.Location = new System.Drawing.Point(512, 56);
			this.bP.Name = "bP";
			this.bP.Size = new System.Drawing.Size(56, 48);
			this.bP.TabIndex = 19;
			this.bP.Tag = "P";
			this.bP.Text = "P";
			//
			//bO
			//
			this.bO.BackColor = System.Drawing.SystemColors.Control;
			this.bO.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bO.Location = new System.Drawing.Point(456, 56);
			this.bO.Name = "bO";
			this.bO.Size = new System.Drawing.Size(56, 48);
			this.bO.TabIndex = 18;
			this.bO.Tag = "O";
			this.bO.Text = "O";
			//
			//bI
			//
			this.bI.BackColor = System.Drawing.SystemColors.Control;
			this.bI.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bI.Location = new System.Drawing.Point(400, 56);
			this.bI.Name = "bI";
			this.bI.Size = new System.Drawing.Size(56, 48);
			this.bI.TabIndex = 17;
			this.bI.Tag = "I";
			this.bI.Text = "I";
			//
			//bU
			//
			this.bU.BackColor = System.Drawing.SystemColors.Control;
			this.bU.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bU.Location = new System.Drawing.Point(344, 56);
			this.bU.Name = "bU";
			this.bU.Size = new System.Drawing.Size(56, 48);
			this.bU.TabIndex = 16;
			this.bU.Tag = "U";
			this.bU.Text = "U";
			//
			//bY
			//
			this.bY.BackColor = System.Drawing.SystemColors.Control;
			this.bY.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bY.Location = new System.Drawing.Point(288, 56);
			this.bY.Name = "bY";
			this.bY.Size = new System.Drawing.Size(56, 48);
			this.bY.TabIndex = 15;
			this.bY.Tag = "Y";
			this.bY.Text = "Y";
			//
			//bT
			//
			this.bT.BackColor = System.Drawing.SystemColors.Control;
			this.bT.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bT.Location = new System.Drawing.Point(232, 56);
			this.bT.Name = "bT";
			this.bT.Size = new System.Drawing.Size(56, 48);
			this.bT.TabIndex = 14;
			this.bT.Tag = "T";
			this.bT.Text = "T";
			//
			//bR
			//
			this.bR.BackColor = System.Drawing.SystemColors.Control;
			this.bR.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bR.Location = new System.Drawing.Point(176, 56);
			this.bR.Name = "bR";
			this.bR.Size = new System.Drawing.Size(56, 48);
			this.bR.TabIndex = 13;
			this.bR.Tag = "R";
			this.bR.Text = "R";
			//
			//bE
			//
			this.bE.BackColor = System.Drawing.SystemColors.Control;
			this.bE.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bE.Location = new System.Drawing.Point(120, 56);
			this.bE.Name = "bE";
			this.bE.Size = new System.Drawing.Size(56, 48);
			this.bE.TabIndex = 12;
			this.bE.Tag = "E";
			this.bE.Text = "E";
			//
			//bW
			//
			this.bW.BackColor = System.Drawing.SystemColors.Control;
			this.bW.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bW.Location = new System.Drawing.Point(64, 56);
			this.bW.Name = "bW";
			this.bW.Size = new System.Drawing.Size(56, 48);
			this.bW.TabIndex = 11;
			this.bW.Tag = "W";
			this.bW.Text = "W";
			//
			//bQ
			//
			this.bQ.BackColor = System.Drawing.SystemColors.Control;
			this.bQ.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.bQ.Location = new System.Drawing.Point(8, 56);
			this.bQ.Name = "bQ";
			this.bQ.Size = new System.Drawing.Size(56, 48);
			this.bQ.TabIndex = 10;
			this.bQ.Tag = "Q";
			this.bQ.Text = "Q";
			//
			//b0
			//
			this.b0.BackColor = System.Drawing.SystemColors.Control;
			this.b0.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b0.Location = new System.Drawing.Point(440, 8);
			this.b0.Name = "b0";
			this.b0.Size = new System.Drawing.Size(48, 40);
			this.b0.TabIndex = 9;
			this.b0.Tag = "0";
			this.b0.Text = "0";
			//
			//b9
			//
			this.b9.BackColor = System.Drawing.SystemColors.Control;
			this.b9.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b9.Location = new System.Drawing.Point(392, 8);
			this.b9.Name = "b9";
			this.b9.Size = new System.Drawing.Size(48, 40);
			this.b9.TabIndex = 8;
			this.b9.Tag = "9";
			this.b9.Text = "9";
			//
			//b8
			//
			this.b8.BackColor = System.Drawing.SystemColors.Control;
			this.b8.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b8.Location = new System.Drawing.Point(344, 8);
			this.b8.Name = "b8";
			this.b8.Size = new System.Drawing.Size(48, 40);
			this.b8.TabIndex = 7;
			this.b8.Tag = "8";
			this.b8.Text = "8";
			//
			//b7
			//
			this.b7.BackColor = System.Drawing.SystemColors.Control;
			this.b7.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b7.Location = new System.Drawing.Point(296, 8);
			this.b7.Name = "b7";
			this.b7.Size = new System.Drawing.Size(48, 40);
			this.b7.TabIndex = 6;
			this.b7.Tag = "7";
			this.b7.Text = "7";
			//
			//b6
			//
			this.b6.BackColor = System.Drawing.SystemColors.Control;
			this.b6.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b6.Location = new System.Drawing.Point(248, 8);
			this.b6.Name = "b6";
			this.b6.Size = new System.Drawing.Size(48, 40);
			this.b6.TabIndex = 5;
			this.b6.Tag = "6";
			this.b6.Text = "6";
			//
			//b5
			//
			this.b5.BackColor = System.Drawing.SystemColors.Control;
			this.b5.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b5.Location = new System.Drawing.Point(200, 8);
			this.b5.Name = "b5";
			this.b5.Size = new System.Drawing.Size(48, 40);
			this.b5.TabIndex = 4;
			this.b5.Tag = "5";
			this.b5.Text = "5";
			//
			//b4
			//
			this.b4.BackColor = System.Drawing.SystemColors.Control;
			this.b4.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b4.Location = new System.Drawing.Point(152, 8);
			this.b4.Name = "b4";
			this.b4.Size = new System.Drawing.Size(48, 40);
			this.b4.TabIndex = 3;
			this.b4.Tag = "4";
			this.b4.Text = "4";
			//
			//b3
			//
			this.b3.BackColor = System.Drawing.SystemColors.Control;
			this.b3.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b3.Location = new System.Drawing.Point(104, 8);
			this.b3.Name = "b3";
			this.b3.Size = new System.Drawing.Size(48, 40);
			this.b3.TabIndex = 2;
			this.b3.Tag = "3";
			this.b3.Text = "3";
			//
			//b2
			//
			this.b2.BackColor = System.Drawing.SystemColors.Control;
			this.b2.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.b2.Location = new System.Drawing.Point(56, 8);
			this.b2.Name = "b2";
			this.b2.Size = new System.Drawing.Size(48, 40);
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
			this.b1.Size = new System.Drawing.Size(48, 40);
			this.b1.TabIndex = 0;
			this.b1.Tag = "1";
			this.b1.Text = "1";
			//
			//frmInputPanel
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(592, 264);
			this.Controls.Add(this.pnlInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInputPanel";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "软件盘输入";
			this.TopMost = true;
			this.pnlInput.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public TextBox CurrentUsedControl;
		private int CapsStatus = 1; //0 = 小写 1= 大写
		
		private bool dragging;
		private int mousex;
		private int mousey;
		
		private Point mouse_offset;
		
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
			this.Hide();
		}
		
		private void InputButton_Click(System.Object sender, System.EventArgs e)
		{
			if (CurrentUsedControl.SelectedText == "")
			{
				CurrentUsedControl.Text += ((Button)sender).Tag;
			}
			else
			{
				CurrentUsedControl.SelectedText = ((Button)sender).Tag.ToString();
			}
			//CurrentUsedControl.Text += sender.tag
			CurrentUsedControl.Focus();
			CurrentUsedControl.Select(CurrentUsedControl.Text.Length, 0);
		}
		
		private void bBack_Click(System.Object sender, System.EventArgs e)
		{
			if (CurrentUsedControl.Text.Length > 0)
			{
				string txt = (string) CurrentUsedControl.Text;
				int startIndex = txt.Length - 1;
				
				txt = txt.Remove(startIndex, 1);
				CurrentUsedControl.Text = txt;
				CurrentUsedControl.Focus();
				CurrentUsedControl.Select(CurrentUsedControl.Text.Length, 0);
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
		
		private void frmInputPanel_Load(System.Object sender, System.EventArgs e)
		{
			bSpc.Tag = " ";
		}
		
		private void pnlInput_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			mouse_offset = new Point(e.X, e.Y);
		}
		
		private void pnlInput_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//按住鼠标左右键均可拖动窗体
			if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
			{
				Point mousePos = MousePosition;
				//获得鼠标偏移量
				mousePos.Offset(System.Convert.ToInt32(- mouse_offset.X), System.Convert.ToInt32(- mouse_offset.Y));
				//设置窗体随鼠标一起移动
				this.Location = mousePos;
			}
		}
	}
	
}
