-- lấy tên server
GO
create VIEW [dbo].[Get_Subscribes]
AS
SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
WHERE PUBS.pubid = SUBS.pubid AND  publisher <> subscriber_server AND PUBS.description <> N'Tra cứu'


--Lấy thông tin log in
GO
ALTER PROC [dbo].[SP_Lay_Thong_Tin_NV_Tu_Login] @TENLOGIN NVARCHAR(100) AS
BEGIN
	DECLARE @UID INT
	DECLARE @MANV NVARCHAR(100)
	SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
	WHERE sid = SUSER_SID(@TENLOGIN)
	IF (SELECT TrangThaiXoa FROM NhanVien WHERE MANV = @MANV) = 1 -- ĐĂNG NHẬP BẰNG TÀI KHOẢN NHÂN VIÊN ĐÃ NGHỈ
		SELECT MANV = ''
	ELSE
		SELECT MANV = @MANV, HOTEN = (SELECT HO + ' ' + TEN FROM dbo.NHANVIEN WHERE MANV=@MANV ), TENNHOM=NAME
		FROM sys.sysusers
		WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
END