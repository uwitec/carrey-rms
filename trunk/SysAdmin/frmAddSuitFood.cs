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
	public class frmAddSuitFood : System.Windows.Forms.Form
	{
		
		public string suitcode;
		public double suitprice;
		public double foodtotalprice = 0;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAddSuitFood()
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
		internal System.Windows.Forms.TreeView TreeView1;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGrid dgSuitFoods;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmAddSuitFood_Load);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAddSuitFood));
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.TreeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView1_ItemDrag);
			this.TreeView1.DoubleClick += new System.EventHandler(this.TreeView1_DoubleClick);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dgSuitFoods = new System.Windows.Forms.DataGrid();
			this.dgSuitFoods.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGrid1_DragEnter);
			this.dgSuitFoods.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGrid1_DragDrop);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgSuitFoods).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//TreeView1
			//
			this.TreeView1.HideSelection = false;
			this.TreeView1.ImageList = this.ImageList1;
			this.TreeView1.Location = new System.Drawing.Point(8, 16);
			this.TreeView1.Name = "TreeView1";
			this.TreeView1.Size = new System.Drawing.Size(200, 336);
			this.TreeView1.TabIndex = 0;
			//
			//ImageList1
			//
			this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			//
			//dgSuitFoods
			//
			this.dgSuitFoods.AllowDrop = true;
			this.dgSuitFoods.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgSuitFoods.BackColor = System.Drawing.Color.GhostWhite;
			this.dgSuitFoods.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgSuitFoods.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgSuitFoods.CaptionForeColor = System.Drawing.Color.White;
			this.dgSuitFoods.CaptionVisible = false;
			this.dgSuitFoods.DataMember = "";
			this.dgSuitFoods.FlatMode = true;
			this.dgSuitFoods.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgSuitFoods.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSuitFoods.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgSuitFoods.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgSuitFoods.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgSuitFoods.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgSuitFoods.LinkColor = System.Drawing.Color.Teal;
			this.dgSuitFoods.Location = new System.Drawing.Point(216, 48);
			this.dgSuitFoods.Name = "dgSuitFoods";
			this.dgSuitFoods.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgSuitFoods.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSuitFoods.ReadOnly = true;
			this.dgSuitFoods.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgSuitFoods.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgSuitFoods.Size = new System.Drawing.Size(432, 240);
			this.dgSuitFoods.TabIndex = 1;
			this.dgSuitFoods.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgSuitFoods;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "SuitFoodsList";
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "菜品编码";
			this.DataGridTextBoxColumn3.MappingName = "foodcode";
			this.DataGridTextBoxColumn3.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "菜品名称";
			this.DataGridTextBoxColumn2.MappingName = "foodname";
			this.DataGridTextBoxColumn2.Width = 75;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "单位";
			this.DataGridTextBoxColumn4.MappingName = "unit";
			this.DataGridTextBoxColumn4.Width = 75;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "单价";
			this.DataGridTextBoxColumn5.MappingName = "price";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "数量";
			this.DataGridTextBoxColumn6.MappingName = "foodqty";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(336, 368);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 2;
			this.Button1.Text = "删除(&D)";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(416, 368);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 3;
			this.Button2.Text = "清空(&L)";
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.ForeColor = System.Drawing.Color.Navy;
			this.Label1.Location = new System.Drawing.Point(216, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(432, 32);
			this.Label1.TabIndex = 4;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(552, 368);
			this.Button3.Name = "Button3";
			this.Button3.TabIndex = 5;
			this.Button3.Text = "确定(&O)";
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(256, 368);
			this.Button4.Name = "Button4";
			this.Button4.TabIndex = 6;
			this.Button4.Text = "添加(&A)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Location = new System.Drawing.Point(216, 296);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(432, 56);
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "信息";
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label2.ForeColor = System.Drawing.Color.Navy;
			this.Label2.Location = new System.Drawing.Point(8, 21);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(408, 23);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "菜品数量：0    菜品合计金额：0    优惠了：0";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label3
			//
			this.Label3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label3.Location = new System.Drawing.Point(0, 391);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(656, 23);
			this.Label3.TabIndex = 8;
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmAddSuitFood
			//
			this.AcceptButton = this.Button3;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(656, 414);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgSuitFoods);
			this.Controls.Add(this.TreeView1);
			this.Controls.Add(this.Label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddSuitFood";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "套餐菜品";
			((System.ComponentModel.ISupportInitialize) this.dgSuitFoods).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回菜品
		private void LoadFoodList()
		{
			TreeNode node1;
			TreeNode node2;
			TreeNode subnode;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select depcode,deptname from department where depttype='菜品制作' order by deptname";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "t1"); //菜品制作部门
				
				SqlCommand selectCMD1 = new SqlCommand();
				SqlDataAdapter dbDA1 = new SqlDataAdapter();
				DataSet dbDS1 = new DataSet();
				
				SqlCommand selectCMD2 = new SqlCommand();
				SqlDataAdapter dbDA2 = new SqlDataAdapter();
				DataSet dbDS2 = new DataSet();
				
				
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
                    node1 = TreeView1.Nodes.Add(dbDS.Tables[0].Rows[i][1].ToString());
					node1.ImageIndex = 0;
					
					selectCMD1.Connection = conn;
					selectCMD1.CommandText = "select typecode,typename from foodtype where deptcode='" + dbDS.Tables[0].Rows[i][0] + "' order by typename";
					selectCMD1.CommandTimeout = 30;
					
					dbDA1.SelectCommand = selectCMD1;
					dbDS1.Clear();
					dbDA1.Fill(dbDS1, "t2"); //菜品类别
					if (dbDS1.Tables[0].Rows.Count > 0)
					{
						for (int j = 0; j <= dbDS1.Tables[0].Rows.Count - 1; j++)
						{
                            node2 = node1.Nodes.Add(dbDS1.Tables[0].Rows[j][1].ToString());
							node2.ImageIndex = 0;
							
							selectCMD2.Connection = conn;
							selectCMD2.CommandText = "select foodname from foodlist where foodtypecode='" + dbDS1.Tables[0].Rows[j][0] + "' order by foodname";
							selectCMD2.CommandTimeout = 30;
							
							dbDA2.SelectCommand = selectCMD2;
							dbDS2.Clear();
							dbDA2.Fill(dbDS2, "t3");
							if (dbDS2.Tables[0].Rows.Count > 0)
							{
								for (int k = 0; k <= dbDS2.Tables[0].Rows.Count - 1; k++)
								{
                                    subnode = node2.Nodes.Add(dbDS2.Tables[0].Rows[k][0].ToString());
									subnode.ImageIndex = 2;
								}
							}
						}
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
		
		//返回套餐中菜品列表
		private void LoadSuitFoodsList(string suitcode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select * from view_suitfoods where suitcode='" + suitcode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "SuitFoodsList");
				dgSuitFoods.DataSource = null;
				dgSuitFoods.DataSource = dbDS;
				dgSuitFoods.DataMember = "SuitFoodsList";
				
				RefreshInfo();
				
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
		
		//添加套餐菜品记录
		private bool AddSuitFood(string suitcode, string foodcode, string foodqty)
			{
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectCMD = new SqlCommand("select foodcode from suitfoods where foodcode='" + foodcode + "' and suitcode='" + suitcode + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
				{
					MessageBox.Show("该套餐已经存在该菜品记录了！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into suitfoods " + "(suitcode,foodcode,foodqty) " + "values (" + "'" + suitcode + "'" + "," + "'" + foodcode + "'" + "," + foodqty + ")";
					
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
		private bool DelSuitFood(string suitcode, string foodcode, int mode)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				if (mode == 0) //删除当前原料记录
				{
					selectCMD.CommandText = "delete from suitfoods where suitcode='" + suitcode + "' " + "and foodcode='" + foodcode + "'";
				}
				else //清空当前菜品原料记录
				{
					selectCMD.CommandText = "delete from suitfoods where suitcode='" + suitcode + "' ";
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
		
		private void RefreshInfo()
		{
			foodtotalprice = 0;
			Label2.Text = "菜品数量：0    菜品合计金额：0    优惠了：0";
			if (dgSuitFoods.VisibleRowCount > 0)
			{
				Label2.Text = "菜品数量：" + dgSuitFoods.VisibleRowCount.ToString();
				
				//计算菜品价格合计
				for (int i = 1; i <= dgSuitFoods.VisibleRowCount; i++)
				{
                    foodtotalprice = foodtotalprice + double.Parse(dgSuitFoods[i - 1, 3].ToString().Trim()) * double.Parse(dgSuitFoods[i - 1, 4].ToString().Trim()); //单价*数量
				}

                Label2.Text = Label2.Text + "    " + "菜品售价合计：" + string.Format("{0:N2}", foodtotalprice);
                Label2.Text = Label2.Text + "    " + "优惠了：" + string.Format("{0:N2}", foodtotalprice - suitprice);
			}
		}
		
		private void frmAddSuitFood_Load(System.Object sender, System.EventArgs e)
		{
			LoadFoodList();
			LoadSuitFoodsList(suitcode);
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
			string foodname;
			foodname = e.Data.GetData(DataFormats.Text).ToString();
			frmAddSuitFoodQty frmaddsfq = new frmAddSuitFoodQty();
			frmaddsfq.Label1.Text = "菜品名称：" + foodname + "   单位：" + rms_var.GetFoodUnit(foodname) + "\r\n" + "单价：" + rms_var.GetFoodPrice(foodname);
			frmaddsfq.ShowDialog();
			if (frmaddsfq.DialogResult == DialogResult.OK)
			{
				//添加记录
				if (AddSuitFood(suitcode, rms_var.GetFoodCode(foodname), frmaddsfq.NumericUpDown1.Text))
				{
					LoadSuitFoodsList(suitcode);
				}
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			if (! (dgSuitFoods.CurrentRowIndex < 0))
			{
				if (MessageBox.Show("确定要清空组成当前套餐的所有菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (DelSuitFood(suitcode, "", 1))
					{
						LoadSuitFoodsList(suitcode);
					}
				}
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (! (dgSuitFoods.CurrentRowIndex < 0))
			{
				if (MessageBox.Show("确定要删除组成当前套餐的当前菜品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
                    if (DelSuitFood(suitcode, dgSuitFoods[dgSuitFoods.CurrentRowIndex, 0].ToString(), 0))
					{
						LoadSuitFoodsList(suitcode);
					}
				}
			}
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			if (! (TreeView1.SelectedNode.GetNodeCount(true) > 0))
			{
				string foodname;
				foodname = TreeView1.SelectedNode.Text;
				
				frmAddSuitFoodQty frmaddsfq = new frmAddSuitFoodQty();
				frmaddsfq.Label1.Text = "菜品名称：" + foodname + "   单位：" + rms_var.GetFoodUnit(foodname) + "\r\n" + "单价：" + rms_var.GetFoodPrice(foodname);
				frmaddsfq.ShowDialog();
				if (frmaddsfq.DialogResult == DialogResult.OK)
				{
					//添加记录
					if (AddSuitFood(suitcode, rms_var.GetFoodCode(foodname), frmaddsfq.NumericUpDown1.Text))
					{
						LoadSuitFoodsList(suitcode);
					}
					
				}
			}
		}
		
		private void TreeView1_DoubleClick(object sender, System.EventArgs e)
		{
			Button4_Click(sender, e);
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			if (dgSuitFoods.VisibleRowCount > 0)
			{
				//需要更新菜品当前成本
				if (rms_var.GetFoodCostMethodCode() != 1) //不是手工指定菜品成本，需要计算最新菜品成本
				{
					Label3.Text = "正在核算菜品成本......";
					
					//
					//
					//
					//
					//
					//
					//
				}
				Label3.Text = "正在核算套餐中菜品成本......";
				rms_var.UpdateSuitFoodsPrice(suitcode);
			}
			this.DialogResult = DialogResult.OK;
		}
	}
	
}
