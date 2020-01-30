/** procedures*//
create proc display_Stock-- to display  stock names
As 
begin 
begin try 
begin transaction

select s.Stock_ID,p.Name as Product,su.Name as Suplier,s.Quantity as Quantity,s.Unit_price as Unit_Price
from Product p  inner join Stock s 
on s.Product_ID = p.Product_ID inner join 
Supplier su on su.Supplier_ID = s.Supplier_ID

commit transaction
end try
begin catch
rollback transaction
end catch
end
--/////////////////////////////////
--//////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////////

--////////////////////////
--//////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////////
create proc ord_detail -- to display order record 
@idd int 
As 
begin 
begin try 
begin transaction

select o.Order_ID,p.Name as Product,p.Unit_price,d.SoldQuantity as Quantity ,d.SoldPrice as total_Price
from Product p inner join OrderDelivered d
on d.Product_ID=p.Product_ID inner join OrderTable o
on o.Order_ID = d.Order_ID 
where o.Order_ID = @idd
commit transaction
end try
begin catch
rollback transaction
end catch
end

select * from OrderTable
--//////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////////


create proc total_bill -- to calculate the total amount of product purchased
@id int
as
begin 
select sum(d.SoldPrice) as Total from OrderDelivered d where Order_ID=@id;
end

select * from OrderDelivered
select * from OrderTable
select * from Product

