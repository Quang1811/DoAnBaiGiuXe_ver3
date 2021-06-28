namespace ProjectUITParking
{
    partial class form_quanlytt
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
            this.cmd_quanlynhanvien = new System.Windows.Forms.Button();
            this.cmdquanlyxe = new System.Windows.Forms.Button();
            this.pnQuanlytt = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmd_quanlynhanvien
            // 
            this.cmd_quanlynhanvien.Location = new System.Drawing.Point(23, 12);
            this.cmd_quanlynhanvien.Name = "cmd_quanlynhanvien";
            this.cmd_quanlynhanvien.Size = new System.Drawing.Size(189, 63);
            this.cmd_quanlynhanvien.TabIndex = 0;
            this.cmd_quanlynhanvien.Text = "Quản Lý Nhân Viên";
            this.cmd_quanlynhanvien.UseVisualStyleBackColor = true;
            this.cmd_quanlynhanvien.Click += new System.EventHandler(this.cmd_quanlynhanvien_Click);
            // 
            // cmdquanlyxe
            // 
            this.cmdquanlyxe.Location = new System.Drawing.Point(23, 132);
            this.cmdquanlyxe.Name = "cmdquanlyxe";
            this.cmdquanlyxe.Size = new System.Drawing.Size(189, 65);
            this.cmdquanlyxe.TabIndex = 1;
            this.cmdquanlyxe.Text = "Quản Lý Xe";
            this.cmdquanlyxe.UseVisualStyleBackColor = true;
            this.cmdquanlyxe.Click += new System.EventHandler(this.cmdquanlyxe_Click);
            // 
            // pnQuanlytt
            // 
            this.pnQuanlytt.AutoSize = true;
            this.pnQuanlytt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnQuanlytt.Location = new System.Drawing.Point(234, 12);
            this.pnQuanlytt.Name = "pnQuanlytt";
            this.pnQuanlytt.Size = new System.Drawing.Size(1656, 984);
            this.pnQuanlytt.TabIndex = 3;
            // 
            // form_quanlytt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 998);
            this.Controls.Add(this.cmd_quanlynhanvien);
            this.Controls.Add(this.cmdquanlyxe);
            this.Controls.Add(this.pnQuanlytt);
            this.Name = "form_quanlytt";
            this.Text = "QUẢN LÝ THÔNG TIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_quanlynhanvien;
        private System.Windows.Forms.Button cmdquanlyxe;
        private System.Windows.Forms.Panel pnQuanlytt;

    }
}