create database QLBSACH
use QLBSACH

create table TacGia(
	MaTG varchar(5) not null primary key,
	TenTG nvarchar(100) not null,
	DiaChiTG nvarchar(100) not null
	)

create table TheLoai(
	MaTL varchar(10) not null primary key,
	TenTL nvarchar(50) not null
	)

create table Sach (
	MaSach varchar(5) not null primary key,
	TenSach nvarchar(100) not null,
	TenTG nvarchar(100) not null,
	NgayXB date not null,
	MaTL varchar(10) not null foreign key references TheLoai(MaTL)
	)

create table Sach_TG(
	MaSach varchar(5) not null foreign key references Sach(MaSach),
	MaTG varchar(5) not null foreign key references TacGia(MaTG)
	primary key(MaSach,MaTG)
	)

create table KhachHang(
	MaKH varchar(10) not null primary key,
	TenKH nvarchar(50) not null,
	GioiTinh bit not null,
	DiaChiKH nvarchar(100) null, 
	DienThoaiKH varchar(20) null,
	NgaySinh date not null
	)

create table DungCu(
	MaDC varchar(5) not null primary key,
	TenDC nvarchar(20) not null,
	DVT nvarchar(10) not null,
	GiaBanDC money not null 
	)

create table ChiTietHDS(
	MaHDS varchar(10) not null primary key,
	MaSach varchar(5) not null foreign key references Sach(MaSach),
	SoLuongSach int not null,
	GiaBanS money not null
	)

create table ChiTietHDDC(
	MaHDDC varchar(10) not null primary key,
	MaDC varchar(5) not null foreign key references DungCu(MaDC),
	SoLuongDC int not null,
	GiaBanDC money not null
	)

create table HoaDon(
	SoHD varchar(10) not null primary key,
	MaHDS varchar(10) not null foreign key references ChiTietHDS(MaHDS),
	/*MaHDDC varchar(10) null foreign key references ChiTietHDDC(MaHDDC),*/
	NgayBan date,
	MaKH varchar(10) not null foreign key references KhachHang(MaKH), 
	)

create table NhaXuatBan (
	MaNXB nvarchar(10) not null primary key,
	TenNXB nvarchar(50) not null,
	DiaChiNXB nvarchar(100) not null, 
	DienThoai varchar(20) null
	)

create table NhaCungCap (
	MaNCC nvarchar(10) not null primary key,
	TenNCC nvarchar(50) not null,
	DiaChiNCC nvarchar(100) not null, 
	SDTNCC varchar(20) not null,
	MaNXB nvarchar(10) not null foreign key references NhaXuatBan(MaNXB)
	)

create table ChiTietPNS(
	SoCTPNS varchar(10) primary key,
	SoLuongNhapS int not null,
	GiaNhapS money not null,
	MaSach varchar(5) not null foreign key references Sach(MaSach)
	)

create table ChiTietPNDC(
	SoCTPNDC varchar(10) primary key,
	SoLuongNhapDC int not null,
	GiaNhapDC money not null,
	MaDC varchar(5) not null foreign key references DungCu(MaDC)
	)

create table PhieuNhap(
	SoPN varchar(5) not null primary key,
	SoCTPNS varchar(10) not null foreign key references ChiTietPNS(SoCTPNS),
	/*SoCTPNDC varchar(10) null foreign key references ChiTietPNDC(SoCTPNDC),*/
	NgayNhap date not null,
	MaNCC nvarchar(10) not null foreign key references NhaCungCap(MaNCC)
	)

insert into TacGia values
    ('TG01','Ernest Hemingway','Oak Park, Illinois, Chicago'),
    ('TG02',N'Tố Hữu', N'631 Võ Văn Tần,Đà Nẵng'),
    ('TG03','Haruki Murakami',N'Tp Ashiya ở tỉnh Hy,ogo'),
    ('TG04',N'Nguyễn Nhật Ánh',N'Bình Quế, Thăng Bình, Quảng Nam'),
    ('TG05',N'Nguyễn Du', N'5A Trần Hưng Đạo,Q1,TPHCM'),
    ('TG06',N'Kim Lân',N'Tân Hồng, Từ Sơn, Bắc Ninh'),
    ('TG07','Jules Verne ',N'Tp Nantes, Pháp'),
    ('TG08','Ern Fagway','Oa Luhok, Iminois, Chi Bacago')

insert into TheLoai values
    ('HK',N'Hồi ký'),
    ('TT',N'Tiểu thuyết'),
    ('TD',N'Truyện dài'),
    ('TTH',N'Truyện thơ')

INSERT INTO Sach VALUES
    ('S01',N'Chuông nguyện hồn ai','Ernest Hemingway','5/12/1940','TT'),
    ('S02',N'Nhớ lạ một thời',N'Tố Hữu','10/10/2000','HK'),
    ('S03',N'Người tình Sputnik','Haruki Murakami','1/19/1999','HK'),
    ('S04',N'Mắt biếc',N'Nguyễn Nhật Ánh','8/8/1990','TD'),
    ('S05',N'Truyện Kiều',N'Nguyễn Du','11/9/1820','TTH'),
    ('S06',N'Vợ Nhặt',N'Kim Lân','5/22/1998','TT'),
    ('S07',N'Lên Cung trăng','Jules Verne ','6/7/1990','TT'),
    ('S08',N'Lên Hương','Mai Đạt','5/12/2000','TD')



insert into Sach_TG values
	('S01','TG01'),
	('S01','TG07'),
	('S02','TG02'),
	('S02','TG05'),
	('S02','TG03'),
	('S03','TG04'),
	('S03','TG06'),
	('S04','TG01'),
	('S04','TG05'),
	('S05','TG02'),
	('S05','TG04'),
	('S06','TG06'),
	('S07','TG03'),
	('S07','TG01')

INSERT INTO KhachHang VALUES 
	('KH001',N'Nguyễn Văn Thành',0,N'24 Hoàng Văn Thụ,Nha Trang,KH','0987636728','1/9/1999'),
	('KH002',N'Trương Thị Thanh Hằng',1,N'782 Ngô Quyền,Q6,TPHCM','0898362886','12/8/1995'),
	('KH003',N'Võ Hoài Lâm',0,N'156 Phan Chu Trinh,TPHCM','0384623682','7/31/1994'),
	('KH004',N'Hoàng Thị Như Quỳnh',1,N'93 Nguyễn Trãi,Phú Yên','0782377278','9/15/1990'),
	('KH005',N'Lê Thanh Thảo',1,N'109 Hùng Vương','0783876837','10/10/1985'),
	('KH006',N'Đặng Thị Thảo Vy',1,N'78 Lê Hồng Phong,Nha Trang,KH','0983623678','6/24/1989'),
	('KH007',N'Ngô Nguyễn Thành Nam',0,N'36 Nhị Hà, Nha Trang,KH','0866465293','3/29/1979')

INSERT INTO DungCu VALUES
	('DC01',N'Cục tẩy',N'Cái',8000),
	('DC02',N'Màu tô',N'Hộp',13000),
	('DC03',N'Bảng ghi',N'Cái',9500),
	('DC04',N'Vở ghi',N'Cuốn',7000),
	('DC05',N'Bút chì',N'Cây',4000),
	('DC06',N'Bút bi',N'Cây',5000),
	('DC07',N'Hộp bút',N'Hộp',16500)

INSERT INTO ChiTietHDS VALUES
	('CTHDS01','S07',10,20000),
	('CTHDS02','S06',5,34000),
	('CTHDS03','S05',15,15000),
	('CTHDS04','S04',7,35000),
	('CTHDS05','S01',40,45000),
	('CTHDS06','S02',3,27000),
	('CTHDS07','S03',25,25000)

INSERT INTO ChiTietHDDC VALUES
	('CTHDDC01','DC01',5,10000),
	('CTHDDC02','DC02',2,15000),
	('CTHDDC03','DC03',12,12000),
	('CTHDDC04','DC04',63,8000),
	('CTHDDC05','DC05',15,5000),
	('CTHDDC06','DC06',33,6000),
	('CTHDDC07','DC07',18,17000)

INSERT INTO HoaDon VALUES
	('HD01','CTHDS01',null,'01/20/2020','KH001'),
	('HD02','CTHDS03','CTHDDC06','01/02/2020','KH002'),
	('HD03','CTHDS02',null,'05/02/2020','KH003'),
	('HD04','CTHDS04',null,'11/04/2020','KH004'),
	('HD05','CTHDS05','CTHDDC03','02/05/2020','KH005'),
	('HD06','CTHDS06',null,'06/16/2020','KH006'),
	('HD07','CTHDS07','CTHDDC01','09/08/2020','KH007'),
	('HD08','CTHDS01',null,'12/20/2020','KH001')
	



INSERT INTO NHAXUATBAN VALUES 
	('GD',N'NXB Giáo Dục',N'5A Trần Hưng Đạo,Q1,TPHCM','0957357287'),
	('GTVT',N'Giao Thông Vận Tải',N'459 Trưng Vương, Hà Nội','0295496352'),
	('KD',N'NXB Kim Đồng',N'967 Lê Hồng Phong,Q10,TPHCM','0967843568'),
	('LSVM',N'Lịch Sử Văn Minh',N'125 Trần Bình Trọng,TPHCM','0867354085'),
	('PNB',N'Phương Nam Book',N'34 Bà Rịa, Vũng Tàu','0888527752'),
	('VH',N'NXB Văn Học',N'09 Nguyễn Thái Học,Q1,TPHCM','0989835276'),
	('NN',N'NXB Nhã Nam',N'631 Võ Văn Tần,Đà Nẵng','0784735276'),
('TP',N'NXB Tư pháp.',N'5A Trần Hưng Đạo,Lâm Đồng','0957087287')


INSERT INTO NHACUNGCAP VALUES 
	('NCC01',N'Cty TNHH Đỗ Gia Phát',N'Cầu Giấy, Hà Nội','0984867231','NN'),
	('NCC02',N'Trung Ương Đoàn TNCS HCM',N'33 Hoàng Văn Thụ, Q9, TPHCM','0994863733','KD'),
	('NCC03',N'NXB Giao Thông Vận Tải',N'823 Đinh Tiên Hoàng, Q2,TPHCM','0965275285','GTVT'),
	('NCC04',N'Bộ Giáo Dục và Đào Tạo',N'978 Quang Trung, Hà Nội','0637572876','GD'),
	('NCC05',N'NXB Tổng Hợp TPHCM',N'864 Nguyễn Thị Minh Khai, Q1,TPHCM','0836345634','PNB'),
	('NCC06',N'Đại Học Quốc Gia Hà Nội',N'873 Duy Tân,Cầu Giấy,Hà Nội','0375834678','LSVM'),
	('NCC07',N'Hội Nhà Văn',N'98 Trần Hưng Đạo,Hà Nội','0936478432','VH')

insert into ChiTietPNS VALUES 
	('CTPNS01',200,15000,'S01'),
    ('CTPNS02',175,25000,'S02'),
   	('CTPNS03',155,12000,'S03'),
   	('CTPNS04',130,30000,'S04'),
   	('CTPNS05',180,40000,'S05'),
   	('CTPNS06',190,17000,'S06'),
   	('CTPNS07',174,19000,'S07'),
	('CTPNS08',100,20000,'S03')


insert into ChiTietPNDC VALUES 
	('CTPNDC01',50,7000,'DC01'),
	('CTPNDC02',50,12000,'DC02'),
	('CTPNDC03',70,8000,'DC03'),
	('CTPNDC04',80,6000,'DC04'),
	('CTPNDC05',100,3000,'DC05'),
	('CTPNDC06',68,4000,'DC06'),
	('CTPNDC07',96,15000,'DC07')

insert into PhieuNhap VALUES 
	('PN01','CTPNS05',null,'02/11/2019','NCC01'),
	('PN02','CTPNS01','CTPNDC05','12/08/2019','NCC02'),
	('PN03','CTPNS03',null,'03/05/2019','NCC03'),
	('PN04','CTPNS07',null,'04/09/2019','NCC04'),
	('PN05','CTPNS02','CTPNDC02','11/01/2019','NCC05'),
	('PN06','CTPNS06','CTPNDC06','05/05/2019','NCC06'),
	('PN07','CTPNS04',null,'12/20/2019','NCC07'),
	('PN08','CTPNS08','CTPNDC04','02/11/2019','NCC04'),
	('PN09','CTPNS05',null,'01/11/2019','NCC07')



/* Thủ tục */
--Thêm sách mới:
CREATE PROCEDURE pr_THEM_SACH(
    @MaSach varchar(5),
    @TenSach nvarchar (100),
    @TenTG nvarchar(100),
    @NgayXB datetime,
    @MaTL varchar(10)
) AS
    BEGIN
        insert into Sach(MaSach, TenSach, TenTG, NgayXB, MaTL)
        values(@MaSach, @TenSach, @TenTG, @NgayXB, @MaTL)
    END;

--drop proc pr_THEM_SACH
--exec pr_THEM_SACH 'S011',N'Lên Cung trăng','Jules Verne ','6/7/1990','TT'
--Xóa sách
CREATE PROCEDURE pr_XOA_SACH(
    @MaSach VARCHAR(5)
) AS
    BEGIN
        DELETE FROM Sach
        WHERE MaSach = @MaSach 
    END;

--drop proc pr_XOA_SACH
--select* from Sach
--delete from Sach_TG where MaSach = 'S07'
exec pr_XOA_SACH 'S07'
--Tìm kiếm sách theo thể loại
CREATE PROCEDURE pr_TIM_KIEM(
    @TenTL NVARCHAR(50)
)AS 
    BEGIN
        IF(EXISTS(SELECT TenSach
                FROM Sach a, TheLoai b
                WHERE a.MaTL = b.MaTL and b.TenTL = @TenTL)
                )
            SELECT TenSach
            FROM Sach a, TheLoai b
            WHERE a.MaTL = b.MaTL and b.TenTL = @TenTL
        ELSE 
            PRINT N'Xin lỗi, nhà sách chưa mở bán thể loại sách: ' + '' + CAST(@TenTL AS NVARCHAR(50));
    END;
--drop proc pr_TIM_KIEM
/* Hàm */
--Hiển thị thứ trong tuần tương ứng với ngày tháng năm 
/*
CREATE FUNCTION fu_Thu
(
	@ngay DATETIME
)
RETURNS NVARCHAR(10)
AS
     BEGIN
          DECLARE @result NVARCHAR(10)
          SELECT @result = CASE DATEPART(DW,@ngay)
                        WHEN 1 THEN N'Chủ nhật'
                        WHEN 2 THEN N'Thứ hai'
                        WHEN 3 THEN N'Thứ ba'
                        WHEN 4 THEN N'Thứ tư'
                        WHEN 5 THEN N'Thứ năm'
                        WHEN 6 THEN N'Thứ sáu'
                        ELSE N'Thứ bảy'
                      END   
          RETURN (@result) 
END;		 */
--drop function fu_Thu
--SELECT MaSach, TenSach, (dbo.fu_Thu(NgayXB) + ',' + CONVERT(nvarchar(10),NgayXB,103) )AS 'Thứ ngày đầy đủ'
--FROM Sach

--Đếm số lượng phiếu nhập mà nhà cung cấp cung cấp cho nhà sách
CREATE FUNCTION fu_DEMSLPN(@MaNCC VARCHAR(10))
RETURNS INT  
AS
	BEGIN
		DECLARE @temp INT 
		SET @temp = (
		SELECT COUNT(b.SoPN) 
		FROM NhaCungCap a, PhieuNhap b
		WHERE a.MaNCC = b.MaNCC and a.MaNCC = @MaNCC)
		RETURN @temp
	END;

--drop function fu_DEMSLPN
--select dbo.fu_DEMSLPN('NCC01') AS 'Số lượng sách nhà cung cấp cung cấp'
--from NhaCungCap

/* Trigger */
--Đặt giới hạn sách nhập vào ngăn nhân viên nhập thêm sách vào
CREATE TRIGGER tr_GH_Sach ON Sach FOR INSERT
AS
	IF(SELECT COUNT(MaSach) FROM Sach) > 15
	BEGIN
		PRINT N'Bạn không thể nhập quá 10 quyển sách'
		ROLLBACK TRAN
	END;
--drop trigger tr_GH_Sach
--exec pr_THEM_SACH 'S08',N'Lên Cung trăng','Jules Verne ','6/7/1990','TT'
--select* from Sach

--Ngăn xoá 2 bản ghi trong bảng khách hàng đồng thời
CREATE TRIGGER tr_DouDel ON Sach FOR DELETE
AS
	IF((SELECT COUNT(MaSach) FROM Sach) < 2)
	BEGIN
		ROLLBACK TRAN
    END;

--drop trigger tr_DouDel
--select* from Sach
--delete from Sach where MaSach = 'S09' and MaSach = 'S10'

--Không cho phép xóa người trên 30 tuổi
CREATE TRIGGER tr_DelBefore ON KhachHang FOR DELETE
AS
	BEGIN
		DECLARE @COUNT INT = 0;
		SELECT @COUNT = COUNT(*) FROM KhachHang 
		WHERE YEAR(GETDATE()) - YEAR(KhachHang.NgaySinh) > 30
		IF(@COUNT > 0)
		BEGIN 
			PRINT N'Không được xóa khách hàng trên 30 tuổi'
			ROLLBACK TRAN
		END;
	END;

/*INSERT INTO KhachHang VALUES
('KH008',N'Đặng Thị Thảo Vy',1,N'78 Lê Hồng Phong,Nha Trang,KH','0983623678','6/24/1999'),
	('KH009',N'Ngô Nguyễn Thành Nam',0,N'36 Nhị Hà, Nha Trang,KH','0866465293','3/29/1975')	   */
/*
	DROP TRIGGER tr_DelBefore
select* from KhachHang
delete from KhachHang where MaKH ='KH009'	 */
	
/*use master;
create login group3_1 with password = '123456789';
alter login group3_1 with default_database = QL_BanSach_NT;
use QL_BanSach_NT;
create user group3_user1 for login group3_1;
grant select on object::HoaDon to group3_user1;

-- login thì tạo ở master
use master;
create login group3_2 with password = '123456789';
alter login group3_2 with default_database = QL_BanSach_NT;
use QL_BanSach_NT; -- Tạo, gán quyền cho user thì vào database user đó dùng
create user group3_user2 for login group3_2;
grant update on object::DungCu to group3_user2; 

use master;
create login group3_3 with password = '123456789';
alter login group3_3 with default_database = QL_BanSach_NT;
use QL_BanSach_NT;
create user group3_user3 for login group3_3;
grant insert on object::Sach to group3_user3;


create role group3_user_role;
alter role group3_user_role add member group3_user;	  */