create database Project1;

create table Product_GST_Details(Product_Gst_ID int primary key,Gst_Detail_Name varchar(500),CGST decimal(18,0),SGST decimal(18,0),IGST decimal(18,0));
select * from Product_GST_Details
insert into Product_GST_Details values(601,'AC and Fridge',14,14,14),
									  (602,'Computers',9,9,9),
									  (603,'Printers',9,9,9),
									  (604,'Mobiles',6,6,6)

create table ProductCategory(Product_Category_ID int primary key,Product_Type_Name varchar(500),Product_Gst_ID int, constraint c foreign key(Product_Gst_ID) references Product_GST_Details(Product_Gst_ID));
select * from ProductCategory
insert into ProductCategory values (1001,'Computers',602),
									(1002,'Mobile',604),
									(1003,'Printers',603),
									(1004,'AC and Fridge',601)

create table Product(Product_ID int primary key,Product_Type_ID int,Product_Name varchar(500), constraint p foreign key (Product_Type_ID) references ProductCategory (Product_Category_ID) );
select * from Product
alter table product add Product_Price decimal(18,0)
insert into Product values(210,1002,'Apple',40000),
						  (211,1002,'Lenovo',25000),
						  (212,1003,'Samsung',50000),
						  (213,1004,'IFB',20000),
						  (214,1004,'LG',30000),
						  (215,1001,'Sony',60000)

create table InvoiceDetail(Invoice_Detail_ID int primary key identity,Customer_Name varchar(500),Customer_contact varchar(15),Product_Category_ID int,Product_ID int,Residential_Type_ID int,Invoice_Date DateTime,Quantity Decimal (18,0),Price decimal(18,0),CGST decimal(18,0),SGST decimal(18,0),IGST decimal(18,0),CGST_Value decimal(18,0),SGST_Value decimal(18,0),IGST_Value decimal(18,0),Total_Amount decimal(18,0),
constraint d1 foreign key (Product_Category_ID) references ProductCategory(Product_Category_ID) ,constraint d2 foreign key (Product_ID) references Product(Product_ID));
select * from InvoiceDetail
--product name
select p.product_name from Product p inner join ProductCategory t on p.Product_Type_ID = t.Product_Category_ID where t.Product_Type_Name = Product_Type_Name;
--gst details
select a.CGST,a.SGST,a.IGST from Product_GST_Details a inner join ProductCategory b 
on a.Product_Gst_ID=b.Product_Gst_ID where b.Product_Type_Name='Printers'
--for price
select Product_Price from Product where Product_Name='Apple'