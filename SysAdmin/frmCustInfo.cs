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
	public class frmCustInfo : System.Windows.Forms.Form
	{
		
		public string CustCode;
		public string Cardcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmCustInfo()
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Button Button1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCustInfo));
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmCustInfo_Load);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(24, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(192, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "客户编码：";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.GroupBox1.ForeColor = System.Drawing.Color.Navy;
			this.GroupBox1.Location = new System.Drawing.Point(16, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(432, 128);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "客户信息";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(232, 48);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(192, 23);
			this.Label8.TabIndex = 7;
			this.Label8.Text = "单位地址：";
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(24, 96);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(192, 23);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "个人电话：";
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(232, 96);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(192, 23);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "联系人：";
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(232, 72);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(192, 23);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "单位电话：";
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(232, 24);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(192, 23);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "单位名称：";
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(24, 72);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(192, 23);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "客户类别：";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(24, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(192, 23);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "客户名称：";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Label16);
			this.GroupBox2.Controls.Add(this.Label15);
			this.GroupBox2.Controls.Add(this.Label14);
			this.GroupBox2.Controls.Add(this.Label13);
			this.GroupBox2.Controls.Add(this.Label12);
			this.GroupBox2.Controls.Add(this.Label11);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.GroupBox2.ForeColor = System.Drawing.Color.Navy;
			this.GroupBox2.Location = new System.Drawing.Point(16, 152);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(432, 128);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "会员卡信息";
			//
			//Label16
			//
			this.Label16.Location = new System.Drawing.Point(232, 96);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(176, 23);
			this.Label16.TabIndex = 7;
			this.Label16.Text = "状态：";
			//
			//Label15
			//
			this.Label15.Location = new System.Drawing.Point(24, 96);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(200, 23);
			this.Label15.TabIndex = 6;
			this.Label15.Text = "折扣比例：";
			//
			//Label14
			//
			this.Label14.Location = new System.Drawing.Point(232, 72);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(176, 23);
			this.Label14.TabIndex = 5;
			this.Label14.Text = "卡存余额：";
			//
			//Label13
			//
			this.Label13.Location = new System.Drawing.Point(232, 48);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(176, 23);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "消费累计：";
			//
			//Label12
			//
			this.Label12.Location = new System.Drawing.Point(24, 72);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(200, 23);
			this.Label12.TabIndex = 3;
			this.Label12.Text = "开户地点：";
			//
			//Label11
			//
			this.Label11.Location = new System.Drawing.Point(232, 24);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(176, 23);
			this.Label11.TabIndex = 2;
			this.Label11.Text = "开户金额：";
			//
			//Label10
			//
			this.Label10.Location = new System.Drawing.Point(24, 48);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(200, 23);
			this.Label10.TabIndex = 1;
			this.Label10.Text = "开户日期：";
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(24, 24);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(200, 23);
			this.Label9.TabIndex = 0;
			this.Label9.Text = "会员卡号：";
			//
			//Button1
			//
			this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button1.Location = new System.Drawing.Point(352, 296);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "关闭(&C)";
			//
			//frmCustInfo
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button1;
			this.ClientSize = new System.Drawing.Size(464, 334);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCustInfo";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "客户/会员卡信息";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void RefreshCustInfo()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT customercode,customername, " + "typename,phonenumber1,company,address1,phonenumber2,contacter " + "FROM view_Customer where customercode='" + CustCode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t1");
				
				//填充客户信息
				Label1.Text = Label1.Text + dbDS.Tables[0].Rows[0]["customercode"].ToString();
				Label2.Text = Label2.Text + dbDS.Tables[0].Rows[0]["customername"].ToString();
				Label3.Text = Label3.Text + dbDS.Tables[0].Rows[0]["typename"].ToString();
				Label7.Text = Label7.Text + dbDS.Tables[0].Rows[0]["phonenumber1"].ToString();
				Label4.Text = Label4.Text + dbDS.Tables[0].Rows[0]["company"].ToString();
				Label8.Text = Label8.Text + dbDS.Tables[0].Rows[0]["address1"].ToString();
				Label5.Text = Label5.Text + dbDS.Tables[0].Rows[0]["phonenumber2"].ToString();
				Label6.Text = Label6.Text + dbDS.Tables[0].Rows[0]["contacter"].ToString();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		private void RefreshCardInfo()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT clubcardno,begindate, " + "places,discountrate,begincost,totalcost,remaincost,status " + "FROM view_ClubCard where clubcardno='" + Cardcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t1");
				
				//填充会员卡信息
				Label9.Text = Label9.Text + dbDS.Tables[0].Rows[0]["clubcardno"].ToString();
				Label10.Text = Label10.Text + dbDS.Tables[0].Rows[0]["begindate"].ToString();
				Label12.Text = Label12.Text + dbDS.Tables[0].Rows[0]["places"].ToString();
				Label15.Text = Label15.Text + dbDS.Tables[0].Rows[0]["discountrate"].ToString();
				Label11.Text = Label11.Text + dbDS.Tables[0].Rows[0]["begincost"].ToString();
				Label13.Text = Label13.Text + dbDS.Tables[0].Rows[0]["totalcost"].ToString();
				Label14.Text = Label14.Text + dbDS.Tables[0].Rows[0]["remaincost"].ToString();
				string st;
				st = dbDS.Tables[0].Rows[0]["status"].ToString();
				if (st == "1")
				{
					Label16.Text = Label16.Text + "启用";
				}
				else if (st == "2")
				{
					Label16.Text = Label16.Text + "暂停";
				}
				else if (st == "3")
				{
					Label16.Text = Label16.Text + "废止";
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		private void frmCustInfo_Load(System.Object sender, System.EventArgs e)
		{
			RefreshCustInfo();
			RefreshCardInfo();
		}
	}
	
}
