	------stored procedure
select *from products
insert into products(product_name,unit_price) values('keyboard',300),('desktop',45000),('mouse',360)

select product_name,unit_price from products order by product_name;

create procedure prod1
as
begin
select* from products
end;

----execute a stored procedure 
exec prod1

-------------mofifying-----------
--alter--
alter procedure prod1
as
begin
select 
product_name ,unit_price 
from products
order by 
unit_price 
end;

exec prod1

--delete--
drop procedure prod1;

exec prod1;

--with 1 parameter
create procedure findproduct12
as
begin
select product_name,unit_price
from products 
order by unit_price;
end;

exec findproduct12

select * from products

----this time we can add a parameter to the stored procedure 
----prices are greater than an input price:
create proc prod3(@minprice as decimal)
as
begin
select*from products
where unit_price >@minprice
order by unit_price
end;

exec prod3 120
exec prod3 350

create proc pp2(@pn as varchar(20))
as
begin
select *from products
where product_name=@pn

end;

exec pp2 'mouse'

----with 2 parameter
create proc prod4(@pname as varchar(20),@p as decimal)
as
begin
select *from products
where product_name = @pname
and unit_price >= @p		---greater than equals to
order by product_name
end;

exec prod4 'mouse',120

-----creating a stored procedure with multiple parameters
create proc prod7(@minp as decimal,@maxp as decimal)
as
begin
select * from products
where unit_price > @minp and unit_price < @maxp
order by product_name
end;

exec prod7 120,500

alert procedure findproducts(@min_unit_price as decimal
