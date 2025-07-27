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
    public class FoodCategoryBLL
    {
        private static FoodCategoryBLL instance;

        public static FoodCategoryBLL Instance
        {
            get
            {
                if (instance == null) instance = new FoodCategoryBLL();
                return instance;
            }
            private set => instance = value;
        }
        public FoodCategoryBLL() { }
        public List<FoodCategory> GetListFoodCategory()
        {
            return FoodCategoryDAL.Instance.GetListFoodCategory();
        }
        public string GetNameCategorybyIDcate(string idcategory)
        {
            return FoodCategoryDAL.Instance.GetNameCategorybyIDcate(idcategory);
        }
        public bool checkCategoryExist(string name)
        {
            return FoodCategoryDAL.Instance.checkCategoryExist(name);
        }
        public void ThemDanhMuc(string name)
        {
            FoodCategoryDAL.Instance.ThemDanhMuc(name);
        }
        public void CapNhatDanhMuc(string name, string id)
        {
            FoodCategoryDAL.Instance.CapNhatDanhMuc(name, id);
        }
        public FoodCategory GetFoodCategorybyIDCate(string id)
        {
            return FoodCategoryDAL.Instance.GetFoodCategorybyIDCate(id);
        }
        public void XoaDanhMuc(string idcate)
        {
            FoodCategoryDAL.Instance.XoaDanhMuc(idcate);
        }
        public DataTable TimKiemDanhMuc(string name)
        {
            return FoodCategoryDAL.Instance.TimKiemDanhMuc(name);
        }
    }
}
