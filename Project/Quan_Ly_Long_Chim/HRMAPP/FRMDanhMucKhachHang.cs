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
    public partial class FRMDanhMucKhachHang : Form
    {
        private ICustomerServices customerServices;
        public FRMDanhMucKhachHang()
        {
            InitializeComponent();
            customerServices = new CustomerServices();
        }

        private void FRMDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            txt_maKhachHang.Enabled = false;
            btn_luuKhachHang.Enabled = false;
            btn_boQua.Enabled = false;
            txt_diaChiKhachHang.Enabled = false;
            masked_dienThoaiKhachHang.Enabled = false;
            btn_xoaKhachHang.Enabled = false;
            btn_suaKhachHang.Enabled = false;
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            dgv_khachHang.DataSource = customerServices.listCustomers();
            dgv_khachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgv_khachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgv_khachHang.Columns[2].HeaderText = "Địa chỉ";
            dgv_khachHang.Columns[3].HeaderText = "Điện thoại";
            dgv_khachHang.Columns[4].HeaderText = "Ngày tạo";
            dgv_khachHang.Columns[0].Width = 100;
            dgv_khachHang.Columns[1].Width = 150;
            dgv_khachHang.Columns[2].Width = 150;
            dgv_khachHang.Columns[3].Width = 150;
            dgv_khachHang.Columns[3].Width = 150;
            dgv_khachHang.AllowUserToAddRows = false;
            dgv_khachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void resetValues()
        {
            txt_maKhachHang.Text = "";
            txt_tenKhachHang.Text = "";
            txt_diaChiKhachHang.Text = "";
            masked_dienThoaiKhachHang.Text = "";
            date_ngayTao.Value = DateTime.Now;
        }

        private void btn_themKhachHang_Click(object sender, EventArgs e)
        {
            btn_suaKhachHang.Enabled = false;
            btn_xoaKhachHang.Enabled = false;
            btn_boQua.Enabled = true;
            btn_luuKhachHang.Enabled = true;
            btn_themKhachHang.Enabled = false;
            txt_diaChiKhachHang.Enabled = true;
            masked_dienThoaiKhachHang.Enabled = true;
            resetValues();
            txt_maKhachHang.Enabled = true;
            txt_maKhachHang.Focus();
        }

        private void dgv_khachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_themKhachHang.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maKhachHang.Focus();
                return;
            }
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_maKhachHang.Text = dgv_khachHang.Rows[index].Cells[0].Value.ToString();
                txt_tenKhachHang.Text = dgv_khachHang.Rows[index].Cells[1].Value.ToString();
                txt_diaChiKhachHang.Text = dgv_khachHang.Rows[index].Cells[2].Value.ToString();
                masked_dienThoaiKhachHang.Text = dgv_khachHang.Rows[index].Cells[3].Value.ToString();
                date_ngayTao.Value = DateTime.Parse(dgv_khachHang.Rows[index].Cells[4].Value.ToString());
            }
            btn_suaKhachHang.Enabled = true;
            btn_xoaKhachHang.Enabled = true;
            btn_boQua.Enabled = true;
            txt_diaChiKhachHang.Enabled = true;
            masked_dienThoaiKhachHang.Enabled = true;
        }

        private void btn_luuKhachHang_Click(object sender, EventArgs e)
        {
            if (txt_maKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maKhachHang.Focus();
                return;
            }
            if (txt_tenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenKhachHang.Focus();
                return;
            }
            if (txt_diaChiKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diaChiKhachHang.Focus();
                return;
            }
            if (masked_dienThoaiKhachHang.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                masked_dienThoaiKhachHang.Focus();
                return;
            }
            if (customerServices.listCustomers().Where(c => c.Id == txt_maKhachHang.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Đã tồn tại mã khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maKhachHang.Focus();
                return;
            }
            Customer c = new Customer
            {
                Id = txt_maKhachHang.Text,
                Name = txt_tenKhachHang.Text,
                Address = txt_diaChiKhachHang.Text,
                Phone = masked_dienThoaiKhachHang.Text,
                CreateAt = date_ngayTao.Value,
            };
            customerServices.insertCustomer(c);
            loadDataGridView();
            resetValues();
            btn_xoaKhachHang.Enabled = false;
            btn_themKhachHang.Enabled = true;
            btn_boQua.Enabled = false;
            btn_luuKhachHang.Enabled = false;
            btn_suaKhachHang.Enabled = false;
            txt_maKhachHang.Enabled = false;
        }

        private void btn_suaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgv_khachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_maKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenKhachHang.Focus();
                return;
            }
            if (txt_diaChiKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diaChiKhachHang.Focus();
                return;
            }
            if (masked_dienThoaiKhachHang.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                masked_dienThoaiKhachHang.Focus();
                return;
            }
            string ngayTao = date_ngayTao.Value.ToString("yyyy-MM-dd");
            Customer c = new Customer();
            c.Id = txt_maKhachHang.Text;
            c.Name = txt_tenKhachHang.Text;
            c.Address = txt_diaChiKhachHang.Text;
            c.Phone = masked_dienThoaiKhachHang.Text;
            c.CreateAt = date_ngayTao.Value;
            customerServices.updateCustomer(c);
            loadDataGridView();
            resetValues();
            btn_boQua.Enabled = false;
            btn_suaKhachHang.Enabled = false;
            btn_xoaKhachHang.Enabled = false;
        }

        private void btn_xoaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgv_khachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_maKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    customerServices.deteleCustomer(txt_maKhachHang.Text);
                    loadDataGridView();
                    resetValues();
                    btn_boQua.Enabled = false;
                    btn_suaKhachHang.Enabled = false;
                    btn_xoaKhachHang.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng mã " + txt_maKhachHang.Text + " này được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            resetValues();
            btn_boQua.Enabled = false;
            btn_themKhachHang.Enabled = true;
            btn_xoaKhachHang.Enabled = false;
            btn_suaKhachHang.Enabled = false;
            btn_luuKhachHang.Enabled = false;
            txt_maKhachHang.Enabled = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_timKiemKhachHang_Click(object sender, EventArgs e)
        {
            List<Customer> customers = new List<Customer>();
            if (txt_tenKhachHang.Text == "")
            {
                customers = customerServices.listCustomers();
            }
            if (txt_tenKhachHang.Text != "")
            {
                customers = customerServices.listCustomers().Where(c => c.Name.Contains(txt_tenKhachHang.Text)).ToList();
            }
            dgv_khachHang.DataSource = customers;
            if (dgv_khachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có " + dgv_khachHang.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            resetValues();
            btn_xoaKhachHang.Enabled = false;
            btn_suaKhachHang.Enabled = false;
        }

        private void btn_hienThiDS_Click(object sender, EventArgs e)
        {
            loadDataGridView();
            btn_luuKhachHang.Enabled = false;
            btn_boQua.Enabled = false;
            btn_xoaKhachHang.Enabled = false;
            btn_suaKhachHang.Enabled = false;
        }
    }
}
