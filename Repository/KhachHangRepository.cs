using QL_Thue_Xe_Dap.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace QL_Thue_Xe_Dap.Repository
{
    public class KhachHangRepository : Repository
    {
        
        public KhachHangRepository() : base(){}

        public KhachHang ThemKhachHang(KhachHang khachHang)
        {
            Guid randomGuid = Guid.NewGuid();
            khachHang.MaKh = randomGuid.ToString();


            string proc = "Proc_Ins_KhachHang";

            int soBanGhiThayDoi = 0;
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(proc, base.Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ma", khachHang.MaKh);
                command.Parameters.AddWithValue("@ten", khachHang.TenKh);
                command.Parameters.AddWithValue("@cccd", khachHang.Cccd);
                command.Parameters.AddWithValue("@email", khachHang.Email);
                command.Parameters.AddWithValue("@sdt", khachHang.Sdt);
                command.Parameters.AddWithValue("@gioitinh", khachHang.GioiTinh);
                command.Parameters.AddWithValue("@ngaysinh", khachHang.NgaySinh);
                command.Parameters.AddWithValue("@diachi", khachHang.DiaChi);

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
            string proc = "Proc_Update_KhachHang";

            int soBanGhiThayDoi = 0;
            
            using (SqlCommand command = new SqlCommand(proc, base.Connection))
            {
                base.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ma", khachHang.MaKh);
                command.Parameters.AddWithValue("@ten", khachHang.TenKh);
                command.Parameters.AddWithValue("@cccd", khachHang.Cccd);
                command.Parameters.AddWithValue("@email", khachHang.Email);
                command.Parameters.AddWithValue("@sdt", khachHang.Sdt);
                command.Parameters.AddWithValue("@gioitinh", khachHang.GioiTinh);
                command.Parameters.AddWithValue("@ngaysinh", khachHang.NgaySinh);
                command.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
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

        public bool CheckExist(string maKH)
        {
            string proc = "Proc_GetDataByMa_KhachHang";
            string result = null;

            using (SqlCommand command = new SqlCommand(proc, base.Connection))
            {
                base.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ma", maKH);
                result = (string)command.ExecuteScalar();
                base.CloseConnection();
            }

            return result != null;
        }
        public DataTable GetKhachHangs()
        {
            string proc = "Proc_GetData_KhachHang";

            DataTable data = new DataTable();

            using (SqlCommand command = new SqlCommand(proc, base.Connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                
                using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(data);
                }
            }

            return data;
        }
    }
}