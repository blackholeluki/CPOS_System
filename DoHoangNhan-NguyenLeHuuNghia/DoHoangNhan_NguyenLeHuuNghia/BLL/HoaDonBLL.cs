using DoHoangNhan_NguyenLeHuuNghia.DAL;
using DoHoangNhan_NguyenLeHuuNghia.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoHoangNhan_NguyenLeHuuNghia.BLL
{
    public class HoaDonBLL
    {
        private static HoaDonBLL instance;

        public static HoaDonBLL Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonBLL();
                return instance;
            }
            private set => instance = value;
        }
        public HoaDonBLL() { }
        public List<HoaDon> GetlistHoaDon(string idtable)
        {
            return HoaDonDAL.Instance.GetlistHoaDon(idtable);
        }
    }
}
