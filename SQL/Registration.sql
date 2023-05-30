create database Registration;

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

create table TableCourseRegDetail(CourseRegId int primary key identity,CategoryId int,FullName varchar(150) ,GenderId int );
select * from TableCourseRegDetail;

create table TableRegAddress(RegAddressId int primary key identity,CourseRegId int,Nationid int ,Stateid int,Cityid int,
	constraint a1 foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId),
	constraint a2 foreign key(Nationid) references Nation(Nationid),
	constraint a3 foreign key(Stateid) references State(Stateid),
	constraint a4 foreign key(Cityid) references City(Cityid));
select * from TableRegAddress;

create table TableFeeDetail1(FeeId int primary key identity,CourseRegId int,TotalAmount decimal(18,0),MinPer decimal(18,0),PaidAmount decimal(18,0),BalAmount decimal(18,0),PaidDate datetime, constraint d1 foreign key (CourseRegId) references TableCourseRegDetail(CourseRegId));
select * from TableFeeDetail1;


---------- Query ------------------------------
----------
--Query to  nation name
select Nationname from Nation

--Query to select State according to nation name
select s.statename from state s inner join Nation n on s.Nationid=n.Nationid where n.Nationname='India';

--Query to select City according to state name 
select c.Cityname from City c inner join State s on c.Stateid=s.Stateid where s.Statename='Punjab';

--Query 
			------course detail ------
insert into TableCourseRegDetail values --(@CategoryId,@FullName,@GenderId)

			------Reg Address ------
select top 1 CourseRegId from TableCourseRegDetail order by CourseRegId desc

insert into TableRegAddress values --(@CourseRegId,@nationid,@stateid,@cityid)

				------fee detail -----
insert into TableFeeDetail1 values --(@CourseRegId,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)