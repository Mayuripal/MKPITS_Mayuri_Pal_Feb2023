create database drivenitdb

Create table ItemMaster(ItemID int  primary key identity (1,1) not null,ItemDescr nvarchar(100) null ,BalQty int null ,CreatedOn DateTime);

create table Transactions(TransID int primary key identity(1,1) not null,ItemId int not null,TransType char(1) not null,TransQty int,TransDate DateTime
constraint c1 foreign key (ItemId) references ItemMaster(ItemId));

select * from ItemMaster
select * from Transactions

Insert into ItemMaster values('mouse',10,'12/3/2004'),('keyboard',15,'12/3/2004');