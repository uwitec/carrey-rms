using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class AddForm : System.Windows.Forms.Form
	{
		
		public int frmmode = 0; //0= 加单 1=开台、新建单据
		public string CurrentBillTypeCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public AddForm()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddForm));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(AddForm_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(32, 56);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 7;
			this.Label1.Text = "单据号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(32, 80);
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 8;
			this.Label2.Text = "单据类型：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(128, 56);
			this.TextBox1.MaxLength = 10;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(128, 21);
			this.TextBox1.TabIndex = 1;
			this.TextBox1.Text = "";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(128, 80);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(128, 20);
			this.ComboBox1.TabIndex = 2;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(80, 144);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 4;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(160, 144);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 5;
			this.Button2.Text = "取消(&C)";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(32, 104);
			this.Label4.Name = "Label4";
			this.Label4.TabIndex = 9;
			this.Label4.Text = "服务员编号：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(32, 32);
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 6;
			this.Label3.Text = "开台人数：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(128, 32);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(128, 21);
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(128, 104);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(128, 21);
			this.TextBox2.TabIndex = 3;
			this.TextBox2.Text = "";
			//
			//Label5
			//
			this.Label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label5.ForeColor = System.Drawing.Color.Navy;
			this.Label5.Location = new System.Drawing.Point(16, 8);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(272, 23);
			this.Label5.TabIndex = 10;
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//AddForm
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(306, 184);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加单据";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回单据类型列表，并填充列表框
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
					ComboBox1.Items.Add(dbDS.Tables[0].Rows[i][0]);
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
					ComboBox1.Items.Add(dbDS.Tables[0].Rows[i][0]);
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
						CurrentBillTypeCode = rms_var.GetBillTypeCode(ComboBox1.Text);
						if (CurrentBillTypeCode != "")
						{
							this.DialogResult = DialogResult.OK;
						}
						else
						{
							CurrentBillTypeCode = "";
							MessageBox.Show("没有选择单据类型，或者单据类型不存在！");
							ComboBox1.SelectedIndex = 0;
							ComboBox1.Focus();
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
				if (! (NumericUpDown1.Value > 0))
				{
					MessageBox.Show("开台人数不能小于或等于0");
					NumericUpDown1.Focus();
					NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
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
						CurrentBillTypeCode = rms_var.GetBillTypeCode(ComboBox1.Text);
						if (CurrentBillTypeCode != "")
						{
							this.DialogResult = DialogResult.OK;
						}
						else
						{
							CurrentBillTypeCode = "";
							MessageBox.Show("没有选择单据类型，或者单据类型不存在！");
							ComboBox1.SelectedIndex = 0;
							ComboBox1.Focus();
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
			//检测前台单据是否自动编号
			if (rms_var.GetSysSetup("autobalancebill") == "1") //自动生成前台单据编号
			{
				TextBox1.Text = rms_var.GenNewBalanceBillNo();
			}
			else
			{
				TextBox1.Text = "";
			}
			if (NumericUpDown1.Visible)
			{
				NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
			}
			TextBox2.Text = rms_var.opinfo.OpID;
		}
	}
	
}
