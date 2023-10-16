using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using QL_Thue_Xe_Dap.Model;
using QL_Thue_Xe_Dap.Repository;

namespace QL_Thue_Xe_Dap.Servive
{
    public class XeService
    {
        private XeRepository xeRepository;

        public XeService()
        {
            xeRepository = new XeRepository();
        }

        public DataTable GetLoaiXeChuaThue()
        {
            return xeRepository.GetLoaiXeChuaThue();
        }

        public DataTable GetXeChuaThueTheoLoai(string loaiXe)
        {
            return xeRepository.GetXeChuaThueTheoLoai(loaiXe);
        }

        public DataTable ConvertListXeToDataTable(List<Xe> listXe, int gioThueXe)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaXe", typeof(string));
            dataTable.Columns.Add("TenXe", typeof(string));
            dataTable.Columns.Add("TrangThai", typeof(int));
            dataTable.Columns.Add("TenLoai", typeof(string));
            dataTable.Columns.Add("GiaXe", typeof(double));
            dataTable.Columns.Add("GiaThue", typeof(double));
            dataTable.Columns.Add("Tien Dat Coc", typeof(double));
            dataTable.Columns.Add("Thanh Tien Gia Thue", typeof(double));


            foreach (Xe xe in listXe)
            {
                dataTable.Rows.Add(  xe.MaXe, 
                    xe.TenXe,
                    xe.TrangThai,
                    xe.TenLoai,
                    xe.GiaXe, 
                    xe.GiaThue,
                    xe.GiaXe*0.5, 
                    gioThueXe * xe.GiaThue);
            }
            
            return dataTable;
        }

        public Xe ConvertRowViewToXe(DataRowView dataRowView)
        {
            Xe xe = new Xe();

            DataRow row = dataRowView.Row;

            // Lấy các giá trị cụ thể từ DataRow
            xe.MaXe = row["maXe"].ToString();
            xe.TenXe = row["tenXe"].ToString();
            xe.TrangThai = bool.Parse(row["trangThai"].ToString());
            xe.TenLoai = row["tenLoai"].ToString();
            xe.GiaXe = Double.Parse(row["giaXe"].ToString());
            xe.GiaThue = Double.Parse(row["giaThue"].ToString());
            xe.MoTa = row["moTa"].ToString();
            
            return xe;
        }

        public DataTable LocXeDaTonTaiTrongList(DataTable dataTable, List<Xe> listXe)
        {
            List<string> listMaXe = listXe.Select(xe => xe.MaXe).ToList();

            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                string maXeInDataTable = dataTable.Rows[i]["maXe"].ToString();

                if (listMaXe.Contains(maXeInDataTable))
                {
                    dataTable.Rows.RemoveAt(i);
                }
            }

            return dataTable;
        }
    }
}