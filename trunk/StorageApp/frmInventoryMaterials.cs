using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace StorageApp
{
	public class frmInventoryMaterials : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmInventoryMaterials()
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.Button Button2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmInventoryMaterials));
			this.DataGrid1 = new System.Windows.Forms.DataGrid();
			base.Load += new System.EventHandler(frmInventoryMaterials_Load);
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).BeginInit();
			this.SuspendLayout();
			//
			//DataGrid1
			//
			this.DataGrid1.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.DataGrid1.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGrid1.BackColor = System.Drawing.Color.GhostWhite;
			this.DataGrid1.BackgroundColor = System.Drawing.Color.Lavender;
			this.DataGrid1.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.DataGrid1.CaptionForeColor = System.Drawing.Color.White;
			this.DataGrid1.CaptionVisible = false;
			this.DataGrid1.DataMember = "";
			this.DataGrid1.FlatMode = true;
			this.DataGrid1.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.DataGrid1.HeaderForeColor = System.Drawing.Color.Lavender;
			this.DataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.DataGrid1.Location = new System.Drawing.Point(0, 67);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.DataGrid1.SelectionBackColor = System.Drawing.Color.Teal;
			this.DataGrid1.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.DataGrid1.Size = new System.Drawing.Size(620, 370);
			this.DataGrid1.TabIndex = 0;
			this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.DataGrid1;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn7});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "MaterialsList";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "物品编码";
			this.DataGridTextBoxColumn1.MappingName = "materialcode";
			this.DataGridTextBoxColumn1.ReadOnly = true;
			this.DataGridTextBoxColumn1.Width = 65;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "物品名称";
			this.DataGridTextBoxColumn2.MappingName = "materialname";
			this.DataGridTextBoxColumn2.ReadOnly = true;
			this.DataGridTextBoxColumn2.Width = 110;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "单位";
			this.DataGridTextBoxColumn3.MappingName = "unit";
			this.DataGridTextBoxColumn3.ReadOnly = true;
			this.DataGridTextBoxColumn3.Width = 50;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "本期盘存数量";
			this.DataGridTextBoxColumn4.MappingName = "currentperiodinvntquantity";
			this.DataGridTextBoxColumn4.Width = 90;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "本期领用数量";
			this.DataGridTextBoxColumn5.MappingName = "currentperiodquantity";
			this.DataGridTextBoxColumn5.ReadOnly = true;
			this.DataGridTextBoxColumn5.Width = 90;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "单价";
			this.DataGridTextBoxColumn6.MappingName = "price";
			this.DataGridTextBoxColumn6.ReadOnly = true;
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "合计";
			this.DataGridTextBoxColumn7.MappingName = "totalprice";
			this.DataGridTextBoxColumn7.ReadOnly = true;
			this.DataGridTextBoxColumn7.Width = 80;
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.Location = new System.Drawing.Point(8, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(144, 23);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "原物料";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label2.Location = new System.Drawing.Point(152, 12);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(128, 23);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "部门";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label3
			//
			this.Label3.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label3.Location = new System.Drawing.Point(8, 36);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(144, 23);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "上期盘存时间";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label4
			//
			this.Label4.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label4.Location = new System.Drawing.Point(152, 36);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(128, 23);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "本期盘存时间";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(473, 9);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(64, 48);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(542, 9);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(64, 48);
			this.Button2.TabIndex = 6;
			this.Button2.Text = "取消(&C)";
			//
			//frmInventoryMaterials
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(620, 437);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.DataGrid1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInventoryMaterials";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "部门物品盘存";
			((System.ComponentModel.ISupportInitialize) this.DataGrid1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		public string StorageDeptName;
		public string DeptName;
		public string PriorInvntDate;
		public string InventoryDate;
		public DataTable InventoryMaterials;
		
		//创建临时存储的已选择的物品记录表
		public void CreateSelectedMaterialsTable()
		{
			InventoryMaterials = new DataTable("MaterialsList");
			
			DataColumn Column3 = new DataColumn();
			Column3.DataType = System.Type.GetType("System.String");
			Column3.AllowDBNull = true;
			Column3.ReadOnly = true;
			Column3.DefaultValue = "";
			Column3.ColumnName = "MaterialCode";
			InventoryMaterials.Columns.Add(Column3);
			
			DataColumn Column4 = new DataColumn();
			Column4.DataType = System.Type.GetType("System.String");
			Column4.AllowDBNull = true;
			Column4.ReadOnly = true;
			Column4.ColumnName = "MaterialName";
			InventoryMaterials.Columns.Add(Column4);
			
			DataColumn Column5 = new DataColumn();
			Column5.DataType = System.Type.GetType("System.String");
			Column5.AllowDBNull = true;
			Column5.ReadOnly = true;
			Column5.ColumnName = "Unit";
			InventoryMaterials.Columns.Add(Column5);
			
			DataColumn Column8 = new DataColumn();
			Column8.DataType = System.Type.GetType("System.String");
			Column8.AllowDBNull = true;
			Column8.ReadOnly = false;
			Column8.DefaultValue = 0;
			Column8.ColumnName = "CurrentPeriodInvntQuantity"; //本期期末盘存数量
			InventoryMaterials.Columns.Add(Column8);
			
			DataColumn Column7 = new DataColumn();
			Column7.DataType = System.Type.GetType("System.String");
			Column7.AllowDBNull = true;
			Column7.ReadOnly = true;
			Column7.DefaultValue = 0;
			Column7.ColumnName = "CurrentPeriodQuantity"; //本期数量=本期领用数量+上期期末盘存数量
			InventoryMaterials.Columns.Add(Column7);
			
			DataColumn Column9 = new DataColumn();
			Column9.DataType = System.Type.GetType("System.String");
			Column9.AllowDBNull = true;
			Column9.ReadOnly = true;
			Column9.DefaultValue = 0;
			Column9.ColumnName = "Price";
			InventoryMaterials.Columns.Add(Column9);
			
			DataColumn Column10 = new DataColumn();
			Column10.DataType = System.Type.GetType("System.String");
			Column10.AllowDBNull = true;
			Column10.ReadOnly = true;
			Column10.DefaultValue = 0;
			Column10.ColumnName = "TotalPrice";
			InventoryMaterials.Columns.Add(Column10);
		}
		
		//添加临时物品记录
		public void AddMaterials(string MaterialCode, string MaterialName, string Unit, double CurrentPeriodQuantity, double totalprice)
			{
			DataRow myRow;
			
			myRow = InventoryMaterials.NewRow();
			myRow["MaterialCode"] = MaterialCode;
			myRow["MaterialName"] = MaterialName;
			myRow["Unit"] = Unit;
			myRow["CurrentPeriodQuantity"] = CurrentPeriodQuantity; //本期领用数量
			myRow["Price"] = totalprice / CurrentPeriodQuantity;
			myRow["totalprice"] = totalprice;
			InventoryMaterials.Rows.Add(myRow);
		}
		
		//
		private bool GetPriorPeriodMaterials(string storage, string deptname)
		{
			//先返回上期期末盘存物品数量
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "SELECT * FROM OutStoragebill where left(billno,1)='t' and outdepcode='" + rms_var.GetDeptCode(storage) + "' and " + "depcode='" + rms_var.GetDeptCode(deptname) + "' and storagebilltypecode='E' and outdate<'" + InventoryDate + "' order by outdate";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t"); //盘存单记录
				if (dbDS.Tables[0].Rows.Count == 0) //不存在上期盘存
				{
					//检测在盘存日期之后是否存盘存单，有则退出
					selectCMD.CommandText = "SELECT * FROM OutStoragebill where outdepcode='" + rms_var.GetDeptCode(storage) + "' and " + "depcode='" + rms_var.GetDeptCode(deptname) + "' and storagebilltypecode='E' and outdate>='" + InventoryDate + "' order by outdate";
					dbDA.Fill(dbDS, "test");
					if (dbDS.Tables["test"].Rows.Count > 0) //在输入的盘存日期后已经存在盘存单了，退出
					{
						MessageBox.Show("在 " + InventoryDate + " 或者之后已经存在盘存单了");
						return false;
					}
					//返回所有当前部门入库单据的物品 A D
					selectCMD.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice " + "FROM view_OutStorageMaterials where outdepcode='" + rms_var.GetDeptCode(storage) + "' and " + "depcode='" + rms_var.GetDeptCode(deptname) + "' and (storagebilltypecode='A' or storagebilltypecode='D') and outdate<'" + InventoryDate + "'" + " group by materialcode";
					dbDA.Fill(dbDS, "t1");
					
					//将上期期末物品添加进 InventoryMaterials
					for (int i = 0; i <= dbDS.Tables["t1"].Rows.Count - 1; i++)
					{
						//检测期初是否建账，若有则获取部门期初建账时的相应物品，作为上期期初盘存数据
						selectCMD.CommandText = "SELECT materialcode,quantity,price,totalprice " + "FROM SecStorage_Inventory where materialcode='" + dbDS.Tables["t1"].Rows[i]["materialcode"] + "'" + " and yearmonth='" + rms_var.GetSysSetup("Begindate") + "'";
						dbDA.Fill(dbDS, "t3");
						double priorquantity = 0;
						double priortotalprice = 0;
						
						if (dbDS.Tables["t3"].Rows.Count > 0) //在期初建账中存在当前物品，返回上期期末盘存物品数量和总钱数
						{
							priorquantity = System.Convert.ToDouble(dbDS.Tables["t3"].Rows[0]["quantity"]);
							priortotalprice = System.Convert.ToDouble(dbDS.Tables["t3"].Rows[0]["totalprice"]);
						}

                        AddMaterials(dbDS.Tables["t1"].Rows[i]["materialcode"].ToString(), rms_var.GetMaterialName(dbDS.Tables["t1"].Rows[i]["materialcode"].ToString()), rms_var.GetMaterialUnit(dbDS.Tables["t1"].Rows[i]["materialcode"].ToString()), (System.Convert.ToDouble(dbDS.Tables["t1"].Rows[i]["quantity"])) + priorquantity, (System.Convert.ToDouble(dbDS.Tables["t1"].Rows[i]["totalprice"])) + priortotalprice);
						dbDS.Tables["t3"].Clear();
					}
					
					DataGrid1.DataSource = InventoryMaterials;
					return true;
				}
				else //存在上期盘存
				{
					//检测在盘存日期之后是否存盘存单，有则退出
					selectCMD.CommandText = "SELECT * FROM OutStoragebill where outdepcode='" + rms_var.GetDeptCode(storage) + "' and " + "depcode='" + rms_var.GetDeptCode(deptname) + "' and storagebilltypecode='E' and outdate>='" + InventoryDate + "' order by outdate";
					dbDA.Fill(dbDS, "test");
					if (dbDS.Tables["test"].Rows.Count > 0) //在输入的盘存日期后已经存在盘存单了，退出
					{
						MessageBox.Show("在 " + InventoryDate + " 或者之后已经存在盘存单了");
						return false;
					}
					//返回上期期末盘存单据号
					string PriorPeriodBillNo;
					string PriorPeriodInventorydate;
					PriorPeriodBillNo = dbDS.Tables["t"].Rows[dbDS.Tables["t"].Rows.Count - 1]["Billno"].ToString();
					//上期盘存时间
					PriorPeriodInventorydate = dbDS.Tables["t"].Rows[dbDS.Tables["t"].Rows.Count - 1]["outdate"].ToString();
					PriorInvntDate = PriorPeriodInventorydate;
					
					//返回所有当前部门入库单据的物品 A D
					//返回上期期末盘存后所有领料、直拨出库单的物品数量
					selectCMD.CommandText = "SELECT materialcode,sum(quantity) as quantity,sum(totalprice) as totalprice " + "FROM view_OutStorageMaterials where outdepcode='" + rms_var.GetDeptCode(storage) + "' and " + "depcode='" + rms_var.GetDeptCode(deptname) + "' and (storagebilltypecode='A' or storagebilltypecode='D') and " + "outdate<'" + InventoryDate + "' and outdate>'" + PriorPeriodInventorydate + "'" + " group by materialcode";
					dbDA.Fill(dbDS, "t2");
					
					if (dbDS.Tables["t2"].Rows.Count == 0) //上次盘存后没有部门入库记录
					{
						//将上次盘存数量作为本期领用数量
						selectCMD.CommandText = "SELECT materialcode,quantity,price,totalprice " + "FROM view_OutStorageMaterials where billno='" + PriorPeriodBillNo + "'";
						dbDA.Fill(dbDS, "t3");
						for (int i = 0; i <= dbDS.Tables["t3"].Rows.Count - 1; i++)
						{
                            AddMaterials(dbDS.Tables["t3"].Rows[i]["materialcode"].ToString(), rms_var.GetMaterialName(dbDS.Tables["t3"].Rows[i]["materialcode"].ToString()), rms_var.GetMaterialUnit(dbDS.Tables["t3"].Rows[i]["materialcode"].ToString()), System.Convert.ToDouble(dbDS.Tables["t3"].Rows[i]["quantity"]), System.Convert.ToDouble(dbDS.Tables["t3"].Rows[i]["totalprice"]));
						}
					}
					else
					{
						for (int i = 0; i <= dbDS.Tables["t2"].Rows.Count - 1; i++)
						{
							selectCMD.CommandText = "SELECT materialcode,quantity,price,totalprice " + "FROM view_OutStorageMaterials where billno='" + PriorPeriodBillNo + "' and materialcode='" + dbDS.Tables["t2"].Rows[i]["materialcode"] + "'";
							dbDA.Fill(dbDS, "t3");
							double priorquantity = 0;
							double priortotalprice = 0;
							
							if (dbDS.Tables["t3"].Rows.Count > 0) //在盘存单中存在当前物品，返回上期期末盘存物品数量和总钱数
							{
								priorquantity = System.Convert.ToDouble(dbDS.Tables["t3"].Rows[0]["quantity"]);
								priortotalprice = System.Convert.ToDouble(dbDS.Tables["t3"].Rows[0]["totalprice"]);
							}
                            AddMaterials(dbDS.Tables["t2"].Rows[i]["materialcode"].ToString(), rms_var.GetMaterialName(dbDS.Tables["t2"].Rows[i]["materialcode"].ToString()), rms_var.GetMaterialUnit(dbDS.Tables["t2"].Rows[i]["materialcode"].ToString()), (System.Convert.ToDouble(dbDS.Tables["t2"].Rows[i]["quantity"])) + priorquantity, (System.Convert.ToDouble(dbDS.Tables["t2"].Rows[i]["totalprice"])) + priortotalprice);
							dbDS.Tables["t3"].Clear();
						}
					}
					DataGrid1.DataSource = InventoryMaterials;
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
		
		private void frmInventoryMaterials_Load(System.Object sender, System.EventArgs e)
		{
			Label1.Text = StorageDeptName;
			Label2.Text = DeptName;
			Label3.Text = PriorInvntDate;
			Label4.Text = InventoryDate;
			//查询上期盘存时间，并获取盘存数量
			CreateSelectedMaterialsTable();
			if (! GetPriorPeriodMaterials(StorageDeptName, DeptName))
			{
				Close();
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			bool successful = true;
			int totalnum;
			totalnum = InventoryMaterials.Rows.Count - 1;
			
			for (int i = 0; i <= totalnum; i++)
			{
				if (InventoryMaterials.Rows[InventoryMaterials.Rows.Count - 1][0].ToString() == "")
				{
					InventoryMaterials.Rows.RemoveAt(InventoryMaterials.Rows.Count - 1);
					totalnum--;
				}
			}
			
			//检测盘存数量是否合法
			try
			{
				for (int i = 0; i <= InventoryMaterials.Rows.Count - 1; i++)
				{
					if (System.Convert.ToDouble(DataGrid1[i, 3]) > System.Convert.ToDouble(DataGrid1[i, 4]))
					{
						MessageBox.Show("盘存数量不合法");
						successful = false;
						goto endOfTry;
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("盘存数量不合法");
				successful = false;
			}
endOfTry:
			
			if (successful)
			{
				this.DialogResult = DialogResult.OK;
				frmDeptInventory frmdi = new frmDeptInventory();
				frmdi.lblStorage.Text = StorageDeptName;
				frmdi.lblDeptname.Text = DeptName;
				frmdi.DateTimePicker1.Text = (DateTime.Parse(InventoryDate)).Year.ToString() + "-" + (DateTime.Parse(InventoryDate)).Month.ToString() + "-" + (DateTime.Parse(InventoryDate)).Day.ToString();
				frmdi.DateTimePicker2.Text = (DateTime.Parse(InventoryDate)).Hour.ToString() + ":" + (DateTime.Parse(InventoryDate)).Minute.ToString() + ":" + (DateTime.Parse(InventoryDate)).Second.ToString();
				if (DataGrid1.VisibleRowCount > 0)
				{
					frmdi.SelectedMaterials = InventoryMaterials;
					frmdi.dgMaterials.DataSource = frmdi.SelectedMaterials;
				}
				frmdi.ShowDialog();
			}
		}
		
	}
	
}
