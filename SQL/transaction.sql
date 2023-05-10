create table product(
prod_id int primary key,
prod_name varchar(20),
price int,
quantity int )

insert into product values(111,'mobile',10000,10),
(112,'laptop',45000,15),
(113,'mouse',250,20),
(114,'harddisk',4000,25),
(115,'speaker',3000,20)

select *from product

----start new transaction
begin transaction
----sql statement
insert into product values (116,'headphone',2000,30)
update product set price =450 where prod_id=114
-----comit changes
commit transaction

----start new transaction
begin transaction
----sql statement

update product set price =5000 where prod_id=114
delete from product where prod_id=116

set implicit_transactions on 
----start a new transaction 
begin transaction
---sql statement
update product set price=5000 where prod_id=114
delete from product where prod_id =116
---undo changes
rollback transaction
