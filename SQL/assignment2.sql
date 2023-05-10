create database sales;
create table salesman(salesman_id int primary key,name varchar(20),city varchar (20),commision dec(10,2))
insert into salesman values(5001,'James Hoog','New York ', 0.15),
							(5002,'Nail Knite','Paris',0.13),
							(5005,'Pit Alex ','london',0.11),
							(5006,'Mc Lyon','paris',0.14),
							(5007,'Paul Adam','Rome',0.13),
							(5003,'Lauson Hen','San Jose',0.12)
			-----query to display all the information of all salesmen
			select * from salesman
			-----query to display specific columns like name and commission for all the salesmen
		select name,commision from salesman

create table orders(ord_no int primary key,purch_amt dec(10,2),ord_date varchar(20),cust_id int,salesman_id int,
constraint o foreign key (salesman_id) references salesman(salesman_id))

insert into orders values (70001,150.5,'2012-10-05 ' ,3005 , 5002),
(70009 ,270.65,'2012-09-10',3001,5005),
(70002,65.26,'2012-10-05',3002,5001),
(70004 ,110.5,'2012-08-17', 3009,5003),
(70007,948.5,'2012-09-10',3005,5002),
(70005,2400.6,'2012-07-27',3007,5001),
(70008,5760,'2012-09-10',3002,5001)

		------query to display the columns in a specific order like order date, salesman id,
		----order number and purchase amount from for all the orders.
select ord_date,salesman_id,ord_no,purch_amt from orders

		------query to find the unique salespeople ID. Return salesman_id
select distinct salesman_id from orders

		--------query to find the salespeople who lives in the City of 'Paris'.
			----Return salesperson's name, city. 
select name,city from salesman where city='paris'

create table customer(cust_id int primary key,cust_name varchar(20),cust_city varchar(20),grade int,salesman_id int,
constraint c foreign key (salesman_id) references salesman(salesman_id));

		---query to find those customers whose grade is 200. 
		----Return customer_id, cust_name, city, grade, salesman_id.