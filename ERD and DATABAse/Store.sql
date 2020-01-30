create database Store


create table Supplier(Supplier_ID int IDENTITY(1,1) PRIMARY KEY, Name varchar(200) not null, Address text not null, PhoneNo varchar(100))

drop table Supplier

drop table Product
Drop Table Stock

create table Product(Product_ID int IDENTITY(1,1) PRIMARY KEY, Product_Code int not null, Name text,  size varchar(50) not null, quantity int not null, Unit_price decimal(5,2))

create table Stock(Stock_ID int IDENTITY(1,1) primary key,Supplier_ID int FOREIGN KEY REFERENCES Supplier(Supplier_ID),Product_ID int FOREIGN KEY REFERENCES Product(Product_ID),Quantity int not null, Unit_price decimal(5,2))


create table OrderTable(Order_ID int IDENTITY(1,1) primary key,Order_Date Datetime not null);

create table OrderDelivered(OrderDelivered_ID int IDENTITY(1,1),Order_ID int FOREIGN KEY REFERENCES OrderTable(Order_ID),Product_ID int FOREIGN KEY REFERENCES Product(Product_ID), SoldPrice decimal(5,2),SoldQuantity int not null)

CREATE PROCEDURE ADD_STOCK @Product_ID int, @Supplier_ID int, @Qty int, @Unit_Price
AS

insert into Stock(Supplier_ID,Product_ID,Quantity,Unit_price) values(@Supplier_ID,@Product_ID,@Qty,@Unit_Price)

GO;


CREATE PROCEDURE ADD_STOCK @Product_ID int, @Supplier_ID int, @Qty int, @Unit_Price
AS

insert into Stock(Supplier_ID,Product_ID,Quantity,Unit_price) values(@Supplier_ID,@Product_ID,@Qty,@Unit_Price)

GO;

CREATE PROCEDURE Add_Stock
AS

SELECT * FROM Customers
GO;




create procedure Add_Supplier
@Name varchar(50),@adress varchar(50), @phoneNumber varchar(50)
as
begin
insert into Supplier(Name,Address,PhoneNo) values(@Name,@Adress,@phoneNumber)
end


EXEC add_supplier 'dada','chota','456333'


Exec Add_product 99,'dd','medium',9,34
Exec Add_product '22','aaa','Medium','3','5'


create procedure Add_Product
@Product_Code int,@Name text,@size varchar(50), @Quantity int, @Unit_Price decimal(5,2)
as
begin
insert into Product(Product_Code,Name,size,quantity,Unit_price) values(@Product_Code,@Name,@size,@Quantity,@Unit_Price)
end














insert into Supplier(Name,Address,PhoneNo) values('Salman Iftikhar','Model Town','9234749181')

insert into Product(Product_Code,Name,size,quantity,Unit_price) values(0001,'China Pents','medium',9,350.4)

insert into Stock(Supplier_ID,Product_ID,Quantity,Unit_price) values(1,1,9,350.4)


select  * from Supplier
select  * from Product
select  * from Stock