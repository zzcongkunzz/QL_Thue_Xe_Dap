using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QL_Thue_Xe_Dap.Model;
using QL_Thue_Xe_Dap.Servive;

namespace QL_Thue_Xe_Dap
{
    public partial class ThueXe : Form
    {
        private XeService xeService;

        private TaoDonThueXeService taoDonThueXeService;
        
        private List<Xe> listXe;
        
        public ThueXe()
        {
            InitializeComponent();
            
            xeService = new XeService();
            taoDonThueXeService = new TaoDonThueXeService();
            listXe = new List<Xe>();
        }
        
        private void ThueXe_Load(object sender, EventArgs e)
        {
            this.cmbLoaiXe.DataSource = xeService.GetLoaiXeChuaThue();
            this.cmbLoaiXe.DisplayMember = "tenLoai";
            this.cmbLoaiXe.ValueMember = "tenLoai";

            LoadDataGridView();
        }

        private void textSoGioThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không phải số
            }

            TinhTongTien();
        }

        private void textSoGioThue_TextChanged(object sender, EventArgs e)
        {
            if (txtSoGioThue.Text == "" || (int.Parse(txtSoGioThue.Text) < 1))
            {
                    txtSoGioThue.Text = "1";
            }
            
            LoadDataGridView();
        }

        private void cmbLoaiXe_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCmbTenXe();
            
        }

        private void cmbTenXe_SelectedValueChanged(object sender, EventArgs e)
        {

           if (cmbTenXe.SelectedItem != null)
           {
               if (cmbTenXe.SelectedItem is DataRowView selectedRowView)
               {

                   Xe xe = xeService.ConvertRowViewToXe(selectedRowView);
                   
                   txtGiaThue.Text = xe.GiaThue.ToString();
                   txtTienDatCoc.Text = (0.5 * xe.GiaThue).ToString();
               }
           }
           
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (cmbTenXe.SelectedItem != null)
            {
                if (cmbTenXe.SelectedItem is DataRowView selectedRowView)
                {

                    Xe xe = xeService.ConvertRowViewToXe(selectedRowView);
                   
                    listXe.Add(xe);

                    LoadDataGridView();
                    LoadCmbTenXe();
                    TinhTongTien();

                }
            }
        }
        
        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (this.dgvDSXe.SelectedRows[0] != null)
            {
                DataGridViewRow selectedRow = this.dgvDSXe.SelectedRows[0];
                string maXe = selectedRow.Cells["MaXe"].Value.ToString();
                Xe xeToRemove = listXe.Find(x => x.MaXe == maXe);
                if (xeToRemove != null)
                {
                    listXe.Remove(xeToRemove);
                }
                
                LoadDataGridView();
                LoadCmbTenXe();
                TinhTongTien();
            }
        }

        private void LoadDataGridView()
        {
            if (int.TryParse(this.txtSoGioThue.Text, out int result))
            {
                this.dgvDSXe.DataSource = xeService.ConvertListXeToDataTable(listXe, result);
            }
        }

        private void LoadCmbTenXe()
        {
            this.cmbTenXe.Text = "";
            
            string tenLoaiXe;
            try
            {
                tenLoaiXe = this.cmbLoaiXe.SelectedValue.ToString();
                DataTable dataTable = xeService.GetXeChuaThueTheoLoai(tenLoaiXe);
                this.cmbTenXe.DataSource = xeService.LocXeDaTonTaiTrongList(dataTable, listXe);
                this.cmbTenXe.DisplayMember = "tenXe";
                this.cmbTenXe.ValueMember = "maXe";
            }
            catch
            {
                
            }

            if (cmbTenXe.Text == "")
            {
                this.txtGiaThue.Text = "";
                this.txtTienDatCoc.Text = "";
            }
        }

        private void TinhTongTien()
        {
            double tongTienXe = 0; 
            if (int.TryParse(this.txtSoGioThue.Text, out int result))
            {
                foreach (Xe xe in listXe)
                {
                    tongTienXe += (xe.GiaThue * result + xe.GiaXe * 0.5); 
                }
            }

            this.txtTongTien.Text = tongTienXe.ToString();
        }

        private void btnTaoDonThueXe_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();

            khachHang.TenKh = this.txtTenKH.Text;
            khachHang.Cccd = this.txtSoCCCDKH.Text;
            khachHang.Email = this.txtEmailKH.Text;
            khachHang.Sdt = this.txtSoDienThoaiKH.Text;
            khachHang.DiaChi = this.txtDiaChi.Text;

            if (int.TryParse(this.txtSoGioThue.Text, out int result))
            {
                if (taoDonThueXeService.ThucThi(khachHang, listXe, result))
                {
                    MessageBox.Show("tạo đơn thuê xe thành công!");
                    
                }
                else
                {
                    MessageBox.Show("tạo đơn thuê xe thất bại!");
                }
            }
            else
            {
                MessageBox.Show("thời gian thuê không hợp lệ");
            }
            
        }
    }
}