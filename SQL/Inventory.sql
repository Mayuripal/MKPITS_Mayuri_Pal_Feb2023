create database StoreManagement;
			----------1st table Item Master-----------
create table Item_master (Item_Id int primary key,Item_Name varchar(500)not null,Category varchar(500),Rate decimal(10,2)not null,Balance_quantity decimal(10,2)not null);

			----------2nd table Department Master-----------
create table Department_mast (Department_id int primary key,Department_name varchar(500)not null);

			----------3rd table Vendor Master-----------
create table Vendor_mast (Vendor_id int primary key,Vendor_name varchar(500)not null);

			----------4th table Transaction Detail -----------
Create table Transaction_Detail (Transaction_id int identity primary key,Item_Id int,Transaction_Date datetime not null,Department_id int,Vendor_id int,Quantity int,
	constraint t1 foreign key (Item_Id) references Item_master(Item_Id),
	constraint t2 foreign key (Department_id) references Department_mast(Department_id),
	constraint t3 foreign key (Vendor_id) references Vendor_mast(Vendor_id));
	
	select* from Vendor_mast