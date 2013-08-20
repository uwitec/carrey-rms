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
	public class frmFoodCost : System.Windows.Forms.Form
	{
		
		public string foodcode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmFoodCost()
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
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.TreeView TreeView1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.DataGrid dgFoodCostList;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmFoodCost_Load);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmFoodCost));
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.TreeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView1_ItemDrag);
			this.TreeView1.DoubleClick += new System.EventHandler(this.TreeView1_DoubleClick);
			this.dgFoodCostList = new System.Windows.Forms.DataGrid();
			this.dgFoodCostList.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGrid1_DragEnter);
			this.dgFoodCostList.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGrid1_DragDrop);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button4 = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgFoodCostList).BeginInit();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//ImageList1
			//
			this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(320, 392);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 4;
			this.Button1.Text = "删除(&D)";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(400, 392);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 5;
			this.Button2.Text = "清空(&L)";
			//
			//TreeView1
			//
			this.TreeView1.HideSelection = false;
			this.TreeView1.ImageList = this.ImageList1;
			this.TreeView1.Location = new System.Drawing.Point(8, 8);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.SelectedImageIndex = 1;
			this.TreeView1.Size = new System.Drawing.Size(208, 372);
			this.TreeView1.TabIndex = 0;
			//
			//dgFoodCostList
			//
			this.dgFoodCostList.AllowDrop = true;
			this.dgFoodCostList.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodCostList.BackColor = System.Drawing.Color.GhostWhite;
			this.dgFoodCostList.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgFoodCostList.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgFoodCostList.CaptionForeColor = System.Drawing.Color.White;
			this.dgFoodCostList.CaptionVisible = false;
			this.dgFoodCostList.DataMember = "";
			this.dgFoodCostList.FlatMode = true;
			this.dgFoodCostList.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgFoodCostList.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodCostList.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgFoodCostList.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodCostList.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgFoodCostList.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgFoodCostList.LinkColor = System.Drawing.Color.Teal;
			this.dgFoodCostList.Location = new System.Drawing.Point(224, 255);
			this.dgFoodCostList.Name = "dgFoodCostList";
			this.dgFoodCostList.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgFoodCostList.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgFoodCostList.ReadOnly = true;
			this.dgFoodCostList.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgFoodCostList.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgFoodCostList.Size = new System.Drawing.Size(351, 125);
			this.dgFoodCostList.TabIndex = 2;
			this.dgFoodCostList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgFoodCostList;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "FoodCostList";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "原料编码";
			this.DataGridTextBoxColumn1.MappingName = "materialcode";
			this.DataGridTextBoxColumn1.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "名称";
			this.DataGridTextBoxColumn2.MappingName = "materialname";
			this.DataGridTextBoxColumn2.Width = 80;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "组成类别";
			this.DataGridTextBoxColumn3.MappingName = "type";
			this.DataGridTextBoxColumn3.Width = 60;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "单位";
			this.DataGridTextBoxColumn4.MappingName = "unit";
			this.DataGridTextBoxColumn4.Width = 60;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "数量";
			this.DataGridTextBoxColumn5.MappingName = "quantity";
			this.DataGridTextBoxColumn5.Width = 65;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "损耗率";
			this.DataGridTextBoxColumn6.MappingName = "lossability";
			this.DataGridTextBoxColumn6.Width = 65;
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.ForeColor = System.Drawing.Color.Navy;
			this.Label1.Location = new System.Drawing.Point(224, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(351, 23);
			this.Label1.TabIndex = 7;
			//
			//Button4
			//
			this.Button4.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button4.Location = new System.Drawing.Point(480, 392);
			this.Button4.Name = "Button4";
			this.Button4.TabIndex = 6;
			this.Button4.Text = "关闭(&C)";
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(224, 232);
			this.Label8.Name = "Label8";
			this.Label8.TabIndex = 8;
			this.Label8.Text = "原料组成：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(240, 392);
			this.Button5.Name = "Button5";
			this.Button5.TabIndex = 3;
			this.Button5.Text = "添加(&A)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.NumericUpDown3);
			this.GroupBox1.Controls.Add(this.NumericUpDown2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.NumericUpDown1);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Location = new System.Drawing.Point(224, 32);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(352, 200);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "菜品成本一般信息";
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(232, 170);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(96, 23);
			this.Button3.TabIndex = 6;
			this.Button3.Text = "保存信息(&S)";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(104, 115);
			this.TextBox3.Multiline = true;
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox3.Size = new System.Drawing.Size(240, 48);
			this.TextBox3.TabIndex = 5;
			this.TextBox3.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(104, 64);
			this.TextBox2.Multiline = true;
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox2.Size = new System.Drawing.Size(240, 48);
			this.TextBox2.TabIndex = 4;
			this.TextBox2.Text = "";
			//
			//NumericUpDown3
			//
			this.NumericUpDown3.Location = new System.Drawing.Point(264, 40);
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new System.Drawing.Size(80, 21);
			this.NumericUpDown3.TabIndex = 3;
			this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.Location = new System.Drawing.Point(104, 40);
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new System.Drawing.Size(80, 21);
			this.NumericUpDown2.TabIndex = 2;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(264, 16);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(80, 21);
			this.TextBox1.TabIndex = 1;
			this.TextBox1.Text = "";
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(104, 16);
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(80, 21);
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(16, 115);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(88, 23);
			this.Label7.TabIndex = 12;
			this.Label7.Text = "特点及标准：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(32, 64);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(72, 23);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "加工方法：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(192, 40);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "其它费用：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(32, 40);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "燃料费：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(192, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "规格：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(32, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "份量：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmFoodCost
			//
			this.AcceptButton = this.Button4;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button4;
			this.ClientSize = new System.Drawing.Size(584, 428);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dgFoodCostList);
			this.Controls.Add(this.TreeView1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFoodCost";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "菜品成本卡";
			((System.ComponentModel.ISupportInitialize) this.dgFoodCostList).EndInit();
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回菜品成本信息
		private void GetFoodCostInfo(string foodcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select * from foodcost where foodcode='" + foodcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "FoodList");
				
				if (dbDS.Tables[0].Rows.Count > 0)
				{
					NumericUpDown1.Text = dbDS.Tables[0].Rows[0][1].ToString();
					TextBox1.Text = dbDS.Tables[0].Rows[0][2].ToString();
					NumericUpDown2.Text = dbDS.Tables[0].Rows[0][5].ToString();
					NumericUpDown3.Text = dbDS.Tables[0].Rows[0][6].ToString();
					TextBox2.Text = dbDS.Tables[0].Rows[0][3].ToString();
					TextBox3.Text = dbDS.Tables[0].Rows[0][4].ToString();
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
		
		//保存菜品成本一般信息
		private bool SaveFoodCostInfo(string foodcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select foodcode from foodcost where foodcode='" + foodcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码,进行更新，否则添加
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update foodcost set " + "weight = " + NumericUpDown1.Text + "," + "standard='" + TextBox1.Text + "'" + "," + "fuelcost=" + NumericUpDown2.Text + "," + "othercost=" + NumericUpDown3.Text + "," + "dosteps='" + TextBox2.Text + "'" + "," + "feature='" + TextBox3.Text + "' " + "where foodcode='" + foodcode + "'";
					
					selectCMD.ExecuteNonQuery();
					return true;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into foodcost " + "(foodcode,weight,standard,fuelcost,othercost,dosteps,feature) " + "values (" + "'" + foodcode + "'" + "," + NumericUpDown1.Text + "," + "'" + TextBox1.Text + "'" + "," + NumericUpDown2.Text + "," + NumericUpDown3.Text + "," + "'" + TextBox2.Text + "'" + "," + "'" + TextBox3.Text + "'" + ")";
					
					selectCMD.ExecuteNonQuery();
					return true;
				}
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
		
		//返回菜品成本原料组成信息
		private void GetFoodCostMtrlInfo(string foodcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select * from view_FoodCost where foodcode='" + foodcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "FoodCostList");
				dgFoodCostList.DataSource = null;
				dgFoodCostList.DataSource = dbDS;
				dgFoodCostList.DataMember = "FoodCostList";
				
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
		
		//返回原料
		private void LoadMaterialList()
		{
			TreeNode node;
			TreeNode subnode;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select materialtypecode,name from MaterialType where issalecost='1' order by name";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "t1");
				
				SqlCommand selectCMD1 = new SqlCommand();
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				DataSet dbDS1 = new DataSet();
				
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					node = TreeView1.Nodes.Add(dbDS.Tables[0].Rows[i][1].ToString()); //添加类别节点
					node.ImageIndex = 0;
					
					selectCMD1.Connection = conn;
					selectCMD1.CommandText = "select materialname from Materials where materialtypecode='" + dbDS.Tables[0].Rows[i][0].ToString() + "' order by materialname";
					selectCMD1.CommandTimeout = 30;
					
					dbDA1.SelectCommand = selectCMD1;
					dbDS1.Clear();
					dbDA1.Fill(dbDS1, "t2");
					for (int j = 0; j <= dbDS1.Tables[0].Rows.Count - 1; j++) //向当前类别节点下添加原料记录
					{
						subnode = node.Nodes.Add(dbDS1.Tables[0].Rows[j][0].ToString());
						subnode.ImageIndex = 2;
					}
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
		
		//添加菜品组成的原料记录
		private bool AddMtrl(string foodcode, string materialcode, string Type, string unit, double quantity, double lossability)
			{
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select foodcode,materialcode from FoodCost_MList where foodcode='" + foodcode + "' and materialcode='" + materialcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
				{
					MessageBox.Show("该菜品已经存在该原料记录了！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into FoodCost_MList " + "(foodcode,materialcode,Type,unit,quantity,lossability) " + "values (" + "'" + foodcode + "'" + "," + "'" + materialcode + "'" + "," + "'" + Type + "'" + "," + "'" + unit + "'" + "," + quantity.ToString() + "," + lossability.ToString() + ")";
					
					selectCMD.ExecuteNonQuery();
					
					return true;
				}
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
		
		//删除菜品组成的原料
		private bool DelMtrl(string foodcode, string materialcode, int mode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (mode == 0) //删除当前原料记录
				{
					selectCMD.CommandText = "delete from FoodCost_MList where foodcode='" + foodcode + "' " + "and materialcode='" + materialcode + "'";
				}
				else //清空当前菜品原料记录
				{
					selectCMD.CommandText = "delete from FoodCost_MList where foodcode='" + foodcode + "' ";
				}
				
				selectCMD.CommandTimeout = 30;
				conn.Open();
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
		
		private void frmFoodCost_Load(System.Object sender, System.EventArgs e)
		{
			LoadMaterialList();
			GetFoodCostInfo(foodcode);
			GetFoodCostMtrlInfo(foodcode);
		}
		
		private void TreeView1_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			if (! (TreeView1.SelectedNode.GetNodeCount(true) > 0))
			{
				TreeView1.DoDragDrop(TreeView1.SelectedNode.Text, DragDropEffects.Copy | DragDropEffects.Move);
			}
		}
		
		private void DataGrid1_DragEnter(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		
		private void DataGrid1_DragDrop(System.Object sender, System.Windows.Forms.DragEventArgs e)
		{
			string materialname;
			materialname = e.Data.GetData(DataFormats.Text).ToString();
			
			frmAddFoodCost frmaddmtrl = new frmAddFoodCost();
			frmaddmtrl.Label1.Text = "名称：" + materialname + "  单位：" + rms_var.GetMaterialUnit(materialname);
			frmaddmtrl.ShowDialog();
			if (frmaddmtrl.DialogResult == DialogResult.OK)
			{
				//向成本表中添加记录
				if (AddMtrl(foodcode, rms_var.GetMaterialCode(materialname), frmaddmtrl.ComboBox1.Text, rms_var.GetMaterialUnit(materialname), (double) frmaddmtrl.NumericUpDown1.Value, (double) frmaddmtrl.NumericUpDown2.Value))
					{
					GetFoodCostMtrlInfo(foodcode);
				}
				
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			if (! (dgFoodCostList.CurrentRowIndex < 0))
			{
				if (MessageBox.Show("确定要清空组成当前菜品的所有原料吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (DelMtrl(foodcode, "", 1))
					{
						GetFoodCostMtrlInfo(foodcode);
					}
				}
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (! (dgFoodCostList.CurrentRowIndex < 0))
			{
				if (MessageBox.Show("确定要删除组成当前菜品的当前原料吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
                    if (DelMtrl(foodcode, dgFoodCostList[dgFoodCostList.CurrentRowIndex, 0].ToString(), 0))
					{
						GetFoodCostMtrlInfo(foodcode);
					}
				}
			}
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			if (SaveFoodCostInfo(foodcode))
			{
				MessageBox.Show("保存成功，请为该菜品添加原料以进一步组成菜品成本。");
			}
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
            try
            {
                if (!(TreeView1.SelectedNode.GetNodeCount(true)>0))
                {
                    string materialname;
                    materialname = TreeView1.SelectedNode.Text;

                    frmAddFoodCost frmaddmtrl = new frmAddFoodCost();
                    frmaddmtrl.Label1.Text = "名称：" + materialname + "  单位：" + rms_var.GetMaterialUnit(materialname);
                    frmaddmtrl.ShowDialog();
                    if (frmaddmtrl.DialogResult == DialogResult.OK)
                    {
                        //向成本表中添加记录
                        if (AddMtrl(foodcode, rms_var.GetMaterialCode(materialname), frmaddmtrl.ComboBox1.Text, rms_var.GetMaterialUnit(materialname), (double)frmaddmtrl.NumericUpDown1.Value, (double)frmaddmtrl.NumericUpDown2.Value))
                        {
                            GetFoodCostMtrlInfo(foodcode);
                        }

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
		}
		
		private void TreeView1_DoubleClick(object sender, System.EventArgs e)
		{
			Button5_Click(sender, e);
		}
		
	}
	
}
