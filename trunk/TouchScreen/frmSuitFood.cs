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
		public class frmSuitFood : System.Windows.Forms.Form
		{
			
			private SuitFoodButtonList SuitFoodBtnList;
			private int SuitFoodPageInterval = 60;
			
			private frmInputPanel frminptForm;
			
			public string SuitCode;
			public double SuitQuantity = 0;
			
			#region  Windows 窗体设计器生成的代码
			
			public frmSuitFood()
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
			internal System.Windows.Forms.Button Button1;
			internal System.Windows.Forms.Button Button2;
			internal System.Windows.Forms.Panel Panel1;
			internal System.Windows.Forms.Button Button3;
			internal System.Windows.Forms.Button Button4;
			internal System.Windows.Forms.ImageList ImageList1;
			internal System.Windows.Forms.TextBox TextBox1;
			internal System.Windows.Forms.Label Label1;
			[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
				this.components = new System.ComponentModel.Container();
				base.Load += new System.EventHandler(frmSuitFood_Load);
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSuitFood));
				this.Button1 = new System.Windows.Forms.Button();
				this.Button1.Click += new System.EventHandler(this.Button1_Click);
				this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
				this.Button2 = new System.Windows.Forms.Button();
				this.Panel1 = new System.Windows.Forms.Panel();
				this.Button3 = new System.Windows.Forms.Button();
				this.Button3.Click += new System.EventHandler(this.Button3_Click);
				this.Button4 = new System.Windows.Forms.Button();
				this.Button4.Click += new System.EventHandler(this.Button4_Click);
				this.TextBox1 = new System.Windows.Forms.TextBox();
				this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
				this.TextBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
				this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
				this.TextBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
				this.Label1 = new System.Windows.Forms.Label();
				this.SuspendLayout();
				//
				//Button1
				//
				this.Button1.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button1.ImageIndex = 0;
				this.Button1.ImageList = this.ImageList1;
				this.Button1.Location = new System.Drawing.Point(296, 136);
				this.Button1.Name = "Button1";
				this.Button1.Size = new System.Drawing.Size(64, 40);
				this.Button1.TabIndex = 1;
				//
				//ImageList1
				//
				this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
				this.ImageList1.ImageSize = new System.Drawing.Size(32, 32);
				this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
				this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
				//
				//Button2
				//
				this.Button2.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
				this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button2.ImageIndex = 1;
				this.Button2.ImageList = this.ImageList1;
				this.Button2.Location = new System.Drawing.Point(296, 176);
				this.Button2.Name = "Button2";
				this.Button2.Size = new System.Drawing.Size(64, 40);
				this.Button2.TabIndex = 2;
				//
				//Panel1
				//
				this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel1.Location = new System.Drawing.Point(8, 8);
				this.Panel1.Name = "Panel1";
				this.Panel1.Size = new System.Drawing.Size(280, 208);
				this.Panel1.TabIndex = 4;
				//
				//Button3
				//
				this.Button3.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button3.ImageIndex = 5;
				this.Button3.ImageList = this.ImageList1;
				this.Button3.Location = new System.Drawing.Point(296, 8);
				this.Button3.Name = "Button3";
				this.Button3.Size = new System.Drawing.Size(64, 40);
				this.Button3.TabIndex = 5;
				//
				//Button4
				//
				this.Button4.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button4.ImageIndex = 4;
				this.Button4.ImageList = this.ImageList1;
				this.Button4.Location = new System.Drawing.Point(296, 48);
				this.Button4.Name = "Button4";
				this.Button4.Size = new System.Drawing.Size(64, 40);
				this.Button4.TabIndex = 6;
				//
				//TextBox1
				//
				this.TextBox1.Location = new System.Drawing.Point(296, 112);
				this.TextBox1.Name = "TextBox1";
				this.TextBox1.Size = new System.Drawing.Size(64, 23);
				this.TextBox1.TabIndex = 7;
				this.TextBox1.Text = "1";
				this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
				//
				//Label1
				//
				this.Label1.Location = new System.Drawing.Point(296, 88);
				this.Label1.Name = "Label1";
				this.Label1.Size = new System.Drawing.Size(64, 23);
				this.Label1.TabIndex = 8;
				this.Label1.Text = "数量：";
				this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
				//
				//frmSuitFood
				//
				this.AcceptButton = this.Button1;
				this.AutoScaleBaseSize = new System.Drawing.Size(8, 16);
				this.CancelButton = this.Button2;
				this.ClientSize = new System.Drawing.Size(370, 224);
				this.Controls.Add(this.Label1);
				this.Controls.Add(this.TextBox1);
				this.Controls.Add(this.Button4);
				this.Controls.Add(this.Button3);
				this.Controls.Add(this.Panel1);
				this.Controls.Add(this.Button2);
				this.Controls.Add(this.Button1);
				this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
				this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "frmSuitFood";
				this.Text = "选择套餐";
				this.ResumeLayout(false);
				
			}
			
			#endregion
			
			//返回套餐列表
			private void LoadSuitsList()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM suit", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDS.Clear();
					dbDA.Fill(dbDS, "Suit");
					//dgSuitFood.DataSource = Nothing
					//dgSuitFood.DataSource = dbDS
					//dgSuitFood.DataMember = "Suit"
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
			
			private void GetSuits()
			{
				if (SuitFoodBtnList != null)
				{
					SuitFoodBtnList.RemoveAll();
					SuitFoodBtnList = null;
				}
				SuitFoodBtnList = new SuitFoodButtonList(Panel1, 93, 40, Color.LightBlue, Color.FromArgb(255, 128, 128), 3);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM suit", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDS.Clear();
					dbDA.Fill(dbDS, "Suit");
					if (dbDS.Tables[0].Rows.Count > 0)
					{
						for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
						{
							SuitFoodBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["suitcode"].ToString(), dbDS.Tables[0].Rows[i]["suitname"].ToString(), (System.Convert.ToDouble(dbDS.Tables[0].Rows[i]["standardsum"]).ToString("{#,##0:N2}")));
						}
						SuitCode = dbDS.Tables[0].Rows[0]["suitcode"].ToString();
						SuitFoodBtnList.SelectItem(0);
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
			
			private void frmSuitFood_Load(System.Object sender, System.EventArgs e)
			{
				frminptForm = new frmInputPanel();
				//LoadSuitsList()
				rms_var.frmSuit = this;
				GetSuits();
			}
			
			private void Button3_Click(System.Object sender, System.EventArgs e)
			{
				if (SuitFoodBtnList[0].Top != 0)
				{
					for (int i = 0; i <= SuitFoodBtnList.Count - 1; i++)
					{
						SuitFoodBtnList[i].Top += SuitFoodPageInterval;
						SuitFoodBtnList.CurrentBtnTop += SuitFoodPageInterval;
					}
					SuitFoodBtnList.CurrentBtnTop = System.Convert.ToInt32(SuitFoodBtnList[SuitFoodBtnList.Count - 1].Top);
				}
			}
			
			private void Button4_Click(System.Object sender, System.EventArgs e)
			{
				if ((SuitFoodBtnList[SuitFoodBtnList.Count - 1].Top + SuitFoodBtnList[SuitFoodBtnList.Count - 1].Height) > Panel1.Height)
				{
					for (int i = 0; i <= SuitFoodBtnList.Count - 1; i++)
					{
						SuitFoodBtnList[i].Top -= SuitFoodPageInterval;
						SuitFoodBtnList.CurrentBtnTop -= SuitFoodPageInterval;
					}
					SuitFoodBtnList.CurrentBtnTop = System.Convert.ToInt32(SuitFoodBtnList[SuitFoodBtnList.Count - 1].Top);
				}
			}
			
			private void Button1_Click(System.Object sender, System.EventArgs e)
			{
				try
				{
					SuitQuantity = double.Parse(TextBox1.Text);
					this.DialogResult = DialogResult.OK;
				}
				catch (Exception)
				{
					MessageBox.Show("套餐数量输入错误，请核对后重新输入。");
				}
			}
			
			private void TextBox1_TextChanged(System.Object sender, System.EventArgs e)
			{
				
			}
			
			private void ShowInputPanel(TextBox TargetControl)
			{
                Point controlLocation = Point.Empty;
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
		}
		
	}
	
}
