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
	public class frmTimeBlock : System.Windows.Forms.Form
	{
		
		private string oldcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmTimeBlock()
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.DataGrid dgTimeBlock;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeBlock));
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgTimeBlock = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeBlock)).BeginInit();
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
            this.ToolBar1.Size = new System.Drawing.Size(429, 54);
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
            // dgTimeBlock
            // 
            this.dgTimeBlock.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgTimeBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTimeBlock.BackColor = System.Drawing.Color.GhostWhite;
            this.dgTimeBlock.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgTimeBlock.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgTimeBlock.CaptionForeColor = System.Drawing.Color.White;
            this.dgTimeBlock.DataMember = "";
            this.dgTimeBlock.FlatMode = true;
            this.dgTimeBlock.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgTimeBlock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTimeBlock.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgTimeBlock.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgTimeBlock.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgTimeBlock.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgTimeBlock.LinkColor = System.Drawing.Color.Teal;
            this.dgTimeBlock.Location = new System.Drawing.Point(0, 56);
            this.dgTimeBlock.Name = "dgTimeBlock";
            this.dgTimeBlock.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgTimeBlock.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgTimeBlock.ReadOnly = true;
            this.dgTimeBlock.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgTimeBlock.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgTimeBlock.Size = new System.Drawing.Size(429, 189);
            this.dgTimeBlock.TabIndex = 1;
            this.dgTimeBlock.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            this.dgTimeBlock.DoubleClick += new System.EventHandler(this.dgTimeBlock_DoubleClick);
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgTimeBlock;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2,
            this.DataGridTextBoxColumn3,
            this.DataGridTextBoxColumn4});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "timeblock";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "时间段编码";
            this.DataGridTextBoxColumn1.MappingName = "timeblockcode";
            this.DataGridTextBoxColumn1.Width = 75;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "名称";
            this.DataGridTextBoxColumn2.MappingName = "name";
            this.DataGridTextBoxColumn2.Width = 75;
            // 
            // DataGridTextBoxColumn3
            // 
            this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn3.Format = "";
            this.DataGridTextBoxColumn3.FormatInfo = null;
            this.DataGridTextBoxColumn3.HeaderText = "开始时间";
            this.DataGridTextBoxColumn3.MappingName = "begintime";
            this.DataGridTextBoxColumn3.Width = 75;
            // 
            // DataGridTextBoxColumn4
            // 
            this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn4.Format = "";
            this.DataGridTextBoxColumn4.FormatInfo = null;
            this.DataGridTextBoxColumn4.HeaderText = "截止时间";
            this.DataGridTextBoxColumn4.MappingName = "endtime";
            this.DataGridTextBoxColumn4.Width = 75;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.DateTimePicker2);
            this.Panel1.Controls.Add(this.DateTimePicker1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TextBox2);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(1, 248);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(427, 133);
            this.Panel1.TabIndex = 2;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePicker2.Location = new System.Drawing.Point(303, 61);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.ShowUpDown = true;
            this.DateTimePicker2.Size = new System.Drawing.Size(82, 21);
            this.DateTimePicker2.TabIndex = 3;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePicker1.Location = new System.Drawing.Point(303, 34);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.ShowUpDown = true;
            this.DateTimePicker1.Size = new System.Drawing.Size(82, 21);
            this.DateTimePicker1.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(239, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 23);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "截止时间：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(240, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 23);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "起始时间：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(139, 61);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(96, 21);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(139, 34);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(96, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(43, 33);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "时间段编码：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(43, 60);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "名称：";
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
            this.Button2.Location = new System.Drawing.Point(348, 95);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "隐藏(&H)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(284, 95);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(58, 23);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "保存(&S)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmTimeBlock
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(429, 382);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgTimeBlock);
            this.Controls.Add(this.ToolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimeBlock";
            this.Text = "时间段";
            this.Load += new System.EventHandler(this.frmTimeBlock_Load);
            this.Closed += new System.EventHandler(this.frmTimeBlock_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeBlock)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回时间段列表
		private void LoadTimeblockList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM timeblock", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "timeblock");
				dgTimeBlock.DataSource = null;
				dgTimeBlock.DataSource = dbDS;
				dgTimeBlock.DataMember = "timeblock";
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
		
		//添加 时间段
		private bool AddData(string timeblockcode, string name, string begintime, string endtime)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select timeblockcode from timeblock where timeblockcode='" + timeblockcode + "'", conn);
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
					selectCMD.CommandText = "insert into timeblock (timeblockcode,name,begintime,endtime) " + "values (" + "'" + timeblockcode + "'" + "," + "'" + name + "'" + "," + "'" + begintime + "'" + "," + "'" + endtime + "'" + ")";
					
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
		
		//修改 时间段
		private bool EditData(string oldcode, string newtimeblockcode, string name, string begintime, string endtime)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldcode == newtimeblockcode) //编码没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.CommandText = "update timeblock set " + "name='" + name + "'" + "," + "begintime='" + begintime + "'" + "," + "endtime='" + endtime + "' " + "where timeblockcode='" + newtimeblockcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select timeblockcode from timeblock where timeblockcode='" + newtimeblockcode + "'";
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
						selectCMD.CommandText = "update timeblock set " + "timeblockcode='" + newtimeblockcode + " '" + "," + "name='" + name + "'" + "," + "begintime='" + begintime + "'" + "," + "endtime='" + endtime + "' " + "where billtypecode='" + oldcode + "'";
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
		
		//删除 timeblock
		private bool DelTimeBlock(string code)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from timeblock where timeblockcode='" + code + "'";
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
		
		private void frmTimeBlock_Load(System.Object sender, System.EventArgs e)
		{
			LoadTimeblockList();
		}
		
		private void frmTimeBlock_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmTimeblk = null;
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			rms_var.frmTimeblk.dgTimeBlock.Height = rms_var.frmTimeblk.Height - rms_var.frmTimeblk.ToolBar1.Height - 35;
			rms_var.frmTimeblk.Panel1.Visible = false;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("时间段编码不能为空！");
				return;
			}
			if (TextBox2.Text.Trim() == "")
			{
				MessageBox.Show("名称不能为空！");
				return;
			}
			
			if (Label3.Text == "添加记录")
			{
				if (AddData(TextBox1.Text, TextBox2.Text, DateTimePicker1.Text, DateTimePicker2.Text))
				{
					MessageBox.Show("添加记录成功！");
					LoadTimeblockList();
					
					TextBox1.Text = "";
					TextBox2.Text = "";
					
                    //if (MessageBox.Show("继续添加新的时间段吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    //{
						TextBox1.Focus();
						TextBox1.SelectAll();
                    //}
                    //else
                    //{
                    //    rms_var.frmTimeblk.dgTimeBlock.Height = rms_var.frmTimeblk.Height - rms_var.frmTimeblk.ToolBar1.Height - 35;
                    //    rms_var.frmTimeblk.Panel1.Visible = false;
                    //}
				}
			}
			else
			{
				if (MessageBox.Show("确定要修改当前时间段吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(oldcode, TextBox1.Text, TextBox2.Text, DateTimePicker1.Text, DateTimePicker2.Text))
					{
						MessageBox.Show("修改记录成功！");
						rms_var.frmTimeblk.dgTimeBlock.Height = rms_var.frmTimeblk.Height - rms_var.frmTimeblk.ToolBar1.Height - 35;
						rms_var.frmTimeblk.Panel1.Visible = false;
						LoadTimeblockList();
						TextBox1.Text = "";
						TextBox2.Text = "";
					}
				}
				
			}
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
						dgTimeBlock.Height = dgTimeBlock.Height - Panel1.Height - 5;
						Panel1.Visible = true;
						this.AcceptButton = Button1;
						this.CancelButton = Button2;
						TextBox1.Focus();
					}
					break;
					
				case 1: //修改数据
					if (! (dgTimeBlock.CurrentRowIndex < 0))
					{
						Button2_Click(sender, e);
						if (! Panel1.Visible)
						{
							Label3.Text = "修改记录";
                            TextBox1.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 0].ToString();
							oldcode = TextBox1.Text;
                            TextBox2.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 1].ToString();
							DateTimePicker1.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 2].ToString();
                            DateTimePicker2.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 3].ToString();
							dgTimeBlock.Height = dgTimeBlock.Height - Panel1.Height - 5;
							Panel1.Visible = true;
							this.AcceptButton = Button1;
							this.CancelButton = Button2;
							
							TextBox1.Focus();
						}
					}
					break;
				case 2: //删除当前数据
					if (! (dgTimeBlock.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgTimeBlock[dgTimeBlock.CurrentRowIndex, 0].ToString().Trim() + " 的时间段吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelTimeBlock(dgTimeBlock[dgTimeBlock.CurrentRowIndex, 0].ToString()))
							{
								LoadTimeblockList();
							}
						}
					}
					break;
				case 4:
					this.Close();
					break;
			}
		}
		
		private void dgTimeBlock_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgTimeBlock.CurrentRowIndex < 0))
			{
				Button2_Click(sender, e);
				if (! Panel1.Visible)
				{
					Label3.Text = "修改记录";
					TextBox1.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 0].ToString();
					oldcode = TextBox1.Text;
					TextBox2.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 1].ToString();
					DateTimePicker1.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 2].ToString();
                    DateTimePicker2.Text = dgTimeBlock[dgTimeBlock.CurrentRowIndex, 3].ToString();
					dgTimeBlock.Height = dgTimeBlock.Height - Panel1.Height - 5;
					Panel1.Visible = true;
					this.AcceptButton = Button1;
					this.CancelButton = Button2;
					
					TextBox1.Focus();
				}
			}
		}
	}
	
}
