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
	public class frmFoodList : System.Windows.Forms.Form
	{
		
		private string CurrentFoodLstSqlCode = "SELECT * FROM view_FoodList";
		private string CurrentSqlWhereCode = "";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmFoodList()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ToolBarButton ToolBarButton13;
		internal System.Windows.Forms.ToolBarButton ToolBarButton14;
		internal System.Windows.Forms.DataGrid dgFoodList;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn11;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn14;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn2;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn3;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton15;
		internal System.Windows.Forms.ToolBarButton ToolBarButton16;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmFoodList_Load);
			base.Closed += new System.EventHandler(frmFoodList_Closed);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmFoodList));
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgFoodList = new System.Windows.Forms.DataGrid();
			this.dgFoodList.DoubleClick += new System.EventHandler(this.dgFoodList_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn4 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridBoolColumn3 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn5 = new System.Windows.Forms.DataGridBoolColumn();
			((System.ComponentModel.ISupportInitialize) this.dgFoodList).BeginInit();
			this.SuspendLayout();
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton4, this.ToolBarButton9, this.ToolBarButton10, this.ToolBarButton7, this.ToolBarButton5, this.ToolBarButton6, this.ToolBarButton15, this.ToolBarButton16, this.ToolBarButton8, this.ToolBarButton12, this.ToolBarButton11, this.ToolBarButton14, this.ToolBarButton13});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(724, 55);
			this.ToolBar1.TabIndex = 1;
			//
			//ToolBarButton1
			//
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Text = "添加";
			//
			//ToolBarButton2
			//
			this.ToolBarButton2.ImageIndex = 1;
			this.ToolBarButton2.Text = "修改";
			//
			//ToolBarButton3
			//
			this.ToolBarButton3.ImageIndex = 2;
			this.ToolBarButton3.Text = "删除";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton9
			//
			this.ToolBarButton9.ImageIndex = 3;
			this.ToolBarButton9.Text = "查询";
			//
			//ToolBarButton10
			//
			this.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 4;
			this.ToolBarButton7.Text = "做法";
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 5;
			this.ToolBarButton5.Text = "口味";
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton15
			//
			this.ToolBarButton15.ImageIndex = 6;
			this.ToolBarButton15.Text = "成本卡";
			//
			//ToolBarButton16
			//
			this.ToolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton8
			//
			this.ToolBarButton8.ImageIndex = 7;
			this.ToolBarButton8.Text = "调价";
			//
			//ToolBarButton12
			//
			this.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton11
			//
			this.ToolBarButton11.ImageIndex = 9;
			this.ToolBarButton11.Text = "打印";
			//
			//ToolBarButton14
			//
			this.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton13
			//
			this.ToolBarButton13.ImageIndex = 8;
			this.ToolBarButton13.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//dgFoodList
			//
			this.dgFoodList.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodList.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgFoodList.BackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodList.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgFoodList.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgFoodList.CaptionForeColor = System.Drawing.Color.White;
			this.dgFoodList.DataMember = "";
			this.dgFoodList.FlatMode = true;
			this.dgFoodList.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgFoodList.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgFoodList.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgFoodList.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgFoodList.LinkColor = System.Drawing.Color.Teal;
			this.dgFoodList.Location = new System.Drawing.Point(0, 56);
			this.dgFoodList.Name = "dgFoodList";
			this.dgFoodList.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgFoodList.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.ReadOnly = true;
			this.dgFoodList.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgFoodList.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgFoodList.Size = new System.Drawing.Size(724, 477);
			this.dgFoodList.TabIndex = 2;
			this.dgFoodList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgFoodList;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn7, this.DataGridTextBoxColumn8, this.DataGridBoolColumn1, this.DataGridTextBoxColumn11, this.DataGridBoolColumn2, this.DataGridTextBoxColumn13, this.DataGridTextBoxColumn14, this.DataGridBoolColumn4, this.DataGridBoolColumn3, this.DataGridTextBoxColumn9, this.DataGridBoolColumn5});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "foodlist";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "菜品编码";
			this.DataGridTextBoxColumn1.MappingName = "foodcode";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "菜品名称";
			this.DataGridTextBoxColumn2.MappingName = "foodname";
			this.DataGridTextBoxColumn2.Width = 75;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "菜品类别";
			this.DataGridTextBoxColumn3.MappingName = "typename";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "单位";
			this.DataGridTextBoxColumn4.MappingName = "unit";
			this.DataGridTextBoxColumn4.Width = 75;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "归属部门";
			this.DataGridTextBoxColumn5.MappingName = "deptname";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "单价";
			this.DataGridTextBoxColumn6.MappingName = "price";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "成本价";
			this.DataGridTextBoxColumn7.MappingName = "cost";
			this.DataGridTextBoxColumn7.Width = 75;
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "提成";
			this.DataGridTextBoxColumn8.MappingName = "deduct";
			this.DataGridTextBoxColumn8.Width = 75;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "特价菜";
			this.DataGridBoolColumn1.MappingName = "specialfood";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 75;
			//
			//DataGridTextBoxColumn11
			//
			this.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn11.Format = "";
			this.DataGridTextBoxColumn11.FormatInfo = null;
			this.DataGridTextBoxColumn11.HeaderText = "特价价格";
			this.DataGridTextBoxColumn11.MappingName = "specialprice";
			this.DataGridTextBoxColumn11.Width = 75;
			//
			//DataGridBoolColumn2
			//
			this.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn2.FalseValue = "0";
			this.DataGridBoolColumn2.HeaderText = "时价菜";
			this.DataGridBoolColumn2.MappingName = "currentfood";
			this.DataGridBoolColumn2.NullValue = resources.GetObject("DataGridBoolColumn2.NullValue");
			this.DataGridBoolColumn2.TrueValue = "1";
			this.DataGridBoolColumn2.Width = 75;
			//
			//DataGridTextBoxColumn13
			//
			this.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn13.Format = "";
			this.DataGridTextBoxColumn13.FormatInfo = null;
			this.DataGridTextBoxColumn13.HeaderText = "时价价格";
			this.DataGridTextBoxColumn13.MappingName = "currentprice";
			this.DataGridTextBoxColumn13.Width = 75;
			//
			//DataGridTextBoxColumn14
			//
			this.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn14.Format = "";
			this.DataGridTextBoxColumn14.FormatInfo = null;
			this.DataGridTextBoxColumn14.HeaderText = "拼音码";
			this.DataGridTextBoxColumn14.MappingName = "spell";
			this.DataGridTextBoxColumn14.Width = 75;
			//
			//DataGridBoolColumn4
			//
			this.DataGridBoolColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn4.FalseValue = "0";
			this.DataGridBoolColumn4.HeaderText = "不优惠";
			this.DataGridBoolColumn4.MappingName = "nodiscount";
			this.DataGridBoolColumn4.NullValue = resources.GetObject("DataGridBoolColumn4.NullValue");
			this.DataGridBoolColumn4.TrueValue = "1";
			this.DataGridBoolColumn4.Width = 75;
			//
			//DataGridBoolColumn3
			//
			this.DataGridBoolColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn3.FalseValue = "0";
			this.DataGridBoolColumn3.HeaderText = "暂不出售";
			this.DataGridBoolColumn3.MappingName = "disabled";
			this.DataGridBoolColumn3.NullValue = resources.GetObject("DataGridBoolColumn3.NullValue");
			this.DataGridBoolColumn3.TrueValue = "1";
			this.DataGridBoolColumn3.Width = 75;
			//
			//DataGridTextBoxColumn9
			//
			this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn9.Format = "";
			this.DataGridTextBoxColumn9.FormatInfo = null;
			this.DataGridTextBoxColumn9.HeaderText = "剩余数量";
			this.DataGridTextBoxColumn9.MappingName = "remain";
			this.DataGridTextBoxColumn9.NullText = "";
			this.DataGridTextBoxColumn9.Width = 75;
			//
			//DataGridBoolColumn5
			//
			this.DataGridBoolColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn5.FalseValue = "0";
			this.DataGridBoolColumn5.HeaderText = "前台定制";
			this.DataGridBoolColumn5.MappingName = "isunicode";
			this.DataGridBoolColumn5.NullValue = resources.GetObject("DataGridBoolColumn5.NullValue");
			this.DataGridBoolColumn5.TrueValue = "1";
			this.DataGridBoolColumn5.Width = 75;
			//
			//frmFoodList
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(724, 533);
			this.Controls.Add(this.dgFoodList);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmFoodList";
			this.Text = "菜品列表";
			((System.ComponentModel.ISupportInitialize) this.dgFoodList).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回菜品列表
		private void LoadFoodList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = CurrentFoodLstSqlCode + CurrentSqlWhereCode + " order by foodcode";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
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
		
		//编辑菜品信息
		private void EditFoodInfo()
		{
			frmEditFood editfood = new frmEditFood();
			editfood.GetFoodTypeList();
			editfood.ComboBox1.Text = dgFoodList[dgFoodList.CurrentRowIndex, 2].ToString(); //类别
			editfood.TextBox1.Text = dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(); //编码
            editfood.TextBox2.Text = dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString(); //菜品名称
			editfood.TextBox3.Text = dgFoodList[dgFoodList.CurrentRowIndex, 12].ToString(); //拼音码
			editfood.ComboBox2.Text = dgFoodList[dgFoodList.CurrentRowIndex, 3].ToString(); //单位
            editfood.NumericUpDown1.Text = dgFoodList[dgFoodList.CurrentRowIndex, 5].ToString(); //单价
            editfood.NumericUpDown5.Text = dgFoodList[dgFoodList.CurrentRowIndex, 6].ToString(); //成本价
            editfood.NumericUpDown2.Text = dgFoodList[dgFoodList.CurrentRowIndex, 7].ToString(); //提成
			
			editfood.CheckBox3.Checked = dgFoodList[dgFoodList.CurrentRowIndex, 8].ToString()=="1"?true:false; //是否为特价菜
            editfood.CheckBox4.Checked = dgFoodList[dgFoodList.CurrentRowIndex, 10].ToString() == "1" ? true : false; //是否为时价菜
            editfood.CheckBox1.Checked = dgFoodList[dgFoodList.CurrentRowIndex, 13].ToString() == "1" ? true : false; //不优惠
            editfood.CheckBox2.Checked = dgFoodList[dgFoodList.CurrentRowIndex, 14].ToString() == "1" ? true : false; //不出售
            editfood.NumericUpDown6.Text = dgFoodList[dgFoodList.CurrentRowIndex, 15].ToString(); //剩余数量
            editfood.CheckBox5.Checked = dgFoodList[dgFoodList.CurrentRowIndex, 16].ToString() == "1" ? true : false; //前台定制菜品
			
			if (editfood.CheckBox3.Checked)
			{
				editfood.NumericUpDown3.Text = dgFoodList[dgFoodList.CurrentRowIndex, 9].ToString(); //特价价格
				editfood.NumericUpDown3.Enabled = true;
			}
			
			if (editfood.CheckBox4.Checked)
			{
				editfood.NumericUpDown4.Text = dgFoodList[dgFoodList.CurrentRowIndex, 11].ToString(); //时价价格
				editfood.NumericUpDown4.Enabled = true;
			}
			
			editfood.frmMode = 2; //修改记录
			editfood.Text = "修改菜品信息";
			editfood.OldFoodCode = dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString(); //保存原始编号
			editfood.OldFoodName = dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString(); //保存原始名称
			//检测是否直接修改成本价
			
			
			editfood.ShowDialog();
			if (editfood.DialogResult == DialogResult.OK)
			{
				LoadFoodList();
			}
		}
		
		//删除 菜品
		private bool DelFood(string foodcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from foodlist where foodcode='" + foodcode + "'";
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
		
		//查询 菜品信息
		private void SearchFood(string foodcode, string foodtypename, string foodname, string foodPym, bool specialfood, bool currentfood, bool nodiscount, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				CurrentSqlWhereCode = " where " + "foodcode like '" + "%" + foodcode + "%'" + " and " + "typename like '" + "%" + foodtypename + "%'" + " and " + "foodname like '" + "%" + foodname + "%'" + " and " + "spell like '" + "%" + foodPym + "%'" + " and " + "specialfood like '" + "%" + Convert.ToInt32(specialfood).ToString() + "%'" + " and " + "currentfood like '" + "%" + Convert.ToInt32(currentfood).ToString() + "%'" + " and " + "nodiscount like '" + "%" + Convert.ToInt32(nodiscount).ToString() + "%'" + " and " + "disabled like '" + "%" +Convert.ToInt32(disabled).ToString() + "%'";
				
				selectCMD.CommandText = CurrentFoodLstSqlCode + CurrentSqlWhereCode;
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
		
		//更新菜品价格
		private bool UpdateFoodsPrice(string direct, double value)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				if (direct == "+") //上调
				{
					selectCMD.CommandText ="update foodlist set price=price+price*" + (value / 100).ToString() + CurrentSqlWhereCode;
				}
				else if (direct == "-")
				{
					selectCMD.CommandText ="update foodlist set price=price-price*" + (value / 100).ToString() + CurrentSqlWhereCode;
				}
				
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
		
		private void frmFoodList_Load(System.Object sender, System.EventArgs e)
		{
			LoadFoodList();
		}
		
		private void frmFoodList_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmfoodlst = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditFood EditFood_1 = new frmEditFood();
					EditFood_1.GetFoodTypeList();
					
					EditFood_1.frmMode = 1; //添加记录
					EditFood_1.Text = "添加菜品信息";
					
					EditFood_1.ShowDialog();
					if (EditFood_1.DialogResult == DialogResult.OK)
					{
						LoadFoodList();
					}
					break;
				case 1: //修改数据
					if (! (dgFoodList.CurrentRowIndex < 0))
					{
						EditFoodInfo();
					}
					break;
				case 2: //删除当前数据
					if (! (dgFoodList.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString().Trim() + " 的菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//'删除操作
							if (DelFood(dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString()))
							{
								LoadFoodList();
							}
						}
					}
					break;
				case 4: //查询数据
					frmEditFood EditFood = new frmEditFood();
					EditFood.GetFoodTypeList();
					
					EditFood.frmMode = 3; //查询数据
					EditFood.Text = "查询菜品信息";
					
					EditFood.ShowDialog();
					if (EditFood.DialogResult == DialogResult.OK)
					{
						SearchFood(EditFood.TextBox1.Text, EditFood.ComboBox1.Text, EditFood.TextBox2.Text, EditFood.TextBox3.Text, EditFood.CheckBox3.Checked, EditFood.CheckBox4.Checked, EditFood.CheckBox1.Checked, EditFood.CheckBox2.Checked);
					}
					break;
				case 6: //做法
					if (! (dgFoodList.CurrentRowIndex < 0))
					{
						frmEditFoodOperandi frmfoodop = new frmEditFoodOperandi();
						frmfoodop.frmMode = 2; //2=编辑当前菜品做法
                        frmfoodop.foodcode = dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString();
                        frmfoodop.Label4.Text = "菜品名称：" + "\r\n" + dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString();
						frmfoodop.ShowDialog();
					}
					break;
				case 7: //口味
					if (! (dgFoodList.CurrentRowIndex < 0))
					{
						frmEditFoodTaste frmfoodtst = new frmEditFoodTaste();
						frmfoodtst.frmMode = 2; //2=编辑当前菜品口味
						frmfoodtst.foodcode = dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString();
                        frmfoodtst.Label4.Text = "菜品名称：" + "\r\n" + dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString();
						frmfoodtst.ShowDialog();
					}
					break;
				case 9: //成本卡
					if (! (dgFoodList.CurrentRowIndex < 0))
					{
						frmFoodCost frmfoodcst = new frmFoodCost();
						frmfoodcst.foodcode = dgFoodList[dgFoodList.CurrentRowIndex, 0].ToString();
                        frmfoodcst.Label1.Text = "菜品名称：" + dgFoodList[dgFoodList.CurrentRowIndex, 1].ToString();
						frmfoodcst.ShowDialog();
					}
					break;
				case 11: //调价
					if (! (dgFoodList.CurrentRowIndex < 0))
					{
						frmAdjustFoodPrice frmadjfoodprice = new frmAdjustFoodPrice();
						frmadjfoodprice.ShowDialog();
						if (frmadjfoodprice.DialogResult == DialogResult.OK)
						{
							if (frmadjfoodprice.RadioButton1.Checked) //上调
							{
								if (UpdateFoodsPrice("+", (double) frmadjfoodprice.NumericUpDown1.Value))
								{
									LoadFoodList();
								}
							}
							else
							{
								if (UpdateFoodsPrice("-", (double) frmadjfoodprice.NumericUpDown1.Value))
								{
									LoadFoodList();
								}
							}
						}
					}
					break;
				case 13: //打印
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentFoodLstSqlCode))
						{
							MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
						}
					}
					break;
				case 15: //关闭
					this.Close();
					break;
			}
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.food_cr == null)
			{
				report_var.food_cr = new ReportDocument();
			}
			else
			{
				report_var.food_cr.Close();
				report_var.food_cr = null;
				report_var.food_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.food_rpt_filename))
			{
				report_var.food_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.food_rpt_filename, sql, "view_FoodList");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.food_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.food_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.food_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
		
		private void dgFoodList_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgFoodList.CurrentRowIndex < 0))
			{
				EditFoodInfo();
			}
		}
		
	}
	
}
