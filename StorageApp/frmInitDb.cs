using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace StorageApp
{
	public class frmInitDb : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmInitDb()
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
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmInitDb));
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			base.Load += new System.EventHandler(frmInitDb_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Items.AddRange(new object[] {"一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"});
			this.ComboBox1.Location = new System.Drawing.Point(144, 48);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(64, 20);
			this.ComboBox1.TabIndex = 1;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Location = new System.Drawing.Point(56, 88);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 2;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(136, 88);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 3;
			this.Button2.Text = "取消(&C)";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(64, 48);
			this.NumericUpDown1.Maximum = new decimal(new int[] {3000, 0, 0, 0});
			this.NumericUpDown1.Minimum = new decimal(new int[] {2005, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(72, 21);
			this.NumericUpDown1.TabIndex = 4;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {2005, 0, 0, 0});
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(64, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 23);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "库存管理启用日期：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmInitDb
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(258, 136);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.ComboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInitDb";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "启用库存管理";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void frmInitDb_Load(System.Object sender, System.EventArgs e)
		{
			string startdate;
			startdate = rms_var.GetSysSetup("begindate");
			if (startdate != "")
			{
				NumericUpDown1.Text =startdate.Substring(0,4);
                ComboBox1.SelectedIndex =int.Parse(startdate.Substring(startdate.Length-2, 2)) - 1;
				Button1.Enabled = false;
			}
			else
			{
				NumericUpDown1.Text = string.Format("0000",DateTime.Now.Date.Year);
				ComboBox1.SelectedIndex = DateTime.Now.Date.Month - 1;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			string startdate;
			startdate = NumericUpDown1.Text + string.Format("00",ComboBox1.SelectedIndex + 1);
			rms_var.SetSysSetup("begindate", startdate);
			this.DialogResult = DialogResult.OK;
		}
	}
	
}
