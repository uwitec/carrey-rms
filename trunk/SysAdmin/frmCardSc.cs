using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace SysAdmin
{
	public class frmCardSc : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCardSc()
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
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCardSc));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmCardSc_Load);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 5;
			this.Label1.Text = "会员卡号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(112, 24);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(120, 21);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Items.AddRange(new object[] {"启用", "暂停", "废止"});
			this.ComboBox1.Location = new System.Drawing.Point(112, 60);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(120, 20);
			this.ComboBox1.TabIndex = 1;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(112, 95);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(120, 21);
			this.TextBox2.TabIndex = 2;
			this.TextBox2.Text = "";
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(64, 144);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(152, 144);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 60);
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 6;
			this.Label2.Text = "会员卡状态：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 96);
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 7;
			this.Label3.Text = "客户名称：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmCardSc
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(280, 198);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCardSc";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "查询";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void frmCardSc_Load(System.Object sender, System.EventArgs e)
		{
			ComboBox1.SelectedIndex = 0;
		}
	}
	
}
