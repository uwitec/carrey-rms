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
	public class frmCustomer : System.Windows.Forms.Form
	{
		
		private string CurrentCustLstSqlCode = "SELECT * FROM view_customer";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCustomer()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton9;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.DataGrid dgCust;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn13;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmCustomer_Load);
			base.Closed += new System.EventHandler(frmCustomer_Closed);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCustomer));
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgCust = new System.Windows.Forms.DataGrid();
			this.dgCust.DoubleClick += new System.EventHandler(this.dgCust_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn3 = new System.Windows.Forms.DataGridBoolColumn();
			((System.ComponentModel.ISupportInitialize) this.dgCust).BeginInit();
			this.SuspendLayout();
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton9, this.ToolBarButton5, this.ToolBarButton4, this.ToolBarButton6, this.ToolBarButton12, this.ToolBarButton10, this.ToolBarButton11, this.ToolBarButton7});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(579, 55);
			this.ToolBar1.TabIndex = 2;
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
			//ToolBarButton9
			//
			this.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 3;
			this.ToolBarButton5.Text = "查询";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.ImageIndex = 4;
			this.ToolBarButton6.Text = "打印";
			//
			//ToolBarButton12
			//
			this.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton10
			//
			this.ToolBarButton10.ImageIndex = 5;
			this.ToolBarButton10.Text = "会员卡";
			//
			//ToolBarButton11
			//
			this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 6;
			this.ToolBarButton7.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//dgCust
			//
			this.dgCust.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgCust.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgCust.BackColor = System.Drawing.Color.GhostWhite;
			this.dgCust.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgCust.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgCust.CaptionForeColor = System.Drawing.Color.White;
			this.dgCust.DataMember = "";
			this.dgCust.FlatMode = true;
			this.dgCust.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgCust.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCust.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgCust.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgCust.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgCust.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgCust.LinkColor = System.Drawing.Color.Teal;
			this.dgCust.Location = new System.Drawing.Point(0, 56);
			this.dgCust.Name = "dgCust";
			this.dgCust.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgCust.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCust.ReadOnly = true;
			this.dgCust.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgCust.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgCust.Size = new System.Drawing.Size(579, 369);
			this.dgCust.TabIndex = 3;
			this.dgCust.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgCust;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridBoolColumn1, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn8, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn7, this.DataGridTextBoxColumn9, this.DataGridBoolColumn2, this.DataGridTextBoxColumn10, this.DataGridTextBoxColumn12, this.DataGridTextBoxColumn13, this.DataGridBoolColumn3});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "customer";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "客户编码";
			this.DataGridTextBoxColumn1.MappingName = "customercode";
			this.DataGridTextBoxColumn1.NullText = "";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "客户名称";
			this.DataGridTextBoxColumn2.MappingName = "customername";
			this.DataGridTextBoxColumn2.NullText = "";
			this.DataGridTextBoxColumn2.Width = 75;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "会员";
			this.DataGridBoolColumn1.MappingName = "isclubmember";
			this.DataGridBoolColumn1.NullText = "";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 75;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "身份证号码";
			this.DataGridTextBoxColumn3.MappingName = "idcardno";
			this.DataGridTextBoxColumn3.NullText = "";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "个人电话";
			this.DataGridTextBoxColumn4.MappingName = "phonenumber1";
			this.DataGridTextBoxColumn4.NullText = "";
			this.DataGridTextBoxColumn4.Width = 75;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "单位名称";
			this.DataGridTextBoxColumn5.MappingName = "company";
			this.DataGridTextBoxColumn5.NullText = "";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "单位地址";
			this.DataGridTextBoxColumn8.MappingName = "address1";
			this.DataGridTextBoxColumn8.NullText = "";
			this.DataGridTextBoxColumn8.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "单位电话";
			this.DataGridTextBoxColumn6.MappingName = "phonenumber2";
			this.DataGridTextBoxColumn6.NullText = "";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "联系人";
			this.DataGridTextBoxColumn7.MappingName = "contacter";
			this.DataGridTextBoxColumn7.NullText = "";
			this.DataGridTextBoxColumn7.Width = 75;
			//
			//DataGridTextBoxColumn9
			//
			this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn9.Format = "";
			this.DataGridTextBoxColumn9.FormatInfo = null;
			this.DataGridTextBoxColumn9.HeaderText = "客户类别";
			this.DataGridTextBoxColumn9.MappingName = "typename";
			this.DataGridTextBoxColumn9.NullText = "";
			this.DataGridTextBoxColumn9.Width = 75;
			//
			//DataGridBoolColumn2
			//
			this.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn2.FalseValue = "0";
			this.DataGridBoolColumn2.HeaderText = "允许签单";
			this.DataGridBoolColumn2.MappingName = "signed";
			this.DataGridBoolColumn2.NullText = "";
			this.DataGridBoolColumn2.NullValue = resources.GetObject("DataGridBoolColumn2.NullValue");
			this.DataGridBoolColumn2.TrueValue = "1";
			this.DataGridBoolColumn2.Width = 75;
			//
			//DataGridTextBoxColumn10
			//
			this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn10.Format = "";
			this.DataGridTextBoxColumn10.FormatInfo = null;
			this.DataGridTextBoxColumn10.HeaderText = "签单限额";
			this.DataGridTextBoxColumn10.MappingName = "signupcost";
			this.DataGridTextBoxColumn10.NullText = "";
			this.DataGridTextBoxColumn10.Width = 75;
			//
			//DataGridTextBoxColumn12
			//
			this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn12.Format = "";
			this.DataGridTextBoxColumn12.FormatInfo = null;
			this.DataGridTextBoxColumn12.HeaderText = "累计消费";
			this.DataGridTextBoxColumn12.MappingName = "totalcost";
			this.DataGridTextBoxColumn12.NullText = "";
			this.DataGridTextBoxColumn12.Width = 75;
			//
			//DataGridTextBoxColumn13
			//
			this.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn13.Format = "";
			this.DataGridTextBoxColumn13.FormatInfo = null;
			this.DataGridTextBoxColumn13.HeaderText = "备注";
			this.DataGridTextBoxColumn13.MappingName = "note";
			this.DataGridTextBoxColumn13.NullText = "";
			this.DataGridTextBoxColumn13.Width = 75;
			//
			//DataGridBoolColumn3
			//
			this.DataGridBoolColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn3.FalseValue = "0";
			this.DataGridBoolColumn3.HeaderText = "暂停使用";
			this.DataGridBoolColumn3.MappingName = "disabled";
			this.DataGridBoolColumn3.NullText = "";
			this.DataGridBoolColumn3.NullValue = resources.GetObject("DataGridBoolColumn3.NullValue");
			this.DataGridBoolColumn3.TrueValue = "1";
			this.DataGridBoolColumn3.Width = 75;
			//
			//frmCustomer
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(579, 425);
			this.Controls.Add(this.dgCust);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmCustomer";
			this.Text = "客户/会员信息管理";
			((System.ComponentModel.ISupportInitialize) this.dgCust).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回客户信息列表
		private void LoadCustList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand(CurrentCustLstSqlCode, conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "Customer");
				dgCust.DataSource = null;
				dgCust.DataSource = dbDS;
				dgCust.DataMember = "Customer";
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
		
		//编辑客户信息
		private void EditCustInfo()
		{
			frmEditCust editcust = new frmEditCust();
			editcust.GetCustTypeList();
			editcust.ComboBox1.Text = dgCust[dgCust.CurrentRowIndex, 9].ToString(); //类别
			editcust.TextBox6.Text = dgCust[dgCust.CurrentRowIndex, 0].ToString(); //编号
            editcust.TextBox2.Text = dgCust[dgCust.CurrentRowIndex, 1].ToString(); //姓名
			editcust.TextBox5.Text = dgCust[dgCust.CurrentRowIndex, 3].ToString(); //身份证号
			editcust.TextBox9.Text = dgCust[dgCust.CurrentRowIndex, 6].ToString(); //单位住址
			editcust.TextBox3.Text = dgCust[dgCust.CurrentRowIndex, 4].ToString(); //个人电话
			editcust.TextBox8.Text = dgCust[dgCust.CurrentRowIndex, 7].ToString(); //单位电话
			editcust.TextBox4.Text = dgCust[dgCust.CurrentRowIndex, 8].ToString(); //联系人
			editcust.TextBox7.Text = dgCust[dgCust.CurrentRowIndex, 5].ToString(); //单位名称
            editcust.CheckBox1.Checked = dgCust[dgCust.CurrentRowIndex, 10].ToString() == "1" ? true : false; //签单权
			editcust.NumericUpDown1.Enabled = editcust.CheckBox1.Checked;
			editcust.NumericUpDown1.Text = dgCust[dgCust.CurrentRowIndex, 11].ToString(); //签单限额
			editcust.TextBox10.Text = dgCust[dgCust.CurrentRowIndex, 13].ToString(); //备注
			
			
			editcust.frmMode = 2; //修改记录
			editcust.Text = "修改客户信息";
            editcust.OldCustCode = dgCust[dgCust.CurrentRowIndex, 0].ToString(); //保存原始编号
			
			editcust.ShowDialog();
			if (editcust.DialogResult == DialogResult.OK)
			{
				LoadCustList();
			}
		}
		
		//删除客户
		private bool DelCust(string CustCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//检测该客户有无会员卡及状态，不存在方可删除
				SqlCommand selectCMD = new SqlCommand("select status from clubcard where customercode='" + CustCode + "'" + " and " + "status<>'3'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					MessageBox.Show("该客户是会员，请先废止并删除其所拥有的会员卡后方可进行客户删除操作！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandText = "delete from customer where customercode='" + CustCode + "'";
					selectCMD.CommandTimeout = 30;
					selectCMD.ExecuteNonQuery();
					
					return true;
				}
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
		
		//查询客户信息
		private void SearchCust(string CustCode, string Custname, string CustType)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				CurrentCustLstSqlCode = "SELECT * FROM view_Customer where " + "customercode like '" + "%" + CustCode + "%'" + " and " + "customername like '" + "%" + Custname + "%'" + " and " + "typename like '" + "%" + CustType + "%'";
				selectCMD.CommandText = CurrentCustLstSqlCode;
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "Customer");
				dgCust.DataSource = null;
				dgCust.DataSource = dbDS;
				dgCust.DataMember = "Customer";
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
		
		private void frmCustomer_Load(System.Object sender, System.EventArgs e)
		{
			LoadCustList();
		}
		
		private void dgCust_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgCust.CurrentRowIndex < 0))
			{
				EditCustInfo();
			}
		}
		
		private void frmCustomer_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmCust = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditCust editcust_1 = new frmEditCust();
					editcust_1.GetCustTypeList();
					
					editcust_1.frmMode = 1; //添加记录
					editcust_1.Text = "添加客户信息";
					
					editcust_1.ShowDialog();
					if (editcust_1.DialogResult == DialogResult.OK)
					{
						LoadCustList();
					}
					break;
				case 1: //修改数据
					if (! (dgCust.CurrentRowIndex < 0))
					{
						EditCustInfo();
					}
					break;
				case 2: //删除当前数据
					if (! (dgCust.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgCust[dgCust.CurrentRowIndex, 0].ToString().Trim() + " 的客户信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelCust(dgCust[dgCust.CurrentRowIndex, 0].ToString()))
							{
								LoadCustList();
							}
						}
					}
					break;
				case 4: //查询数据
					frmEditCust editcust = new frmEditCust();
					editcust.GetCustTypeList();
					
					editcust.frmMode = 3; //查询数据
					editcust.Text = "查询客户信息";
					
					editcust.ShowDialog();
					if (editcust.DialogResult == DialogResult.OK)
					{
						SearchCust(editcust.TextBox6.Text, editcust.TextBox2.Text, editcust.ComboBox1.Text);
					}
					break;
				case 6: //打印
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentCustLstSqlCode))
						{
							MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
						}
					}
					break;
				case 8: //发会员卡
                    if (dgCust.CurrentRowIndex > -1)
                    {
					    frmJoinToClub frmjtc = new frmJoinToClub();
					    frmjtc.CustCode =dgCust[dgCust.CurrentRowIndex, 0].ToString();
					    frmjtc.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("请先选择客户");
                    }

					break;
				case 10:
					this.Close();
					break;
			}
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.customer_cr == null)
			{
				report_var.customer_cr = new ReportDocument();
			}
			else
			{
				report_var.customer_cr.Close();
				report_var.customer_cr = null;
				report_var.customer_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.customer_rpt_filename))
			{
				report_var.customer_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.customer_rpt_filename, sql, "view_customer");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.customer_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.customer_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.customer_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
	}
	
}
