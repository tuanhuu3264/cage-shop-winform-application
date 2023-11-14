USE CAGE_SHOP
GO
INSERT INTO Type_Product (id, name)
VALUES ('TP_1', 'Lồng chim'),
       ('TP_2', 'Nan'),
       ('TP_3', 'Móc treo lồng chim'),
       ('TP_4', 'Nhẫn đeo chân chim'),
       ('TP_5', 'Khác');
GO
INSERT INTO Product(id,name,quantity,description,price_export,price_import,idTypeProduct,imageUrl)
VALUES('P_1', 'LỒNG CHIM 1',3,'Màu trắng, cao 800 cm', 2000000,1400000,'TP_1',''),
      ('P_2', 'NAN 1', 3,'Màu trắng, size XXL',120000,90000,'TP_2',''),
	  ('P_3','MÓC TREO LỒNG CHIM 1', 4, 'Gỗ Hương, dài 15cm',70000,50000,'TP_3',''),
	  ('P_4','NHẪN ĐEO CHÂN CHIM', 5,'SIZE XXL, MÀU ĐỎ', 30000,15000,'TP_4',''),
	  ('P_5', 'LỒNG CHIM 2',3,'Màu đen, cao 800 cm', 1900000,1400000,'TP_1',''),
      ('P_6', 'NAN 2', 3,'Màu trắng, size XXL',110000,90000,'TP_2',''),
	  ('P_7','MÓC TREO LỒNG CHIM 2', 4, 'Gỗ Hương, dài 15cm',40000,20000,'TP_3',''),
	  ('P_8','NHẪN ĐEO CHÂN CHIM ư', 5,'SIZE XXL, MÀU ĐỎ', 50000,25000,'TP_4','')
GO
INSERT INTO Customer(id,name,address,phone,createAt)
VALUES ('C_1','Trịnh Hữu Tuấn','Thủ Đức, Thành phố HCM','(090)-516-4896','2023-11-3'),
       ('C_2','Nguyễn Ngọc Tuấn','Thủ Đức, Thành phố HCM','(090)-223-4896','2023-11-3'),
	   ('C_3','Trần Trương Văn','Thủ Đức, Thành phố HCM','(090)-211-4896','2023-11-3')
GO 
INSERT INTO Staff(id,email,imageUrl,phone,name,address,gender,dateWork,salary,dateBirth,role)
VALUES('S_1','tuan@gmail.com','','(082)-234-1111','Trịnh Văn Tuấn','Tân Phú, Hồ Chí Minh','Nam','2023-9-23',2000000,'2003-08-08','staff'),
      ('S_2','tuanhuu@gmail.com','','(082)-234-2211','Trịnh Bị Tuấn','Suối Tiên, Hồ Chí Minh','Nam','2023-9-23',2000000,'2003-08-08','staff'),
	  ('S_3','thinh@gmail.com','','(084)-234-1111','Trịnh Duy Tuấn','Linh Đông, Hồ Chí Minh','Nam','2023-9-23',2000000,'2003-08-08','staff')
GO
INSERT INTO Orders(id,dateBuy,idCustomer,idStaff,total)
VALUES ('O_1','2023-09-23','C_1','S_1',2000000), 
       ('O_2','2023-09-24','C_2','S_2',1200000),
	   ('O_3','2023-09-25','C_1','S_1',2010000),
	   ('O_4','2023-10-15','C_2','S_2',2000000), 
       ('O_5','2023-10-16','C_3','S_2',1200000),
	   ('O_6','2023-10-16','C_1','S_3',2010000), 
	   ('O_7','2023-11-01','C_1','S_1',2040000), 
       ('O_8','2023-11-02','C_2','S_2',90000),
	   ('O_9','2023-11-03','C_1','S_1',110000)
GO 
INSERT INTO Order_Product (idOrder, idProduct, quantity, price, total, discount)
VALUES
('O_1', 'P_1', 1, 2000000, 2000000, 0),
('O_2', 'P_2', 2, 120000, 240000, 0),
('O_3', 'P_3', 1, 70000, 70000, 0),
('O_4', 'P_1', 1, 2000000, 2000000, 0),
('O_4', 'P_4', 1, 30000, 30000, 0),
('O_5', 'P_2', 1, 120000, 120000, 0),
('O_6', 'P_3', 2, 70000, 140000, 0),
('O_7', 'P_1', 3, 2000000, 6000000, 0),
('O_7', 'P_4', 2, 30000, 60000, 0),
('O_8', 'P_2', 2, 120000, 240000, 0),
('O_9', 'P_3', 1, 70000, 70000, 0),
('O_9', 'P_4', 1, 30000, 30000, 0);