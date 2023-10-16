using System.Collections.Generic;
using QL_Thue_Xe_Dap.Model;
using System;
using System.Data.SqlClient;
using System.Data;




namespace QL_Thue_Xe_Dap.Repository
{
    public class PhieuDatCocRepository : Repository
    {
        public PhieuDatCocRepository() : base()
        {
        }

        public PhieuDatCoc ThemPhieuDatCoc(KhachHang khachHang, List<Xe> listXe)
        {
            DataTable dataTable = new DataTable();
           
            Guid randomGuid = Guid.NewGuid();
            DateTime currentTime = DateTime.Now;
            double tongTienDatCoc = 0;

            PhieuDatCoc phieuDatCoc = new PhieuDatCoc();
            
            foreach (Xe xe in listXe)
            {
                tongTienDatCoc += (xe.GiaXe * 0.5); 
            }

            phieuDatCoc.MaPhieu = randomGuid.ToString();
            phieuDatCoc.MaKh = khachHang.MaKh;
            phieuDatCoc.MaNv = Properties.Settings.Default.MaNV;
            phieuDatCoc.NgayDatCoc = currentTime;
            phieuDatCoc.TongTien = tongTienDatCoc;
            
            String query = $"INSERT INTO tbl_PhieuDatCoc(maPhieu, maKH, maNV, ngayDatCoc, tongTien)  " +
                           $"VALUES ('{phieuDatCoc.MaPhieu}', " +
                           $"'{phieuDatCoc.MaKh}', " +
                           $"'{phieuDatCoc.MaNv}', " +
                           $"'{phieuDatCoc.NgayDatCoc}', " +
                           $"'{phieuDatCoc.TongTien}'" +
                           $")";

            int soBanGhiThayDoi = 0;
            
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                
                soBanGhiThayDoi = command.ExecuteNonQuery();
            }
            base.CloseConnection();

            if (soBanGhiThayDoi > 0)
            {
                bool themThanhCong = ThemChiTietPhieuDatCoc(phieuDatCoc.MaPhieu, listXe);

                if (themThanhCong)
                {
                    return phieuDatCoc;
                }
                else
                {
                    XoaPhieuDatCoc(phieuDatCoc.MaPhieu);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        
        public bool ThemChiTietPhieuDatCoc(string maPhieu, List<Xe> listXe)
        {
            foreach (Xe xe in listXe)
            {
                String query = $"INSERT INTO tbl_ChiTietPhieuDatCoc(maPhieu, maXe, tienDatCoc) " +
                               $"VALUES ('{maPhieu}', '{xe.MaXe}', {xe.GiaXe * 0.5})";
                
                base.OpenConnection();
                using (SqlCommand command = new SqlCommand(query, base.Connection))
                {

                    if (command.ExecuteNonQuery() <= 0)
                    {
                        return false;
                    }
                }
                base.CloseConnection();

            }
            

            return true;
        }

        
        public void XoaPhieuDatCoc(string maPhieu)
        {
            XoaChiTietPhieuDatCoc(maPhieu);
            
            String query = $"DELETE tbl_PhieuDatCoc " +
                           $"WHERE maPhieu = {maPhieu}";
            
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                
                command.ExecuteNonQuery();
            }
            base.CloseConnection();
            
        }

        public void XoaChiTietPhieuDatCoc(string maPhieu)
        {
            String query = $"DELETE tbl_ChiTietPhieuDatCoc " +
                           $"WHERE maPhieu = {maPhieu}";
            
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                
                command.ExecuteNonQuery();
            }
            base.CloseConnection();
        }
        
    }
}