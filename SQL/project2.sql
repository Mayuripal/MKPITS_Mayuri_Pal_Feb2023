create database project2;
create table course(courseid int primary key,coursename varchar(50),fees decimal(18,0));
insert into course values(12,'Java',7500),(13,'Dotnet',50000)
select * from course;

select coursename from course

create table country(countryid int primary key,countryname varchar(50));
select * from country;
insert into country values(1,'India')
insert into country values(2,'Usa')
select countryname from country where countryname='India'

create table states(stateid int primary key,statename varchar(50),countryid int ,constraint c1 foreign key (countryid) references country(countryid));
insert into states values(101,'Maharashtra',1),(102,'Washigton',2),(103,'Texas',2),(104,'Rajasthan',1)
select * from states;

create table city(cityid int primary key,cityname varchar(50),stateid int,constraint c2 foreign key (stateid) references states (stateid));
select * from city;
insert into city values (110,'Nagpur',101),(111,'Mumbai',101),(112,'olympia',102),(113,'seatlle',102),
						(114,'Austin',103),(115,'dalas',103),(116,'jaipur',104),(117,'kota',104)

create table addmision(addmisionid int primary key identity,first_name varchar(50),last_name varchar(50),gender varchar(50),contact int,countryname varchar(50),statename varchar(50),cityname varchar(50),coursename varchar(50),feesdate date,amountpaid decimal(18,0),balance decimal(18,0));

select* from addmision;