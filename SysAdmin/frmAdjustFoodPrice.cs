using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace SysAdmin
{
	public class frmAdjustFoodPrice : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAdjustFoodPrice()
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAdjustFoodPrice));
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 55);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "调整幅度：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.NumericUpDown1);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 32);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(248, 96);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "调整方法";
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label2.Location = new System.Drawing.Point(168, 55);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 23);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "%";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(96, 56);
			this.NumericUpDown1.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(72, 21);
			this.NumericUpDown1.TabIndex = 3;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {100, 0, 0, 0});
			//
			//RadioButton2
			//
			this.RadioButton2.Location = new System.Drawing.Point(128, 24);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(112, 24);
			this.RadioButton2.TabIndex = 2;
			this.RadioButton2.Text = "下调";
			//
			//RadioButton1
			//
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(24, 24);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.TabIndex = 1;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "上调";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(104, 136);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(176, 136);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(64, 23);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "取消(&C)";
			//
			//Label3
			//
			this.Label3.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label3.Location = new System.Drawing.Point(16, 8);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(264, 23);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "调整当前菜品列表中的菜品价格";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmAdjustFoodPrice
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(266, 176);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAdjustFoodPrice";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "菜品调价";
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (RadioButton2.Checked && NumericUpDown1.Value == 100)
			{
				if (MessageBox.Show("警告：下调 100% 的价格意味着将单价设为 0！请务必确认后进行操作！" + '\t'+"真的要将当前菜品列表的价格下调 100% 吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					this.DialogResult = DialogResult.OK;
				}
			}
			else
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
	}
	
}
