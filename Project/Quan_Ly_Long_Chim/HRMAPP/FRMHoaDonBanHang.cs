using BusinessObject.Models;
using HRMDAO;
using HRMService;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HRMAPP
{
    public partial class FRMHoaDonBanHang : Form
    {
        IOrderProductServices orderProductServices;
        IOrderServices orderServices;
        IProductServices productServices;
        ICustomerServices customerServices;
        IStaffServices staffServices;
        List<Customer> customers = new List<Customer>();
        List<staff> staffs = new List<staff>();
        List<Product> products = new List<Product>();
        List<Order> orders = new List<Order>();
        List<OrderProduct> orderProducts = new List<OrderProduct>();
    
        public FRMHoaDonBanHang()
        {
            InitializeComponent();
            orderProductServices = new OrderProductServices();
            orderServices = new OrderServices();
            productServices = new ProductServices();
            customerServices = new CustomerServices();
            staffServices = new StaffServices();
    
        }
        public delegate void DataPassHandler(string data);
        public event DataPassHandler DataPassed;
        private void SendDataToForm2(string id)
        {
            DataPassed?.Invoke(id);
        }
        private void FRMHoaDonBanHang_Load(object sender, EventArgs e)
        {
            btn_themHoaDon.Enabled = true;
            btn_luuHoaDon.Enabled = false;
            btn_huyHoaDon.Enabled = false;

            btn_boQua.Enabled = false;
            txt_maHD.Enabled = false;
            txt_tenNhanVien.Enabled = false;
            txt_tenKhachHang.Enabled = false;
            txt_diaChi.Enabled = false;
            masked_dienThoai.Enabled = false;
            txt_tenHang.Enabled = false;
            txt_donGia.Enabled = false;
            txt_thanhTien.Enabled = false;
            txt_tongTien.Enabled = false;
            txt_giamGia.Text = "0";
            txt_tongTien.Text = "0";
            cbo_maKhachHang.DataSource = customerServices.listCustomers();
            cbo_maKhachHang.DisplayMember = "id";
            cbo_maKhachHang.SelectedIndex = -1;
            cbo_maNhanVien.DataSource = staffServices.listStaffs();
            cbo_maNhanVien.DisplayMember = "id";
            cbo_maNhanVien.SelectedIndex = -1;
            cbo_maHang.DataSource = productServices.listProducts();
            cbo_maHang.DisplayMember = "id";
            cbo_maHang.SelectedIndex = -1;
            if (txt_maHD.Text != "")
            {
                LoadInfoHoaDon();
                btn_huyHoaDon.Enabled = true;
         
            }
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            dgv_thongTinHoaDon.DataSource = orderProductServices.listOrderProducts().Where(op => op.IdOrder == txt_maHD.Text)
                .Select(op => new
                {
                    op.IdProduct,
                    op.IdProductNavigation.Name,
                    op.Quantity,
                    PriceExport = (float)op.IdProductNavigation.PriceExport,
                    op.Discount,
                    op.Total
                }).ToList();
            dgv_thongTinHoaDon.Columns[0].HeaderText = "Mã hàng";
            dgv_thongTinHoaDon.Columns[1].HeaderText = "Tên hàng";
            dgv_thongTinHoaDon.Columns[2].HeaderText = "Số lượng";
            dgv_thongTinHoaDon.Columns[3].HeaderText = "Đơn giá";
            dgv_thongTinHoaDon.Columns[4].HeaderText = "Giảm giá %";
            dgv_thongTinHoaDon.Columns[5].HeaderText = "Thành tiền";
            dgv_thongTinHoaDon.Columns[0].Width = 80;
            dgv_thongTinHoaDon.Columns[1].Width = 130;
            dgv_thongTinHoaDon.Columns[2].Width = 80;
            dgv_thongTinHoaDon.Columns[3].Width = 90;
            dgv_thongTinHoaDon.Columns[4].Width = 90;
            dgv_thongTinHoaDon.Columns[5].Width = 90;
            dgv_thongTinHoaDon.AllowUserToAddRows = false;
            dgv_thongTinHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void resetValues()
        {
            txt_maHD.Text = "";
            date_ngayBan.Value = DateTime.Now;
            cbo_maNhanVien.Text = "";
            cbo_maKhachHang.Text = "";
            txt_tenNhanVien.Text = "";
            txt_diaChi.Text = "";
            txt_tenKhachHang.Text = "";
            masked_dienThoai.Text = "";
            txt_tongTien.Text = "0";
            txt_bangChu.Text = "";
            cbo_maHang.Text = "";
            txt_tenHang.Text = "";
            txt_donGia.Text = "0";
            txt_soLuong.Text = "";
            txt_giamGia.Text = "0";
            txt_thanhTien.Text = "0";
        }
        private void ResetValuesHang()
        {
            cbo_maHang.Text = "";
            txt_tenHang.Text = "";
            txt_donGia.Text = "";
            txt_soLuong.Text = "";
            txt_giamGia.Text = "0";
            txt_thanhTien.Text = "0";
        }
        private void LoadInfoHoaDon()
        {
            date_ngayBan.Value = orderServices.listOrders()
                                                .Where(o => o.Id == txt_maHD.Text)
                                                .Select(o => DateTime.Parse(o.DateBuy.ToString()))
                                                .FirstOrDefault();
            cbo_maNhanVien.Text = orderServices.listOrders()
                                                .Where(o => o.Id == txt_maHD.Text)
                                                .Select(o => o.IdStaff)
                                                .FirstOrDefault() ?? string.Empty;
            cbo_maKhachHang.Text = orderServices.listOrders()
                                                .Where(o => o.Id == txt_maHD.Text)
                                                .Select(o => o.IdCustomer)
                                                .FirstOrDefault() ?? string.Empty;
            txt_tongTien.Text = orderServices.listOrders()
                                                .Where(o => o.Id == txt_maHD.Text)
                                                .Select(o => o.Total)
                                                .FirstOrDefault()?.ToString() ?? string.Empty;
            txt_bangChu.Text = DataProvider.ChuyenSoSangChuoi(Double.Parse(txt_tongTien.Text));
            cbo_maNhanVien.Enabled = false;
            cbo_maKhachHang.Enabled = false;
        }

        private void btn_themHoaDon_Click(object sender, EventArgs e)
        {
            btn_huyHoaDon.Enabled = false;
            btn_luuHoaDon.Enabled = true;
   
            btn_themHoaDon.Enabled = false;
            btn_boQua.Enabled = true;
            cbo_maKhachHang.Enabled = true;
            cbo_maNhanVien.Enabled = true;
            resetValues();
            txt_maHD.Text = DataProvider.CreateKey("HDB");
            loadDataGridView();
        }

        private void btn_luuHoaDon_Click(object sender, EventArgs e)
        {
            double sl, SLcon, tongBanDau, tongMoi;
            if (!orderServices.checkIdOrder(txt_maHD.Text))
            {
                if (cbo_maNhanVien.Text.Length == 0 || cbo_maKhachHang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên và khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                double total = Math.Round(Convert.ToDouble(txt_tongTien.Text), 0);
                Order order = new Order
                {
                    Id = txt_maHD.Text,
                    DateBuy = date_ngayBan.Value,
                    Total = total,
                    IdCustomer = cbo_maKhachHang.Text,
                    IdStaff = cbo_maNhanVien.Text,
                };
                orderServices.insertOrder(order);
            }

            if (orderProductServices.listOrderProducts().Where(op => op.IdProduct == cbo_maHang.Text && op.IdOrder == txt_maHD.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbo_maHang.Focus();
                return;
            }
            if (txt_soLuong.Text.Trim().Length == 0 || txt_soLuong.Text == "0")
            {
                MessageBox.Show("Bạn phải nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soLuong.Text = "";
                txt_soLuong.Focus();
                return;
            }
            sl = Convert.ToDouble(productServices.listProducts().Where(p => p.Id == cbo_maHang.Text).Select(p => p.Quantity).FirstOrDefault());
            if (Convert.ToDouble(txt_soLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soLuong.Text = "";
                txt_soLuong.Focus();
                return;
            }
            OrderProduct orderProduct = new OrderProduct
            {
                IdProduct = cbo_maHang.Text,
                IdOrder = txt_maHD.Text,
                Quantity = int.Parse(txt_soLuong.Text),
                Discount = int.Parse(txt_giamGia.Text),
                Price = Convert.ToDouble(txt_donGia.Text),
                Total = Convert.ToDouble(txt_thanhTien.Text.ToString()),
            };

            if (MessageBox.Show("Bạn đã mua " + txt_tenHang.Text + " với số lượng là: " + Convert.ToDouble(txt_soLuong.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                orderProductServices.insertOrderProduct(orderProduct);
                loadDataGridView();
                SLcon = sl - Convert.ToDouble(txt_soLuong.Text);
                productServices.updateQuantityProduct(SLcon, cbo_maHang.Text);
                tongBanDau = Convert.ToDouble(orderServices.listOrders().Where(o => o.Id == txt_maHD.Text).Select(o => o.Total).FirstOrDefault());
                tongMoi = tongBanDau + Convert.ToDouble(txt_thanhTien.Text);
                orderServices.updateTotalOrder(tongMoi, txt_maHD.Text);
                txt_tongTien.Text = tongMoi.ToString();
                txt_bangChu.Text = DataProvider.ChuyenSoSangChuoi(Double.Parse(txt_tongTien.Text));
            }

            ResetValuesHang();
            btn_huyHoaDon.Enabled = true;
            btn_themHoaDon.Enabled = false;
   
            SendDataToForm2(txt_maHD.Text);
        }

        private void cbo_maHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_maHang.Text == "")
            {
                txt_tenHang.Text = "";
                txt_donGia.Text = "";
            }
            txt_tenHang.Text = productServices.listProducts()
                                              .Where(p => p.Id == cbo_maHang.Text)
                                              .Select(p => p.Name)
                                              .FirstOrDefault() ?? string.Empty;
            txt_donGia.Text = productServices.listProducts()
                                              .Where(p => p.Id == cbo_maHang.Text)
                                              .Select(p => p.PriceExport)
                                              .FirstOrDefault()?.ToString() ?? string.Empty;
        }

        private void cbo_maKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_maKhachHang.Text == "")
            {
                txt_tenKhachHang.Text = "";
                masked_dienThoai.Text = "";
                txt_diaChi.Text = "";
            }
            masked_dienThoai.Text = customerServices.listCustomers()
                                                .Where(s => s.Id == cbo_maKhachHang.Text)
                                                .Select(s => s.Phone)
                                                .FirstOrDefault() ?? string.Empty;
            txt_tenKhachHang.Text = customerServices.listCustomers()
                                                .Where(s => s.Id == cbo_maKhachHang.Text)
                                                .Select(s => s.Name)
                                                .FirstOrDefault() ?? string.Empty;
            txt_diaChi.Text = customerServices.listCustomers()
                                                .Where(s => s.Id == cbo_maKhachHang.Text)
                                                .Select(s => s.Address)
                                                .FirstOrDefault() ?? string.Empty;
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            double thanhTien, soLuong, donGia, giamGia;
            if (txt_soLuong.Text == "")
                soLuong = 0;
            else
                soLuong = Convert.ToDouble(txt_soLuong.Text);
            if (txt_giamGia.Text == "")
                giamGia = 0;
            else
                giamGia = Convert.ToDouble(txt_giamGia.Text);
            if (txt_donGia.Text == "")
                donGia = 0;
            else
                donGia = Convert.ToDouble(txt_donGia.Text);
            thanhTien = soLuong * donGia - soLuong * donGia * giamGia / 100;
            double total = Math.Round(thanhTien, 0);
            txt_thanhTien.Text = total.ToString();
        }

        private void cbo_maNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_maNhanVien.Text == "")
            {
                txt_tenNhanVien.Text = "";
            }
            txt_tenNhanVien.Text = staffServices.listStaffs()
                                                .Where(s => s.Id == cbo_maNhanVien.Text)
                                                .Select(s => s.Name)
                                                .FirstOrDefault() ?? string.Empty;
        }

        private void txt_giamGia_TextChanged(object sender, EventArgs e)
        {
            double thanhTien, soLuong, donGia, giamGia;
            if (txt_soLuong.Text == "")
                soLuong = 0;
            else
                soLuong = Convert.ToDouble(txt_soLuong.Text);
            if (txt_giamGia.Text == "")
                giamGia = 0;
            else
                giamGia = Convert.ToDouble(txt_giamGia.Text);
            if (txt_donGia.Text == "")
                donGia = 0;
            else
                donGia = Convert.ToDouble(txt_donGia.Text);
            thanhTien = soLuong * donGia - soLuong * donGia * giamGia / 100;
            double total = Math.Round(thanhTien, 0);
            txt_thanhTien.Text = total.ToString();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (cbo_maHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SendDataToForm2("Clean");
                cbo_maHD.Focus();
                return;
            }
            txt_maHD.Text = cbo_maHD.Text;
            SendDataToForm2(txt_maHD.Text);
            LoadInfoHoaDon();
            loadDataGridView();
            txt_tenNhanVien.Text = staffServices.listStaffs()
                                                .Where(s => s.Id == cbo_maNhanVien.Text)
                                                .Select(s => s.Name)
                                                .FirstOrDefault() ?? string.Empty;
            txt_tenKhachHang.Text = customerServices.listCustomers()
                                                .Where(s => s.Id == cbo_maKhachHang.Text)
                                                .Select(s => s.Name)
                                                .FirstOrDefault() ?? string.Empty;
            txt_diaChi.Text = customerServices.listCustomers()
                                                .Where(s => s.Id == cbo_maKhachHang.Text)
                                                .Select(s => s.Address)
                                                .FirstOrDefault() ?? string.Empty;
            btn_huyHoaDon.Enabled = true;
            btn_luuHoaDon.Enabled = true;

            btn_themHoaDon.Enabled = false;
            btn_boQua.Enabled = true;
            cbo_maHD.SelectedIndex = -1;
        }

        private void cbo_maHD_DropDown(object sender, EventArgs e)
        {
            cbo_maHD.DataSource = orderServices.listOrders();
            cbo_maHD.DisplayMember = "id";
            cbo_maHD.SelectedIndex = -1;
        }

        private void cbo_maKhachHang_DropDown(object sender, EventArgs e)
        {
            if (cbo_maKhachHang.Text == "")
            {
                txt_tenKhachHang.Text = "";
                txt_diaChi.Text = "";
                masked_dienThoai.Text = "";
            }
            cbo_maKhachHang.DataSource = customerServices.listCustomers();
            cbo_maKhachHang.DisplayMember = "id";
            cbo_maKhachHang.SelectedIndex = -1;
        }

        private void btn_huyHoaDon_Click(object sender, EventArgs e)
        {

            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var orderProducts = orderProductServices.listOrderProducts().Where(m => m.IdOrder == txt_maHD.Text);

                foreach (var orderProduct in orderProducts)
                {
                    sl = Convert.ToDouble(productServices.listProducts().Where(p => p.Id == orderProduct.IdProduct).Select(p => p.Quantity).FirstOrDefault());
                    slxoa = Convert.ToDouble(orderProduct.Quantity);
                    slcon = sl + slxoa;
                    productServices.updateQuantityProduct(slcon, orderProduct.IdProduct);
                }

                orderProductServices.deleteOrderProduct(txt_maHD.Text);
                orderServices.deleteOrder(txt_maHD.Text);
                resetValues();
                loadDataGridView();
                dgv_thongTinHoaDon.DataSource = null;
                btn_huyHoaDon.Enabled = false;
   
                btn_luuHoaDon.Enabled = false;
                btn_themHoaDon.Enabled = true;
                SendDataToForm2("Clean");
            }

        }

        private void dgv_thongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt_giamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

       
        private void dgv_thongTinHoaDon_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (dgv_thongTinHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                MaHangxoa = dgv_thongTinHoaDon.CurrentRow.Cells["idProduct"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgv_thongTinHoaDon.CurrentRow.Cells["quantity"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgv_thongTinHoaDon.CurrentRow.Cells["total"].Value.ToString());
                orderProductServices.deleteOrderProductByIdOrderAndIdProduct(txt_maHD.Text, MaHangxoa);
                sl = Convert.ToDouble(productServices.listProducts().Where(p => p.Id == MaHangxoa).Select(p => p.Quantity).FirstOrDefault());
                slcon = sl + SoLuongxoa;
                productServices.updateQuantityProduct(slcon, MaHangxoa);
                tong = Convert.ToDouble(orderServices.listOrders().Where(o => o.Id == txt_maHD.Text).Select(o => o.Total).FirstOrDefault());
                tongmoi = tong - ThanhTienxoa;
                orderServices.updateTotalOrder(tongmoi, txt_maHD.Text);
                txt_tongTien.Text = tongmoi.ToString();
                txt_bangChu.Text = DataProvider.ChuyenSoSangChuoi(Double.Parse(tongmoi.ToString()));
                cbo_maHang.Text = "";
                txt_tenHang.Text = "";
                txt_donGia.Text = "0";
                txt_soLuong.Text = "0";
                txt_giamGia.Text = "0";
                txt_thanhTien.Text = "0";
                loadDataGridView();
                SendDataToForm2(txt_maHD.Text);
            }

        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            resetValues();
            SendDataToForm2("Clean");
            dgv_thongTinHoaDon.DataSource = null;
            btn_huyHoaDon.Enabled = false;
            btn_luuHoaDon.Enabled = false;
            btn_themHoaDon.Enabled = true;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        public static Assembly LoadOfficeInteropAssembly()
        {
            Assembly officeInteropAssembly = null;

            try
            {
                officeInteropAssembly = Assembly.Load("Office, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c");
            }
            catch (Exception ex)
            {
                // Handle the exception.
            }

            return officeInteropAssembly;
        }
    }
}
