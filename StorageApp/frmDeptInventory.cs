using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace StorageApp
{
	public class frmDeptInventory : Form
	{
		
		public DataTable SelectedMaterials;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmDeptInventory()
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.DataGrid dgMaterials;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton13;
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ToolBarButton ToolBarButton15;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Label lblDeptname;
		internal System.Windows.Forms.Label lblStorage;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDeptInventory));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.lblStorage = new System.Windows.Forms.Label();
			this.lblDeptname = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.dgMaterials = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgMaterials).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.GroupBox1.BackColor = System.Drawing.Color.White;
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Controls.Add(this.lblStorage);
			this.GroupBox1.Controls.Add(this.lblDeptname);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.CheckBox1);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.GroupBox1.Location = new System.Drawing.Point(3, 56);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(502, 168);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "盘存单";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(98, 80);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(128, 23);
			this.Label9.TabIndex = 17;
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker2.Location = new System.Drawing.Point(194, 48);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(83, 21);
			this.DateTimePicker2.TabIndex = 20;
			//
			//lblStorage
			//
			this.lblStorage.Location = new System.Drawing.Point(370, 24);
			this.lblStorage.Name = "lblStorage";
			this.lblStorage.Size = new System.Drawing.Size(121, 23);
			this.lblStorage.TabIndex = 19;
			this.lblStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//lblDeptname
			//
			this.lblDeptname.Location = new System.Drawing.Point(370, 47);
			this.lblDeptname.Name = "lblDeptname";
			this.lblDeptname.Size = new System.Drawing.Size(121, 23);
			this.lblDeptname.TabIndex = 18;
			this.lblDeptname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(98, 104);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(352, 21);
			this.TextBox2.TabIndex = 6;
			this.TextBox2.Text = "";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(98, 48);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(95, 21);
			this.DateTimePicker1.TabIndex = 2;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(98, 25);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(178, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//CheckBox1
			//
			this.CheckBox1.BackColor = System.Drawing.Color.White;
			this.CheckBox1.Enabled = false;
			this.CheckBox1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.CheckBox1.Location = new System.Drawing.Point(384, 136);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(108, 24);
			this.CheckBox1.TabIndex = 7;
			this.CheckBox1.Text = "已审核";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(30, 104);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(72, 23);
			this.Label8.TabIndex = 7;
			this.Label8.Text = "备注：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(22, 80);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(80, 23);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "操作员：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(286, 24);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 23);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "仓    库：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(30, 47);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "盘存时间：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(30, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "单据号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(286, 47);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(80, 23);
			this.Label6.TabIndex = 4;
			this.Label6.Text = "部    门：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//dgMaterials
			//
			this.dgMaterials.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dgMaterials.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgMaterials.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgMaterials.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgMaterials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgMaterials.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgMaterials.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.CaptionVisible = false;
			this.dgMaterials.DataMember = "";
			this.dgMaterials.FlatMode = true;
			this.dgMaterials.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgMaterials.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dgMaterials.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgMaterials.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgMaterials.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgMaterials.LinkColor = System.Drawing.Color.Teal;
			this.dgMaterials.Location = new System.Drawing.Point(0, 224);
			this.dgMaterials.Name = "dgMaterials";
			this.dgMaterials.ParentRowsBackColor = System.Drawing.Color.White;
			this.dgMaterials.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgMaterials.ReadOnly = true;
			this.dgMaterials.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgMaterials.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgMaterials.Size = new System.Drawing.Size(508, 214);
			this.dgMaterials.TabIndex = 4;
			this.dgMaterials.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.DataGridTableStyle1.DataGrid = this.dgMaterials;
			this.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5});
			this.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Black;
			this.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.Silver;
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "MaterialsList";
			this.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Navy;
			this.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "物品编码";
			this.DataGridTextBoxColumn1.MappingName = "materialcode";
			this.DataGridTextBoxColumn1.Width = 80;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "物品名称";
			this.DataGridTextBoxColumn2.MappingName = "materialname";
			this.DataGridTextBoxColumn2.Width = 110;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "单位";
			this.DataGridTextBoxColumn3.MappingName = "unit";
			this.DataGridTextBoxColumn3.Width = 60;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "盘存数量";
			this.DataGridTextBoxColumn4.MappingName = "CurrentPeriodInvntQuantity";
			this.DataGridTextBoxColumn4.Width = 70;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "单价";
			this.DataGridTextBoxColumn5.MappingName = "price";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton13, this.ToolBarButton12, this.ToolBarButton15, this.ToolBarButton4, this.ToolBarButton10});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(508, 55);
			this.ToolBar1.TabIndex = 5;
			//
			//ToolBarButton13
			//
			this.ToolBarButton13.ImageIndex = 0;
			this.ToolBarButton13.Text = "保存";
			//
			//ToolBarButton12
			//
			this.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton15
			//
			this.ToolBarButton15.ImageIndex = 2;
			this.ToolBarButton15.Text = "审核";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton10
			//
			this.ToolBarButton10.ImageIndex = 4;
			this.ToolBarButton10.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//frmDeptInventory
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(508, 438);
			this.Controls.Add(this.ToolBar1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.dgMaterials);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDeptInventory";
			this.Text = "盘存单";
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgMaterials).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//保存 盘存 单据
		private bool SaveBill(string billno, string StorageBillTypeCode, string Outdate, string DepCode, string OutDepCode, string Operator, bool Audited, string note)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select billno from outstoragebill where billno='" + billno + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					MessageBox.Show("单据已经存在，不能保存盘存单。");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					//上期期末盘存单
					selectCMD.CommandText = "insert into outstoragebill " + "(billno,StorageBillTypeCode,outdate,DepCode,OutDepCode,Operator,note,Audited) " + "values (" + "'" + "j" + billno + "'" + "," + "'" + StorageBillTypeCode + "'" + "," + "'" + Outdate + "'" + "," + "'" + DepCode + "'" + "," + "'" + OutDepCode + "'" + "," + "'" + Operator + "'" + "," + "'" + note + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(Audited)).ToString() + "'" + ")";
					selectCMD.ExecuteNonQuery();
					//下棋期初盘存单
					selectCMD.CommandText = "insert into outstoragebill " + "(billno,StorageBillTypeCode,outdate,DepCode,OutDepCode,Operator,note,Audited) " + "values (" + "'" + "t" + billno + "'" + "," + "'" + StorageBillTypeCode + "'" + "," + "'" + (DateTime.Parse(Outdate)).AddSeconds(2).ToString() + "'" + "," + "'" + DepCode + "'" + "," + "'" + OutDepCode + "'" + "," + "'" + Operator + "'" + "," + "'" + note + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(Audited)).ToString() + "'" + ")";
					
					selectCMD.ExecuteNonQuery();
					return true;
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
			
			return false;
		}
		
		//保存单据物品记录
		private bool SaveBillsMaterials(string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "delete from outstoragematerials where billno='" + billno + "'";
				selectCMD.ExecuteNonQuery();
				for (int i = 0; i <= dgMaterials.VisibleRowCount - 1; i++)
				{
					//上期期末盘存单
                    selectCMD.CommandText = "insert into outstoragematerials (billno,MaterialCode,MaterialTypeCode,Quantity,Price,TotalPrice) " + "values (" + "'" + "j" + billno + "'" + "," + "'" + dgMaterials[i, 0] + "'" + "," + "'" + rms_var.GetTheMaterialTypeCode(dgMaterials[i, 0].ToString()) + "'" + "," + "-" + dgMaterials[i, 3].ToString() + "," + "-" + dgMaterials[i, 4].ToString() + "," + "-" + (System.Convert.ToString((double.Parse(dgMaterials[i, 3].ToString())) * double.Parse(dgMaterials[i, 4].ToString()))) + ")";
					selectCMD.ExecuteNonQuery();
					//下棋期初盘存单
                    selectCMD.CommandText = "insert into outstoragematerials (billno,MaterialCode,MaterialTypeCode,Quantity,Price,TotalPrice) " + "values (" + "'" + "t" + billno + "'" + "," + "'" + dgMaterials[i, 0] + "'" + "," + "'" + rms_var.GetTheMaterialTypeCode(dgMaterials[i, 0].ToString()) + "'" + "," + dgMaterials[i, 3].ToString() + "," + dgMaterials[i, 4].ToString() + "," + (System.Convert.ToString((double.Parse(dgMaterials[i, 3].ToString())) * double.Parse(dgMaterials[i, 4].ToString()))) + ")";
					
					selectCMD.ExecuteNonQuery();
				}
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
		
		//更新审核标志
		private bool UpdateAuditSign(string billno)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.CommandText = "update outstoragebill set audited='1' where billno='" + billno + "'";
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
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //保存盘存单
					if (TextBox1.Enabled && TextBox1.Text == "")
					{
						MessageBox.Show("单据号不能为空！");
						TextBox1.Focus();
						TextBox1.SelectAll();
						return;
					}
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (! CheckBox1.Checked)
						{
							//先创建上期期末盘存单
							if (SaveBill(TextBox1.Text, "E", DateTimePicker1.Text + " " + DateTimePicker2.Text, rms_var.GetDeptCode(lblDeptname.Text), rms_var.GetDeptCode(lblStorage.Text), Label9.Text, false, TextBox2.Text))
								{
								//添加单据物品列表
								if (SaveBillsMaterials(TextBox1.Text))
								{
									MessageBox.Show("单据保存成功");
									this.DialogResult = DialogResult.OK;
								}
							}
						}
						else
						{
							MessageBox.Show("已审核单据不能进行修改");
						}
					}
					else
					{
						MessageBox.Show("物品列表为空，请添加物品");
					}
					break;
				case 2: //审核盘存单
					if (dgMaterials.VisibleRowCount > 0)
					{
						if (CheckBox1.Checked == false)
						{
							//检测有无审核权
							if (rms_var.AllowAudit())
							{
								if (MessageBox.Show("确定要审核当前单据吗？" +"\r\n"+ "注意：经审核过的单据将不能再进行修改！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
								{
									CheckBox1.Checked = true;
									//更新审核标志
									if (UpdateAuditSign(TextBox1.Text))
									{
										MessageBox.Show("审核成功");
									}
								}
							}
							else
							{
								MessageBox.Show("您没有审核权。");
								return;
							}
						}
						else
						{
							MessageBox.Show("已经审核了");
						}
					}
					break;
			}
		}
		
	}
	
}
