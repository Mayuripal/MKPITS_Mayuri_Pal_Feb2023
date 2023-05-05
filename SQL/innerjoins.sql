create table stud (id int primary key identity,add_no varchar(40) not null,first_name varchar(45) NOT NULL,last_name varchar(45) NOT NULL,age int,city varchar(25) NOT NULL  );    
 create table fees(add_no varchar(40)not null,course varchar(40)not null,amount_paid int);

 INSERT INTO Stud (add_no, first_name, last_name, age, city)VALUES
	(3354,'Luisa', 'Evans', 13, 'Texas'),       
    (2135, 'Paul', 'Ward', 15, 'Alaska'),       
    (4321, 'Peter', 'Bennett', 14, 'California'),    
    (4213,'Carlos', 'Patterson', 17, 'New York'),       
    (5112, 'Rose', 'Huges', 16, 'Florida'),  
    (6113, 'Marielia', 'Simmons', 15, 'Arizona'),    
    (7555,'Antonio', 'Butler', 14, 'New York'),       
    (8345, 'Diego', 'Cox', 13, 'California');  

INSERT INTO fees (add_no,course,amount_paid)VALUES
(3354,'java',20000),
(7555,'android',22000),
(4321,'python',18000),
(8345,'sql',15000),
(5112,'machine learning',30000);

select*from stud
select *from fees

SELECT s.add_no, s.first_name,s.last_name, f.course, f.amount_paid FROM stud s  INNER JOIN Fees  f ON s.add_no = f.add_no;  --inner joins to get a single table from 2 tables with a common column(eg. id is common in both ) --

select s.add_no, s.first_name, s.last_name ,f.course,f.amount_paid from stud s cross join fees f --cross joins to multiply 2 table data--

select s.add_no,s.first_name,s.last_name ,f.course,f.amount_paid from stud s left join fees f on s.add_no=f.add_no;		---left join all values of left table and common values of right table otherwise null--

select s.add_no,s.first_name,s.last_name ,f.course,f.amount_paid from stud s right join fees f on s.add_no=f.add_no;		---right join all values of right table and common values of left table otherwise null accept add_no it cant taken as null--

select s.add_no,s.first_name,s.last_name ,f.course,f.amount_paid from stud s full outer join fees f on s.add_no=f.add_no;		---full outer join combines both table--