using System.Configuration;
using System.Data;
using System;
using System.Configuration;
using System.Data.SqlClient;
using QL_Thue_Xe_Dap.Model;


namespace QL_Thue_Xe_Dap.Repository
{
    public class XeRepository : Repository
    {
        
        public XeRepository() : base()
        { }

        public DataTable GetLoaiXeChuaThue()
        {
            DataTable dataTable = new DataTable();
            base.OpenConnection();
            String query = $"SELECT DISTINCT tenLoai FROM tbl_Xe " +
                           $"WHERE trangThai = 0";
            
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            base.CloseConnection();
            return dataTable;
        }

        public DataTable GetXeChuaThueTheoLoai(string loaiXe)
        {
            DataTable dataTable = new DataTable();
            base.OpenConnection();
            String query = $"SELECT * FROM tbl_Xe " +
                           $"WHERE tenLoai = N'{loaiXe}' " +
                           $"AND trangThai = 0 ";
            
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            base.CloseConnection();
            return dataTable;
        }

        public bool CapNhatTrangThaiXe(string maXe)
        {
            DataTable dataTable = new DataTable();
            
            String query = $"UPDATE tbl_Xe " +
                           $"SET trangThai = 1 " +
                           $"WHERE maXe = '{maXe}' ";

            int soBanGhiThayDoi = 0;
            
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                base.OpenConnection();
                soBanGhiThayDoi = command.ExecuteNonQuery();
                base.CloseConnection();

            }

            return soBanGhiThayDoi > 0;
        }
    }
}