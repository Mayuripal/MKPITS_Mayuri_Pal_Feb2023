---create database---
create database country;
---create table----
create table country_detail(country_id int primary key,country_name varchar(20));
---insert detail----
insert into country_detail values(1,'India'),(2,'USA')

create table state_detail(state_id int primary  key identity,state_name varchar(20),country_id int ,constraint a1 foreign key(country_id) references country_detail(country_id));
insert into state_detail (state_name,country_id)values('Maharashtra',1),('MP',1),('Washington',2),('Texas',2)

create table city_detail (city_id int primary key,city_name varchar(20),state_id int,constraint c1 foreign key(state_id) references state_detail(state_id));
insert into city_detail values(1,'Nagpur',1),(2,'Mumbai',1),(3,'Pune',1),(4,'Indore',2),(5,'Bhopal',2),(6,'Ujjain',2),(7,'Seattle',3),(8,'Tacoma',3),(9,'Spokane',3),(10,'Houston',4),(11,'San Antonio',4),(12,'Dallas',4)

select*from city_detail
select *from state_detail
select *from country_detail

		-------query to find state using country id--------
select c1.country_id,c1.country_name,s1.state_name from country_detail c1 inner join state_detail s1 on c1.country_id= s1.country_id where c1.country_name='india';
select c1.country_id,c1.country_name,s1.state_name from country_detail c1 inner join state_detail s1 on c1.country_id= s1.country_id where c1.country_name='usa';

---can also be written in this way ----
select s1.state_name from country_detail c1 inner join state_detail s1 on c1.country_id= s1.country_id where c1.country_name='india';

select ct.city_name from city_detail ct inner join state_detail s1 on ct.state_id= s1.state_id where s1.state_name='maharashtra';

----sub-query for state-----
select state_name from state_detail where country_id =
(select country_id from country_detail where country_name ='india' );

---sub-query for city------
select city_name from city_detail where state_id =
(select state_id from state_detail where state_name ='texas' );

create table course(course_id int primary key,course_name varchar(20));
insert into course values(1,'Dotnet'),(2,'java')

create table student(stud_id int primary key,stud_name varchar(20),course_id int,constraint c foreign key(course_id) references course (course_id));
insert into student values(1,'amit',1),(2,'asha',2),(3,'arti',1),(4,'ashish',2)

select *from student
select *from course

-----query using sub query-----
select stud_name from student where course_id =(select course_id from course where course_name ='dotnet');

-----query using inner join-----
select s.stud_name ,c.course_name from student s inner join course c ON s.course_id=c.course_id where course_name='dotnet';