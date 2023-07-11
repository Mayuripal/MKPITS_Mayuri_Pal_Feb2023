create database EmployeeDetails;
create table Employee (Id int identity primary key ,Name varchar(50) not null,City varchar(50) not null,Address varchar(50) not null);
drop table Employee
select * from Employee;

Insert into Employee values('Arti','Nagpur','Sadar');

create proc AddEmployee(@Name varchar(50),@City varchar(50),@Address varchar(50))
as
begin
Insert into Employee values(@Name,@City,@Address)
end;
 
 exec AddEmployee
 select * from Employee;
 --------------------------------------------------------------------------------------------
 Create proc UpdateEmployee(@Name varchar(50),@City varchar(50),@Address varchar(50))
as
begin
Update Employee set City=@City,Address=@Address where Name=@Name
end;
----------------------------------------------------------------------------------------
Create proc DeleteEmployee(@Name varchar(50),@City varchar(50),@Address varchar(50))
as
begin
Delete from Employee  where Name=@Name
end;

