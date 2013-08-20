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


namespace DeskApp
{
	sealed class report_var
	{
		public static ReportDocument cr_payfor;
		public static ReportDocument cr_Balance;
		public static ReportDocument customer_cr;
		
		//结帐单报表文件
		public readonly static string Payfor_rpt_filename = "cr_Payfor.rpt";
		public readonly static string PayforTemp_rpt_filename = "cr_PayforTemp.rpt";
		
		//----------------
		
		//结帐查询报表文件
		public readonly static string BalanceQry_rpt_filename = "cr_Balance.rpt";
		
		//收款/结帐类别查询报表文件
		public readonly static string BalanceTypQry_rpt_filename = "cr_BalanceType.rpt";
		
		//客户报表文件
		public readonly static string customer_rpt_filename = "cr_customer.rpt";
		
		//桌台单据菜品记录报表文件
		public readonly static string SaleBillsFoods_rpt_filename = "cr_salebillsfoods.rpt";
		
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
