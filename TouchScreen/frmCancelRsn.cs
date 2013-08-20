using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace TouchScreen
{
	namespace MySpace
	{
		public class frmCancelRsn : System.Windows.Forms.Form
		{
			
			private CancelFoodRsnButtonList CancelFoodRsnBtnList;
			private int CancelFoodRsnPageInterval = 60;
			
			public string CancelReason;
			
			#region  Windows 窗体设计器生成的代码
			
			public frmCancelRsn()
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
			internal System.Windows.Forms.Button Button2;
			internal System.Windows.Forms.Panel Panel1;
			internal System.Windows.Forms.Button Button3;
			internal System.Windows.Forms.Button Button4;
			internal System.Windows.Forms.ImageList ImageList1;
			[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
				this.components = new System.ComponentModel.Container();
				base.Load += new System.EventHandler(frmCancelRsn_Load);
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCancelRsn));
				this.Button1 = new System.Windows.Forms.Button();
				this.Button2 = new System.Windows.Forms.Button();
				this.Panel1 = new System.Windows.Forms.Panel();
				this.Button3 = new System.Windows.Forms.Button();
				this.Button3.Click += new System.EventHandler(this.Button3_Click);
				this.Button4 = new System.Windows.Forms.Button();
				this.Button4.Click += new System.EventHandler(this.Button4_Click);
				this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
				this.SuspendLayout();
				//
				//Button1
				//
				this.Button1.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button1.ImageIndex = 0;
				this.Button1.ImageList = this.ImageList1;
				this.Button1.Location = new System.Drawing.Point(312, 120);
				this.Button1.Name = "Button1";
				this.Button1.Size = new System.Drawing.Size(64, 56);
				this.Button1.TabIndex = 5;
				//
				//Button2
				//
				this.Button2.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
				this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button2.ImageIndex = 1;
				this.Button2.ImageList = this.ImageList1;
				this.Button2.Location = new System.Drawing.Point(312, 176);
				this.Button2.Name = "Button2";
				this.Button2.Size = new System.Drawing.Size(64, 56);
				this.Button2.TabIndex = 6;
				//
				//Panel1
				//
				this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
				this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.Panel1.Location = new System.Drawing.Point(8, 8);
				this.Panel1.Name = "Panel1";
				this.Panel1.Size = new System.Drawing.Size(296, 224);
				this.Panel1.TabIndex = 8;
				//
				//Button3
				//
				this.Button3.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button3.ImageIndex = 5;
				this.Button3.ImageList = this.ImageList1;
				this.Button3.Location = new System.Drawing.Point(312, 8);
				this.Button3.Name = "Button3";
				this.Button3.Size = new System.Drawing.Size(64, 56);
				this.Button3.TabIndex = 9;
				//
				//Button4
				//
				this.Button4.BackColor = System.Drawing.Color.LightSteelBlue;
				this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.Button4.ImageIndex = 4;
				this.Button4.ImageList = this.ImageList1;
				this.Button4.Location = new System.Drawing.Point(312, 64);
				this.Button4.Name = "Button4";
				this.Button4.Size = new System.Drawing.Size(64, 56);
				this.Button4.TabIndex = 10;
				//
				//ImageList1
				//
				this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
				this.ImageList1.ImageSize = new System.Drawing.Size(32, 32);
				this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
				this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
				//
				//frmCancelRsn
				//
				this.AutoScaleBaseSize = new System.Drawing.Size(8, 16);
				this.CancelButton = this.Button2;
				this.ClientSize = new System.Drawing.Size(386, 240);
				this.Controls.Add(this.Button4);
				this.Controls.Add(this.Button3);
				this.Controls.Add(this.Panel1);
				this.Controls.Add(this.Button2);
				this.Controls.Add(this.Button1);
				this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
				this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "frmCancelRsn";
				this.ShowInTaskbar = false;
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				this.Text = "选择取消原因";
				this.ResumeLayout(false);
				
			}
			
			#endregion
			
			//返回取消列表
			private void LoadCancelList()
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM CancelReason", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDS.Clear();
					dbDA.Fill(dbDS, "CancelReason");
					//dgCancelReason.DataSource = Nothing
					//dgCancelReason.DataSource = dbDS
					//dgCancelReason.DataMember = "CancelReason"
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
			
			private void GetCancels()
			{
				if (CancelFoodRsnBtnList != null)
				{
					CancelFoodRsnBtnList.RemoveAll();
					CancelFoodRsnBtnList = null;
				}
				CancelFoodRsnBtnList = new CancelFoodRsnButtonList(Panel1, 74, 40, Color.LightBlue, Color.FromArgb(255, 128, 128), 4);
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand("SELECT * FROM CancelReason", conn);
					selectCMD.CommandTimeout = 30;
					SqlDataAdapter dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					DataSet dbDS = new DataSet();
					dbDS.Clear();
					dbDA.Fill(dbDS, "t");
					for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
					{
						CancelFoodRsnBtnList.AddNewButton(dbDS.Tables[0].Rows[i]["reason"].ToString());
					}
					CancelReason = dbDS.Tables[0].Rows[0]["reason"].ToString();
					CancelFoodRsnBtnList.SelectItem(0);
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
			
			private void frmCancelRsn_Load(System.Object sender, System.EventArgs e)
			{
				rms_var.frmCancelReason = this;
				GetCancels();
			}
			
			private void Button3_Click(System.Object sender, System.EventArgs e)
			{
				if (CancelFoodRsnBtnList[0].Top != 0)
				{
					for (int i = 0; i <= CancelFoodRsnBtnList.Count - 1; i++)
					{
						CancelFoodRsnBtnList[i].Top += CancelFoodRsnPageInterval;
						CancelFoodRsnBtnList.CurrentBtnTop += CancelFoodRsnPageInterval;
					}
					CancelFoodRsnBtnList.CurrentBtnTop = System.Convert.ToInt32(CancelFoodRsnBtnList[CancelFoodRsnBtnList.Count - 1].Top);
				}
			}
			
			private void Button4_Click(System.Object sender, System.EventArgs e)
			{
				if ((CancelFoodRsnBtnList[CancelFoodRsnBtnList.Count - 1].Top + CancelFoodRsnBtnList[CancelFoodRsnBtnList.Count - 1].Height) > Panel1.Height)
				{
					for (int i = 0; i <= CancelFoodRsnBtnList.Count - 1; i++)
					{
						CancelFoodRsnBtnList[i].Top -= CancelFoodRsnPageInterval;
						CancelFoodRsnBtnList.CurrentBtnTop -= CancelFoodRsnPageInterval;
					}
					CancelFoodRsnBtnList.CurrentBtnTop = System.Convert.ToInt32(CancelFoodRsnBtnList[CancelFoodRsnBtnList.Count - 1].Top);
				}
			}
		}
		
	}
	
}
