namespace DeskApp
{
    partial class frmChangeTableStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_st4 = new System.Windows.Forms.Button();
            this.btn_st3 = new System.Windows.Forms.Button();
            this.btn_st1 = new System.Windows.Forms.Button();
            this.btn_st0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_st4
            // 
            this.btn_st4.BackColor = System.Drawing.Color.Transparent;
            this.btn_st4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_st4.Image = global::DeskApp.Properties.Resources._49;
            this.btn_st4.Location = new System.Drawing.Point(262, 15);
            this.btn_st4.Name = "btn_st4";
            this.btn_st4.Size = new System.Drawing.Size(75, 72);
            this.btn_st4.TabIndex = 4;
            this.btn_st4.UseVisualStyleBackColor = false;
            this.btn_st4.Click += new System.EventHandler(this.btn_st4_Click);
            // 
            // btn_st3
            // 
            this.btn_st3.BackColor = System.Drawing.Color.Transparent;
            this.btn_st3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_st3.Image = global::DeskApp.Properties.Resources._38;
            this.btn_st3.Location = new System.Drawing.Point(181, 15);
            this.btn_st3.Name = "btn_st3";
            this.btn_st3.Size = new System.Drawing.Size(75, 72);
            this.btn_st3.TabIndex = 3;
            this.btn_st3.UseVisualStyleBackColor = false;
            this.btn_st3.Click += new System.EventHandler(this.btn_st3_Click);
            // 
            // btn_st1
            // 
            this.btn_st1.BackColor = System.Drawing.Color.Transparent;
            this.btn_st1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_st1.Image = global::DeskApp.Properties.Resources._54;
            this.btn_st1.Location = new System.Drawing.Point(99, 15);
            this.btn_st1.Name = "btn_st1";
            this.btn_st1.Size = new System.Drawing.Size(75, 72);
            this.btn_st1.TabIndex = 1;
            this.btn_st1.UseVisualStyleBackColor = false;
            this.btn_st1.Click += new System.EventHandler(this.btn_st1_Click);
            // 
            // btn_st0
            // 
            this.btn_st0.BackColor = System.Drawing.Color.Transparent;
            this.btn_st0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_st0.Image = global::DeskApp.Properties.Resources._50;
            this.btn_st0.Location = new System.Drawing.Point(18, 15);
            this.btn_st0.Name = "btn_st0";
            this.btn_st0.Size = new System.Drawing.Size(75, 72);
            this.btn_st0.TabIndex = 0;
            this.btn_st0.UseVisualStyleBackColor = false;
            this.btn_st0.Click += new System.EventHandler(this.btn_st0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "变为空闲";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "变为使用";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "变为脏台";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "变为停用";
            // 
            // frmChangeTableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 122);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_st4);
            this.Controls.Add(this.btn_st3);
            this.Controls.Add(this.btn_st1);
            this.Controls.Add(this.btn_st0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeTableStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "状态变更";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_st0;
        private System.Windows.Forms.Button btn_st1;
        private System.Windows.Forms.Button btn_st3;
        private System.Windows.Forms.Button btn_st4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}