CREATE TABLE Lop (
    MaLop nvarchar(50) PRIMARY KEY,
    TenLop nvarchar(100)
);

CREATE TABLE SinhVien (
    MaSV nvarchar(50) PRIMARY KEY,
    HoTen nvarchar(100),
    NgaySinh datetime,
    GioiTinh nvarchar(10),
    Email nvarchar(100),
    MaLop nvarchar(50) FOREIGN KEY REFERENCES Lop(MaLop)
);