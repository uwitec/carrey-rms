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
	public class frmEditAccess : System.Windows.Forms.Form
	{
		
		public string OpID;
		
		
		#region  Windows 窗体设计器生成的代码
		
		public frmEditAccess()
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
		internal System.Windows.Forms.CheckBox chk_sys;
		internal System.Windows.Forms.CheckBox chk_hc;
		internal System.Windows.Forms.CheckBox chk_hztj;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.CheckBox chk_xtsz;
		internal System.Windows.Forms.CheckBox chk_khgl;
		internal System.Windows.Forms.CheckBox chk_rygl;
		internal System.Windows.Forms.CheckBox chk_clgl;
		internal System.Windows.Forms.CheckBox chk_qtgl;
		internal System.Windows.Forms.CheckBox chk_sjgl;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.CheckBox chk_audit;
		internal System.Windows.Forms.CheckBox chk_jz;
		internal System.Windows.Forms.CheckBox chk_tc;
		internal System.Windows.Forms.CheckBox chk_qd;
		internal System.Windows.Forms.CheckBox chk_dz;
		internal System.Windows.Forms.CheckBox chk_df;
		internal System.Windows.Forms.CheckBox chk_qt;
		internal System.Windows.Forms.CheckBox chk_kc_wl;
		internal System.Windows.Forms.CheckBox chk_kc_yl;
		internal System.Windows.Forms.CheckBox chk_fw;
		internal System.Windows.Forms.CheckBox chk_rmssvc;
		internal System.Windows.Forms.CheckBox chk_cmp;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEditAccess));
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			base.Load += new System.EventHandler(frmEditAccess_Load);
			this.Button2 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.chk_rmssvc = new System.Windows.Forms.CheckBox();
			this.chk_kc_yl = new System.Windows.Forms.CheckBox();
			this.chk_hztj = new System.Windows.Forms.CheckBox();
			this.chk_hc = new System.Windows.Forms.CheckBox();
			this.chk_kc_wl = new System.Windows.Forms.CheckBox();
			this.chk_qt = new System.Windows.Forms.CheckBox();
			this.chk_sys = new System.Windows.Forms.CheckBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.chk_sjgl = new System.Windows.Forms.CheckBox();
			this.chk_qtgl = new System.Windows.Forms.CheckBox();
			this.chk_clgl = new System.Windows.Forms.CheckBox();
			this.chk_rygl = new System.Windows.Forms.CheckBox();
			this.chk_khgl = new System.Windows.Forms.CheckBox();
			this.chk_xtsz = new System.Windows.Forms.CheckBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.chk_fw = new System.Windows.Forms.CheckBox();
			this.chk_df = new System.Windows.Forms.CheckBox();
			this.chk_dz = new System.Windows.Forms.CheckBox();
			this.chk_qd = new System.Windows.Forms.CheckBox();
			this.chk_tc = new System.Windows.Forms.CheckBox();
			this.chk_jz = new System.Windows.Forms.CheckBox();
			this.chk_audit = new System.Windows.Forms.CheckBox();
			this.chk_cmp = new System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(216, 400);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(296, 400);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 4;
			this.Button2.Text = "取消(&C)";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.chk_cmp);
			this.GroupBox1.Controls.Add(this.chk_rmssvc);
			this.GroupBox1.Controls.Add(this.chk_kc_yl);
			this.GroupBox1.Controls.Add(this.chk_hztj);
			this.GroupBox1.Controls.Add(this.chk_hc);
			this.GroupBox1.Controls.Add(this.chk_kc_wl);
			this.GroupBox1.Controls.Add(this.chk_qt);
			this.GroupBox1.Controls.Add(this.chk_sys);
			this.GroupBox1.Location = new System.Drawing.Point(16, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(384, 128);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "登录权限";
			//
			//chk_rmssvc
			//
			this.chk_rmssvc.Location = new System.Drawing.Point(24, 96);
			this.chk_rmssvc.Name = "chk_rmssvc";
			this.chk_rmssvc.Size = new System.Drawing.Size(160, 24);
			this.chk_rmssvc.TabIndex = 7;
			this.chk_rmssvc.Text = "允许启动服务程序";
			//
			//chk_kc_yl
			//
			this.chk_kc_yl.Location = new System.Drawing.Point(192, 48);
			this.chk_kc_yl.Name = "chk_kc_yl";
			this.chk_kc_yl.Size = new System.Drawing.Size(176, 24);
			this.chk_kc_yl.TabIndex = 6;
			this.chk_kc_yl.Text = "允许登录库存管理（原料）";
			//
			//chk_hztj
			//
			this.chk_hztj.Location = new System.Drawing.Point(192, 72);
			this.chk_hztj.Name = "chk_hztj";
			this.chk_hztj.Size = new System.Drawing.Size(184, 24);
			this.chk_hztj.TabIndex = 5;
			this.chk_hztj.Text = "允许登录汇总统计/决策支持";
			//
			//chk_hc
			//
			this.chk_hc.Location = new System.Drawing.Point(24, 72);
			this.chk_hc.Name = "chk_hc";
			this.chk_hc.Size = new System.Drawing.Size(144, 24);
			this.chk_hc.TabIndex = 4;
			this.chk_hc.Text = "允许登录后厨管理";
			//
			//chk_kc_wl
			//
			this.chk_kc_wl.Location = new System.Drawing.Point(192, 24);
			this.chk_kc_wl.Name = "chk_kc_wl";
			this.chk_kc_wl.Size = new System.Drawing.Size(176, 24);
			this.chk_kc_wl.TabIndex = 1;
			this.chk_kc_wl.Text = "允许登录库存管理（物料）";
			//
			//chk_qt
			//
			this.chk_qt.Location = new System.Drawing.Point(24, 48);
			this.chk_qt.Name = "chk_qt";
			this.chk_qt.Size = new System.Drawing.Size(144, 24);
			this.chk_qt.TabIndex = 2;
			this.chk_qt.Text = "允许登录前台管理";
			//
			//chk_sys
			//
			this.chk_sys.Location = new System.Drawing.Point(24, 24);
			this.chk_sys.Name = "chk_sys";
			this.chk_sys.Size = new System.Drawing.Size(144, 24);
			this.chk_sys.TabIndex = 0;
			this.chk_sys.Text = "允许登录系统管理";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.chk_sjgl);
			this.GroupBox2.Controls.Add(this.chk_qtgl);
			this.GroupBox2.Controls.Add(this.chk_clgl);
			this.GroupBox2.Controls.Add(this.chk_rygl);
			this.GroupBox2.Controls.Add(this.chk_khgl);
			this.GroupBox2.Controls.Add(this.chk_xtsz);
			this.GroupBox2.Location = new System.Drawing.Point(16, 152);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(384, 104);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "系统管理权限";
			//
			//chk_sjgl
			//
			this.chk_sjgl.Location = new System.Drawing.Point(192, 72);
			this.chk_sjgl.Name = "chk_sjgl";
			this.chk_sjgl.Size = new System.Drawing.Size(168, 24);
			this.chk_sjgl.TabIndex = 5;
			this.chk_sjgl.Text = "允许数据管理";
			//
			//chk_qtgl
			//
			this.chk_qtgl.Location = new System.Drawing.Point(192, 48);
			this.chk_qtgl.Name = "chk_qtgl";
			this.chk_qtgl.Size = new System.Drawing.Size(168, 24);
			this.chk_qtgl.TabIndex = 3;
			this.chk_qtgl.Text = "允许管理前台信息";
			//
			//chk_clgl
			//
			this.chk_clgl.Location = new System.Drawing.Point(192, 24);
			this.chk_clgl.Name = "chk_clgl";
			this.chk_clgl.Size = new System.Drawing.Size(168, 24);
			this.chk_clgl.TabIndex = 1;
			this.chk_clgl.Text = "允许菜例管理";
			//
			//chk_rygl
			//
			this.chk_rygl.Location = new System.Drawing.Point(24, 72);
			this.chk_rygl.Name = "chk_rygl";
			this.chk_rygl.Size = new System.Drawing.Size(144, 24);
			this.chk_rygl.TabIndex = 4;
			this.chk_rygl.Text = "允许人员管理";
			//
			//chk_khgl
			//
			this.chk_khgl.Location = new System.Drawing.Point(24, 48);
			this.chk_khgl.Name = "chk_khgl";
			this.chk_khgl.Size = new System.Drawing.Size(144, 24);
			this.chk_khgl.TabIndex = 2;
			this.chk_khgl.Text = "允许客户管理";
			//
			//chk_xtsz
			//
			this.chk_xtsz.Location = new System.Drawing.Point(24, 24);
			this.chk_xtsz.Name = "chk_xtsz";
			this.chk_xtsz.Size = new System.Drawing.Size(144, 24);
			this.chk_xtsz.TabIndex = 0;
			this.chk_xtsz.Text = "允许系统设置";
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.chk_fw);
			this.GroupBox3.Controls.Add(this.chk_df);
			this.GroupBox3.Controls.Add(this.chk_dz);
			this.GroupBox3.Controls.Add(this.chk_qd);
			this.GroupBox3.Controls.Add(this.chk_tc);
			this.GroupBox3.Controls.Add(this.chk_jz);
			this.GroupBox3.Controls.Add(this.chk_audit);
			this.GroupBox3.Location = new System.Drawing.Point(16, 264);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(384, 128);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "操作权限";
			//
			//chk_fw
			//
			this.chk_fw.Location = new System.Drawing.Point(24, 96);
			this.chk_fw.Name = "chk_fw";
			this.chk_fw.TabIndex = 6;
			this.chk_fw.Text = "返位权";
			//
			//chk_df
			//
			this.chk_df.Location = new System.Drawing.Point(192, 72);
			this.chk_df.Name = "chk_df";
			this.chk_df.Size = new System.Drawing.Size(176, 24);
			this.chk_df.TabIndex = 5;
			this.chk_df.Text = "未结帐允许删除单据和菜品";
			//
			//chk_dz
			//
			this.chk_dz.Location = new System.Drawing.Point(192, 48);
			this.chk_dz.Name = "chk_dz";
			this.chk_dz.Size = new System.Drawing.Size(176, 24);
			this.chk_dz.TabIndex = 3;
			this.chk_dz.Text = "自由打折权";
			//
			//chk_qd
			//
			this.chk_qd.Location = new System.Drawing.Point(192, 24);
			this.chk_qd.Name = "chk_qd";
			this.chk_qd.Size = new System.Drawing.Size(176, 24);
			this.chk_qd.TabIndex = 1;
			this.chk_qd.Text = "允许客户签单结账";
			//
			//chk_tc
			//
			this.chk_tc.Location = new System.Drawing.Point(24, 72);
			this.chk_tc.Name = "chk_tc";
			this.chk_tc.Size = new System.Drawing.Size(144, 24);
			this.chk_tc.TabIndex = 4;
			this.chk_tc.Text = "允许退菜";
			//
			//chk_jz
			//
			this.chk_jz.Location = new System.Drawing.Point(24, 48);
			this.chk_jz.Name = "chk_jz";
			this.chk_jz.Size = new System.Drawing.Size(144, 24);
			this.chk_jz.TabIndex = 2;
			this.chk_jz.Text = "结账权";
			//
			//chk_audit
			//
			this.chk_audit.Location = new System.Drawing.Point(24, 24);
			this.chk_audit.Name = "chk_audit";
			this.chk_audit.Size = new System.Drawing.Size(144, 24);
			this.chk_audit.TabIndex = 0;
			this.chk_audit.Text = "单据审核权";
			//
			//chk_cmp
			//
			this.chk_cmp.Location = new System.Drawing.Point(192, 96);
			this.chk_cmp.Name = "chk_cmp";
			this.chk_cmp.Size = new System.Drawing.Size(176, 24);
			this.chk_cmp.TabIndex = 8;
			this.chk_cmp.Text = "允许登录触摸屏客户端";
			//
			//frmEditAccess
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(416, 440);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEditAccess";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "编辑操作员权限";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//更新登录权限
		private void Update_Log_sys_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='sys'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'sys')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='sys'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_kc_wl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='kc_wl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'kc_wl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='kc_wl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_kc_yl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='kc_yl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'kc_yl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='kc_yl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_qt_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qt'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'qt')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='qt'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_zk_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='zk'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'zk')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='zk'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_hc_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='hc'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'hc')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='hc'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_hztj_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='hztj'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'hztj')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='hztj'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_rmssvc_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='rmssvc'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'rmssvc')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='rmssvc'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Log_cmp_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='cmp'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'cmp')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='cmp'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		//更新数据管理权限
		private void Update_Sys_xtsz_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='xtsz'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'xtsz')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='xtsz'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Sys_khgl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='khgl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'khgl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='khgl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Sys_rygl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='rygl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'rygl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='rygl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Sys_clgl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='clgl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'clgl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='clgl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Sys_qtgl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qtgl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'qtgl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='qtgl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Sys_sjgl_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='sjgl'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'sjgl')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='sjgl'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		//更新操作权限
		private void Update_Op_audit_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='audit'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'audit')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='audit'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Op_jz_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='jz'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'jz')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='jz'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Op_tc_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='tc'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'tc')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='tc'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Op_qd_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qd'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'qd')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='qd'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Op_dz_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='dz'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'dz')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='dz'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Op_df_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='df'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'df')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='df'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		private void Update_Op_fw_Access(string opid, bool allow)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				
				SqlCommand selectcmd;
				selectcmd = new SqlCommand();
				selectcmd.Connection = conn;
				selectcmd.CommandTimeout = 30;
				
				if (allow)
				{
					//检测有无该权限记录
					selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='fw'";
					SqlDataAdapter dbDA;
					dbDA = new SqlDataAdapter();
					dbDA.SelectCommand = selectcmd;
					conn.Open();
					DataSet dbDS;
					dbDS = new DataSet();
					dbDA.Fill(dbDS, "t");
					if (! (dbDS.Tables[0].Rows.Count > 0))
					{
						selectcmd.CommandText = "insert into op_acs (operatorid,access) values " + "('" + opid + "'" + "," + "'fw')";
						selectcmd.ExecuteNonQuery();
					}
				}
				else
				{
					selectcmd.CommandText = "delete from op_acs where operatorid='" + opid + "'" + " and " + " access='fw'";
					conn.Open();
					selectcmd.ExecuteNonQuery();
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
		
		///''
		
		private void UpdateLogAccess(bool sys, bool kcwl, bool kcyl, bool qt, bool hc, bool hztj, bool rmssvc, bool cmp)
			{
			Update_Log_sys_Access(OpID, sys);
			Update_Log_kc_wl_Access(OpID, kcwl);
			Update_Log_kc_yl_Access(OpID, kcyl);
			Update_Log_qt_Access(OpID, qt);
			Update_Log_hc_Access(OpID, hc);
			Update_Log_hztj_Access(OpID, hztj);
			Update_Log_rmssvc_Access(OpID, rmssvc);
			Update_Log_cmp_Access(OpID, cmp);
		}
		
		private void UpdateSysAccess(bool xtsz, bool khgl, bool rygl, bool clgl, bool qtgl, bool sjgl)
			{
			Update_Sys_xtsz_Access(OpID, xtsz);
			Update_Sys_khgl_Access(OpID, khgl);
			Update_Sys_rygl_Access(OpID, rygl);
			Update_Sys_clgl_Access(OpID, clgl);
			Update_Sys_qtgl_Access(OpID, qtgl);
			Update_Sys_sjgl_Access(OpID, sjgl);
		}
		
		private void UpdateOpAccess(bool audit, bool jz, bool tc, bool qd, bool dz, bool df, bool fw)
			{
			Update_Op_audit_Access(OpID, audit);
			Update_Op_jz_Access(OpID, jz);
			Update_Op_tc_Access(OpID, tc);
			Update_Op_qd_Access(OpID, qd);
			Update_Op_dz_Access(OpID, dz);
			Update_Op_df_Access(OpID, df);
			Update_Op_fw_Access(OpID, fw);
		}
		
		
		//返回登录权限设置
		private void GetLogAccessInfo(object opid)
		{
			
			//sys 是否允许登录系统设置
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			SqlCommand selectcmd;
			selectcmd = new SqlCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='sys'";
			SqlDataAdapter dbDA;
			dbDA = new SqlDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_sys.Checked = true;
			}
			else
			{
				chk_sys.Checked = false;
			}
			
			//kc 是否允许登录库存管理 物料
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='kc_wl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_kc_wl.Checked = true;
			}
			else
			{
				chk_kc_wl.Checked = false;
			}
			
			//kc 是否允许登录库存管理 原料
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='kc_yl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_kc_yl.Checked = true;
			}
			else
			{
				chk_kc_yl.Checked = false;
			}
			
			//qt 是否允许登录前台管理
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qt'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_qt.Checked = true;
			}
			else
			{
				chk_qt.Checked = false;
			}
			
			//hc 是否允许登录后厨上菜
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='hc'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_hc.Checked = true;
			}
			else
			{
				chk_hc.Checked = false;
			}
			
			//hztj 是否允许登录汇总统计
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='hztj'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_hztj.Checked = true;
			}
			else
			{
				chk_hztj.Checked = false;
			}
			
			//rmssvc 是否允许启动RMS服务程序
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='rmssvc'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_rmssvc.Checked = true;
			}
			else
			{
				chk_rmssvc.Checked = false;
			}
			
			//cmp 是否允许登录触摸屏客户端
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='cmp'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_cmp.Checked = true;
			}
			else
			{
				chk_cmp.Checked = false;
			}
		}
		
		//返回系统设置权限
		private void GetSysAccessInfo(object opid)
		{
			//xtsz
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			SqlCommand selectcmd;
			selectcmd = new SqlCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='xtsz'";
			SqlDataAdapter dbDA;
			dbDA = new SqlDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_xtsz.Checked = true;
			}
			else
			{
				chk_xtsz.Checked = false;
			}
			
			//khgl
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='khgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_khgl.Checked = true;
			}
			else
			{
				chk_khgl.Checked = false;
			}
			
			//rygl
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='rygl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_rygl.Checked = true;
			}
			else
			{
				chk_rygl.Checked = false;
			}
			
			//clgl
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='clgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_clgl.Checked = true;
			}
			else
			{
				chk_clgl.Checked = false;
			}
			
			//qtgl
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qtgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_qtgl.Checked = true;
			}
			else
			{
				chk_qtgl.Checked = false;
			}
			
			//sjgl
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='sjgl'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_sjgl.Checked = true;
			}
			else
			{
				chk_sjgl.Checked = false;
			}
		}
		
		//返回操作权限
		private void GetOPAccessInfo(object opid)
		{
			//audit 审核权
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			SqlCommand selectcmd;
			selectcmd = new SqlCommand();
			selectcmd.Connection = conn;
			selectcmd.CommandTimeout = 30;
			
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='audit'";
			SqlDataAdapter dbDA;
			dbDA = new SqlDataAdapter();
			dbDA.SelectCommand = selectcmd;
			conn.Open();
			DataSet dbDS;
			dbDS = new DataSet();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_audit.Checked = true;
			}
			else
			{
				chk_audit.Checked = false;
			}
			
			//jz 结帐权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='jz'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_jz.Checked = true;
			}
			else
			{
				chk_jz.Checked = false;
			}
			
			//tc 退菜权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='tc'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_tc.Checked = true;
			}
			else
			{
				chk_tc.Checked = false;
			}
			
			//qd 签单结帐权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='qd'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_qd.Checked = true;
			}
			else
			{
				chk_qd.Checked = false;
			}
			
			//dz 自有打折权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='dz'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_dz.Checked = true;
			}
			else
			{
				chk_dz.Checked = false;
			}
			
			//df 删单据删菜品权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='df'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_df.Checked = true;
			}
			else
			{
				chk_df.Checked = false;
			}
			
			//fw 返位权
			selectcmd.CommandText = "select * from op_acs where operatorid='" + opid + "'" + " and " + "access='fw'";
			dbDS.Clear();
			dbDA.Fill(dbDS, "t");
			if (dbDS.Tables[0].Rows.Count > 0) //存在该权限
			{
				chk_fw.Checked = true;
			}
			else
			{
				chk_fw.Checked = false;
			}
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (MessageBox.Show("确定要更新当前的权限设置吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				//更新权限设置
				UpdateLogAccess(chk_sys.Checked, chk_kc_wl.Checked, chk_kc_yl.Checked, chk_qt.Checked, chk_hc.Checked, chk_hztj.Checked, chk_rmssvc.Checked, chk_cmp.Checked);
				
				UpdateSysAccess(chk_xtsz.Checked, chk_khgl.Checked, chk_rygl.Checked, chk_clgl.Checked, chk_qtgl.Checked, chk_sjgl.Checked);
				
				UpdateOpAccess(chk_audit.Checked, chk_jz.Checked, chk_tc.Checked, chk_qd.Checked, chk_dz.Checked, chk_df.Checked, chk_fw.Checked);
			}
			this.DialogResult = DialogResult.OK;
		}
		
		private void frmEditAccess_Load(System.Object sender, System.EventArgs e)
		{
			GetLogAccessInfo(OpID);
			GetSysAccessInfo(OpID);
			GetOPAccessInfo(OpID);
		}
	}
	
}
