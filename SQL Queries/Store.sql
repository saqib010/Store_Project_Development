create database Store

----------///////////////////////////////////////////////////////
----------///////////////////////////////////////////////////////
----------///////////////////////////////////////////////////////
--_--------Tables
----------///////////////////////////////////////////////////////
create table Supplier(Supplier_ID int IDENTITY(1,1) PRIMARY KEY, Name varchar(200) not null, Address text not null, PhoneNo varchar(100))

drop table peoduct

drop table Product
Drop Table OrderTable

select * from Supplier

create table Product(Product_ID int IDENTITY(1,1) PRIMARY KEY, Product_Code int not null, Name text,  size varchar(50) not null, Unit_price decimal(15,2))

create table Stock(Stock_ID int IDENTITY(1,1) primary key,Supplier_ID int FOREIGN KEY REFERENCES Supplier(Supplier_ID),Product_ID int FOREIGN KEY REFERENCES Product(Product_ID),Quantity int not null,Total_Sale decimal(15,2))


create table OrderTable(Order_ID int IDENTITY(1,1) primary key,Order_Date Datetime not null,order_profit decimal(15,2));

create table OrderDelivered(OrderDelivered_ID int IDENTITY(1,1),Order_ID int FOREIGN KEY REFERENCES OrderTable(Order_ID),Product_ID int FOREIGN KEY REFERENCES Product(Product_ID), SoldPrice decimal(5,2),SoldQuantity int not null,Single_Profit decimal(15,0),Total_Bill decimal(15,2),Total_Profit decimal(15,2))


ALTER OrderTable
alter order_profit null ;
ALTER TABLE OrderTable MODIFY (order_profit NULL);

@order_profit=(select sum(single_profit) from OrderDelivered where Order_ID=(select max(Order_ID) from OrderTable))

insert into OrderTable(Order_Date,order_profit) values (GETDATE(),null)
select * from OrderTable

select max(Unit_price) 
from Product
where Product_Code=85
update OrderTable set order_profit=67.4 where Order_ID=(Select max(Order_ID) from OrderTable)



select Unit_Price from product where product_Code=551


exec take_order 551,2,800,11.00


select * from OrderTable
select * from OrderDelivered
exec Display_Stock








--////////  Add Order Panel //////////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
drop procedure Take_Order
select * from Product
exec take_order 3344,10,46000,322.00
exec display_stock
select * from OrderTable
select * from OrderDelivered
insert into OrderTable(Order_Date,order_profit) values(GETDATE(),0)
select * from OrderTable 

exec take_order 551,10,1000,91.00

create procedure Display_Order
as 
begin

select * 
end


Exec Add_Product 'saas',302,'pentiees','ExtraLarge',8,800



drop table OrderTable



select * from Supplier
----////////////////////////////////////////////
----////////////////////////////////////////////
----////////////////////////////////////////////
----/////////////////// Take Order/////////////////////////
----////////////////////////////////////////////
----////////////////////////////////////////////
exec Display_Stock

select * from orderTable
select * from OrderDelivered

drop procedure Take_Order
exec Take_Order 544,10,500,50
drop procedure Take_Order
create procedure Take_Order
@Product_code int,@sold_quantity int, @Sold_Unit_Price varchar(50),@single_profit decimal(15,2)
as
begin
Declare @order_profit decimal(15,2)
Declare @Product_ID int 
SET @Product_ID=(Select Product_ID from Product where Product_Code=@Product_code)
--Declare @final_bill decimal(15,2)
 if exists (select * from Stock where Product_ID=@Product_ID and Quantity>@sold_quantity)
--IF exists( Select * From tb_login as l Where l.username=@name and l.password=@pass)  
  
Begin  
insert into OrderDelivered (Order_ID,Product_ID,SoldPrice,SoldQuantity,Single_Profit,Total_profit,Total_Bill) values ((Select max(Order_ID) from OrderTable),(@Product_ID),@Sold_Unit_Price,@sold_quantity,@single_profit,@single_profit*@sold_quantity,@Sold_Unit_Price*@sold_quantity)
update Stock set Quantity= Quantity-@sold_quantity where Product_ID= @Product_ID

       select 1 
End  
   
Else  
   
Begin  
       select 0 
end   

--insert into OrderTable(Order_Date,order_profit) values(GETDATE(),0)

select Product_Code from Product where Product_ID=18;

end
truncate table OrderTable
drop table OrderDelivered

exec display_order
select * from OrderDelivered
select * from OrderTable

/////////////////////////////////
----////////////////////////////////////////////
----/////////////////// Total Bill/////////////////////////
----////////////////////////////////////////////
----///////////
drop procedure total_amount
create proc total_amount -- to calculate the total amount of product purchased
as
begin
Declare @order_profit decimal(15,2)
Declare @Last_order int
set @Last_order=(select max(Order_ID) from OrderTable)
set @order_profit=(select sum(Total_Profit) from OrderDelivered where Order_ID=@Last_order)
IF exists( select sum(d.total_Bill) as Total from OrderDelivered d where d.Order_ID=@Last_order)  
  
Begin  
update OrderTable set order_profit=@Order_profit where Order_ID=(Select max(Order_ID) from OrderTable)
select sum(d.total_Bill) as Total from OrderDelivered d where d.Order_ID=(select max(Order_ID) from OrderTable)
insert into OrderTable(Order_Date,order_profit) values(GETDATE(),0)
       
End  
   
Else  
   
Begin  
       select 0 
end   


end

select Supplier_ID from Stock where Product_ID=22



select * from OrderDelivered where Product_ID=22

--///////Supplier Sold Product Details///////////////////
--//////////////////////////////
--///////////////////////////////
--////////////////////////////

drop procedure Supplier_Product
create procedure Supplier_Product
@supplierName varchar(500)
as 
begin
Declare @Supplier_ID int
set @Supplier_ID=(select Supplier_ID from Supplier where Name=@supplierName)

if exists (select Product_ID from stock where Supplier_ID=@Supplier_ID)
begin
select (select Order_Date from OrderTable where Order_ID=o.Order_ID) as Date,(select name from Product where Product_ID=o.Product_ID) as Name,(select Unit_price from Product where Product_ID=o.Product_ID) as Unit_Price,o.SoldQuantity,o.SoldPrice,o.Single_Profit,total_profit,total_Bill
from OrderDelivered o
where product_ID in
(select Product_ID from stock where Supplier_ID=@Supplier_ID)
end
else
begin
select 0
end
end
exec Supplier_Product 'Zehan'
--///////Total Sale///////////////////
--//////////////////////////////
--///////////////////////////////
--////////////////////////////
drop procedure TotalSale
create procedure TotalSale
@SupplierName varchar(500)
as
begin
if exists (select Product_ID from stock where Supplier_ID=21)
begin
select sum(o.Total_Bill)as TotalSale,sum(o.Total_Profit) as Total_Profit
from OrderDelivered o
where product_ID in
(select Product_ID from stock where Supplier_ID=(select Supplier_ID from Supplier where Name=@SupplierName))
end
else
begin
select 0
end
end






exec Display_Stock

select * from Supplier where Supplier_ID=23




--////////  Add Supplier Procedure //////////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
drop procedure Add_Supplier
create procedure Add_Supplier
@Name varchar(50),@adress varchar(50), @phoneNumber varchar(50)
as
begin
if exists (Select * from Supplier where name=@Name)
begin 
select 0
end
else 
begin 
insert into Supplier(Name,Address,PhoneNo) values(@Name,@Adress,@phoneNumber)
select 1
end 

end

--///////////Add Product Procedure///////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
--//////////////////////////////////////////////////////
drop procedure Add_Product
create procedure Add_Product
@SupplierName varchar(50),@Product_Code int,@Name text,@size varchar(50), @Quantity int, @Unit_Price decimal(15,2)
as
begin

declare @Supplier_ID int
set @Supplier_ID=(select Supplier_ID from Supplier where name like @SupplierName)
IF exists( Select Supplier_ID from Supplier where name like @SupplierName)
Begin
if exists (Select * from Product where Product_Code=@Product_Code)
BEGIN
SELECT 0
END
ELSE
BEGIN
insert into Product(Product_Code,Name,size,Unit_price) values(@Product_Code,@Name,@size,@Unit_Price)
insert into Stock(Supplier_ID,Product_ID,Quantity,Total_Sale) values(@Supplier_ID ,(Select max(Product_ID) from Product),@Quantity,@Quantity*@Unit_price)
select 1
END
End  
Else  
Begin  
       select 0 
end   
end




Exec Add_Product 'GFC Fan',179,'SSSS','ExtraLarge',2,2222

Exec Add_product 'Taimoor',85,'Pajamaaa','ExtraLarge',9,892
select * from Stock
select * from Product

exec Add_Product 'Taimoor',911,'Kurta','medium',9,55
select * from Stock
Truncate table Stock
----//////Display Stock Procedure//////////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////
--////////////////////////////////////////////

CREATE PROCEDURE Display_Stock
AS
begin
select Supplier.name as Supplier, Product.Name as Product,Product_Code,Stock.Quantity,Product.Unit_price as Rate,Total_Sale as TotalAmount
from Stock
join Supplier on Stock.Supplier_ID=Supplier.Supplier_ID
join Product on Stock.Product_ID=Product.Product_ID
end

drop procedure Display_Order
exec Display_Order

----//////Display Order Procedure//////////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////
--////////////////////////////////////////////

CREATE PROCEDURE Display_Order
AS
begin
select o.Order_ID,P.Name as Product,P.Product_Code,o.SoldQuantity,o.total_bill,OrderTable.order_profit as total_profit

from OrderDelivered o
join Product p on o.Product_ID=P.Product_ID
join OrderTable on o.Order_ID=OrderTable.Order_ID
end



select Name
from Product
where Product_ID in(
select Product_ID
from OrderDelivered where Product_ID
in (select Product_ID from Stock where Supplier_ID=21))



----//////Display Order Procedure//////////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////
--////////////////////////////////////////////
----////////////////////////////////////////////
----/////////////////// Total Bill/////////////////////////
----////////////////////////////////////////////
----///////////
Exec Add_Product 'Saqib',987,'pakistan','Medium',9,550
select Product_ID,Single_Profit
from OrderDelivered where Product_ID
in (select Product_ID from Stock where Supplier_ID=21)
truncate table Supplier
select * from Supplier

select Supplier_ID from Stock
where Product_ID=21


insert into Supplier(Name,Address,PhoneNo) values('Salman Iftikhar','Model Town','9234749181')

insert into Product(Product_Code,Name,size,quantity,Unit_price) values(0001,'China Pents','medium',9,350.4)

insert into Stock(Supplier_ID,Product_ID,Quantity,Unit_price) values(1,1,9,350.4)


select  * from Supplier
select  * from Product
select  * from Stock