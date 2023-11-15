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
    public partial class FRMDanhMucNhanVien : Form
    {
        private IStaffServices staffServices;
        public FRMDanhMucNhanVien()
        {
            InitializeComponent();
            staffServices = new StaffServices();
            combox_Role.Items.Add("staff");
            combox_Role.Items.Add("manager");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FRMDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            txt_maNhanVien.Enabled = false;
            btn_luuNhanVien.Enabled = false;
            btn_boQua.Enabled = false;
            btn_suaNhanVien.Enabled = false;
            btn_xoaNhanVien.Enabled = false;
            txt_bangChu.Enabled = false;
            txt_luong.Enabled = false;
            masked_dienThoaiNhanVien.Enabled = false;
            txt_diaChi.Enabled = false;
            txt_anh.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgv_nhanVien.DataSource = staffServices.listStaffs().Select(s => new
            {
                s.Id,
                s.Name,
                s.Gender,
                s.Email,
                s.Address,
                s.Phone,
                s.DateBirth,
                s.DateWork,
                s.Salary,
                s.ImageUrl,
            }).ToList();
            dgv_nhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_nhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgv_nhanVien.Columns[2].HeaderText = "Giới tính";
            dgv_nhanVien.Columns[3].HeaderText = "Email";
            dgv_nhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgv_nhanVien.Columns[5].HeaderText = "Điện thoại";
            dgv_nhanVien.Columns[6].HeaderText = "Ngày sinh";
            dgv_nhanVien.Columns[7].HeaderText = "Ngày làm";
            dgv_nhanVien.Columns[8].HeaderText = "Lương";
            dgv_nhanVien.Columns[9].HeaderText = "Ảnh";
            dgv_nhanVien.Columns[0].Width = 100;
            dgv_nhanVien.Columns[1].Width = 150;
            dgv_nhanVien.Columns[2].Width = 100;
            dgv_nhanVien.Columns[3].Width = 150;
            dgv_nhanVien.Columns[4].Width = 100;
            dgv_nhanVien.Columns[5].Width = 100;
            dgv_nhanVien.Columns[6].Width = 100;
            dgv_nhanVien.Columns[7].Width = 100;
            dgv_nhanVien.Columns[8].Width = 100;
            dgv_nhanVien.AllowUserToAddRows = false;
            dgv_nhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void resetValue()
        {
            txt_maNhanVien.Text = "";
            txt_tenNhanVien.Text = "";
            txt_diaChi.Text = "";
            radio_nam.Checked = false;
            radio_nu.Checked = false;
            date_ngaySinh.Value = DateTime.Now;
            masked_dienThoaiNhanVien.Text = "";
            txt_anh.Text = "";
            picture_nhanVien.Image = null;
            txt_luong.Text = "0";
            txt_bangChu.Text = "";
            date_ngayLam.Value = DateTime.Now;
            txt_email.Text = "";
            txt_matKhau.Clear();

        }
        private void dgv_nhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_themNhanVien.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maNhanVien.Focus();
                return;
            }
            if (dgv_nhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_maNhanVien.Text = dgv_nhanVien.Rows[index].Cells["id"].Value.ToString();
                staff staff = staffServices.GetStaff(txt_maNhanVien.Text);
                txt_tenNhanVien.Text = staff.Name;
                if (staff.Gender== "Nam")
                {
                    radio_nam.Checked = true;
                }
                if (staff.Gender== "Nữ")
                {
                    radio_nu.Checked = true;
                }
                txt_email.Enabled = false;
                combox_Role.Text = staff.Role;
                txt_matKhau.Text = staff.Password;
                txt_email.Text = staff.Email;
                txt_diaChi.Text = staff.Address;
                masked_dienThoaiNhanVien.Text = staff.Phone;
                date_ngaySinh.Value = (DateTime)staff.DateBirth;
                date_ngayLam.Value = (DateTime)staff.DateWork;
                txt_luong.Text = staff.Salary.ToString();
                txt_anh.Text = staffServices.listStaffs().Where(s => s.Id == txt_maNhanVien.Text).Select(s => s.ImageUrl).FirstOrDefault() ?? string.Empty;
                picture_nhanVien.Image = Image.FromFile(txt_anh.Text);
            }

            btn_suaNhanVien.Enabled = true;
            btn_xoaNhanVien.Enabled = true;
            txt_luong.Enabled = true;
            txt_bangChu.Enabled = false;
            txt_diaChi.Enabled = true;
            masked_dienThoaiNhanVien.Enabled = true;
            btn_boQua.Enabled = true;
        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picture_nhanVien.Image = Image.FromFile(dlgOpen.FileName);
                txt_anh.Text = dlgOpen.FileName;
            }
        }

        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            btn_suaNhanVien.Enabled = false;
            btn_xoaNhanVien.Enabled = false;
            btn_boQua.Enabled = true;
            btn_luuNhanVien.Enabled = true;
            btn_themNhanVien.Enabled = false;
            txt_luong.Enabled = true;
            txt_bangChu.Enabled = false;
            txt_diaChi.Enabled = true;
            txt_email.Enabled = true;
            masked_dienThoaiNhanVien.Enabled = true;
            resetValue();
            txt_maNhanVien.Enabled = true;
            txt_maNhanVien.Focus();
        }

        private void btn_luuNhanVien_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (txt_maNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maNhanVien.Focus();
                return;
            }
            if (txt_tenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenNhanVien.Focus();
                return;
            }
            if (txt_diaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diaChi.Focus();
                return;
            }
            if (masked_dienThoaiNhanVien.Text == "(   )     -")
            {
                MessageBox.Show("Bạn cần phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                masked_dienThoaiNhanVien.Focus();
                return;
            }
            if (radio_nam.Checked == true)
            {
                gioiTinh = "Nam";

            }
            if (radio_nu.Checked == true)
            {
                gioiTinh = "Nữ";

            }
            if (txt_email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;

            }
            else
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txt_email.Text, pattern))
                {
                    MessageBox.Show("Email không hợp lệ, email phải theo format example@email.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                }
            }
            if (string.IsNullOrEmpty(txt_matKhau.Text))
            {
                MessageBox.Show("Bạn cần phải nhập mật khẩu cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matKhau.Focus();
                return;
            }
            if (txt_luong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập lương cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                masked_dienThoaiNhanVien.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_mo.Focus();
                return;
            }
            if (staffServices.listStaffs().Where(s => s.Id == txt_maNhanVien.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Đã tồn tại mã nhân viên, bạn cần nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maNhanVien.Focus();
                txt_maNhanVien.Text = "";
                return;
            }
            if (string.IsNullOrEmpty(combox_Role.Text))
            {
                MessageBox.Show("Chức vụ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combox_Role.Focus();
                return;
            }
            staff s = new staff
            {
                Id = txt_maNhanVien.Text,
                Email = txt_email.Text,
                Phone = masked_dienThoaiNhanVien.Text,
                Name = txt_tenNhanVien.Text,
                Address = txt_diaChi.Text,
                Gender = gioiTinh,
                DateWork = date_ngayLam.Value,
                Salary = (float)Convert.ToDouble(txt_luong.Text),
                DateBirth = date_ngaySinh.Value,
                ImageUrl = txt_anh.Text,
                Password = txt_matKhau.Text,
                Role=combox_Role.Text
            };
            staffServices.insertStaff(s);
            LoadDataGridView();
            resetValue();
            btn_themNhanVien.Enabled = true;
            btn_boQua.Enabled = false;
            btn_luuNhanVien.Enabled = false;
            txt_maNhanVien.Enabled = false;
            btn_suaNhanVien.Enabled = false;
            btn_xoaNhanVien.Enabled = false;
        }

        private void btn_suaNhanVien_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (dgv_nhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txt_matKhau.Text))
            {
                MessageBox.Show("Bạn cần phải nhập mật khẩu cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matKhau.Focus();
                return;
            }
            if (txt_maNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_tenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenNhanVien.Focus();
                return;
            }
            if (txt_diaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diaChi.Focus();
                return;
            }
            if (masked_dienThoaiNhanVien.Text == "(   )     -")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                masked_dienThoaiNhanVien.Focus();
                return;
            }
            if (radio_nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            if (radio_nu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            if (txt_email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;

            }
            else
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txt_email.Text, pattern))
                {
                    MessageBox.Show("Email không hợp lệ, email phải theo format example@email.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_email.Focus();
                }
            }
            if (txt_luong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập lương cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                masked_dienThoaiNhanVien.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_mo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(combox_Role.Text))
            {
                MessageBox.Show("Chức vụ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combox_Role.Focus();
                return;
            }
            staff s = new staff();
            s.Id = txt_maNhanVien.Text;
            s.Email = txt_email.Text;
            s.Phone = masked_dienThoaiNhanVien.Text;
            s.Name = txt_tenNhanVien.Text;
            s.Address = txt_diaChi.Text;
            s.Gender = gioiTinh;
            s.DateWork = date_ngayLam.Value;
            s.Salary = (float)Convert.ToDouble(txt_luong.Text);
            s.DateBirth = date_ngaySinh.Value;
            s.ImageUrl = txt_anh.Text;
            s.Password = txt_matKhau.Text;
            s.Role = combox_Role.Text;
            staffServices.updateStaff(s);
            LoadDataGridView();
            resetValue();
            txt_email.Enabled = false;
            btn_boQua.Enabled = false;
            btn_suaNhanVien.Enabled = false;
            btn_xoaNhanVien.Enabled = false;
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            if (combox_Role.Text.Equals("manager"))
            {
                MessageBox.Show("Không thể xóa quản lí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgv_nhanVien.Columns.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_maNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    staffServices.deleteStaff(txt_maNhanVien.Text);
                    LoadDataGridView();
                    resetValue();
                    btn_suaNhanVien.Enabled = false;
                    btn_xoaNhanVien.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa nhân viên mã " + txt_maNhanVien.Text + " này được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            resetValue();
            btn_boQua.Enabled = false;
            btn_themNhanVien.Enabled = true;
            btn_suaNhanVien.Enabled = false;
            btn_xoaNhanVien.Enabled = false;
            btn_luuNhanVien.Enabled = false;
            txt_maNhanVien.Enabled = false;
            txt_email.Enabled = false;
        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {
            if (txt_luong.Text == "")
            {
                txt_bangChu.Text = "";
            }
            else
            {
                txt_bangChu.Text = DataProvider.ChuyenSoSangChuoi(Double.Parse(txt_luong.Text.ToString()));
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            List<staff> staffs = new List<staff>();
            if (txt_tenNhanVien.Text == "" && txt_email.Text == "")
            {
                staffs = staffServices.listStaffs();
            }
            if (txt_tenNhanVien.Text != "")
            {
                staffs = staffServices.listStaffs().Where(s => s.Name.Contains(txt_tenNhanVien.Text)).ToList();
            }
            if (txt_email.Text != "")
            {
                staffs = staffServices.listStaffs().Where(s => s.Email.Contains(txt_tenNhanVien.Text)).ToList();
            }
            dgv_nhanVien.DataSource = staffs;
            if (dgv_nhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có " + dgv_nhanVien.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgv_nhanVien.DataSource = staffs;
            resetValue();
        }

        private void btn_hienThi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
