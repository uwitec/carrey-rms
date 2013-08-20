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
	public class frmClubCard : System.Windows.Forms.Form
	{
		
		private string CurrentCardLstSqlCode = "SELECT * FROM view_ClubCard";
		
		#region  Windows 窗体设计器生成的代码
		
		public frmClubCard()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton12;
		internal System.Windows.Forms.ToolBarButton ToolBarButton10;
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.DataGrid dgCard;
		internal System.Windows.Forms.ToolBarButton ToolBarButton8;
		internal System.Windows.Forms.ToolBarButton ToolBarButton11;
		internal System.Windows.Forms.ToolBarButton ToolBarButton13;
		internal System.Windows.Forms.ToolBarButton ToolBarButton14;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmClubCard_Load);
			base.Closed += new System.EventHandler(frmClubCard_Closed);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClubCard));
			this.dgCard = new System.Windows.Forms.DataGrid();
			this.dgCard.DoubleClick += new System.EventHandler(this.dgCard_DoubleClick);
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
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize) this.dgCard).BeginInit();
			this.SuspendLayout();
			//
			//dgCard
			//
			this.dgCard.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgCard.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgCard.BackColor = System.Drawing.Color.GhostWhite;
			this.dgCard.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgCard.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgCard.CaptionForeColor = System.Drawing.Color.White;
			this.dgCard.DataMember = "";
			this.dgCard.FlatMode = true;
			this.dgCard.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgCard.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCard.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgCard.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgCard.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgCard.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgCard.LinkColor = System.Drawing.Color.Teal;
			this.dgCard.Location = new System.Drawing.Point(0, 56);
			this.dgCard.Name = "dgCard";
			this.dgCard.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgCard.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCard.ReadOnly = true;
			this.dgCard.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgCard.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgCard.Size = new System.Drawing.Size(568, 360);
			this.dgCard.TabIndex = 5;
			this.dgCard.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgCard;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn7, this.DataGridTextBoxColumn8, this.DataGridBoolColumn1});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "clubcard";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "卡号";
			this.DataGridTextBoxColumn1.MappingName = "clubcardno";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "客户编码";
			this.DataGridTextBoxColumn2.MappingName = "customercode";
			this.DataGridTextBoxColumn2.Width = 80;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "客户名称";
			this.DataGridTextBoxColumn3.MappingName = "customername";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "开户日期";
			this.DataGridTextBoxColumn4.MappingName = "begindate";
			this.DataGridTextBoxColumn4.Width = 90;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "开户金额";
			this.DataGridTextBoxColumn5.MappingName = "begincost";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "累计消费";
			this.DataGridTextBoxColumn6.MappingName = "totalcost";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "卡存余额";
			this.DataGridTextBoxColumn7.MappingName = "remaincost";
			this.DataGridTextBoxColumn7.Width = 75;
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "折让比率";
			this.DataGridTextBoxColumn8.MappingName = "discountrate";
			this.DataGridTextBoxColumn8.Width = 75;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "3";
			this.DataGridBoolColumn1.HeaderText = "启用";
			this.DataGridBoolColumn1.MappingName = "status";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 75;
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton8, this.ToolBarButton9, this.ToolBarButton5, this.ToolBarButton12, this.ToolBarButton11, this.ToolBarButton4, this.ToolBarButton13, this.ToolBarButton10, this.ToolBarButton6, this.ToolBarButton14, this.ToolBarButton7});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(568, 55);
			this.ToolBar1.TabIndex = 4;
			//
			//ToolBarButton1
			//
			this.ToolBarButton1.ImageIndex = 0;
			this.ToolBarButton1.Text = "启用";
			//
			//ToolBarButton2
			//
			this.ToolBarButton2.ImageIndex = 1;
			this.ToolBarButton2.Text = "暂停";
			//
			//ToolBarButton3
			//
			this.ToolBarButton3.ImageIndex = 2;
			this.ToolBarButton3.Text = "废止";
			//
			//ToolBarButton8
			//
			this.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton9
			//
			this.ToolBarButton9.ImageIndex = 3;
			this.ToolBarButton9.Text = "打折";
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.ImageIndex = 4;
			this.ToolBarButton5.Text = "续存";
			//
			//ToolBarButton12
			//
			this.ToolBarButton12.ImageIndex = 5;
			this.ToolBarButton12.Text = "密码";
			//
			//ToolBarButton11
			//
			this.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.ImageIndex = 6;
			this.ToolBarButton4.Text = "删除";
			//
			//ToolBarButton13
			//
			this.ToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton10
			//
			this.ToolBarButton10.ImageIndex = 7;
			this.ToolBarButton10.Text = "查询";
			//
			//ToolBarButton6
			//
			this.ToolBarButton6.ImageIndex = 8;
			this.ToolBarButton6.Text = "打印";
			//
			//ToolBarButton14
			//
			this.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 9;
			this.ToolBarButton7.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//frmClubCard
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(568, 414);
			this.Controls.Add(this.dgCard);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmClubCard";
			this.Text = "会员卡管理";
			((System.ComponentModel.ISupportInitialize) this.dgCard).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回会员卡信息列表
		private void LoadCardList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand(CurrentCardLstSqlCode, conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "ClubCard");
				dgCard.DataSource = null;
				dgCard.DataSource = dbDS;
				dgCard.DataMember = "ClubCard";
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
		
		//查询会员卡信息
		private void SearchCard(string cardcode, string cardstatus, string custname)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				CurrentCardLstSqlCode = "SELECT * FROM view_ClubCard where " + "clubcardno like '" + "%" + cardcode + "%'" + " and " + "status = '" + cardstatus + "'" + " and " + "customername like '" + "%" + custname + "%'";
				selectCMD.CommandText = CurrentCardLstSqlCode;
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "ClubCard");
				dgCard.DataSource = null;
				dgCard.DataSource = dbDS;
				dgCard.DataMember = "ClubCard";
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
		
		//删除会员卡
		private bool DelCard(string CardCode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//检测该该会员卡的状态，只有废止后才能删除
				SqlCommand selectCMD = new SqlCommand("select status from clubcard where clubcardno='" + CardCode + "'" + " and " + "status<>'3'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					MessageBox.Show("请先废止该会员卡后方可进行删除操作！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandText = "delete from clubcard where clubcardno='" + CardCode + "'";
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
		
		//启用会员卡
		private bool EnableCard(string cardcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//检测该该会员卡的状态
				SqlCommand selectCMD = new SqlCommand("select status from clubcard where clubcardno='" + cardcode + "'" + " and " + "status='2'", conn); //暂停状态才能进行启用操作
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //暂停状态
				{
					selectCMD.Connection = conn;
					selectCMD.CommandText = "update clubcard set " + "status='1' " + "where clubcardno='" + cardcode + "'";
					selectCMD.CommandTimeout = 30;
					selectCMD.ExecuteNonQuery();
					
					return true;
				}
				else
				{
					MessageBox.Show("该会员卡不是暂停状态，启用操作不能进行！");
					return false;
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
		
		//暂停会员卡
		private bool PauseCard(string cardcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//检测该该会员卡的状态
				SqlCommand selectCMD = new SqlCommand("select status from clubcard where clubcardno='" + cardcode + "'" + " and " + "status='1'", conn); //启用状态才能进行暂停操作
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //启用状态
				{
					selectCMD.Connection = conn;
					selectCMD.CommandText = "update clubcard set " + "status='2' " + "where clubcardno='" + cardcode + "'";
					selectCMD.CommandTimeout = 30;
					selectCMD.ExecuteNonQuery();
					
					return true;
				}
				else
				{
					MessageBox.Show("该会员卡不是启用状态，暂停操作不能进行！");
					return false;
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
		
		//废止会员卡
		private bool DisableCard(string cardcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//检测该该会员卡的状态
				SqlCommand selectCMD = new SqlCommand("select status from clubcard where clubcardno='" + cardcode + "'" + " and " + "status<>'3'", conn); //不是废止状态才能进行废止操作
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					selectCMD.Connection = conn;
					selectCMD.CommandText = "update clubcard set " + "status='3' " + "where clubcardno='" + cardcode + "'";
					selectCMD.CommandTimeout = 30;
					selectCMD.ExecuteNonQuery();
					
					return true;
				}
				else
				{
					MessageBox.Show("该会员卡已经是废止状态，操作不能进行！");
					return false;
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
		
		private void frmClubCard_Load(System.Object sender, System.EventArgs e)
		{
			LoadCardList();
		}
		
		private void frmClubCard_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmcard = null;
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //启用
					if (! (dgCard.CurrentRowIndex < 0))
					{
						if (MessageBox.Show("确定要启用 " + dgCard[dgCard.CurrentRowIndex, 0] + " 号会员卡？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
                            if (EnableCard(dgCard[dgCard.CurrentRowIndex, 0].ToString()))
							{
								MessageBox.Show("启用成功。");
								LoadCardList();
							}
						}
					}
					break;
					
				case 1: //暂停
					if (! (dgCard.CurrentRowIndex < 0))
					{
						if (MessageBox.Show("确定要暂停使用 " + dgCard[dgCard.CurrentRowIndex, 0] + " 号会员卡？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
                            if (PauseCard(dgCard[dgCard.CurrentRowIndex, 0].ToString()))
							{
								MessageBox.Show("暂停使用成功。");
								LoadCardList();
							}
						}
					}
					break;
					
				case 2: //废止
					if (! (dgCard.CurrentRowIndex < 0))
					{
						if (MessageBox.Show("确定要废止 " + dgCard[dgCard.CurrentRowIndex, 0] + " 号会员卡？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							if (MessageBox.Show("警告：一旦废止会员卡，您将无法再启用它！请谨慎操作！ " + "\r\n"+ "确实要废止 " + dgCard[dgCard.CurrentRowIndex, 0] + " 号会员卡吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
							{
                                if (DisableCard(dgCard[dgCard.CurrentRowIndex, 0].ToString()))
								{
									MessageBox.Show("废止操作成功。");
									LoadCardList();
								}
							}
						}
					}
					break;
					
				case 4: //打折
					if (! (dgCard.CurrentRowIndex < 0))
					{
						frmClubDiscount frmcd = new frmClubDiscount();
						frmcd.cardcode = dgCard[dgCard.CurrentRowIndex, 0].ToString();
						frmcd.ShowDialog();
						if (frmcd.DialogResult == DialogResult.OK)
						{
							LoadCardList();
						}
					}
					break;
					
				case 5: //续存
					if (! (dgCard.CurrentRowIndex < 0))
					{
						frmCardSupply frmds = new frmCardSupply();
                        frmds.cardcode = dgCard[dgCard.CurrentRowIndex, 0].ToString();
						frmds.ShowDialog();
						if (frmds.DialogResult == DialogResult.OK)
						{
							LoadCardList();
						}
					}
					break;
					
				case 6: //更改密码
					if (! (dgCard.CurrentRowIndex < 0))
					{
						frmCardPsw frmcp = new frmCardPsw();
                        frmcp.cardcode = dgCard[dgCard.CurrentRowIndex, 0].ToString();
						frmcp.ShowDialog();
						if (frmcp.DialogResult == DialogResult.OK)
						{
							LoadCardList();
						}
					}
					break;
					
				case 8: //删除当前数据
					if (! (dgCard.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的编号为 " + dgCard[dgCard.CurrentRowIndex, 0].ToString().Trim() + " 的会员卡吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//删除操作
                            if (DelCard(dgCard[dgCard.CurrentRowIndex, 0].ToString()))
							{
								LoadCardList();
							}
						}
					}
					break;
				case 10:
					frmCardSc frmcsc = new frmCardSc();
					frmcsc.ShowDialog();
					if (frmcsc.DialogResult == DialogResult.OK)
					{
						SearchCard(frmcsc.TextBox1.Text, System.Convert.ToString(frmcsc.ComboBox1.SelectedIndex + 1), frmcsc.TextBox2.Text);
					}
					break;
				case 11:
					if (MessageBox.Show("确定要进行打印操作吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						if (! PrintReport(CurrentCardLstSqlCode))
						{
							MessageBox.Show("打印失败！如果问题依然存在请联系系统管理员。");
						}
					}
					break;
				case 13:
					this.Close();
					break;
			}
		}
		
		private bool PrintReport(string sql)
		{
			if (report_var.card_cr == null)
			{
				report_var.card_cr = new ReportDocument();
			}
			else
			{
				report_var.card_cr.Close();
				report_var.card_cr = null;
				report_var.card_cr = new ReportDocument();
			}
			//检测报表文件是否存在
			if (File.Exists(report_var.GetReportPath() + report_var.card_rpt_filename))
			{
				report_var.card_cr = report_var.LoadReport(report_var.GetReportPath() + report_var.card_rpt_filename, sql, "view_ClubCard");
				
				TableLogOnInfo logOnInfo = new TableLogOnInfo();
				int i;
				
				// 对报表中的每个表依次循环。
				for (i = 0; i <= report_var.card_cr.Database.Tables.Count - 1; i++)
				{
					// 设置当前表的连接信息。
					logOnInfo.ConnectionInfo.ServerName = rms_var.ReadStrfromReg("SQLServerName", "");
					logOnInfo.ConnectionInfo.DatabaseName = rms_var.ReadStrfromReg("DataBaseName", "");
					logOnInfo.ConnectionInfo.UserID = rms_var.ReadStrfromReg("SQL_User", "");
					logOnInfo.ConnectionInfo.Password = rms_var.ReadStrfromReg("SQL_PSW", "");
					report_var.card_cr.Database.Tables[i].ApplyLogOnInfo(logOnInfo);
				}
				
				report_var.card_cr.PrintToPrinter(1, true, 1, 1);
				
				return true;
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return false;
			}
		}
		
		private void dgCard_DoubleClick(object sender, System.EventArgs e)
		{
			if (! (dgCard.CurrentRowIndex < 0))
			{
				frmCustInfo frmci = new frmCustInfo();
				//填充信息
				frmci.CustCode = dgCard[dgCard.CurrentRowIndex, 1].ToString(); //客户编号
                frmci.Cardcode = dgCard[dgCard.CurrentRowIndex, 0].ToString(); //会员卡编号
				frmci.ShowDialog();
			}
		}
	}
	
}
