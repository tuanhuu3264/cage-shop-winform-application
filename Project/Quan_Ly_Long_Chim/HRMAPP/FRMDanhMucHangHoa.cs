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
    public partial class FRMDanhMucHangHoa : Form
    {
        private IProductServices productServices;
        private ITypeProductServices typeProductServices;
        public FRMDanhMucHangHoa()
        {
            InitializeComponent();
            productServices = new ProductServices();
            typeProductServices = new TypeProductServices();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRMDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            txt_maHang.Enabled = false;
            btn_suaHangHoa.Enabled = false;
            btn_boQua.Enabled = false;
            btn_luuHangHoa.Enabled = false;
            btn_xoaHangHoa.Enabled = false;
            txt_anh.Enabled = false;
            txt_tenChatLieu.Enabled = false;
            txt_soLuong.Enabled = false;
            txt_donBan.Enabled = false;
            txt_donGia.Enabled = false;
            txt_bangChuDonBan.Enabled = false;
            txt_bangChuDonNhap.Enabled = false;
            txt_soLuong.Enabled = false;
            LoadDataGridView();
            resetValues();
        }
        private void resetValues()
        {
            txt_maHang.Text = "";
            txt_tenHang.Text = "";
            cbo_maChatLieu.Text = "";
            txt_tenChatLieu.Text = "";
            txt_soLuong.Text = "0";
            txt_donGia.Text = "0";
            txt_donBan.Text = "0";
            txt_soLuong.Enabled = true;
            txt_donGia.Enabled = false;
            txt_donBan.Enabled = false;
            txt_anh.Text = "";
            txt_anh.Enabled = false;
            picture_hang.Image = null;
            txt_ghiChu.Text = "";
        }
        private void LoadDataGridView()
        {
            dgv_hang.DataSource = productServices.listProducts();
            dgv_hang.Columns[0].HeaderText = "Mã hàng";
            dgv_hang.Columns[1].HeaderText = "Tên hàng";
            dgv_hang.Columns[2].HeaderText = "Ảnh";
            dgv_hang.Columns[3].HeaderText = "Đơn giá nhập";
            dgv_hang.Columns[4].HeaderText = "Đơn giá bán";
            dgv_hang.Columns[5].HeaderText = "Số lượng";
            dgv_hang.Columns[6].HeaderText = "Mô tả";
            dgv_hang.Columns[7].HeaderText = "Mã chất liệu";
            dgv_hang.Columns[0].Width = 100;
            dgv_hang.Columns[1].Width = 140;
            dgv_hang.Columns[2].Width = 100;
            dgv_hang.Columns[3].Width = 80;
            dgv_hang.Columns[4].Width = 100;
            dgv_hang.Columns[5].Width = 100;
            dgv_hang.Columns[6].Width = 200;
            dgv_hang.Columns[7].Width = 300;
            dgv_hang.AllowUserToAddRows = false;
            dgv_hang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_themHanghoa_Click(object sender, EventArgs e)
        {
            btn_suaHangHoa.Enabled = false;
            btn_xoaHangHoa.Enabled = false;
            btn_boQua.Enabled = true;
            btn_luuHangHoa.Enabled = true;
            btn_themHanghoa.Enabled = false;
            resetValues();
            txt_maHang.Enabled = true;
            txt_maHang.Focus();
            txt_soLuong.Enabled = true;
            txt_donBan.Enabled = true;
            txt_donGia.Enabled = true;
            txt_bangChuDonNhap.Enabled = false;
            txt_bangChuDonBan.Enabled = false;
        }

        private void btn_xoaHangHoa_Click(object sender, EventArgs e)
        {
            if (dgv_hang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_maHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xóa món hàng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    productServices.deleteProduct(txt_maHang.Text);
                    LoadDataGridView();
                    resetValues();
                    btn_boQua.Enabled = false;
                    btn_xoaHangHoa.Enabled = false;
                    btn_suaHangHoa.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thẻ xóa món hàng mã " + txt_maHang.Text + " này được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_suaHangHoa_Click(object sender, EventArgs e)
        {
            if (dgv_hang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_maHang.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tenHang.Text))
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cbo_maChatLieu.Text))
            {
                MessageBox.Show("Bạn phải chọn chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_maChatLieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_anh.Text))
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_anh.Focus();
                return;
            }

            if (productServices == null)
            {
                MessageBox.Show("ProductServices is not initialized.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbo_maChatLieu.Text == null)
            {
                MessageBox.Show("Bạn phải chọn một chất liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_maChatLieu.Focus();
                return;
            }

            Product p = new Product();
            p.Id = txt_maHang.Text;
            p.Name = txt_tenHang.Text;
            p.ImageUrl = txt_anh.Text;
            p.PriceImport = float.Parse(txt_donGia.Text);
            p.PriceExport = float.Parse(txt_donBan.Text);
            p.Quantity = int.Parse(txt_soLuong.Text);
            p.Description = txt_ghiChu.Text;
            p.IdTypeProduct = cbo_maChatLieu.Text;


            try
            {
                productServices.updateProduct(p);
                LoadDataGridView();
                resetValues();
                btn_boQua.Enabled = false;
                btn_xoaHangHoa.Enabled = false;
                btn_suaHangHoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_luuHangHoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maHang.Text))
            {
                MessageBox.Show("Bạn phải nhập mã hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tenHang.Text))
            {
                MessageBox.Show("Bạn phải nhập tên hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenHang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cbo_maChatLieu.Text))
            {
                MessageBox.Show("Bạn phải chọn chất liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_maChatLieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_anh.Text))
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_mo.Focus();
                return;
            }

            if (productServices.checkID(txt_maHang.Text))
            {
                MessageBox.Show("Mã hàng này đã tồn tại. Vui lòng chọn mã hàng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maHang.Focus();
                return;
            }
            Product p = new Product
            {
                Id = txt_maHang.Text,
                Name = txt_tenHang.Text,
                ImageUrl = txt_anh.Text,
                PriceImport = float.Parse(txt_donGia.Text),
                PriceExport = float.Parse(txt_donBan.Text),
                Quantity = int.Parse(txt_soLuong.Text),
                Description = txt_ghiChu.Text,
                IdTypeProduct = ((TypeProduct)cbo_maChatLieu.SelectedItem).Id
            };

            try
            {
                productServices.insertProduct(p);
                LoadDataGridView();
                resetValues();
                btn_xoaHangHoa.Enabled = false;
                btn_themHanghoa.Enabled = true;
                btn_suaHangHoa.Enabled = false;
                btn_boQua.Enabled = false;
                btn_luuHangHoa.Enabled = false;
                txt_maHang.Enabled = false;
                txt_anh.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            resetValues();
            btn_suaHangHoa.Enabled = false;
            btn_xoaHangHoa.Enabled = false;
            btn_themHanghoa.Enabled = true;
            btn_boQua.Enabled = false;
            btn_luuHangHoa.Enabled = false;
            txt_maHang.Enabled = false;
            txt_anh.Enabled = false;
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            List<Product> productDTOs = new List<Product>();
            if ((txt_tenHang.Text == "") && (cbo_maChatLieu.Text == ""))
            {
                productDTOs = productServices.listProducts();
            }
            if (txt_tenHang.Text != "")
            {
                productDTOs = productServices.listProducts().Where(p => p.Name.Contains(txt_tenHang.Text)).ToList();
            }
            if (cbo_maChatLieu.Text != "")
            {
                productDTOs = productServices.listProducts().Where(p => p.IdTypeProduct.Contains(txt_tenHang.Text)).ToList();
            }
            dgv_hang.DataSource = productDTOs;
            if (dgv_hang.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có " + dgv_hang.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgv_hang.DataSource = productDTOs;
            resetValues();
        }

        private void btn_hienThiDS_Click(object sender, EventArgs e)
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

        private void dgv_hang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_themHanghoa.Enabled == false)
            {
                MessageBox.Show("Đang ở trạng thái thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maHang.Focus();
                return;
            }
            if (dgv_hang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_maHang.Text = dgv_hang.Rows[index].Cells["Id"].Value.ToString();
                txt_tenHang.Text = dgv_hang.Rows[index].Cells["Name"].Value.ToString();
                cbo_maChatLieu.Text = dgv_hang.Rows[index].Cells["IdTypeProduct"].Value.ToString();
                txt_soLuong.Text = dgv_hang.Rows[index].Cells["Quantity"].Value.ToString();
                txt_donGia.Text = dgv_hang.Rows[index].Cells["PriceImport"].Value.ToString();
                txt_donBan.Text = dgv_hang.Rows[index].Cells["PriceExport"].Value.ToString(); ;
                txt_anh.Text = dgv_hang.Rows[index].Cells["ImageUrl"].Value.ToString(); ;
                /*picture_hang.Image = Image.FromFile(txt_anh.Text);*/
                txt_tenChatLieu.Text = typeProductServices.listTypeProduct().Where(t => t.Id == cbo_maChatLieu.Text).Select(t => t.Name).FirstOrDefault();
                txt_ghiChu.Text = dgv_hang.Rows[index].Cells["Description"].Value.ToString(); ;
            }
            btn_suaHangHoa.Enabled = true;
            btn_xoaHangHoa.Enabled = true;
            txt_donBan.Enabled = true;
            txt_donGia.Enabled = true;
            txt_tenChatLieu.Enabled = false;
            txt_bangChuDonNhap.Enabled = false;
            txt_bangChuDonBan.Enabled = false;
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
                picture_hang.Image = Image.FromFile(dlgOpen.FileName);
                txt_anh.Text = dlgOpen.FileName;
            }
        }

        private void cbo_maChatLieu_DropDown(object sender, EventArgs e)
        {
            List<TypeProduct> idProduct = new List<TypeProduct>();
            idProduct = typeProductServices.listTypeProduct();
            cbo_maChatLieu.DataSource = idProduct;
            cbo_maChatLieu.DisplayMember = "id";
        }

        private void cbo_maChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_maChatLieu.Text == "")
            {
                txt_tenChatLieu.Text = "";
            }
            txt_tenChatLieu.Text = typeProductServices.listTypeProduct().Where(t => t.Id == cbo_maChatLieu.Text).Select(t => t.Name).FirstOrDefault();
        }

        private void txt_donGia_TextChanged(object sender, EventArgs e)
        {
            if (txt_donGia.Text == "")
            {
                txt_bangChuDonNhap.Text = "";
            }
            else
            {
                txt_bangChuDonNhap.Text = DataProvider.ChuyenSoSangChuoi(Double.Parse(txt_donGia.Text.ToString()));
            }
        }

        private void txt_donBan_TextChanged(object sender, EventArgs e)
        {
            if (txt_donBan.Text == "")
            {
                txt_bangChuDonBan.Text = "";
            }
            else
            {
                txt_bangChuDonBan.Text = DataProvider.ChuyenSoSangChuoi(Double.Parse(txt_donBan.Text.ToString()));
            }
        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_donBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
