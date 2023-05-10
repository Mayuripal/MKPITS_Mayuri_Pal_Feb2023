create table employee (empid int primary key, empname varchar(20))
-----------------
CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)
-----------------
CREATE TRIGGER empt
on employee
for insert
as
insert into
EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() FROM
inserted;
-----------------
INSERT INTO EMPLOYEE values(11,'asha')
insert into employee values (12,'ankit')
select *from employee
select *from emplog

-----------------
create trigger empu
on employee
after update
as
insert into
Emplog(EmpID,Operation,UpdatedDate)
SELECT empid,'update',getdate() from deleted

select*from employee
update employee set empname='amit' where empid=11