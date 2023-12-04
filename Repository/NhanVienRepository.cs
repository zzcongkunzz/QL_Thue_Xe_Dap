using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QL_Thue_Xe_Dap.Repository
{
    public class NhanVienRepository : Repository
    {
        
        public NhanVienRepository() : base()
        { }
        

        public DataTable KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            DataTable dataTable = new DataTable();
            base.OpenConnection();
            String query = $"SELECT * FROM tbl_NhanVien " +
                           $"INNER JOIN dbo.tbl_NhomNguoiDung tNND on tNND.idNhomNguoiDung = tbl_NhanVien.idNhomNguoiDung " +
                           $"WHERE taiKhoan = '{taiKhoan}' AND matKhau = '{matKhau}'";
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            base.CloseConnection();
            return dataTable;
        }

        public void MatKhau(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String query = $"SELECT count(*) FROM tbl_NhanVien " +
/*                          $" INNER JOIN dbo.tbl_NhomNguoiDung tNND on tNND.idNhomNguoiDung = tbl_NhanVien.idNhomNguoiDung " +*/
                          $"WHERE taiKhoan = '{taiKhoan}'";

                String query2 = $"UPDATE tbl_NhanVien " +
                                $"SET matKhau = '{matKhauMoi}' " +
                               /*                               $" INNER JOIN dbo.tbl_NhomNguoiDung tNND on tNND.idNhomNguoiDung = tbl_NhanVien.idNhomNguoiDung " +*/
                               $"WHERE taiKhoan = '{taiKhoan}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("taiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("matKhau", matKhauCu);

                    int userCount = (int)command.ExecuteScalar();
                    if (userCount == 0)
                    {
                        throw new Exception("Mật khẩu cũ không đúng.");
                    }
                }

                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("taiKhoan", taiKhoan);
                    command2.Parameters.AddWithValue("matKhau", matKhauMoi);

                    var rowsAffected = command2.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Đổi mật khẩu không thành công. Thử lại sau.");
                    }
                }
            }
           
        }

    }
}