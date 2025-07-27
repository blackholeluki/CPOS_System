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
    public class AccountBLL
    {
        private static AccountBLL instance;

        public static AccountBLL Instance 
        { 
            get
            {
                if (instance == null) instance = new AccountBLL();
                return instance;
            }
            private set => instance = value; 
        }
        private AccountBLL() { }
        public bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }
        public Account GetAccountByUsername(string username)
        {
            return AccountDAL.Instance.GetAccountByUsername(username);
        }
        public DataTable GetAccountBySearch(string temp)
        {
            return AccountDAL.Instance.GetAccountBySearch(temp);
        }
        public DataTable GetAllAccount()
        {
            return AccountDAL.Instance.GetAccount();
        }
        public List<string> GetlistChucvu()
        {
            return AccountDAL.Instance.GetlistChucvu();
        }
        public DataTable GetListAccount()
        {
            return AccountDAL.Instance.GetListAccount();
        }
        public DataTable Timkiemnhanvien(string ten, string vaitro)
        {
            return AccountDAL.Instance.Timkiemnhanvien(ten, vaitro);
        }

    }
}
