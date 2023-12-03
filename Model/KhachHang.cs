using System;

namespace QL_Thue_Xe_Dap.Model
{
    public class KhachHang
    {
        private string maKH;
        private string tenKH;
        private string cccd;
        private string email;
        private string sdt;
        private string diaChi;
        private string gioiTinh;
        private DateTime ngaySinh;

        public KhachHang()
        {
        }

        public KhachHang(string maKH, string tenKH, string cccd, string email, string sdt, string diaChi, string gioiTinh, DateTime ngaySinh)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            Cccd = cccd;
            Email = email;
            Sdt = sdt;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public string MaKh
        {
            get => maKH;
            set => maKH = value;
        }

        public string TenKh
        {
            get => tenKH;
            set => tenKH = value;
        }

        public string Cccd
        {
            get => cccd;
            set => cccd = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }
        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }
        public DateTime NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }
    }
}