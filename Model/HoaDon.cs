using System;

namespace QL_Thue_Xe_Dap.Model
{
    public class HoaDon
    {
        // mã hóa đơn
        private string maHD;
        private string maKH;
        private string maNV;
        private DateTime ngayThue;
        private DateTime ngayTra;
        private double tongTien;

        public HoaDon()
        {
        }

        public string MaHd
        {
            get => maHD;
            set => maHD = value;
        }

        public string MaKh
        {
            get => maKH;
            set => maKH = value;
        }

        public string MaNv
        {
            get => maNV;
            set => maNV = value;
        }

        public DateTime NgayThue
        {
            get => ngayThue;
            set => ngayThue = value;
        }

        public DateTime NgayTra
        {
            get => ngayTra;
            set => ngayTra = value;
        }

        public double TongTien
        {
            get => tongTien;
            set => tongTien = value;
        }
    }
}