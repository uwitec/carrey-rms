using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace SysAdmin
{
	public class frmAddSuitFoodQty : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAddSuitFoodQty()
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
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAddSuitFoodQty));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmAddSuitFoodQty_Load);
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.ForeColor = System.Drawing.Color.Navy;
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(272, 40);
			this.Label1.TabIndex = 0;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(128, 64);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(72, 21);
			this.NumericUpDown1.TabIndex = 1;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {1, 0, 0, 0});
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
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(48, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 23);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "套餐中数量：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmAddSuitFoodQty
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(298, 144);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddSuitFoodQty";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加套餐菜品";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
		
		private void frmAddSuitFoodQty_Load(System.Object sender, System.EventArgs e)
		{
			NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
		}
	}
	
}
