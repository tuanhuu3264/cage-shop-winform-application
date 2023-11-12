using BusinessObject.Models;
using HRMService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMAPP
{
    public partial class FRMLogin : Form
    {
        IStaffServices staffServices;
        public FRMLogin()
        {
            InitializeComponent();
            txt_Password.PasswordChar = '*';
            staffServices = new StaffServices();
        }

        private void bttn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text.Trim()))
            {
                MessageBox.Show("Không được để trống email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Không được để trống mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return;
            }

            string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Email.Text, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return;
            }
            staff account = staffServices.checkLogin(txt_Email.Text, txt_Password.Text);
            if (account == null)
            {
                MessageBox.Show("Sai email hoặc mật khẩu. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FRMTrangChu trangchu = new FRMTrangChu(account);
            this.Hide();
            trangchu.Show();
        }
    }
}
