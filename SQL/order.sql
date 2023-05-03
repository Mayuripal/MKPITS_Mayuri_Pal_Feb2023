create table orders(order_no int primary key,order_date varchar(20),cust_id int )

create table order_detail(order_no int,prod_id int ,rate int ,quantity int ,constraint t1 foreign key (order_no) references orders (order_no) )

select * from order_detail
select *from orders

insert into orders values (1,'12/2/2022',212)
insert into order_detail values (1,123,200,2)
insert into order_detail values (1,124,500,1)

insert into orders values (2,'12/1/2023',213)
insert into order_detail values (2,123,200,1)
insert into order_detail values (2,125,600,2)

insert into orders values (3,'12/2/2023',214)
insert into order_detail values (1,125,600,1)
