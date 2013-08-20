using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;
using System.Data.SqlClient;


namespace DeskApp
{
	public class frmAppoint : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAppoint()
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
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.DataGrid dgAppointBill;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.DataGridTableStyle DataGridTableStyle1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn2;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn3;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn4;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn5;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn6;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn7;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn8;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn9;
		internal System.Windows.Forms.DataGridBoolColumn DataGridBoolColumn1;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn12;
		internal System.Windows.Forms.DataGridTextBoxColumn DataGridTextBoxColumn10;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAppoint));
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			base.Load += new System.EventHandler(frmAppoint_Load);
			base.Closed += new System.EventHandler(frmAppoint_Closed);
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.dgAppointBill = new System.Windows.Forms.DataGrid();
			this.DataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.DataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.DataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgAppointBill).BeginInit();
			this.SuspendLayout();
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(24, 8);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(96, 21);
			this.DateTimePicker1.TabIndex = 0;
			this.DateTimePicker1.Value = new DateTime(2005, 1, 21, 17, 36, 0, 0);
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker2.Location = new System.Drawing.Point(152, 8);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(96, 21);
			this.DateTimePicker2.TabIndex = 1;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Location = new System.Drawing.Point(320, 8);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(80, 20);
			this.ComboBox1.TabIndex = 2;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(264, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(56, 23);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "时间段：";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(408, 8);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(56, 23);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "操作员：";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.Location = new System.Drawing.Point(8, 8);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(16, 23);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "从";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.Location = new System.Drawing.Point(128, 8);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(16, 23);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "到";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//ComboBox2
			//
			this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.Location = new System.Drawing.Point(464, 8);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(88, 20);
			this.ComboBox2.TabIndex = 9;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.RadioButton3);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 40);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(328, 48);
			this.GroupBox1.TabIndex = 10;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "订单状态";
			//
			//RadioButton3
			//
			this.RadioButton3.Location = new System.Drawing.Point(224, 16);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(88, 24);
			this.RadioButton3.TabIndex = 2;
			this.RadioButton3.Text = "完成";
			//
			//RadioButton2
			//
			this.RadioButton2.Location = new System.Drawing.Point(128, 16);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(80, 24);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "预订中";
			//
			//RadioButton1
			//
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(24, 16);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(88, 24);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "全部";
			//
			//dgAppointBill
			//
			this.dgAppointBill.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dgAppointBill.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.dgAppointBill.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgAppointBill.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgAppointBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dgAppointBill.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgAppointBill.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dgAppointBill.CaptionText = "订单列表";
			this.dgAppointBill.DataMember = "";
			this.dgAppointBill.FlatMode = true;
			this.dgAppointBill.Font = new System.Drawing.Font("Tahoma", 8.0F);
			this.dgAppointBill.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgAppointBill.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dgAppointBill.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dgAppointBill.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgAppointBill.HeaderFont = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.dgAppointBill.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgAppointBill.LinkColor = System.Drawing.Color.Teal;
			this.dgAppointBill.Location = new System.Drawing.Point(8, 96);
			this.dgAppointBill.Name = "dgAppointBill";
			this.dgAppointBill.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dgAppointBill.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgAppointBill.ReadOnly = true;
			this.dgAppointBill.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dgAppointBill.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dgAppointBill.Size = new System.Drawing.Size(568, 336);
			this.dgAppointBill.TabIndex = 11;
			this.dgAppointBill.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {this.DataGridTableStyle1});
			//
			//DataGridTableStyle1
			//
			this.DataGridTableStyle1.DataGrid = this.dgAppointBill;
			this.DataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {this.DataGridTextBoxColumn1, this.DataGridTextBoxColumn4, this.DataGridTextBoxColumn5, this.DataGridTextBoxColumn6, this.DataGridTextBoxColumn2, this.DataGridTextBoxColumn3, this.DataGridTextBoxColumn8, this.DataGridTextBoxColumn7, this.DataGridTextBoxColumn9, this.DataGridBoolColumn1, this.DataGridTextBoxColumn10, this.DataGridTextBoxColumn12});
			this.DataGridTableStyle1.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGridTableStyle1.MappingName = "AppointBill";
			//
			//DataGridTextBoxColumn1
			//
			this.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn1.Format = "";
			this.DataGridTextBoxColumn1.FormatInfo = null;
			this.DataGridTextBoxColumn1.HeaderText = "订单编号";
			this.DataGridTextBoxColumn1.MappingName = "appointno";
			this.DataGridTextBoxColumn1.Width = 65;
			//
			//DataGridTextBoxColumn4
			//
			this.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn4.Format = "";
			this.DataGridTextBoxColumn4.FormatInfo = null;
			this.DataGridTextBoxColumn4.HeaderText = "客户名称";
			this.DataGridTextBoxColumn4.MappingName = "customername";
			this.DataGridTextBoxColumn4.Width = 60;
			//
			//DataGridTextBoxColumn5
			//
			this.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn5.Format = "";
			this.DataGridTextBoxColumn5.FormatInfo = null;
			this.DataGridTextBoxColumn5.HeaderText = "预订人";
			this.DataGridTextBoxColumn5.MappingName = "orderman";
			this.DataGridTextBoxColumn5.Width = 75;
			//
			//DataGridTextBoxColumn6
			//
			this.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn6.Format = "";
			this.DataGridTextBoxColumn6.FormatInfo = null;
			this.DataGridTextBoxColumn6.HeaderText = "联系电话";
			this.DataGridTextBoxColumn6.MappingName = "ordermantel";
			this.DataGridTextBoxColumn6.Width = 75;
			//
			//DataGridTextBoxColumn2
			//
			this.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn2.Format = "";
			this.DataGridTextBoxColumn2.FormatInfo = null;
			this.DataGridTextBoxColumn2.HeaderText = "创建日期";
			this.DataGridTextBoxColumn2.MappingName = "orderdate";
			this.DataGridTextBoxColumn2.Width = 70;
			//
			//DataGridTextBoxColumn3
			//
			this.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn3.Format = "";
			this.DataGridTextBoxColumn3.FormatInfo = null;
			this.DataGridTextBoxColumn3.HeaderText = "预订日期";
			this.DataGridTextBoxColumn3.MappingName = "arrivedate";
			this.DataGridTextBoxColumn3.Width = 70;
			//
			//DataGridTextBoxColumn8
			//
			this.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn8.Format = "";
			this.DataGridTextBoxColumn8.FormatInfo = null;
			this.DataGridTextBoxColumn8.HeaderText = "时间段";
			this.DataGridTextBoxColumn8.MappingName = "timeblock";
			this.DataGridTextBoxColumn8.Width = 60;
			//
			//DataGridTextBoxColumn7
			//
			this.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn7.Format = "";
			this.DataGridTextBoxColumn7.FormatInfo = null;
			this.DataGridTextBoxColumn7.HeaderText = "估计人数";
			this.DataGridTextBoxColumn7.MappingName = "est_quantity";
			this.DataGridTextBoxColumn7.Width = 75;
			//
			//DataGridTextBoxColumn9
			//
			this.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn9.Format = "";
			this.DataGridTextBoxColumn9.FormatInfo = null;
			this.DataGridTextBoxColumn9.HeaderText = "定金";
			this.DataGridTextBoxColumn9.MappingName = "ordermoney";
			this.DataGridTextBoxColumn9.Width = 55;
			//
			//DataGridBoolColumn1
			//
			this.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridBoolColumn1.FalseValue = "0";
			this.DataGridBoolColumn1.HeaderText = "完成预订";
			this.DataGridBoolColumn1.MappingName = "status";
			this.DataGridBoolColumn1.NullValue = resources.GetObject("DataGridBoolColumn1.NullValue");
			this.DataGridBoolColumn1.TrueValue = "1";
			this.DataGridBoolColumn1.Width = 55;
			//
			//DataGridTextBoxColumn10
			//
			this.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn10.Format = "";
			this.DataGridTextBoxColumn10.FormatInfo = null;
			this.DataGridTextBoxColumn10.HeaderText = "操作员";
			this.DataGridTextBoxColumn10.MappingName = "operator";
			this.DataGridTextBoxColumn10.Width = 60;
			//
			//DataGridTextBoxColumn12
			//
			this.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.DataGridTextBoxColumn12.Format = "";
			this.DataGridTextBoxColumn12.FormatInfo = null;
			this.DataGridTextBoxColumn12.HeaderText = "备注";
			this.DataGridTextBoxColumn12.MappingName = "note";
			this.DataGridTextBoxColumn12.NullText = "";
			this.DataGridTextBoxColumn12.Width = 140;
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(584, 104);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 12;
			this.Button1.Text = "修改(&E)";
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.Location = new System.Drawing.Point(584, 136);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 13;
			this.Button2.Text = "完成(&C)";
			//
			//Button3
			//
			this.Button3.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Button3.Location = new System.Drawing.Point(584, 168);
			this.Button3.Name = "Button3";
			this.Button3.TabIndex = 14;
			this.Button3.Text = "删除(&D)";
			//
			//Button4
			//
			this.Button4.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button4.Location = new System.Drawing.Point(584, 408);
			this.Button4.Name = "Button4";
			this.Button4.TabIndex = 15;
			this.Button4.Text = "关闭(&X)";
			//
			//Button5
			//
			this.Button5.Image = (System.Drawing.Image) (resources.GetObject("Button5.Image"));
			this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button5.Location = new System.Drawing.Point(344, 44);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(88, 48);
			this.Button5.TabIndex = 16;
			this.Button5.Text = "查询(&Q)";
			this.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmAppoint
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(664, 438);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgAppointBill);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.ComboBox2);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.DateTimePicker2);
			this.Controls.Add(this.DateTimePicker1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmAppoint";
			this.Text = "预订管理";
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgAppointBill).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void LoadAppointBill(string begindate, string enddate, string timeblock, string @operator)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select * from view_AppointBill where arrivedate <='" + enddate + "'" + " and " + "arrivedate>='" + begindate + "'";
				if (ComboBox1.Text != "全部")
				{
					selectCMD.CommandText = selectCMD.CommandText + " and timeblockcode='" + rms_var.GetTimeBlockCode(timeblock) + "'";
				}
				if (ComboBox2.Text != "全部")
				{
					selectCMD.CommandText = selectCMD.CommandText + " and operator='" + @operator + "'";
				}
				if (RadioButton2.Checked)
				{
					selectCMD.CommandText = selectCMD.CommandText + " and status=0";
				}
				if (RadioButton3.Checked)
				{
					selectCMD.CommandText = selectCMD.CommandText + " and status=1";
				}
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "AppointBill");
				dgAppointBill.DataSource = null;
				dgAppointBill.DataSource = dbDS;
				dgAppointBill.DataMember = "AppointBill";
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
		
		private void frmAppoint_Load(System.Object sender, System.EventArgs e)
		{
			//返回时间段列表
			DataTable tblTimeBlock = new DataTable();
			tblTimeBlock = rms_var.LoadTimeBlock();
			ComboBox1.Items.Clear();
			for (int i = 0; i <= tblTimeBlock.Rows.Count - 1; i++)
			{
				ComboBox1.Items.Add(tblTimeBlock.Rows[i][0]);
			}
			ComboBox1.Items.Insert(0, "全部");
			ComboBox1.SelectedIndex = 0;
			
			//返回操作员列表
			DataTable tblOperator = new DataTable();
			tblOperator = rms_var.LoadOperator();
			ComboBox2.Items.Clear();
			for (int i = 0; i <= tblOperator.Rows.Count - 1; i++)
			{
				ComboBox2.Items.Add(tblOperator.Rows[i][0]);
			}
			ComboBox2.Items.Insert(0, "全部");
			ComboBox2.SelectedIndex = 0;
			
			DateTimePicker1.Value = DateTime.Now;
			DateTimePicker2.Value = DateTime.Now;
			
			LoadAppointBill(DateTimePicker1.Value.ToShortDateString(), DateTimePicker2.Value.ToShortDateString(), ComboBox1.Text, ComboBox2.Text);
		}
		
		private void frmAppoint_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmAppnt = null;
		}
		
		private void Button4_Click(System.Object sender, System.EventArgs e)
		{
			Close();
		}
		
		private void Button5_Click(System.Object sender, System.EventArgs e)
		{
			LoadAppointBill(DateTimePicker1.Value.ToShortDateString(), DateTimePicker2.Value.ToShortDateString(), ComboBox1.Text, ComboBox2.Text);
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			frmNewAppointBill frmnab = new frmNewAppointBill();
			frmnab.TextBox1.Enabled = false;
			frmnab.ComboBox2.Enabled = false;
			frmnab.TextBox1.Text = dgAppointBill[dgAppointBill.CurrentRowIndex, 0].ToString(); //订单编号
			frmnab.EditOpID = dgAppointBill[dgAppointBill.CurrentRowIndex, 10].ToString(); //操作员
			frmnab.TextBox3.Text = dgAppointBill[dgAppointBill.CurrentRowIndex, 1].ToString(); //客户名称
			frmnab.TextBox4.Text = dgAppointBill[dgAppointBill.CurrentRowIndex, 2].ToString(); //预订人
			frmnab.TextBox5.Text = dgAppointBill[dgAppointBill.CurrentRowIndex, 3].ToString(); //联系电话
			frmnab.DateTimePicker2.Text = dgAppointBill[dgAppointBill.CurrentRowIndex, 5].ToString(); //预订日期
			frmnab.EditTimeBlock = dgAppointBill[dgAppointBill.CurrentRowIndex, 6].ToString(); //时间段
			frmnab.NumericUpDown2.Text =dgAppointBill[dgAppointBill.CurrentRowIndex, 7].ToString(); //估计人数
			frmnab.NumericUpDown1.Text =dgAppointBill[dgAppointBill.CurrentRowIndex, 8].ToString(); //定金
			frmnab.TextBox6.Text = dgAppointBill[dgAppointBill.CurrentRowIndex, 11].ToString(); //备注
			//0=预订中 1=完成
			if (dgAppointBill[dgAppointBill.CurrentRowIndex, 9].ToString() == "1") //完成预定
			{
				frmnab.Label13.Text = "完成";
			}
			else//预定中
			{
				frmnab.Label13.ForeColor = Color.Red;
				frmnab.Label13.Text = "预订中";
			}
			
			
			frmnab.CreateSelectedTables();
			frmnab.CreateSelectedFoods();
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				//获取预订的桌台
				SqlCommand selectCMD = new SqlCommand();
				selectCMD.Connection = conn;
				selectCMD.CommandTimeout = 30;
				selectCMD.CommandText = "select name,tableno,tablename,peoplenumber from view_AppointTable where appointno='" + dgAppointBill[dgAppointBill.CurrentRowIndex, 0].ToString() + "'";
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t1");
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					frmnab.AddTable(dbDS.Tables[0].Rows[i][0].ToString(),dbDS.Tables[0].Rows[i][1].ToString(),dbDS.Tables[0].Rows[i][2].ToString(),dbDS.Tables[0].Rows[i][3].ToString());
				}
				
				//获取预订的菜品
				selectCMD.CommandText = "select foodcode,foodname,unit,quantity,price,oprandi,taste from view_AppointFood where appointno='" + dgAppointBill[dgAppointBill.CurrentRowIndex, 0].ToString() + "'";
				dbDA.Fill(dbDS, "t2");
				for (int i = 0; i <= dbDS.Tables[1].Rows.Count - 1; i++)
				{
					frmnab.AddFood(dbDS.Tables[1].Rows[i][0].ToString(),dbDS.Tables[1].Rows[i][1].ToString(),dbDS.Tables[1].Rows[i][2].ToString(),dbDS.Tables[1].Rows[i][3].ToString(),dbDS.Tables[1].Rows[i][4].ToString(), dbDS.Tables[1].Rows[i][5].ToString(),dbDS.Tables[1].Rows[i][6].ToString());
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
			
			frmnab.ShowDialog();
			if (frmnab.DialogResult == DialogResult.OK)
			{
				LoadAppointBill(DateTimePicker1.Value.ToShortDateString(), DateTimePicker2.Value.ToShortDateString(), ComboBox1.Text, ComboBox2.Text);
			}
		}
		
		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("确定要删除选中的预定订单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
				conn.ConnectionString = rms_var.ConnStr;
				try
				{
					SqlCommand selectCMD = new SqlCommand();
					selectCMD.Connection = conn;
					conn.Open();
					selectCMD.CommandText = "delete from appointbill where appointno='" + dgAppointBill[dgAppointBill.CurrentRowIndex, 0].ToString() + "'";
					selectCMD.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					conn.Close();
					LoadAppointBill(DateTimePicker1.Value.ToShortDateString(), DateTimePicker2.Value.ToShortDateString(), ComboBox1.Text, ComboBox2.Text);
				}
			}
		}
		
		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			if (dgAppointBill[dgAppointBill.CurrentRowIndex, 9].ToString()=="1")
			{
				MessageBox.Show("预订已经完成，你不能再进行开台操作！");
				return;
			}
			
			if (rms_var.CompleteAppoint(dgAppointBill[dgAppointBill.CurrentRowIndex, 0].ToString()))
			{
				LoadAppointBill(DateTimePicker1.Value.ToShortDateString(), DateTimePicker2.Value.ToShortDateString(), ComboBox1.Text, ComboBox2.Text);
			}
		}
	}
	
}
