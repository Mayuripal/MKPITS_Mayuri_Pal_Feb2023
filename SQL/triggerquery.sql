create table student (studid int primary key, studname varchar(20))
-----------------
CREATE TABLE studLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)
-----------------
CREATE TRIGGER stdt
on student
for insert
as
insert into studLog(LogID,Operation,UpdatedDate)
select studid,'insert',GETDATE()
FROM inserted;
-----------------
INSERT INTO student values(1,'eakta')
insert into student values (12,'ankit')
select *from student
select *from studlog

-----------------
