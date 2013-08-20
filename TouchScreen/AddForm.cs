using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace TouchScreen
{
	namespace MySpace
	{
		public class AddForm : System.Windows.Forms.Form
		{
			
			public int frmmode = 0; //0= 加单 1=开台、新建单据
			public ArrayList BillTypeList;
			private int CurrentBillTypeNo = 0;
			public string CurrentBillTypeCode;
			public string CurrentBillTypeName;
			private frmInputPanel frminptForm;
			
			#region  Windows 窗体设计器生成的代码
			
			public AddForm()
			{
				
				//该调用是 Windows 窗体设计器所必需的。
				InitializeComponent();
				
				//在 InitializeComponent() 调用之后添加任何初始化
				BillTypeList = new ArrayList();
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
			internal System.Windows.Forms.Label Label1;
			internal System.Windows.Forms.Label Label2;
			internal System.Windows.Forms.TextBox TextBox1;
			internal System.Windows.Forms.Button Button1;
			internal System.Windows.Forms.Button Button2;
			internal System.Windows.Forms.Label Label4;
			internal System.Windows.Forms.Label Label3;
			internal System.Windows.Forms.TextBox TextBox2;
			internal System.Windows.Forms.Label Label5;
			internal System.Windows.Forms.TextBox TextBox3;
			internal System.Windows.Forms.Button Button3;
			internal System.Windows.Forms.Label Label6;
			internal System.Windows.Forms.Button Button4;
			internal System.Windows.Forms.ImageList ImageList1;
			[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
				this.components = new System.ComponentModel.Container();
				base.Load += new System.EventHandler(AddForm_Load);
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddForm));
				this.Label1 = new System.Windows.Forms.Label();
				this.Label2 = new System.Windows.Forms.Label();
				this.TextBox1 = new System.Windows.Forms.TextBox();
				this.TextBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
				this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
				this.TextBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
				this.Button1 = new System.Windows.Forms.Button();
				this.Button1.Click += new System.EventHandler(this.Button1_Click);
				this.Button2 = new System.Windows.Forms.Button();
				this.Label4 = new System.Windows.Forms.Label();
				this.Label3 = new System.Windows.Forms.Label();
				this.TextBox2 = new System.Windows.Forms.TextBox();
				this.TextBox2.Enter += new System.EventHandler(this.TextBox2_Enter);
				this.TextBox2.Click += new System.EventHandler(this.TextBox2_Click);
				this.TextBox2.Leave += new System.EventHandler(this.TextBox2_Leave);
				this.Label5 = new System.Windows.Forms.Label();
				this.TextBox3 = new System.Windows.Forms.TextBox();
				this.TextBox3.Enter += new System.EventHandler(this.TextBox3_Enter);
				this.TextBox3.Click += new System.EventHandler(this.TextBox3_Click);
				this.TextBox3.Leave += new System.EventHandler(this.TextBox3_Leave);
				this.Button3 = new System.Windows.Forms.Button();
				this.Button3.Click += new System.EventHandler(this.Button3_Click);
				this.Label6 = new System.Windows.Forms.Label();
				this.Button4 = new System.Windows.Forms.Button();
				this.Button4.Click += new System.EventHandler(this.Button4_Click);
				this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
				this.SuspendLayout();
				//
				//Label1
				//
				this.Label1.Location = new System.Drawing.Point(112, 96);
				this.Label1.Name = "Label1";
				this.Label1.TabIndex = 7;
				this.Label1.Text = "单据号：";
				this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				//
				//Label2
				//
				this.Label2.Location = new System.Drawing.Point(128, 136);
				this.Label2.Name = "Label2";
				this.Label2.Size = new System.Drawing.Size(208, 23);
				this.Label2.TabIndex = 8;
				this.Label2.Text = "单据类型";
				this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				//
				//TextBox1
				//
				this.TextBox1.Location = new System.Drawing.Point(208, 96);
				this.TextBox1.MaxLength = 10;
				this.TextBox1.Name = "TextBox1";
				this.TextBox1.Size = new System.Drawing.Size(136, 29);
				this.TextBox1.TabIndex = 3;
				this.TextBox1.Text = "";
				this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				//
				//Button1
				//
				this.Button1.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.Button1.ImageIndex = 0;
				this.Button1.ImageList = this.ImageList1;
				this.Button1.Location = new System.Drawing.Point(136, 280);
				this.Button1.Name = "Button1";
				this.Button1.Size = new System.Drawing.Size(96, 56);
				this.Button1.TabIndex = 0;
				//
				//Button2
				//
				this.Button2.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
				this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.Button2.ImageIndex = 1;
				this.Button2.ImageList = this.ImageList1;
				this.Button2.Location = new System.Drawing.Point(232, 280);
				this.Button2.Name = "Button2";
				this.Button2.Size = new System.Drawing.Size(96, 56);
				this.Button2.TabIndex = 1;
				//
				//Label4
				//
				this.Label4.Location = new System.Drawing.Point(88, 224);
				this.Label4.Name = "Label4";
				this.Label4.Size = new System.Drawing.Size(128, 23);
				this.Label4.TabIndex = 9;
				this.Label4.Text = "服务员编号：";
				this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				//
				//Label3
				//
				this.Label3.Location = new System.Drawing.Point(104, 56);
				this.Label3.Name = "Label3";
				this.Label3.Size = new System.Drawing.Size(112, 23);
				this.Label3.TabIndex = 6;
				this.Label3.Text = "开台人数：";
				this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				//
				//TextBox2
				//
				this.TextBox2.Enabled = false;
				this.TextBox2.Location = new System.Drawing.Point(208, 224);
				this.TextBox2.Name = "TextBox2";
				this.TextBox2.Size = new System.Drawing.Size(128, 29);
				this.TextBox2.TabIndex = 5;
				this.TextBox2.Text = "";
				//
				//Label5
				//
				this.Label5.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, ((System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label5.ForeColor = System.Drawing.Color.Navy;
				this.Label5.Location = new System.Drawing.Point(8, 8);
				this.Label5.Name = "Label5";
				this.Label5.Size = new System.Drawing.Size(456, 48);
				this.Label5.TabIndex = 10;
				this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				//
				//TextBox3
				//
				this.TextBox3.Location = new System.Drawing.Point(208, 56);
				this.TextBox3.Name = "TextBox3";
				this.TextBox3.Size = new System.Drawing.Size(136, 29);
				this.TextBox3.TabIndex = 11;
				this.TextBox3.Text = "1";
				this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				//
				//Button3
				//
				this.Button3.BackColor = System.Drawing.Color.Lavender;
				this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.Button3.ImageIndex = 2;
				this.Button3.ImageList = this.ImageList1;
				this.Button3.Location = new System.Drawing.Point(32, 136);
				this.Button3.Name = "Button3";
				this.Button3.Size = new System.Drawing.Size(88, 64);
				this.Button3.TabIndex = 12;
				//
				//Label6
				//
				this.Label6.BackColor = System.Drawing.Color.FromArgb((byte) (192), (byte) (192), (byte) (255));
				this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				this.Label6.Location = new System.Drawing.Point(128, 168);
				this.Label6.Name = "Label6";
				this.Label6.Size = new System.Drawing.Size(208, 32);
				this.Label6.TabIndex = 13;
				this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				//
				//Button4
				//
				this.Button4.BackColor = System.Drawing.Color.Lavender;
				this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
				this.Button4.ImageIndex = 3;
				this.Button4.ImageList = this.ImageList1;
				this.Button4.Location = new System.Drawing.Point(344, 136);
				this.Button4.Name = "Button4";
				this.Button4.Size = new System.Drawing.Size(88, 64);
				this.Button4.TabIndex = 14;
				//
				//ImageList1
				//
				this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
				this.ImageList1.ImageSize = new System.Drawing.Size(32, 32);
				this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
				this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
				//
				//AddForm
				//
				this.AutoScaleBaseSize = new System.Drawing.Size(10, 22);
				this.CancelButton = this.Button2;
				this.ClientSize = new System.Drawing.Size(466, 368);
				this.Controls.Add(this.Button4);
				this.Controls.Add(this.Label6);
				this.Controls.Add(this.Button3);
				this.Controls.Add(this.TextBox3);
				this.Controls.Add(this.Label5);
				this.Controls.Add(this.TextBox2);
				this.Controls.Add(this.Label3);
				this.Controls.Add(this.Label4);
				this.Controls.Add(this.Button2);
				this.Controls.Add(this.Button1);
				this.Controls.Add(this.TextBox1);
				this.Controls.Add(this.Label2);
				this.Controls.Add(this.Label1);
				this.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
				this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "AddForm";
				this.ShowInTaskbar = false;
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				this.Text = "添加单据";
				this.ResumeLayout(false);
				
			}
			
			#endregion
			
			private void ShowInputPanel(TextBox TargetControl)
			{
				Point controlLocation=Point.Empty;
                Point inputPanelLocation = Point.Empty;
				controlLocation = TargetControl.PointToScreen(controlLocation);
				Rectangle ScreenWorkArea = Screen.FromPoint(controlLocation).WorkingArea;
				//If Not frminptForm.Visible Then
				frminptForm.CurrentUsedControl = TargetControl;
				inputPanelLocation.X = controlLocation.X;
				inputPanelLocation.Y = controlLocation.Y + 30;
				if (controlLocation.X + frminptForm.Width > ScreenWorkArea.Width) //右边界超出屏幕
				{
					inputPanelLocation.X = ScreenWorkArea.Width - frminptForm.Width;
				}
				if (controlLocation.Y + TargetControl.Height + frminptForm.Height + 30 > ScreenWorkArea.Height) //下边界超出屏幕
				{
					inputPanelLocation.Y = controlLocation.Y - 30 - frminptForm.Height;
				}
				if (controlLocation.X < 0) //左边界超出屏幕
				{
					inputPanelLocation.X = 0;
				}
				frminptForm.SetBounds(inputPanelLocation.X, inputPanelLocation.Y, 592, 264);
				frminptForm.Show();
			}
			
			//返回单据类型列表，并填充列表框
			public void GetBillTypeList1()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT name FROM billtype order by name";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						//ComboBox1.Items.Add(dbDS.Tables(0).Rows(i).Item(0))
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
			}
			
			public void GetBillTypeList()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT name FROM billtype order by name";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						BillTypeList.Add(dbDS.Tables[0].Rows[i][0].ToString());
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
			}
			
			//返回消费单据类型列表，并填充列表框
			public void GetConsumeBillTypeList1()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT name FROM billtype where consumebill='1'";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						//ComboBox1.Items.Add(dbDS.Tables(0).Rows(i).Item(0).ToString)
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
			}
			
			public void GetConsumeBillTypeList()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT name FROM billtype where consumebill='1'";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						BillTypeList.Add(dbDS.Tables[0].Rows[i][0].ToString());
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
			}
			
			private void Button1_Click(System.Object sender, System.EventArgs e)
			{
				if (frmmode == 0) //加单
				{
					if (TextBox1.Text.Trim() == "")
					{
						MessageBox.Show("单据号不能为空！");
						TextBox1.Focus();
						TextBox1.SelectAll();
					}
					else //返回单据类型编码
					{
						//检测服务员是否存在()
						if (rms_var.EmpExists(TextBox2.Text))
						{
							CurrentBillTypeCode = rms_var.GetBillTypeCode(CurrentBillTypeName);
							if (CurrentBillTypeCode != "")
							{
								this.DialogResult = DialogResult.OK;
							}
							else
							{
								CurrentBillTypeCode = "";
								MessageBox.Show("没有选择单据类型，或者单据类型不存在！");
							}
						}
						else
						{
							MessageBox.Show("服务员不存在");
							TextBox2.Focus();
							TextBox2.SelectAll();
						}
						
					}
				}
				else //开台、新建单据
				{
					int OpenPsnCount;
					try
					{
						OpenPsnCount = int.Parse(TextBox3.Text);
					}
					catch (Exception)
					{
						MessageBox.Show("开台人数输入有误，请核对后重新输入。");
						TextBox3.Focus();
						TextBox3.Select(0, TextBox3.Text.Length);
						return;
					}
					if (! (OpenPsnCount > 0))
					{
						MessageBox.Show("开台人数不能小于或等于0");
						TextBox3.Focus();
						TextBox3.Select(0, TextBox3.Text.Length);
						return;
					}
					if (TextBox1.Text.Trim() == "")
					{
						MessageBox.Show("单据号不能为空！");
						TextBox1.Focus();
						TextBox1.SelectAll();
					}
					else //返回单据类型编码
					{
						//检测服务员是否存在()
						if (rms_var.EmpExists(TextBox2.Text))
						{
							CurrentBillTypeCode = rms_var.GetBillTypeCode(CurrentBillTypeName);
							if (CurrentBillTypeCode != "")
							{
								this.DialogResult = DialogResult.OK;
							}
							else
							{
								CurrentBillTypeCode = "";
								MessageBox.Show("没有选择单据类型，或者单据类型不存在！");
							}
						}
						else
						{
							MessageBox.Show("服务员不存在");
							TextBox2.Focus();
							TextBox2.SelectAll();
						}
					}
				}
			}
			
			private void AddForm_Load(System.Object sender, System.EventArgs e)
			{
				frminptForm = new frmInputPanel();
				//检测前台单据是否自动编号
				if (rms_var.GetSysSetup("autobalancebill") == "1") //自动生成前台单据编号
				{
					TextBox1.Text = rms_var.GenNewBalanceBillNo();
				}
				else
				{
					TextBox1.Text = "";
				}
			}
			
			private void TextBox1_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(TextBox1);
			}
			
			private void TextBox1_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(TextBox1);
			}
			
			private void TextBox1_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void TextBox2_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(TextBox2);
			}
			
			private void TextBox2_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(TextBox2);
			}
			
			private void TextBox2_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void TextBox3_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(TextBox3);
			}
			
			private void TextBox3_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(TextBox3);
			}
			
			private void TextBox3_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void Button4_Click(System.Object sender, System.EventArgs e)
			{
				if (CurrentBillTypeNo != BillTypeList.Count - 1)
				{
					CurrentBillTypeNo++;
					Label6.Text = BillTypeList[CurrentBillTypeNo].ToString();
					CurrentBillTypeName = Label6.Text;
				}
			}
			
			private void Button3_Click(System.Object sender, System.EventArgs e)
			{
				if (CurrentBillTypeNo != 0)
				{
					CurrentBillTypeNo--;
					Label6.Text = BillTypeList[CurrentBillTypeNo].ToString();
					CurrentBillTypeName = Label6.Text;
				}
			}
		}
		
	}
	
}
