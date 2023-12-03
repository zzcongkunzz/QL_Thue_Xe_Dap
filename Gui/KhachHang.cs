using QL_Thue_Xe_Dap.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Thue_Xe_Dap.Gui
{
    public partial class KhachHang : Form
    {
        private KhachHangService khService;
        public KhachHang()
        {
            InitializeComponent();
            khService = new KhachHangService();
        }

        private void LoadTableKH()
        {
            dgvKH.DataSource = khService.GetDataKhachHang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            string cccd = txtSoCCCDKH.Text;
            string sdt = txtSoDienThoaiKH.Text;
            string email = txtEmailKH.Text;
            string diaChi = txtDiaChi.Text;
            string gioiTinh;
            if (rdbNam.Checked)
                gioiTinh = rdbNam.Text;
            else
                gioiTinh = rdbNu.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;

            Model.KhachHang khachHang = new Model.KhachHang("", tenKH, cccd, email, sdt, diaChi, gioiTinh, ngaySinh);
            if(khService.LuuKhachHang(khachHang))
            {
                MessageBox.Show("Lưu thông tin khách hàng thành công");
                LoadTableKH();
            }
            else
            {
                MessageBox.Show("Lỗi! vui lòng liên hệ với trung tâm tư vấn");
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadTableKH();
        }
    }
}
