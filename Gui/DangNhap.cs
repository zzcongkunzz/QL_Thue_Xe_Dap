using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using QL_Thue_Xe_Dap.Gui;
using QL_Thue_Xe_Dap.Model;
using QL_Thue_Xe_Dap.Repository;
using QL_Thue_Xe_Dap.Servive;

namespace QL_Thue_Xe_Dap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private NhanVienService nhanVienService = new NhanVienService();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            bool checkError = false;

            if (taiKhoan.Equals(""))
            {
                this.error.SetError(this.txtTaiKhoan, "Không được để trống");
                checkError = true;
            }

            if (matKhau.Equals(""))
            {
                this.error.SetError(this.txtMatKhau, "Không được để trống");
                checkError = true;
            }

            if (checkError == false)
            {
                if (this.nhanVienService.DangNhap(taiKhoan, matKhau))
                {
                    MessageBox.Show($"Bạn đã đăng nhập thành công với quyền: {Properties.Settings.Default.Quyen}");

                    if (Properties.Settings.Default.Quyen == "Admin")
                    {
                        TrangChuAdmin trangChuAdmin = new TrangChuAdmin();
                        trangChuAdmin.Show();
                        this.Hide();
                    }
                    else if (Properties.Settings.Default.Quyen == "NhanVien")
                    {
                        TrangChuNV trangChuNv = new TrangChuNV();
                        trangChuNv.Show();
                        this.Hide();
                    }
                    else if (Properties.Settings.Default.Quyen == "QuanLyXe")
                    {
                        TrangChuQLXe trangChuQlXe = new TrangChuQLXe();
                        trangChuQlXe.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
        }

        private void cbhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbhienmk.Checked == true)
            {
                this.txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void lbDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.Show();
            this.Hide();
        }
    }
}