using System.Collections.Generic;
using QL_Thue_Xe_Dap.Repository;

namespace QL_Thue_Xe_Dap.Model
{
    public class TaoDonThueXeService
    {
        private KhachHangRepository khachHangRepository;

        private HoaDonRepository hoaDonRepository;

        private PhieuDatCocRepository phieuDatCocRepository;
        
        public TaoDonThueXeService()
        {
            khachHangRepository = new KhachHangRepository();


            hoaDonRepository = new HoaDonRepository();

            phieuDatCocRepository = new PhieuDatCocRepository();
        }

        public bool ThucThi(KhachHang khachHang, List<Xe> listXe, int thoiGianThueXe)
        {
            KhachHang cheKhachHang = khachHangRepository.TimKiemKhachHang(khachHang.Cccd);

            if (cheKhachHang != null)
            {
                khachHang.MaKh = cheKhachHang.MaKh;
                
                khachHang = khachHangRepository.CapNhatKhachHang(khachHang);
            }
            else
            {
               khachHang = khachHangRepository.ThemKhachHang(khachHang);
            }

            HoaDon hoaDon =  hoaDonRepository.ThemHoaDon(khachHang, listXe, thoiGianThueXe);

            if (hoaDon != null)
            {
                PhieuDatCoc phieuDatCoc =  phieuDatCocRepository.ThemPhieuDatCoc(khachHang, listXe);

                if (phieuDatCoc != null)
                {
                    return true;
                }
                else
                {
                    hoaDonRepository.XoaHoaDon(hoaDon.MaHd);
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }
    }
}