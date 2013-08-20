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


namespace DeskApp
{
	public class frmPayFor : System.Windows.Forms.Form
	{
		
		public struct structTablePayFor
		{
			public string tableno;
			public double foodcost;
			public double discountrate;
			public double fooddiscountcost;
			public double servercost;
			public double presentcost;
			public double addcost;
			public double oddcost;
			public double deratecost;
			public double overcost;
			public double lowpay;
			
			public double endprice; //抹零后的支付金额
			public double needpayforcost; //应付金额
			
			public double balancecost; //该桌台最终应支付的金额
			
		}
		
		public structTablePayFor[] TablePayFor;
		
		public DataTable tblPayFor;
		//Public CurrentTableno As String
		//Private CurrentTableSerialNo As String
		private string CurrentClubCardNo;
		private string CurrentClubCardDiscountRate;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmPayFor()
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
		internal System.Windows.Forms.Button btnCheckout;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.DataGrid dgPayForType;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label lblFoodCost;
		internal System.Windows.Forms.Label lblDiscountCost;
		internal System.Windows.Forms.Label lblServerCost;
		internal System.Windows.Forms.Label lblAddCost;
		internal System.Windows.Forms.Label lblOverTimeCost;
		internal System.Windows.Forms.Label lblOddCost;
		internal System.Windows.Forms.Label lblPresentCost;
		internal System.Windows.Forms.Label lblNeedCost;
		internal System.Windows.Forms.NumericUpDown numDerateCost;
		internal System.Windows.Forms.Label lblClubCardno;
		internal System.Windows.Forms.Label lblClubDisc;
		internal System.Windows.Forms.Label lblCustomerName;
		internal System.Windows.Forms.Label lblCustomerSignedCount;
		internal System.Windows.Forms.CheckBox chk_print;
		internal System.Windows.Forms.Button Button5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayFor));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNeedCost = new System.Windows.Forms.Label();
            this.lblPresentCost = new System.Windows.Forms.Label();
            this.lblOddCost = new System.Windows.Forms.Label();
            this.lblDiscountCost = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblOverTimeCost = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblServerCost = new System.Windows.Forms.Label();
            this.lblFoodCost = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.numDerateCost = new System.Windows.Forms.NumericUpDown();
            this.Button3 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCustomerSignedCount = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.dgPayForType = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.chk_print = new System.Windows.Forms.CheckBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.lblClubDisc = new System.Windows.Forms.Label();
            this.lblClubCardno = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDerateCost)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayForType)).BeginInit();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(224, 472);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(72, 23);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "结账(&O)";
            this.btnCheckout.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(296, 472);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(72, 23);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "取消(&C)";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "会员卡号：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblNeedCost);
            this.GroupBox1.Controls.Add(this.lblPresentCost);
            this.GroupBox1.Controls.Add(this.lblOddCost);
            this.GroupBox1.Controls.Add(this.lblDiscountCost);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblOverTimeCost);
            this.GroupBox1.Controls.Add(this.lblAddCost);
            this.GroupBox1.Controls.Add(this.lblServerCost);
            this.GroupBox1.Controls.Add(this.lblFoodCost);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(361, 120);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "结账金额";
            // 
            // lblNeedCost
            // 
            this.lblNeedCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNeedCost.ForeColor = System.Drawing.Color.Navy;
            this.lblNeedCost.Location = new System.Drawing.Point(256, 94);
            this.lblNeedCost.Name = "lblNeedCost";
            this.lblNeedCost.Size = new System.Drawing.Size(80, 23);
            this.lblNeedCost.TabIndex = 15;
            this.lblNeedCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPresentCost
            // 
            this.lblPresentCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPresentCost.ForeColor = System.Drawing.Color.Red;
            this.lblPresentCost.Location = new System.Drawing.Point(256, 42);
            this.lblPresentCost.Name = "lblPresentCost";
            this.lblPresentCost.Size = new System.Drawing.Size(80, 23);
            this.lblPresentCost.TabIndex = 14;
            this.lblPresentCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOddCost
            // 
            this.lblOddCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOddCost.ForeColor = System.Drawing.Color.Red;
            this.lblOddCost.Location = new System.Drawing.Point(256, 68);
            this.lblOddCost.Name = "lblOddCost";
            this.lblOddCost.Size = new System.Drawing.Size(80, 23);
            this.lblOddCost.TabIndex = 13;
            this.lblOddCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountCost
            // 
            this.lblDiscountCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDiscountCost.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountCost.Location = new System.Drawing.Point(256, 16);
            this.lblDiscountCost.Name = "lblDiscountCost";
            this.lblDiscountCost.Size = new System.Drawing.Size(80, 23);
            this.lblDiscountCost.TabIndex = 9;
            this.lblDiscountCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.Location = new System.Drawing.Point(192, 94);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(88, 23);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "应收金额：";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.Location = new System.Drawing.Point(192, 68);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 23);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "抹零金额：";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.Location = new System.Drawing.Point(40, 94);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 23);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "包房/附加费：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.Location = new System.Drawing.Point(192, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 23);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "优惠金额：";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.Location = new System.Drawing.Point(192, 42);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 23);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "赠送金额：";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.Location = new System.Drawing.Point(40, 68);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(110, 23);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "单间最低消费：";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.Location = new System.Drawing.Point(40, 42);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 23);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "服务费：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(40, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "菜品金额：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOverTimeCost
            // 
            this.lblOverTimeCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOverTimeCost.ForeColor = System.Drawing.Color.Navy;
            this.lblOverTimeCost.Location = new System.Drawing.Point(104, 68);
            this.lblOverTimeCost.Name = "lblOverTimeCost";
            this.lblOverTimeCost.Size = new System.Drawing.Size(80, 23);
            this.lblOverTimeCost.TabIndex = 12;
            this.lblOverTimeCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddCost
            // 
            this.lblAddCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddCost.ForeColor = System.Drawing.Color.Navy;
            this.lblAddCost.Location = new System.Drawing.Point(104, 94);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(80, 23);
            this.lblAddCost.TabIndex = 11;
            this.lblAddCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServerCost
            // 
            this.lblServerCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServerCost.ForeColor = System.Drawing.Color.Navy;
            this.lblServerCost.Location = new System.Drawing.Point(104, 42);
            this.lblServerCost.Name = "lblServerCost";
            this.lblServerCost.Size = new System.Drawing.Size(80, 23);
            this.lblServerCost.TabIndex = 10;
            this.lblServerCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodCost
            // 
            this.lblFoodCost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFoodCost.ForeColor = System.Drawing.Color.Navy;
            this.lblFoodCost.Location = new System.Drawing.Point(104, 16);
            this.lblFoodCost.Name = "lblFoodCost";
            this.lblFoodCost.Size = new System.Drawing.Size(80, 23);
            this.lblFoodCost.TabIndex = 8;
            this.lblFoodCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button4);
            this.GroupBox2.Controls.Add(this.TextBox2);
            this.GroupBox2.Controls.Add(this.numDerateCost);
            this.GroupBox2.Controls.Add(this.Button3);
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Location = new System.Drawing.Point(8, 136);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(360, 72);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "金额减免";
            // 
            // Button4
            // 
            this.Button4.Enabled = false;
            this.Button4.Location = new System.Drawing.Point(320, 40);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(26, 23);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "...";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Enabled = false;
            this.TextBox2.Location = new System.Drawing.Point(216, 40);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(101, 21);
            this.TextBox2.TabIndex = 6;
            // 
            // numDerateCost
            // 
            this.numDerateCost.DecimalPlaces = 2;
            this.numDerateCost.Enabled = false;
            this.numDerateCost.Location = new System.Drawing.Point(80, 40);
            this.numDerateCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDerateCost.Name = "numDerateCost";
            this.numDerateCost.Size = new System.Drawing.Size(72, 21);
            this.numDerateCost.TabIndex = 5;
            this.numDerateCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button3
            // 
            this.Button3.Enabled = false;
            this.Button3.Location = new System.Drawing.Point(320, 16);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(26, 23);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "...";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(80, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(237, 21);
            this.TextBox1.TabIndex = 3;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(162, 40);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(56, 23);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "批准人：";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(10, 40);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(72, 23);
            this.Label11.TabIndex = 1;
            this.Label11.Text = "减免金额：";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(10, 16);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 23);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "减免原因：";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lblCustomerSignedCount);
            this.GroupBox3.Controls.Add(this.lblCustomerName);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Location = new System.Drawing.Point(8, 216);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(360, 48);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "客户信息";
            // 
            // lblCustomerSignedCount
            // 
            this.lblCustomerSignedCount.ForeColor = System.Drawing.Color.Navy;
            this.lblCustomerSignedCount.Location = new System.Drawing.Point(240, 18);
            this.lblCustomerSignedCount.Name = "lblCustomerSignedCount";
            this.lblCustomerSignedCount.Size = new System.Drawing.Size(115, 23);
            this.lblCustomerSignedCount.TabIndex = 3;
            this.lblCustomerSignedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.ForeColor = System.Drawing.Color.Navy;
            this.lblCustomerName.Location = new System.Drawing.Point(80, 18);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(93, 23);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(16, 18);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(72, 23);
            this.Label14.TabIndex = 1;
            this.Label14.Text = "客户名称：";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(168, 18);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(72, 23);
            this.Label13.TabIndex = 0;
            this.Label13.Text = "签单数量：";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.Location = new System.Drawing.Point(8, 320);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(100, 23);
            this.Label15.TabIndex = 9;
            this.Label15.Text = "结账方式：";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgPayForType
            // 
            this.dgPayForType.CaptionVisible = false;
            this.dgPayForType.DataMember = "";
            this.dgPayForType.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPayForType.Location = new System.Drawing.Point(8, 344);
            this.dgPayForType.Name = "dgPayForType";
            this.dgPayForType.ReadOnly = true;
            this.dgPayForType.Size = new System.Drawing.Size(299, 104);
            this.dgPayForType.TabIndex = 4;
            this.dgPayForType.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgPayForType;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3});
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "payfor";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "方式编码";
            this.DataGridTextBoxColumn1.MappingName = "paytypecode";
            this.DataGridTextBoxColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "结账方式";
            this.DataGridTextBoxColumn2.MappingName = "paytypename";
            this.DataGridTextBoxColumn2.Width = 75;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "金额";
            this.DataGridTextBoxColumn3.MappingName = "price";
            this.DataGridTextBoxColumn3.Width = 75;
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(312, 344);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(57, 23);
            this.Button6.TabIndex = 5;
            this.Button6.Text = "添加(&A)";
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(312, 368);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(57, 23);
            this.Button7.TabIndex = 12;
            this.Button7.Text = "删除(&D)";
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // chk_print
            // 
            this.chk_print.Checked = true;
            this.chk_print.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_print.Location = new System.Drawing.Point(8, 448);
            this.chk_print.Name = "chk_print";
            this.chk_print.Size = new System.Drawing.Size(152, 24);
            this.chk_print.TabIndex = 7;
            this.chk_print.Text = "结账后打印结账单";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.lblClubDisc);
            this.GroupBox4.Controls.Add(this.lblClubCardno);
            this.GroupBox4.Controls.Add(this.Label26);
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Location = new System.Drawing.Point(8, 272);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(360, 48);
            this.GroupBox4.TabIndex = 3;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "会员卡信息";
            // 
            // lblClubDisc
            // 
            this.lblClubDisc.ForeColor = System.Drawing.Color.Navy;
            this.lblClubDisc.Location = new System.Drawing.Point(240, 18);
            this.lblClubDisc.Name = "lblClubDisc";
            this.lblClubDisc.Size = new System.Drawing.Size(115, 23);
            this.lblClubDisc.TabIndex = 5;
            this.lblClubDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClubCardno
            // 
            this.lblClubCardno.ForeColor = System.Drawing.Color.Navy;
            this.lblClubCardno.Location = new System.Drawing.Point(80, 18);
            this.lblClubCardno.Name = "lblClubCardno";
            this.lblClubCardno.Size = new System.Drawing.Size(93, 23);
            this.lblClubCardno.TabIndex = 4;
            this.lblClubCardno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label26
            // 
            this.Label26.Location = new System.Drawing.Point(176, 18);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(100, 23);
            this.Label26.TabIndex = 3;
            this.Label26.Text = "折让比率：";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.SystemColors.Info;
            this.Label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label23.ForeColor = System.Drawing.Color.Red;
            this.Label23.Location = new System.Drawing.Point(208, 368);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(160, 17);
            this.Label23.TabIndex = 6;
            this.Label23.Text = "添加结账方式，请单击这里";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label23.Visible = false;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(120, 472);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(104, 23);
            this.Button5.TabIndex = 8;
            this.Button5.Text = "打印暂结单(&P)";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // frmPayFor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(376, 512);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.chk_print);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.dgPayForType);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayFor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结账";
            this.Load += new System.EventHandler(this.frmPayFor_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDerateCost)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayForType)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		
		#endregion
		
		public void CreatePayForTable()
		{
			tblPayFor = new DataTable("PayFor");
			
			DataColumn Column3 = new DataColumn();
			Column3.DataType = System.Type.GetType("System.String");
			Column3.AllowDBNull = true;
			Column3.ReadOnly = true;
			Column3.ColumnName = "PayTypeCode";
			tblPayFor.Columns.Add(Column3);
			
			DataColumn Column4 = new DataColumn();
			Column4.DataType = System.Type.GetType("System.String");
			Column4.AllowDBNull = true;
			Column4.ReadOnly = true;
			Column4.ColumnName = "PayTypeName";
			tblPayFor.Columns.Add(Column4);
			
			DataColumn Column5 = new DataColumn();
			Column5.DataType = System.Type.GetType("System.Decimal");
			Column5.AllowDBNull = true;
			Column5.ReadOnly = true;
			Column5.ColumnName = "Price";
			Column5.DefaultValue = 0;
			
			tblPayFor.Columns.Add(Column5);
		}
		
		private string GetSuitBillNoInBill(string serialno, string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT billno FROM salelist_t where serialno='" + serialno + "' and suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					return dbDS.Tables[0].Rows[0][0].ToString();
				}
				else
				{
					return "";
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
			return "";
		}
		
		private string GetSuitBillTypeCodeInBill(string serialno, string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT billtypecode FROM salelist_t where serialno='" + serialno + "' and suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					return dbDS.Tables[0].Rows[0][0].ToString();
				}
				else
				{
					return "";
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
			return "";
		}
		
		private string GetSuitBillTypeNameInBill(string serialno, string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT billtypename FROM view_salelist_t where serialno='" + serialno + "' and suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					return dbDS.Tables[0].Rows[0][0].ToString();
				}
				else
				{
					return "";
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
			return "";
		}
		
		private string GetSuitName(string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT suitname FROM suit where suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					return dbDS.Tables[0].Rows[0][0].ToString();
				}
				else
				{
					return "";
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
			return "";
		}
		
		private double GetSuitPrice(string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT standardsum FROM suit where suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					return double.Parse(dbDS.Tables[0].Rows[0][0].ToString());
				}
				else
				{
					return 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return 0;
			}
			finally
			{
				conn.Close();
			}
		}
		
		private bool DoPayForTemp(string needbalancecost)
		{
			if (MessageBox.Show("确定要打印暂结单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				this.Enabled = false;
				double remains = 0;
				string currenttableserialno;
				string currenttableno;
                currenttableno = TablePayFor[0].tableno;
				currenttableserialno = rms_var.GetCurrentTableSerialNo(currenttableno);
				//分派减免金额
				double totalfoodcost = 0;
				
				for (int i = 0; i <= TablePayFor.Length - 1; i++)
				{
					totalfoodcost = totalfoodcost + TablePayFor[i].foodcost;
				}
				
				for (int i = 0; i <= TablePayFor.Length - 1; i++)
				{
					TablePayFor[i].deratecost = double.Parse(numDerateCost.Value.ToString()) * TablePayFor[i].foodcost / totalfoodcost;
				}
				
				//将所有需要结帐的菜品和套餐加入临时表
				//遍历菜品记录
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					int NormalFoodCount;
					int SuitCount;
					int SuitRecCount;
					int TotalCount;
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					//非套餐菜品
					selectCMD.CommandText = "select billno,billtypecode,billtypename,foodname,unit,add_dec*decquantity+addquantity as quantity,price as totalprice from view_salelist_t where serialno='" + currenttableserialno + "' and suitcode=''";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t1");
					NormalFoodCount = dbDS.Tables[0].Rows.Count;
					//返回所有套餐suitcode
					selectCMD.CommandText = "select suitcode,suitquantity from view_salelist_t where serialno='" + currenttableserialno + "' and suitcode<>'' group by suitcode,suitquantity ";
					dbDA.SelectCommand = selectCMD;
					dbDA.Fill(dbDS, "t2");
					SuitRecCount = dbDS.Tables["t2"].Rows.Count;
					SuitCount = 0;
					for (int i = 0; i <= dbDS.Tables["t2"].Rows.Count - 1; i++)
					{
						SuitCount = SuitCount + int.Parse(dbDS.Tables["t2"].Rows[i]["suitquantity"].ToString());
					}
					TotalCount = NormalFoodCount + SuitCount;
					selectCMD.CommandText = "delete from salelist_tt where serialno='" + currenttableserialno + "'";
					selectCMD.ExecuteNonQuery();
					//准备向salelist_tt中添加结帐显示套餐
					for (int i = 0; i <= SuitRecCount - 1; i++)
					{
						selectCMD.CommandText = "insert into salelist_tt (serialno,billno,billtypecode,billtypename,foodname,unit,quantity,price) values ('" + currenttableserialno + "','" + GetSuitBillNoInBill(currenttableserialno,dbDS.Tables[1].Rows[i][0].ToString()) + "','" + GetSuitBillTypeCodeInBill(currenttableserialno, dbDS.Tables[1].Rows[i][0].ToString()) + "','" + GetSuitBillTypeNameInBill(currenttableserialno, dbDS.Tables[1].Rows[i][0].ToString()) + "','" + GetSuitName(dbDS.Tables[1].Rows[i][0].ToString()) + "','份'," + dbDS.Tables[1].Rows[i][1].ToString() + "," + (System.Convert.ToDouble(dbDS.Tables[1].Rows[i][1].ToString()) * GetSuitPrice(dbDS.Tables[1].Rows[i][0].ToString())).ToString() + ")";
						selectCMD.ExecuteNonQuery();
					}
					//向salelist_tt中添加结帐显示菜品
					for (int i = 0; i <= NormalFoodCount - 1; i++)
					{
						selectCMD.CommandText = "insert into salelist_tt (serialno,billno,billtypecode,billtypename,foodname,unit,quantity,price) values ('" + currenttableserialno + "','" + dbDS.Tables[0].Rows[i]["billno"].ToString() + "','" + dbDS.Tables[0].Rows[i]["billtypecode"].ToString() + "','" + dbDS.Tables[0].Rows[i]["billtypename"].ToString() + "','" + dbDS.Tables[0].Rows[i]["foodname"].ToString() + "','" + dbDS.Tables[0].Rows[i]["unit"].ToString() + "'" + "," + dbDS.Tables[0].Rows[i]["quantity"].ToString() + "," + dbDS.Tables[0].Rows[i]["totalprice"].ToString() + ")";
						selectCMD.ExecuteNonQuery();
					}
				}
				catch (Exception)
				{
					MessageBox.Show("获取菜品的操作失败！");
					this.Enabled = true;
					return false;
				}
				
				//打印暂结单
				if (report_var.cr_payfor == null)
				{
					report_var.cr_payfor = new ReportDocument();
				}
				else
				{
					report_var.cr_payfor.Close();
					report_var.cr_payfor = null;
					report_var.cr_payfor = new ReportDocument();
				}
				//检测报表文件是否存在
				if (File.Exists(rms_var.GetReportPath() + report_var.PayforTemp_rpt_filename))
				{
					report_var.cr_payfor.Load(rms_var.GetReportPath() + report_var.PayforTemp_rpt_filename);
				}
				else
				{
					MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
					return false;
				}
				
                //TableLogOnInfo logOnInfo = new TableLogOnInfo();
                ////Dim i As Integer
				
                //// 对报表中的每个表依次循环。
                //for (int i = 0; i <= report_var.cr_payfor.Database.Tables.Count - 1; i++)
                //{
                //    // 设置当前表的连接信息。
                //    logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
                //    logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
                //    logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
                //    logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
                //    report_var.cr_payfor.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
                //}
                //填充数据
                {
                    DataSet dsdataSet = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("select billno,billtypecode,billtypename,foodname,unit,quantity,price as totalprice from salelist_tt where serialno='" + currenttableserialno + "'", conn);
                    da.Fill(dsdataSet, "salelist_tt");
                    //使用“报表引擎”对象模型将填充的数据集,传递给报表
                    report_var.cr_payfor.SetDataSource(dsdataSet.Tables[0]);
                }

				ParameterFieldDefinitions crParameterFieldDefinitions;
				ParameterFieldDefinition crParameterFieldDefinition;
				ParameterValues crParameterValues;
				ParameterDiscreteValue crParameterDiscreteValue;
				
				crParameterFieldDefinitions = report_var.cr_payfor.DataDefinition.ParameterFields;
				
				crParameterFieldDefinition = crParameterFieldDefinitions["@serialno"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = currenttableserialno;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["酒店名称"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = rms_var.GetSysSetup("CompanyName");
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["桌台号"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "桌台号：" + currenttableno;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["菜品合计"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "菜品合计：" + lblFoodCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["附加费"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = lblAddCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["服务费合计"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = lblServerCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["超时费合计"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = lblOverTimeCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["优惠合计"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = lblDiscountCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["减免合计"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = numDerateCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["抹零"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = lblOddCost.Text;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["operatorid"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "操作员：" + rms_var.GetEmpName(rms_var.opinfo.OpID);
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["title"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "暂结单";
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				//应收合计
				decimal balancecost;
				
				if (rms_var.ExistsMngr(TextBox2.Text))
				{
					if (TextBox1.Text != "")
					{
						//减去减免金额
                        balancecost = decimal.Parse(lblNeedCost.Text) - numDerateCost.Value;
					}
					else
					{
                        balancecost = decimal.Parse(lblNeedCost.Text);
					}
					
				}
				else
				{
                    balancecost = decimal.Parse(lblNeedCost.Text);
				}
				
				crParameterFieldDefinition = crParameterFieldDefinitions["应收合计"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
                crParameterDiscreteValue.Value = "应收合计：" + string.Format("{0:N2}", balancecost);
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["实收"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
                crParameterDiscreteValue.Value = "实收：" + string.Format("{0:N2}", decimal.Parse(needbalancecost));
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["找零"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();

                decimal ChangeCost = decimal.Parse(needbalancecost) - balancecost;

                crParameterDiscreteValue.Value = "找零："+string.Format("{0:N2}",ChangeCost);
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["@guid"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "GUID：" + currenttableserialno;
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["酒店地址"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "公司地址：" + rms_var.GetSysSetup("address");
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				crParameterFieldDefinition = crParameterFieldDefinitions["联系电话"];
				crParameterValues = crParameterFieldDefinition.CurrentValues;
				crParameterDiscreteValue = new ParameterDiscreteValue();
				crParameterDiscreteValue.Value = "联系电话：" + rms_var.GetSysSetup("telphone");
				crParameterValues.Add(crParameterDiscreteValue);
				crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
				
				report_var.cr_payfor.PrintToPrinter(1, true, 0, 0);
				this.Enabled = true;
                return true;
			}
			else
			{
				return false;
			}
		}
		
		private bool DoPayFor(string needbalancecost, bool print, bool accessdb)
		{
			if (MessageBox.Show("确定要进行结帐操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
                string ChangeCost=((double.Parse(needbalancecost)) - double.Parse(lblNeedCost.Text)).ToString();
                //在客显上显示找零
                DevExt.PoleDisplayer.Display(string.Format("{0:N2}", ChangeCost), DevExt.PoleDisplayType.Change);
				//显示找零金额
                MessageBox.Show("找零金额：" + ChangeCost + " 元");
				double remains = (double.Parse(needbalancecost)) - double.Parse(lblNeedCost.Text);
				string currenttableserialno;
				string currenttableno;
                currenttableno =TablePayFor[0].tableno;
				currenttableserialno = rms_var.GetCurrentTableSerialNo(currenttableno);
				//分派减免金额
				double totalfoodcost = 0;
				
				for (int i = 0; i <= TablePayFor.Length - 1; i++)
				{
					totalfoodcost = totalfoodcost + TablePayFor[i].foodcost;
				}
				
				for (int i = 0; i <= TablePayFor.Length - 1; i++)
				{
					TablePayFor[i].deratecost = (double)numDerateCost.Value * TablePayFor[i].foodcost/totalfoodcost;
				}
				
				//将所有需要结帐的菜品和套餐加入临时表
				//遍历菜品记录
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					int NormalFoodCount;
					int SuitCount;
					int SuitRecCount;
					int TotalCount;
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					//非套餐菜品
					selectCMD.CommandText = "select billno,billtypecode,billtypename,foodname,unit,add_dec*decquantity+addquantity as quantity,price as totalprice from view_salelist_t where serialno='" + currenttableserialno + "' and suitcode=''";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t1");
					NormalFoodCount = dbDS.Tables[0].Rows.Count;
					//返回所有套餐suitcode
					selectCMD.CommandText = "select suitcode,suitquantity from view_salelist_t where serialno='" + currenttableserialno + "' and suitcode<>'' group by suitcode,suitquantity ";
					dbDA.SelectCommand = selectCMD;
					dbDA.Fill(dbDS, "t2");
					SuitRecCount = dbDS.Tables["t2"].Rows.Count;
					SuitCount = 0;
					for (int i = 0; i <= dbDS.Tables["t2"].Rows.Count - 1; i++)
					{
						SuitCount = SuitCount + int.Parse(dbDS.Tables["t2"].Rows[i]["suitquantity"].ToString());
					}
					TotalCount = NormalFoodCount + SuitCount;
					selectCMD.CommandText = "delete from salelist_tt where serialno='" + currenttableserialno + "'";
					selectCMD.ExecuteNonQuery();
					//准备向salelist_tt中添加结帐显示套餐
					for (int i = 0; i <= SuitRecCount - 1; i++)
					{
						selectCMD.CommandText = "insert into salelist_tt (serialno,billno,billtypecode,billtypename,foodname,unit,quantity,price) values ('" + currenttableserialno + "','" + GetSuitBillNoInBill(currenttableserialno,dbDS.Tables[1].Rows[i][0].ToString()) + "','" + GetSuitBillTypeCodeInBill(currenttableserialno,dbDS.Tables[1].Rows[i][0].ToString()) + "','" + GetSuitBillTypeNameInBill(currenttableserialno,dbDS.Tables[1].Rows[i][0].ToString()) + "','" + GetSuitName(dbDS.Tables[1].Rows[i][0].ToString()) + "','份'," + dbDS.Tables[1].Rows[i][1].ToString() + "," + ((System.Convert.ToDouble(dbDS.Tables[1].Rows[i][1])) * GetSuitPrice(dbDS.Tables[1].Rows[i][0].ToString())) + ")";
						selectCMD.ExecuteNonQuery();
					}
					//向salelist_tt中添加结帐显示菜品
					for (int i = 0; i <= NormalFoodCount - 1; i++)
					{
						selectCMD.CommandText = "insert into salelist_tt (serialno,billno,billtypecode,billtypename,foodname,unit,quantity,price) values ('" + currenttableserialno + "','" + dbDS.Tables[0].Rows[i]["billno"].ToString() + "','" + dbDS.Tables[0].Rows[i]["billtypecode"].ToString() + "','" + dbDS.Tables[0].Rows[i]["billtypename"].ToString() + "','" + dbDS.Tables[0].Rows[i]["foodname"].ToString() + "','" + dbDS.Tables[0].Rows[i]["unit"].ToString() + "'," + dbDS.Tables[0].Rows[i]["quantity"].ToString() + "," + dbDS.Tables[0].Rows[i]["totalprice"].ToString() + ")";
						selectCMD.ExecuteNonQuery();
					}
				}
				catch (Exception)
				{
					MessageBox.Show("获取菜品的操作失败！");
					this.Enabled = true;
					return false;
				}
				
				for (int i = 0; i <= TablePayFor.Length - 1; i++)
				{
					currenttableno = TablePayFor[i].tableno;
					currenttableserialno = rms_var.GetCurrentTableSerialNo(currenttableno);
					if (accessdb)
					{
						rms_var.AddToBalance(currenttableno, TablePayFor[i].foodcost.ToString(), TablePayFor[i].fooddiscountcost.ToString(), TablePayFor[i].servercost.ToString(), TablePayFor[i].addcost.ToString(), TablePayFor[i].overcost.ToString(), System.Convert.ToString(TablePayFor[i].oddcost), TablePayFor[i].presentcost.ToString(),TablePayFor[i].needpayforcost.ToString(), System.Convert.ToString(TablePayFor[i].deratecost), System.Convert.ToString(TablePayFor[i].balancecost - TablePayFor[i].deratecost), TextBox1.Text, TextBox2.Text);
					}
				}
				if (accessdb)
				{
					//向支付类型表中添加记录 各类型金额
					string serialno;
					serialno = rms_var.GetCurrentTableSerialNo(currenttableno);
					for (int i = 0; i <= tblPayFor.Rows.Count - 1; i++)
					{
						if ( tblPayFor.Rows[i]["paytypename"] == "签单")
						{
                            rms_var.AddToBalanceType(serialno, tblPayFor.Rows[i]["paytypecode"].ToString(), tblPayFor.Rows[i]["Price"].ToString(), "", "", rms_var.GetCustomerCode(lblCustomerName.Text), "1", "", "0");
							//更新customer表
                            rms_var.UpdateCustomerSignPay(rms_var.GetCustomerCode(lblCustomerName.Text), tblPayFor.Rows[i]["Price"].ToString());
						}
						else if ( tblPayFor.Rows[i]["paytypename"] == "会员卡")
						{
							rms_var.AddToBalanceType(serialno, tblPayFor.Rows[i]["paytypecode"].ToString(), tblPayFor.Rows[i]["Price"].ToString(), "", "", "", "0", lblClubCardno.Text, lblClubDisc.Text);
							//更新clubcard表
							rms_var.UpdateClubCardPay(lblClubCardno.Text, tblPayFor.Rows[i]["Price"].ToString());
						}
						else
						{
                            rms_var.AddToBalanceType(serialno, tblPayFor.Rows[i]["paytypecode"].ToString(), tblPayFor.Rows[i]["Price"].ToString(), "", "", "", "0", "", "0");
						}
					}
					//添加 balancetable,salebill,salelist 移除 balancetable_t,salebill_t,salelist_t
					System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
					conn1.ConnectionString = rms_var.ConnStr;
					try
					{
						SqlCommand selectCMD1 = new SqlCommand();
						selectCMD1.Connection = conn1;
						selectCMD1.CommandText = "insert into balancetable select * from balancetable_t where serialno='" + serialno + "'";
						selectCMD1.CommandTimeout = 30;
						conn1.Open();
						selectCMD1.ExecuteNonQuery();
						selectCMD1.CommandText = "delete from balancetable_t where serialno='" + serialno + "'";
						selectCMD1.ExecuteNonQuery();
						selectCMD1.CommandText = "insert into salebill select * from salebill_t where serialno='" + serialno + "'";
						selectCMD1.ExecuteNonQuery();
						selectCMD1.CommandText = "delete from salebill_t where serialno='" + serialno + "'";
						selectCMD1.ExecuteNonQuery();
						selectCMD1.CommandText = "insert into salelist select * from salelist_t where serialno='" + serialno + "'";
						selectCMD1.ExecuteNonQuery();
						selectCMD1.CommandText = "delete from salelist_t where serialno='" + serialno + "'";
						selectCMD1.ExecuteNonQuery();
						
						for (int i = 0; i <= TablePayFor.Length - 1; i++)
						{
							selectCMD1.CommandText = "update tablestatus set status='0' where tableno='" + TablePayFor[i].tableno + "'";
							selectCMD1.ExecuteNonQuery();
						}
						
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
						return false;
					}
					finally
					{
						conn1.Close();
					}
                    //打开钱箱
                    DevExt.CashDrawer.Open();
					MessageBox.Show("结账完毕！");
					this.Enabled = false;
				}
				
				//打印结帐单
				if (print)
				{
                    try
                    {

                        if (report_var.cr_payfor == null)
                        {
                            report_var.cr_payfor = new ReportDocument();
                        }
                        else
                        {
                            report_var.cr_payfor.Close();
                            report_var.cr_payfor = null;
                            report_var.cr_payfor = new ReportDocument();
                        }
                        //检测报表文件是否存在
                        if (File.Exists(rms_var.GetReportPath() + report_var.Payfor_rpt_filename))
                        {
                            report_var.cr_payfor.Load(rms_var.GetReportPath() + report_var.Payfor_rpt_filename);
                        }
                        else
                        {
                            MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
                            return false;
                        }

                        //TableLogOnInfo logOnInfo = new TableLogOnInfo();
                        //int i;

                        //// 对报表中的每个表依次循环。
                        //for (i = 0; i <= report_var.cr_payfor.Database.Tables.Count - 1; i++)
                        //{
                        //    // 设置当前表的连接信息。
                        //    logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
                        //    logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
                        //    logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
                        //    logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
                        //    report_var.cr_payfor.Database.Tables[i].ApplyLogOnInfo(logOnInfo);

                        //}
                        //填充数据
                        {
                            DataSet dsdataSet = new DataSet();
                            SqlDataAdapter da = new SqlDataAdapter("select billno,billtypecode,billtypename,foodname,unit,quantity,price as totalprice from salelist_tt where serialno='" + currenttableserialno + "'", conn);
                            da.Fill(dsdataSet, "salelist_tt");
                            //使用“报表引擎”对象模型将填充的数据集,传递给报表
                            report_var.cr_payfor.SetDataSource(dsdataSet.Tables[0]);
                        }
                        ParameterFieldDefinitions crParameterFieldDefinitions;
                        ParameterFieldDefinition crParameterFieldDefinition;
                        ParameterValues crParameterValues;
                        ParameterDiscreteValue crParameterDiscreteValue;

                        crParameterFieldDefinitions = report_var.cr_payfor.DataDefinition.ParameterFields;

                        crParameterFieldDefinition = crParameterFieldDefinitions["@serialno"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = currenttableserialno;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["酒店名称"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = rms_var.GetSysSetup("CompanyName");
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["桌台号"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "桌台号：" + currenttableno;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["菜品合计"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "菜品合计：" + lblFoodCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["附加费"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = lblAddCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["服务费合计"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = lblServerCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["超时费合计"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = lblOverTimeCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["优惠合计"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = lblDiscountCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["减免合计"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = numDerateCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["抹零"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = lblOddCost.Text;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["operatorid"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "操作员：" + rms_var.GetEmpName(rms_var.opinfo.OpID);
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["title"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "结帐单";
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        //应收合计
                        double balancecost;

                        if (rms_var.ExistsMngr(TextBox2.Text))
                        {
                            if (TextBox1.Text != "")
                            {
                                //减去减免金额
                                balancecost = (double.Parse(lblNeedCost.Text)) - double.Parse(numDerateCost.Value.ToString());
                            }
                            else
                            {
                                balancecost = double.Parse(lblNeedCost.Text);
                            }

                        }
                        else
                        {
                            balancecost = double.Parse(lblNeedCost.Text);
                        }

                        crParameterFieldDefinition = crParameterFieldDefinitions["应收合计"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "应收合计：" + string.Format("{0:N2}", balancecost);
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["实收"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "实收：" + string.Format("{0:N2}", double.Parse(needbalancecost));
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["找零"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "找零：" + string.Format("{0:N2}", remains);
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["@guid"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "GUID：" + currenttableserialno;
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["酒店地址"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "公司地址：" + rms_var.GetSysSetup("address");
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        crParameterFieldDefinition = crParameterFieldDefinitions["联系电话"];
                        crParameterValues = crParameterFieldDefinition.CurrentValues;
                        crParameterDiscreteValue = new ParameterDiscreteValue();
                        crParameterDiscreteValue.Value = "联系电话：" + rms_var.GetSysSetup("telphone");
                        crParameterValues.Add(crParameterDiscreteValue);
                        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                        //frmPreview frmprv
                        //frmprv.CrystalReportViewer1.ReportSource = oRpt;

                        //frmprv.ShowDialog()
                        report_var.cr_payfor.PrintToPrinter(1, true, 0, 0);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
					
				}				
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public void AddNewPayFor(string paytypecode, string paytypename, double price)
		{
			DataRow myRow;
			
			myRow = tblPayFor.NewRow();
			myRow["PayTypeCode"] = paytypecode;
			myRow["PayTypeName"] = paytypename;
			myRow["Price"] = price;
			tblPayFor.Rows.Add(myRow);
		}
		
		private void frmPayFor_Load(System.Object sender, System.EventArgs e)
		{
			dgPayForType.DataSource = tblPayFor;
			Label23.Visible = true;
		}
		
		private void Button6_Click(System.Object sender, System.EventArgs e)
		{
			Label23.Visible = false;
			frmSelPayType frmspt = new frmSelPayType();
            decimal balancedcost = 0; //支付金额
			
			if (tblPayFor.Rows.Count > 0)
			{
				for (int i = 0; i <= tblPayFor.Rows.Count - 1; i++)
				{
					balancedcost = balancedcost + Convert.ToDecimal(tblPayFor.Rows[i]["Price"]);
				}
				//有无减免金额
				if (rms_var.ExistsMngr(TextBox2.Text))
				{
					if (TextBox1.Text != "")
					{
						//减去减免金额
                        frmspt.NumericUpDown1.Value =decimal.Parse(lblNeedCost.Text)- balancedcost - numDerateCost.Value;
					}
					else
					{
						frmspt.NumericUpDown1.Value = decimal.Parse(lblNeedCost.Text) - balancedcost;
					}
					
				}
				else
				{
					frmspt.NumericUpDown1.Value = decimal.Parse(lblNeedCost.Text) - balancedcost;
				}
			}
			else
			{
				//有无减免金额
				if (rms_var.ExistsMngr(TextBox2.Text))
				{
					if (TextBox1.Text != "")
					{
						//减去减免金额
                        frmspt.NumericUpDown1.Value =decimal.Parse(lblNeedCost.Text) - balancedcost - numDerateCost.Value;
					}
					else
					{
						frmspt.NumericUpDown1.Value =decimal.Parse(lblNeedCost.Text) - balancedcost;
					}
					
				}
				else
				{
					frmspt.NumericUpDown1.Value = decimal.Parse(lblNeedCost.Text) - balancedcost;
				}
			}
			
			frmspt.ShowDialog();
			if (frmspt.DialogResult == DialogResult.OK)
			{
				//检测有无已经存在该结账方式了
				for (int i = 0; i <= dgPayForType.VisibleRowCount - 1; i++)
				{
					if (dgPayForType[i, 1] == frmspt.ComboBox1.Text) //已经存在
					{
						MessageBox.Show("已经存在该结账方式了");
						return;
					}
				}
				lblCustomerName.Text = rms_var.PayCustomerName;
				lblCustomerSignedCount.Text = rms_var.PayCustomerSignedCount;
				
				lblClubCardno.Text = rms_var.PayClubCardNo;
				lblClubDisc.Text = rms_var.PayClubCardDiscountRate;
				AddNewPayFor(rms_var.GetPayTypeCode(frmspt.ComboBox1.Text), frmspt.ComboBox1.Text, (double) frmspt.NumericUpDown1.Value);
			}
		}
		
		private void Button7_Click(System.Object sender, System.EventArgs e)
		{
			if (tblPayFor.Rows.Count != 0)
			{
				if (MessageBox.Show("确定要删除当前结账方式吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (dgPayForType[dgPayForType.CurrentRowIndex, 1].ToString().Trim() == "签单")
					{
						lblCustomerName.Text = "";
						lblCustomerSignedCount.Text = "";
						
						rms_var.PayCustomerCode = "";
						rms_var.PayCustomerName = "";
						rms_var.PayCustomerSignedCount = "";
						
						tblPayFor.Rows.RemoveAt(dgPayForType.CurrentRowIndex);
					}
					else if (dgPayForType[dgPayForType.CurrentRowIndex, 1].ToString().Trim() == "会员卡")
					{
						lblClubCardno.Text = "";
						lblClubDisc.Text = "";
						rms_var.PayClubCardNo = "";
						rms_var.PayClubCardDiscountRate = "";
						tblPayFor.Rows.RemoveAt(dgPayForType.CurrentRowIndex);
					}
					else
					{
						tblPayFor.Rows.RemoveAt(dgPayForType.CurrentRowIndex);
					}
				}
			}
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			frmSelDerateReason frmsdr = new frmSelDerateReason();
			frmsdr.ShowDialog();
			if (frmsdr.DialogResult == DialogResult.OK)
			{
                TextBox1.Text = frmsdr.dgDerateReason[frmsdr.dgDerateReason.CurrentRowIndex, 1].ToString();
			}
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			frmSelManager frmsm = new frmSelManager();
			frmsm.ShowDialog();
			if (frmsm.DialogResult == DialogResult.OK)
			{
                TextBox2.Text = frmsm.DataGrid1[frmsm.DataGrid1.CurrentRowIndex, 1].ToString();
			}
		}
		
		//打印暂结单
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			double balancedcost = double.Parse(lblNeedCost.Text);
			if (DoPayForTemp(balancedcost.ToString()))
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			//应收金额不得超过xxx元
			//If CDbl(lblNeedCost.Text) > 150 Then
			//MsgBox("非正式版本结账金额不得超过150元！")
			//Exit Sub
			//End If
			
			if (tblPayFor.Rows.Count > 0)
			{
                decimal balancedcost = 0;
				for (int i = 0; i <= tblPayFor.Rows.Count - 1; i++)
				{
                    balancedcost = balancedcost + decimal.Parse(tblPayFor.Rows[i]["Price"].ToString());
				}
				
				if (rms_var.ExistsMngr(TextBox2.Text))
				{
					if (TextBox1.Text != "")
					{
						//减免金额
						balancedcost = balancedcost - numDerateCost.Value;
						if (lblClubCardno.Text != "") //会员卡打折
						{
                            if (balancedcost < (decimal.Parse(lblNeedCost.Text)) * (decimal.Parse(lblClubDisc.Text)) / 100 - numDerateCost.Value)
							{
								MessageBox.Show("结账金额不能小于应收金额！");
							}
							else
							{
								//结账操作
								if (DoPayFor(balancedcost.ToString(), chk_print.Checked, true))
								{
									this.DialogResult = DialogResult.OK;
								}
							}
						}
						else
						{
                            if (balancedcost < (decimal.Parse(lblNeedCost.Text)) - numDerateCost.Value)
							{
								MessageBox.Show("结账金额不能小于应收金额！");
							}
							else
							{
								//结账操作
								if (DoPayFor(balancedcost.ToString(), chk_print.Checked, true))
								{
									this.DialogResult = DialogResult.OK;
								}
							}
						}
					}
					else
					{
						//结账操作
						if (DoPayFor(balancedcost.ToString(), chk_print.Checked, true))
						{
							this.DialogResult = DialogResult.OK;
						}
					}
				}
				else
				{
					if (lblClubCardno.Text != "") //会员卡打折
					{
                        if (balancedcost < (decimal.Parse(lblNeedCost.Text)) * (decimal.Parse(lblClubDisc.Text)) / 100)
						{
							MessageBox.Show("结账金额不能小于应收金额！");
						}
						else
						{
							//结账操作
							if (DoPayFor(balancedcost.ToString(), chk_print.Checked, true))
							{
								this.DialogResult = DialogResult.OK;
							}
						}
					}
					else
					{
                        if (balancedcost < decimal.Parse(lblNeedCost.Text))
						{
							MessageBox.Show("结账金额不能小于应收金额！");
						}
						else
						{
							//结账操作
							if (DoPayFor(balancedcost.ToString(), chk_print.Checked, true))
							{
								this.DialogResult = DialogResult.OK;
							}
						}
					}
					
				}
			}
			else
			{
				MessageBox.Show("结账方式为空，无法进行结账操作！");
			}
		}
	}
	
}
