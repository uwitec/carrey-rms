using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace DeskApp
{
	public class frmTableStatus : System.Windows.Forms.Form
	{
		
		private ListViewItem[] lvitems;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmTableStatus()
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
        internal System.Windows.Forms.ListView lvTablelist;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.ContextMenu ContextMenu1;
        private MenuItem mnu_PowerON;
        private MenuItem mnu_PowerOFF;
        private ToolStrip toolStrip1;
        private ToolStripComboBox cbTableType;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ListView listView1;
        private Panel panel1;
        private Splitter splitter1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private ListView listView2;
		internal System.Windows.Forms.MenuItem MenuItem1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableStatus));
            this.lvTablelist = new System.Windows.Forms.ListView();
            this.ContextMenu1 = new System.Windows.Forms.ContextMenu();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_PowerON = new System.Windows.Forms.MenuItem();
            this.mnu_PowerOFF = new System.Windows.Forms.MenuItem();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbTableType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTablelist
            // 
            this.lvTablelist.ContextMenu = this.ContextMenu1;
            this.lvTablelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTablelist.LargeImageList = this.ImageList1;
            this.lvTablelist.Location = new System.Drawing.Point(129, 25);
            this.lvTablelist.Name = "lvTablelist";
            this.lvTablelist.Size = new System.Drawing.Size(386, 407);
            this.lvTablelist.TabIndex = 0;
            this.lvTablelist.UseCompatibleStateImageBehavior = false;
            this.lvTablelist.DoubleClick += new System.EventHandler(this.lvTablelist_DoubleClick);
            // 
            // ContextMenu1
            // 
            this.ContextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.mnu_PowerON,
            this.mnu_PowerOFF});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.Text = "刷新(&R)";
            this.MenuItem1.Click += new System.EventHandler(this.MenuItem1_Click);
            // 
            // mnu_PowerON
            // 
            this.mnu_PowerON.Index = 1;
            this.mnu_PowerON.Text = "开电源";
            // 
            // mnu_PowerOFF
            // 
            this.mnu_PowerOFF.Index = 2;
            this.mnu_PowerOFF.Text = "关电源";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "50.png");
            this.ImageList1.Images.SetKeyName(1, "54.png");
            this.ImageList1.Images.SetKeyName(2, "12.png");
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(615, 7);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 34);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "关闭(&C)";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbTableType,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "位置/类别：";
            // 
            // cbTableType
            // 
            this.cbTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableType.Name = "cbTableType";
            this.cbTableType.Size = new System.Drawing.Size(121, 25);
            this.cbTableType.SelectedIndexChanged += new System.EventHandler(this.cbTableType_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 407);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 54);
            this.panel1.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 407);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(515, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 407);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "人数：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "桌台信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "消费：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "开台时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "200年12月12日 12时12分12秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "100人";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "999999.99元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "餐台状况：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "正常";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "经过的时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "XX小时XX分XX秒";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "停止时间：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "200年12月12日 12时12分12秒";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "倒计时剩余时间：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "XX小时XX分XX秒";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 305);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(204, 102);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // frmTableStatus
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button1;
            this.ClientSize = new System.Drawing.Size(719, 486);
            this.Controls.Add(this.lvTablelist);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTableStatus";
            this.ShowInTaskbar = false;
            this.Text = "桌台使用状态";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closed += new System.EventHandler(this.frmTableStatus_Closed);
            this.Load += new System.EventHandler(this.frmTableStatus_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//刷新桌台列表视图
		private void RefreshTableListView(string TableTypeName)
		{
			DataTable tablelist;
			tablelist = rms_var.LoadTableList(TableTypeName);
			
			lvTablelist.Items.Clear();
			lvitems = new ListViewItem[tablelist.Rows.Count - 1 + 1];
			int ts;
			for (int i = 0; i <= tablelist.Rows.Count - 1; i++)
			{
				lvitems[i] = new ListViewItem();
                lvitems[i].Text = tablelist.Rows[i][0].ToString();
				ts = System.Convert.ToInt32(tablelist.Rows[i][2]);
				if (ts == 0) //空闲
				{
					lvitems[i].ImageIndex = 0;
				}
				else if (ts == 1) //使用
				{
					lvitems[i].ImageIndex = 1;
				}
				else if (ts == 2) //预订
				{
					lvitems[i].ImageIndex = 2;
				}
				
				lvTablelist.Items.Add(lvitems[i]);
			}
		}
		
		//显示输入单据窗口
		public void ShowInputBillForm1(string tableno)
		{
			if (rms_var.frmInputBill == null)
			{
				rms_var.frmInputBill = new InputBill();
				rms_var.frmInputBill.MdiParent = rms_var.mainfrm;
				rms_var.frmInputBill.Show();
				rms_var.frmInputBill.ShowTable(tableno);
			}
			else //已经打开单据输入窗口
			{
				if (rms_var.frmInputBill.WindowState != FormWindowState.Minimized)
				{
					rms_var.frmInputBill.BringToFront();
				}
				else
				{
					rms_var.frmInputBill.WindowState = FormWindowState.Maximized;
				}
				rms_var.frmInputBill.ShowTable(tableno);
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void frmTableStatus_Load(System.Object sender, System.EventArgs e)
		{
			//初始化主窗口,填充桌台类别列表
			DataTable tabletype;
			tabletype = rms_var.LoadTableType();
			for (int i = 0; i <= tabletype.Rows.Count - 1; i++)
			{
				cbTableType.Items.Add(tabletype.Rows[i]["Name"]);
			}
			cbTableType.Items.Add("全部");
			cbTableType.SelectedIndex = 0;
			//刷新桌台列表视图
			RefreshTableListView(cbTableType.Text);
		}
		
		private void cbTableType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			RefreshTableListView(cbTableType.Text);
		}
		
		private void frmTableStatus_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmTableST = null;
		}
		
		private void lvTablelist_DoubleClick(object sender, System.EventArgs e)
		{
			ShowInputBillForm1(lvTablelist.SelectedItems[0].Text);
		}
		
		private void MenuItem1_Click(System.Object sender, System.EventArgs e)
		{
			RefreshTableListView(cbTableType.Text);
		}
	}
	
}
