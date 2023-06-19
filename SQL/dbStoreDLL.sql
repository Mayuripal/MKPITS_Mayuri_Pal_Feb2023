create database dbStoreDLL;
			----------1st table Item Master-----------
create table Item_master (Item_Id int identity primary key,Item_Name varchar(500)not null,Category varchar(500),Rate decimal(10,2)not null,Balance_quantity int not null);

			----------2nd table Department Master-----------
create table Department_mast (Department_id int identity primary key,Department_name varchar(500)not null);

			----------3rd table Vendor Master-----------
create table Vendor_mast (Vendor_id int identity primary key,Vendor_name varchar(500)not null);
select * from Vendor_mast
			----------4th table Transaction Det Idail -----------
Create table Transaction_Detail (Transaction_id int identity primary key,Item_Id int,Transaction_Date datetime not null,Department_id int null,Vendor_id int null,Quantity int,
	constraint t1 foreign key (Item_Id) references Item_master(Item_Id),
	constraint t2 foreign key (Department_id) references Department_mast(Department_id),
	constraint t3 foreign key (Vendor_id) references Vendor_mast(Vendor_id));
	
	select* from Transaction_Detail
	
	select * from Department_mast
	
	select * from Item_master;
