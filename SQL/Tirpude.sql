create database Tirpude;
create table studentexamdetail(rollno int primary key,firstname varchar (10),lastname varchar(10),marks int,city varchar(10),state varchar(10),mobileno int)

select * from studentexamdetail
insert into studentexamdetail values (1,'neha','shah',78,'Nagpur','MH',8266489)
insert into studentexamdetail values (2,'kirti','roy',70,'Chindwara','MP',8296489)
insert into studentexamdetail values (3,'gaurav','thange',89,'Nagar','MH',8261289)
insert into studentexamdetail values (4,'shivani','gupta',67,'Nagpur','MH',8260489)
insert into studentexamdetail values (5,'neha','patil',68,'Amravati','MH',8263489)
insert into studentexamdetail values (6,'rushi','yadav',59,'Bihar','UP',8266439)
insert into studentexamdetail values (7,'amruta','jadhav',98,'satara','MH',8266439)
insert into studentexamdetail values (8,'vaishu','mankar',81,'Akola','MH',8896489)
insert into studentexamdetail values (9,'mihir','shah',78,'Jaipur','RJ',8278189)
insert into studentexamdetail values (10,'ishan','deshmukh',98,'Pune','MH',8217489)

create table studentfeesdetail(rollno int primary key,firstname varchar (10),lastname varchar(10),fees int,month varchar(10))
select *from studentfeesdetail 

insert into studentfeesdetail values (1,'neha','shah',1200,'jan')
insert into studentfeesdetail values (2,'kirti','roy',1000,'dec')
insert into studentfeesdetail values (3,'gaurav','thange',1100,'jan')
insert into studentfeesdetail values (4,'shivani','gupta',1000,'feb')
insert into studentfeesdetail values (5,'neha','patil',1200,'dec')
insert into studentfeesdetail values (6,'rushi','yadav',1200,'feb')
insert into studentfeesdetail values (7,'amruta','jadhav',1000,'dec')
insert into studentfeesdetail values (8,'vaishu','mankar',1300,'jan')
insert into studentfeesdetail values (9,'mihir','shah',1200,'feb')
insert into studentfeesdetail values (10,'ishan','deshmukh',1250,'feb')


--query list student detail in Ascending order by first name--
select firstname,lastname from studentexamdetail order by firstname

--query list student detail in Ascending order by first name,last name--
select firstname,lastname from studentexamdetail order by firstname,lastname

--query list student detail in Decending order by first name--
select firstname,lastname from studentexamdetail order by firstname desc

--query list student detail resident of nagpur--
select firstname, COUNT(*) from studentexamdetail where city='Nagpur' group by firstname

--query list student detail for fees paid by month of feb--
select * from studentfeesdetail where month='feb' order by firstname

--query list student by paid fees --
select firstname,fees,month  from studentfeesdetail order by fees 

--query list student by marks score --
select TOP 10  *from studentexamdetail order by marks DESC

--query to find marks between range--
select * from studentexamdetail where marks between 70 and 80 

--QUERY to find whose mark in range--
select * from studentexamdetail where marks in (78,89)

--QUERY to find whose mark not in range--
select * from studentfeesdetail where month not in ('feb')

--query to use like clause --
select *from studentexamdetail where state like 'MH'
		