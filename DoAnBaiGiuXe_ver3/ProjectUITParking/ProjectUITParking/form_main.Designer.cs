namespace ProjectUITParking
{
    partial class formmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formmain));
            this.cmdQuanLyTT = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmdBaoCao = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.link01 = new System.Windows.Forms.LinkLabel();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdQuanLyTT
            // 
            this.cmdQuanLyTT.Image = ((System.Drawing.Image)(resources.GetObject("cmdQuanLyTT.Image")));
            this.cmdQuanLyTT.Location = new System.Drawing.Point(12, 3);
            this.cmdQuanLyTT.Name = "cmdQuanLyTT";
            this.cmdQuanLyTT.Size = new System.Drawing.Size(170, 76);
            this.cmdQuanLyTT.TabIndex = 0;
            this.cmdQuanLyTT.UseVisualStyleBackColor = true;
            this.cmdQuanLyTT.Click += new System.EventHandler(this.cmdQuanLyTT_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quản Lý Thông Tin";
            // 
            // cmdBaoCao
            // 
            this.cmdBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("cmdBaoCao.Image")));
            this.cmdBaoCao.Location = new System.Drawing.Point(307, 3);
            this.cmdBaoCao.Name = "cmdBaoCao";
            this.cmdBaoCao.Size = new System.Drawing.Size(171, 76);
            this.cmdBaoCao.TabIndex = 2;
            this.cmdBaoCao.UseVisualStyleBackColor = true;
            this.cmdBaoCao.Click += new System.EventHandler(this.cmdBaoCao_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdThoat.Image")));
            this.cmdThoat.Location = new System.Drawing.Point(916, 5);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(177, 72);
            this.cmdThoat.TabIndex = 4;
            this.cmdThoat.UseVisualStyleBackColor = true;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(349, 80);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 20);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Báo Cáo";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(985, 80);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(50, 20);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Thoát";
            // 
            // link01
            // 
            this.link01.AutoSize = true;
            this.link01.Location = new System.Drawing.Point(618, 80);
            this.link01.Name = "link01";
            this.link01.Size = new System.Drawing.Size(143, 20);
            this.link01.TabIndex = 8;
            this.link01.TabStop = true;
            this.link01.Text = "Thông tin về nhóm ";
            // 
            // cmdAbout
            // 
            this.cmdAbout.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbout.Image")));
            this.cmdAbout.Location = new System.Drawing.Point(599, 3);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(175, 76);
            this.cmdAbout.TabIndex = 9;
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Location = new System.Drawing.Point(12, 103);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1887, 913);
            this.panel_main.TabIndex = 10;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1022);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.link01);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.cmdQuanLyTT);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdBaoCao);
            this.Name = "formmain";
            this.Text = "                                                                                 " +
    "                                                                         PHẦN MỀ" +
    "M BÃI GIỮ XE ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdQuanLyTT;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button cmdBaoCao;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel link01;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Panel panel_main;
    }
}

