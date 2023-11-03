namespace HRMAPP
{
    partial class FRMDanhMucTimKiemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDanhMucTimKiemHoaDon));
            panel1 = new Panel();
            button1 = new Button();
            txt_tongTien = new TextBox();
            txt_nam = new TextBox();
            txt_thang = new TextBox();
            cbo_maNhanVien = new ComboBox();
            cbo_maKhachHang = new ComboBox();
            cbo_maHoaDon = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_timKiemHoaDon = new Button();
            btn_dong = new Button();
            dgv_hoaDon = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_tongTien);
            panel1.Controls.Add(txt_nam);
            panel1.Controls.Add(txt_thang);
            panel1.Controls.Add(cbo_maNhanVien);
            panel1.Controls.Add(cbo_maKhachHang);
            panel1.Controls.Add(cbo_maHoaDon);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 262);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(308, 12);
            button1.Name = "button1";
            button1.Size = new Size(58, 55);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_tongTien
            // 
            txt_tongTien.Location = new Point(774, 148);
            txt_tongTien.Name = "txt_tongTien";
            txt_tongTien.Size = new Size(321, 27);
            txt_tongTien.TabIndex = 13;
            // 
            // txt_nam
            // 
            txt_nam.Location = new Point(423, 147);
            txt_nam.Name = "txt_nam";
            txt_nam.Size = new Size(122, 27);
            txt_nam.TabIndex = 12;
            // 
            // txt_thang
            // 
            txt_thang.Location = new Point(224, 147);
            txt_thang.Name = "txt_thang";
            txt_thang.Size = new Size(122, 27);
            txt_thang.TabIndex = 11;
            // 
            // cbo_maNhanVien
            // 
            cbo_maNhanVien.FormattingEnabled = true;
            cbo_maNhanVien.Location = new Point(224, 198);
            cbo_maNhanVien.Name = "cbo_maNhanVien";
            cbo_maNhanVien.Size = new Size(321, 28);
            cbo_maNhanVien.TabIndex = 10;
            // 
            // cbo_maKhachHang
            // 
            cbo_maKhachHang.FormattingEnabled = true;
            cbo_maKhachHang.Location = new Point(774, 102);
            cbo_maKhachHang.Name = "cbo_maKhachHang";
            cbo_maKhachHang.Size = new Size(321, 28);
            cbo_maKhachHang.TabIndex = 9;
            // 
            // cbo_maHoaDon
            // 
            cbo_maHoaDon.FormattingEnabled = true;
            cbo_maHoaDon.Location = new Point(224, 102);
            cbo_maHoaDon.Name = "cbo_maHoaDon";
            cbo_maHoaDon.Size = new Size(321, 28);
            cbo_maHoaDon.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(667, 146);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 7;
            label7.Text = "Tổng tiền :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(617, 101);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 6;
            label6.Text = "Mã khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(352, 147);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 5;
            label5.Text = "Năm :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 197);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 4;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 146);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 3;
            label3.Text = "Tháng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 101);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(372, 26);
            label1.Name = "label1";
            label1.Size = new Size(501, 41);
            label1.TabIndex = 1;
            label1.Text = "DANH MỤC TÌM KIẾM HÓA ĐƠN";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_timKiemHoaDon);
            panel2.Controls.Add(btn_dong);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 166);
            panel2.TabIndex = 1;
            // 
            // btn_timKiemHoaDon
            // 
            btn_timKiemHoaDon.Image = (Image)resources.GetObject("btn_timKiemHoaDon.Image");
            btn_timKiemHoaDon.Location = new Point(357, 52);
            btn_timKiemHoaDon.Name = "btn_timKiemHoaDon";
            btn_timKiemHoaDon.Size = new Size(141, 61);
            btn_timKiemHoaDon.TabIndex = 9;
            btn_timKiemHoaDon.Text = "&Tìm Kiếm";
            btn_timKiemHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_timKiemHoaDon.UseVisualStyleBackColor = true;
            btn_timKiemHoaDon.Click += btn_timKiemHoaDon_Click;
            // 
            // btn_dong
            // 
            btn_dong.Image = (Image)resources.GetObject("btn_dong.Image");
            btn_dong.Location = new Point(570, 52);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(141, 61);
            btn_dong.TabIndex = 8;
            btn_dong.Text = "&Đóng";
            btn_dong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // dgv_hoaDon
            // 
            dgv_hoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hoaDon.Dock = DockStyle.Fill;
            dgv_hoaDon.Location = new Point(0, 262);
            dgv_hoaDon.Name = "dgv_hoaDon";
            dgv_hoaDon.RowHeadersWidth = 51;
            dgv_hoaDon.RowTemplate.Height = 29;
            dgv_hoaDon.Size = new Size(1125, 375);
            dgv_hoaDon.TabIndex = 2;
            // 
            // FRMDanhMucTimKiemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 803);
            Controls.Add(dgv_hoaDon);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FRMDanhMucTimKiemHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMDanhMucTimKiemHoaDon";
            Load += FRMDanhMucTimKiemHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgv_hoaDon;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_tongTien;
        private TextBox txt_nam;
        private TextBox txt_thang;
        private ComboBox cbo_maNhanVien;
        private ComboBox cbo_maKhachHang;
        private ComboBox cbo_maHoaDon;
        private Button btn_timKiemHoaDon;
        private Button btn_dong;
        private Button button1;
    }
}