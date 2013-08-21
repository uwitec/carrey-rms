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
        private ListView lv_Category;
        private Panel panel1;
        private Splitter splitter1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Label lbl_StartTime;
        private Label label3;
        private Label lbl_number;
        private Label lbl_tableStatus;
        private Label label7;
        private ListView lv_DevExt;
        private ImageList il_Category;
        private Label lbl_maxnumber;
        private Label label4;
        private Label label5;
        private Label lbl_LowPay;
        private Label lbl_RoomPay;
        private Label label8;
        private Label lbl_price;
        private Label label9;
        private MenuItem mnu_ChangeStatus;
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbTableType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lv_Category = new System.Windows.Forms.ListView();
            this.il_Category = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_DevExt = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_RoomPay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_LowPay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_maxnumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tableStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.mnu_ChangeStatus = new System.Windows.Forms.MenuItem();
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
            this.lvTablelist.Location = new System.Drawing.Point(129, 0);
            this.lvTablelist.Name = "lvTablelist";
            this.lvTablelist.Size = new System.Drawing.Size(386, 432);
            this.lvTablelist.TabIndex = 0;
            this.lvTablelist.UseCompatibleStateImageBehavior = false;
            this.lvTablelist.SelectedIndexChanged += new System.EventHandler(this.lvTablelist_SelectedIndexChanged);
            this.lvTablelist.DoubleClick += new System.EventHandler(this.lvTablelist_DoubleClick);
            // 
            // ContextMenu1
            // 
            this.ContextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.mnu_PowerON,
            this.mnu_PowerOFF,
            this.mnu_ChangeStatus});
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
            this.ImageList1.Images.SetKeyName(3, "38.png");
            this.ImageList1.Images.SetKeyName(4, "49.png");
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
            this.toolStrip1.Visible = false;
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
            // lv_Category
            // 
            this.lv_Category.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_Category.HideSelection = false;
            this.lv_Category.LargeImageList = this.il_Category;
            this.lv_Category.Location = new System.Drawing.Point(0, 0);
            this.lv_Category.Name = "lv_Category";
            this.lv_Category.Size = new System.Drawing.Size(121, 432);
            this.lv_Category.TabIndex = 5;
            this.lv_Category.UseCompatibleStateImageBehavior = false;
            this.lv_Category.SelectedIndexChanged += new System.EventHandler(this.lv_Category_SelectedIndexChanged);
            // 
            // il_Category
            // 
            this.il_Category.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_Category.ImageStream")));
            this.il_Category.TransparentColor = System.Drawing.Color.Transparent;
            this.il_Category.Images.SetKeyName(0, "80.jpg");
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
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 432);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_DevExt);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(515, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 432);
            this.panel2.TabIndex = 8;
            // 
            // lv_DevExt
            // 
            this.lv_DevExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_DevExt.Location = new System.Drawing.Point(0, 249);
            this.lv_DevExt.Name = "lv_DevExt";
            this.lv_DevExt.Size = new System.Drawing.Size(204, 183);
            this.lv_DevExt.TabIndex = 2;
            this.lv_DevExt.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_price);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_RoomPay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_LowPay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_maxnumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_tableStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_number);
            this.groupBox1.Controls.Add(this.lbl_StartTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "桌台信息";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(85, 167);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(23, 12);
            this.lbl_price.TabIndex = 17;
            this.lbl_price.Text = "0元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "当前消费：";
            // 
            // lbl_RoomPay
            // 
            this.lbl_RoomPay.AutoSize = true;
            this.lbl_RoomPay.Location = new System.Drawing.Point(85, 140);
            this.lbl_RoomPay.Name = "lbl_RoomPay";
            this.lbl_RoomPay.Size = new System.Drawing.Size(23, 12);
            this.lbl_RoomPay.TabIndex = 15;
            this.lbl_RoomPay.Text = "0元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "附加费：";
            // 
            // lbl_LowPay
            // 
            this.lbl_LowPay.AutoSize = true;
            this.lbl_LowPay.Location = new System.Drawing.Point(85, 111);
            this.lbl_LowPay.Name = "lbl_LowPay";
            this.lbl_LowPay.Size = new System.Drawing.Size(23, 12);
            this.lbl_LowPay.TabIndex = 13;
            this.lbl_LowPay.Text = "0元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "最低消费：";
            // 
            // lbl_maxnumber
            // 
            this.lbl_maxnumber.AutoSize = true;
            this.lbl_maxnumber.Location = new System.Drawing.Point(85, 52);
            this.lbl_maxnumber.Name = "lbl_maxnumber";
            this.lbl_maxnumber.Size = new System.Drawing.Size(23, 12);
            this.lbl_maxnumber.TabIndex = 11;
            this.lbl_maxnumber.Text = "0人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "承载人数：";
            // 
            // lbl_tableStatus
            // 
            this.lbl_tableStatus.AutoSize = true;
            this.lbl_tableStatus.Location = new System.Drawing.Point(85, 27);
            this.lbl_tableStatus.Name = "lbl_tableStatus";
            this.lbl_tableStatus.Size = new System.Drawing.Size(29, 12);
            this.lbl_tableStatus.TabIndex = 7;
            this.lbl_tableStatus.Text = "正常";
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
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(85, 83);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(23, 12);
            this.lbl_number.TabIndex = 4;
            this.lbl_number.Text = "0人";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Location = new System.Drawing.Point(29, 223);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(17, 12);
            this.lbl_StartTime.TabIndex = 3;
            this.lbl_StartTime.Text = "无";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "开台时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前人数：";
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
            // mnu_ChangeStatus
            // 
            this.mnu_ChangeStatus.Index = 3;
            this.mnu_ChangeStatus.Text = "变更状态";
            this.mnu_ChangeStatus.Click += new System.EventHandler(this.mnu_ChangeStatus_Click);
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
            this.Controls.Add(this.lv_Category);
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
				else if (ts == 3) //脏台
				{
					lvitems[i].ImageIndex = 3;
				}
                else if (ts == 4) //停用
                {
                    lvitems[i].ImageIndex = 4;
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
            //cbTableType.Items.Add("全部");
            //cbTableType.SelectedIndex = 0;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = "全部";
            lvi.ImageIndex = 0;
            lv_Category.Items.Add(lvi);

			DataTable tabletype;
			tabletype = rms_var.LoadTableType();
			for (int i = 0; i <= tabletype.Rows.Count - 1; i++)
			{
                lvi = new ListViewItem();
                lvi.Text = tabletype.Rows[i]["Name"].ToString();
                lvi.ImageIndex = 0;
                lv_Category.Items.Add(lvi);
                //cbTableType.Items.Add(tabletype.Rows[i]["Name"]);
			}
            lv_Category.Items[0].Selected = true;
			//刷新桌台列表视图
            RefreshTable();
            //RefreshTableListView(cbTableType.Text);
		}
		
		private void cbTableType_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
            //RefreshTableListView(cbTableType.Text);
            RefreshTable();
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
            //RefreshTableListView(cbTableType.Text);
            RefreshTable();
		}

        private void lv_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        public void RefreshTable()
        {
            try
            {
                RefreshTableListView(lv_Category.SelectedItems[0].Text);
            }
            catch { }
        }

        private void lvTablelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tableno = lvTablelist.SelectedItems[0].Text;
                //获取桌台状态 0=空闲，1=使用，2=预定中,3=脏台，4=停用
                int status=rms_var.GetTableStatus(tableno);
                switch (status)
                {
                    case 0:
                        lbl_tableStatus.Text = "空闲";
                        break;
                    case 1:
                        lbl_tableStatus.Text = "使用中";
                        break;
                    case 2:
                        lbl_tableStatus.Text = "预定中";
                        break;
                    case 3:
                        lbl_tableStatus.Text = "脏台";
                        break;
                    case 4:
                        lbl_tableStatus.Text = "停用";
                        break;
                    default:
                        lbl_tableStatus.Text = "无此桌台";
                        break;

                }
                //当然就餐人数
                try
                {
                    lbl_number.Text = rms_var.GetOpenTablePsn(tableno).ToString() + "人";
                }
                catch { }
                //桌台最大载客量
                lbl_maxnumber.Text = rms_var.GetTableMaxPeopleNumber(tableno)+"人";
                //开台时间
                lbl_StartTime .Text= rms_var.GetTableOpenTime(tableno);
                //返回当前桌台所有金额
                lbl_price.Text = rms_var.GetTablePrice(tableno)+"元";

                //返回桌台最低消费金额
                lbl_LowPay.Text = rms_var.GetTableLowPay(tableno) + "元";

                //返回桌台包房/附加费
                lbl_RoomPay.Text = rms_var.GetTableRoomPay(tableno) + "元";
            }
            catch { }
        }

        private void mnu_ChangeStatus_Click(object sender, EventArgs e)
        {
            frmChangeTableStatus fts = new frmChangeTableStatus();
            if (fts.ShowDialog() == DialogResult.OK)
            {
                rms_var.ChangeTableStatus(lvTablelist.SelectedItems[0].Text, fts.GetStatus);
                RefreshTable();
            }
        }
	}
	
}
