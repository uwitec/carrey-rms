using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class SelTimeBlock : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public SelTimeBlock()
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
		internal System.Windows.Forms.DataGrid DataGrid1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SelTimeBlock));
			this.DataGrid1 = new System.Windows.Forms.DataGrid();
			base.Load += new System.EventHandler(SelTimeBlock_Load);
			this.DataGrid1.DoubleClick += new System.EventHandler(this.DataGrid1_DoubleClick);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).BeginInit();
			this.SuspendLayout();
			//
			//DataGrid1
			//
			this.DataGrid1.AlternatingBackColor = System.Drawing.Color.White;
			this.DataGrid1.BackColor = System.Drawing.Color.White;
			this.DataGrid1.BackgroundColor = System.Drawing.Color.Ivory;
			this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkSlateBlue;
			this.DataGrid1.CaptionForeColor = System.Drawing.Color.Lavender;
			this.DataGrid1.DataMember = "";
			this.DataGrid1.FlatMode = true;
			this.DataGrid1.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.DataGrid1.ForeColor = System.Drawing.Color.Black;
			this.DataGrid1.GridLineColor = System.Drawing.Color.Wheat;
			this.DataGrid1.HeaderBackColor = System.Drawing.Color.CadetBlue;
			this.DataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.DataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.DataGrid1.Location = new System.Drawing.Point(8, 8);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Ivory;
			this.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.DataGrid1.ReadOnly = true;
			this.DataGrid1.SelectionBackColor = System.Drawing.Color.Wheat;
			this.DataGrid1.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
			this.DataGrid1.Size = new System.Drawing.Size(224, 128);
			this.DataGrid1.TabIndex = 0;
			this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.DataGrid1;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "timeblock";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "时段编码";
			this.DataGridTextBoxColumn1.MappingName = "timeblockcode";
			this.DataGridTextBoxColumn1.Width = 65;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "时段名称";
			this.DataGridTextBoxColumn2.MappingName = "name";
			this.DataGridTextBoxColumn2.Width = 85;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(136, 144);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Label1
			//
			this.Label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label1.Location = new System.Drawing.Point(0, 161);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(242, 23);
			this.Label1.TabIndex = 2;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			//
			//SelTimeBlock
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(242, 184);
			this.ControlBox = false;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.DataGrid1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelTimeBlock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "选择营业时段";
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void TextBoxEnterHandler1(object sender, System.EventArgs e)
		{
			Control inner =(Control)sender;
			
			inner.Visible = false;
			DataGrid1.Select(DataGrid1.CurrentRowIndex);
			DataGrid1.Focus();
		}
		
		//返回时间段列表
		private void GetTimeBlockList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM timeblock";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "TimeBlock");
				DataGrid1.DataSource = null;
				DataGrid1.DataSource = dbDS;
				DataGrid1.DataMember = "TimeBlock";
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
		
		//设置全局时间段名称
		private void SetTimeBlock(string timeblock)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "update syssetup set value='" + timeblock + "'" + " where parametercode='CurrentTimeblockName'";
				conn.Open();
				selectCMD.ExecuteNonQuery();
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
		
		private void SelTimeBlock_Load(System.Object sender, System.EventArgs e)
		{
			DataGridTextBoxColumn1.TextBox.Enter += new System.EventHandler(new EventHandler(TextBoxEnterHandler1));
			DataGridTextBoxColumn2.TextBox.Enter += new System.EventHandler(new EventHandler(TextBoxEnterHandler1));
			
			GetTimeBlockList();
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			
			rms_var.TimeBlock = DataGrid1[DataGrid1.CurrentRowIndex, 1].ToString();
			SetTimeBlock(rms_var.TimeBlock);
			
			Label1.Text = "正在更新桌台预订状态....";
			Label1.Refresh();
			
			rms_var.UpdateAppointTable(rms_var.GetTimeBlockCode(rms_var.TimeBlock));
			
			Cursor = Cursors.Default;
			
			this.DialogResult = DialogResult.OK;
		}
		
		private void DataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			Button1_Click(sender, e);
		}
	}
	
}
