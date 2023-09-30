-- Tạo cơ sở dữ liệu QuanLyBanHang
CREATE DATABASE QuanLyBanHang;
GO

-- Sử dụng cơ sở dữ liệu QuanLyBanHang
USE QuanLyBanHang;
GO

-- Tạo bảng chatLieu
CREATE TABLE chatLieu (
    maChatLieu NVARCHAR(50) NOT NULL PRIMARY KEY CLUSTERED,
    tenChatLieu NVARCHAR(50) NULL
);
GO

-- Tạo bảng khach
CREATE TABLE khach (
    maKhach NVARCHAR(50) NOT NULL PRIMARY KEY CLUSTERED,
    tenKhach NVARCHAR(50) NOT NULL,
    diaChi NVARCHAR(50) NOT NULL,
    dienThoai NVARCHAR(50) NOT NULL
);
GO

-- Tạo bảng hang
CREATE TABLE hang (
    maHang NVARCHAR(50) NOT NULL PRIMARY KEY CLUSTERED,
    tenHang NVARCHAR(50) NOT NULL,
    maChatLieu NVARCHAR(50) NOT NULL,
    soLuong FLOAT(53) NOT NULL,
    donGiaNhap FLOAT(53) NOT NULL,
    donGiaBan FLOAT(53) NOT NULL,
    anh NVARCHAR(200) NOT NULL,
    ghiChu NVARCHAR(200) NULL,
    FOREIGN KEY (maChatLieu) REFERENCES chatLieu(maChatLieu)
);
GO

-- Tạo bảng nhanVien
CREATE TABLE nhanVien (
    maNhanVien NVARCHAR(50) NOT NULL PRIMARY KEY CLUSTERED,
    tenNhanVien NVARCHAR(50) NOT NULL,
    gioiTinh NVARCHAR(10) NOT NULL,
    diaChi NVARCHAR(50) NOT NULL,
    dienThoai NVARCHAR(50) NOT NULL,
    ngaySinh DATETIME NOT NULL
);
GO

-- Tạo bảng hoaDonBan
CREATE TABLE hoaDonBan (
    maHoaDon NVARCHAR(30) NOT NULL PRIMARY KEY CLUSTERED,
    maNhanVien NVARCHAR(50) NOT NULL,
    ngayBan DATETIME NOT NULL,
    maKhach NVARCHAR(50) NOT NULL,
    tongTien FLOAT(53) NOT NULL,
    FOREIGN KEY (maNhanVien) REFERENCES nhanVien(maNhanVien),
    FOREIGN KEY (maKhach) REFERENCES khach(maKhach)
);
GO

-- Tạo bảng chiTietHoaDonBan
CREATE TABLE chiTietHoaDonBan (
    maHoaDon NVARCHAR(30) NOT NULL,
    maHang NVARCHAR(50) NOT NULL,
    soLuong FLOAT(53) NOT NULL,
    donGia FLOAT(53) NOT NULL,
    giamGia FLOAT(53) NOT NULL,
    thanhTien FLOAT(53) NOT NULL,
    PRIMARY KEY CLUSTERED (maHoaDon, maHang),
    FOREIGN KEY (maHang) REFERENCES hang(maHang),
    FOREIGN KEY (maHoaDon) REFERENCES hoaDonBan(maHoaDon)
);
GO
--------------------------------------------------

INSERT INTO chatLieu (maChatLieu, tenChatLieu)
VALUES ('CL01', 'polyme');

INSERT INTO chatLieu (maChatLieu, tenChatLieu)
VALUES ('CL02', 'sợi tổng hợp');

INSERT INTO chatLieu (maChatLieu, tenChatLieu)
VALUES ('CL03', 'vải cotton');