namespace HRMAPP
{
    partial class FRMDanhMucNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDanhMucNhanVien));
            panel1 = new Panel();
            date_ngaySinh = new DateTimePicker();
            masked_dienThoaiNhanVien = new MaskedTextBox();
            radio_nu = new RadioButton();
            radio_nam = new RadioButton();
            date_ngayLam = new DateTimePicker();
            txt_bangChu = new TextBox();
            txt_luong = new TextBox();
            txt_email = new TextBox();
            txt_anh = new TextBox();
            txt_diaChi = new TextBox();
            label8 = new Label();
            label5 = new Label();
            picture_nhanVien = new PictureBox();
            txt_tenNhanVien = new TextBox();
            txt_maNhanVien = new TextBox();
            btn_mo = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_timKiem = new Button();
            btn_boQua = new Button();
            btn_hienThi = new Button();
            btn_dong = new Button();
            btn_luuNhanVien = new Button();
            btn_suaNhanVien = new Button();
            btn_xoaNhanVien = new Button();
            btn_themNhanVien = new Button();
            dgv_nhanVien = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_nhanVien).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(date_ngaySinh);
            panel1.Controls.Add(masked_dienThoaiNhanVien);
            panel1.Controls.Add(radio_nu);
            panel1.Controls.Add(radio_nam);
            panel1.Controls.Add(date_ngayLam);
            panel1.Controls.Add(txt_bangChu);
            panel1.Controls.Add(txt_luong);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_anh);
            panel1.Controls.Add(txt_diaChi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(picture_nhanVien);
            panel1.Controls.Add(txt_tenNhanVien);
            panel1.Controls.Add(txt_maNhanVien);
            panel1.Controls.Add(btn_mo);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 286);
            panel1.TabIndex = 0;
            // 
            // date_ngaySinh
            // 
            date_ngaySinh.Location = new Point(605, 161);
            date_ngaySinh.Name = "date_ngaySinh";
            date_ngaySinh.Size = new Size(283, 27);
            date_ngaySinh.TabIndex = 63;
            // 
            // masked_dienThoaiNhanVien
            // 
            masked_dienThoaiNhanVien.Location = new Point(605, 117);
            masked_dienThoaiNhanVien.Mask = "(999) 000-0000";
            masked_dienThoaiNhanVien.Name = "masked_dienThoaiNhanVien";
            masked_dienThoaiNhanVien.Size = new Size(283, 27);
            masked_dienThoaiNhanVien.TabIndex = 62;
            // 
            // radio_nu
            // 
            radio_nu.AutoSize = true;
            radio_nu.Location = new Point(229, 252);
            radio_nu.Name = "radio_nu";
            radio_nu.Size = new Size(50, 24);
            radio_nu.TabIndex = 61;
            radio_nu.TabStop = true;
            radio_nu.Text = "Nữ";
            radio_nu.UseVisualStyleBackColor = true;
            // 
            // radio_nam
            // 
            radio_nam.AutoSize = true;
            radio_nam.Location = new Point(148, 252);
            radio_nam.Name = "radio_nam";
            radio_nam.Size = new Size(62, 24);
            radio_nam.TabIndex = 60;
            radio_nam.TabStop = true;
            radio_nam.Text = "Nam";
            radio_nam.UseVisualStyleBackColor = true;
            // 
            // date_ngayLam
            // 
            date_ngayLam.Location = new Point(148, 202);
            date_ngayLam.Name = "date_ngayLam";
            date_ngayLam.Size = new Size(283, 27);
            date_ngayLam.TabIndex = 59;
            // 
            // txt_bangChu
            // 
            txt_bangChu.Location = new Point(605, 251);
            txt_bangChu.Name = "txt_bangChu";
            txt_bangChu.Size = new Size(283, 27);
            txt_bangChu.TabIndex = 58;
            // 
            // txt_luong
            // 
            txt_luong.Location = new Point(605, 205);
            txt_luong.Name = "txt_luong";
            txt_luong.Size = new Size(283, 27);
            txt_luong.TabIndex = 57;
            txt_luong.TextChanged += txt_luong_TextChanged;
            txt_luong.KeyPress += txt_luong_KeyPress;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(148, 161);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(283, 27);
            txt_email.TabIndex = 52;
            // 
            // txt_anh
            // 
            txt_anh.Location = new Point(921, 60);
            txt_anh.Multiline = true;
            txt_anh.Name = "txt_anh";
            txt_anh.Size = new Size(174, 56);
            txt_anh.TabIndex = 51;
            // 
            // txt_diaChi
            // 
            txt_diaChi.Location = new Point(605, 76);
            txt_diaChi.Name = "txt_diaChi";
            txt_diaChi.Size = new Size(283, 27);
            txt_diaChi.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(921, 30);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 49;
            label8.Text = "Ảnh :";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(499, 254);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 48;
            label5.Text = "Bằng chữ :";
            // 
            // picture_nhanVien
            // 
            picture_nhanVien.Location = new Point(921, 122);
            picture_nhanVien.Name = "picture_nhanVien";
            picture_nhanVien.Size = new Size(174, 141);
            picture_nhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_nhanVien.TabIndex = 47;
            picture_nhanVien.TabStop = false;
            // 
            // txt_tenNhanVien
            // 
            txt_tenNhanVien.Location = new Point(148, 117);
            txt_tenNhanVien.Name = "txt_tenNhanVien";
            txt_tenNhanVien.Size = new Size(283, 27);
            txt_tenNhanVien.TabIndex = 39;
            // 
            // txt_maNhanVien
            // 
            txt_maNhanVien.Location = new Point(148, 75);
            txt_maNhanVien.Name = "txt_maNhanVien";
            txt_maNhanVien.Size = new Size(283, 27);
            txt_maNhanVien.TabIndex = 38;
            // 
            // btn_mo
            // 
            btn_mo.Location = new Point(1001, 22);
            btn_mo.Name = "btn_mo";
            btn_mo.Size = new Size(94, 29);
            btn_mo.TabIndex = 37;
            btn_mo.Text = "&Mở";
            btn_mo.UseVisualStyleBackColor = true;
            btn_mo.Click += btn_mo_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(519, 208);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 36;
            label12.Text = "Lương :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(496, 164);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 35;
            label11.Text = "Ngày sinh :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(492, 120);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 34;
            label10.Text = "Điện thoại :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(515, 78);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 33;
            label9.Text = "Địa chỉ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(54, 254);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 31;
            label7.Text = "Giới tính : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 208);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 30;
            label6.Text = "Ngày làm :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 164);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 28;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 27;
            label3.Text = "Tên nhân viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 79);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 26;
            label2.Text = "Mã nhân viên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(404, 13);
            label1.Name = "label1";
            label1.Size = new Size(374, 41);
            label1.TabIndex = 2;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_timKiem);
            panel2.Controls.Add(btn_boQua);
            panel2.Controls.Add(btn_hienThi);
            panel2.Controls.Add(btn_dong);
            panel2.Controls.Add(btn_luuNhanVien);
            panel2.Controls.Add(btn_suaNhanVien);
            panel2.Controls.Add(btn_xoaNhanVien);
            panel2.Controls.Add(btn_themNhanVien);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 609);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 194);
            panel2.TabIndex = 1;
            // 
            // btn_timKiem
            // 
            btn_timKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_timKiem.Image = (Image)resources.GetObject("btn_timKiem.Image");
            btn_timKiem.Location = new Point(333, 105);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(190, 61);
            btn_timKiem.TabIndex = 15;
            btn_timKiem.Text = "&Tìm kiếm nhân viên";
            btn_timKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_timKiem.UseVisualStyleBackColor = true;
            btn_timKiem.Click += btn_timKiem_Click;
            // 
            // btn_boQua
            // 
            btn_boQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_boQua.Image = (Image)resources.GetObject("btn_boQua.Image");
            btn_boQua.Location = new Point(62, 105);
            btn_boQua.Name = "btn_boQua";
            btn_boQua.Size = new Size(190, 61);
            btn_boQua.TabIndex = 14;
            btn_boQua.Text = "&Bỏ qua";
            btn_boQua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_boQua.UseVisualStyleBackColor = true;
            btn_boQua.Click += btn_boQua_Click;
            // 
            // btn_hienThi
            // 
            btn_hienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hienThi.Image = (Image)resources.GetObject("btn_hienThi.Image");
            btn_hienThi.Location = new Point(614, 105);
            btn_hienThi.Name = "btn_hienThi";
            btn_hienThi.Size = new Size(190, 61);
            btn_hienThi.TabIndex = 13;
            btn_hienThi.Text = "&Hiển thị DS";
            btn_hienThi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hienThi.UseVisualStyleBackColor = true;
            btn_hienThi.Click += btn_hienThi_Click;
            // 
            // btn_dong
            // 
            btn_dong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dong.Image = (Image)resources.GetObject("btn_dong.Image");
            btn_dong.Location = new Point(872, 105);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(190, 61);
            btn_dong.TabIndex = 12;
            btn_dong.Text = "&Đóng";
            btn_dong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dong.UseVisualStyleBackColor = true;
            btn_dong.Click += btn_dong_Click;
            // 
            // btn_luuNhanVien
            // 
            btn_luuNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_luuNhanVien.Image = (Image)resources.GetObject("btn_luuNhanVien.Image");
            btn_luuNhanVien.Location = new Point(872, 29);
            btn_luuNhanVien.Name = "btn_luuNhanVien";
            btn_luuNhanVien.Size = new Size(190, 61);
            btn_luuNhanVien.TabIndex = 11;
            btn_luuNhanVien.Text = "&Lưu ";
            btn_luuNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_luuNhanVien.UseVisualStyleBackColor = true;
            btn_luuNhanVien.Click += btn_luuNhanVien_Click;
            // 
            // btn_suaNhanVien
            // 
            btn_suaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_suaNhanVien.Image = (Image)resources.GetObject("btn_suaNhanVien.Image");
            btn_suaNhanVien.Location = new Point(614, 29);
            btn_suaNhanVien.Name = "btn_suaNhanVien";
            btn_suaNhanVien.Size = new Size(190, 61);
            btn_suaNhanVien.TabIndex = 10;
            btn_suaNhanVien.Text = "&Cập nhật nhân viên";
            btn_suaNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_suaNhanVien.UseVisualStyleBackColor = true;
            btn_suaNhanVien.Click += btn_suaNhanVien_Click;
            // 
            // btn_xoaNhanVien
            // 
            btn_xoaNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoaNhanVien.Image = (Image)resources.GetObject("btn_xoaNhanVien.Image");
            btn_xoaNhanVien.Location = new Point(333, 29);
            btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            btn_xoaNhanVien.Size = new Size(190, 61);
            btn_xoaNhanVien.TabIndex = 9;
            btn_xoaNhanVien.Text = "&Xóa nhân viên";
            btn_xoaNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_xoaNhanVien.UseVisualStyleBackColor = true;
            btn_xoaNhanVien.Click += btn_xoaNhanVien_Click;
            // 
            // btn_themNhanVien
            // 
            btn_themNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themNhanVien.Image = (Image)resources.GetObject("btn_themNhanVien.Image");
            btn_themNhanVien.Location = new Point(62, 29);
            btn_themNhanVien.Name = "btn_themNhanVien";
            btn_themNhanVien.Size = new Size(190, 61);
            btn_themNhanVien.TabIndex = 8;
            btn_themNhanVien.Text = "&Thêm nhân viên";
            btn_themNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_themNhanVien.UseVisualStyleBackColor = true;
            btn_themNhanVien.Click += btn_themNhanVien_Click;
            // 
            // dgv_nhanVien
            // 
            dgv_nhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nhanVien.Dock = DockStyle.Fill;
            dgv_nhanVien.Location = new Point(0, 286);
            dgv_nhanVien.Name = "dgv_nhanVien";
            dgv_nhanVien.RowHeadersWidth = 51;
            dgv_nhanVien.RowTemplate.Height = 29;
            dgv_nhanVien.Size = new Size(1125, 323);
            dgv_nhanVien.TabIndex = 2;
            dgv_nhanVien.CellContentClick += dgv_nhanVien_CellContentClick;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(340, 7);
            button1.Name = "button1";
            button1.Size = new Size(58, 55);
            button1.TabIndex = 64;
            button1.UseVisualStyleBackColor = true;
            // 
            // FRMDanhMucNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 803);
            Controls.Add(dgv_nhanVien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FRMDanhMucNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMDanhMucNhanVien";
            Load += FRMDanhMucNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_nhanVien).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_nhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox picture_nhanVien;
        private TextBox txt_tenNhanVien;
        private TextBox txt_maNhanVien;
        private Button btn_mo;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label5;
        private TextBox txt_diaChi;
        private TextBox txt_bangChu;
        private TextBox txt_luong;
        private TextBox txt_email;
        private TextBox txt_anh;
        private DataGridView dgv_nhanVien;
        private RadioButton radio_nu;
        private RadioButton radio_nam;
        private DateTimePicker date_ngayLam;
        private DateTimePicker date_ngaySinh;
        private MaskedTextBox masked_dienThoaiNhanVien;
        private Button btn_timKiem;
        private Button btn_boQua;
        private Button btn_hienThi;
        private Button btn_dong;
        private Button btn_luuNhanVien;
        private Button btn_suaNhanVien;
        private Button btn_xoaNhanVien;
        private Button btn_themNhanVien;
        private Button button1;
    }
}