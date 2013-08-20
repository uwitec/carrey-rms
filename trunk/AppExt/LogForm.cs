using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//using Nox.Net.Apis;
using System.Drawing;


namespace AppExt
{
	public class LogForm : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public LogForm()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label3;
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
		internal System.Windows.Forms.Button Button3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.bHide = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bCaps = new System.Windows.Forms.Button();
            this.bSpc = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.bN = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bV = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bX = new System.Windows.Forms.Button();
            this.bZ = new System.Windows.Forms.Button();
            this.bL = new System.Windows.Forms.Button();
            this.bK = new System.Windows.Forms.Button();
            this.bJ = new System.Windows.Forms.Button();
            this.bH = new System.Windows.Forms.Button();
            this.bG = new System.Windows.Forms.Button();
            this.bF = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bS = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bP = new System.Windows.Forms.Button();
            this.bO = new System.Windows.Forms.Button();
            this.bI = new System.Windows.Forms.Button();
            this.bU = new System.Windows.Forms.Button();
            this.bY = new System.Windows.Forms.Button();
            this.bT = new System.Windows.Forms.Button();
            this.bR = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bW = new System.Windows.Forms.Button();
            this.bQ = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(232, 72);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(128, 21);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(152, 72);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "操作员帐号：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(224, 136);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "登录(&L)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(304, 136);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "退出(&Q)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(160, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 23);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "密码：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(232, 96);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '*';
            this.TextBox2.Size = new System.Drawing.Size(128, 21);
            this.TextBox2.TabIndex = 1;
            this.TextBox2.Enter += new System.EventHandler(this.TextBox2_Enter);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(136, 216);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 7;
            this.PictureBox2.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(136, 184);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(264, 32);
            this.Label4.TabIndex = 7;
            this.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(152, 8);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Navy;
            this.Label3.Location = new System.Drawing.Point(192, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(208, 32);
            this.Label3.TabIndex = 8;
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
            this.pnlInput.Location = new System.Drawing.Point(408, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(496, 216);
            this.pnlInput.TabIndex = 9;
            this.pnlInput.TabStop = true;
            this.pnlInput.Visible = false;
            // 
            // bHide
            // 
            this.bHide.BackColor = System.Drawing.SystemColors.Control;
            this.bHide.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bHide.Location = new System.Drawing.Point(400, 168);
            this.bHide.Name = "bHide";
            this.bHide.Size = new System.Drawing.Size(88, 40);
            this.bHide.TabIndex = 40;
            this.bHide.Text = "隐藏";
            this.bHide.UseVisualStyleBackColor = false;
            this.bHide.Click += new System.EventHandler(this.bHide_Click);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.SystemColors.Control;
            this.bDot.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bDot.Location = new System.Drawing.Point(392, 128);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(48, 40);
            this.bDot.TabIndex = 39;
            this.bDot.Tag = ".";
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.Key_Click);
            // 
            // bCaps
            // 
            this.bCaps.BackColor = System.Drawing.SystemColors.Control;
            this.bCaps.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bCaps.Location = new System.Drawing.Point(8, 168);
            this.bCaps.Name = "bCaps";
            this.bCaps.Size = new System.Drawing.Size(88, 40);
            this.bCaps.TabIndex = 38;
            this.bCaps.Text = "Caps/小写";
            this.bCaps.UseVisualStyleBackColor = false;
            this.bCaps.Click += new System.EventHandler(this.bCaps_Click);
            // 
            // bSpc
            // 
            this.bSpc.BackColor = System.Drawing.SystemColors.Control;
            this.bSpc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bSpc.Location = new System.Drawing.Point(104, 168);
            this.bSpc.Name = "bSpc";
            this.bSpc.Size = new System.Drawing.Size(288, 40);
            this.bSpc.TabIndex = 37;
            this.bSpc.Tag = "";
            this.bSpc.Text = "SPACE/空格";
            this.bSpc.UseVisualStyleBackColor = false;
            this.bSpc.Click += new System.EventHandler(this.Key_Click);
            // 
            // bM
            // 
            this.bM.BackColor = System.Drawing.SystemColors.Control;
            this.bM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bM.Location = new System.Drawing.Point(344, 128);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(48, 40);
            this.bM.TabIndex = 36;
            this.bM.Tag = "M";
            this.bM.Text = "M";
            this.bM.UseVisualStyleBackColor = false;
            this.bM.Click += new System.EventHandler(this.Key_Click);
            // 
            // bN
            // 
            this.bN.BackColor = System.Drawing.SystemColors.Control;
            this.bN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bN.Location = new System.Drawing.Point(296, 128);
            this.bN.Name = "bN";
            this.bN.Size = new System.Drawing.Size(48, 40);
            this.bN.TabIndex = 35;
            this.bN.Tag = "N";
            this.bN.Text = "N";
            this.bN.UseVisualStyleBackColor = false;
            this.bN.Click += new System.EventHandler(this.Key_Click);
            // 
            // bB
            // 
            this.bB.BackColor = System.Drawing.SystemColors.Control;
            this.bB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bB.Location = new System.Drawing.Point(248, 128);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(48, 40);
            this.bB.TabIndex = 34;
            this.bB.Tag = "B";
            this.bB.Text = "B";
            this.bB.UseVisualStyleBackColor = false;
            this.bB.Click += new System.EventHandler(this.Key_Click);
            // 
            // bV
            // 
            this.bV.BackColor = System.Drawing.SystemColors.Control;
            this.bV.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bV.Location = new System.Drawing.Point(200, 128);
            this.bV.Name = "bV";
            this.bV.Size = new System.Drawing.Size(48, 40);
            this.bV.TabIndex = 33;
            this.bV.Tag = "V";
            this.bV.Text = "V";
            this.bV.UseVisualStyleBackColor = false;
            this.bV.Click += new System.EventHandler(this.Key_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.Control;
            this.bC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bC.Location = new System.Drawing.Point(152, 128);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(48, 40);
            this.bC.TabIndex = 32;
            this.bC.Tag = "C";
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.Key_Click);
            // 
            // bX
            // 
            this.bX.BackColor = System.Drawing.SystemColors.Control;
            this.bX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bX.Location = new System.Drawing.Point(104, 128);
            this.bX.Name = "bX";
            this.bX.Size = new System.Drawing.Size(48, 40);
            this.bX.TabIndex = 31;
            this.bX.Tag = "X";
            this.bX.Text = "X";
            this.bX.UseVisualStyleBackColor = false;
            this.bX.Click += new System.EventHandler(this.Key_Click);
            // 
            // bZ
            // 
            this.bZ.BackColor = System.Drawing.SystemColors.Control;
            this.bZ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bZ.Location = new System.Drawing.Point(56, 128);
            this.bZ.Name = "bZ";
            this.bZ.Size = new System.Drawing.Size(48, 40);
            this.bZ.TabIndex = 30;
            this.bZ.Tag = "Z";
            this.bZ.Text = "Z";
            this.bZ.UseVisualStyleBackColor = false;
            this.bZ.Click += new System.EventHandler(this.Key_Click);
            // 
            // bL
            // 
            this.bL.BackColor = System.Drawing.SystemColors.Control;
            this.bL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bL.Location = new System.Drawing.Point(416, 88);
            this.bL.Name = "bL";
            this.bL.Size = new System.Drawing.Size(48, 40);
            this.bL.TabIndex = 29;
            this.bL.Tag = "L";
            this.bL.Text = "L";
            this.bL.UseVisualStyleBackColor = false;
            this.bL.Click += new System.EventHandler(this.Key_Click);
            // 
            // bK
            // 
            this.bK.BackColor = System.Drawing.SystemColors.Control;
            this.bK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bK.Location = new System.Drawing.Point(368, 88);
            this.bK.Name = "bK";
            this.bK.Size = new System.Drawing.Size(48, 40);
            this.bK.TabIndex = 28;
            this.bK.Tag = "K";
            this.bK.Text = "K";
            this.bK.UseVisualStyleBackColor = false;
            this.bK.Click += new System.EventHandler(this.Key_Click);
            // 
            // bJ
            // 
            this.bJ.BackColor = System.Drawing.SystemColors.Control;
            this.bJ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bJ.Location = new System.Drawing.Point(320, 88);
            this.bJ.Name = "bJ";
            this.bJ.Size = new System.Drawing.Size(48, 40);
            this.bJ.TabIndex = 27;
            this.bJ.Tag = "J";
            this.bJ.Text = "J";
            this.bJ.UseVisualStyleBackColor = false;
            this.bJ.Click += new System.EventHandler(this.Key_Click);
            // 
            // bH
            // 
            this.bH.BackColor = System.Drawing.SystemColors.Control;
            this.bH.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bH.Location = new System.Drawing.Point(272, 88);
            this.bH.Name = "bH";
            this.bH.Size = new System.Drawing.Size(48, 40);
            this.bH.TabIndex = 26;
            this.bH.Tag = "H";
            this.bH.Text = "H";
            this.bH.UseVisualStyleBackColor = false;
            this.bH.Click += new System.EventHandler(this.Key_Click);
            // 
            // bG
            // 
            this.bG.BackColor = System.Drawing.SystemColors.Control;
            this.bG.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bG.Location = new System.Drawing.Point(224, 88);
            this.bG.Name = "bG";
            this.bG.Size = new System.Drawing.Size(48, 40);
            this.bG.TabIndex = 25;
            this.bG.Tag = "G";
            this.bG.Text = "G";
            this.bG.UseVisualStyleBackColor = false;
            this.bG.Click += new System.EventHandler(this.Key_Click);
            // 
            // bF
            // 
            this.bF.BackColor = System.Drawing.SystemColors.Control;
            this.bF.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bF.Location = new System.Drawing.Point(176, 88);
            this.bF.Name = "bF";
            this.bF.Size = new System.Drawing.Size(48, 40);
            this.bF.TabIndex = 24;
            this.bF.Tag = "F";
            this.bF.Text = "F";
            this.bF.UseVisualStyleBackColor = false;
            this.bF.Click += new System.EventHandler(this.Key_Click);
            // 
            // bD
            // 
            this.bD.BackColor = System.Drawing.SystemColors.Control;
            this.bD.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bD.Location = new System.Drawing.Point(128, 88);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(48, 40);
            this.bD.TabIndex = 23;
            this.bD.Tag = "D";
            this.bD.Text = "D";
            this.bD.UseVisualStyleBackColor = false;
            this.bD.Click += new System.EventHandler(this.Key_Click);
            // 
            // bS
            // 
            this.bS.BackColor = System.Drawing.SystemColors.Control;
            this.bS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bS.Location = new System.Drawing.Point(80, 88);
            this.bS.Name = "bS";
            this.bS.Size = new System.Drawing.Size(48, 40);
            this.bS.TabIndex = 22;
            this.bS.Tag = "S";
            this.bS.Text = "S";
            this.bS.UseVisualStyleBackColor = false;
            this.bS.Click += new System.EventHandler(this.Key_Click);
            // 
            // bA
            // 
            this.bA.BackColor = System.Drawing.SystemColors.Control;
            this.bA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bA.Location = new System.Drawing.Point(32, 88);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(48, 40);
            this.bA.TabIndex = 21;
            this.bA.Tag = "A";
            this.bA.Text = "A";
            this.bA.UseVisualStyleBackColor = false;
            this.bA.Click += new System.EventHandler(this.Key_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.Control;
            this.bBack.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bBack.Location = new System.Drawing.Point(416, 8);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(72, 32);
            this.bBack.TabIndex = 20;
            this.bBack.Text = "BACK Space";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bP
            // 
            this.bP.BackColor = System.Drawing.SystemColors.Control;
            this.bP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bP.Location = new System.Drawing.Point(440, 48);
            this.bP.Name = "bP";
            this.bP.Size = new System.Drawing.Size(48, 40);
            this.bP.TabIndex = 19;
            this.bP.Tag = "P";
            this.bP.Text = "P";
            this.bP.UseVisualStyleBackColor = false;
            this.bP.Click += new System.EventHandler(this.Key_Click);
            // 
            // bO
            // 
            this.bO.BackColor = System.Drawing.SystemColors.Control;
            this.bO.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bO.Location = new System.Drawing.Point(392, 48);
            this.bO.Name = "bO";
            this.bO.Size = new System.Drawing.Size(48, 40);
            this.bO.TabIndex = 18;
            this.bO.Tag = "O";
            this.bO.Text = "O";
            this.bO.UseVisualStyleBackColor = false;
            this.bO.Click += new System.EventHandler(this.Key_Click);
            // 
            // bI
            // 
            this.bI.BackColor = System.Drawing.SystemColors.Control;
            this.bI.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bI.Location = new System.Drawing.Point(344, 48);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(48, 40);
            this.bI.TabIndex = 17;
            this.bI.Tag = "I";
            this.bI.Text = "I";
            this.bI.UseVisualStyleBackColor = false;
            this.bI.Click += new System.EventHandler(this.Key_Click);
            // 
            // bU
            // 
            this.bU.BackColor = System.Drawing.SystemColors.Control;
            this.bU.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bU.Location = new System.Drawing.Point(296, 48);
            this.bU.Name = "bU";
            this.bU.Size = new System.Drawing.Size(48, 40);
            this.bU.TabIndex = 16;
            this.bU.Tag = "U";
            this.bU.Text = "U";
            this.bU.UseVisualStyleBackColor = false;
            this.bU.Click += new System.EventHandler(this.Key_Click);
            // 
            // bY
            // 
            this.bY.BackColor = System.Drawing.SystemColors.Control;
            this.bY.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bY.Location = new System.Drawing.Point(248, 48);
            this.bY.Name = "bY";
            this.bY.Size = new System.Drawing.Size(48, 40);
            this.bY.TabIndex = 15;
            this.bY.Tag = "Y";
            this.bY.Text = "Y";
            this.bY.UseVisualStyleBackColor = false;
            this.bY.Click += new System.EventHandler(this.Key_Click);
            // 
            // bT
            // 
            this.bT.BackColor = System.Drawing.SystemColors.Control;
            this.bT.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bT.Location = new System.Drawing.Point(200, 48);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(48, 40);
            this.bT.TabIndex = 14;
            this.bT.Tag = "T";
            this.bT.Text = "T";
            this.bT.UseVisualStyleBackColor = false;
            this.bT.Click += new System.EventHandler(this.Key_Click);
            // 
            // bR
            // 
            this.bR.BackColor = System.Drawing.SystemColors.Control;
            this.bR.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bR.Location = new System.Drawing.Point(152, 48);
            this.bR.Name = "bR";
            this.bR.Size = new System.Drawing.Size(48, 40);
            this.bR.TabIndex = 13;
            this.bR.Tag = "R";
            this.bR.Text = "R";
            this.bR.UseVisualStyleBackColor = false;
            this.bR.Click += new System.EventHandler(this.Key_Click);
            // 
            // bE
            // 
            this.bE.BackColor = System.Drawing.SystemColors.Control;
            this.bE.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bE.Location = new System.Drawing.Point(104, 48);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(48, 40);
            this.bE.TabIndex = 12;
            this.bE.Tag = "E";
            this.bE.Text = "E";
            this.bE.UseVisualStyleBackColor = false;
            this.bE.Click += new System.EventHandler(this.Key_Click);
            // 
            // bW
            // 
            this.bW.BackColor = System.Drawing.SystemColors.Control;
            this.bW.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bW.Location = new System.Drawing.Point(56, 48);
            this.bW.Name = "bW";
            this.bW.Size = new System.Drawing.Size(48, 40);
            this.bW.TabIndex = 11;
            this.bW.Tag = "W";
            this.bW.Text = "W";
            this.bW.UseVisualStyleBackColor = false;
            this.bW.Click += new System.EventHandler(this.Key_Click);
            // 
            // bQ
            // 
            this.bQ.BackColor = System.Drawing.SystemColors.Control;
            this.bQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bQ.Location = new System.Drawing.Point(8, 48);
            this.bQ.Name = "bQ";
            this.bQ.Size = new System.Drawing.Size(48, 40);
            this.bQ.TabIndex = 10;
            this.bQ.Tag = "Q";
            this.bQ.Text = "Q";
            this.bQ.UseVisualStyleBackColor = false;
            this.bQ.Click += new System.EventHandler(this.Key_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.Control;
            this.b0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b0.Location = new System.Drawing.Point(368, 8);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(40, 32);
            this.b0.TabIndex = 9;
            this.b0.Tag = "0";
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.Key_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.Control;
            this.b9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b9.Location = new System.Drawing.Point(328, 8);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 32);
            this.b9.TabIndex = 8;
            this.b9.Tag = "9";
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.Key_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.Control;
            this.b8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b8.Location = new System.Drawing.Point(288, 8);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 32);
            this.b8.TabIndex = 7;
            this.b8.Tag = "8";
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.Key_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.Control;
            this.b7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b7.Location = new System.Drawing.Point(248, 8);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 32);
            this.b7.TabIndex = 6;
            this.b7.Tag = "7";
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.Key_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.Control;
            this.b6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b6.Location = new System.Drawing.Point(208, 8);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 32);
            this.b6.TabIndex = 5;
            this.b6.Tag = "6";
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.Key_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.Control;
            this.b5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b5.Location = new System.Drawing.Point(168, 8);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 32);
            this.b5.TabIndex = 4;
            this.b5.Tag = "5";
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.Key_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.Control;
            this.b4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b4.Location = new System.Drawing.Point(128, 8);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 32);
            this.b4.TabIndex = 3;
            this.b4.Tag = "4";
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.Key_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Control;
            this.b3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b3.Location = new System.Drawing.Point(88, 8);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 32);
            this.b3.TabIndex = 2;
            this.b3.Tag = "3";
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.Key_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Control;
            this.b2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b2.Location = new System.Drawing.Point(48, 8);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 32);
            this.b2.TabIndex = 1;
            this.b2.Tag = "2";
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.Key_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Control;
            this.b1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b1.Location = new System.Drawing.Point(8, 8);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 32);
            this.b1.TabIndex = 0;
            this.b1.Tag = "1";
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.Key_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button3.Location = new System.Drawing.Point(368, 96);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(30, 21);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "::";
            this.Button3.Visible = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // LogForm
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(386, 216);
            this.ControlBox = false;
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " - ";
            this.Load += new System.EventHandler(this.LogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private TextBox CurrentUsedTextBox;
		
		private int CapsStatus = 1; //0 = 小写 1= 大写
		
		//返回酒店名称
		private string GetCompanyNameFromDB()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA = new SqlDataAdapter();
				DataSet dbDS = new DataSet();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				
				//companyname
				selectCMD.CommandText = "SELECT parametercode,value FROM syssetup where parametercode='companyname'";
				dbDA.SelectCommand = selectCMD;
				
				dbDA.Fill(dbDS, "t");
				return dbDS.Tables[0].Rows[0]["value"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			
			return "";
		}
		
		private string GetCompanyNameFromReg()
		{
			return rms_var.ReadStrfromReg("RestaurantName", "");
		}
		
		//确定按钮，验证登录信息
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			Label4.Text = "请稍等，正在登录系统......";
			Label4.Refresh();
			int logrtn;
			logrtn = rms_var.CheckLog(TextBox1.Text, TextBox2.Text, "localhost");
			if (logrtn == 1)
			{
				Label4.Text = "登录成功！";
				this.DialogResult = DialogResult.OK;
			}
			else if (logrtn == 0)
			{
				Label4.Text = "登录失败！";
				Label4.Refresh();
				MessageBox.Show("用户名或密码不正确，或者您没有登录该模块的权限。请核对后重新输入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Label4.Text = "";
				Label4.Refresh();
				TextBox1.Focus();
				TextBox1.SelectAll();
			}
			else
			{
				Label4.Text = "登陆失败！请检查系统初始化是否正确以及 SQL Server 的连接是否正常。";
				Label4.Refresh();
				MessageBox.Show("登陆失败！请检查系统初始化是否正确以及 SQL Server 的连接是否正常。" + '\r' + '\r' + "如果问题依然存在，请联系系统供应商。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}
		
		//结束应用程序
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			//结束应用程序
			this.DialogResult = DialogResult.Cancel;
		}
		
		//初始化 数据库连接
		private void LogForm_Load(System.Object sender, System.EventArgs e)
		{
			//If Now.Date.Year.ToString >= "2009" Then
			//If Now.Date.Month.ToString >= "1" Then
			//MessageBox.Show("系统遇到严重错误，向操作系统的请求失败！" + Chr(13) + Chr(13) + "Error code：0x286FA0B，如果问题依旧请联系系统供应商。")
			//Exit Sub
			//End If
			//End If
			bSpc.Tag = " ";
			
			rms_var.InitialApp();
			
			//Label3.Text = GetCompanyNameFromDB()
			Label3.Text = GetCompanyNameFromReg();
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			//Dim screenBound As Rectangle = Screen.GetWorkingArea(Me)
			
			//If Me.Width - pnlInput.Left - pnlInput.Width - 8 = 0 Then '当前状态为显示，变为隐藏
			//Me.Width = Me.Width - pnlInput.Width - 8
			//Else
			//    Me.Width = Me.Width + pnlInput.Width + 8
			//End If
			//Me.Left = (screenBound.Width - Me.Width) / 2
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
			Rectangle screenBound = Screen.GetWorkingArea(this);
			
			if (this.Width - pnlInput.Left - pnlInput.Width - 8 == 0) //当前状态为显示，变为隐藏
			{
				this.Width = this.Width - pnlInput.Width - 8;
			}
			else
			{
				this.Width = this.Width + pnlInput.Width + 8;
			}
			this.Left = System.Convert.ToInt32((screenBound.Width - this.Width) / 2);
		}
		
		private void InputButton_Click(string tag)
		{
			CurrentUsedTextBox.Text +=tag;
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
		#endregion
		
		private void TextBox1_Enter(object sender, System.EventArgs e)
		{
			CurrentUsedTextBox = TextBox1;
		}
		
		private void TextBox2_Enter(object sender, System.EventArgs e)
		{
			CurrentUsedTextBox = TextBox2;
		}

        private void Key_Click(object sender, EventArgs e)
        {
            Button tmsi = (Button)sender;
            InputButton_Click(tmsi.Tag.ToString());
        }
	}
	
	
}
