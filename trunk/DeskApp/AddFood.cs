using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class AddFood : System.Windows.Forms.Form
	{
		
		public double FoodQuantity;
		public string FoodOperandi;
		public string FoodTaste;
		public double FoodUnitPrice;
		
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
		internal System.Windows.Forms.NumericUpDown numFoodQuantity;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.CheckedListBox clbOperandi;
		internal System.Windows.Forms.CheckedListBox clbTaste;
		internal System.Windows.Forms.TextBox txtOperandi;
		internal System.Windows.Forms.TextBox txtTaste;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.NumericUpDown numFoodPrice;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddFood));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(AddFood_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.numFoodQuantity = new System.Windows.Forms.NumericUpDown();
			this.numFoodQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFoodQuantity_KeyPress);
			this.clbOperandi = new System.Windows.Forms.CheckedListBox();
			this.clbOperandi.SelectedIndexChanged += new System.EventHandler(this.clbOperandi_SelectedIndexChanged);
			this.clbOperandi.Leave += new System.EventHandler(this.clbOperandi_Leave);
			this.clbTaste = new System.Windows.Forms.CheckedListBox();
			this.clbTaste.SelectedIndexChanged += new System.EventHandler(this.clbTaste_SelectedIndexChanged);
			this.clbTaste.Leave += new System.EventHandler(this.clbTaste_Leave);
			this.txtOperandi = new System.Windows.Forms.TextBox();
			this.txtTaste = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.numFoodPrice = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize) this.numFoodQuantity).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numFoodPrice).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Font = new System.Drawing.Font("宋体", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(336, 23);
			this.Label1.TabIndex = 7;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "菜品数量：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//numFoodQuantity
			//
			this.numFoodQuantity.DecimalPlaces = 2;
			this.numFoodQuantity.Location = new System.Drawing.Point(88, 56);
			this.numFoodQuantity.Name = "numFoodQuantity";
			this.numFoodQuantity.Size = new System.Drawing.Size(64, 21);
			this.numFoodQuantity.TabIndex = 0;
			this.numFoodQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFoodQuantity.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//clbOperandi
			//
			this.clbOperandi.BackColor = System.Drawing.SystemColors.Window;
			this.clbOperandi.CheckOnClick = true;
			this.clbOperandi.Location = new System.Drawing.Point(24, 120);
			this.clbOperandi.Name = "clbOperandi";
			this.clbOperandi.Size = new System.Drawing.Size(152, 212);
			this.clbOperandi.TabIndex = 1;
			//
			//clbTaste
			//
			this.clbTaste.CheckOnClick = true;
			this.clbTaste.Location = new System.Drawing.Point(192, 120);
			this.clbTaste.Name = "clbTaste";
			this.clbTaste.Size = new System.Drawing.Size(152, 212);
			this.clbTaste.TabIndex = 3;
			//
			//txtOperandi
			//
			this.txtOperandi.Location = new System.Drawing.Point(24, 336);
			this.txtOperandi.Name = "txtOperandi";
			this.txtOperandi.Size = new System.Drawing.Size(152, 21);
			this.txtOperandi.TabIndex = 2;
			this.txtOperandi.Text = "";
			//
			//txtTaste
			//
			this.txtTaste.Location = new System.Drawing.Point(192, 336);
			this.txtTaste.Name = "txtTaste";
			this.txtTaste.Size = new System.Drawing.Size(152, 21);
			this.txtTaste.TabIndex = 4;
			this.txtTaste.Text = "";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(24, 96);
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 9;
			this.Label3.Text = "做法：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(192, 96);
			this.Label4.Name = "Label4";
			this.Label4.TabIndex = 10;
			this.Label4.Text = "口味：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(176, 376);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 5;
			this.Button1.Text = "确定";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(256, 376);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 6;
			this.Button2.Text = "放弃";
			//
			//Label5
			//
			this.Label5.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label5.ForeColor = System.Drawing.Color.Navy;
			this.Label5.Location = new System.Drawing.Point(152, 56);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 11;
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label6
			//
			this.Label6.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold);
			this.Label6.ForeColor = System.Drawing.Color.Navy;
			this.Label6.Location = new System.Drawing.Point(232, 56);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(48, 23);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "单价：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label7
			//
			this.Label7.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold);
			this.Label7.ForeColor = System.Drawing.Color.Navy;
			this.Label7.Location = new System.Drawing.Point(280, 56);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(64, 23);
			this.Label7.TabIndex = 13;
			this.Label7.Text = "Label7";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//numFoodPrice
			//
			this.numFoodPrice.Location = new System.Drawing.Point(280, 56);
			this.numFoodPrice.Maximum = new decimal(new int[] {100000, 0, 0, 0});
			this.numFoodPrice.Name = "numFoodPrice";
			this.numFoodPrice.Size = new System.Drawing.Size(64, 21);
			this.numFoodPrice.TabIndex = 14;
			this.numFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFoodPrice.Visible = false;
			//
			//AddFood
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(368, 416);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txtTaste);
			this.Controls.Add(this.txtOperandi);
			this.Controls.Add(this.clbTaste);
			this.Controls.Add(this.clbOperandi);
			this.Controls.Add(this.numFoodQuantity);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.numFoodPrice);
			this.Controls.Add(this.Label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddFood";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "菜品信息";
			((System.ComponentModel.ISupportInitialize) this.numFoodQuantity).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numFoodPrice).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
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
				clbOperandi.Items.Clear();
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					clbOperandi.Items.Add(dbDS.Tables[0].Rows[i][0], false);
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
				clbTaste.Items.Clear();
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					clbTaste.Items.Add(dbDS.Tables[0].Rows[i][0], false);
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
		
		
		private void clbOperandi_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtOperandi.Text = "";
			for (int i = 0; i <= clbOperandi.Items.Count - 1; i++)
			{
				if (clbOperandi.GetItemChecked(i))
				{
					if (txtOperandi.Text.Trim() == "")
					{
                        txtOperandi.Text = clbOperandi.Items[i].ToString();
					}
					else
					{
						txtOperandi.Text = txtOperandi.Text + "," + (clbOperandi.Items[i]);
					}
					
				}
			}
		}
		
		private void clbOperandi_Leave(object sender, System.EventArgs e)
		{
			txtOperandi.Text = "";
			for (int i = 0; i <= clbOperandi.Items.Count - 1; i++)
			{
				if (clbOperandi.GetItemChecked(i))
				{
					if (txtOperandi.Text.Trim() == "")
					{
                        txtOperandi.Text = clbOperandi.Items[i].ToString();
					}
					else
					{
						txtOperandi.Text = txtOperandi.Text + "," + (clbOperandi.Items[i]);
					}
					
				}
			}
		}
		
		private void AddFood_Load(System.Object sender, System.EventArgs e)
		{
			LoadFoodOperandi();
			LoadFoodTaste();
			numFoodQuantity.Select(0, numFoodQuantity.Text.Length);
		}
		
		private void numFoodQuantity_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar ==(char)27)
			{
				if (numFoodQuantity.Value > 0)
				{
					FoodQuantity = double.Parse(numFoodQuantity.Text);
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
		
		private void clbTaste_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtTaste.Text = "";
			for (int i = 0; i <= clbTaste.Items.Count - 1; i++)
			{
				if (clbTaste.GetItemChecked(i))
				{
					if (txtTaste.Text.Trim() == "")
					{
                        txtTaste.Text = clbTaste.Items[i].ToString();
					}
					else
					{
						txtTaste.Text = txtTaste.Text + "," + (clbTaste.Items[i]);
					}
					
				}
			}
		}
		
		private void clbTaste_Leave(object sender, System.EventArgs e)
		{
			txtTaste.Text = "";
			for (int i = 0; i <= clbTaste.Items.Count - 1; i++)
			{
				if (clbTaste.GetItemChecked(i))
				{
					if (txtTaste.Text.Trim() == "")
					{
                        txtTaste.Text = clbTaste.Items[i].ToString();
					}
					else
					{
						txtTaste.Text = txtTaste.Text + "," + (clbTaste.Items[i]);
					}
				}
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (numFoodQuantity.Value > 0)
			{
				FoodQuantity = double.Parse(numFoodQuantity.Text);
				FoodOperandi = txtOperandi.Text;
				FoodTaste = txtTaste.Text;
				if (numFoodPrice.Visible)
				{
					FoodUnitPrice = (double) numFoodPrice.Value;
				}
				else
				{
                    FoodUnitPrice = Convert.ToDouble(Label7.Text);
				}
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("菜品数量不能为 0，请输入或调整为大于 0 的数字");
			}
		}
		
	}
	
}
