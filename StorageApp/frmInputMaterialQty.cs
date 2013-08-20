using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace StorageApp
{
	public class frmInputMaterialQty : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmInputMaterialQty()
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
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmInputMaterialQty));
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
			this.NumericUpDown1.Enter += new System.EventHandler(this.NumericUpDown1_Enter);
			this.NumericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericUpDown1_KeyPress);
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
			this.NumericUpDown2.Enter += new System.EventHandler(this.NumericUpDown2_Enter);
			this.NumericUpDown2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericUpDown2_KeyPress);
			this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown3.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
			this.NumericUpDown3.Enter += new System.EventHandler(this.NumericUpDown3_Enter);
			this.NumericUpDown3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericUpDown3_KeyPress);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).BeginInit();
			this.SuspendLayout();
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(96, 48);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.DecimalPlaces = 2;
			this.NumericUpDown2.Location = new System.Drawing.Point(96, 72);
			this.NumericUpDown2.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.TabIndex = 1;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown3
			//
			this.NumericUpDown3.DecimalPlaces = 2;
			this.NumericUpDown3.Location = new System.Drawing.Point(96, 96);
			this.NumericUpDown3.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.TabIndex = 2;
			this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(64, 136);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(144, 136);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, ((System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.Location = new System.Drawing.Point(24, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(248, 23);
			this.Label1.TabIndex = 5;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(48, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(48, 23);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "数量：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(48, 72);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(48, 23);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "单价：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(24, 96);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "合计金额：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label5.Location = new System.Drawing.Point(216, 48);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(56, 23);
			this.Label5.TabIndex = 9;
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmInputMaterialQty
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(280, 182);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.NumericUpDown3);
			this.Controls.Add(this.NumericUpDown2);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInputMaterialQty";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "输入数量及价格";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown1.Value <= 0)
			{
				MessageBox.Show("数量不能为 0");
				NumericUpDown1.Focus();
				NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
			}
			else
			{
				if (NumericUpDown2.Value == 0)
				{
					NumericUpDown2.Value = NumericUpDown3.Value / NumericUpDown1.Value;
				}
				if (NumericUpDown3.Value == 0)
				{
					NumericUpDown3.Value = NumericUpDown1.Value * NumericUpDown2.Value;
				}
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void NumericUpDown1_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown1.Value > 0)
			{
				if (NumericUpDown2.Value > 0)
				{
					NumericUpDown3.Value = NumericUpDown2.Value * NumericUpDown1.Value;
				}
			}
		}
		
		private void NumericUpDown2_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown2.Value > 0)
			{
				if (NumericUpDown1.Value > 0)
				{
					NumericUpDown3.Value = NumericUpDown1.Value * NumericUpDown2.Value;
				}
			}
		}
		
		private void NumericUpDown3_ValueChanged(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown3.Value > 0)
			{
				if (NumericUpDown1.Value > 0)
				{
					NumericUpDown2.Value = NumericUpDown3.Value / NumericUpDown1.Value;
				}
			}
		}
		
		private void NumericUpDown1_Enter(object sender, System.EventArgs e)
		{
			NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
		}
		
		private void NumericUpDown2_Enter(object sender, System.EventArgs e)
		{
			NumericUpDown2.Select(0, NumericUpDown2.Text.Length);
		}
		
		private void NumericUpDown3_Enter(object sender, System.EventArgs e)
		{
			NumericUpDown3.Select(0, NumericUpDown3.Text.Length);
		}
		
		private void NumericUpDown1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
            if (e.KeyChar == (char)27)
			{
				NumericUpDown2.Focus();
				NumericUpDown2.Select(0, NumericUpDown2.Text.Length);
			}
		}
		
		private void NumericUpDown2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
            if (e.KeyChar == (char)27)
			{
				NumericUpDown3.Focus();
				NumericUpDown3.Select(0, NumericUpDown3.Text.Length);
			}
		}
		
		private void NumericUpDown3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar ==(char)27)
			{
				Button1_Click(sender, e);
			}
		}
		
	}
	
}
