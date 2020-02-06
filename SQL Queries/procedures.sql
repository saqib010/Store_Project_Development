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

--////////////////////////
--//////////////////////////////////////////////////////////////
--//////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////////
/*
create proc update_stock -- to display order record 
@supname varchar(100),
@prodcode int,
@prodname varchar(100),
@quantity int 
As 
begin 
begin try 
begin transaction

declare @prod_id int,
		@stok_id int,
		@sup_id int

set @prod_id = (select p.Product_ID
from Product as p
where p.Product_Code=@prodcode and convert(varchar,p.Name) = @prodname)

set @sup_id = (select s.Supplier_ID
from Supplier as s
where s.Name=@supname)

set @stok_id = (select st.Stock_ID from Stock st where st.Product_ID=@prod_id and st.Supplier_ID=@sup_id)

update Stock set Quantity = ((select  Quantity from Stock where Stock_ID=@stok_id)+@quantity) where Stock_ID =@stok_id

commit transaction
end try
begin catch
rollback transaction
end catch
end

exec update_stock 'Salman Iftikhar',3,'China pants',11**/

create proc update_stock -- to calculate the total amount of product purchased
@stock_id int,
@quantity int
as
begin 
update Stock set Quantity = ((select  Quantity from Stock where Stock_ID=@stock_id)+@quantity) where Stock_ID =@stock_id
end
