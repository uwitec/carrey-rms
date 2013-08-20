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
	public class frmBrsSpecialFood : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmBrsSpecialFood()
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
		internal System.Windows.Forms.DataGrid dgFoodList;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBrsSpecialFood));
			this.dgFoodList = new System.Windows.Forms.DataGrid();
			base.Load += new System.EventHandler(frmBrsSpecialFood_Load);
			base.Closed += new System.EventHandler(frmBrsSpecialFood_Closed);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			((System.ComponentModel.ISupportInitialize) this.dgFoodList).BeginInit();
			this.SuspendLayout();
			//
			//dgFoodList
			//
			this.dgFoodList.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dgFoodList.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgFoodList.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgFoodList.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgFoodList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgFoodList.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgFoodList.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.CaptionText = "菜品列表";
			this.dgFoodList.DataMember = "";
			this.dgFoodList.FlatMode = true;
			this.dgFoodList.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgFoodList.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dgFoodList.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgFoodList.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgFoodList.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgFoodList.LinkColor = System.Drawing.Color.Teal;
			this.dgFoodList.Location = new System.Drawing.Point(0, 0);
			this.dgFoodList.Name = "dgFoodList";
			this.dgFoodList.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dgFoodList.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodList.ReadOnly = true;
			this.dgFoodList.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgFoodList.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgFoodList.Size = new System.Drawing.Size(616, 408);
			this.dgFoodList.TabIndex = 3;
			this.dgFoodList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgFoodList;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn7});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "specialfoodlist";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "菜品编码";
			this.DataGridTextBoxColumn1.MappingName = "foodcode";
			this.DataGridTextBoxColumn1.Width = 55;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "菜品名称";
			this.DataGridTextBoxColumn2.MappingName = "foodname";
			this.DataGridTextBoxColumn2.Width = 110;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "单位";
			this.DataGridTextBoxColumn3.MappingName = "unit";
			this.DataGridTextBoxColumn3.Width = 50;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "类别";
			this.DataGridTextBoxColumn4.MappingName = "typename";
			this.DataGridTextBoxColumn4.Width = 85;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "所属部门";
			this.DataGridTextBoxColumn5.MappingName = "deptname";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "原始单价";
			this.DataGridTextBoxColumn6.MappingName = "price";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "特价";
			this.DataGridTextBoxColumn7.MappingName = "specialprice";
			this.DataGridTextBoxColumn7.Width = 75;
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(520, 416);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 4;
			this.Button1.Text = "确定(&O)";
			//
			//frmBrsSpecialFood
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 454);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgFoodList);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmBrsSpecialFood";
			this.Text = "特价菜";
			((System.ComponentModel.ISupportInitialize) this.dgFoodList).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回特价菜菜品列表
		private void GetSpecialFoodList()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select * from view_foodlist where specialfood='1'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "SpecialFoodList");
				dgFoodList.DataSource = null;
				dgFoodList.DataSource = dbDS;
				dgFoodList.DataMember = "SpecialFoodList";
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
		
		private void frmBrsSpecialFood_Load(System.Object sender, System.EventArgs e)
		{
			GetSpecialFoodList();
		}
		
		private void frmBrsSpecialFood_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmbrssfod = null;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
	
}
