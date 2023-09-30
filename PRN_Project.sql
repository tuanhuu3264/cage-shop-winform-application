create database CAGE_SHOP;
go
use CAGE_SHOP;
go
CREATE TABLE Material(
    id NVARCHAR(6) PRIMARY KEY,
    name NVARCHAR(100)
);

CREATE TABLE Product(
    id NVARCHAR(6) PRIMARY KEY,
    name NVARCHAR(100),
    type NVARCHAR(15),
    imageUrl NVARCHAR(MAX),
    price_import MONEY,
    price MONEY,
    quantity INT,
    description NVARCHAR(MAX),
    idMaterial NVARCHAR(6) REFERENCES Material(id)
);
CREATE TABLE Customer(
    id NVARCHAR(6) NOT NULL PRIMARY KEY CLUSTERED,
    name NVARCHAR(50) NOT NULL,
    address NVARCHAR(50) NOT NULL,
    phone NVARCHAR(50) NOT NULL,
    createAt DATE
);
CREATE TABLE Staff(
    id NVARCHAR(6) PRIMARY KEY,
    email NVARCHAR(MAX),
    role NVARCHAR(10),
    imageUrl NVARCHAR(MAX),
    phone NVARCHAR(11),
    name NVARCHAR(100),
    address NVARCHAR(MAX),
    gender NVARCHAR(6),
    dateWork DATE,
    salary MONEY,
    dateBirth DATE
);

CREATE TABLE Orders(
    id NVARCHAR(6) PRIMARY KEY,
    dateBuy DATE,
    total MONEY,
    receiver NVARCHAR(MAX),
    address NVARCHAR(MAX),
    phonenumber NVARCHAR(11),
    idCustomer NVARCHAR(6) REFERENCES Customer(id),
    idStaff NVARCHAR(6) REFERENCES Staff(id)
);

CREATE TABLE Order_Product(
    idProduct NVARCHAR(6) REFERENCES Product(id),
    idOrder NVARCHAR(6) REFERENCES Orders(id),
    quantity INT,
    price MONEY
);

CREATE TABLE Report(
    id NVARCHAR(6) PRIMARY KEY,
    content NVARCHAR(MAX),
    title NVARCHAR(100),
    idStaff NVARCHAR(6) REFERENCES Staff(id)
);
