namespace HRMAPP
{
    partial class FRMHoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMHoaDonBanHang));
            panel1 = new Panel();
            button1 = new Button();
            groupBox2 = new GroupBox();
            cbo_maKhachHang = new ComboBox();
            cbo_maNhanVien = new ComboBox();
            masked_dienThoai = new MaskedTextBox();
            date_ngayBan = new DateTimePicker();
            txt_diaChi = new TextBox();
            txt_tenKhachHang = new TextBox();
            txt_tenNhanVien = new TextBox();
            txt_maHD = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cbo_maHD = new ComboBox();
            label19 = new Label();
            btn_timKiem = new Button();
            groupBox1 = new GroupBox();
            dgv_thongTinHoaDon = new DataGridView();
            panel6 = new Panel();
            txt_tongTien = new TextBox();
            txt_bangChu = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            panel5 = new Panel();
            panel7 = new Panel();
            btn_boQua = new Button();
            btn_dong = new Button();
            btn_luuHoaDon = new Button();
            btn_themHoaDon = new Button();
            btn_huyHoaDon = new Button();
            btn_inHoaDon = new Button();
            btn_luuHangHoa = new Button();
            btn_suaHangHoa = new Button();
            btn_xoaHangHoa = new Button();
            btn_themHanghoa = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            cbo_maHang = new ComboBox();
            txt_thanhTien = new TextBox();
            txt_donGia = new TextBox();
            txt_giamGia = new TextBox();
            txt_tenHang = new TextBox();
            txt_soLuong = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thongTinHoaDon).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 237);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(374, 3);
            button1.Name = "button1";
            button1.Size = new Size(58, 55);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbo_maKhachHang);
            groupBox2.Controls.Add(cbo_maNhanVien);
            groupBox2.Controls.Add(masked_dienThoai);
            groupBox2.Controls.Add(date_ngayBan);
            groupBox2.Controls.Add(txt_diaChi);
            groupBox2.Controls.Add(txt_tenKhachHang);
            groupBox2.Controls.Add(txt_tenNhanVien);
            groupBox2.Controls.Add(txt_maHD);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1119, 173);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // cbo_maKhachHang
            // 
            cbo_maKhachHang.FormattingEnabled = true;
            cbo_maKhachHang.Location = new Point(751, 33);
            cbo_maKhachHang.Name = "cbo_maKhachHang";
            cbo_maKhachHang.Size = new Size(337, 28);
            cbo_maKhachHang.TabIndex = 65;
            cbo_maKhachHang.DropDown += cbo_maKhachHang_DropDown;
            cbo_maKhachHang.SelectedIndexChanged += cbo_maKhachHang_SelectedIndexChanged;
            // 
            // cbo_maNhanVien
            // 
            cbo_maNhanVien.FormattingEnabled = true;
            cbo_maNhanVien.Location = new Point(147, 103);
            cbo_maNhanVien.Name = "cbo_maNhanVien";
            cbo_maNhanVien.Size = new Size(337, 28);
            cbo_maNhanVien.TabIndex = 64;
            cbo_maNhanVien.SelectedIndexChanged += cbo_maNhanVien_SelectedIndexChanged;
            // 
            // masked_dienThoai
            // 
            masked_dienThoai.Location = new Point(751, 138);
            masked_dienThoai.Mask = "(999) 000-0000";
            masked_dienThoai.Name = "masked_dienThoai";
            masked_dienThoai.Size = new Size(338, 27);
            masked_dienThoai.TabIndex = 63;
            // 
            // date_ngayBan
            // 
            date_ngayBan.Location = new Point(147, 71);
            date_ngayBan.Name = "date_ngayBan";
            date_ngayBan.Size = new Size(337, 27);
            date_ngayBan.TabIndex = 60;
            // 
            // txt_diaChi
            // 
            txt_diaChi.Location = new Point(751, 103);
            txt_diaChi.Name = "txt_diaChi";
            txt_diaChi.Size = new Size(338, 27);
            txt_diaChi.TabIndex = 42;
            // 
            // txt_tenKhachHang
            // 
            txt_tenKhachHang.Location = new Point(751, 68);
            txt_tenKhachHang.Name = "txt_tenKhachHang";
            txt_tenKhachHang.Size = new Size(338, 27);
            txt_tenKhachHang.TabIndex = 41;
            // 
            // txt_tenNhanVien
            // 
            txt_tenNhanVien.Location = new Point(146, 138);
            txt_tenNhanVien.Name = "txt_tenNhanVien";
            txt_tenNhanVien.Size = new Size(338, 27);
            txt_tenNhanVien.TabIndex = 40;
            // 
            // txt_maHD
            // 
            txt_maHD.Location = new Point(146, 33);
            txt_maHD.Name = "txt_maHD";
            txt_maHD.Size = new Size(338, 27);
            txt_maHD.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(651, 141);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 10;
            label9.Text = "Điện thoại :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(674, 106);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 9;
            label8.Text = "Địa chỉ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(618, 71);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 8;
            label7.Text = "Tên khách hàng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(620, 36);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 7;
            label6.Text = "Mã khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 71);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 6;
            label5.Text = "Ngày bán :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 106);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 5;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 141);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên nhân viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 36);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã hóa đơn :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(438, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 41);
            label1.TabIndex = 2;
            label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbo_maHD);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(btn_timKiem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 723);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 80);
            panel2.TabIndex = 1;
            // 
            // cbo_maHD
            // 
            cbo_maHD.FormattingEnabled = true;
            cbo_maHD.Location = new Point(136, 24);
            cbo_maHD.Name = "cbo_maHD";
            cbo_maHD.Size = new Size(337, 28);
            cbo_maHD.TabIndex = 65;
            cbo_maHD.DropDown += cbo_maHD_DropDown;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(34, 27);
            label19.Name = "label19";
            label19.Size = new Size(96, 20);
            label19.TabIndex = 19;
            label19.Text = "Mã hóa đơn :";
            // 
            // btn_timKiem
            // 
            btn_timKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_timKiem.Image = (Image)resources.GetObject("btn_timKiem.Image");
            btn_timKiem.Location = new Point(505, 7);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(185, 61);
            btn_timKiem.TabIndex = 9;
            btn_timKiem.Text = "&Tìm kiếm";
            btn_timKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_timKiem.UseVisualStyleBackColor = true;
            btn_timKiem.Click += btn_timKiem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_thongTinHoaDon);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1125, 486);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mặt hàng";
            // 
            // dgv_thongTinHoaDon
            // 
            dgv_thongTinHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongTinHoaDon.Dock = DockStyle.Fill;
            dgv_thongTinHoaDon.Location = new Point(3, 118);
            dgv_thongTinHoaDon.Name = "dgv_thongTinHoaDon";
            dgv_thongTinHoaDon.RowHeadersWidth = 51;
            dgv_thongTinHoaDon.RowTemplate.Height = 29;
            dgv_thongTinHoaDon.Size = new Size(1119, 226);
            dgv_thongTinHoaDon.TabIndex = 3;
            dgv_thongTinHoaDon.CellContentClick += dgv_thongTinHoaDon_CellContentClick;
            dgv_thongTinHoaDon.DoubleClick += dgv_thongTinHoaDon_DoubleClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(txt_tongTien);
            panel6.Controls.Add(txt_bangChu);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 344);
            panel6.Name = "panel6";
            panel6.Size = new Size(1119, 64);
            panel6.TabIndex = 2;
            // 
            // txt_tongTien
            // 
            txt_tongTien.Location = new Point(772, 10);
            txt_tongTien.Name = "txt_tongTien";
            txt_tongTien.Size = new Size(338, 27);
            txt_tongTien.TabIndex = 41;
            // 
            // txt_bangChu
            // 
            txt_bangChu.Location = new Point(92, 32);
            txt_bangChu.Name = "txt_bangChu";
            txt_bangChu.Size = new Size(338, 27);
            txt_bangChu.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(674, 13);
            label18.Name = "label18";
            label18.Size = new Size(89, 20);
            label18.TabIndex = 18;
            label18.Text = "Tổng tiền :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(9, 35);
            label17.Name = "label17";
            label17.Size = new Size(78, 20);
            label17.TabIndex = 17;
            label17.Text = "Bằng chữ :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Berlin Sans FB", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(9, 11);
            label16.Name = "label16";
            label16.Size = new Size(201, 18);
            label16.TabIndex = 17;
            label16.Text = "Nháy đúp một dòng để xóa";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 408);
            panel5.Name = "panel5";
            panel5.Size = new Size(1119, 75);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_boQua);
            panel7.Controls.Add(btn_dong);
            panel7.Controls.Add(btn_luuHoaDon);
            panel7.Controls.Add(btn_themHoaDon);
            panel7.Controls.Add(btn_huyHoaDon);
            panel7.Controls.Add(btn_inHoaDon);
            panel7.Controls.Add(btn_luuHangHoa);
            panel7.Controls.Add(btn_suaHangHoa);
            panel7.Controls.Add(btn_xoaHangHoa);
            panel7.Controls.Add(btn_themHanghoa);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, -101);
            panel7.Name = "panel7";
            panel7.Size = new Size(1119, 176);
            panel7.TabIndex = 2;
            // 
            // btn_boQua
            // 
            btn_boQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_boQua.Image = (Image)resources.GetObject("btn_boQua.Image");
            btn_boQua.Location = new Point(746, 107);
            btn_boQua.Name = "btn_boQua";
            btn_boQua.Size = new Size(172, 61);
            btn_boQua.TabIndex = 9;
            btn_boQua.Text = "&Bỏ qua";
            btn_boQua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_boQua.UseVisualStyleBackColor = true;
            btn_boQua.Click += btn_boQua_Click;
            // 
            // btn_dong
            // 
            btn_dong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dong.Image = (Image)resources.GetObject("btn_dong.Image");
            btn_dong.Location = new Point(924, 107);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(172, 61);
            btn_dong.TabIndex = 8;
            btn_dong.Text = "&Đóng";
            btn_dong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // btn_luuHoaDon
            // 
            btn_luuHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luuHoaDon.Image = (Image)resources.GetObject("btn_luuHoaDon.Image");
            btn_luuHoaDon.Location = new Point(212, 107);
            btn_luuHoaDon.Name = "btn_luuHoaDon";
            btn_luuHoaDon.Size = new Size(172, 61);
            btn_luuHoaDon.TabIndex = 7;
            btn_luuHoaDon.Text = "&Lưu hóa đơn";
            btn_luuHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_luuHoaDon.UseVisualStyleBackColor = true;
            btn_luuHoaDon.Click += btn_luuHoaDon_Click;
            // 
            // btn_themHoaDon
            // 
            btn_themHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themHoaDon.Image = (Image)resources.GetObject("btn_themHoaDon.Image");
            btn_themHoaDon.Location = new Point(34, 107);
            btn_themHoaDon.Name = "btn_themHoaDon";
            btn_themHoaDon.Size = new Size(172, 61);
            btn_themHoaDon.TabIndex = 6;
            btn_themHoaDon.Text = "&Thêm hóa đơn";
            btn_themHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_themHoaDon.UseVisualStyleBackColor = true;
            btn_themHoaDon.Click += btn_themHoaDon_Click;
            // 
            // btn_huyHoaDon
            // 
            btn_huyHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_huyHoaDon.Image = (Image)resources.GetObject("btn_huyHoaDon.Image");
            btn_huyHoaDon.Location = new Point(390, 107);
            btn_huyHoaDon.Name = "btn_huyHoaDon";
            btn_huyHoaDon.Size = new Size(172, 61);
            btn_huyHoaDon.TabIndex = 5;
            btn_huyHoaDon.Text = "&Hủy hóa đơn";
            btn_huyHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_huyHoaDon.UseVisualStyleBackColor = true;
            btn_huyHoaDon.Click += btn_huyHoaDon_Click;
            // 
            // btn_inHoaDon
            // 
            btn_inHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inHoaDon.Image = (Image)resources.GetObject("btn_inHoaDon.Image");
            btn_inHoaDon.Location = new Point(568, 107);
            btn_inHoaDon.Name = "btn_inHoaDon";
            btn_inHoaDon.Size = new Size(172, 61);
            btn_inHoaDon.TabIndex = 4;
            btn_inHoaDon.Text = "&In hóa đơn";
            btn_inHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_inHoaDon.UseVisualStyleBackColor = true;
            btn_inHoaDon.Click += btn_inHoaDon_Click;
            // 
            // btn_luuHangHoa
            // 
            btn_luuHangHoa.Location = new Point(902, 18);
            btn_luuHangHoa.Name = "btn_luuHangHoa";
            btn_luuHangHoa.Size = new Size(141, 61);
            btn_luuHangHoa.TabIndex = 3;
            btn_luuHangHoa.Text = "&Lưu";
            btn_luuHangHoa.UseVisualStyleBackColor = true;
            // 
            // btn_suaHangHoa
            // 
            btn_suaHangHoa.Location = new Point(644, 18);
            btn_suaHangHoa.Name = "btn_suaHangHoa";
            btn_suaHangHoa.Size = new Size(141, 61);
            btn_suaHangHoa.TabIndex = 2;
            btn_suaHangHoa.Text = "&Sửa";
            btn_suaHangHoa.UseVisualStyleBackColor = true;
            // 
            // btn_xoaHangHoa
            // 
            btn_xoaHangHoa.Location = new Point(363, 18);
            btn_xoaHangHoa.Name = "btn_xoaHangHoa";
            btn_xoaHangHoa.Size = new Size(141, 61);
            btn_xoaHangHoa.TabIndex = 1;
            btn_xoaHangHoa.Text = "&Xóa";
            btn_xoaHangHoa.UseVisualStyleBackColor = true;
            // 
            // btn_themHanghoa
            // 
            btn_themHanghoa.Location = new Point(92, 18);
            btn_themHanghoa.Name = "btn_themHanghoa";
            btn_themHanghoa.Size = new Size(141, 61);
            btn_themHanghoa.TabIndex = 0;
            btn_themHanghoa.Text = "&Thêm";
            btn_themHanghoa.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(1119, 95);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbo_maHang);
            panel4.Controls.Add(txt_thanhTien);
            panel4.Controls.Add(txt_donGia);
            panel4.Controls.Add(txt_giamGia);
            panel4.Controls.Add(txt_tenHang);
            panel4.Controls.Add(txt_soLuong);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1119, 95);
            panel4.TabIndex = 1;
            // 
            // cbo_maHang
            // 
            cbo_maHang.FormattingEnabled = true;
            cbo_maHang.Location = new Point(143, 17);
            cbo_maHang.Name = "cbo_maHang";
            cbo_maHang.Size = new Size(210, 28);
            cbo_maHang.TabIndex = 65;
            cbo_maHang.SelectedIndexChanged += cbo_maHang_SelectedIndexChanged;
            // 
            // txt_thanhTien
            // 
            txt_thanhTien.Location = new Point(835, 53);
            txt_thanhTien.Name = "txt_thanhTien";
            txt_thanhTien.Size = new Size(208, 27);
            txt_thanhTien.TabIndex = 47;
            // 
            // txt_donGia
            // 
            txt_donGia.Location = new Point(835, 17);
            txt_donGia.Name = "txt_donGia";
            txt_donGia.Size = new Size(208, 27);
            txt_donGia.TabIndex = 46;
            // 
            // txt_giamGia
            // 
            txt_giamGia.Location = new Point(479, 53);
            txt_giamGia.Name = "txt_giamGia";
            txt_giamGia.Size = new Size(208, 27);
            txt_giamGia.TabIndex = 45;
            txt_giamGia.TextChanged += txt_giamGia_TextChanged;
            txt_giamGia.KeyPress += txt_giamGia_KeyPress;
            // 
            // txt_tenHang
            // 
            txt_tenHang.Location = new Point(479, 17);
            txt_tenHang.Name = "txt_tenHang";
            txt_tenHang.Size = new Size(208, 27);
            txt_tenHang.TabIndex = 44;
            // 
            // txt_soLuong
            // 
            txt_soLuong.Location = new Point(145, 53);
            txt_soLuong.Name = "txt_soLuong";
            txt_soLuong.Size = new Size(208, 27);
            txt_soLuong.TabIndex = 43;
            txt_soLuong.TextChanged += txt_soLuong_TextChanged;
            txt_soLuong.KeyPress += txt_soLuong_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(744, 56);
            label15.Name = "label15";
            label15.Size = new Size(85, 20);
            label15.TabIndex = 16;
            label15.Text = "Thành tiền :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(760, 20);
            label14.Name = "label14";
            label14.Size = new Size(69, 20);
            label14.TabIndex = 15;
            label14.Text = "Đơn giá :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(371, 56);
            label13.Name = "label13";
            label13.Size = new Size(102, 20);
            label13.TabIndex = 14;
            label13.Text = "Giảm giá (%) :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(397, 20);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 13;
            label12.Text = "Tên hàng :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(63, 56);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 12;
            label11.Text = "Số lượng :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(63, 20);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 11;
            label10.Text = "Mã hàng :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // FRMHoaDonBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 803);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FRMHoaDonBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMHoaDonBanHang";
            Load += FRMHoaDonBanHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_thongTinHoaDon).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgv_thongTinHoaDon;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label18;
        private Label label17;
        private Label label16;
        private Panel panel7;
        private Button btn_luuHoaDon;
        private Button btn_themHoaDon;
        private Button btn_huyHoaDon;
        private Button btn_inHoaDon;
        private Button btn_luuHangHoa;
        private Button btn_suaHangHoa;
        private Button btn_xoaHangHoa;
        private Button btn_themHanghoa;
        private Button btn_dong;
        private Label label19;
        private Button btn_timKiem;
        private TextBox txt_diaChi;
        private TextBox txt_tenKhachHang;
        private TextBox txt_tenNhanVien;
        private TextBox txt_maHD;
        private TextBox txt_tongTien;
        private TextBox txt_bangChu;
        private TextBox txt_thanhTien;
        private TextBox txt_donGia;
        private TextBox txt_giamGia;
        private TextBox txt_tenHang;
        private TextBox txt_soLuong;
        private DateTimePicker date_ngayBan;
        private MaskedTextBox masked_dienThoai;
        private ComboBox cbo_maNhanVien;
        private ComboBox cbo_maKhachHang;
        private ComboBox cbo_maHD;
        private ComboBox cbo_maHang;
        private Button btn_boQua;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}