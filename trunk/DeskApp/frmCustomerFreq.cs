using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace DeskApp
{
	public class frmCustomerFreq : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCustomerFreq()
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
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker4;
		internal System.Windows.Forms.DateTimePicker DateTimePicker3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label2;
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCustomerFreq));
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.DateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.Label3 = new System.Windows.Forms.Label();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.DateTimePicker4);
			this.Panel1.Controls.Add(this.DateTimePicker3);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.DateTimePicker2);
			this.Panel1.Controls.Add(this.DateTimePicker1);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(624, 64);
			this.Panel1.TabIndex = 2;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(288, 8);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 48);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "查询(&F)";
			//
			//DateTimePicker4
			//
			this.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker4.Location = new System.Drawing.Point(200, 32);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.ShowUpDown = true;
			this.DateTimePicker4.Size = new System.Drawing.Size(80, 21);
			this.DateTimePicker4.TabIndex = 5;
			//
			//DateTimePicker3
			//
			this.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker3.Location = new System.Drawing.Point(80, 32);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new System.Drawing.Size(112, 21);
			this.DateTimePicker3.TabIndex = 4;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(8, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "至";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.CustomFormat = "";
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker2.Location = new System.Drawing.Point(200, 8);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.ShowUpDown = true;
			this.DateTimePicker2.Size = new System.Drawing.Size(80, 21);
			this.DateTimePicker2.TabIndex = 3;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.CustomFormat = "";
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(80, 8);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(112, 21);
			this.DateTimePicker1.TabIndex = 2;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(8, 8);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "就餐时间：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//CrystalReportViewer1
			//
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			this.CrystalReportViewer1.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.CrystalReportViewer1.DisplayGroupTree = false;
			this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 72);
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = null;
			this.CrystalReportViewer1.ShowCloseButton = false;
			this.CrystalReportViewer1.Size = new System.Drawing.Size(624, 408);
			this.CrystalReportViewer1.TabIndex = 3;
			//
			//frmCustomerFreq
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(624, 478);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.CrystalReportViewer1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmCustomerFreq";
			this.Text = "常客查询";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
	}
	
}
