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
	public class frmApplyDiscountDept : System.Windows.Forms.Form
	{
		
		public string DiscountCode;
		
		#region  Windows 窗体设计器生成的代码
		
		public frmApplyDiscountDept()
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
		internal System.Windows.Forms.CheckedListBox CheckedListBox1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmApplyDiscountDept));
			this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
			base.Load += new System.EventHandler(frmApplyDiscountDept_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//CheckedListBox1
			//
			this.CheckedListBox1.Location = new System.Drawing.Point(16, 40);
			this.CheckedListBox1.Name = "CheckedListBox1";
			this.CheckedListBox1.Size = new System.Drawing.Size(232, 228);
			this.CheckedListBox1.TabIndex = 0;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(72, 288);
			this.Button1.Name = "Button1";
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定(&O)";
			//
			//Button2
			//
			this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Button2.Location = new System.Drawing.Point(152, 288);
			this.Button2.Name = "Button2";
			this.Button2.TabIndex = 2;
			this.Button2.Text = "取消(&C)";
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("宋体", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
			this.Label1.ForeColor = System.Drawing.Color.Navy;
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(248, 32);
			this.Label1.TabIndex = 3;
			//
			//frmApplyDiscountDept
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.Button2;
			this.ClientSize = new System.Drawing.Size(264, 326);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.CheckedListBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmApplyDiscountDept";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "将优惠应用到部门";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		//返回所有菜品制作部门
		private void LoadDiscountDept()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand("select deptname from department where depttype='菜品制作' order by deptname", conn);
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
					CheckedListBox1.Items.Add(dbDS.Tables[0].Rows[i][0]);
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
		
		//检测当前有回所应用的部门，并在相应部门前打勾
		private void RefreshDeptDiscount()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "select deptcode from DiscountArea where discountcode='" + DiscountCode + "'";
				selectCMD.CommandTimeout = 30;
				SqlDataAdapter dbDA = new SqlDataAdapter();
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				DataSet dbDS = new DataSet();
				dbDA.Fill(dbDS, "t");
				
				int tmp;
				
				for (int i = 0; i <= dbDS.Tables[0].Rows.Count - 1; i++)
				{
                    tmp = CheckedListBox1.Items.IndexOf(rms_var.GetDeptName(dbDS.Tables[0].Rows[i][0].ToString()));
					CheckedListBox1.SetItemChecked(tmp, true);
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
		
		//删除应用的部门
		private object DelDeptDis()
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "delete from DiscountArea where discountcode='" + DiscountCode + "'";
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
		
		private void AddDeptToDiscount(string deptname)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			conn.ConnectionString = rms_var.ConnStr;
			try
			{
				SqlCommand selectCMD = new SqlCommand();
				
				selectCMD.Connection = conn;
				selectCMD.CommandText = "insert into DiscountArea (discountcode,deptcode) values " + "(" + "'" + DiscountCode + "'" + "," + "'" + rms_var.GetDeptCode(deptname) + "'" + ")";
				selectCMD.CommandTimeout = 30;
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
		
		private void frmApplyDiscountDept_Load(System.Object sender, System.EventArgs e)
		{
			LoadDiscountDept();
			RefreshDeptDiscount();
		}
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			//先删除所有当前有的部门
			DelDeptDis();
			
			//遍历选中部门，添加之
			string deptname;
			
			for (int i = 0; i <= CheckedListBox1.Items.Count - 1; i++)
			{
				if (CheckedListBox1.GetItemChecked(i)) //选中
				{
					deptname = CheckedListBox1.Items[i].ToString();
					AddDeptToDiscount(deptname);
				}
			}
			
			this.DialogResult = DialogResult.OK;
		}
	}
	
}
