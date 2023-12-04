using System.ComponentModel;

namespace QL_Thue_Xe_Dap
{
    partial class ThueXe
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoGioThue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.dgvDSXe = new System.Windows.Forms.DataGridView();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cmbTenXe = new System.Windows.Forms.ComboBox();
            this.btnTaoDonThueXe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.txtSoDienThoaiKH = new System.Windows.Forms.TextBox();
            this.txtSoCCCDKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoGioThue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnXoaXe);
            this.groupBox2.Controls.Add(this.btnThemXe);
            this.groupBox2.Controls.Add(this.dgvDSXe);
            this.groupBox2.Controls.Add(this.txtGiaThue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTienDatCoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbLoaiXe);
            this.groupBox2.Controls.Add(this.cmbTenXe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1214, 575);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe thuê";
            // 
            // txtSoGioThue
            // 
            this.txtSoGioThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGioThue.Location = new System.Drawing.Point(162, 135);
            this.txtSoGioThue.Name = "txtSoGioThue";
            this.txtSoGioThue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoGioThue.Size = new System.Drawing.Size(260, 26);
            this.txtSoGioThue.TabIndex = 28;
            this.txtSoGioThue.Text = "1";
            this.txtSoGioThue.TextChanged += new System.EventHandler(this.textSoGioThue_TextChanged);
            this.txtSoGioThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSoGioThue_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Số giờ thuê\r\n";
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXe.Location = new System.Drawing.Point(1016, 292);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(163, 50);
            this.btnXoaXe.TabIndex = 25;
            this.btnXoaXe.Text = "Xóa";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.Location = new System.Drawing.Point(1016, 210);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(163, 52);
            this.btnThemXe.TabIndex = 24;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // dgvDSXe
            // 
            this.dgvDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXe.Location = new System.Drawing.Point(23, 210);
            this.dgvDSXe.Name = "dgvDSXe";
            this.dgvDSXe.RowTemplate.Height = 24;
            this.dgvDSXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSXe.Size = new System.Drawing.Size(957, 349);
            this.dgvDSXe.TabIndex = 23;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Enabled = false;
            this.txtGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.Location = new System.Drawing.Point(720, 88);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(260, 26);
            this.txtGiaThue.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giá Thuê\r\n";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Enabled = false;
            this.txtTienDatCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDatCoc.Location = new System.Drawing.Point(720, 48);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(260, 26);
            this.txtTienDatCoc.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiền đặt cọc\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên xe\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Loại Xe\r\n";
            // 
            // cmbLoaiXe
            // 
            this.cmbLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiXe.FormattingEnabled = true;
            this.cmbLoaiXe.Location = new System.Drawing.Point(162, 45);
            this.cmbLoaiXe.Name = "cmbLoaiXe";
            this.cmbLoaiXe.Size = new System.Drawing.Size(260, 28);
            this.cmbLoaiXe.TabIndex = 9;
            this.cmbLoaiXe.SelectedValueChanged += new System.EventHandler(this.cmbLoaiXe_SelectedValueChanged);
            // 
            // cmbTenXe
            // 
            this.cmbTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenXe.FormattingEnabled = true;
            this.cmbTenXe.Location = new System.Drawing.Point(162, 85);
            this.cmbTenXe.Name = "cmbTenXe";
            this.cmbTenXe.Size = new System.Drawing.Size(260, 28);
            this.cmbTenXe.TabIndex = 10;
            this.cmbTenXe.SelectedValueChanged += new System.EventHandler(this.cmbTenXe_SelectedValueChanged);
            // 
            // btnTaoDonThueXe
            // 
            this.btnTaoDonThueXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDonThueXe.Location = new System.Drawing.Point(911, 771);
            this.btnTaoDonThueXe.Name = "btnTaoDonThueXe";
            this.btnTaoDonThueXe.Size = new System.Drawing.Size(274, 50);
            this.btnTaoDonThueXe.TabIndex = 26;
            this.btnTaoDonThueXe.Text = "Tạo Đơn Thuê Xe\r\n";
            this.btnTaoDonThueXe.UseVisualStyleBackColor = true;
            this.btnTaoDonThueXe.Click += new System.EventHandler(this.btnTaoDonThueXe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmailKH);
            this.groupBox1.Controls.Add(this.txtSoDienThoaiKH);
            this.groupBox1.Controls.Add(this.txtSoCCCDKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 177);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(720, 83);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 30);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Địa Chỉ";
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Location = new System.Drawing.Point(720, 43);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(260, 30);
            this.txtEmailKH.TabIndex = 4;
            // 
            // txtSoDienThoaiKH
            // 
            this.txtSoDienThoaiKH.Location = new System.Drawing.Point(162, 117);
            this.txtSoDienThoaiKH.Name = "txtSoDienThoaiKH";
            this.txtSoDienThoaiKH.Size = new System.Drawing.Size(260, 30);
            this.txtSoDienThoaiKH.TabIndex = 3;
            // 
            // txtSoCCCDKH
            // 
            this.txtSoCCCDKH.Location = new System.Drawing.Point(162, 76);
            this.txtSoCCCDKH.Name = "txtSoCCCDKH";
            this.txtSoCCCDKH.Size = new System.Drawing.Size(260, 30);
            this.txtSoCCCDKH.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(162, 39);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(260, 30);
            this.txtTenKH.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(581, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Số điện thoại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Số CCCD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Họ và tên";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(159, 786);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(599, 22);
            this.txtTongTien.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 786);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tổng Tiền\r\n";
            // 
            // ThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 853);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTaoDonThueXe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThueXe";
            this.Text = "ThueXe";
            this.Load += new System.EventHandler(this.ThueXe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSoGioThue;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ErrorProvider error;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTaoDonThueXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.DataGridView dgvDSXe;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoaiXe;
        private System.Windows.Forms.ComboBox cmbTenXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.TextBox txtSoDienThoaiKH;
        private System.Windows.Forms.TextBox txtSoCCCDKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

        #endregion
    }
}