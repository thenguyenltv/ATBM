-- Insert NHANVIEN (DOUUTIEN, LINHVUC, CHINHANH)
-- 1. DOUUTIEN: GiamDoc, TruongPhong, NhanVien
-- 2. LINHVUC: MuaBan, SanXuat, GiaCong
-- 3. CHINHANH: MienBac, MienTrung, MienNam
-- Thiet lap mot procedure de insert du lieu vao bang NHANVIEN

DECLARE
	p_DOUUTIEN VARCHAR2(50);
	p_LINHVUC VARCHAR2(50);
	p_CHINHANH VARCHAR2(50);
    counter NUMBER := 0;
    --TMP NUMBER;
BEGIN
  FOR row IN (
    SELECT *
    FROM NHANVIEN
    WHERE ROWNUM <= 300 -- NhanVien thuong
   )
  LOOP
        --Dbms_ouTput.Put_line(ROWNUM);
		if mod(counter, 3) = 0 then
			p_DOUUTIEN := 'GiamDoc';
			p_LINHVUC := 'MuaBan';
			p_CHINHANH := 'MienBac';	
		elsif mod(counter, 3) = 1 then
			p_DOUUTIEN := 'TruongPhong';
			p_LINHVUC := 'SanXuat';
			p_CHINHANH := 'MienTrung';
		else
			p_DOUUTIEN := 'NhanVien';
			p_LINHVUC := 'GiaCong';
			p_CHINHANH := 'MienNam';
		end if;

    UPDATE NHANVIEN
SET 
		LINHVUC = CASE mod(rownum, 3) WHEN 1 THEN 'MuaBan' WHEN 2 THEN 'SanXuat' ELSE 'GiaCong' END,
		CHINHANH = CASE mod(rownum, 3) WHEN 1 THEN 'MienBac' WHEN 2 THEN 'MienTrung' ELSE 'MienNam' END
WHERE STT <=300;

    counter := counter + 1;
    EXIT WHEN counter = 262;
  END LOOP;
   
  COMMIT; -- Commit the changes to the table
END;
/
ROLLBACK;
SELECT * FROM NHANVIEN;
