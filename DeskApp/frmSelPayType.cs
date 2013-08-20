using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class frmSelPayType : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSelPayType()
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
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelPayType));
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Location = new System.Drawing.Point(128, 16);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(120, 20);
            this.ComboBox1.TabIndex = 0;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.DecimalPlaces = 2;
            this.NumericUpDown1.Location = new System.Drawing.Point(128, 40);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.NumericUpDown1.TabIndex = 1;
            this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(104, 80);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "确定(&O)";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(184, 80);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "取消(&C)";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(56, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "结账方式：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(56, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 23);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "金额：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(16, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // frmSelPayType
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(298, 120);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelPayType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加结账方式";
            this.Load += new System.EventHandler(this.frmSelPayType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		#endregion
		
		public DataTable LoadPayType()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM PayType", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "PayTypeList");
				return dbDS.Tables[0];
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return null;
		}
		
		private void frmSelPayType_Load(System.Object sender, System.EventArgs e)
		{
			DataTable fpaytype;
			fpaytype = LoadPayType();
			for (int i = 0; i <= fpaytype.Rows.Count - 1; i++)
			{
				this.ComboBox1.Items.Add(fpaytype.Rows[i]["name"]);
			}
			ComboBox1.SelectedIndex = 0;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (NumericUpDown1.Value <= 0)
			{
				MessageBox.Show("金额不能等于或小于 0");
				return;
			}
			if (ComboBox1.Text == "签单")
			{
				//检测是否允许签单
				if (rms_var.TheAppExt.Chk_op_qd)
				{
					frmSelCustomer frmsc = new frmSelCustomer();
					frmsc.ShowDialog();
					if (frmsc.DialogResult == DialogResult.OK)
					{
						rms_var.PayCustomerCode = frmsc.dgCustomer[frmsc.dgCustomer.CurrentRowIndex, 0].ToString();
						rms_var.PayCustomerName =frmsc.dgCustomer[frmsc.dgCustomer.CurrentRowIndex, 1].ToString();
						rms_var.PayCustomerSignedCount =frmsc.dgCustomer[frmsc.dgCustomer.CurrentRowIndex, 2].ToString();
						//检测当前客户是否允许签单
						if (rms_var.AllowSignPay(rms_var.PayCustomerCode))
						{
							//检测签单金额是否超过限额
							if (rms_var.CustOverSign(rms_var.PayCustomerCode)) //超过限额
							{
								//检测系统超出限额是否允许结帐
								if (rms_var.GetSysSetup("SignFullBalance") == "1") //允许结帐
								{
									this.DialogResult = DialogResult.OK;
								}
								else
								{
									MessageBox.Show("签单金额已经超出限额，系统不允许结帐。如果仍需要结帐请联系系统管理员。");
								}
							}
							else
							{
								this.DialogResult = DialogResult.OK;
							}
						}
						else
						{
							MessageBox.Show("当前客户没有签单权，请到系统管理中进行设置。");
						}
					}
				}
				else
				{
					MessageBox.Show("您没有进行签单操作的权限。");
					return;
				}
			}
			else if (ComboBox1.Text == "会员卡")
			{
				frmSelClubCard frmscc = new frmSelClubCard();
				frmscc.ShowDialog();
				if (frmscc.DialogResult == DialogResult.OK)
				{
					rms_var.PayClubCardNo = frmscc.TextBox1.Text;
					//系统会员卡折扣方法 clubfixedderate 0：累计金额；1：固定折扣
					if (rms_var.GetSysSetup("clubfixedderate") == "0") //累计金额打折
					{
						rms_var.PayClubCardDiscountRate = rms_var.GetClubAddUpDiscountrate(frmscc.TextBox1.Text);
					}
					else //固定折扣
					{
						rms_var.PayClubCardDiscountRate = rms_var.GetClubDiscountrate(frmscc.TextBox1.Text);
					}
					
					NumericUpDown1.Value = NumericUpDown1.Value * (decimal.Parse(rms_var.PayClubCardDiscountRate) / 100);
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
