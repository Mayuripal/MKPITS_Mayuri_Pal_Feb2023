create database details;
create table customer(cust_id int primary key,first_name varchar(20),last_name varchar(20),phone bigint,email varchar(30),street varchar(20),city varchar(20),state varchar(20),zipcode int)
create table orders(o_id int primary key,cust_id int,o_status varchar(20),o_date varchar(20),required_date varchar(20),shipped_date varchar(20),store_id int,staff_id int,constraint c foreign key (cust_id) references customer(cust_id));

insert into customer values(1,'amit','kumar',937284928,'amit12@gmail','civil lines','Nagpur','Mh',440021),
							(2,'nita','das',978284844,'das31@gmail','hinjewadi','pune','mh',440031),
							(3,'amit','gupta',9372454928,'amit72@gmail','sita streets','bhopal','Mp',220140),
							(4,'sita','kumar',937281228,'sita12@gmail','dattawadi','Nagpur','Mh',440021),
							(5,'ria','sharma',939300032,'ria51@gmail','wardhaman nagar','indore','mp',444023)

insert into orders values(101,1,'dispatched','23/4/23','28/4/23','27/4/23',10001,90012),
						(102,4,'dispatched','23/2/23','8/3/23','2/4/23',10001,90012),
						(103,2,'dispatched','23/4/22','28/5/22','29/5/23',10001,90013),
						(104,3,'dispatched','23/1/23','28/4/23','30/4/23',10001,90012),
						(105,5,'dispatched','2/4/20','3/4/20','2/5/23',10001,90013)

						select *from customer
						select *from orders

-----1 query -----
select o_id,o_date,cust_id from orders where cust_id in (select cust_id from customer where city='nagpur')order by o_date desc;

-----2 query ------
select o_id ,cust_id,o_date,staff_id
from orders								---outer query ---
where cust_id 
in (select cust_id from customer where city='pune');		---sub query---

----3 query----
select o_id from orders where staff_id=90012;