using System.Collections.Generic;
using QL_Thue_Xe_Dap.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_Thue_Xe_Dap.Repository
{
    public class HoaDonRepository : Repository
    {
        private XeRepository xeRepository;
        
        public HoaDonRepository() : base()
        {
            xeRepository = new XeRepository();
        }

        public HoaDon ThemHoaDon(KhachHang khachHang, List<Xe> listXe, int thoiGianThue) {
            
            DataTable dataTable = new DataTable();
           
            Guid randomGuid = Guid.NewGuid();
            DateTime currentTime = DateTime.Now;
            double tongTienXe = 0;

            HoaDon hoaDon = new HoaDon();
            
            foreach (Xe xe in listXe)
            {
                tongTienXe += (xe.GiaThue * thoiGianThue); 
            }

            hoaDon.MaHd = randomGuid.ToString();
            hoaDon.MaKh = khachHang.MaKh;
            hoaDon.MaNv = Properties.Settings.Default.MaNV;
            hoaDon.NgayThue = currentTime;
            hoaDon.NgayTra = currentTime.AddHours(thoiGianThue);
            hoaDon.TongTien = tongTienXe;
            
            String query = $"INSERT INTO tbl_HoaDonThueXe(maHoaDon, maKH, maNV, ngayThueXe, ngayTra, tongTien) " +
                           $"VALUES ('{hoaDon.MaHd}', " +
                           $"'{hoaDon.MaKh}', " +
                           $"'{hoaDon.MaNv}', " +
                           $"'{hoaDon.NgayThue}', " +
                           $"'{hoaDon.NgayTra}', " +
                           $"'{hoaDon.TongTien}'" +
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
                bool themThanhCong = ThemChiTietHoaDon(hoaDon.MaHd, listXe);

                if (themThanhCong)
                {
                    return hoaDon;
                }
                else
                {
                    XoaHoaDon(hoaDon.MaHd);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public bool ThemChiTietHoaDon(string maHD, List<Xe> listXe)
        {
            foreach (Xe xe in listXe)
            {
                String query = $"INSERT INTO tbl_ChiTietHoaDonThue(maHoaDon, maXe, giaThue) " +
                               $"VALUES ('{maHD}', '{xe.MaXe}', {xe.GiaThue})";
                
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

            foreach (Xe xe in listXe)
            {
                xeRepository.CapNhatTrangThaiXe(xe.MaXe);
            }

            return true;
        }


        public void XoaHoaDon(string maHD)
        {
            XoaChiTietHoaDon(maHD);
            
            String query = $"DELETE tbl_HoaDonThueXe " +
                           $"WHERE maHoaDon = {maHD}";
            
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                
                command.ExecuteNonQuery();
            }
            base.CloseConnection();
            
        }

        public void XoaChiTietHoaDon(string maHD)
        {
            String query = $"DELETE tbl_ChiTietHoaDonThue " +
                           $"WHERE maHoaDon = {maHD}";
            
            base.OpenConnection();
            using (SqlCommand command = new SqlCommand(query, base.Connection))
            {
                
                command.ExecuteNonQuery();
            }
            base.CloseConnection();
        }
    }
}