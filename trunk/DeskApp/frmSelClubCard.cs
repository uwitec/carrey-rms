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
	public class frmSelClubCard : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelClubCard()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelClubCard));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(120, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(120, 40);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(144, 21);
            this.TextBox2.TabIndex = 1;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(112, 80);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(192, 80);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "取消(&C)";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(72, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "卡号：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(72, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 23);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "密码：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(16, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 48);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // frmSelClubCard
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(290, 120);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelClubCard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员卡优惠";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private bool CheckClubCard(string cardno, string psw)
		{
			System.Data.SqlClient.SqlConnection conn1 = new System.Data.SqlClient.SqlConnection();
			conn1.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD1 = new SqlCommand();
				selectCMD1.Connection = conn1;
				selectCMD1.CommandText = "SELECT count(*) FROM clubcard where clubcardno='" + cardno + "' and cardpassword='" + psw + "' and status='1'";
				selectCMD1.CommandTimeout = 30;
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				dbDA1.SelectCommand = selectCMD1;
				conn1.Open();
				DataSet dbDS1 = new DataSet();
				dbDA1.Fill(dbDS1, "t");
				if (dbDS1.Tables[0].Rows[0][0].ToString() == "0")
				{
					return false;
				}
				else
				{
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
				conn1.Close();
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (CheckClubCard(TextBox1.Text, TextBox2.Text))
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("会员卡号或密码输入不正确。");
				TextBox2.Focus();
				TextBox2.SelectAll();
			}
		}
		
	}
	
}
