using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace DeskApp
{
	public class frmFreeDiscount : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmFreeDiscount()
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
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		public System.Windows.Forms.ComboBox ComboBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFreeDiscount));
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			base.Load += new System.EventHandler(frmFreeDiscount_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label5 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(104, 24);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(80, 21);
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {100, 0, 0, 0});
			this.NumericUpDown1.Visible = false;
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(48, 208);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(128, 208);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(32, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "打折比率：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("宋体", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label2.Location = new System.Drawing.Point(184, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 23);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "%";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label2.Visible = false;
			//
			//Label3
			//
			this.Label3.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label3.ForeColor = System.Drawing.Color.Navy;
			this.Label3.Location = new System.Drawing.Point(8, 64);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(232, 48);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "示例：100% 表示不打折，80%表示在消费金额的基础上打8折，50%表示半价，以此类推。";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(8, 8);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(216, 16);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "后台不允许优惠菜品特价菜品折上折";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Label4.Visible = false;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Location = new System.Drawing.Point(8, 112);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(232, 32);
			this.Panel1.TabIndex = 7;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(8, 8);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(216, 16);
			this.Label5.TabIndex = 7;
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 152);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(232, 48);
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "折扣选项";
			//
			//RadioButton2
			//
			this.RadioButton2.Location = new System.Drawing.Point(120, 16);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(104, 24);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "打折";
			//
			//RadioButton1
			//
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(16, 16);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(104, 24);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "不打折";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(104, 24);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(80, 20);
			this.ComboBox1.TabIndex = 9;
			//
			//frmFreeDiscount
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(250, 248);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFreeDiscount";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "打折";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void frmFreeDiscount_Load(System.Object sender, System.EventArgs e)
		{
			NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
			string DscntOnDscnt = rms_var.GetSysSetup("DiscountOnDiscount"); //允许折上折
			if (DscntOnDscnt == "1") //允许折上折
			{
				Label4.Text = "后台允许优惠菜品特价菜品折上折";
			}
			else
			{
				Label4.ForeColor = Color.Red;
				Label4.Text = "后台不允许优惠菜品特价菜品折上折";
			}
			string fixcostrtn = rms_var.FixCost();
			if (fixcostrtn == "0")
			{
				Label5.Text = "支付金额不抹零、不四舍五入";
			}
			else if (fixcostrtn == "1")
			{
				Label5.Text = "支付金额抹去角分";
			}
			else if (fixcostrtn == "2")
			{
				Label5.Text = "支付金额四舍五入到元";
			}
		}
		
	}
	
}
