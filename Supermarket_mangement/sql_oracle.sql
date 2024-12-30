
create table emp (id number (10) not null primary key, name varchar2(15) not null ,phone number(10), addr varchar2(50), email varchar2(50)); 

create table type_jop (jop_id number (10) not null ,jop_name varchar2(15) not null,constraint jop_id primary key(jop_id) );

create table quality (quality_id number (10) not null , quality_name varchar2(15) not null , constraint quality_id primary key(quality_id) 
);

create table item (item_id number (10) not null , item_name varchar2(15) not null ,item_price number (10) not null,item_quantiy  number (10) not null ,quality_id number (10) not null,constraint item_id primary key (item_id) , constraint quality foreign key (quality_id) references quality (quality_id)); 
 
create table store (store_id number (10) not null , emp_id number (10) not null , item_id number (10) not null , type_bill_id number (10) not null ,
 constraint store_id_pr primary key(store_id) ,
 constraint employy_fr_id foreign key (emp_id) references emp (id) , 
constraint item_num_fr_id foreign key (item_id) references item (item_id) );

create table product_info (
id_pro number not null primary key,
name_pro varchar2(15) not null,
price_pro number not null,
qultiy_pro number not null,
subTotal number not null);

create table bill(
id_bill number not null primary key,
cus_name varchar2(20) not null,
date_bill date not null,
emp_name varchar2(20) not null,
total number not null);

create table client(id_cli number not null primary key,
cli_name varchar2(50) not null,
cli_phone number null , client_add varchar2(50) null);