create database company;
   --store id primary key--
create table stores(store_id int primary key,store_name varchar(20),phone int,email varchar(30),street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into stores values (111,'royal',938585,'royal@gmail.com','chakan','pune','Mh',111045)

	--categories catid primary key--
create table categories(categorie_id int primary key,categorie_name varchar(20))
insert into categories values (101,'oilpump')

	--brand id primary key---
create table brand(brand_id int primary key,brand_name varchar(20))
insert into brand values(9793,'bullet')

	--product id primary key,brand id &categorie id foriegn key---
create table product1(prod_id int primary key,prod_name varchar(20),model_year int,list_price int,brand_id int,categorie_id int,
constraint p1 foreign key (brand_id) references brand(brand_id),
constraint p2 foreign key (categorie_id) references categories(categorie_id))
insert into product1 values(001,'bike',2023,150893,973,101)

	---stocks ---
create table stocks(store_id int,prod_id int ,qty int,
constraint s1 foreign key (store_id) references stores(store_id),
constraint s2 foreign key (prod_id) references product1(prod_id))
insert into stocks values(111,001,20)

	--costomer custid primary key---
create table customer(cust_id int primary key,first_name varchar(20),last_name varchar(20),phone int,email varchar,street varchar,city varchar(10),state varchar(20),zipcode int)
insert into customer values(881,'mihir','patil',847568,'m','v','Nashik','Mh',420003)

	---staff staffid primarykey & store id foreign key---
create table staff(staff_id int primary key,first_name varchar(20),last_name varchar(20),email varchar(20),phone int,active varchar(10),store_id int,manager_id int,
constraint F1 foreign key (store_id) references stores(store_id))
insert into staff values(211,'amruta','jadhav','ajadhav@gmail',8442224,'yes',111,10001)

	--order orderid primary key & custid,staffid,storeid foreign key---
create table order1(order_id int primary key,cust_id int,order_status varchar(10),order_date varchar(20),required_date varchar(20),shipped_date varchar(20),store_id int,staff_id int,
constraint q1 foreign key (cust_id) references customer(cust_id),
constraint q2 foreign key (staff_id) references staff(staff_id),
constraint q3 foreign key (store_id) references stores(store_id))
insert into order1 values (0110,881,'dispached','23/1/2023','2/5/2023','5/5/2023',111,211)


	--order item --
create table orderitem(order_id int,item_id int primary key ,prod_id int ,qty int,list_price int,discount int,
constraint l1 foreign key (order_id) references order1 (order_id),
constraint l2 foreign key (prod_id) references product1(prod_id))
insert into orderitem values(0110,121,001,21,100832,20)




