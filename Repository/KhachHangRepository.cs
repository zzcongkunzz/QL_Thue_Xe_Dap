using QL_Thue_Xe_Dap.Model;
using System;

using System.Data;
using System.Data.SqlClient;
namespace QL_Thue_Xe_Dap.Repository
{
    public class KhachHangRepository : Repository
    {
        
        public KhachHangRepository() : base(){}

        public KhachHang ThemKhachHang(KhachHang khachHang)
        {
            DataTable dataTable = new DataTable();
           
            Guid randomGuid = Guid.NewGuid();
            khachHang.MaKh = randomGuid.ToString();
            
            String query = $"Insert Into tbl_KhachHang(maKH, tenKH, cccd, email, sdt, diaChi)" +
                           $"values ('{khachHang.MaKh}', N'{khachHang.TenKh}', '{khachHang.Cccd}', '{khachHang.Email}', '{khachHang.Sdt}', N'{khachHang.DiaChi}')";

            int soBanGhiThayDoi = 0;
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                
                soBanGhiThayDoi = command.ExecuteNonQuery();
            }
            base.CloseConnection();

            if (soBanGhiThayDoi > 0)
            {
                return khachHang;
            }
            else
            {
                return null;
            }
        }
        
        public KhachHang CapNhatKhachHang(KhachHang khachHang)
        {
            DataTable dataTable = new DataTable();
            
            String query = $"UPDATE tbl_KhachHang " +
                           $"SET tenKH = N'{khachHang.TenKh}', " +
                           $"cccd = '{khachHang.Cccd}', " +
                           $"email = '{khachHang.Email}', " +
                           $"sdt = '{khachHang.Sdt}', " +
                           $"diaChi = N'{khachHang.DiaChi}' " +
                           $"WHERE maKH = '{khachHang.MaKh}'";

            int soBanGhiThayDoi = 0;
            
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                base.OpenConnection();
                soBanGhiThayDoi = command.ExecuteNonQuery();
                base.CloseConnection();

            }
            
            if (soBanGhiThayDoi > 0)
            {
                return khachHang;
            }
            else
            {
                return null;
            }
        }

        public KhachHang TimKiemKhachHang(string cccd)
        {
            KhachHang khachHang = new KhachHang();
            
            DataTable dataTable = new DataTable();
            base.OpenConnection();
            String query = $"SELECT * FROM tbl_KhachHang " +
                           $"WHERE cccd = '{cccd}' ";
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    khachHang.MaKh = dataTable.Rows[0]["maKH"].ToString();
                    khachHang.TenKh = dataTable.Rows[0]["tenKH"].ToString();
                    khachHang.Cccd = dataTable.Rows[0]["cccd"].ToString();
                    khachHang.Email = dataTable.Rows[0]["email"].ToString();
                    khachHang.Sdt = dataTable.Rows[0]["sdt"].ToString();
                    khachHang.DiaChi = dataTable.Rows[0]["diaChi"].ToString();
                }
            }
            base.CloseConnection();
            if (khachHang.MaKh != null)
            {
                return khachHang;

            }
            else
            {
                return null;
            }
        }
    }
}