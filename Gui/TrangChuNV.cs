using System;
using System.Windows.Forms;
using QL_Thue_Xe_Dap.Servive;

namespace QL_Thue_Xe_Dap
{
    public partial class TrangChuNV : Form
    {
        private Form index;
        
        private NhanVienService nhanVienService = new NhanVienService();
        
        public TrangChuNV()
        {
            InitializeComponent();
        }


        private void TrangChuNV_Load(object sender, EventArgs e)
        {
            ThueXe thueXe = new ThueXe();
            thueXe.MdiParent = this;
            thueXe.FormBorderStyle = FormBorderStyle.None;
            thueXe.Show();
            index = thueXe;
            
        }
        
        
        private void TaoMdiParent(Form formMdiParent)
        {
            index.Close();
            formMdiParent.MdiParent = this;
            formMdiParent.FormBorderStyle = FormBorderStyle.None;
            formMdiParent.TopLevel = false;
            formMdiParent.Dock = DockStyle.Fill;
            formMdiParent.Show();
            index = formMdiParent;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Chắc chắn muốn đăng xuất"
                , "Đăng Xuất :(", MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation
                , MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                nhanVienService.DangXuat();
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Hide();
            }
        }

        private void thuêXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThueXe thueXe = new ThueXe();
            TaoMdiParent(thueXe);
        }
    }
}