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
	public class frmFoodDiscount : System.Windows.Forms.Form
	{
		
		private string oldcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmFoodDiscount()
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
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGrid dgFoodDiscount;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.Label Label4;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodDiscount));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgFoodDiscount = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFoodDiscount)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
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
            this.ToolBarButton5,
            this.ToolBarButton6,
            this.ToolBarButton7});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(376, 54);
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
            // ToolBarButton5
            // 
            this.ToolBarButton5.ImageIndex = 4;
            this.ToolBarButton5.Name = "ToolBarButton5";
            this.ToolBarButton5.Text = "应用";
            // 
            // ToolBarButton6
            // 
            this.ToolBarButton6.Name = "ToolBarButton6";
            this.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
            this.ImageList1.Images.SetKeyName(4, "");
            // 
            // dgFoodDiscount
            // 
            this.dgFoodDiscount.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgFoodDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFoodDiscount.BackColor = System.Drawing.Color.GhostWhite;
            this.dgFoodDiscount.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgFoodDiscount.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgFoodDiscount.CaptionForeColor = System.Drawing.Color.White;
            this.dgFoodDiscount.DataMember = "";
            this.dgFoodDiscount.FlatMode = true;
            this.dgFoodDiscount.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgFoodDiscount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodDiscount.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgFoodDiscount.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodDiscount.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgFoodDiscount.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgFoodDiscount.LinkColor = System.Drawing.Color.Teal;
            this.dgFoodDiscount.Location = new System.Drawing.Point(0, 56);
            this.dgFoodDiscount.Name = "dgFoodDiscount";
            this.dgFoodDiscount.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgFoodDiscount.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgFoodDiscount.ReadOnly = true;
            this.dgFoodDiscount.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgFoodDiscount.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgFoodDiscount.Size = new System.Drawing.Size(376, 159);
            this.dgFoodDiscount.TabIndex = 1;
            this.dgFoodDiscount.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgFoodDiscount.DoubleClick += new System.EventHandler(this.dgFoodDiscount_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgFoodDiscount;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridBoolColumn1});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "discount";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "优惠编码";
            this.DataGridTextBoxColumn1.MappingName = "discountcode";
            this.DataGridTextBoxColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "优惠名称";
            this.DataGridTextBoxColumn2.MappingName = "discountname";
            this.DataGridTextBoxColumn2.Width = 75;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "折扣率";
            this.DataGridTextBoxColumn3.MappingName = "discountrate";
            this.DataGridTextBoxColumn3.Width = 75;
            // 
            // DataGridBoolColumn1
            // 
            this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridBoolColumn1.FalseValue = "0";
            this.DataGridBoolColumn1.HeaderText = "暂停优惠";
            this.DataGridBoolColumn1.MappingName = "disabled";
            this.DataGridBoolColumn1.TrueValue = "1";
            this.DataGridBoolColumn1.Width = 75;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.CheckBox1);
            this.Panel1.Controls.Add(this.NumericUpDown1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TextBox2);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(1, 219);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(374, 143);
            this.Panel1.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.Location = new System.Drawing.Point(335, 38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 23);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "%";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(237, 64);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(95, 24);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.Text = "暂停优惠";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(264, 40);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(69, 21);
            this.NumericUpDown1.TabIndex = 1;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(216, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "优惠值：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(125, 66);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(88, 21);
            this.TextBox2.TabIndex = 2;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(125, 40);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(89, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(51, 65);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 23);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "优惠名称：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Teal;
            this.Label3.Location = new System.Drawing.Point(7, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Label3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(290, 102);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "隐藏(&H)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(227, 102);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(58, 23);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "保存(&S)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(51, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "优惠编码：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmFoodDiscount
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgFoodDiscount);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFoodDiscount";
            this.Text = "优惠打折";
            this.Load += new System.EventHandler(this.frmFoodDiscount_Load);
            this.Closed += new System.EventHandler(this.frmFoodDiscount_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgFoodDiscount)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回菜品优惠列表
		private void LoadFoodDiscountList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM Discount", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "Discount");
				dgFoodDiscount.DataSource = null;
				dgFoodDiscount.DataSource = dbDS;
				dgFoodDiscount.DataMember = "Discount";
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
		
		//添加 优惠
		private bool AddData(string discountcode, string discountname, string discountrate, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select discountcode from discount where discountcode='" + discountcode + "'", conn);
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
					selectCMD.CommandText = "insert into discount (discountcode,discountname,discountrate,disabled) " + "values (" + "'" + discountcode + "'" + "," + "'" + discountname + "'" + "," + discountrate.ToString() + "," + "'" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + ")";
					
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
		
		//修改 优惠
		private bool EditData(string olddiscountcode, string newdiscountcode, string discountname, string discountrate, bool disabled)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (olddiscountcode == newdiscountcode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update discount set " + "discountname='" + discountname + "'" + "," + "discountrate=" + discountrate + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "where discountcode='" + newdiscountcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select discountcode from discount where discountcode='" + newdiscountcode + "'";
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
						selectCMD.CommandText = "update discount set " + "discountcode='" + newdiscountcode + "'" + "," + "discountname='" + discountname + "'" + "," + "discountrate=" + discountrate + "," + "disabled='" + Math.Abs(System.Convert.ToInt32(disabled)).ToString() + "'" + "where discountcode='" + olddiscountcode + "'";
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
		
		
		//删除菜品优惠
		private bool DelDiscount(string Discountcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from discount where discountcode='" + Discountcode + "'";
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				
				//删除所有应用此优惠的部门的优惠
				selectCMD.CommandText = "delete from DiscountArea where discountcode='" + Discountcode + "'";
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
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			rms_var.frmFoodDisc.dgFoodDiscount.Height = rms_var.frmFoodDisc.Height - rms_var.frmFoodDisc.ToolBar1.Height - 35;
			rms_var.frmFoodDisc.Panel1.Visible = false;
		}
		
		private void frmFoodDiscount_Load(System.Object sender, System.EventArgs e)
		{
			LoadFoodDiscountList();
		}
		
		private void frmFoodDiscount_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmFoodDisc = null;
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
						NumericUpDown1.Value = 0;
						CheckBox1.Checked = false;
						dgFoodDiscount.Height = dgFoodDiscount.Height - Panel1.Height - 5;
						Panel1.Visible = true;
						this.AcceptButton = Button1;
						this.CancelButton = Button2;
						TextBox1.Focus();
					}
					break;
					
				case 1: //修改数据
					if (! (dgFoodDiscount.CurrentRowIndex < 0))
					{
						Button2_Click(sender, e);
						if (! Panel1.Visible)
						{
							Label3.Text = "修改记录";
                            TextBox1.Text = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 0].ToString();
							oldcode = TextBox1.Text;
                            TextBox2.Text = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 1].ToString();
							NumericUpDown1.Value = System.Convert.ToDecimal(dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 2]);
                            CheckBox1.Checked = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 3].ToString() == "1" ? true : false;
							dgFoodDiscount.Height = dgFoodDiscount.Height - Panel1.Height - 5;
							Panel1.Visible = true;
							this.AcceptButton = Button1;
							this.CancelButton = Button2;
							TextBox1.Focus();
						}
					}
					break;
				case 2: //删除当前数据
					if (! (dgFoodDiscount.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 0].ToString().Trim() + " 的菜品优惠吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelDiscount(dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 0].ToString()))
							{
								LoadFoodDiscountList();
							}
						}
					}
					break;
				case 4: //应用部门
					if (! (dgFoodDiscount.CurrentRowIndex < 0))
					{
						frmApplyDiscountDept frmapplydisdept = new frmApplyDiscountDept();
                        frmapplydisdept.DiscountCode = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 0].ToString();
						frmapplydisdept.Label1.Text = "请选择将名为 " + dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 1] + " 的优惠应用到的部门";
						frmapplydisdept.ShowDialog();
					}
					break;
				case 6:
					this.Close();
					break;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("优惠编码不能为空！");
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("优惠名称不能为空！");
				return;
			}
			
			if (Label3.Text == "添加记录")
			{
				if (AddData(TextBox1.Text, TextBox2.Text, NumericUpDown1.Value.ToString(), CheckBox1.Checked))
				{
					MessageBox.Show("添加记录成功！");
					LoadFoodDiscountList();
					
					TextBox1.Text = "";
					TextBox2.Text = "";
					NumericUpDown1.Value = 0;
					CheckBox1.Checked = false;
					
                    //if (MessageBox.Show("继续添加新的优惠折扣吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    //{
						TextBox1.Focus();
						TextBox1.SelectAll();
                    //}
                    //else
                    //{
                    //    rms_var.frmFoodDisc.dgFoodDiscount.Height = rms_var.frmFoodDisc.Height - rms_var.frmFoodDisc.ToolBar1.Height - 35;
                    //    rms_var.frmFoodDisc.Panel1.Visible = false;
                    //}
				}
			}
			else
			{
				if (MessageBox.Show("确定要修改当前优惠折扣吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(oldcode, TextBox1.Text, TextBox2.Text, NumericUpDown1.Value.ToString(), CheckBox1.Checked))
					{
						MessageBox.Show("修改记录成功！");
						rms_var.frmFoodDisc.dgFoodDiscount.Height = rms_var.frmFoodDisc.Height - rms_var.frmFoodDisc.ToolBar1.Height - 35;
						rms_var.frmFoodDisc.Panel1.Visible = false;
						LoadFoodDiscountList();
						TextBox1.Text = "";
						TextBox2.Text = "";
						NumericUpDown1.Value = 0;
						CheckBox1.Checked = false;
					}
				}
				
			}
		}
		
		private void dgFoodDiscount_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgFoodDiscount.CurrentRowIndex < 0))
			{
				Button2_Click(sender, e);
				if (! Panel1.Visible)
				{
					Label3.Text = "修改记录";
                    TextBox1.Text = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 0].ToString();
					oldcode = TextBox1.Text;
                    TextBox2.Text = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 1].ToString();
					NumericUpDown1.Value = System.Convert.ToDecimal(dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 2]);
                    CheckBox1.Checked = dgFoodDiscount[dgFoodDiscount.CurrentRowIndex, 3].ToString() == "1" ? true : false;
					dgFoodDiscount.Height = dgFoodDiscount.Height - Panel1.Height - 5;
					Panel1.Visible = true;
					this.AcceptButton = Button1;
					this.CancelButton = Button2;
					TextBox1.Focus();
				}
			}
		}
	}
	
}
