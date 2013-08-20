using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.IO;


namespace SysAdmin
{
	sealed class report_var
	{
		public static ReportDocument customer_cr;
		public static ReportDocument dept_cr;
		public static ReportDocument employee_cr;
		public static ReportDocument food_cr;
		public static ReportDocument table_cr;
		public static ReportDocument card_cr;
		
		//客户报表文件
		public readonly static string customer_rpt_filename = "cr_customer.rpt";
		
		//部门报表文件
		public readonly static string dept_rpt_filename = "cr_dept.rpt";
		
		//雇员报表文件
		public readonly static string employee_rpt_filename = "cr_employee.rpt";
		
		//菜品报表文件
		public readonly static string food_rpt_filename = "cr_food.rpt";
		
		//桌台报表文件
		public readonly static string table_rpt_filename = "cr_table.rpt";
		
		//会员卡报表文件
		public readonly static string card_rpt_filename = "cr_card.rpt";
		
		//结帐查询
		public static ReportDocument LoadReport(string rptfilename, string sql, string tablename)
		{
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
			SqlDataAdapter dbDA = new SqlDataAdapter();
			DataSet dataSet = new DataSet();
			conn.ConnectionString = rms_var.ConnStr;
			
			try
			{
				SqlCommand selectCMD = new SqlCommand(sql, conn);
				selectCMD.CommandTimeout = 30;
				dbDA.SelectCommand = selectCMD;
				conn.Open();
				dbDA.Fill(dataSet, tablename);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			
			ReportDocument cr_doc;
			cr_doc = new ReportDocument();
			cr_doc.Load(rptfilename);
			
			cr_doc.SetDataSource(dataSet);
			
			return cr_doc;
			
		}
		
		//返回报表路径
		public static string GetReportPath()
		{
			//获取报表路径信息
			string ReportPath;
			
			ReportPath = rms_var.ReadStrfromReg("ReportPath", Directory.GetCurrentDirectory());
			if (ReportPath[ReportPath.Length - 1] !='\\')
			{
				ReportPath += "\\";
			}
			
			return ReportPath;
		}
		
	}
	
}
