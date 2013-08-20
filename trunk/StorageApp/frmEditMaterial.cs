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
	public class frmEditMaterial : System.Windows.Forms.Form
	{
		
		public string CurrentStorageDeptName;
		public int frmMode; //0=edit 1=add
		public string OldMaterialCode;
		public string OldMaterialName;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditMaterial()
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
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown2;
		internal System.Windows.Forms.NumericUpDown NumericUpDown3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown1;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditMaterial));
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			base.Load += new System.EventHandler(frmEditMaterial_Load);
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(232, 208);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(312, 208);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.NumericUpDown2);
			this.GroupBox1.Controls.Add(this.NumericUpDown3);
			this.GroupBox1.Controls.Add(this.NumericUpDown1);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.TextBox5);
			this.GroupBox1.Controls.Add(this.TextBox4);
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(408, 184);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "物品信息";
			//
			//NumericUpDown2
			//
			this.NumericUpDown2.Location = new System.Drawing.Point(304, 117);
			this.NumericUpDown2.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown2.Name = "NumericUpDown2";
			this.NumericUpDown2.Size = new System.Drawing.Size(88, 21);
			this.NumericUpDown2.TabIndex = 8;
			this.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown3
			//
			this.NumericUpDown3.Location = new System.Drawing.Point(304, 53);
			this.NumericUpDown3.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown3.Name = "NumericUpDown3";
			this.NumericUpDown3.Size = new System.Drawing.Size(88, 21);
			this.NumericUpDown3.TabIndex = 6;
			this.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//NumericUpDown1
			//
			this.NumericUpDown1.Location = new System.Drawing.Point(304, 85);
			this.NumericUpDown1.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
			this.NumericUpDown1.Name = "NumericUpDown1";
			this.NumericUpDown1.Size = new System.Drawing.Size(88, 21);
			this.NumericUpDown1.TabIndex = 7;
			this.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label9
			//
			this.Label9.Location = new System.Drawing.Point(224, 53);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(80, 23);
			this.Label9.TabIndex = 35;
			this.Label9.Text = "月领用限额：";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label8
			//
			this.Label8.Location = new System.Drawing.Point(224, 117);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(80, 23);
			this.Label8.TabIndex = 34;
			this.Label8.Text = "库存下限：";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label7
			//
			this.Label7.Location = new System.Drawing.Point(224, 85);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(80, 23);
			this.Label7.TabIndex = 33;
			this.Label7.Text = "库存上限：";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(88, 117);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(120, 21);
			this.TextBox5.TabIndex = 4;
			this.TextBox5.Text = "";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(88, 141);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(120, 21);
			this.TextBox4.TabIndex = 5;
			this.TextBox4.Text = "";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(88, 93);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(120, 21);
			this.TextBox3.TabIndex = 3;
			this.TextBox3.Text = "";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(88, 69);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(120, 21);
			this.TextBox2.TabIndex = 2;
			this.TextBox2.Text = "";
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(88, 45);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(120, 21);
			this.TextBox1.TabIndex = 1;
			this.TextBox1.Text = "";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(88, 21);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 20);
			this.ComboBox1.TabIndex = 0;
			//
			//Label6
			//
			this.Label6.Location = new System.Drawing.Point(16, 117);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(72, 23);
			this.Label6.TabIndex = 32;
			this.Label6.Text = "单位：";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(16, 141);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(72, 23);
			this.Label5.TabIndex = 31;
			this.Label5.Text = "型号：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(16, 93);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 30;
			this.Label4.Text = "拼音码：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(16, 69);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 29;
			this.Label3.Text = "物品名称：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 45);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(72, 23);
			this.Label2.TabIndex = 28;
			this.Label2.Text = "物品编码：";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 21);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 27;
			this.Label1.Text = "物品分类：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmEditMaterial
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(424, 248);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditMaterial";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//添加
		private bool AddData(string materialcode, string typename, string materialname, string spell, string unit, string type, double LimitedQty, double UpperQTy, double LowerQty)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select materialcode from materials where materialcode='" + materialcode + "' or materialname='" + materialname + "'", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				if (dbDS.Tables[0].Rows.Count > 0) //存在
				{
					MessageBox.Show("编码或名称重复！");
					return false;
				}
				else
				{
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "insert into materials (materialcode,materialname,unit,Type,MaterialTypeCode," + "Spell,LimitedQty,UpperQTy,LowerQty) " + "values (" + "'" + materialcode + "'" + "," + "'" + materialname + "'" + "," + "'" + unit + "'" + "," + "'" + type + "'" + "," + "'" + rms_var.GetMaterialTypeCode(typename) + "'" + "," + "'" + spell + "'" + "," + LimitedQty.ToString() + "," + UpperQTy.ToString() + "," + LowerQty.ToString() + ")";
					
					selectCMD.ExecuteNonQuery();
					
					return true;
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
			return false;
		}
		
		//修改
		private bool EditData(string oldmaterialcode, string newmaterialcode, string typename, string materialname, string spell, string unit, string type, double LimitedQty, double UpperQTy, double LowerQty)
			{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD;
				SqlDataAdapter dbDA;
				DataSet dbDS;
				
				if (oldmaterialcode == newmaterialcode && OldMaterialName == materialname) //没有改变，直接更新
				{
					selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					conn.Open();
					
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					selectCMD.CommandText = "update materials set " + "MaterialTypeCode='" + rms_var.GetMaterialTypeCode(typename) + "'" + "," + "spell='" + spell + "'" + "," + "unit='" + unit + "'" + "," + "type='" + type + "'" + "," + "LimitedQty=" + LimitedQty.ToString() + "," + "UpperQTy=" + UpperQTy.ToString() + "," + "LowerQty=" + LowerQty.ToString() + " " + "where materialcode='" + oldmaterialcode + "'";
					selectCMD.ExecuteNonQuery();
					
					return true;
					
				}
				else //编码改变
				{
					selectCMD = new SqlCommand();
					selectCMD.CommandText = "select materialcode from materials where materialcode='" + newmaterialcode + "' and materialcode<>'" + oldmaterialcode + "'" + " or name='" + typename + "'" + " and name<>'" + OldMaterialName + "'";
					selectCMD.Connection = conn;
					selectCMD.CommandTimeout = 30;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectCMD;
					conn.Open();
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					
					if (dbDS.Tables[0].Rows.Count > 0) //存在该编码
					{
						MessageBox.Show("编码或名称重复！");
						return false;
					}
					else
					{
						selectCMD.Connection = conn;
						selectCMD.CommandTimeout = 30;
						selectCMD.CommandText = "update materials set " + "materialcode='" + newmaterialcode + "'" + "," + "materialname='" + materialname + "'" + "," + "MaterialTypeCode='" + rms_var.GetMaterialTypeCode(typename) + "'" + "," + "spell='" + spell + "'" + "," + "unit='" + unit + "'" + "," + "type='" + type + "'" + "," + "LimitedQty=" + LimitedQty + "," + "UpperQTy=" + UpperQTy + "," + "LowerQty=" + LowerQty + " " + "where materialcode='" + oldmaterialcode + "'";
						selectCMD.ExecuteNonQuery();
						
						return true;
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
			return false;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (frmMode == 2) //修改记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("not blank");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("not blank");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("not blank");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (MessageBox.Show("确定要修改当前物品信息吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					if (EditData(OldMaterialCode, TextBox1.Text, ComboBox1.Text, TextBox2.Text, TextBox3.Text, TextBox5.Text, TextBox4.Text, (double) NumericUpDown3.Value, (double) NumericUpDown1.Value, (double) NumericUpDown2.Value))
						{
						MessageBox.Show("修改记录成功！");
						this.DialogResult = DialogResult.OK;
					}
				}
				
			}
			else if (frmMode == 1) //添加记录
			{
				if (TextBox1.Text.Trim() == "")
				{
					MessageBox.Show("not blank");
					TextBox1.Focus();
					TextBox1.SelectAll();
					return;
				}
				if (TextBox2.Text.Trim() == "")
				{
					MessageBox.Show("not blank");
					TextBox2.Focus();
					TextBox2.SelectAll();
					return;
				}
				if (ComboBox1.Text.Trim() == "")
				{
					MessageBox.Show("not blank");
					ComboBox1.Focus();
					ComboBox1.SelectAll();
					return;
				}
				if (AddData(TextBox1.Text, ComboBox1.Text, TextBox2.Text, TextBox3.Text, TextBox5.Text, TextBox4.Text, (double) NumericUpDown3.Value, (double) NumericUpDown1.Value, (double) NumericUpDown2.Value))
					{
					MessageBox.Show("添加记录成功！");
					if (MessageBox.Show("继续添加新物品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						TextBox1.Text = "";
						TextBox2.Text = "";
						TextBox3.Text = "";
						TextBox4.Text = "";
						TextBox5.Text = "";
						NumericUpDown3.Value = 0;
						NumericUpDown1.Value = 0;
						NumericUpDown2.Value = 0;
						
						TextBox1.Focus();
						TextBox1.SelectAll();
					}
					else
					{
						this.DialogResult = DialogResult.OK;
					}
				}
			}
			else if (frmMode == 3) //查询
			{
				this.DialogResult = DialogResult.OK;
			}
		}
		
		private void frmEditMaterial_Load(System.Object sender, System.EventArgs e)
		{
			//设置原物料编码长度
			TextBox1.MaxLength = int.Parse(rms_var.GetMaterialCodeLenth(CurrentStorageDeptName));
		}
	}
	
}
