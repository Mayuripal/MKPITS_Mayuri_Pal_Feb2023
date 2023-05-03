create table Teacher(teacher_id int primary key,age int)

create table Subject (teacher_id int,subject varchar(15), Constraint t1 foreign key (teacher_id)  references Teacher (teacher_id))

select * from Subject
select * from Teacher

insert into Teacher values(1,25)
insert into Subject values(1,'chemistry')
insert into Subject values(1,'biology')

insert into Teacher values(2,28)
insert into Subject values(2,'english')
insert into Subject values(2,'math')

insert into Teacher values(3,30)
insert into Subject values(3,'computer')

insert into Teacher values(4,22)
insert into Subject values (4,'history')
insert into subject values (4,'physics')