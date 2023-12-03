using QL_Thue_Xe_Dap.Model;
using QL_Thue_Xe_Dap.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Thue_Xe_Dap.Service
{
    public class KhachHangService
    {
        private KhachHangRepository _khRepository;
        public KhachHangService()
        {
            this._khRepository = new KhachHangRepository();
        }

        public bool LuuKhachHang(KhachHang khachHang)
        {
            KhachHang kh = _khRepository.ThemKhachHang(khachHang);
            return kh != null;
        }

        public DataTable GetDataKhachHang()
        {
            return _khRepository.GetKhachHangs();
        }
    }
}
