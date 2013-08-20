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


namespace StorageApp
{
	sealed class report_var
	{
		public static ReportDocument materials_cr;
		public static ReportDocument inbill_cr;
		public static ReportDocument outbill_cr;
		
		//物品报表文件
		public readonly static string materials_rpt_filename = "cr_materials.rpt";
		
		//入库报表文件
		public readonly static string inbill_rpt_filename = "cr_inbill.rpt";
		
		//出库报表文件
		public readonly static string outbill_rpt_filename = "cr_outbill.rpt";
		
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
			if (ReportPath[ReportPath.Length - 1] != '\\')
			{
				ReportPath += "\\";
			}
			
			return ReportPath;
		}
		
	}
	
}
