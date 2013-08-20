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
		public class AddFood : System.Windows.Forms.Form
		{
			
			public double FoodQuantity;
			public string FoodOperandi;
			public string FoodTaste;
			public double FoodUnitPrice;
			
			private frmInputPanel frminptForm;
			
			private FoodOperandisButtonList FoodOperandisBtnList;
			private int FoodOperandisPageInterval = 150;
			
			private FoodTastesButtonList FoodTastesBtnList;
			private int FoodTastesPageInterval = 150;
			
			#region  Windows 窗体设计器生成的代码
			
			public AddFood()
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
			internal System.Windows.Forms.Label Label1;
			internal System.Windows.Forms.Label Label2;
			internal System.Windows.Forms.Label Label3;
			internal System.Windows.Forms.Label Label4;
			internal System.Windows.Forms.Button Button1;
			internal System.Windows.Forms.Button Button2;
			internal System.Windows.Forms.TextBox txtOperandi;
			internal System.Windows.Forms.TextBox txtTaste;
			internal System.Windows.Forms.Label Label5;
			internal System.Windows.Forms.TextBox TextBox1;
			internal System.Windows.Forms.Button Button3;
			internal System.Windows.Forms.Panel Panel1;
			internal System.Windows.Forms.Button Button4;
			internal System.Windows.Forms.Panel Panel2;
			internal System.Windows.Forms.Button Button5;
			internal System.Windows.Forms.Button Button6;
			internal System.Windows.Forms.ImageList ImageList1;
			internal System.Windows.Forms.Label Label6;
			internal System.Windows.Forms.Label Label7;
			internal System.Windows.Forms.TextBox numFoodPrice;
			[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
				this.components = new System.ComponentModel.Container();
				base.Load += new System.EventHandler(AddFood_Load);
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddFood));
				this.Label1 = new System.Windows.Forms.Label();
				this.Label2 = new System.Windows.Forms.Label();
				this.txtOperandi = new System.Windows.Forms.TextBox();
				this.txtOperandi.Enter += new System.EventHandler(this.txtOperandi_Enter);
				this.txtOperandi.Click += new System.EventHandler(this.txtOperandi_Click);
				this.txtOperandi.Leave += new System.EventHandler(this.txtOperandi_Leave);
				this.txtTaste = new System.Windows.Forms.TextBox();
				this.txtTaste.Enter += new System.EventHandler(this.txtTaste_Enter);
				this.txtTaste.Click += new System.EventHandler(this.txtTaste_Click);
				this.txtTaste.Leave += new System.EventHandler(this.txtTaste_Leave);
				this.Label3 = new System.Windows.Forms.Label();
				this.Label4 = new System.Windows.Forms.Label();
				this.Button1 = new System.Windows.Forms.Button();
				this.Button1.Click += new System.EventHandler(this.Button1_Click);
				this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
				this.Button2 = new System.Windows.Forms.Button();
				this.Label5 = new System.Windows.Forms.Label();
				this.TextBox1 = new System.Windows.Forms.TextBox();
				this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
				this.TextBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
				this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
				this.TextBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
				this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
				this.Button3 = new System.Windows.Forms.Button();
				this.Button3.Click += new System.EventHandler(this.Button3_Click);
				this.Panel1 = new System.Windows.Forms.Panel();
				this.Button4 = new System.Windows.Forms.Button();
				this.Button4.Click += new System.EventHandler(this.Button4_Click);
				this.Panel2 = new System.Windows.Forms.Panel();
				this.Button5 = new System.Windows.Forms.Button();
				this.Button5.Click += new System.EventHandler(this.Button5_Click);
				this.Button6 = new System.Windows.Forms.Button();
				this.Button6.Click += new System.EventHandler(this.Button6_Click);
				this.Label6 = new System.Windows.Forms.Label();
				this.Label7 = new System.Windows.Forms.Label();
				this.numFoodPrice = new System.Windows.Forms.TextBox();
				this.numFoodPrice.Enter += new System.EventHandler(this.numFoodPrice_Enter);
				this.numFoodPrice.Click += new System.EventHandler(this.numFoodPrice_Click);
				this.numFoodPrice.Leave += new System.EventHandler(this.numFoodPrice_Leave);
				this.SuspendLayout();
				//
				//Label1
				//
				this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				this.Label1.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
				this.Label1.Location = new System.Drawing.Point(16, 8);
				this.Label1.Name = "Label1";
				this.Label1.Size = new System.Drawing.Size(464, 48);
				this.Label1.TabIndex = 0;
				this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				//
				//Label2
				//
				this.Label2.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label2.Location = new System.Drawing.Point(16, 81);
				this.Label2.Name = "Label2";
				this.Label2.Size = new System.Drawing.Size(112, 23);
				this.Label2.TabIndex = 8;
				this.Label2.Text = "菜品数量：";
				this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//txtOperandi
				//
				this.txtOperandi.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.txtOperandi.Location = new System.Drawing.Point(16, 408);
				this.txtOperandi.Name = "txtOperandi";
				this.txtOperandi.Size = new System.Drawing.Size(224, 29);
				this.txtOperandi.TabIndex = 5;
				this.txtOperandi.Text = "";
				this.txtOperandi.Visible = false;
				//
				//txtTaste
				//
				this.txtTaste.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.txtTaste.Location = new System.Drawing.Point(256, 408);
				this.txtTaste.Name = "txtTaste";
				this.txtTaste.Size = new System.Drawing.Size(224, 29);
				this.txtTaste.TabIndex = 6;
				this.txtTaste.Text = "";
				this.txtTaste.Visible = false;
				//
				//Label3
				//
				this.Label3.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label3.Location = new System.Drawing.Point(16, 128);
				this.Label3.Name = "Label3";
				this.Label3.TabIndex = 9;
				this.Label3.Text = "做法：";
				this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//Label4
				//
				this.Label4.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label4.Location = new System.Drawing.Point(248, 128);
				this.Label4.Name = "Label4";
				this.Label4.TabIndex = 10;
				this.Label4.Text = "口味：";
				this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//Button1
				//
				this.Button1.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button1.ImageIndex = 0;
				this.Button1.ImageList = this.ImageList1;
				this.Button1.Location = new System.Drawing.Point(168, 432);
				this.Button1.Name = "Button1";
				this.Button1.Size = new System.Drawing.Size(80, 48);
				this.Button1.TabIndex = 0;
				this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
				this.Button2.Location = new System.Drawing.Point(248, 432);
				this.Button2.Name = "Button2";
				this.Button2.Size = new System.Drawing.Size(80, 48);
				this.Button2.TabIndex = 1;
				this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				//
				//Label5
				//
				this.Label5.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Label5.ForeColor = System.Drawing.Color.Navy;
				this.Label5.Location = new System.Drawing.Point(168, 72);
				this.Label5.Name = "Label5";
				this.Label5.Size = new System.Drawing.Size(120, 40);
				this.Label5.TabIndex = 11;
				this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//TextBox1
				//
				this.TextBox1.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.TextBox1.Location = new System.Drawing.Point(112, 78);
				this.TextBox1.Name = "TextBox1";
				this.TextBox1.Size = new System.Drawing.Size(56, 29);
				this.TextBox1.TabIndex = 12;
				this.TextBox1.Text = "1";
				this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				//
				//Button3
				//
				this.Button3.BackColor = System.Drawing.Color.Lavender;
				this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Button3.ImageIndex = 2;
				this.Button3.ImageList = this.ImageList1;
				this.Button3.Location = new System.Drawing.Point(16, 360);
				this.Button3.Name = "Button3";
				this.Button3.Size = new System.Drawing.Size(112, 48);
				this.Button3.TabIndex = 13;
				//
				//Panel1
				//
				this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel1.Location = new System.Drawing.Point(16, 152);
				this.Panel1.Name = "Panel1";
				this.Panel1.Size = new System.Drawing.Size(224, 208);
				this.Panel1.TabIndex = 14;
				//
				//Button4
				//
				this.Button4.BackColor = System.Drawing.Color.Lavender;
				this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Button4.ImageIndex = 3;
				this.Button4.ImageList = this.ImageList1;
				this.Button4.Location = new System.Drawing.Point(128, 360);
				this.Button4.Name = "Button4";
				this.Button4.Size = new System.Drawing.Size(112, 48);
				this.Button4.TabIndex = 15;
				//
				//Panel2
				//
				this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel2.Location = new System.Drawing.Point(256, 152);
				this.Panel2.Name = "Panel2";
				this.Panel2.Size = new System.Drawing.Size(224, 208);
				this.Panel2.TabIndex = 16;
				//
				//Button5
				//
				this.Button5.BackColor = System.Drawing.Color.Lavender;
				this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Button5.ImageIndex = 2;
				this.Button5.ImageList = this.ImageList1;
				this.Button5.Location = new System.Drawing.Point(256, 360);
				this.Button5.Name = "Button5";
				this.Button5.Size = new System.Drawing.Size(112, 48);
				this.Button5.TabIndex = 17;
				//
				//Button6
				//
				this.Button6.BackColor = System.Drawing.Color.Lavender;
				this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.Button6.ImageIndex = 3;
				this.Button6.ImageList = this.ImageList1;
				this.Button6.Location = new System.Drawing.Point(368, 360);
				this.Button6.Name = "Button6";
				this.Button6.Size = new System.Drawing.Size(112, 48);
				this.Button6.TabIndex = 18;
				//
				//Label6
				//
				this.Label6.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold);
				this.Label6.Location = new System.Drawing.Point(288, 72);
				this.Label6.Name = "Label6";
				this.Label6.Size = new System.Drawing.Size(72, 40);
				this.Label6.TabIndex = 19;
				this.Label6.Text = "单价：";
				this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//Label7
				//
				this.Label7.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold);
				this.Label7.Location = new System.Drawing.Point(352, 72);
				this.Label7.Name = "Label7";
				this.Label7.Size = new System.Drawing.Size(96, 40);
				this.Label7.TabIndex = 22;
				this.Label7.Text = "单价";
				this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				//
				//numFoodPrice
				//
				this.numFoodPrice.Font = new System.Drawing.Font("仿宋_GB2312", 14.25F, System.Drawing.FontStyle.Bold);
				this.numFoodPrice.Location = new System.Drawing.Point(352, 78);
				this.numFoodPrice.Name = "numFoodPrice";
				this.numFoodPrice.Size = new System.Drawing.Size(96, 29);
				this.numFoodPrice.TabIndex = 23;
				this.numFoodPrice.Text = "";
				this.numFoodPrice.Visible = false;
				//
				//AddFood
				//
				this.AutoScaleBaseSize = new System.Drawing.Size(8, 16);
				this.CancelButton = this.Button2;
				this.ClientSize = new System.Drawing.Size(498, 496);
				this.Controls.Add(this.numFoodPrice);
				this.Controls.Add(this.Label7);
				this.Controls.Add(this.Label6);
				this.Controls.Add(this.Button6);
				this.Controls.Add(this.Button5);
				this.Controls.Add(this.Panel2);
				this.Controls.Add(this.Button4);
				this.Controls.Add(this.Panel1);
				this.Controls.Add(this.Button3);
				this.Controls.Add(this.TextBox1);
				this.Controls.Add(this.Label5);
				this.Controls.Add(this.Button2);
				this.Controls.Add(this.Button1);
				this.Controls.Add(this.Label4);
				this.Controls.Add(this.Label3);
				this.Controls.Add(this.txtTaste);
				this.Controls.Add(this.txtOperandi);
				this.Controls.Add(this.Label2);
				this.Controls.Add(this.Label1);
				this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
				this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "AddFood";
				this.ShowInTaskbar = false;
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				this.Text = "菜品信息";
				this.ResumeLayout(false);
				
			}
			
			#endregion
			
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
			
			private void LoadFoodOperandi()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT name FROM foodoperandi", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					//clbOperandi.Items.Clear()
					//For i As Integer = 0 To dbDS.Tables(0).Rows.Count - 1
					//clbOperandi.Items.Add(dbDS.Tables(0).Rows(i).Item(0), False)
					//Next
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
			
			private void LoadFoodTaste()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT name FROM foodtaste", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					//clbTaste.Items.Clear()
					//For i As Integer = 0 To dbDS.Tables(0).Rows.Count - 1
					//clbTaste.Items.Add(dbDS.Tables(0).Rows(i).Item(0), False)
					//Next
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
			
			private void AddFood_Load(System.Object sender, System.EventArgs e)
			{
				frminptForm = new frmInputPanel();
				LoadFoodOperandi();
				LoadFoodTaste();
				TextBox1.Select(0, TextBox1.Text.Length);
				rms_var.frmAddFood = this;
				GetFoodOperandis();
				GetFoodTastes();
			}
			
			private void Button1_Click(System.Object sender, System.EventArgs e)
			{
				double Foodqty;
				try
				{
					Foodqty = double.Parse(TextBox1.Text);
				}
				catch (Exception)
				{
					MessageBox.Show("菜品数量输入有误，请核对后重新输入。");
					TextBox1.Focus();
					TextBox1.Select(0, TextBox1.Text.Length);
					return;
				}
				if (numFoodPrice.Visible)
				{
					try
					{
						FoodUnitPrice = double.Parse(numFoodPrice.Text);
					}
					catch (Exception)
					{
						MessageBox.Show("菜品单价输入有误，请核对后重新输入。");
						numFoodPrice.Focus();
						numFoodPrice.Select(0, numFoodPrice.Text.Length);
						return;
					}
				}
				if (Foodqty > 0)
				{
					FoodQuantity = double.Parse(Foodqty.ToString());
					FoodOperandi = txtOperandi.Text;
					FoodTaste = txtTaste.Text;
					if (numFoodPrice.Visible)
					{
						FoodUnitPrice = double.Parse(numFoodPrice.Text);
					}
					else
					{
						FoodUnitPrice = double.Parse(Label7.Text);
					}
					this.DialogResult = DialogResult.OK;
				}
				else
				{
					MessageBox.Show("菜品数量不能为 0，请输入或调整为大于 0 的数字");
				}
			}
			
			private void txtOperandi_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(txtOperandi);
			}
			
			private void txtOperandi_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(txtOperandi);
			}
			
			private void txtOperandi_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void txtTaste_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(txtTaste);
			}
			
			private void txtTaste_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(txtTaste);
			}
			
			private void txtTaste_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void TextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
			{
				if (e.KeyChar ==(char)27)
				{
					double Foodqty;
					try
					{
						Foodqty = double.Parse(TextBox1.Text);
					}
					catch (Exception)
					{
						MessageBox.Show("菜品数量输入有误，请核对后重新输入。");
						TextBox1.Focus();
						TextBox1.Select(0, TextBox1.Text.Length);
						return;
					}
					if (Foodqty > 0)
					{
						FoodQuantity = double.Parse(Foodqty.ToString());
						FoodOperandi = txtOperandi.Text;
						FoodTaste = txtTaste.Text;
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("菜品数量不能为 0，请输入或调整为大于 0 的数字");
					}
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
			
			public void GetFoodOperandis()
			{
				if (FoodOperandisBtnList != null)
				{
					FoodOperandisBtnList.RemoveAll();
					FoodOperandisBtnList = null;
				}
				FoodOperandisBtnList = new FoodOperandisButtonList(Panel1, 75, 45, Color.LightBlue, Color.FromArgb(255, 128, 128), 3);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT name FROM foodoperandi";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						FoodOperandisBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["name"].ToString());
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
			
			public void GetFoodTastes()
			{
				if (FoodTastesBtnList != null)
				{
					FoodTastesBtnList.RemoveAll();
					FoodTastesBtnList = null;
				}
				FoodTastesBtnList = new FoodTastesButtonList(Panel2, 75, 45, Color.LightBlue, Color.FromArgb(255, 128, 128), 3);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandText = "SELECT name FROM foodtaste";
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						FoodTastesBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["name"].ToString());
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
			
			private void Button3_Click(System.Object sender, System.EventArgs e)
			{
				if (FoodOperandisBtnList[0].Top != 0)
				{
					for (int i = 0; i <= FoodOperandisBtnList.Count - 1; i++)
					{
						FoodOperandisBtnList[i].Top += FoodOperandisPageInterval;
						FoodOperandisBtnList.CurrentBtnTop += FoodOperandisPageInterval;
					}
					FoodOperandisBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodOperandisBtnList[FoodOperandisBtnList.Count - 1].Top);
				}
			}
			
			
			private void Button4_Click(System.Object sender, System.EventArgs e)
			{
				if ((FoodOperandisBtnList[FoodOperandisBtnList.Count - 1].Top + FoodOperandisBtnList[FoodOperandisBtnList.Count - 1].Height) > Panel1.Height)
				{
					for (int i = 0; i <= FoodOperandisBtnList.Count - 1; i++)
					{
						FoodOperandisBtnList[i].Top -= FoodOperandisPageInterval;
						FoodOperandisBtnList.CurrentBtnTop -= FoodOperandisPageInterval;
					}
					FoodOperandisBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodOperandisBtnList[FoodOperandisBtnList.Count - 1].Top);
				}
			}
			
			private void Button5_Click(System.Object sender, System.EventArgs e)
			{
				if (FoodTastesBtnList[0].Top != 0)
				{
					for (int i = 0; i <= FoodTastesBtnList.Count - 1; i++)
					{
						FoodTastesBtnList[i].Top += FoodTastesPageInterval;
						FoodTastesBtnList.CurrentBtnTop += FoodTastesPageInterval;
					}
					FoodTastesBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodTastesBtnList[FoodTastesBtnList.Count - 1].Top);
				}
			}
			
			private void Button6_Click(System.Object sender, System.EventArgs e)
			{
				if ((FoodTastesBtnList[FoodTastesBtnList.Count - 1].Top + FoodTastesBtnList[FoodTastesBtnList.Count - 1].Height) > Panel1.Height)
				{
					for (int i = 0; i <= FoodTastesBtnList.Count - 1; i++)
					{
						FoodTastesBtnList[i].Top -= FoodTastesPageInterval;
						FoodTastesBtnList.CurrentBtnTop -= FoodTastesPageInterval;
					}
					FoodTastesBtnList.CurrentBtnTop = System.Convert.ToInt32(FoodTastesBtnList[FoodTastesBtnList.Count - 1].Top);
				}
			}
			
			private void numFoodPrice_Enter(object sender, System.EventArgs e)
			{
				ShowInputPanel(numFoodPrice);
			}
			
			private void numFoodPrice_Click(object sender, System.EventArgs e)
			{
				ShowInputPanel(numFoodPrice);
			}
			
			private void numFoodPrice_Leave(object sender, System.EventArgs e)
			{
				frminptForm.Hide();
			}
			
			private void TextBox1_TextChanged(System.Object sender, System.EventArgs e)
			{
				
			}
		}
		
	}
	
}
