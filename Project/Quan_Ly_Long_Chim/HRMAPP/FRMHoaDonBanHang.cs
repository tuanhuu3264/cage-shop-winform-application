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
using COMExcel = Microsoft.Office.Interop.Excel;

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
            btn_inHoaDon.Enabled = false;
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
                btn_inHoaDon.Enabled = true;
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
            btn_inHoaDon.Enabled = false;
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
            btn_inHoaDon.Enabled = true;
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
            btn_inHoaDon.Enabled = true;
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
                SendDataToForm2(txt_maHD.Text);
                dgv_thongTinHoaDon.DataSource = null;
                btn_huyHoaDon.Enabled = false;
                btn_inHoaDon.Enabled = false;
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

        private void btn_inHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maHD.Text))
            {
                MessageBox.Show("Cần chọn một hóa đơn để in.");
                return;
            }

            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHang;

            // Định dạng chung
            exRange = (COMExcel.Range)exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; // Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; // Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "SHOP VTT";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Đại học FPT";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (033)2333005";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; // Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";

            // thông tin chung của hóa đơn bán
            sql = "SELECT b.name, a.quantity, b.price_export, a.discount, a.total " +
                  "FROM Order_Product AS a, Product AS b WHERE a.idOrder = N'" +
                  txt_maHD.Text + "' AND a.idProduct = b.id";

            Order order = orderServices.getById(txt_maHD.Text);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = order.Id.ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = order.IdCustomerNavigation.Name;
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = order.IdCustomerNavigation.Address;
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = order.IdCustomerNavigation.Phone;

            // Lấy thông tin các mặt hàng
            tblThongtinHang = (DataTable)orderProductServices.listOrderProducts().Select(m => new
            {
                m.IdProductNavigation?.Name,
                m.Quantity,
                m.IdProductNavigation?.PriceExport,
                m.Discount,
                m.Total
            });

            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";

            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                // Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1, hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                {
                    // Điền thông tin hàng từ cột thứ 2, dòng 12
                    if (cot == 3)
                    {
                        exSheet.Cells[cot + 2, hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                    }
                    else
                    {
                        exSheet.Cells[cot + 2, hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    }
                }
            }

            exRange = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[cot, hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[cot + 1, hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = order.Total.ToString();
            exRange = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, hang + 15];
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + DataProvider.ChuyenSoSangChuoi((double)order.Total);
            exRange = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[4, hang + 17];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            DateTime d = (DateTime)order.DateBuy;
            exRange.Range["A1:C1"].Value = "Thủ Đức, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = order.IdStaffNavigation.Name;
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

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
            }

        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            resetValues();
            dgv_thongTinHoaDon.DataSource = null;
            btn_huyHoaDon.Enabled = false;
            btn_inHoaDon.Enabled = false;
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
