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
            txt_tongTien.Enabled = false;
        }
        private void resetValues()
        {
            cbo_maHoaDon.Text = "";
            cbo_maKhachHang.Text = "";
            cbo_maNhanVien.Text = "";
            txt_nam.Text = "";
            txt_thang.Text = "";
            txt_tongTien.Text = "0";
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
            if ((cbo_maHoaDon.Text == "") && (txt_thang.Text == "") && (txt_nam.Text == "") && (cbo_maNhanVien.Text == "") && (cbo_maKhachHang.Text == "") && (txt_tongTien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbo_maHoaDon.Text != "")
            {
                dgv_hoaDon.DataSource = orderServices.listOrders().Where(o => o.Id == cbo_maHoaDon.Text).Select(o => new
                {
                    o.Id,
                    o.IdStaff,
                    o.DateBuy,
                    o.IdCustomer,
                    o.Total,
                }).ToList();
            }
            if (txt_thang.Text != "")
            {
                dgv_hoaDon.DataSource = orderServices.listOrders().Where(o => o.DateBuy.Value.Month == int.Parse(txt_thang.Text)).Select(o => new
                {
                    o.Id,
                    o.IdStaff,
                    o.DateBuy,
                    o.IdCustomer,
                    o.Total,
                }).ToList();
            }
            if (txt_nam.Text != "")
            {
                dgv_hoaDon.DataSource = orderServices.listOrders().Where(o => o.DateBuy.Value.Year == int.Parse(txt_nam.Text)).Select(o => new
                {
                    o.Id,
                    o.IdStaff,
                    o.DateBuy,
                    o.IdCustomer,
                    o.Total,
                }).ToList();
            }
            if (cbo_maNhanVien.Text != "")
            {
                dgv_hoaDon.DataSource = orderServices.listOrders().Where(o => o.IdStaff == cbo_maNhanVien.Text).Select(o => new
                {
                    o.Id,
                    o.IdStaff,
                    o.DateBuy,
                    o.IdCustomer,
                    o.Total,
                }).ToList();
            }
            if (cbo_maKhachHang.Text != "")
            {
                dgv_hoaDon.DataSource = orderServices.listOrders().Where(o => o.IdCustomer == cbo_maKhachHang.Text).Select(o => new
                {
                    o.Id,
                    o.IdStaff,
                    o.DateBuy,
                    o.IdCustomer,
                    o.Total,
                }).ToList();
            }

            if (dgv_hoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn nào được tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetValues();
            }
            else
            {

                MessageBox.Show("Có " + dgv_hoaDon.Rows.Count + " hóa đơn được tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDataGridView();
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
    }
}
