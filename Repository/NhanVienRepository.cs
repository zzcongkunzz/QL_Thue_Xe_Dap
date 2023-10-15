using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QL_Thue_Xe_Dap.Repository
{
    public class NhanVienRepository
    {
        private SqlConnection connection;
        
        public NhanVienRepository()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            String query = $"SELECT * FROM tbl_NhanVien " +
                           $"INNER JOIN dbo.tbl_NhomNguoiDung tNND on tNND.idNhomNguoiDung = tbl_NhanVien.idNhomNguoiDung " +
                           $"WHERE taiKhoan = '{taiKhoan}' AND matKhau = '{matKhau}'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            connection.Close();
            return dataTable;
        }

    }
}