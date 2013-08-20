using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace SysAdmin
{
	public class frmCardSupply : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCardSupply()
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCardSupply));
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			base.Load += new System.EventHandler(frmCardSupply_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(104, 24);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(80, 21);
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(64, 64);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(72, 23);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(144, 64);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(72, 23);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(32, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "充值金额：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(184, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 23);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "元人民币";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmCardSupply
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(274, 104);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCardSupply";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "会员卡续存";
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public string cardcode;
		
		private bool DoCardSupply(string cardcode, string money)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandTimeout = 30;
				conn.Open();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "update clubcard set " + "remaincost=remaincost+" + NumericUpDown1.Text + " where clubcardno='" + cardcode + "'";
				selectCMD.ExecuteNonQuery();
				
				//记录该次充值记录
				selectCMD.CommandText = "insert into CardSupply " + "(clubcardno,supplydate,cost,operator) " + "values " + "(" + "'" + cardcode + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + money + "," + "'" + rms_var.opinfo.OpID + "'" + ")";
				selectCMD.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
			finally
			{
				conn.Close();
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			DoCardSupply(cardcode, NumericUpDown1.Text);
		}
		
		private void frmCardSupply_Load(System.Object sender, System.EventArgs e)
		{
			NumericUpDown1.Select(0, NumericUpDown1.Text.Length);
		}
	}
	
}
