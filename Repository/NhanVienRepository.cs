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

    }
}