create database CAGE_SHOP;
go
use CAGE_SHOP;
go
create table Material(
    id varchar(6) primary key, 
    name varchar(100) 
);
go
create table Product(
    id varchar(6) primary key, 
    name varchar(100), 
	type varchar(15),
	price money, 
	quantity int,
	description varchar(max),
	idMaterial varchar(6) foreign key references Material(id)
);
go
create table Account(
    id varchar(6) primary key,
	email varchar(max),
	role varchar(10),
    phonenumber varchar(11), 
    name varchar(100), 
    address varchar(max), 
	gender varchar(6), 
	dateCreate date, 
	salary money, 
	dateBirth date
);
go
create table Orders(
    id varchar(6) primary key, 
    dateBuy date, 
    total money, 
	receiver varchar(max),
	address varchar(max),
    phonenumber varchar(11),
	idCustomer varchar(6) foreign key references Account(id),
    idStaff varchar(6) foreign key references Account(id)
);
go
create table Order_Product(
    idProduct varchar(6) foreign key references Product(id), 
	idOrder varchar(6) foreign key references Orders(id),
    quantity int, 
    price money 
);
go 
create table Image_Product(
 idProduct varchar(6) foreign key references Product(id), 
 imageUrls varchar(max)
);
go 
create table Image_Staff(
 idStaff varchar(6) foreign key references Account(id), 
 imageUrls varchar(max)
);
go 
create table Voucher(
 id varchar(6) primary key, 
 content varchar(max), 
 value int, 
 dateStart date, 
 dateEnd date
);
go 
create table Product_Voucher(
 idProduct varchar(6) foreign key references Product(id),
 idVoucher varchar(6) foreign key references Voucher(id)
);