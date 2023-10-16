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

        public KhachHang()
        {
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
    }
}