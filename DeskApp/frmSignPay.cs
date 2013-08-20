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
	public class frmSignPay : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmSignPay()
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
		internal System.Windows.Forms.DataGrid dgSignPay;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Button Button3;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSignPay));
			this.dgSignPay = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.dgSignPay).BeginInit();
			this.SuspendLayout();
			//
			//dgSignPay
			//
			this.dgSignPay.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dgSignPay.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgSignPay.BackColor = System.Drawing.Color.Gainsboro;
			this.dgSignPay.BackgroundColor = System.Drawing.Color.Silver;
			this.dgSignPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgSignPay.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgSignPay.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgSignPay.DataMember = "";
			this.dgSignPay.FlatMode = true;
			this.dgSignPay.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgSignPay.ForeColor = System.Drawing.Color.Black;
			this.dgSignPay.GridLineColor = System.Drawing.Color.DimGray;
			this.dgSignPay.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgSignPay.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgSignPay.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgSignPay.HeaderForeColor = System.Drawing.Color.White;
			this.dgSignPay.LinkColor = System.Drawing.Color.MidnightBlue;
			this.dgSignPay.Location = new System.Drawing.Point(8, 48);
			this.dgSignPay.Name = "dgSignPay";
			this.dgSignPay.ParentRowsBackColor = System.Drawing.Color.DarkGray;
			this.dgSignPay.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dgSignPay.ReadOnly = true;
			this.dgSignPay.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgSignPay.SelectionForeColor = System.Drawing.Color.White;
			this.dgSignPay.Size = new System.Drawing.Size(656, 336);
			this.dgSignPay.TabIndex = 3;
			this.dgSignPay.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgSignPay;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn7, this.DataGridTextBoxColumn6});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "BalanceType";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "GUID";
			this.DataGridTextBoxColumn1.MappingName = "serialno";
			this.DataGridTextBoxColumn1.Width = 220;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "桌台号";
			this.DataGridTextBoxColumn2.MappingName = "tableno";
			this.DataGridTextBoxColumn2.Width = 55;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "开台时间";
			this.DataGridTextBoxColumn3.MappingName = "begintime";
			this.DataGridTextBoxColumn3.Width = 90;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "签单时间";
			this.DataGridTextBoxColumn4.MappingName = "paytime";
			this.DataGridTextBoxColumn4.Width = 90;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "签单金额";
			this.DataGridTextBoxColumn5.MappingName = "balancecost";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "操作员";
			this.DataGridTextBoxColumn6.MappingName = "operator";
			this.DataGridTextBoxColumn6.Width = 60;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(296, 16);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 4;
			this.Button1.Text = "结账(&P)";
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Button2.Location = new System.Drawing.Point(576, 392);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 5;
			this.Button2.Text = "关闭(&C)";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 23);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "签单日期：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(88, 16);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(112, 21);
			this.DateTimePicker1.TabIndex = 7;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(208, 16);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(80, 23);
			this.Button3.TabIndex = 10;
			this.Button3.Text = "查询(&F)";
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "客户编码";
			this.DataGridTextBoxColumn7.MappingName = "customercode";
			this.DataGridTextBoxColumn7.Width = 65;
			//
			//frmSignPay
			//
			this.AcceptButton = this.Button2;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(672, 430);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgSignPay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSignPay";
			this.ShowInTaskbar = false;
			this.Text = "签单结账";
			((System.ComponentModel.ISupportInitialize) this.dgSignPay).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回一定日期内的签单记录
		private void LoadSignPayList(DateTime signpaydate)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandText = "SELECT * FROM view_BalanceType where " + "DATEPART(year, paytime)>='" + signpaydate.Year.ToString() + "' and DATEPART(month, paytime)>='" + signpaydate.Month.ToString() + "' and DATEPART(day, paytime)>='" + signpaydate.Day.ToString() + "' and paytypecode='4'";
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDS.Clear();
				dbDA.Fill(dbDS, "BalanceType");
				dgSignPay.DataSource = null;
				dgSignPay.DataSource = dbDS;
				dgSignPay.DataMember = "BalanceType";
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
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			LoadSignPayList(DateTimePicker1.Value);
		}
		
		private bool UpdateBalanceType(string serialno, string topaytypecode)
		{
			bool returnValue;
			returnValue = false;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandText = "update balancetype set paytypecode='" + topaytypecode + "'" + " where serialno='" + serialno + "'";
				selectCMD.Connection = conn;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				returnValue = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return returnValue;
		}
		
		private bool UpdateCustomerCost(string customercode, string paycost)
		{
			bool returnValue;
			returnValue = false;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandText = "update customer set totalcost=totalcost+" + paycost + " where customercode='" + customercode + "'";
				selectCMD.Connection = conn;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				returnValue = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return returnValue;
		}
		
		private bool AddSignPayFor(string serialno, string customercode, string paytypecode, string cost)
		{
			bool returnValue;
			returnValue = false;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandText = "insert into SignPayfor (Serialno,SignPayDate,CustomerCode,PayTypeCode,Cost,Operator) " + "values ('" + serialno + "','" + DateTime.Now.ToString() + "','" + customercode + "','" + paytypecode + "'," + cost + ",'" + rms_var.opinfo.OpID + "')";
				
				selectCMD.Connection = conn;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				returnValue = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return returnValue;
		}
		
		private bool UpdateBalance(string serialno, string discountcost, string oddcost, string endBalanceCost)
		{
			bool returnValue;
			returnValue = false;
			
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.CommandText = "update balance set discountcost=" + discountcost + ",oddcost=" + oddcost + ",balancecost=" + endBalanceCost + " where serialno='" + serialno + "'";
				
				selectCMD.Connection = conn;
				conn.Open();
				selectCMD.ExecuteNonQuery();
				returnValue = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return returnValue;
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
            if (dgSignPay.CurrentRowIndex == -1)
            {
                return;
            }
			//1、返回当前选中记录的 serialno,计算serialno的所有桌台应付金额
			string SelectedPaySerialno;
			
			SelectedPaySerialno = dgSignPay[dgSignPay.CurrentRowIndex, 0].ToString();
			
			//2、允许自由打折
			int DiscountRate = 100; //默认打折率
			
			if (rms_var.TheAppExt.Chk_op_dz)
			{
				frmFreeDiscount frmfd = new frmFreeDiscount();
				frmfd.ShowDialog();
				if (frmfd.DialogResult == DialogResult.OK) //存在，并设置了自由打折
				{
					DiscountRate = System.Convert.ToInt32(frmfd.NumericUpDown1.Value);
				}
				else
				{
					return;
				}
			}
			
			//3、选择签单结帐的支付类型，并且更新 balancetype 表的相同 serialno 的支付类型 paytypecode
			string PayTypecode;
			double BalanceCost = 0;
			double AfterDiscountCost = 0;
			double AfterOddCost = 0;
			
			frmSelPayType frmspt = new frmSelPayType();
			
			BalanceCost = System.Convert.ToDouble(dgSignPay[dgSignPay.CurrentRowIndex, 4]);
			AfterDiscountCost = BalanceCost * DiscountRate / 100;
			
			if (rms_var.FixCost()!="0") //允许自动抹零
			{
				AfterOddCost =Math.Floor(AfterDiscountCost);
			}
			else
			{
				AfterOddCost = AfterDiscountCost;
			}
			
			frmspt.NumericUpDown1.ReadOnly = true;
			frmspt.NumericUpDown1.Value = (decimal) AfterOddCost;
			
			frmspt.ShowDialog();
			if (frmspt.DialogResult == DialogResult.OK)
			{
				PayTypecode = rms_var.GetPayTypeCode(frmspt.ComboBox1.Text);
				if (PayTypecode != "4") //结帐时不能再是签单，必须选择除签单外的结账方式
				{
					UpdateBalanceType(SelectedPaySerialno, rms_var.GetPayTypeCode(frmspt.ComboBox1.Text));
				}
				else
				{
					MessageBox.Show("签单结帐的方式不能再选择签单！");
					return;
				}
			}
			else
			{
				return;
			}
			
			//4、更新customer表 payingcost
			UpdateCustomerCost(dgSignPay[dgSignPay.CurrentRowIndex, 5].ToString(), AfterOddCost.ToString());
			
			//5、向SignPayFor表添加签单结账记录
			AddSignPayFor(SelectedPaySerialno,dgSignPay[dgSignPay.CurrentRowIndex, 5].ToString(), PayTypecode, AfterOddCost.ToString());
			
			//6、更新balance表
			UpdateBalance(SelectedPaySerialno, (BalanceCost - AfterDiscountCost).ToString(), (AfterDiscountCost - AfterOddCost).ToString(), AfterOddCost.ToString());
			
			MessageBox.Show("签单结帐顺利完成！");
		}
	}
	
}
