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
	public class frmCardAddupDisc : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCardAddupDisc()
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
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.ToolBar ToolBar1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton1;
		internal System.Windows.Forms.ToolBarButton ToolBarButton3;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.DataGrid dgCardAddUpdis;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardAddupDisc));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgCardAddUpdis = new System.Windows.Forms.DataGrid();
            this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardAddUpdis)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NumericUpDown2);
            this.Panel1.Controls.Add(this.NumericUpDown1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(0, 216);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(384, 136);
            this.Panel1.TabIndex = 2;
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(174, 65);
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.NumericUpDown2.TabIndex = 1;
            this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(174, 37);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.NumericUpDown1.TabIndex = 0;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDown1.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(75, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "累计消费金额：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(75, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "折让比率：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Button2.Location = new System.Drawing.Point(290, 97);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 23);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "隐藏(&H)";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
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
            // ToolBar1
            // 
            this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ToolBarButton1,
            this.ToolBarButton3,
            this.ToolBarButton4,
            this.ToolBarButton7});
            this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.ImageList = this.ImageList1;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(384, 54);
            this.ToolBar1.TabIndex = 0;
            this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
            // 
            // ToolBarButton1
            // 
            this.ToolBarButton1.ImageIndex = 0;
            this.ToolBarButton1.Name = "ToolBarButton1";
            this.ToolBarButton1.Text = "添加";
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.ImageIndex = 1;
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
            this.ToolBarButton7.ImageIndex = 2;
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
            // 
            // dgCardAddUpdis
            // 
            this.dgCardAddUpdis.AlternatingBackColor = System.Drawing.Color.GhostWhite;
            this.dgCardAddUpdis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCardAddUpdis.BackColor = System.Drawing.Color.GhostWhite;
            this.dgCardAddUpdis.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgCardAddUpdis.CaptionBackColor = System.Drawing.Color.Navy;
            this.dgCardAddUpdis.CaptionForeColor = System.Drawing.Color.White;
            this.dgCardAddUpdis.DataMember = "";
            this.dgCardAddUpdis.FlatMode = true;
            this.dgCardAddUpdis.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgCardAddUpdis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCardAddUpdis.GridLineColor = System.Drawing.Color.RoyalBlue;
            this.dgCardAddUpdis.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgCardAddUpdis.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgCardAddUpdis.HeaderForeColor = System.Drawing.Color.Lavender;
            this.dgCardAddUpdis.LinkColor = System.Drawing.Color.Teal;
            this.dgCardAddUpdis.Location = new System.Drawing.Point(0, 56);
            this.dgCardAddUpdis.Name = "dgCardAddUpdis";
            this.dgCardAddUpdis.ParentRowsBackColor = System.Drawing.Color.Lavender;
            this.dgCardAddUpdis.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCardAddUpdis.ReadOnly = true;
            this.dgCardAddUpdis.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgCardAddUpdis.SelectionForeColor = System.Drawing.Color.PaleGreen;
            this.dgCardAddUpdis.Size = new System.Drawing.Size(384, 157);
            this.dgCardAddUpdis.TabIndex = 1;
            this.dgCardAddUpdis.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.DataGridTableStyle1});
            // 
            // DataGridTableStyle1
            // 
            this.DataGridTableStyle1.DataGrid = this.dgCardAddUpdis;
            this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.DataGridTextBoxColumn1,
            this.DataGridTextBoxColumn2});
            this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridTableStyle1.MappingName = "ClubAddUpDisc";
            // 
            // DataGridTextBoxColumn1
            // 
            this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn1.Format = "";
            this.DataGridTextBoxColumn1.FormatInfo = null;
            this.DataGridTextBoxColumn1.HeaderText = "累计消费金额";
            this.DataGridTextBoxColumn1.MappingName = "cost";
            this.DataGridTextBoxColumn1.Width = 110;
            // 
            // DataGridTextBoxColumn2
            // 
            this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataGridTextBoxColumn2.Format = "";
            this.DataGridTextBoxColumn2.FormatInfo = null;
            this.DataGridTextBoxColumn2.HeaderText = "折让比率";
            this.DataGridTextBoxColumn2.MappingName = "discountrate";
            this.DataGridTextBoxColumn2.Width = 80;
            // 
            // frmCardAddupDisc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(384, 350);
            this.Controls.Add(this.dgCardAddUpdis);
            this.Controls.Add(this.ToolBar1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCardAddupDisc";
            this.Text = "会员卡累计折让比率";
            this.Load += new System.EventHandler(this.frmCardAddupDisc_Load);
            this.Closed += new System.EventHandler(this.frmCardAddupDisc_Closed);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardAddUpdis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		//返回会员累计折让比率列表
		private void LoadCardAddupDisList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM ClubAddUpDisc", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "ClubAddUpDisc");
				dgCardAddUpdis.DataSource = null;
				dgCardAddUpdis.DataSource = dbDS;
				dgCardAddUpdis.DataMember = "ClubAddUpDisc";
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
		
		//添加 会员累计折让
		private bool AddData(string cost, string discountrate)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select cost from ClubAddUpDisc where cost>=" + cost, conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该累计金额
				{
					MessageBox.Show("已经存在等于或者大于该累计金额的折让比率记录！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into ClubAddUpDisc (cost,discountrate) " + "values (" + cost + "," + discountrate + ")";
					
					selectCMD.ExecuteNonQuery();
					
					//更新会员的累计消费折扣
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update ClubCard set " + "discountrate=" + discountrate + " where totalcost>=" + cost;
					
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
		
		//删除会员累计折让比率
		private bool DelCardAddupDis(string cost)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from ClubAddUpDisc where cost=" + cost;
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
		
		private void frmCardAddupDisc_Load(System.Object sender, System.EventArgs e)
		{
			LoadCardAddupDisList();
		}
		
		private void frmCardAddupDisc_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmCardAUD = null;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown1.Value < 100)
			{
				MessageBox.Show("累计金额太少！");
				NumericUpDown1.Focus();
				return;
			}
			if (NumericUpDown2.Value < 50)
			{
				MessageBox.Show("折让比率太低！");
				NumericUpDown2.Focus();
				return;
			}
			
			if (Label3.Text == "添加记录")
			{
				if (AddData(NumericUpDown1.Text, NumericUpDown2.Text))
				{
					MessageBox.Show("添加记录成功！");
					LoadCardAddupDisList();
					
					NumericUpDown1.Value = 800;
					NumericUpDown2.Value = 100;
					
                    //if (MessageBox.Show("继续添加新的累计折让吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    //{
						NumericUpDown1.Focus();
                    //}
                    //else
                    //{
                    //    rms_var.frmCardAUD.dgCardAddUpdis.Height = rms_var.frmCardAUD.Height - rms_var.frmCardAUD.ToolBar1.Height - 35;
                    //    rms_var.frmCardAUD.Panel1.Visible = false;
                    //}
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
						NumericUpDown1.Text = "";
						NumericUpDown2.Text = "";
						dgCardAddUpdis.Height = dgCardAddUpdis.Height - Panel1.Height - 5;
						Panel1.Visible = true;
						this.AcceptButton = Button1;
						this.CancelButton = Button2;
						NumericUpDown1.Focus();
					}
					break;
				case 1: //删除当前数据
					if (! (dgCardAddUpdis.CurrentRowIndex < 0))
					{
						if (MessageBox.Show("确定要删除当前选中的累计折让比率吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelCardAddupDis(dgCardAddUpdis[dgCardAddUpdis.CurrentRowIndex, 0].ToString()))
							{
								LoadCardAddupDisList();
							}
						}
					}
					break;
				case 3:
					this.Close();
					break;
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			rms_var.frmCardAUD.dgCardAddUpdis.Height = rms_var.frmCardAUD.Height - rms_var.frmCardAUD.ToolBar1.Height - 35;
			rms_var.frmCardAUD.Panel1.Visible = false;
		}
	}
	
}
