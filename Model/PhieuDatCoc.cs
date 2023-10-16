using System;

namespace QL_Thue_Xe_Dap.Model
{
    public class PhieuDatCoc
    {
        private string maPhieu;
        private string maKH;
        private string maNV;
        private DateTime ngayDatCoc;
        private Double tongTien;

        public PhieuDatCoc()
        {
        }

        public string MaPhieu
        {
            get => maPhieu;
            set => maPhieu = value;
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

        public DateTime NgayDatCoc
        {
            get => ngayDatCoc;
            set => ngayDatCoc = value;
        }

        public Double TongTien
        {
            get => tongTien;
            set => tongTien = value;
        }
    }
}