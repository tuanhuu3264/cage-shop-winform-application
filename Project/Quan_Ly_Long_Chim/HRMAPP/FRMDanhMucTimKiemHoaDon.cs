using BusinessObject.Models;
using HRMDAO;
using HRMService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMAPP
{
    public partial class FRMDanhMucTimKiemHoaDon : Form
    {
        private IOrderServices orderServices;
        private ICustomerServices customerServices;
        private IStaffServices staffServices;
        public FRMDanhMucTimKiemHoaDon()
        {
            InitializeComponent();
            orderServices = new OrderServices();
            customerServices = new CustomerServices();
            staffServices = new StaffServices();
        }

        private void FRMDanhMucTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            cbo_maHoaDon.DataSource = orderServices.listOrders();
            cbo_maHoaDon.DisplayMember = "id";
            cbo_maHoaDon.SelectedIndex = -1;
            cbo_maKhachHang.DataSource = customerServices.listCustomers();
            cbo_maKhachHang.DisplayMember = "id";
            cbo_maKhachHang.SelectedIndex = -1;
            cbo_maNhanVien.DataSource = staffServices.listStaffs();
            cbo_maNhanVien.DisplayMember = "id";
            cbo_maNhanVien.SelectedIndex = -1;

        }
        private void resetValues()
        {
            cbo_maHoaDon.Text = "";
            cbo_maKhachHang.Text = "";
            cbo_maNhanVien.Text = "";
            txt_nam.Text = "";
            txt_thang.Text = "";

            cbo_maHoaDon.Focus();
        }
        private void loadDataGridView()
        {
            dgv_hoaDon.Columns[0].HeaderText = "Mã HĐB";
            dgv_hoaDon.Columns[1].HeaderText = "Mã nhân viên";
            dgv_hoaDon.Columns[2].HeaderText = "Ngày bán";
            dgv_hoaDon.Columns[3].HeaderText = "Mã khách";
            dgv_hoaDon.Columns[4].HeaderText = "Tổng tiền";
            dgv_hoaDon.Columns[0].Width = 150;
            dgv_hoaDon.Columns[1].Width = 100;
            dgv_hoaDon.Columns[2].Width = 80;
            dgv_hoaDon.Columns[3].Width = 80;
            dgv_hoaDon.Columns[4].Width = 80;
            dgv_hoaDon.AllowUserToAddRows = false;
            dgv_hoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_timKiemHoaDon_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (string.IsNullOrWhiteSpace(cbo_maHoaDon.Text) && string.IsNullOrWhiteSpace(txt_thang.Text) &&
                string.IsNullOrWhiteSpace(txt_nam.Text) && string.IsNullOrWhiteSpace(cbo_maNhanVien.Text) &&
                string.IsNullOrWhiteSpace(cbo_maKhachHang.Text))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện để tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Fetching Initial Data
            IEnumerable<Order> orders = orderServices.listOrders();

            // Filtering based on Search Criteria
            if (!string.IsNullOrWhiteSpace(cbo_maHoaDon.Text))
            {
                orders = orders.Where(o => o.Id == cbo_maHoaDon.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(txt_thang.Text))
            {
                if (int.TryParse(txt_thang.Text, out int month))
                {
                    if (month < 1 || month > 12)
                    {
                        MessageBox.Show("Tháng không phù hợp. Vui lòng nhập lại");
                        return;
                    }
                    orders = orders.Where(o => o.DateBuy.Value.Month == month);
                }
                else
                {
                    MessageBox.Show("Tháng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(txt_nam.Text))
            {
                if (int.TryParse(txt_nam.Text, out int year))
                {
                    if (year < 0)
                    {
                        MessageBox.Show("Năm không phù hợp. Vui lòng nhập lại");
                        return;
                    }
                    orders = orders.Where(o => o.DateBuy.Value.Year == year);
                }
                else
                {
                    MessageBox.Show("Năm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(cbo_maNhanVien.Text))
            {
                orders = orders.Where(o => o.IdStaff == cbo_maNhanVien.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(cbo_maKhachHang.Text))
            {
                orders = orders.Where(o => o.IdCustomer == cbo_maKhachHang.Text.Trim());
            }

            // Binding the Filtered Data to DataGridView
            BindingSource newS = new BindingSource();
            newS.DataSource = orders.Select(m => new
            {
                m.Id,
                m.DateBuy,
                m.Total,
                m.IdCustomer,
                m.IdStaff
            });
            dgv_hoaDon.DataSource = newS;

            // Displaying Messages based on Search Results
            if (!orders.Any())
            {
                MessageBox.Show("Không có hóa đơn nào được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetValues();
            }
            else
            {
                MessageBox.Show($"Có {orders.Count()} hóa đơn được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetValues();
            }


        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_hoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
