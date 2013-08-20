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
		public class TablesButtonList : System.Collections.CollectionBase
		{
			
			private readonly System.Windows.Forms.Panel HostPanel;
			
			private int ButtonWidth = 115;
			private int ButtonHeight = 60;
			private int CountBtnPerLine = 2;
			private int CurrentBtnLine = 0;
			private Color ButtonOrignalBackColor1;
			private Color ButtonOrignalBackColor2;
			private Color ButtonOrignalBackColor3;
			private Color ButtonSelectedBackColor;
			public int CurrentBtnTop = 0;
			
			private int m_RefreshObjectID;
			
			public void AddNewButton(string tableno, string tablename, int status)
			{
				System.Windows.Forms.Button aButton = new System.Windows.Forms.Button();
				aButton.Width = ButtonWidth;
				aButton.Height = ButtonHeight;
				switch (status)
				{
					case 0: //桌台空闲
						aButton.BackColor = ButtonOrignalBackColor1;
						break;
					case 1: //桌台使用中
						aButton.BackColor = ButtonOrignalBackColor2;
						break;
					case 2: //原桌台预定中
						aButton.BackColor = ButtonOrignalBackColor3;
						break;
				}
				//aButton.ImageList = frmMain.ImageList2
				//aButton.ImageIndex = 15
				//aButton.ImageAlign = ContentAlignment.TopCenter
				aButton.TextAlign = ContentAlignment.MiddleCenter;
				
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
				aButton.Tag = tableno.ToString() + "," + status.ToString();
				aButton.Text = tableno + "\r\n" + "[" + tablename + "]";
				aButton.Click += new System.EventHandler(ClickHandler);
				
			}
			
			public TablesButtonList(System.Windows.Forms.Panel host, int btnWidth, int btnHeight, int btnCountPerLine, int RefreshObjectID)
				{
					ButtonOrignalBackColor1 = Color.LightBlue;
					ButtonOrignalBackColor2 = Color.Gold;
					ButtonOrignalBackColor3 = Color.Gray;
					ButtonSelectedBackColor = Color.FromArgb(255, 128, 128);
					
				HostPanel = host;
				ButtonWidth = btnWidth;
				ButtonHeight = btnHeight;
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
					HostPanel.Controls.Remove(this[0]);
					this.List.RemoveAt(0);
				}
			}
			
			public void RemoveAll()
			{
				while (this.Count > 0)
				{
					HostPanel.Controls.Remove(this[this.Count - 1]);
					this.List.RemoveAt(this.Count - 1);
				}
			}
			
			public void ClickHandler(object sender, System.EventArgs e)
			{
				//MessageBox.Show("您已单击按钮 " + CType(CType(sender, Button).Tag, String))
				if (m_RefreshObjectID == 1) //桌台状态视图
				{
					for (int I = 0; I <= this.Count - 1; I++)
					{
						string btntag =((Button)this.List[I]).Tag.ToString();
						string[] tags;
						tags = btntag.Split(",".ToCharArray());
						
						switch (tags[1])
						{
							case "0": //桌台空闲
								((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor1;
								break;
							case "1": //桌台使用中
								((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor2;
								break;
							case "2": //原桌台预定中
								((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor3;
								break;
						}
					}
					((Button) sender).BackColor = ButtonSelectedBackColor;
					rms_var.frmMain.TabControl1.SelectedIndex = 1;
					string tmp = System.Convert.ToString(((Button) sender).Tag);
					string[] tmps = tmp.Split(",".ToCharArray());
					string tableno = tmps[0];
					int ts;
					ts = rms_var.GetTableStatus(tableno);
					switch (ts)
					{
						case 0: //桌台空闲
							rms_var.frmMain.CurrentTableNo = tableno;
							rms_var.frmMain.ShowBill(tableno, "first");
							break;
						case 1: //桌台使用中
							rms_var.frmMain.ShowBill(tableno, "first");
							break;
						case 2: //原桌台预定中
							break;
							
					}
				}
				else //单据输入视图
				{
					for (int I = 0; I <= this.Count - 1; I++)
					{
						string btntag =((Button)this.List[I]).Tag.ToString();
						string[] tags;
						tags = btntag.Split(",".ToCharArray());
						
						switch (tags[1])
						{
							case "0": //桌台空闲
								((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor1;
								break;
							case "1": //桌台使用中
								((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor2;
								break;
							case "2": //原桌台预定中
								((System.Windows.Forms.Button) (this.List[I])).BackColor = ButtonOrignalBackColor3;
								break;
						}
					}
					((Button) sender).BackColor = ButtonSelectedBackColor;
					string tmp = System.Convert.ToString(((Button) sender).Tag);
					string[] tmps = tmp.Split(",".ToCharArray());
					string tableno = tmps[0];
					int ts;
					ts = rms_var.GetTableStatus(tableno);
					switch (ts)
					{
						case 0: //桌台空闲
							rms_var.frmMain.CurrentTableNo = tableno;
							rms_var.frmMain.ShowBill(tableno, "first");
							break;
						case 1: //桌台使用中
							rms_var.frmMain.ShowBill(tableno, "first");
							break;
						case 2: //原桌台预定中
							break;
							
					}
				}
			}
			
		}
	}
	
	
}
