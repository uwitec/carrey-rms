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
	public class frmAccess : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAccess()
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
		internal System.Windows.Forms.ToolBarButton ToolBarButton7;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton4;
		internal System.Windows.Forms.ToolBarButton ToolBarButton5;
		internal System.Windows.Forms.DataGrid dgOp;
		internal System.Windows.Forms.ToolBarButton ToolBarButton6;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmAccess_Load);
			base.Closed += new System.EventHandler(frmAccess_Closed);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAccess));
			this.dgOp = new System.Windows.Forms.DataGrid();
			this.dgOp.DoubleClick += new System.EventHandler(this.dgOp_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.ToolBar1 = new System.Windows.Forms.ToolBar();
			this.ToolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolBar1_ButtonClick);
			this.ToolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ToolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
			((System.ComponentModel.ISupportInitialize) this.dgOp).BeginInit();
			this.SuspendLayout();
			//
			//dgOp
			//
			this.dgOp.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgOp.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgOp.BackColor = System.Drawing.Color.GhostWhite;
			this.dgOp.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgOp.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgOp.CaptionForeColor = System.Drawing.Color.White;
			this.dgOp.DataMember = "";
			this.dgOp.FlatMode = true;
			this.dgOp.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgOp.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgOp.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgOp.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgOp.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgOp.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgOp.LinkColor = System.Drawing.Color.Teal;
			this.dgOp.Location = new System.Drawing.Point(0, 56);
			this.dgOp.Name = "dgOp";
			this.dgOp.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgOp.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgOp.ReadOnly = true;
			this.dgOp.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgOp.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgOp.Size = new System.Drawing.Size(496, 310);
			this.dgOp.TabIndex = 4;
			this.dgOp.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgOp;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridBoolColumn2, this.DataGridTextBoxColumn6, this.DataGridBoolColumn1});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "operator";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "操作员帐号";
			this.DataGridTextBoxColumn1.MappingName = "OperatorID";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "雇员编号";
			this.DataGridTextBoxColumn2.MappingName = "empid";
			this.DataGridTextBoxColumn2.Width = 75;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "雇员姓名";
			this.DataGridTextBoxColumn3.MappingName = "name";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "所属部门";
			this.DataGridTextBoxColumn4.MappingName = "deptname";
			this.DataGridTextBoxColumn4.Width = 75;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "暂停使用";
			this.DataGridBoolColumn1.MappingName = "disabled";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 75;
			//
			//ToolBar1
			//
			this.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {this.ToolBarButton1, this.ToolBarButton2, this.ToolBarButton3, this.ToolBarButton9, this.ToolBarButton6, this.ToolBarButton4, this.ToolBarButton5, this.ToolBarButton7});
			this.ToolBar1.ButtonSize = new System.Drawing.Size(50, 48);
			this.ToolBar1.DropDownArrows = true;
			this.ToolBar1.ImageList = this.ImageList1;
			this.ToolBar1.Location = new System.Drawing.Point(0, 0);
			this.ToolBar1.Name = "ToolBar1";
			this.ToolBar1.ShowToolTips = true;
			this.ToolBar1.Size = new System.Drawing.Size(496, 55);
			this.ToolBar1.TabIndex = 3;
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
			//ToolBarButton6
			//
			this.ToolBarButton6.ImageIndex = 6;
			this.ToolBarButton6.Text = "密码";
			//
			//ToolBarButton4
			//
			this.ToolBarButton4.ImageIndex = 4;
			this.ToolBarButton4.Text = "权限";
			//
			//ToolBarButton5
			//
			this.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			//
			//ToolBarButton7
			//
			this.ToolBarButton7.ImageIndex = 5;
			this.ToolBarButton7.Text = "关闭";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.MappingName = "PPC_PSW";
			this.DataGridTextBoxColumn6.NullText = "";
			this.DataGridTextBoxColumn6.Width = 0;
			//
			//DataGridBoolColumn2
			//
			this.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn2.FalseValue = "1";
			this.DataGridBoolColumn2.HeaderText = "禁用PPC";
			this.DataGridBoolColumn2.MappingName = "PPC";
			this.DataGridBoolColumn2.NullText = "";
			this.DataGridBoolColumn2.NullValue = resources.GetObject("DataGridBoolColumn2.NullValue");
			this.DataGridBoolColumn2.TrueValue = "0";
			this.DataGridBoolColumn2.Width = 75;
			//
			//frmAccess
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(496, 366);
			this.Controls.Add(this.dgOp);
			this.Controls.Add(this.ToolBar1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmAccess";
			this.Text = "操作员帐号管理及权限设置";
			((System.ComponentModel.ISupportInitialize) this.dgOp).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回操作员列表
		private void LoadOperatorList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM view_operator", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "Operator");
				dgOp.DataSource = null;
				dgOp.DataSource = dbDS;
				dgOp.DataMember = "Operator";
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
		
		//编辑操作员信息
		private void EditOPInfo()
		{
			frmEditOp editop = new frmEditOp();
			editop.GetEmplList();
			editop.TextBox1.Text =dgOp[dgOp.CurrentRowIndex, 0].ToString(); //编号
			editop.ComboBox1.Text = dgOp[dgOp.CurrentRowIndex, 2].ToString(); //姓名
			editop.CheckBox1.Checked =dgOp[dgOp.CurrentRowIndex, 6].ToString()=="1"?true:false; //禁用操作员
			editop.CheckBox2.Checked =!(dgOp[dgOp.CurrentRowIndex, 4].ToString()=="1"?true:false); //禁用PPC
			if (!(dgOp[dgOp.CurrentRowIndex, 4].ToString()=="1"?true:false))
			{
				editop.TextBox7.Text = dgOp[dgOp.CurrentRowIndex, 5].ToString();
			}
			
			editop.frmMode = 2; //修改记录
			editop.Text = "修改操作员信息";
			editop.OldOPCode =dgOp[dgOp.CurrentRowIndex, 0].ToString(); //保存原始编号
			
			editop.ShowDialog();
			if (editop.DialogResult == DialogResult.OK)
			{
				LoadOperatorList();
			}
		}
		
		//删除操作员
		private bool DelOprt(string opid)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from Operator where Operatorid='" + opid + "'";
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
		
		private void frmAccess_Load(System.Object sender, System.EventArgs e)
		{
			LoadOperatorList();
		}
		
		private void dgOp_DoubleClick(System.Object sender, System.EventArgs e)
		{
			if (! (dgOp.CurrentRowIndex < 0))
			{
				EditOPInfo();
			}
		}
		
		private void ToolBar1_ButtonClick(System.Object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (ToolBar1.Buttons.IndexOf(e.Button))
			{
				case 0: //添加数据
					frmEditOp editop = new frmEditOp();
					editop.GetEmplList();
					
					editop.frmMode = 1; //添加记录
					editop.Text = "添加操作员信息";
					
					editop.ShowDialog();
					if (editop.DialogResult == DialogResult.OK)
					{
						LoadOperatorList();
					}
					break;
				case 1: //修改数据
					if (! (dgOp.CurrentRowIndex < 0))
					{
						EditOPInfo();
					}
					break;
				case 2: //删除当前数据
					if (! (dgOp.CurrentRowIndex < 0))
					{
                        if (MessageBox.Show("确定要删除当前选中的 " + dgOp[dgOp.CurrentRowIndex, 0].ToString().Trim() + " 帐号吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						{
							//'删除操作
                            if (DelOprt(dgOp[dgOp.CurrentRowIndex, 0].ToString()))
							{
								LoadOperatorList();
							}
						}
					}
					break;
				case 4: //密码
					frmEditPsw frmeditpassword = new frmEditPsw();
					frmeditpassword.ShowDialog();
					if (frmeditpassword.DialogResult == DialogResult.OK)
					{
						//更新当前操作员帐号的密码
						System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
						conn.ConnectionString = rms_var.ConnStr;
						try
						{
							
							SqlCommand selectCMD = new SqlCommand();
							selectCMD.Connection = conn;
							selectCMD.CommandText = "update Operator set " + "password='" + rms_var.MD5Crypt(frmeditpassword.TextBox1.Text) + "' " + "where operatorid='" + dgOp[dgOp.CurrentRowIndex, 0] + "'";
							selectCMD.CommandTimeout = 30;
							conn.Open();
							selectCMD.ExecuteNonQuery();
							MessageBox.Show("密码修改成功！");
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
					break;
				case 5: //权限
					frmEditAccess frmeditacs = new frmEditAccess();
                    frmeditacs.OpID = dgOp[dgOp.CurrentRowIndex, 0].ToString(); //保存帐号，用于更新
					frmeditacs.ShowDialog();
					break;
				case 7:
					this.Close();
					break;
					
			}
		}
		
		private void frmAccess_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmacs = null;
		}
	}
	
}
