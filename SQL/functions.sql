create table product_qty(id int identity primary key,Region varchar(10),product varchar(10),year int,quantity int,price dec(10,2))

select *from product_qty

insert into product_qty values('east','computer',2020,130,50000.00)
insert into product_qty values('south','computer',2020,450,35000.00)
insert into product_qty values('north','computer',2020,250,40000.00)
insert into product_qty values('east','harddisc',2020,190,5500.00)
insert into product_qty values('west','computer',2021,250,45000.00)
insert into product_qty values('south','harddisc',2021,550,4400.00)
insert into product_qty values('west','harddisc',2021,650,7500.00)
insert into product_qty values('east','pendrive',2021,120,800.00)
insert into product_qty values('north','mouse',2019,160,1500.00)
insert into product_qty values('south','pendrive',2019,270,750.00)
insert into product_qty values('east','mouse',2019,2000,1200.00)
insert into product_qty values('west','pendrive',2019,190,650.00)

SELECT MAX(Quantity) AS "Maximum Quantity" FROM product_qty;  --to find max quantity

SELECT Min(Quantity) AS "Maximum Quantity" FROM product_qty;  ---to find min quantity

select product,quantity ,price from product_qty where quantity=(select min (quantity) from product_qty);   --to find min quantity using where

select product,quantity ,price from product_qty where quantity=(select max (quantity) from product_qty);   --to find max quantity using where

select product ,min (quantity) as"min quantity" from product_qty group by product;   --to find min quantity using group by

select product ,max (quantity) as"min quantity" from product_qty group by product;   --to find max quantity using group by

SELECT product, MIN(quantity) AS "Min Quantity" FROM product_qty GROUP BY product HAVING MIN(quantity)>100;  --to find min quantity using group by & having in quantity

SELECT product, MIN(quantity) AS "Min Quantity" FROM product_qty GROUP BY product HAVING MAX(quantity)>500;  --to find max quantity using group by & having in quantity

