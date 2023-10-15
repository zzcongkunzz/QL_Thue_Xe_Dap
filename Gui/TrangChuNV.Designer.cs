using System.ComponentModel;

namespace QL_Thue_Xe_Dap
{
    partial class TrangChuNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thuêXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuĐặtCọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.thuêXeToolStripMenuItem, this.khachsToolStripMenuItem, this.hóaĐơnToolStripMenuItem, this.phiếuĐặtCọcToolStripMenuItem, this.đăngXuấtToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thuêXeToolStripMenuItem
            // 
            this.thuêXeToolStripMenuItem.Name = "thuêXeToolStripMenuItem";
            this.thuêXeToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.thuêXeToolStripMenuItem.Text = "Thuê Xe";
            // 
            // khachsToolStripMenuItem
            // 
            this.khachsToolStripMenuItem.Name = "khachsToolStripMenuItem";
            this.khachsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.khachsToolStripMenuItem.Text = "Khách Hàng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // phiếuĐặtCọcToolStripMenuItem
            // 
            this.phiếuĐặtCọcToolStripMenuItem.Name = "phiếuĐặtCọcToolStripMenuItem";
            this.phiếuĐặtCọcToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.phiếuĐặtCọcToolStripMenuItem.Text = "Phiếu Đặt Cọc";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // TrangChuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 853);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuNV";
            this.Load += new System.EventHandler(this.TrangChuNV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem thuêXeToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem phiếuĐặtCọcToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khachsToolStripMenuItem;

        #endregion
    }
}