/****** Script for SelectTopNRows command from SSMS  ******/
create table studentdata1(roll_no int ,first_name varchar(110),last_name varchar(110),courses varchar(10),city varchar(10),state varchar(10),mobile_no int)
insert into studentdata1 values(1,'mayuri','pal','dotnet','ngp','mh',2345)
insert into studentdata1 values(2,'shreya','dhakle','dotnet','ngp','mh',8345)
insert into studentdata1 values(3,'rupali','barde','dotnet','paratwada','mh',2345)
insert into studentdata1 values(4,'akansha','wahane','dotnet','tumsar','mh',2395)
insert into studentdata1 values(5,'yasmin','sheikh','dotnet','balarsha','mh',9335)
insert into studentdata1 values(6,'anjali','pathak','dotnet','kalmeshwar','mh',7345)
insert into studentdata1 values(7,'tanmay','patil','dotnet','ngp','mh',3145)
insert into studentdata1 values(8,'sahil','kalwe','dotnet','ngp','mh',3155)
insert into studentdata1 values(9,'jayesh','deshmukh','dotnet','amt','mh',4752)
insert into studentdata1 values(10,'monali','mohtkar','dotnet','savner','mh',1345)
insert into studentdata1 values(11,'tanushree','meshram','dotnet','kuhi','mh',2845)
insert into studentdata1 values(12,'karishma','panchdhare','dotnet','ngp','mh',2348)
insert into studentdata1 values(13,'ashish','lilhare','dotnet','tirora','mh',2345)


select * from studentdata1	

--query to find student of nagpur and count them--
select courses,count(*) from studentdata1
where city='ngp'
group by courses

--query to find student dosen't resides nagpur--
select * from studentdata1 where city <>'ngp'
--use (<>) for not equalto
