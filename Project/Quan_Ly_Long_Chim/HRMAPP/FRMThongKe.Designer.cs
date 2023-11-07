namespace BirdManageShop
{
    partial class FRMThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart_TopTypeOfProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            groupBox8 = new GroupBox();
            label_NumberOrder = new Label();
            cbox_Time = new ComboBox();
            grpBox_Revenue = new GroupBox();
            label_RevenueMonth = new Label();
            groupBox7 = new GroupBox();
            label_TotalProductInStock = new Label();
            groupBox6 = new GroupBox();
            label_NumberProductTSold = new Label();
            label_NumberOrderMonth = new Label();
            groupBox2 = new GroupBox();
            label_NewCustomer = new Label();
            chart_TopProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart_DoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_TopTypeOfProduct).BeginInit();
            groupBox1.SuspendLayout();
            groupBox8.SuspendLayout();
            grpBox_Revenue.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_TopProduct).BeginInit();
            SuspendLayout();
            // 
            // chart_DoanhThu
            // 
            legend1.Name = "Legend1";
            chart_DoanhThu.Legends.Add(legend1);
            chart_DoanhThu.Location = new Point(3, 12);
            chart_DoanhThu.Name = "chart_DoanhThu";
            chart_DoanhThu.Size = new Size(491, 330);
            chart_DoanhThu.TabIndex = 0;
            chart_DoanhThu.Text = "chart1";
            // 
            // chart_TopTypeOfProduct
            // 
            chart_TopTypeOfProduct.Location = new Point(500, 12);
            chart_TopTypeOfProduct.Name = "chart_TopTypeOfProduct";
            chart_TopTypeOfProduct.Size = new Size(410, 330);
            chart_TopTypeOfProduct.TabIndex = 1;
            chart_TopTypeOfProduct.Text = "chart1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(cbox_Time);
            groupBox1.Controls.Add(grpBox_Revenue);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(3, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 249);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = SystemColors.ButtonHighlight;
            groupBox8.Controls.Add(label_NumberOrder);
            groupBox8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.ForeColor = SystemColors.Highlight;
            groupBox8.Location = new Point(19, 148);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(214, 83);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Số lượng đơn hàng";
            groupBox8.Enter += groupBox8_Enter;
            // 
            // label_NumberOrder
            // 
            label_NumberOrder.AutoSize = true;
            label_NumberOrder.ForeColor = SystemColors.Highlight;
            label_NumberOrder.Location = new Point(35, 38);
            label_NumberOrder.Name = "label_NumberOrder";
            label_NumberOrder.Size = new Size(18, 20);
            label_NumberOrder.TabIndex = 0;
            label_NumberOrder.Text = "0";
            // 
            // cbox_Time
            // 
            cbox_Time.FormattingEnabled = true;
            cbox_Time.Location = new Point(19, 25);
            cbox_Time.Name = "cbox_Time";
            cbox_Time.Size = new Size(151, 28);
            cbox_Time.TabIndex = 6;
            cbox_Time.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // grpBox_Revenue
            // 
            grpBox_Revenue.BackColor = SystemColors.ButtonHighlight;
            grpBox_Revenue.Controls.Add(label_RevenueMonth);
            grpBox_Revenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpBox_Revenue.ForeColor = SystemColors.Highlight;
            grpBox_Revenue.Location = new Point(19, 59);
            grpBox_Revenue.Name = "grpBox_Revenue";
            grpBox_Revenue.Size = new Size(214, 83);
            grpBox_Revenue.TabIndex = 0;
            grpBox_Revenue.TabStop = false;
            grpBox_Revenue.Text = "Doanh Thu";
            // 
            // label_RevenueMonth
            // 
            label_RevenueMonth.AutoSize = true;
            label_RevenueMonth.ForeColor = SystemColors.Highlight;
            label_RevenueMonth.Location = new Point(35, 35);
            label_RevenueMonth.Name = "label_RevenueMonth";
            label_RevenueMonth.Size = new Size(18, 20);
            label_RevenueMonth.TabIndex = 0;
            label_RevenueMonth.Text = "0";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.Highlight;
            groupBox7.Controls.Add(label_TotalProductInStock);
            groupBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.ForeColor = SystemColors.ButtonHighlight;
            groupBox7.Location = new Point(266, 348);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(228, 77);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Số sản phẩm tồn kho tháng này";
            groupBox7.Enter += groupBox7_Enter;
            // 
            // label_TotalProductInStock
            // 
            label_TotalProductInStock.AutoSize = true;
            label_TotalProductInStock.Location = new Point(38, 42);
            label_TotalProductInStock.Name = "label_TotalProductInStock";
            label_TotalProductInStock.Size = new Size(18, 20);
            label_TotalProductInStock.TabIndex = 5;
            label_TotalProductInStock.Text = "0";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Highlight;
            groupBox6.Controls.Add(label_NumberProductTSold);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.ForeColor = SystemColors.ButtonHighlight;
            groupBox6.Location = new Point(266, 431);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(228, 78);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Số lượng sản phẩm bán ra trong tháng";
            groupBox6.Enter += groupBox6_Enter;
            // 
            // label_NumberProductTSold
            // 
            label_NumberProductTSold.AutoSize = true;
            label_NumberProductTSold.Location = new Point(38, 39);
            label_NumberProductTSold.Name = "label_NumberProductTSold";
            label_NumberProductTSold.Size = new Size(18, 20);
            label_NumberProductTSold.TabIndex = 4;
            label_NumberProductTSold.Text = "0";
            // 
            // label_NumberOrderMonth
            // 
            label_NumberOrderMonth.AutoSize = true;
            label_NumberOrderMonth.Location = new Point(97, 38);
            label_NumberOrderMonth.Name = "label_NumberOrderMonth";
            label_NumberOrderMonth.Size = new Size(17, 20);
            label_NumberOrderMonth.TabIndex = 2;
            label_NumberOrderMonth.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Highlight;
            groupBox2.Controls.Add(label_NewCustomer);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(266, 515);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 82);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số khách hàng mới trong tháng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label_NewCustomer
            // 
            label_NewCustomer.AutoSize = true;
            label_NewCustomer.Location = new Point(38, 44);
            label_NewCustomer.Name = "label_NewCustomer";
            label_NewCustomer.Size = new Size(18, 20);
            label_NewCustomer.TabIndex = 5;
            label_NewCustomer.Text = "0";
            // 
            // chart_TopProduct
            // 
            chart_TopProduct.Location = new Point(500, 348);
            chart_TopProduct.Name = "chart_TopProduct";
            chart_TopProduct.Size = new Size(410, 249);
            chart_TopProduct.TabIndex = 8;
            chart_TopProduct.Text = "chart1";
            chart_TopProduct.Click += chart_TopProduct_Click;
            // 
            // Thong_Ke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 601);
            Controls.Add(chart_TopProduct);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox7);
            Controls.Add(chart_TopTypeOfProduct);
            Controls.Add(chart_DoanhThu);
            Name = "Thong_Ke";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart_DoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_TopTypeOfProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            grpBox_Revenue.ResumeLayout(false);
            grpBox_Revenue.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_TopProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_TopTypeOfProduct;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox grpBox_Revenue;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private Label label_TotalProductInStock;
        private Label label_NumberProductToSell;
        private Label label_NumberOrderDay;
        private Label label_NumberOrderMonth;
        private Label label_RevenueDay;
        private Label label_RevenueMonth;
        private ComboBox cbox_Time;
        private GroupBox groupBox2;
        private Label label_CustomerNew;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_TopProduct;
        private GroupBox groupBox8;
        private Label label_NumberOrder;
        private Label label_NumberProductTSold;
        private Label label_NewCustomer;
    }
}