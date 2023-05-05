create database customer;

create table cust(cust_id int primary key identity,cust_name varchar(20),mob_no bigint)
insert into cust values('shreya dhakle',9265481645),('mahima barde',8206273881),('rupali raut',8626065659),('mayuri pal',9284245381),('akanksha wahane',7839300021)


create table orders (order_id int,order_date varchar(20),cust_id int primary key identity,prod_name varchar(20),qty int,rate dec(10,2))
insert into orders values(1001,'21/2/2020','fruit',2,230.0),(002,'22/1/2020','chips',20,20.0),(003,'13/1/2020','sugar',3,80.0),(004,'11/3/2020','soap',10,40.0),(005,'23/2/2020','oil',5,160.0)

select*from cust
select *from orders

--inner join--
select o.order_id,c.cust_name,o.order_date,o.prod_name,o.qty,o.rate from cust c inner join orders o on c.cust_id=o.cust_id;