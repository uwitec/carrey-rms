using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace TouchScreen
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

        private System.ComponentModel.IContainer components;

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDestTableno));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.Location = new System.Drawing.Point(208, 29);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(112, 29);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.TextBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            this.TextBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ImageIndex = 0;
            this.Button1.ImageList = this.ImageList1;
            this.Button1.Location = new System.Drawing.Point(160, 88);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(80, 56);
            this.Button1.TabIndex = 0;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ImageIndex = 1;
            this.Button2.ImageList = this.ImageList1;
            this.Button2.Location = new System.Drawing.Point(240, 88);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(80, 56);
            this.Button2.TabIndex = 1;
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(88, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 23);
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
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(346, 168);
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
            this.Load += new System.EventHandler(this.frmDestTableno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		private frmInputPanel frminptForm;
		
		private void ShowInputPanel(TextBox TargetControl)
		{
			Point controlLocation=Point.Empty;
			Point inputPanelLocation=Point.Empty;
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
		
		private void TextBox1_Enter(object sender, System.EventArgs e)
		{
			ShowInputPanel(TextBox1);
		}
		
		private void TextBox1_Leave(object sender, System.EventArgs e)
		{
			frminptForm.Hide();
		}
		
		private void frmDestTableno_Load(System.Object sender, System.EventArgs e)
		{
			frminptForm = new frmInputPanel();
		}
		
		private void TextBox1_Click(object sender, System.EventArgs e)
		{
			ShowInputPanel(TextBox1);
		}
	}
	
}
