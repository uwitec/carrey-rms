using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace DecisionApp
{
	public class frmEditPsw : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditPsw()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.CheckBox CheckBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPsw));
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(72, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 23);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "新密码：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(152, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '*';
            this.TextBox1.Size = new System.Drawing.Size(128, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(152, 48);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '*';
            this.TextBox2.Size = new System.Drawing.Size(128, 21);
            this.TextBox2.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(72, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 23);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "再输一次：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(120, 104);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(200, 104);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "取消(&C)";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(24, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 40);
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Location = new System.Drawing.Point(152, 72);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(128, 24);
            this.CheckBox1.TabIndex = 2;
            this.CheckBox1.Text = "不隐蔽密码内容";
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // frmEditPsw
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(298, 144);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditPsw";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更改帐号密码";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text == TextBox2.Text)
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("两次输入的密码不一致，请核对后重新输入。");
			}
		}
		
		private void CheckBox1_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (CheckBox1.Checked)
			{
				TextBox1.PasswordChar =(char)0;
				TextBox2.PasswordChar =(char)0;
			}
			else
			{
				TextBox1.PasswordChar = '●';
				TextBox2.PasswordChar = '●';
			}
		}
	}
	
}
