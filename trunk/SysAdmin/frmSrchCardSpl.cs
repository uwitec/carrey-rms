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
	public class frmSrchCardSpl : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSrchCardSpl()
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGrid dgSrchCardSplRslt;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.ImageList ImageList1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmSrchCardSpl_Load);
			base.Closed += new System.EventHandler(frmSrchCardSpl_Closed);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSrchCardSpl));
			this.dgSrchCardSplRslt = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.Label3 = new System.Windows.Forms.Label();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			((System.ComponentModel.ISupportInitialize) this.dgSrchCardSplRslt).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//dgSrchCardSplRslt
			//
			this.dgSrchCardSplRslt.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgSrchCardSplRslt.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgSrchCardSplRslt.BackColor = System.Drawing.Color.GhostWhite;
			this.dgSrchCardSplRslt.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgSrchCardSplRslt.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgSrchCardSplRslt.CaptionForeColor = System.Drawing.Color.White;
			this.dgSrchCardSplRslt.DataMember = "";
			this.dgSrchCardSplRslt.FlatMode = true;
			this.dgSrchCardSplRslt.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgSrchCardSplRslt.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSrchCardSplRslt.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgSrchCardSplRslt.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgSrchCardSplRslt.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgSrchCardSplRslt.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgSrchCardSplRslt.LinkColor = System.Drawing.Color.Teal;
			this.dgSrchCardSplRslt.Location = new System.Drawing.Point(0, 96);
			this.dgSrchCardSplRslt.Name = "dgSrchCardSplRslt";
			this.dgSrchCardSplRslt.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgSrchCardSplRslt.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSrchCardSplRslt.ReadOnly = true;
			this.dgSrchCardSplRslt.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgSrchCardSplRslt.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgSrchCardSplRslt.Size = new System.Drawing.Size(656, 344);
			this.dgSrchCardSplRslt.TabIndex = 1;
			this.dgSrchCardSplRslt.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgSrchCardSplRslt;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "CardSupply";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "会员卡号";
			this.DataGridTextBoxColumn1.MappingName = "clubcardno";
			this.DataGridTextBoxColumn1.Width = 110;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "续存日期";
			this.DataGridTextBoxColumn2.MappingName = "supplydate";
			this.DataGridTextBoxColumn2.Width = 150;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "续存金额";
			this.DataGridTextBoxColumn3.MappingName = "cost";
			this.DataGridTextBoxColumn3.Width = 90;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "操作员";
			this.DataGridTextBoxColumn4.MappingName = "operator";
			this.DataGridTextBoxColumn4.Width = 90;
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(656, 96);
			this.Panel1.TabIndex = 0;
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(640, 80);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "查询条件";
			//
			//Button2
			//
			this.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Button2.ImageIndex = 1;
			this.Button2.ImageList = this.ImageList1;
			this.Button2.Location = new System.Drawing.Point(576, 16);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(56, 56);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "关闭";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			//
			//ImageList1
			//
			this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.ImageList1.ImageSize = new System.Drawing.Size(28, 28);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker2.Location = new System.Drawing.Point(400, 32);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(96, 21);
			this.DateTimePicker2.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(376, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(24, 23);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "到";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(272, 32);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(96, 21);
			this.DateTimePicker1.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(192, 32);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 23);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "开户日期：从";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(80, 32);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 32);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 4;
			this.Label1.Text = "会员卡号：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Button1
			//
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Button1.ImageIndex = 0;
			this.Button1.ImageList = this.ImageList1;
			this.Button1.Location = new System.Drawing.Point(512, 16);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(56, 56);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "查询";
			this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			//
			//frmSrchCardSpl
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(656, 445);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.dgSrchCardSplRslt);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmSrchCardSpl";
			this.Text = "会员卡续存记录查询";
			((System.ComponentModel.ISupportInitialize) this.dgSrchCardSplRslt).EndInit();
			this.Panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//搜索会员卡充值记录
		private void LoadCardAddupDisList(string cardcode, DateTime begindate, DateTime enddate)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (begindate == enddate)
				{
					selectCMD.CommandText = "SELECT * FROM CardSupply where " + "clubcardno like '%" + cardcode + "%'" + " and " + "datepart(year,supplydate)='" + begindate.Date.Year.ToString() + "'" + " and " + "datepart(month,supplydate)='" + begindate.Date.Month.ToString() + "'" + " and " + "datepart(day,supplydate)='" + begindate.Date.Day.ToString() + "'";
				}
				else
				{
					selectCMD.CommandText = "SELECT * FROM CardSupply where " + "clubcardno like '%" + cardcode + "%'" + " and " + "supplydate>='" + begindate + "' and supplydate<='" + enddate + "'";
				}
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "CardSupply");
				dgSrchCardSplRslt.DataSource = null;
				dgSrchCardSplRslt.DataSource = dbDS;
				dgSrchCardSplRslt.DataMember = "CardSupply";
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
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			LoadCardAddupDisList(TextBox1.Text, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date);
		}
		
		private void frmSrchCardSpl_Load(System.Object sender, System.EventArgs e)
		{
			
		}
		
		private void frmSrchCardSpl_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmscspl = null;
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
	
}
