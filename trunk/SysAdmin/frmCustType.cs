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
	public class frmCustType : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCustType()
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
		internal System.Windows.Forms.DataGrid dgCustType;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustType));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgCustType = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustType)).BeginInit();
            this.Panel1.SuspendLayout();
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
            this.ToolBar1.Size = new System.Drawing.Size(367, 54);
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
            // dgCustType
            // 
            this.dgCustType.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgCustType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCustType.BackColor = System.Drawing.Color.GhostWhite;
            this.dgCustType.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgCustType.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgCustType.CaptionForeColor = System.Drawing.Color.White;
            this.dgCustType.DataMember = "";
            this.dgCustType.FlatMode = true;
            this.dgCustType.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgCustType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCustType.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgCustType.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgCustType.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgCustType.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgCustType.LinkColor = System.Drawing.Color.Teal;
            this.dgCustType.Location = new System.Drawing.Point(0, 56);
            this.dgCustType.Name = "dgCustType";
            this.dgCustType.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgCustType.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCustType.ReadOnly = true;
            this.dgCustType.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgCustType.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgCustType.Size = new System.Drawing.Size(367, 161);
            this.dgCustType.TabIndex = 1;
            this.dgCustType.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgCustType.DoubleClick += new System.EventHandler(this.dgCustType_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgCustType;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "CustType";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "类别编码";
            this.DataGridTextBoxColumn1.MappingName = "typecode";
            this.DataGridTextBoxColumn1.Width = 90;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "客户类别";
            this.DataGridTextBoxColumn2.MappingName = "typename";
            this.DataGridTextBoxColumn2.Width = 90;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(227, 97);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(58, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "保存(&S)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(290, 97);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 23);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "隐藏(&H)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.TextBox2);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(1, 221);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(365, 131);
            this.Panel1.TabIndex = 2;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(155, 62);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(127, 21);
            this.TextBox2.TabIndex = 10;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(155, 35);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(127, 21);
            this.TextBox1.TabIndex = 9;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(58, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "客户类别编码：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(58, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "客户类别名称：";
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
            // frmCustType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(367, 353);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgCustType);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustType";
            this.Text = "客户类别";
            this.Load += new System.EventHandler(this.frmCustType_Load);
            this.Closed += new System.EventHandler(this.frmCustType_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustType)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private string oldtypecode;
		
		//返回客户类别列表
		private void LoadCustTypeList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM custtype", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "CustType");
				dgCustType.DataSource = null;
				dgCustType.DataSource = dbDS;
				dgCustType.DataMember = "CustType";
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
		
		//添加 客户类别
		private bool AddData(string typecode, string typename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select typecode from custtype where typecode='" + typecode + "'", conn);
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
					selectCMD.CommandText = "insert into custtype (typecode,typename) " + "values (" + "'" + typecode + "'" + "," + "'" + typename + "'" + ")";
					
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
		
		//修改 客户类别
		private bool EditData(string oldtypecode, string newtypecode, string typename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldtypecode == newtypecode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update custtype set " + "typename='" + typename + "'" + "where typecode='" + newtypecode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select typecode from custtype where typecode='" + newtypecode + "'";
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
						selectCMD.CommandText = "update custtype set " + "typecode='" + newtypecode + "'" + "," + "typename='" + typename + "'" + "where typecode='" + oldtypecode + "'";
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
		
		//删除客户类别
		private bool DelCustType(string typecode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//先检查有无客户属于此类别
				SqlCommand selectCMD = new SqlCommand();
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select customertype from view_customer  where customertype='" + typecode + "'";
				dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				if (dbDS.Tables[0].Rows.Count > 0) //存在属于该类别的客户记录
				{
					MessageBox.Show("有属于该类别的客户，不能执行删除操作");
					return false;
				}
				else
				{
					selectCMD.CommandText = "delete from custtype where typecode='" + typecode + "'";
					selectCMD.CommandTimeout = 30;
					conn.Open();
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
		
		private void frmCustType_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmCustTyp = null;
		}
		
		private void frmCustType_Load(object sender, System.EventArgs e)
		{
			LoadCustTypeList();
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
						dgCustType.Height = dgCustType.Height - Panel1.Height - 5;
						Panel1.Visible = true;
						this.AcceptButton = Button1;
						this.CancelButton = Button2;
						TextBox1.Focus();
					}
					break;
					
				case 1: //修改数据
					if (! (dgCustType.CurrentRowIndex < 0))
					{
						Button2_Click(sender, e);
						if (! Panel1.Visible)
						{
							Label3.Text = "修改记录";
							TextBox1.Text = dgCustType[dgCustType.CurrentRowIndex, 0].ToString();
							oldtypecode = TextBox1.Text;
                            TextBox2.Text = dgCustType[dgCustType.CurrentRowIndex, 1].ToString();
							dgCustType.Height = dgCustType.Height - Panel1.Height - 5;
							Panel1.Visible = true;
							this.AcceptButton = Button1;
							this.CancelButton = Button2;
							TextBox1.Focus();
						}
					}
					break;
				case 2: //删除当前数据
					if (! (dgCustType.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgCustType[dgCustType.CurrentRowIndex, 0].ToString().Trim() + " 的客户类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelCustType(dgCustType[dgCustType.CurrentRowIndex, 0].ToString()))
							{
								LoadCustTypeList();
							}
						}
					}
					break;
				case 4:
					this.Close();
					break;
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			rms_var.frmCustTyp.dgCustType.Height = rms_var.frmCustTyp.Height - rms_var.frmCustTyp.ToolBar1.Height - 35;
			rms_var.frmCustTyp.Panel1.Visible = false;
		}
		
		private void dgCustType_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgCustType.CurrentRowIndex < 0))
			{
				Button2_Click(sender, e);
				if (! Panel1.Visible)
				{
					Label3.Text = "修改记录";
					TextBox1.Text = dgCustType[dgCustType.CurrentRowIndex, 0].ToString();
					oldtypecode = TextBox1.Text;
                    TextBox2.Text = dgCustType[dgCustType.CurrentRowIndex, 1].ToString();
					dgCustType.Height = dgCustType.Height - Panel1.Height - 5;
					Panel1.Visible = true;
					this.AcceptButton = Button1;
					this.CancelButton = Button2;
					TextBox1.Focus();
				}
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
				MessageBox.Show("类别名称不能为空！");
				return;
			}
			
			if (Label3.Text == "添加记录")
			{
				if (AddData(TextBox1.Text, TextBox2.Text))
				{
					MessageBox.Show("添加记录成功！");
					LoadCustTypeList();
					
					TextBox1.Text = "";
					TextBox2.Text = "";
					
                    //if (MessageBox.Show("继续添加新的客户类别吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    //{
						TextBox1.Focus();
						TextBox1.SelectAll();
                    //}
                    //else
                    //{
                    //    rms_var.frmCustTyp.dgCustType.Height = rms_var.frmCustTyp.Height - rms_var.frmCustTyp.ToolBar1.Height - 35;
                    //    rms_var.frmCustTyp.Panel1.Visible = false;
                    //}
				}
			}
			else
			{
				if (MessageBox.Show("确定要修改当前客户类别吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(oldtypecode, TextBox1.Text, TextBox2.Text))
					{
						MessageBox.Show("修改记录成功！");
						rms_var.frmCustTyp.dgCustType.Height = rms_var.frmCustTyp.Height - rms_var.frmCustTyp.ToolBar1.Height - 35;
						rms_var.frmCustTyp.Panel1.Visible = false;
						LoadCustTypeList();
						TextBox1.Text = "";
						TextBox2.Text = "";
					}
				}
			}
		}
	}
	
}
