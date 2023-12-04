using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using QL_Thue_Xe_Dap.Servive;

namespace QL_Thue_Xe_Dap.Gui
{
    public partial class DoiMatKhau : Form
    {
        /*        string taiKhoanCu = "tuan";
                string matKhauCu = "123";*/
        private NhanVienService nhanVienService;
        public DoiMatKhau()
        {
            InitializeComponent();
            this.nhanVienService = new NhanVienService();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

            string taiKhoan = txtTaiKhoan.Text;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = nhanVienService.encryptionSHA(txtMatKhauMoi.Text);
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text;
/*            if (taiKhoan != taiKhoanCu)
            {
                MessageBox.Show("Tên đăng nhập không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhau != matKhauCu)
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
/*
            if (!newPassword.Equals(confirmNewPassword))
            {
                MessageBox.Show("Mật khẩu không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
*/

/*            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra mật khẩu cũ
                String query = $"SELECT * FROM tbl_NhanVien " +
                               $" INNER JOIN dbo.tbl_NhomNguoiDung tNND on tNND.idNhomNguoiDung = tbl_NhanVien.idNhomNguoiDung " +
                               $"WHERE taiKhoan = '{taiKhoan}' AND matKhau = '{matKhauCu}'";

                String query2 = $"UPDATE tbl_NhanVien " +
                                $"SET matKhau = '{matKhauMoi}' " + 
/*                               $" INNER JOIN dbo.tbl_NhomNguoiDung tNND on tNND.idNhomNguoiDung = tbl_NhanVien.idNhomNguoiDung " +*/
                               $"WHERE taiKhoan = '{taiKhoan}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("taiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("matKhau", matKhauCu);

                    var userCount = command.ExecuteScalar();

/*                    if (userCount = 0)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }*/
                }

                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("taiKhoan", taiKhoan);
                    command2.Parameters.AddWithValue("matKhau", matKhauMoi);

                    var rowsAffected = command2.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công. Thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }











/*                    this.Close();*/
        }
    }
}
