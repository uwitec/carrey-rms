using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace TouchScreen
{
	namespace MySpace
	{
		public class InputMode : System.Windows.Forms.Form
		{
			
			#region  Windows 窗体设计器生成的代码
			
			public InputMode()
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
			internal System.Windows.Forms.Button Button1;
			internal System.Windows.Forms.GroupBox GroupBox1;
			internal System.Windows.Forms.RadioButton RadioButton3;
			internal System.Windows.Forms.RadioButton RadioButton2;
			internal System.Windows.Forms.RadioButton RadioButton1;
			internal System.Windows.Forms.RadioButton RadioButton4;
			[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(InputMode));
				this.Button1 = new System.Windows.Forms.Button();
				this.Button1.Click += new System.EventHandler(this.Button1_Click);
				this.GroupBox1 = new System.Windows.Forms.GroupBox();
				this.RadioButton3 = new System.Windows.Forms.RadioButton();
				this.RadioButton2 = new System.Windows.Forms.RadioButton();
				this.RadioButton1 = new System.Windows.Forms.RadioButton();
				this.RadioButton4 = new System.Windows.Forms.RadioButton();
				this.GroupBox1.SuspendLayout();
				this.SuspendLayout();
				//
				//Button1
				//
				this.Button1.Location = new System.Drawing.Point(120, 152);
				this.Button1.Name = "Button1";
				this.Button1.TabIndex = 3;
				this.Button1.Text = "确定(&O)";
				//
				//GroupBox1
				//
				this.GroupBox1.Controls.Add(this.RadioButton4);
				this.GroupBox1.Controls.Add(this.RadioButton3);
				this.GroupBox1.Controls.Add(this.RadioButton2);
				this.GroupBox1.Controls.Add(this.RadioButton1);
				this.GroupBox1.Location = new System.Drawing.Point(16, 8);
				this.GroupBox1.Name = "GroupBox1";
				this.GroupBox1.Size = new System.Drawing.Size(192, 136);
				this.GroupBox1.TabIndex = 4;
				this.GroupBox1.TabStop = false;
				this.GroupBox1.Text = "过滤方法";
				//
				//RadioButton3
				//
				this.RadioButton3.Location = new System.Drawing.Point(24, 72);
				this.RadioButton3.Name = "RadioButton3";
				this.RadioButton3.Size = new System.Drawing.Size(160, 24);
				this.RadioButton3.TabIndex = 5;
				this.RadioButton3.Text = "菜品类别编码";
				//
				//RadioButton2
				//
				this.RadioButton2.Location = new System.Drawing.Point(24, 48);
				this.RadioButton2.Name = "RadioButton2";
				this.RadioButton2.Size = new System.Drawing.Size(160, 24);
				this.RadioButton2.TabIndex = 4;
				this.RadioButton2.Text = "菜品拼音码";
				//
				//RadioButton1
				//
				this.RadioButton1.Location = new System.Drawing.Point(24, 24);
				this.RadioButton1.Name = "RadioButton1";
				this.RadioButton1.Size = new System.Drawing.Size(160, 24);
				this.RadioButton1.TabIndex = 3;
				this.RadioButton1.Text = "菜品编码";
				//
				//RadioButton4
				//
				this.RadioButton4.Checked = true;
				this.RadioButton4.Location = new System.Drawing.Point(24, 96);
				this.RadioButton4.Name = "RadioButton4";
				this.RadioButton4.Size = new System.Drawing.Size(160, 24);
				this.RadioButton4.TabIndex = 6;
				this.RadioButton4.TabStop = true;
				this.RadioButton4.Text = "菜品类别名称";
				//
				//InputMode
				//
				this.AcceptButton = this.Button1;
				this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
				this.ClientSize = new System.Drawing.Size(226, 192);
				this.Controls.Add(this.GroupBox1);
				this.Controls.Add(this.Button1);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
				this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "InputMode";
				this.ShowInTaskbar = false;
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				this.Text = "选择过滤菜品的方法";
				this.GroupBox1.ResumeLayout(false);
				this.ResumeLayout(false);
				
			}
			
			#endregion
			
			private void Button1_Click(System.Object sender, System.EventArgs e)
			{
				if (RadioButton1.Checked)
				{
					rms_var.FoodInputMode = 0;
				}
				else if (RadioButton2.Checked)
				{
					rms_var.FoodInputMode = 1;
				}
				else if (RadioButton3.Checked)
				{
					rms_var.FoodInputMode = 2;
				}
				else if (RadioButton4.Checked)
				{
					rms_var.FoodInputMode = 3;
				}
				this.DialogResult = DialogResult.OK;
			}
			
		}
	}
	
	
}
