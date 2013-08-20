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


namespace SysAdmin
{
	public class frmTableList : System.Windows.Forms.Form
	{
		
		private string CurrentTableLstSqlCode = "SELECT * FROM view_tableList";
		private string CurrentSqlWhereCode = "";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmTableList()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.DataGrid dgTableList;
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
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn14;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableList));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgTableList = new System.Windows.Forms.DataGrid();
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
            this.DataGridBoolColumn4 = new System.Windows.Forms.DataGridBoolColumn();
            this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn5 = new System.Windows.Forms.DataGridBoolColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTableList)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton9,
            this.ToolBarButton5,
            this.ToolBarButton4,
            this.ToolBarButton6,
            this.ToolBarButton11,
            this.ToolBarButton7});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(604, 54);
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
            // ToolBarButton9
            // 
            this.ToolBarButton9.Name = "ToolBarButton9";
            this.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton5
            // 
            this.ToolBarButton5.ImageIndex = 3;
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Text = "查询";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.ImageIndex = 4;
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Text = "打印";
            // 
            // ToolBarButton11
            // 
            this.ToolBarButton11.Name = "ToolBarButton11";
            this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 5;
            this.ToolBarButton7.Name = "ToolBarButton7";
            this.ToolBarButton7.Text = "关闭";
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
            // dgTableList
            // 
            this.dgTableList.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTableList.BackColor = System.Drawing.Color.GhostWhite;
            this.dgTableList.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgTableList.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgTableList.CaptionForeColor = System.Drawing.Color.White;
            this.dgTableList.DataMember = "";
            this.dgTableList.FlatMode = true;
            this.dgTableList.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgTableList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTableList.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgTableList.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgTableList.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgTableList.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgTableList.LinkColor = System.Drawing.Color.Teal;
            this.dgTableList.Location = new System.Drawing.Point(0, 56);
            this.dgTableList.Name = "dgTableList";
            this.dgTableList.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgTableList.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTableList.ReadOnly = true;
            this.dgTableList.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgTableList.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgTableList.Size = new System.Drawing.Size(604, 410);
            this.dgTableList.TabIndex = 4;
            this.dgTableList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgTableList.DoubleClick += new System.EventHandler(this.dgTableList_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgTableList;
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
            this.DataGridBoolColumn4,
            this.DataGridTextBoxColumn10,
            this.DataGridTextBoxColumn11,
            this.DataGridTextBoxColumn12,
            this.DataGridTextBoxColumn13,
            this.DataGridTextBoxColumn14,
            this.DataGridBoolColumn5});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "tablelist";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "桌台类别/位置";
            this.DataGridTextBoxColumn1.MappingName = "name";
            this.DataGridTextBoxColumn1.Width = 90;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "桌台号";
            this.DataGridTextBoxColumn2.MappingName = "tableno";
            this.DataGridTextBoxColumn2.Width = 90;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "桌台名称";
            this.DataGridTextBoxColumn3.MappingName = "tablename";
            this.DataGridTextBoxColumn3.Width = 110;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "最大载客数";
            this.DataGridTextBoxColumn4.MappingName = "peoplenumber";
            this.DataGridTextBoxColumn4.NullText = "0";
            this.DataGridTextBoxColumn4.Width = 90;
            // 
            // DataGridTextBoxColumn5
            // 
            this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn5.Format = "";
            this.DataGridTextBoxColumn5.FormatInfo = null;
            this.DataGridTextBoxColumn5.HeaderText = "最低消费额";
            this.DataGridTextBoxColumn5.MappingName = "lower_pay";
            this.DataGridTextBoxColumn5.Width = 90;
            // 
            // DataGridTextBoxColumn6
            // 
            this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn6.Format = "";
            this.DataGridTextBoxColumn6.FormatInfo = null;
            this.DataGridTextBoxColumn6.HeaderText = "附加费";
            this.DataGridTextBoxColumn6.MappingName = "addprice";
            this.DataGridTextBoxColumn6.Width = 90;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "收取服务费";
            this.DataGridBoolColumn1.MappingName = "server";
            this.DataGridBoolColumn1.NullText = "0";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 85;
            // 
            // DataGridTextBoxColumn7
            // 
            this.DataGridTextBoxColumn7.Format = "";
            this.DataGridTextBoxColumn7.FormatInfo = null;
            this.DataGridTextBoxColumn7.MappingName = "serverstate";
            this.DataGridTextBoxColumn7.Width = 0;
            // 
            // DataGridTextBoxColumn8
            // 
            this.DataGridTextBoxColumn8.Format = "";
            this.DataGridTextBoxColumn8.FormatInfo = null;
            this.DataGridTextBoxColumn8.MappingName = "server_pay";
            this.DataGridTextBoxColumn8.Width = 0;
            // 
            // DataGridBoolColumn4
            // 
            this.DataGridBoolColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn4.FalseValue = "0";
            this.DataGridBoolColumn4.HeaderText = "收取超时费";
            this.DataGridBoolColumn4.MappingName = "overtime";
            this.DataGridBoolColumn4.NullText = "0";
            this.DataGridBoolColumn4.TrueValue = "1";
            this.DataGridBoolColumn4.Width = 85;
            // 
            // DataGridTextBoxColumn10
            // 
            this.DataGridTextBoxColumn10.Format = "";
            this.DataGridTextBoxColumn10.FormatInfo = null;
            this.DataGridTextBoxColumn10.MappingName = "overtimenum";
            this.DataGridTextBoxColumn10.Width = 0;
            // 
            // DataGridTextBoxColumn11
            // 
            this.DataGridTextBoxColumn11.Format = "";
            this.DataGridTextBoxColumn11.FormatInfo = null;
            this.DataGridTextBoxColumn11.MappingName = "overtimetype";
            this.DataGridTextBoxColumn11.Width = 0;
            // 
            // DataGridTextBoxColumn12
            // 
            this.DataGridTextBoxColumn12.Format = "";
            this.DataGridTextBoxColumn12.FormatInfo = null;
            this.DataGridTextBoxColumn12.MappingName = "overtimestate";
            this.DataGridTextBoxColumn12.Width = 0;
            // 
            // DataGridTextBoxColumn13
            // 
            this.DataGridTextBoxColumn13.Format = "";
            this.DataGridTextBoxColumn13.FormatInfo = null;
            this.DataGridTextBoxColumn13.MappingName = "pertype";
            this.DataGridTextBoxColumn13.Width = 0;
            // 
            // DataGridTextBoxColumn14
            // 
            this.DataGridTextBoxColumn14.Format = "";
            this.DataGridTextBoxColumn14.FormatInfo = null;
            this.DataGridTextBoxColumn14.MappingName = "pertypeprice";
            this.DataGridTextBoxColumn14.Width = 0;
            // 
            // DataGridBoolColumn5
            // 
            this.DataGridBoolColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn5.FalseValue = "0";
            this.DataGridBoolColumn5.HeaderText = "使用状态";
            this.DataGridBoolColumn5.MappingName = "status";
            this.DataGridBoolColumn5.TrueValue = "1";
            this.DataGridBoolColumn5.Width = 85;
            // 
            // frmTableList
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(604, 466);
            this.Controls.Add(this.dgTableList);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTableList";
            this.Text = "桌台管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTableList_Load);
            this.Closed += new System.EventHandler(this.frmTableList_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgTableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回菜品列表
		private void LoadTableList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = CurrentTableLstSqlCode + CurrentSqlWhereCode + " order by tableno";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "TableList");
				dgTableList.DataSource = null;
				dgTableList.DataSource = dbDS;
				dgTableList.DataMember = "TableList";
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
		
		//编辑桌台信息
		private void EditTableInfo()
		{
			frmEditTable EditTable = new frmEditTable();
			EditTable.GetTableTypeList();
			
			//一般信息
			EditTable.ComboBox1.Text = dgTableList[dgTableList.CurrentRowIndex, 0].ToString(); //类别
			EditTable.TextBox1.Text = dgTableList[dgTableList.CurrentRowIndex, 1].ToString(); //桌台编码
			EditTable.TextBox2.Text = dgTableList[dgTableList.CurrentRowIndex, 2].ToString(); //桌台名称
			EditTable.NumericUpDown4.Text =dgTableList[dgTableList.CurrentRowIndex, 3].ToString(); //最大载客数
			EditTable.NumericUpDown5.Text =dgTableList[dgTableList.CurrentRowIndex, 4].ToString(); //最低消费
			EditTable.NumericUpDown6.Text =dgTableList[dgTableList.CurrentRowIndex, 5].ToString(); //房费/附加费
			
			//服务费
            EditTable.CheckBox2.Checked = dgTableList[dgTableList.CurrentRowIndex, 6].ToString() == "1" ? true : false; //是否收取服务费
			if (EditTable.CheckBox2.Checked)
			{
				EditTable.RadioButton1.Enabled = true;
				EditTable.RadioButton2.Enabled = true;
				//检测服务费收取方式
				//服务费收取方式
				if (dgTableList[dgTableList.CurrentRowIndex, 7].ToString() == "0") //固定服务费
				{
					EditTable.RadioButton1.Checked = true;
					EditTable.RadioButton2.Checked = false;
				}
				else
				{
					EditTable.RadioButton1.Checked = false;
					EditTable.RadioButton2.Checked = true;
				}
				if (EditTable.RadioButton1.Checked)
				{
					EditTable.NumericUpDown7.Enabled = true;
					EditTable.NumericUpDown8.Enabled = false;
					EditTable.NumericUpDown7.Text = dgTableList[dgTableList.CurrentRowIndex, 8].ToString();
				}
				else
				{
					EditTable.NumericUpDown7.Enabled = false;
					EditTable.NumericUpDown8.Enabled = true;
					EditTable.NumericUpDown8.Text = dgTableList[dgTableList.CurrentRowIndex, 8].ToString();
				}
			}
			else
			{
				EditTable.RadioButton1.Enabled = false;
				EditTable.RadioButton2.Enabled = false;
				EditTable.NumericUpDown7.Enabled = false;
				EditTable.NumericUpDown8.Enabled = false;
			}
			
			//超时费
            EditTable.CheckBox1.Checked = dgTableList[dgTableList.CurrentRowIndex, 9].ToString() == "1" ? true : false; //是否收取超时费
			if (EditTable.CheckBox1.Checked)
			{
				EditTable.NumericUpDown1.Enabled = true;
				EditTable.ComboBox2.Enabled = true;
				//检测超时费收取方式
				//超时费收取方式
				EditTable.NumericUpDown1.Text = dgTableList[dgTableList.CurrentRowIndex, 10].ToString();
				if (Convert.ToInt32(dgTableList[dgTableList.CurrentRowIndex, 11].ToString()) == 0) //分钟
				{
					EditTable.ComboBox2.Text = "分钟";
				}
				else if (Convert.ToInt32(dgTableList[dgTableList.CurrentRowIndex, 11].ToString()) == 1) //小时
				{
					EditTable.ComboBox2.Text = "小时";
				}
				
				if (dgTableList[dgTableList.CurrentRowIndex, 12].ToString() == "0") //按超时收取
				{
					EditTable.RadioButton3.Checked = true;
					EditTable.RadioButton4.Checked = false;
				}
				else
				{
					EditTable.RadioButton3.Checked = false;
					EditTable.RadioButton4.Checked = true;
				}
				if (EditTable.RadioButton3.Checked)
				{
					EditTable.ComboBox3.Enabled = true;
					
					if (Convert.ToInt32(dgTableList[dgTableList.CurrentRowIndex, 13].ToString()) == 0) //分钟
					{
						EditTable.ComboBox3.Text = "分钟";
					}
					else if (Convert.ToInt32(dgTableList[dgTableList.CurrentRowIndex, 13].ToString()) == 1) //小时
					{
						EditTable.ComboBox3.Text = "小时";
					}
					
					EditTable.NumericUpDown2.Enabled = true;
					EditTable.NumericUpDown2.Text = dgTableList[dgTableList.CurrentRowIndex, 14].ToString();
					EditTable.ComboBox4.Enabled = false;
					EditTable.NumericUpDown3.Enabled = false;
				}
				else
				{
					EditTable.ComboBox4.Enabled = true;
					
					if (Convert.ToInt32(dgTableList[dgTableList.CurrentRowIndex, 14].ToString()) == 1) //分钟
					{
						EditTable.ComboBox3.Text = "分钟";
					}
					else if (Convert.ToInt32(dgTableList[dgTableList.CurrentRowIndex, 14].ToString()) == 1) //小时
					{
						EditTable.ComboBox3.Text = "小时";
					}
					
					EditTable.NumericUpDown3.Enabled = true;
					EditTable.NumericUpDown3.Text = dgTableList[dgTableList.CurrentRowIndex, 14].ToString();
					EditTable.ComboBox3.Enabled = false;
					EditTable.NumericUpDown2.Enabled = false;
				}
			}
			else
			{
				EditTable.NumericUpDown1.Enabled = false;
				EditTable.NumericUpDown2.Enabled = false;
				EditTable.NumericUpDown3.Enabled = false;
				EditTable.ComboBox2.Enabled = false;
				EditTable.ComboBox3.Enabled = false;
				EditTable.ComboBox4.Enabled = false;
				EditTable.RadioButton3.Enabled = false;
				EditTable.RadioButton4.Enabled = false;
			}
			//此处添加开关和呼叫器信息


			EditTable.frmMode = 2; //修改记录
			EditTable.Text = "修改桌台信息";
			EditTable.OldTablecode = dgTableList[dgTableList.CurrentRowIndex, 1].ToString(); //保存原始编号
            EditTable.oldTablename = dgTableList[dgTableList.CurrentRowIndex, 2].ToString(); //保存原始名称
			EditTable.ShowDialog();
			if (EditTable.DialogResult == DialogResult.OK)
			{
				LoadTableList();
			}
		}
		
		//删除 桌台
		private bool DelTable(string tableno)
		{
			if (rms_var.GetTableStatus(tableno) == 0) //桌台空闲
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					
					selectCMD.Connection = conn;
					selectCMD.CommandText = "delete from tablestatus where tableno='" + tableno + "'";
					selectCMD.CommandTimeout = 30;
					conn.Open();
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
			else
			{
				MessageBox.Show("桌台不是空闲状态，您不能删除该桌台。");
			}
			return false;
		}
		
		//查询 桌台
		private void SearchTable(string TableType, string Tableno, string Tablename)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				CurrentSqlWhereCode = " where " + "name like '" + "%" + TableType + "%'" + " and " + "Tableno like '" + "%" + Tableno + "%'" + " and " + "Tablename like '" + "%" + Tablename + "%'";
				
				selectCMD.CommandText = CurrentTableLstSqlCode + CurrentSqlWhereCode;
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "TableList");
				dgTableList.DataSource = null;
				dgTableList.DataSource = dbDS;
				dgTableList.DataMember = "TableList";
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
		
		private void frmTableList_Load(System.Object sender, System.EventArgs e)
		{
			LoadTableList();
		}
		
		private void frmTableList_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmTablelst = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditTable EditTable_1 = new frmEditTable();
					EditTable_1.GetTableTypeList();
					
					EditTable_1.frmMode = 1; //添加记录
					EditTable_1.Text = "添加桌台";
					
					EditTable_1.ShowDialog();
					if (EditTable_1.DialogResult == DialogResult.OK)
					{
						LoadTableList();
					}
					break;
				case 1: //修改数据
					if (! (dgTableList.CurrentRowIndex < 0))
					{
                        if (rms_var.GetTableStatus(dgTableList[dgTableList.CurrentRowIndex, 1].ToString()) == 0) //桌台空闲
						{
							EditTableInfo();
						}
						else
						{
							MessageBox.Show("桌台不是空闲状态，您不能编辑该桌台。");
						}
					}
					break;
				case 2: //删除当前数据
					if (! (dgTableList.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgTableList[dgTableList.CurrentRowIndex, 0].ToString().Trim() + " 的菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelTable(dgTableList[dgTableList.CurrentRowIndex, 0].ToString()))
							{
								LoadTableList();
							}
						}
					}
					break;
				case 4: //查询数据
					frmEditTable EditTable = new frmEditTable();
					EditTable.GetTableTypeList();
					
					EditTable.frmMode = 3; //查询数据
					EditTable.Text = "查询桌台信息";
					
					EditTable.ShowDialog();
					if (EditTable.DialogResult == DialogResult.OK)
					{
						SearchTable(EditTable.ComboBox1.Text, EditTable.TextBox1.Text, EditTable.TextBox2.Text);
					}
					break;
				case 6: //打印
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentTableLstSqlCode))
						{
							MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
						}
					}
					break;
				case 8: //关闭
					this.Close();
					break;
			}
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.table_cr == null)
			{
				report_var.table_cr = new ReportDocument();
			}
			else
			{
				report_var.table_cr.Close();
				report_var.table_cr = null;
				report_var.table_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.table_rpt_filename))
			{
				report_var.table_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.table_rpt_filename, sql, "view_tableList");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.table_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.table_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.table_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
		
		private void dgTableList_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgTableList.CurrentRowIndex < 0))
			{
                if (rms_var.GetTableStatus(dgTableList[dgTableList.CurrentRowIndex, 1].ToString()) == 0) //桌台空闲
				{
					EditTableInfo();
				}
				else
				{
					MessageBox.Show("桌台不是空闲状态，您不能编辑该桌台。");
				}
			}
		}
	}
	
}
