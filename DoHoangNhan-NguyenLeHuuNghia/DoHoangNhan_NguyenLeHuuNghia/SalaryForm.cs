using DoHoangNhan_NguyenLeHuuNghia.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoangNhan_NguyenLeHuuNghia
{
    public partial class SalaryForm : Form
    {
        BindingSource salaryBinding = new BindingSource();
        public SalaryForm()
        {
            InitializeComponent();
            LoadCbbYear();
            cbbMonth.SelectedIndex = 10;
            cbbYear.SelectedIndex = 0;
            LoadTotalSalary();
            AddBinding();
        }
        private void LoadCbbYear()
        {
            cbbYear.DataSource = TimeKeepingBLL.Instance.GetListYear();
        }
        private void AddBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", drvTotalSalary.DataSource, "userName"));
            txtDisplayName.DataBindings.Add(new Binding("Text", drvTotalSalary.DataSource, "Tên nhân viên"));
        }
        private void LoadTotalSalary()
        {
            drvTotalSalary.DataSource = salaryBinding;
            string month = cbbMonth.Text;
            string year = cbbYear.SelectedValue.ToString();
            salaryBinding.DataSource = TimeKeepingBLL.Instance.GetTotalSalary(month, year);
            DataTable dt = (DataTable)salaryBinding.DataSource;
            float totalSalary = 0;
            foreach (DataRow dr in dt.Rows)
            {
                float salary;
                if (float.TryParse(dr["Lương"].ToString(), out salary))
                {
                    totalSalary += salary;
                }
                else
                {
                    Console.WriteLine($"Không thể chuyển đổi '{dr["Lương"]}' sang kiểu float.");
                }
            }
            lblTotalPrice1.Text = string.Format("{0:N0}", totalSalary);
        }

        private int selectedMonth;
        private int selectedYear;
        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbbMonth.Text, out int month))
            {
                selectedMonth = month;
            }
            LoadTotalSalary();
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbbYear.SelectedValue.ToString(), out int year))
            {
                selectedYear = year;
            }
            LoadTotalSalary();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                drvPersonalSalary.DataSource = null;
                return;
            }
            else
            {
                string month = cbbMonth.Text;
                string year = cbbYear.SelectedValue.ToString();
                drvPersonalSalary.DataSource = TimeKeepingBLL.Instance.GetTimeKeepingByUserName(txtUserName.Text, month, year);
            }
        }

        private void iconButtonXoaSF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này và bảng lương của họ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string userName = txtUserName.Text;
                if (!string.IsNullOrEmpty(userName))
                {
                    TimeKeepingBLL.Instance.DeleteTimeKeepingByUserName(userName);
                    MessageBox.Show("Đã xóa nhân viên và bảng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTotalSalary();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
