using System;

namespace QL_Thue_Xe_Dap.Model
{
    public class NhanVien
    {
        public NhanVien() { }
        
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string QuyenNV { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string SDTNV { get; set; }
        public string EmailNV { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}