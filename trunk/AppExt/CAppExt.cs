using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using SkinSharp;

//文档自述

//应用程序扩展 AppExt.dll
//1、包含登录窗口、about窗口
//2、类型化的传菜菜品信息类(用于远程传菜)
//3、权限验证

//在其它引用该类库的桌面程序中都可以调用权限属性

namespace AppExt
{
	public class CAppExt
	{
        public SkinH_Net skinh;
		
		
		//返回数据库连接字符串
		public string GetConnStr
		{
			get
			{
				return rms_var.ConnStr;
			}
		}
		
		//返回系统OEM名称
		public string GetAppTitle
		{
			get
			{
				return rms_var.apptitle;
			}
		}
		
		//返回软件供应商短名称
		public string GetShortVendorName
		{
			get
			{
				return rms_var.ShortVendorName;
			}
		}
		
		//返回英文版权信息
		public string GetEnCopyright
		{
			get
			{
				return rms_var.EnCopyright;
			}
		}
		
		//返回中文版权信息
		public string GetChnCopyright
		{
			get
			{
				return rms_var.ChnCopyright;
			}
		}
		
		//返回主页超级链接
		public string GetWebPageLink
		{
			get
			{
				return rms_var.WebPage;
			}
		}
		
		//系统登录模块
		public int LogModule
		{
			get
			{
				return rms_var.log_mod_code;
			}
			set
			{
				rms_var.log_mod_code = value;
			}
		}
		
		//检测是否允许 库存管理 - 物料管理
		public bool Chk_Kc_Wlgl
		{
			get
			{
				return rms_var.log_kc_wl;
			}
		}
		
		//检测是否允许 库存管理 - 原料管理
		public bool Chk_Kc_Ylgl
		{
			get
			{
				return rms_var.log_kc_yl;
			}
		}
		
		//检测是否允许 系统管理 - 系统设置
		public bool Chk_Sys_xtsz
		{
			get
			{
				return rms_var.sys_xtsz;
			}
		}
		
		//检测是否允许 系统管理 - 客户管理
		public bool Chk_Sys_khgl
		{
			get
			{
				return rms_var.sys_khgl;
			}
		}
		
		//检测是否允许 系统管理 - 人员管理
		public bool Chk_Sys_rygl
		{
			get
			{
				return rms_var.sys_rygl;
			}
		}
		
		//检测是否允许 系统管理 - 菜品管理
		public bool Chk_Sys_cpgl
		{
			get
			{
				return rms_var.sys_cpgl;
			}
		}
		
		//检测是否允许 系统管理 - 前台信息管理
		public bool Chk_Sys_sjgl
		{
			get
			{
				return rms_var.sys_sjgl;
			}
		}
		
		//检测是否允许 系统管理 - 数据管理
		public bool Chk_Sys_qtgl
		{
			get
			{
				return rms_var.sys_qtgl;
			}
		}
		
		//检测是否允许 操作权限 - 审核权
		public bool Chk_op_audit
		{
			get
			{
				return rms_var.op_audit;
			}
		}
		
		//检测是否允许 操作权限 - 结帐权
		public bool Chk_op_jz
		{
			get
			{
				return rms_var.op_jz;
			}
		}
		
		//检测是否允许 操作权限 - 退菜权
		public bool Chk_op_tc
		{
			get
			{
				return rms_var.op_tc;
			}
		}
		
		//检测是否允许 操作权限 - 允许客户签单
		public bool Chk_op_qd
		{
			get
			{
				return rms_var.op_qd;
			}
		}
		
		//检测是否允许 操作权限 - 允许自由打折
		public bool Chk_op_dz
		{
			get
			{
				return rms_var.op_dz;
			}
		}
		
		//检测是否允许 操作权限 - 未结帐允许删除单据和菜品
		public bool Chk_op_df
		{
			get
			{
				return rms_var.op_df;
			}
		}
		
		//检测是否允许 操作权限 - 返位
		public bool Chk_op_fw
		{
			get
			{
				return rms_var.op_fw;
			}
		}
		
		//显示登录窗口
		public string ShowLogForm(string caption)
		{
			LogForm frmlogform = new LogForm();
			frmlogform.Text = System.Convert.ToString(rms_var.apptitle + frmlogform.Text + caption);
			frmlogform.ShowDialog();
            string str="";
			if (frmlogform.DialogResult == System.Windows.Forms.DialogResult.OK) //登录成功
			{
				str=frmlogform.TextBox1.Text; //返回成功登录的操作员ID
			}
			else if (frmlogform.DialogResult == System.Windows.Forms.DialogResult.Cancel) //退出系统
			{
				str="-1";
			}
            return str;
			frmlogform.Dispose();
			
		}
		//显示登录窗口
		public string ShowLogForm2(string caption)
		{
			TouchLogForm frmlogform = new TouchLogForm();
			frmlogform.Text = System.Convert.ToString(rms_var.apptitle + frmlogform.Text + caption);
			frmlogform.ShowDialog();
            string str="";
			if (frmlogform.DialogResult == System.Windows.Forms.DialogResult.OK) //登录成功
			{
				str=frmlogform.TextBox1.Text; //返回成功登录的操作员ID
			}
			else if (frmlogform.DialogResult == System.Windows.Forms.DialogResult.Cancel) //退出系统
			{
				str="-1";
			}
            return str;
			frmlogform.Dispose();
		}
		
		//显示关于窗口
		public void ShowAboutForm(string ver, string id)
		{
			frmAbout frmlogaboutform = new frmAbout();
			frmlogaboutform.verstr = ver;
			frmlogaboutform.appid = id;
			frmlogaboutform.ShowDialog();
			frmlogaboutform.Dispose();
		}
		//传菜 菜品信息
		public class FoodInfo
		{
			
			
			public string FoodCode;
			public string TableType;
			public string Tableno;
			public string PsnCount;
			public string Billno;
			public string FoodName;
			public string TypeName;
			public string DeptName;
			public string unit;
			public string quantity;
			public string operandi;
			public string taste;
			public string operatorid;
			public int OperateCode; //OperateCode = 0 传菜 OperateCode = 1 催菜 OperateCode = 2 缓菜 OperateCode = 3 退菜
			public string CancelRsn; //退菜原因
			public string BarCode;
			
		}
		
		public CAppExt()
		{
            skinh = new SkinH_Net();
            skinh.Attach();
			rms_var.InitialApp();
		}
	}
	
}
