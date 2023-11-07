using BusinessObject.Models;
using HRMService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BirdManageShop
{
    public partial class FRMThongKe : Form
    {
        IOrderServices _orderService;
        IProductServices _productService;
        ICustomerServices _customerService;
        IOrderProductServices _orderProductService;
        public FRMThongKe()
        {
            InitializeComponent();
            _orderService = new OrderServices();
            _productService = new ProductServices();
            _customerService = new CustomerServices();
            _orderProductService = new OrderProductServices();
            cbox_Time.Items.Add("Theo Ngày");
            cbox_Time.Items.Add("Theo Tháng");
            cbox_Time.Items.Add("Theo Năm");
        }
        private void LoadChartRevenue()
        {
            ChartArea chartArea = new ChartArea();
            chart_DoanhThu.ChartAreas.Add(chartArea);
            Series series = new Series("Năm nay");
            series.Color = Color.Red;
            series.ChartType = SeriesChartType.Line;
            chart_DoanhThu.Series.Add(series);
            List<double> dataValues = new List<double>();
            for (int i = 1; i <= 12; i++)
            {
                if (DateTime.Now.Month < i)
                {
                    break;
                }
                var total = _orderService.GetTotalByMonthAndYear(i, DateTime.Now.Year);
                DataPoint dataPoint = new DataPoint(i, total);
                dataPoint.AxisLabel = "Tháng " + i;
                dataPoint.Color = Color.Red;
                dataValues.Add(total);
                series.Points.Add(dataPoint);
            }
            double minY = dataValues.Min();
            double maxY = dataValues.Max();
            chartArea.AxisY.Minimum = Math.Floor(minY / 10) * 10;
            chartArea.AxisY.Maximum = Math.Ceiling(maxY / 10) * 10;

            chartArea.AxisX.LabelStyle.Enabled = true;
            chartArea.AxisY.IsStartedFromZero = true;
            chartArea.AxisY.LabelStyle.Enabled = true;
            chart_DoanhThu.Titles.Add("Doanh thu năm nay");
            Controls.Add(chart_DoanhThu);
        }
        private void LoadChartPieTypeProduct()
        {
            var topTypeProducts = _orderProductService.GetTopTypeProduct(DateTime.Now.Month, DateTime.Now.Year);
            Series series1 = new Series("Năm nay");
            series1.ChartType = SeriesChartType.Pie;

            foreach (var type in topTypeProducts)
            {
                DataPoint point = new DataPoint();
                point.SetValueY(type.TotalQuantity);
                point.AxisLabel = type.TypeProductName;
                point.Label = "#PERCENT{P0}";

                series1.Points.Add(point);
            }

            chart_TopTypeOfProduct.Series.Add(series1);

            ChartArea chartArea1 = new ChartArea();
            chart_TopTypeOfProduct.ChartAreas.Add(chartArea1);

            chart_TopTypeOfProduct.Titles.Add("Tỉ lệ phần trăm loại sản phẩm bán được trong tháng nay");

            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Bottom;

            foreach (var point in series1.Points)
            {
                LegendItem legendItem = new LegendItem
                {
                    Name = point.AxisLabel,
                    Color = point.Color
                };

                legend.CustomItems.Add(legendItem);
            }

            chart_TopTypeOfProduct.Legends.Add(legend);
            chart_TopTypeOfProduct.TextAntiAliasingQuality = TextAntiAliasingQuality.SystemDefault;

            Controls.Add(chart_TopTypeOfProduct);

        }
        private void LoadChartColumnProduct()
        {
            ChartArea chartArea1 = new ChartArea();
            chart_TopProduct.ChartAreas.Add(chartArea1);
            Series series1 = new Series("Tháng này");
            series1.ChartType = SeriesChartType.Column;
            chart_TopProduct.Series.Add(series1);
            List<double> dataValues1 = new List<double>();
            var productTop = _orderProductService.GetTopProduct(DateTime.Now.Month, DateTime.Now.Year);
            int i = 0;

            foreach (var product in productTop)
            {
                i += 1;
                series1.Points.Add(new DataPoint(i, (double)product.TotalQuantity) { AxisLabel = product.ProductName });
            }

            chartArea1.AxisX.LabelStyle.Enabled = true;
            chartArea1.AxisY.IsStartedFromZero = true;
            chartArea1.AxisY.LabelStyle.Enabled = true;
            chart_TopProduct.Titles.Add("Top 5 sản phẩm bán ra trong tháng");
            Controls.Add(chart_TopProduct);
        }
        private void CaculateRevenue()
        {
            if (cbox_Time.Text.Equals("Theo Tháng"))
            {
                var revenueByThisMonth = _orderService.GetTotalByMonthAndYear(DateTime.Now.Month, DateTime.Now.Year);
                label_RevenueMonth.Text = revenueByThisMonth.ToString();
                return;
            }
            if (cbox_Time.Text.Equals("Theo Ngày"))
            {
                var revenueByThisMonth = _orderService.GetTotalByDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                label_RevenueMonth.Text = revenueByThisMonth.ToString();
                return;
            }
            if (cbox_Time.Text.Equals("Theo Năm"))
            {
                var revenueByThisMonth = _orderService.GetTotalByYear(DateTime.Now.Year);
                label_RevenueMonth.Text = revenueByThisMonth.ToString();
                return;
            }


        }
        private void CaculateOrder()
        {
            if (cbox_Time.Text.Equals("Theo Tháng"))
            {
                var numberOrderThisMonth = _orderService.GetNumberOrderByMonth(DateTime.Now.Month, DateTime.Now.Year);
                label_NumberOrder.Text = numberOrderThisMonth.ToString();
                return;
            }
            if (cbox_Time.Text.Equals("Theo Ngày"))
            {
                var numberOrderThisDay = _orderService.GetNumberOrderByDay(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                label_NumberOrder.Text = numberOrderThisDay.ToString();
                return;
            }
            if (cbox_Time.Text.Equals("Theo Năm"))
            {
                var numberOrderThisDay = _orderService.GetNumberOrderByYear(DateTime.Now.Year);
                label_NumberOrder.Text = numberOrderThisDay.ToString();
                return;
            }
        }
        private void CaculateAnother()
        {
            var totalProductStock = _productService.GetTotalStockProduct();
            label_TotalProductInStock.Text = totalProductStock.ToString();
            var customeNew = _customerService.NumberNewCustomerByMonth(DateTime.Now.Month, DateTime.Now.Year);
            label_NewCustomer.Text = customeNew.ToString();
            var totalProductToSell = _orderProductService.GetTotalProductToSellByMonth(DateTime.Now.Month, DateTime.Now.Year);
            label_NumberProductTSold.Text = totalProductToSell.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadChartRevenue();
            LoadChartPieTypeProduct();
            LoadChartColumnProduct();
            CaculateRevenue();
            CaculateOrder();
            CaculateAnother();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaculateOrder();
            CaculateRevenue();
        }

        private void chart_TopProduct_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {
        }
    }
}

