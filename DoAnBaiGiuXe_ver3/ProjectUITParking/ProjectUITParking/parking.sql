CREATE DATABASE Parkuitsv
USE parking

CREATE TABLE thongtinxera
(
maxe nvarchar(50) PRIMARY KEY,
thoigianra datetime NULL,
mathexe nvarchar(50),
loaixe nvarchar(10),
trangthai nvarchar(50) DEFAULT 'chua lay', 
giatien money DEFAULT 000,
mienphi char(10) DEFAULT 'khong',
mauxe nvarchar(10)
)


CREATE TABLE thongtinxevao
(
maxe nvarchar(50) PRIMARY KEY,
thoigianvao datetime,
mathexe nvarchar(50),
loaixe nvarchar(10),

mauxe nvarchar(10)
)
DROP TABLE thongkequanlyxe

CREATE TABLE thongkequanlyxe
(
maxe nvarchar(50) PRIMARY KEY,
thoigianvao datetime,
thoigianra datetime NULL,
mathexe nvarchar(50),
loaixe nvarchar(10),
trangthai nvarchar(50) DEFAULT 'chua lay', 
giatien money DEFAULT 000,
mienphi char(10) DEFAULT 'khong',
mauxe nvarchar(10)
)


)
CREATE TABLE ttnhanvien
(
MaNhanVien nvarchar(50) PRIMARY KEY,
TenNhanVien nvarchar(40),
GioiTinh nvarchar(10),
NgaySinh date,
DiaChi nvarchar(50),
DienThoai nvarchar(12),
Email nvarchar(30),
BangCap nvarchar(20),
CMND nvarchar(20),
NgayVaoLam date
)


---insert ttnhanvien --
INSERT INTO ttnhanvien VALUES ('B01','Cao Trung','Nam','1989/02/11','TP HCM','0919192144','-','trung cap',2419298,'2011/02/27')
INSERT INTO ttnhanvien VALUES ('C01','Ha Cao Nam','Nam','1990/10/10','BAC LIEU','0188213121','-','caodang',9810012,'2006/09/11')
INSERT INTO ttnhanvien VALUES ('B02','Cao Thanh Linh','Nu','1987/10/03','HA NOI','09788811','-','trung cap',331992211,'2008/07/08')
INSERT INTO ttnhanvien VALUES ('C02','Kim Linh Chau','Nu','1991/09/20','VINH LONG','01821311','-','Dai Hoc',998181100,'2015/11/28')


---insert  thongtinxevao ---
INSERT INTO thongtinxevao VALUES ('49-M10-4222','2016/5/29 07:15:20','GC01','xe tay ga','trang')
INSERT INTO thongtinxevao VALUES ('51-L09-2311','2016/5/29 07:38:00' ,'GC03','xe tay ga','trang')
INSERT INTO thongtinxevao VALUES ('64-K20-4444','2016/5/30 13:00:00' ,'GV01','xe so','den')
INSERT INTO thongtinxevao VALUES ('50-B12-3333','2016/6/01 08:00:05', 'GC11','xe tay ga','tim')
INSERT INTO thongtinxevao VALUES ('51-K81-6999','2016/6/02 09:02:52' , 'GV12','xe so','xanh')
INSERT INTO thongtinxevao VALUES ('59-K90-9870','2016/6/03 10:01:00','GC08','xe tay ga','den')
INSERT INTO thongtinxevao VALUES ('65-M22-4211','2016/6/15 20:01:43','GC09','xe tay ga','trang')
---insert thongtinxera ----
--DROP TABLE thongtinxera
--INSERT INTO thongtinxera VALUES ('49-M10-4222','2016/5/29 11:22:20','GC01','xe tay ga','da lay',2000,'khong','trang')
--INSERT INTO thongtinxera VALUES ('51-L09-2311','2016/5/29 10:38:00','GC03','xe tay ga','da lay',2000,'khong','trang')
--INSERT INTO thongtinxera VALUES ('64-K20-4444','2016/5/30 17:00:00','GV01','xe so','da lay',000,'co','den')
--INSERT INTO thongtinxera VALUES ('50-B12-3333','2016/6/01 16:20:05','GC11','xe tay ga','da lay',2000,'khong','tim')
--INSERT INTO thongtinxera VALUES ('51-K81-6999','2016/6/02 17:03:01','GV12','xe so','da lay',3000,'khong','xanh')
--INSERT INTO thongtinxera VALUES ('59-K90-9870','0/0/0','GC08','xe tay ga','chua lay',000,' ','den')

--gop 2 bang thanh 1 bang quanlythongke --
--select thongtinxera.maxe,thongtinxera.mathexe,thongtinxevao.thoigianvao,thongtinxera.thoigianra,thongtinxera.trangthai,thongtinxera.giatien,thongtinxera.mienphi,thongtinxera.loaixe,thongtinxera.hangxe,thongtinxera.mauxe
----from 

--thongtinxevao  JOIN thongtinxera ON thongtinxevao.maxe =thongtinxera.maxe 
---TINH TONG--
--SELECT sum(giatien)
--from 
--thongtinxevao  JOIN thongtinxera ON thongtinxevao.maxe =thongtinxera.maxe 
---- loc thoi gian--
insert into thongkequanlyxe(maxe,thoigianvao,thoigianra,mathexe,trangthai,giatien,mienphi,loaixe,mauxe)
select thongtinxera.maxe,thongtinxevao.thoigianvao,thongtinxera.thoigianra,thongtinxera.mathexe,thongtinxera.trangthai,thongtinxera.giatien,thongtinxera.mienphi,thongtinxera.loaixe,thongtinxera.mauxe
from  thongtinxevao  JOIN thongtinxera 
 ON thongtinxevao.maxe =thongtinxera.maxe 
--where thongtinxevao.thoigianvao =('01/06/2016 07:15,dd/MM/yyyy HH24:MI')
-----TINH TONG--


--select count(maxe)
--from thongtinxera
--where trangthai = 'chua lay'


-- xuat du lieu ra bang ttxera--
--select *
--from thongtinxevao OUTER JOIN thongtinxera
--ON thongtinxevao.maxe=thongtinxera.maxe


--INSERT thongtinxera (maxe,mathexe,loaixe,mauxe)
--SELECT  maxe,mathexe,loaixe,mauxe
--FROM thongtinxevao

