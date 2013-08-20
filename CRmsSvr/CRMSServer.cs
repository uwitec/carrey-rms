using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

//文档自述

//远程对象 CRMSSvr.dll
//向本地专用消息队列传送类型化的菜品信息，供服务程序自动分单打印时调用

//每个远程对象都从MarshalByRefObject派生
namespace CRmsSvr
{
	public class CRMSServer : MarshalByRefObject
	{
    	//测试函数 定义类提供服务的方法
		public bool AddtoMsgQue(string msg)
		{
			bool returnValue;
			returnValue = false;
			string Path = ".\\Private$\\RMS";
			if (System.Messaging.MessageQueue.Exists(Path))
			{
				System.Messaging.MessageQueue queue = new System.Messaging.MessageQueue(Path);
				if (! queue.Transactional)
				{
					queue.Send(msg);
					returnValue = true;
				}
			}
			else
			{
				System.Messaging.MessageQueue queue = new System.Messaging.MessageQueue(Path);
				queue = System.Messaging.MessageQueue.Create(Path);
				queue.Send(msg);
				returnValue = true;
			}
			return returnValue;
		}
		
		//传菜
		public bool TransFood(string FoodCode, string TableType, string Tableno, string PsnCount, string billno, string FoodName, string TypeName, string DeptName, string unit, string quantity, string operandi, string taste, string operatorid, string barcode, int OperateCode, string CancelRsn)
		{
			bool returnValue;
			returnValue = false;
			string queuePath = ".\\Private$\\RMS";
			EnsureQueueExists(queuePath);
			
			System.Messaging.MessageQueue queue = new System.Messaging.MessageQueue(queuePath);
			queue.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] {typeof(AppExt.CAppExt.FoodInfo)});
			
			AppExt.CAppExt.FoodInfo orderRequest = new AppExt.CAppExt.FoodInfo();
			
			orderRequest.FoodCode = FoodCode;
			orderRequest.TableType = TableType;
			orderRequest.Tableno = Tableno;
			orderRequest.PsnCount = PsnCount;
			orderRequest.Billno = billno;
			orderRequest.FoodName = FoodName;
			orderRequest.TypeName = TypeName;
			orderRequest.DeptName = DeptName;
			orderRequest.unit = unit;
			orderRequest.quantity = quantity;
			orderRequest.operandi = operandi;
			orderRequest.taste = taste;
			orderRequest.operatorid = operatorid;
			orderRequest.BarCode = barcode;
			orderRequest.OperateCode = OperateCode; //OperateCode = 0 传菜 OperateCode = 1 催菜 OperateCode = 2 缓菜 OperateCode = 3 退菜
			orderRequest.CancelRsn = CancelRsn;
			
			queue.Send(orderRequest);
			returnValue = true;
			return returnValue;
		}
		
		public void EnsureQueueExists(string queuePath)
		{
			if (!System.Messaging.MessageQueue.Exists(queuePath))
			{
				System.Messaging.MessageQueue.Create(queuePath);
			}
		}
		
	}
	
	
}
