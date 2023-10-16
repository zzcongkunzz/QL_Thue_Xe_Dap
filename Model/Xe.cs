using System;
using System.IO;

namespace QL_Thue_Xe_Dap.Model
{
    public class Xe
    {
        private string maXe;
        private string tenXe;
        private bool trangThai;
        private string tenLoai;
        private Double giaXe;
        private Double giaThue;
        private string moTa;

        public Xe() { }

        public string MaXe
        {
            get => maXe;
            set => maXe = value;
        }

        public string TenXe
        {
            get => tenXe;
            set => tenXe = value;
        }

        public bool TrangThai
        {
            get => trangThai;
            set => trangThai = value;
        }

        public string TenLoai
        {
            get => tenLoai;
            set => tenLoai = value;
        }

        public double GiaXe
        {
            get => giaXe;
            set => giaXe = value;
        }

        public double GiaThue
        {
            get => giaThue;
            set => giaThue = value;
        }

        public string MoTa
        {
            get => moTa;
            set => moTa = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}