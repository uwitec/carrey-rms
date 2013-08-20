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
	public class frmCardPsw : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCardPsw()
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCardPsw));
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(120, 25);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(120, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(120, 57);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(120, 21);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(72, 104);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 2;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(152, 104);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 3;
			this.Button2.Text = "取消(&C)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 23);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "密码：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 23);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "再输一次密码：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmCardPsw
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(298, 150);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCardPsw";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "更改密码";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public string cardcode;
		
		private bool DoChangeCardPsw(string cardcode, string Psw)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "update clubcard set " + "cardpassword='" + Psw + " '" + " where clubcardno='" + cardcode + "'";
				
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text != TextBox2.Text)
			{
				MessageBox.Show("两次输入的密码不一致，请核对后重新输入。");
				TextBox1.Focus();
				TextBox1.SelectAll();
				return;
			}
			else
			{
				if (TextBox1.Text == "" || TextBox2.Text == "")
				{
					MessageBox.Show("密码不能为空。");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
			}
			DoChangeCardPsw(cardcode, TextBox1.Text);
			this.DialogResult = DialogResult.OK;
		}
	}
	
}
