using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace TouchScreen
{
	public class frmCancelFoodQty : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCancelFoodQty()
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
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmCancelFoodQty_Load);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCancelFoodQty));
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown1.Enter += new System.EventHandler(this.NumericUpDown1_Enter);
			this.NumericUpDown1.Leave += new System.EventHandler(this.NumericUpDown1_Leave);
			this.NumericUpDown1.Click += new System.EventHandler(this.NumericUpDown1_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Font = new System.Drawing.Font("宋体", 15.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.NumericUpDown1.Location = new System.Drawing.Point(152, 32);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(88, 30);
			this.NumericUpDown1.TabIndex = 2;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ImageIndex = 0;
			this.Button1.ImageList = this.ImageList1;
			this.Button1.Location = new System.Drawing.Point(160, 88);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(72, 48);
			this.Button1.TabIndex = 0;
			//
			//Button2
			//
			this.Button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button2.ImageIndex = 1;
			this.Button2.ImageList = this.ImageList1;
			this.Button2.Location = new System.Drawing.Point(232, 88);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(72, 48);
			this.Button2.TabIndex = 1;
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.Location = new System.Drawing.Point(48, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(112, 23);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "退菜数量：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label2.ForeColor = System.Drawing.Color.Red;
			this.Label2.Location = new System.Drawing.Point(16, 144);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(296, 40);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "注意：退菜数量的最大值不允许超过该已点菜品的总数量。您即使输入了不合法的数量，系统也仅认为你输入的是允许退菜的最大值。";
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//frmCancelFoodQty
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(322, 200);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCancelFoodQty";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "退菜数量";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public double MaxCount;
		private frmInputPanel frminptForm;
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (! (NumericUpDown1.Value > 0))
			{
				MessageBox.Show("数量不能等于或小于 0");
				NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
			}
			else
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void frmCancelFoodQty_Load(System.Object sender, System.EventArgs e)
		{
			frminptForm = new frmInputPanel();
			NumericUpDown1.Focus();
			NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
		}
		
		private void NumericUpDown1_Enter(object sender, System.EventArgs e)
		{
			if (!frminptForm.Visible)
			{
                //frminptForm.CurrentUsedControl = NumericUpDown1;
				frminptForm.Show();
			}
		}
		
		private void NumericUpDown1_Leave(object sender, System.EventArgs e)
		{
			frminptForm.Hide();
		}
		
		private void NumericUpDown1_Click(object sender, System.EventArgs e)
		{
			if (! frminptForm.Visible)
			{
                //frminptForm.CurrentUsedControl = NumericUpDown1;
				frminptForm.Show();
			}
		}
	}
	
}
