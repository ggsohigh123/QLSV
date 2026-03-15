CREATE DATABASE QLSV;
GO
USE QLSV;
GO

CREATE TABLE Lop (
    MaLop nvarchar(50) PRIMARY KEY, 
    TenLop nvarchar(100)            
);
GO
CREATE TABLE SinhVien (
    MaSV nvarchar(50) PRIMARY KEY,  
    HoTen nvarchar(100),            
    NgaySinh datetime,              
    GioiTinh nvarchar(10),          
    Email nvarchar(100),            
    MaLop nvarchar(50),             
    CONSTRAINT FK_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);
GO