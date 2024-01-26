using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUSS
{
    public class CT_HoaDonBUS
    {
        public List<CT_HoaDonDTO> Load(int id)
        {
            return CT_HoaDonDAO.Instance.GetList(id);
        }

        public void SuaSoluongSanPhamCTHD(int mahoadon, int masanpham, int soluong)
        {
            CT_HoaDonDAO.Instance.SuaSoluongSanPhamCTHD(mahoadon, masanpham, soluong);
        }

        public void ThemVaoCT_HoaDon(int mahoadon, int masanpham, int soluiong)
        {
            CT_HoaDonDAO.Instance.ThemVaoCT_HoaDon(mahoadon,masanpham, soluiong);
        }

        public void XoaCTHD(int mahoadon, int masanpham)
        {
            CT_HoaDonDAO.Instance.XoaCTHD(mahoadon,masanpham);
        }

        public void SuaSoluongSanPhamThem(int mahoadon, int masanpham, int soluong)
        {
            CT_HoaDonDAO.Instance.SuaSoluongSanPhamThem(mahoadon,masanpham, soluong);
        }
    }
}
