select * from customer

------ query update phone no ------- 
update customer set phone = 7719832118
where cust_id=3 
------query update street where city nagpur-------
update customer set street ='ramnagar'
where city='nagpur' and street='dattawadi'

		---created a new table----
create table sample12345(id int identity primary key,name varchar(20))
insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345

delete from sample12345  -----delete whole table and new value will be start after deleted records----

truncate table sample12345	----truncate will delete the record and when you
							--insert new records it will start from one
select * from sample12345
insert into sample12345 values('mouse')
insert into sample12345 values('keyboard')
select * from sample12345

--adding one more column to existing table----
alter table sample12345
add price int
sp_help sample12345

--query to change datatype of column
alter table sample12345
alter column price dec(10,2)

--query to drop column price
alter table sample12345
drop column price

----query to rename table
-----(sp -store procedure)-----
sp_rename 'sample12345', 'newsample'
select*from newsample

---query to rename the column name
EXEC sp_rename 'newsample.name', 'first_name','COLUMN'
