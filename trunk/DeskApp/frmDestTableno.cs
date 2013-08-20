using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace DeskApp
{
	public class frmDestTableno : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmDestTableno()
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
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDestTableno));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(160, 32);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(112, 21);
            this.TextBox1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(104, 72);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(184, 72);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "取消(&C)";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(64, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "目标桌台号：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(24, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 48);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // frmDestTableno
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(288, 120);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDestTableno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择目标桌台";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text != "")
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("不能为空");
			}
		}
		
	}
	
}
