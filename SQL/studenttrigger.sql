  create table student(studid int primary key,studname varchar(20))

  create table Studlog(
  Logid int identity(1,1)not null,
  Studid int not null,
  Operation nvarchar(10) not null,
  Updateddate datetime not null )

  CREATE trigger studt
  on student
  for insert
  as
  insert into
  Studlog(Studid,Operation,Updateddate)
  SELECT studid,'insert',getdate() 
  from inserted;

  insert into student values(1,'aarti')
  insert into student values(2,'amit')
  insert into student values(3,'anu')

  select* from student
  select *from Studlog

  create trigger std1
  on student
  after update
  as
  insert into
  Studlog(Studid,Operation,Updateddate)
  SELECT studid,'update',getdate()
  from deleted;
  
  update student 
  set studname='ria'
  where studid=1;