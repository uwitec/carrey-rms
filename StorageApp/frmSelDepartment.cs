using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace StorageApp
{
	public class frmSelDepartment : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelDepartment()
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSelDepartment));
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			base.Load += new System.EventHandler(frmSelDepartment_Load);
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(88, 16);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(152, 20);
			this.ComboBox1.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "选择仓库：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//ComboBox2
			//
			this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.Location = new System.Drawing.Point(88, 40);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(152, 20);
			this.ComboBox2.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 40);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "选择部门：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(72, 96);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(152, 96);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(264, 72);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			//
			//frmSelDepartment
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(282, 136);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelDepartment";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "选择部门";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void frmSelDepartment_Load(System.Object sender, System.EventArgs e)
		{
			DataTable strgdept;
			strgdept = rms_var.LoadStorageDept();
			for (int i = 0; i <= strgdept.Rows.Count - 1; i++)
			{
				ComboBox1.Items.Add(strgdept.Rows[i]["DeptName"]);
			}
            if (!(ComboBox1.Items.Count > 0))
            {
                MessageBox.Show("请先建立仓库信息");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            ComboBox1.SelectedIndex = 0;
			
			DataTable dept;
			dept = rms_var.LoadDept();
			for (int i = 0; i <= dept.Rows.Count - 1; i++)
			{
				ComboBox2.Items.Add(dept.Rows[i]["DeptName"]);
			}
            if (!(ComboBox2.Items.Count > 0))
            {
                MessageBox.Show("请先建立部门信息");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
			ComboBox2.SelectedIndex = 0;
		}
	}
	
}
