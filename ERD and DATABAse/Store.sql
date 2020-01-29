create database Store


create table Supplier(Supplier_ID int IDENTITY(1,1) PRIMARY KEY, Name varchar(200) not null, Address text not null, PhoneNo varchar(100))

drop table Supplier

drop table Product
Drop Table Stock

create table Product(Product_ID int IDENTITY(1,1) PRIMARY KEY, Product_Code int not null, Name text,  size varchar(50) not null, quantity int not null, Unit_price decimal(5,2))

create table Stock(Stock_ID int IDENTITY(1,1) primary key,Supplier_ID int FOREIGN KEY REFERENCES Supplier(Supplier_ID),Product_ID int FOREIGN KEY REFERENCES Product(Product_ID),Quantity int not null, Unit_price decimal(5,2))


create table OrderTable(Order_ID int IDENTITY(1,1) primary key,Order_Date Datetime not null);

create table OrderDelivered(OrderDelivered_ID int IDENTITY(1,1),Order_ID int FOREIGN KEY REFERENCES OrderTable(Order_ID),Product_ID int FOREIGN KEY REFERENCES Product(Product_ID), SoldPrice decimal(5,2),SoldQuantity int not null)










insert into Supplier(Name,Address,PhoneNo) values('Salman Iftikhar','Model Town','9234749181')

insert into Product(Product_Code,Name,size,quantity,Unit_price) values(0001,'China Pents','medium',9,350.4)

insert into Stock(Supplier_ID,Product_ID,Quantity,Unit_price) values(1,1,9,350.4)


select  * from Supplier
select  * from Product
select  * from Stock