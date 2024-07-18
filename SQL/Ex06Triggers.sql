

create table customer 
(
	cstid int primary key identity(1,1),
	cstname varchar(50) not null,
	cstaddress varchar(200) not null,
	billdate date default getDate(),
	billamount money
)
create table customer_Audit
(
id int primary key identity(1,1),
description varchar(200) not null
)

alter trigger OnNewCustomer
on customer
for insert
as
begin
declare @id int
select @id=cstid from inserted
declare @desc varchar(200)
declare @name varchar(200)
select @name =cstname from inserted
set @desc='Customer with ID'+cast(@id as varchar(4))+'and name as'+@name+'Inserted Successfully on'+
dbo.CreateDate(getdate())
insert into customer_Audit values (@desc)
end

insert into customer (cstname,cstaddress,billamount) values ('Ayush','Bangalore',143456)


--------update-------------
create trigger onUpdateCustomer
on customer
after update
as
begin
declare @id int
declare @oldname varchar(50)
declare @newname varchar(50)
select @id=cstid from inserted
select @newname=cstname from inserted
select @oldname=cstname from deleted

insert into customer_Audit values('The Customer with ID'+cast(@id as varchar(4))+'has
been updated with the new Name as'+ @newname+'from the old Name'+@oldname+'on'+
dbo.CreateDate(getdate()))
end

update customer
set cstname='Aditya' where cstname='Ayush'



select * from customer_Audit
