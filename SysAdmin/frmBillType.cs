using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace SysAdmin
{
	public class frmBillType : System.Windows.Forms.Form
	{
		
		private string oldtypecode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmBillType()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGrid dgBillType;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn2;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillType));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgBillType = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.DataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
            this.DataGridBoolColumn3 = new System.Windows.Forms.DataGridBoolColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBillType)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton2,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton7});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(471, 54);
            this.ToolBar1.TabIndex = 0;
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
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton7
            // 
            this.ToolBarButton7.ImageIndex = 3;
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
            // 
            // dgBillType
            // 
            this.dgBillType.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgBillType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBillType.BackColor = System.Drawing.Color.GhostWhite;
            this.dgBillType.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgBillType.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgBillType.CaptionForeColor = System.Drawing.Color.White;
            this.dgBillType.DataMember = "";
            this.dgBillType.FlatMode = true;
            this.dgBillType.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgBillType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgBillType.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgBillType.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgBillType.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgBillType.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgBillType.LinkColor = System.Drawing.Color.Teal;
            this.dgBillType.Location = new System.Drawing.Point(0, 56);
            this.dgBillType.Name = "dgBillType";
            this.dgBillType.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgBillType.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgBillType.ReadOnly = true;
            this.dgBillType.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgBillType.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgBillType.Size = new System.Drawing.Size(471, 165);
            this.dgBillType.TabIndex = 1;
            this.dgBillType.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgBillType.DoubleClick += new System.EventHandler(this.dgBillType_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgBillType;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridBoolColumn1,
            this.DataGridBoolColumn2,
            this.DataGridBoolColumn3});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "billtype";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "类别编码";
            this.DataGridTextBoxColumn1.MappingName = "billtypecode";
            this.DataGridTextBoxColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "单据名称";
            this.DataGridTextBoxColumn2.MappingName = "name";
            this.DataGridTextBoxColumn2.Width = 75;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "消费单";
            this.DataGridBoolColumn1.MappingName = "consumebill";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 75;
            // 
            // DataGridBoolColumn2
            // 
            this.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn2.FalseValue = "0";
            this.DataGridBoolColumn2.HeaderText = "取消单";
            this.DataGridBoolColumn2.MappingName = "cancelbill";
            this.DataGridBoolColumn2.TrueValue = "1";
            this.DataGridBoolColumn2.Width = 75;
            // 
            // DataGridBoolColumn3
            // 
            this.DataGridBoolColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn3.FalseValue = "0";
            this.DataGridBoolColumn3.HeaderText = "赠送单";
            this.DataGridBoolColumn3.MappingName = "presentbill";
            this.DataGridBoolColumn3.TrueValue = "1";
            this.DataGridBoolColumn3.Width = 75;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.TextBox2);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(0, 223);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(469, 131);
            this.Panel1.TabIndex = 2;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Controls.Add(this.RadioButton3);
            this.GroupBox1.Location = new System.Drawing.Point(224, 16);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(232, 72);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "单据性质";
            // 
            // RadioButton2
            // 
            this.RadioButton2.Location = new System.Drawing.Point(128, 16);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(96, 24);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "取消单";
            // 
            // RadioButton1
            // 
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(24, 16);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(96, 24);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "消费单";
            // 
            // RadioButton3
            // 
            this.RadioButton3.Location = new System.Drawing.Point(24, 40);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(104, 24);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "赠送单";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(120, 62);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(96, 21);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(120, 35);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(96, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "类别编码：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(24, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "单据名称：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Teal;
            this.Label3.Location = new System.Drawing.Point(7, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Label3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(384, 96);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 23);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "隐藏(&H)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(320, 96);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(58, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "保存(&S)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmBillType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(471, 357);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgBillType);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillType";
            this.Text = "单据设置";
            this.Load += new System.EventHandler(this.frmBillType_Load);
            this.Closed += new System.EventHandler(this.frmBillType_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgBillType)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回单据类别列表
		private void LoadBillTypeList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM billtype", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "BillType");
				dgBillType.DataSource = null;
				dgBillType.DataSource = dbDS;
				dgBillType.DataMember = "BillType";
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
		
		//添加 单据类别
		private bool AddData(string billtypecode, string name, bool consumebill, bool cancelbill, bool presentbill)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select billtypecode from billtype where billtypecode='" + billtypecode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
				{
					MessageBox.Show("编码重复！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into billtype (billtypecode,name,consumebill,cancelbill,presentbill) " + "values (" + "'" + billtypecode + "'" + "," + "'" + name + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(consumebill)).ToString() + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(cancelbill)).ToString() + "'" + "," + "'" + Math.Abs(System.Convert.ToInt32(presentbill)).ToString() + "'" + ")";
					
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
		
		//修改 单据类别
		private bool EditData(string oldtypecode, string newbilltypecode, string name, bool consumebill, bool cancelbill, bool presentbill)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldtypecode == newbilltypecode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.CommandText = "update billtype set " + "name='" + name + "'" + "," + "consumebill='" + Math.Abs(System.Convert.ToInt32(consumebill)).ToString() + "'" + "," + "cancelbill='" + Math.Abs(System.Convert.ToInt32(cancelbill)).ToString() + "'" + "," + "presentbill='" + Math.Abs(System.Convert.ToInt32(presentbill)).ToString() + "' " + "where billtypecode='" + newbilltypecode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select billtypecode from billtype where typecode='" + newbilltypecode + "'";
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					
					if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
					{
						MessageBox.Show("编码重复！");
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update billtype set " + "billtypecode='" + newbilltypecode + " '" + "," + "name='" + name + "'" + "," + "consumebill='" + Math.Abs(System.Convert.ToInt32(consumebill)).ToString() + "'" + "," + "cancelbill='" + Math.Abs(System.Convert.ToInt32(cancelbill)).ToString() + "'" + "," + "presentbill='" + Math.Abs(System.Convert.ToInt32(presentbill)).ToString() + "' " + "where billtypecode='" + oldtypecode + "'";
						selectCMD.ExecuteNonQuery();
						
						return true;
					}
					
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
		
		//删除 单据类别
		private bool DelBillType(string typecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from billtype where billtypecode='" + typecode + "'";
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
		
		private void frmBillType_Load(System.Object sender, System.EventArgs e)
		{
			LoadBillTypeList();
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			rms_var.frmBilltyp.dgBillType.Height = rms_var.frmBilltyp.Height - rms_var.frmBilltyp.ToolBar1.Height - 35;
			rms_var.frmBilltyp.Panel1.Visible = false;
		}
		
		private void frmBillType_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmBilltyp = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					Button2_Click(sender, e);
					if (! Panel1.Visible)
					{
						Label3.Text = "添加记录";
						TextBox1.Text = "";
						TextBox2.Text = "";
						RadioButton1.Checked = true;
						dgBillType.Height = dgBillType.Height - Panel1.Height - 5;
						Panel1.Visible = true;
						this.AcceptButton = Button1;
						this.CancelButton = Button2;
						TextBox1.Focus();
					}
					break;
					
				case 1: //修改数据
					if (! (dgBillType.CurrentRowIndex < 0))
					{
						Button2_Click(sender, e);
						if (! Panel1.Visible)
						{
							Label3.Text = "修改记录";
                            TextBox1.Text = dgBillType[dgBillType.CurrentRowIndex, 0].ToString();
							oldtypecode = TextBox1.Text;
                            TextBox2.Text = dgBillType[dgBillType.CurrentRowIndex, 1].ToString();
							RadioButton1.Checked = dgBillType[dgBillType.CurrentRowIndex, 2].ToString()=="1"?true:false;
							RadioButton2.Checked = dgBillType[dgBillType.CurrentRowIndex, 3].ToString()=="1"?true:false;
                            RadioButton3.Checked = dgBillType[dgBillType.CurrentRowIndex, 4].ToString() == "1" ? true : false;
							dgBillType.Height = dgBillType.Height - Panel1.Height - 5;
							Panel1.Visible = true;
							this.AcceptButton = Button1;
							this.CancelButton = Button2;
							
							TextBox1.Focus();
						}
					}
					break;
				case 2: //删除当前数据
					if (! (dgBillType.CurrentRowIndex < 0))
					{
						if (MessageBox.Show("确定要删除当前选中的编号为 " +dgBillType[dgBillType.CurrentRowIndex, 0].ToString().Trim() + " 的单据类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelBillType(dgBillType[dgBillType.CurrentRowIndex, 0].ToString()))
							{
								LoadBillTypeList();
							}
						}
					}
					break;
				case 4:
					this.Close();
					break;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("类别编码不能为空！");
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("单据名称不能为空！");
				return;
			}
			
			if (Label3.Text == "添加记录")
			{
				if (AddData(TextBox1.Text, TextBox2.Text, RadioButton1.Checked, RadioButton2.Checked, RadioButton3.Checked))
				{
					MessageBox.Show("添加记录成功！");
					LoadBillTypeList();
					
					TextBox1.Text = "";
					TextBox2.Text = "";
					RadioButton1.Checked = true;
					
					if (MessageBox.Show("继续添加新的单据类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						TextBox1.Focus();
						TextBox1.SelectAll();
					}
					else
					{
						dgBillType.Height = rms_var.frmBilltyp.Height - rms_var.frmBilltyp.ToolBar1.Height - 35;
						Panel1.Visible = false;
					}
				}
			}
			else
			{
				if (MessageBox.Show("确定要修改当前单据类别吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(oldtypecode, TextBox1.Text, TextBox2.Text, RadioButton1.Checked, RadioButton2.Checked, RadioButton3.Checked))
					{
						MessageBox.Show("修改记录成功！");
						dgBillType.Height = rms_var.frmBilltyp.Height - rms_var.frmBilltyp.ToolBar1.Height - 35;
						Panel1.Visible = false;
						LoadBillTypeList();
						TextBox1.Text = "";
						TextBox2.Text = "";
						RadioButton1.Checked = true;
					}
				}
				
			}
		}
		
		private void dgBillType_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgBillType.CurrentRowIndex < 0))
			{
				Button2_Click(sender, e);
				if (! Panel1.Visible)
				{
					Label3.Text = "修改记录";
                    TextBox1.Text = dgBillType[dgBillType.CurrentRowIndex, 0].ToString();
					oldtypecode = TextBox1.Text;
                    TextBox2.Text = dgBillType[dgBillType.CurrentRowIndex, 1].ToString();
					RadioButton1.Checked = dgBillType[dgBillType.CurrentRowIndex, 2].ToString()=="1"?true:false;
					RadioButton2.Checked = dgBillType[dgBillType.CurrentRowIndex, 3].ToString()=="1"?true:false;
                    RadioButton3.Checked = dgBillType[dgBillType.CurrentRowIndex, 4].ToString() == "1" ? true : false;
					dgBillType.Height = dgBillType.Height - Panel1.Height - 5;
					Panel1.Visible = true;
					this.AcceptButton = Button1;
					this.CancelButton = Button2;
					
					TextBox1.Focus();
				}
			}
		}
	}
	
}
