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
	public class frmSuitFood : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSuitFood()
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
		internal System.Windows.Forms.DataGrid dgSuitFood;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSuitFood));
			this.Button1 = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmSuitFood_Load);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.dgSuitFood = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgSuitFood).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(360, 216);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(440, 216);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//dgSuitFood
			//
			this.dgSuitFood.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgSuitFood.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgSuitFood.BackColor = System.Drawing.Color.GhostWhite;
			this.dgSuitFood.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgSuitFood.CaptionBackColor = System.Drawing.Color.Navy;
			this.dgSuitFood.CaptionForeColor = System.Drawing.Color.White;
			this.dgSuitFood.DataMember = "";
			this.dgSuitFood.FlatMode = true;
			this.dgSuitFood.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgSuitFood.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSuitFood.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgSuitFood.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgSuitFood.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgSuitFood.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgSuitFood.LinkColor = System.Drawing.Color.Teal;
			this.dgSuitFood.Location = new System.Drawing.Point(8, 8);
			this.dgSuitFood.Name = "dgSuitFood";
			this.dgSuitFood.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgSuitFood.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSuitFood.ReadOnly = true;
			this.dgSuitFood.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgSuitFood.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgSuitFood.Size = new System.Drawing.Size(522, 202);
			this.dgSuitFood.TabIndex = 3;
			this.dgSuitFood.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgSuitFood;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridBoolColumn1});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "Suit";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "套餐编码";
			this.DataGridTextBoxColumn1.MappingName = "suitcode";
			this.DataGridTextBoxColumn1.Width = 60;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "套餐名称";
			this.DataGridTextBoxColumn2.MappingName = "suitname";
			this.DataGridTextBoxColumn2.Width = 110;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "就餐人数";
			this.DataGridTextBoxColumn3.MappingName = "mannum";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "人均消费";
			this.DataGridTextBoxColumn4.MappingName = "eachstandard";
			this.DataGridTextBoxColumn4.Width = 75;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "套餐价格";
			this.DataGridTextBoxColumn5.MappingName = "standardsum";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "暂停使用";
			this.DataGridBoolColumn1.MappingName = "disabled";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 60;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.NumericUpDown1.Location = new System.Drawing.Point(104, 216);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(56, 21);
			this.NumericUpDown1.TabIndex = 4;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericUpDown1.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//Label1
			//
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label1.Location = new System.Drawing.Point(8, 216);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 23);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "选择套餐数量：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmSuitFood
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(538, 264);
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dgSuitFood);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSuitFood";
			this.ShowInTaskbar = false;
			this.Text = "选择套餐";
			((System.ComponentModel.ISupportInitialize) this.dgSuitFood).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回套餐列表
		private void LoadSuitsList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("SELECT * FROM suit", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "Suit");
				dgSuitFood.DataSource = null;
				dgSuitFood.DataSource = dbDS;
				dgSuitFood.DataMember = "Suit";
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
		
		private void frmSuitFood_Load(System.Object sender, System.EventArgs e)
		{
			LoadSuitsList();
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (! dgSuitFood.IsSelected(dgSuitFood.CurrentRowIndex))
			{
				MessageBox.Show("没有选中套餐，请确保要点选的套餐所在行已被选中然后重试。");
			}
			else
			{
				this.DialogResult = DialogResult.OK;
			}
		}
	}
	
}
