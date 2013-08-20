using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace SysAdmin
{
	public class frmAddFoodCost : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAddFoodCost()
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAddFoodCost));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmAddFoodCost_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label4 = new System.Windows.Forms.Label();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.ForeColor = System.Drawing.Color.Navy;
			this.Label1.Location = new System.Drawing.Point(18, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(376, 23);
			this.Label1.TabIndex = 5;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(18, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(48, 23);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "数量：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(122, 58);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "组成类别：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Items.AddRange(new object[] {"主料", "辅料", "佐料", "其它"});
			this.ComboBox1.Location = new System.Drawing.Point(184, 59);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(72, 20);
			this.ComboBox1.TabIndex = 1;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(57, 59);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(64, 21);
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(258, 58);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(56, 23);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "损耗率：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.Location = new System.Drawing.Point(309, 59);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new System.Drawing.Size(59, 21);
			this.NumericUpDown2.TabIndex = 2;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(240, 112);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(320, 112);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//Label5
			//
			this.Label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label5.Location = new System.Drawing.Point(367, 58);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(11, 23);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "%";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.NumericUpDown2);
			this.GroupBox1.Controls.Add(this.NumericUpDown1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Location = new System.Drawing.Point(9, 7);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(399, 89);
			this.GroupBox1.TabIndex = 10;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "原料信息";
			//
			//frmAddFoodCost
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(418, 152);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddFoodCost";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加原料";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (! (NumericUpDown1.Value > 0))
			{
				MessageBox.Show("数量不能小于或等于0");
				NumericUpDown1.Focus();
				NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
				return;
			}
			this.DialogResult = DialogResult.OK;
		}
		
		private void frmAddFoodCost_Load(System.Object sender, System.EventArgs e)
		{
			ComboBox1.SelectedIndex = 0;
			NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
		}
	}
	
}
