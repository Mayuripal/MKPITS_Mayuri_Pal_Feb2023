create database Institute;
create table Nation(Nationid int primary key,Nationname varchar(500));
select * from Nation;
insert into Nation values (1,'India'),(2,'United-Nation'),(3,'Nepal'),(4,'Sri Lanka');

create table State(Stateid int primary key,Nationid int,Statename varchar(500) ,constraint s1 foreign key (Nationid) references Nation(Nationid));
select * from State;
insert into State values (101,1,'Andra Pradesh'),(102,1,'Punjab'),(103,2,'California'),(104,2,'Florida'),(105,3,'Koshi'),(106,3,'Bagmati'),(107,4,'Colombo'),(108,4,'Ratnapura');

create table City(Cityid int primary key,Stateid int ,Cityname varchar(500), constraint c1 foreign key (Stateid) references State(Stateid));
select * from City;
insert into City values(1001,101,'Visakhapatnam'),(1002,101,'Vijaywada'),(1003,101,'Guntur'),(1004,102,'Amritsar'),(1005,102,'Jalandar'),
					   (1006,102,'Chindighar'),(1007,103,'Los Angeles'),(1008,103,'San Joes'),(1009,103,'San Diego'),(1010,104,'Jacksonville'),
					   (1011,104,'Miami'),(1012,104,'Tampa'),(1013,105,'Damak'),(1014,105,'Dharan'),(1015,105,'Bhiratnagar'),
					   (1016,106,'Banepa'),(1017,106,'Bharatpur'),(1018,106,'Hetauda'),(1019,107,'Grandpass'),(1020,107,'Borella'),
					   (1021,107,'Pettah'),(1022,108,'Balangoda'),(1023,108,'Kolonna');

create table CourseRegDetail(CourseRegId int primary key,CategoryId int,FullName varchar(150) ,GenderId int )
select * from CourseRegDetail;

create table RegAddress(RegAddressId int primary key,CourseRegId int,Nationid int ,Stateid int,Cityid int,
	constraint r1 foreign key(CourseRegId) references CourseRegDetail(CourseRegId),
	constraint r2 foreign key(Nationid) references Nation(Nationid),
	constraint r3 foreign key(Stateid) references State(Stateid),
	constraint r4 foreign key(Cityid) references City(Cityid));
select * from RegAddress;

create table FeeDetail(FeeId int primary key identity,CourseRegId int,TotalAmount decimal(18,0),MinPer decimal(18,0),PaidAmount decimal(18,0),BalAmount decimal(18,0),PaidDate datetime, constraint f1 foreign key (CourseRegId) references CourseRegDetail(CourseRegId));
select * from FeeDetail;



----------
----------
insert into CourseRegDetail values (4,1,'Ravi',1),
								   (5,2,'Riya',2),
								   (6,1,'Anita',2),
								   (7,1,'Amit',1),
								   (8,2,'jay',1)

insert into RegAddress values (1,4,4,102,1003),
							(2,5,2,103,1009),
							(3,6,2,104,1012),
							(4,7,1,101,1002),
							(5,8,2,103,1007)

insert into FeeDetail values(1,4,1000,0,500,500,2023-04-10),
							(2,8,3000,0,200,800,2023-04-10),
							(3,5,1000,500,600,400,2023-04-10),
							(4,6,3000,2400,2400,600,2023-04-10),
							(5,7,3000,500,1000,2000,2023-04-10);


							-------------------------------------------------------------------------------------------------------------------------
select s.statename from state s inner join Nation n on s.Nationid=n.Nationid where n.Nationname='India';

select c.Cityname from City c inner join State s on c.Stateid=s.Stateid where s.Statename='Punjab';