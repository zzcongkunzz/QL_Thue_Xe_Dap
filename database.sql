Use QL_Thue_Xe_Dap;

create table tbl_NhomNguoiDung
(
    idNhomNguoiDung int	primary key identity(1,1),
    tenNhom nvarchar(255),
    quyen nvarchar(255)
);

create table tbl_NhanVien
(
    maNV varchar(255) primary key,
    idNhomNguoiDung int references tbl_NhomNguoiDung(idNhomNguoiDung),
    tenNV nvarchar(255) not null,
    taiKhoan varchar(255) UNIQUE,
    matKhau varchar(255),
    email varchar(255),
    sdt varchar(15),
    gioiTinh nvarchar(15),
    ngaySinh date,
    diaChi nvarchar(255)
);

create table tbl_KhachHang
(
    maKH varchar(255) primary key,
    tenKH nvarchar(255) not null,
    cccd varchar(255) not null UNIQUE,
    email varchar(255),
    sdt varchar(15) not null UNIQUE,
    gioiTinh nvarchar(15),
    ngaySinh date,
    diaChi nvarchar(255)
);

create table tbl_Xe
(
    maXe varchar(255) primary key,
    tenXe nvarchar(255) not null,
    trangThai bit,
    tenLoai nvarchar(255),
    giaXe float,
    giaThue float,
    moTa text
);

create table tbl_BienBanDenDu
(
    maBienBan varchar(255) primary key,
    maKH varchar(255) references tbl_KhachHang(maKH),
    maNV varchar(255) references tbl_NhanVien(maNV),
    ngayDenBu datetime,
    moTa text
);

create table tbl_ChiTietBanDenBu
(
    maBienBan varchar(255) references tbl_BienBanDenDu(maBienBan),
    maXe varchar(255) references tbl_Xe(maXe),
    tienDenBu float
);

create table tbl_PhieuDatCoc
(
    maPhieu varchar(255) primary key,
    maKH varchar(255) references tbl_KhachHang(maKH),
    maNV varchar(255) references tbl_NhanVien(maNV),
    ngayDatCoc datetime,
    tongTien float
);

create table tbl_ChiTietPhieuDatCoc
(
    maPhieu varchar(255) references tbl_PhieuDatCoc(maPhieu),
    maXe varchar(255) references tbl_Xe(maXe),
    tienDatCoc float
);

create table tbl_HoaDonThueXe
(
    maHoaDon varchar(255) primary key,
    maKH varchar(255) references tbl_KhachHang(maKH),
    maNV varchar(255) references tbl_NhanVien(maNV),
    ngayThueXe datetime,
    ngayTra datetime,
    tongTien float
);

create table tbl_ChiTietHoaDonThue
(
    maHoaDon varchar(255) references tbl_HoaDonThueXe(maHoaDon),
    maXe varchar(255) references tbl_Xe(maXe),
    giaThue float
);

Insert Into tbl_NhomNguoiDung(tenNhom, quyen)
values (N'Nhân viên', 'NhanVien')

Insert Into tbl_NhomNguoiDung(tenNhom, quyen)
values (N'Admin', 'Admin')

Insert Into tbl_NhomNguoiDung(tenNhom, quyen)
values (N'Quản Lý Xe', 'QLXe')

SELECT * FROM tbl_NhomNguoiDung
GO

Insert Into tbl_NhanVien(maNV, idNhomNguoiDung, tenNV, taiKhoan, matKhau )
values ('nv0', 1, N'Công', 'b', '3e23e8160039594a33894f6564e1b1348bbd7a0088d42c4acb73eeaed59c009d')
-- Mật khẩu tài khoản này là chữ b sau khi đã đực mã hóa.

Go

INSERT INTO tbl_Xe(maXe, tenXe, trangThai, tenLoai, giaXe, giaThue)
values ('x1', 'qw', 0, N'sịn', 1000000, 20000)

INSERT INTO tbl_Xe(maXe, tenXe, trangThai, tenLoai, giaXe, giaThue)
values ('x2', 'qw2', 0, N'sịn', 2000000, 30000)

INSERT INTO tbl_Xe(maXe, tenXe, trangThai, tenLoai, giaXe, giaThue)
values ('x3', 'qw3', 0, N'sịn', 3000000, 40000)

INSERT INTO tbl_Xe(maXe, tenXe, trangThai, tenLoai, giaXe, giaThue)
values ('x4', 'aa1', 0, N'thường', 500000, 10000)

INSERT INTO tbl_Xe(maXe, tenXe, trangThai, tenLoai, giaXe, giaThue)
values ('x5', 'aa2', 0, N'thường', 400000, 5000)

INSERT INTO tbl_Xe(maXe, tenXe, trangThai, tenLoai, giaXe, giaThue)
values ('x6', 'fff', 0, N'đểu', 100000, 1000)


Insert Into tbl_KhachHang(maKH, tenKH, cccd, email, sdt, diaChi)
values ('kh1', N'ấd', '0352658899', 'sklfj@gmail.com', '06589774556', N'4sakdjhsakdádkhj')

-- 0 là đang còn trống
-- 1 là đang được sử dụng
UPDATE tbl_Xe
SET trangThai = 0;
