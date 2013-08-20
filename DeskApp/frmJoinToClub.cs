using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class frmJoinToClub : System.Windows.Forms.Form
	{
		
		public string CustCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmJoinToClub()
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
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmJoinToClub));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(40, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(80, 23);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "会员卡号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(40, 51);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 23);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "会员卡密码：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(40, 78);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(80, 23);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "发卡日期：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(40, 105);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(80, 23);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "发卡地点：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(40, 132);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(80, 23);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "开户金额：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(40, 159);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(80, 23);
			this.Label6.TabIndex = 14;
			this.Label6.Text = "折让比例：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(120, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(152, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(120, 51);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(152, 21);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(120, 78);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(152, 21);
			this.DateTimePicker1.TabIndex = 2;
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(120, 105);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(152, 21);
			this.TextBox3.TabIndex = 3;
			this.TextBox3.Text = "";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(120, 133);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(96, 21);
			this.NumericUpDown1.TabIndex = 4;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.Location = new System.Drawing.Point(120, 160);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new System.Drawing.Size(96, 21);
			this.NumericUpDown2.TabIndex = 5;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown2.Value = new decimal(new int[] {95, 0, 0, 0});
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(168, 240);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 7;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(248, 240);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 8;
			this.Button2.Text = "取消(&C)";
			//
			//CheckBox1
			//
			this.CheckBox1.Checked = true;
			this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox1.Location = new System.Drawing.Point(120, 192);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(152, 24);
			this.CheckBox1.TabIndex = 6;
			this.CheckBox1.Text = "发卡后启用该会员";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(216, 132);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(64, 23);
			this.Label7.TabIndex = 15;
			this.Label7.Text = "元人民币";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(216, 162);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(64, 16);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "%";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmJoinToClub
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(352, 286);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.NumericUpDown2);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmJoinToClub";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "发会员卡";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private bool AddClubCard(string customercode, string clubcardno, string begindate, string places, string beginCost, string discountrate, string status, string cardpassword)
			{
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select clubcardno from clubcard where clubcardno='" + clubcardno + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
				{
					MessageBox.Show("会员卡号重复！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into clubcard (customercode,clubcardno,places,begindate,beginCost,discountrate,status,cardpassword) values ('" + customercode + "','" + clubcardno + "','" + places + "','" + begindate + "'," + beginCost + "," + discountrate + ",'" + status + "','" + cardpassword + "')";
					
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
		
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text.Trim() == "")
			{
				MessageBox.Show("会员卡号不能为空！");
				return;
			}
			int cardstatus;
			if (CheckBox1.Checked)
			{
				cardstatus = 1;
			}
			else
			{
				cardstatus = 2; //暂停
			}
			if (AddClubCard(CustCode, TextBox1.Text, DateTimePicker1.Value.ToString(), TextBox3.Text, NumericUpDown1.Text, NumericUpDown2.Text, cardstatus.ToString(), TextBox2.Text))
			{
				MessageBox.Show("添加会员卡成功！");
			}
			else
			{
				TextBox1.Focus();
				TextBox1.SelectAll();
			}
		}
	}
	
}
