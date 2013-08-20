using System.Data;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace AppExt
{
	public class frmAbout : System.Windows.Forms.Form
	{
		
		public string verstr;
		public string appid;
		
		//根据传递过来的appid验证是哪个模块需要调用about窗口，随意定义
		const string deskappid = "3f7a"; //前台管理模块
		const string sysadmappid = "98b0"; //系统管理模块
		const string strgappid = "c8f0"; //库存管理模块
		const string decisionid = "19ea"; //汇总统计模块
		const string kitchenid = "a6c0"; //后厨上菜模块
		const string touchappid = "30f7"; //触摸屏客户端
		
		
		#region  Windows 窗体设计器生成的代码
		
		public frmAbout()
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

        private System.ComponentModel.IContainer components;

        //Windows 窗体设计器所必需的
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label lblUserName;
		internal System.Windows.Forms.Label lblCompanyName;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button1.Location = new System.Drawing.Point(368, 256);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 37);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "确定(&O)";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(210, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(250, 23);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Label1";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Location = new System.Drawing.Point(0, 237);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(368, 23);
            this.LinkLabel1.TabIndex = 1;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "http://www.carreygroup.com";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label2.Location = new System.Drawing.Point(210, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(250, 24);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "PPC 多线程接口服务程序";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label4.Location = new System.Drawing.Point(210, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(250, 32);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Carrey 无线餐饮管理系统";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Location = new System.Drawing.Point(150, 8);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(56, 48);
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(152, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Carrey Group 软件产品";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.Red;
            this.Label7.Location = new System.Drawing.Point(152, 195);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(304, 40);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "版权声明：该程序的著作权归程序作者本人所有，任何单位和/或个人不得擅自再发布和反编译。";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label8.Location = new System.Drawing.Point(0, 296);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(466, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Copyright (C) Carrey Group. All Rights Reserved!";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblUserName);
            this.GroupBox1.Controls.Add(this.lblCompanyName);
            this.GroupBox1.Location = new System.Drawing.Point(152, 88);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(304, 72);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "本产品使用权属于";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(16, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(280, 24);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(16, 20);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(280, 23);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Carrey Group";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(144, 234);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(0, 260);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(368, 23);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "版权所有(C) Carrey Group。保留所有权利！";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 312);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion
		
		private void frmAbout_Load(System.Object sender, System.EventArgs e)
		{
			Label4.Text = rms_var.apptitle.ToString();
			Label1.Text = "版本：" + verstr;
			if (appid == deskappid) //前台管理
			{
				Label2.Text = "前台管理模块";
				PictureBox1.Image = ImageList1.Images[0];
			}
			else if (appid == sysadmappid) //系统管理
			{
				Label2.Text = "系统管理模块";
				PictureBox1.Image = ImageList1.Images[1];
			}
			else if (appid == strgappid) //库存管理
			{
				Label2.Text = "库存管理模块";
				PictureBox1.Image = ImageList1.Images[2];
			}
			else if (appid == decisionid) //汇总统计
			{
				Label2.Text = "汇总统计模块";
				PictureBox1.Image = ImageList1.Images[3];
			}
			else if (appid == kitchenid)
			{
				Label2.Text = "后厨上菜模块";
				PictureBox1.Image = ImageList1.Images[4];
			}
			else if (appid == touchappid)
			{
				Label2.Text = "触摸屏客户端";
				PictureBox1.Image = ImageList1.Images[5];
			}
			//label6.Text = ShortVendorName + "2010"
			LinkLabel1.Text = rms_var.WebPage.ToString();
			Label9.Text = rms_var.ChnCopyright.ToString();
			Label8.Text = rms_var.EnCopyright.ToString();
			//返回注册使用信息
			lblCompanyName.Text = rms_var.ReadStrfromReg("RegisterCompanyName", "Carrey Group");
			//lblUserName.Text = ReadStrfromReg("RegisterUserName", "Carrey Group")
		}
		
		//启动超级链接关联程序
		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(rms_var.WebPage.ToString());
		}
		
	}
	
}
