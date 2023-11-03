using BusinessObject.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRMAPP
{
    public partial class FRMHoaDonCuaKhachHang : Form
    {
        FRMHoaDonBanHang hoaDon;
        IOrderProductServices orderProductServices;
        IOrderServices orderServices;
        IProductServices productServices;
        ITypeProductServices typeProductServices;
        List<Product> products = new List<Product>();
        public FRMHoaDonCuaKhachHang()
        {
            InitializeComponent();
            orderProductServices = new OrderProductServices();
            orderServices = new OrderServices();
            productServices = new ProductServices();
            typeProductServices = new TypeProductServices();
            txt_tongTien.Text = "0";
            txt_bangChu.Text = "0 VNĐ";
        }
        public void AddDatePassed(FRMHoaDonBanHang frm)
        {
            this.hoaDon = frm;
            hoaDon.DataPassed += HoaDon_DataPassed;
        }
        private void HoaDon_DataPassed(string data)
        {
            if (data.Equals("Clean"))
            {
                dgv_hoaDonBanHang.DataSource = null;
                txt_bangChu.Text = "";
                txt_tongTien.Text = "";
                return;
            }
            dgv_hoaDonBanHang.DataSource = orderProductServices.listOrderProducts().Where(op => op.IdOrder == data)
               .Select(op => new
               {
                   op.IdProduct,
                   op.IdProductNavigation.Name,
                   op.Quantity,
                   PriceExport = (float)op.IdProductNavigation.PriceExport,
                   op.Discount,
                   op.Total
               }).ToList();
            txt_tongTien.Text = orderServices.listOrders().Where(o => o.Id == data).Select(o => o.Total).ToString() + " VND";
            txt_bangChu.Text = DataProvider.ChuyenSoSangChuoi(double.Parse(orderServices.listOrders().Where(o => o.Id == data).Select(o => o.Total).ToString()));

        }
        int currentPage = 1;
        int Maxpage = 0;
        private void FRMHoaDonCuaKhachHang_Load(object sender, EventArgs e)
        {
            LoadProducts();
            cbo_maChatLieu.DataSource = typeProductServices.listTypeProduct();
            cbo_maChatLieu.ValueMember = "Id";
            cbo_maChatLieu.DisplayMember = "Name";
        }
        private void LoadProducts()
        {
            products = productServices.listProducts();
            if (products.Count == 0)
            {
                ResetValue();
                return;
            }
            CalculatePageNumber();
            DisplayProducts(currentPage);
        }
        private void CalculatePageNumber()
        {
            Maxpage = (int)Math.Ceiling((double)products.Count / 3);
            label_soTrang.Text = currentPage.ToString() + "/" + Maxpage.ToString();
        }
        private void ResetValue()
        {
            label_soTrang.Text = "0/0";
            for (int i = 0; i < 6; i++)
            {
                PictureBox pictureBox = Controls.Find($"pic_hangHoa{i + 1}", true)[0] as PictureBox;
                pictureBox.Image = null;

                Label nameLabel = Controls.Find($"label_tenSanPham{i + 1}", true)[0] as Label;
                nameLabel.Text = string.Empty;

                Label priceLabel = Controls.Find($"label_anhSanPham{i + 1}", true)[0] as Label;
                priceLabel.Text = string.Empty;

                System.Windows.Forms.TextBox textBox = Controls.Find($"txt_ghiChu{i + 1}", true)[0] as System.Windows.Forms.TextBox;
                textBox.ReadOnly = false;
                textBox.Text = "";
                textBox.ReadOnly = true;
            }
        }

        private void DisplayProducts(int page)
        {

            int startIndex = (page - 1) * 6;

            for (int i = 0; i < 6; i++)
            {
                int index = startIndex + i;
                if (index < products.Count)
                {
                    PictureBox pictureBox = Controls.Find($"pic_hangHoa{i + 1}", true)[0] as PictureBox;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(products[index].ImageUrl);

                    Label nameLabel = Controls.Find($"label_tenSanPham{i + 1}", true)[0] as Label;
                    nameLabel.Text = products[index].Name;

                    Label priceLabel = Controls.Find($"label_anhSanPham{i + 1}", true)[0] as Label;
                    priceLabel.Text = products[index].PriceExport.ToString() + " VND";

                    System.Windows.Forms.TextBox textBox = Controls.Find($"txt_ghiChu{i + 1}", true)[0] as System.Windows.Forms.TextBox;
                    textBox.ReadOnly = false;
                    textBox.Text = products[index].Description.ToString();
                    textBox.ReadOnly = true;
                }
                else
                {

                    PictureBox pictureBox = Controls.Find($"pic_hangHoa{i + 1}", true)[0] as PictureBox;
                    pictureBox.Image = null;

                    Label nameLabel = Controls.Find($"label_tenSanPham{i + 1}", true)[0] as Label;
                    nameLabel.Text = string.Empty;

                    Label priceLabel = Controls.Find($"label_anhSanPham{i + 1}", true)[0] as Label;
                    priceLabel.Text = string.Empty;

                    System.Windows.Forms.TextBox textBox = Controls.Find($"txt_ghiChu{i + 1}", true)[0] as System.Windows.Forms.TextBox;
                    textBox.ReadOnly = false;
                    textBox.Text = "";
                    textBox.ReadOnly = true;
                }
            }
        }

        private void btn_trangTruoc_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayProducts(currentPage);
            }
        }

        private void btn_trangSau_Click(object sender, EventArgs e)
        {
            if (currentPage < Maxpage)
            {
                CalculatePageNumber();
                currentPage++;
                DisplayProducts(currentPage);
            }
        }
        private void Search()
        {
            if (string.IsNullOrEmpty(cbo_maChatLieu.Text.Trim()))
            {
                products = productServices.listProducts();
            }
            else
            {
                products = productServices.listProducts().Where(p => p.IdTypeProduct == cbo_maChatLieu.Text).ToList();

            }
            if (txt_timKiem.Text.Trim().Length > 0)
            {
                products = productServices.listProducts().Where(p => p.Name.Contains(txt_timKiem.Text)).ToList();
            }
            CalculatePageNumber();
            currentPage = 1;
            DisplayProducts(currentPage);
        }

        private void cbo_maChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
