using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace TouchScreen
{
	namespace MySpace
	{
		public class TableTypesButtonList : System.Collections.CollectionBase
		{
			
			private readonly System.Windows.Forms.Panel HostPanel;
			
			private int ButtonWidth = 115;
			private int ButtonHeight = 60;
			private int CountBtnPerLine = 2;
			private int CurrentBtnLine = 0;
			private Color ButtonOrignalBackColor;
			private Color ButtonSelectedBackColor;
			public int CurrentBtnTop = 0;
			
			private int m_RefreshObjectID;
			
			public void AddNewButton(string tabletypename)
			{
				System.Windows.Forms.Button aButton = new System.Windows.Forms.Button();
				aButton.Width = ButtonWidth;
				aButton.Height = ButtonHeight;
				aButton.BackColor = ButtonOrignalBackColor;
				aButton.ForeColor = Color.Black;
				if (m_RefreshObjectID == 1)
				{
					aButton.ImageList = rms_var.frmMain.ImageList2;
					aButton.ImageIndex = 15;
					aButton.ImageAlign = ContentAlignment.TopCenter;
					aButton.TextAlign = ContentAlignment.BottomCenter;
				}
				else
				{
					aButton.TextAlign = ContentAlignment.MiddleCenter;
				}
				
				this.List.Add(aButton);
				HostPanel.Controls.Add(aButton);
				if ((Count - 1) % CountBtnPerLine == 0) //一行中的第一个
				{
					aButton.Left = 0;
					CurrentBtnLine++;
					if (Count != 1)
					{
						CurrentBtnTop = CurrentBtnTop + aButton.Height;
					}
				}
				else //一行中的其余个
				{
					aButton.Left = System.Convert.ToInt32(((Count - 1) % CountBtnPerLine) * aButton.Width);
				}
				aButton.Top = CurrentBtnTop;
				aButton.Tag = tabletypename;
				aButton.Text = tabletypename;
				aButton.Click += new System.EventHandler(ClickHandler);
				
			}
			
			public TableTypesButtonList(System.Windows.Forms.Panel host, int btnWidth, int btnHeight, Color btnOrignalBackColor, Color btnSelectedBackColor, int btnCountPerLine, int RefreshObjectID)
				{
					ButtonOrignalBackColor = Color.LightBlue;
					ButtonSelectedBackColor = Color.Red;
					
				HostPanel = host;
				ButtonWidth = btnWidth;
				ButtonHeight = btnHeight;
				ButtonOrignalBackColor = btnOrignalBackColor;
				ButtonSelectedBackColor = btnSelectedBackColor;
				CountBtnPerLine = btnCountPerLine;
				m_RefreshObjectID = RefreshObjectID;
			}
			
			public System.Windows.Forms.Button this[int Index]
			{
				get
				{
					return ((System.Windows.Forms.Button) (this.List[Index]));
				}
			}
			
			public void Remove()
			{
				// 检查以确保存在要删除的按钮。
				if (this.Count > 0)
				{
					// 从宿主窗体控件集合中删除添加到数组
					// 的最后一个按钮。请注意在访问数组时
					// 默认属性的使用。
					HostPanel.Controls.Remove(this[this.Count - 1]);
					this.List.RemoveAt(this.Count - 1);
				}
			}
			
			public void SelectItem(int index)
			{
				for (int I = 0; I <= this.Count - 1; I++)
				{
					((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor;
				}
				((System.Windows.Forms.Button) (this.List[index])).BackColor = ButtonSelectedBackColor;
				rms_var.frmMain.CurrentTableTypeName =((System.Windows.Forms.Button)(this.List[index])).Tag.ToString();
			}
			
			public void ClickHandler(object sender, System.EventArgs e)
			{
				//MessageBox.Show("您已单击按钮 " + CType(CType(sender, Button).Tag, String))
				if (m_RefreshObjectID == 1) //桌台状态视图
				{
					for (int I = 0; I <= this.Count - 1; I++)
					{
						((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor;
					}
					((Button) sender).BackColor = ButtonSelectedBackColor;
					//更新桌台
					//frmMain.RefreshTableListView(CType(CType(sender, Button).Tag, String))
					rms_var.frmMain.CurrentTableTypeName = System.Convert.ToString(((Button) sender).Tag);
					rms_var.frmMain.GetTablesInFirstView(System.Convert.ToString(((Button) sender).Tag));
				}
				else if (m_RefreshObjectID == 2) //单据输入视图
				{
					for (int I = 0; I <= this.Count - 1; I++)
					{
						((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor;
					}
					((Button) sender).BackColor = ButtonSelectedBackColor;
					
					//更新桌台
					rms_var.frmMain.CurrentTableTypeName = System.Convert.ToString(((Button) sender).Tag);
					rms_var.frmMain.GetTables(System.Convert.ToString(((Button) sender).Tag));
				}
			}
			
		}
		
	}
	
}
