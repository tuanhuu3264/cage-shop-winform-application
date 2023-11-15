using BusinessObject.Models;
using HRMService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMAPP
{
    public partial class FRMHoaDonCuaKhachHang : Form
    {
        private FRMHoaDonBanHang hoaDon;
        private readonly IOrderProductServices orderProductServices;
        private readonly IOrderServices orderServices;
        private readonly IProductServices productServices;
        private readonly ITypeProductServices typeProductServices;
        private IEnumerable<Product> products;

        public FRMHoaDonCuaKhachHang()
        {
            InitializeComponent();
            orderProductServices = new OrderProductServices();
            orderServices = new OrderServices();
            productServices = new ProductServices();
            typeProductServices = new TypeProductServices();
            txt_tongTien.Text = "0";
            txt_bangChu.Text = "0 VNĐ";
            var types = typeProductServices.listTypeProduct();
            foreach (var type in types)
            {
                cbo_maChatLieu.Items.Add(type.Name);
            }
            cbo_maChatLieu.Items.Add("All");
            LoadProducts();
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
            var order = orderServices.listOrders().SingleOrDefault(o => o.Id == data);
            dgv_hoaDonBanHang.DataSource = orderProductServices.listOrderProducts()
                .Where(op => op.IdOrder == data)
                .Select(op => new
                {
                    op.IdProduct,
                    op.IdProductNavigation.Name,
                    op.Quantity,
                    PriceExport = (float)op.IdProductNavigation.PriceExport,
                    op.Discount,
                    op.Total
                }).ToList();
         
                txt_tongTien.Text = order.Total.ToString() + " VND";
                txt_bangChu.Text = DataProvider.ChuyenSoSangChuoi((double)order.Total);
            
        }

        private int currentPage = 1;
        private int Maxpage = 0;

        private void LoadProducts()
        {
            products = productServices.listProducts();
            if (!products.Any())
            {
                ResetValue();
                return;
            }
            CalculatePageNumber();
            DisplayProducts(currentPage);
            

        }

        private void CalculatePageNumber()
        {
            Maxpage = (int)Math.Ceiling((double)products.Count() / 3);
            label_soTrang.Text = $"{currentPage}/{Maxpage}";
        }

        private void ResetValue()
        {
            label_soTrang.Text = "0/0";
            for (int i = 0; i < 3; i++)
            {
                PictureBox pictureBox = Controls.Find($"pic_hangHoa{i + 1}", true)[0] as PictureBox;
                pictureBox.Image = null;

                Label nameLabel = Controls.Find($"label_tenSanPham{i + 1}", true)[0] as Label;
                nameLabel.Text = string.Empty;

                Label priceLabel = Controls.Find($"label_anhSanPham{i + 1}", true)[0] as Label;
                priceLabel.Text = string.Empty;

                TextBox textBox = Controls.Find($"txt_ghiChu{i + 1}", true)[0] as TextBox;
                textBox.ReadOnly = false;
                textBox.Text = "";
                textBox.ReadOnly = true;
            }
        }

        private void DisplayProducts(int page)
        {
            int startIndex = (page - 1) * 3;

            for (int i = 0; i < 3; i++)
            {
                int index = startIndex + i;
                if (index < products.Count())
                {
                    PictureBox pictureBox = Controls.Find($"pic_hangHoa{i + 1}", true)[0] as PictureBox;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(products.ElementAt(index).ImageUrl);

                    Label nameLabel = Controls.Find($"label_tenSanPham{i + 1}", true)[0] as Label;
                    nameLabel.Text = products.ElementAt(index).Name;

                    Label priceLabel = Controls.Find($"label_anhSanPham{i + 1}", true)[0] as Label;
                    priceLabel.Text = $"{products.ElementAt(index).PriceExport} VND";

                    TextBox textBox = Controls.Find($"txt_ghiChu{i + 1}", true)[0] as TextBox;
                    textBox.ReadOnly = false;
                    textBox.Text = products.ElementAt(index).Description;
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

                    TextBox textBox = Controls.Find($"txt_ghiChu{i + 1}", true)[0] as TextBox;
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
                CalculatePageNumber();
                DisplayProducts(currentPage);
            }
        }

        private void btn_trangSau_Click(object sender, EventArgs e)
        {
            if (currentPage < Maxpage)
            {
                currentPage++;
                CalculatePageNumber();
                DisplayProducts(currentPage);
            }
        }

        private void Search()
        {
            products = productServices.listProducts();
            if (string.IsNullOrEmpty(cbo_maChatLieu.Text.Trim())||cbo_maChatLieu.Text=="All")
            {
                products = productServices.listProducts();
            }
            else
            {
                products = products.Where(p => p.IdTypeProductNavigation.Name == cbo_maChatLieu.Text.Trim()).ToList();
            }

            if (txt_timKiem.Text.Trim().Length > 0)
            {
                products = products.Where(p => p.Name.ToLower().Contains(txt_timKiem.Text.ToLower().Trim())).ToList();
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

