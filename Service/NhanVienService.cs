using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using QL_Thue_Xe_Dap.Model;
using QL_Thue_Xe_Dap.Repository;

namespace QL_Thue_Xe_Dap.Servive
{
    public class NhanVienService
    {
        private NhanVienRepository nhanVienRepository;

        public NhanVienService()
        {
            this.nhanVienRepository = new NhanVienRepository();
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            DataTable dataTable = nhanVienRepository.KiemTraDangNhap(taiKhoan, encryptionSHA(matKhau));
            
            if (dataTable.Rows.Count > 0)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNV = dataTable.Rows[0]["maNV"].ToString();
                nhanVien.TenNV = dataTable.Rows[0]["tenNV"].ToString();
                nhanVien.TaiKhoan = dataTable.Rows[0]["taiKhoan"].ToString();
                nhanVien.MatKhau = dataTable.Rows[0]["matKhau"].ToString();
                nhanVien.QuyenNV =  dataTable.Rows[0]["quyen"].ToString();
                
                Properties.Settings.Default.MaNV = nhanVien.MaNV;
                Properties.Settings.Default.TenNV = nhanVien.TenNV;
                Properties.Settings.Default.Quyen = nhanVien.QuyenNV;
                Properties.Settings.Default.TaiKhoan = nhanVien.TaiKhoan;
                Properties.Settings.Default.MatKhau = nhanVien.MatKhau;
                Properties.Settings.Default.Save();
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DangXuat()
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }
        
        private string encryptionSHA(string pass)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(pass);

            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}