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


namespace DecisionApp
{
	sealed class report_var
	{
		public static ReportDocument cr_payfor;
		public static ReportDocument cr_Balance;
		
		//* 报表文件 *
		
		//营业报表
		public readonly static string Yybb_rpt_filename = "cr_yybb.rpt";
		
		//结帐查询报表文件
		public readonly static string BalanceQry_rpt_filename = "cr_Balance.rpt";
		
		//收款/结帐类别查询报表文件
		public readonly static string BalanceTypQry_rpt_filename = "cr_BalanceType.rpt";
		
		//菜品销售报表
		public readonly static string foodsale_rpt_filename = "cr_FoodSale.rpt";
		
		//桌台使用率
		public readonly static string tableusefreq_rpt_filename = "cr_TableUseFreq.rpt";
		
		//厅堂使用收入汇总
		public readonly static string tabletype_rpt_filename = "cr_TableType.rpt";
		
		//部门销售统计汇总
		public readonly static string dept_sale_rpt_filename = "cr_deptsale.rpt";
		
		//部门消耗统计汇总
		public readonly static string dept_cost_rpt_filename = "cr_deptcost.rpt";
		
		//部门毛利润汇总
		public readonly static string dept_stat_rpt_filename = "cr_deptstat.rpt";
		
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
		
	}
	
}
