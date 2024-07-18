
create table EmpTable
( 
	enpId int primary key identity(1000,1), 
	empName nvarchar(100) NOT NULL, --takes 32 bits of size and will take only the space which we have enterd where as char will occupy the space which we have given
	empAddress nvarchar(MAX) NOT NULL,--max means fill how much evwr the user wants
	empSalary money NOT NULL,
)
create table DeptTable
(
	DeptId int primary key identity(1,1),
	Deptname varchar(50) not null,
)

---------------------it is a relational database:the data is store int he for of rows and coloumns-----------------------
--foriegn key relation
 
Alter table EmpTable
Add Dept int Not Null --use null if we already have records
References DeptTable(DeptId)


insert into DeptTable values('Training')
insert into DeptTable values('Devlopment')
insert into DeptTable values('Transport')
insert into DeptTable values('Sales')
insert into DeptTable values('Admin')

insert into EmpTable values('Prathamesh','Bhalki',56000,1) 
insert into EmpTable values('Joydeep','Kolkata',35000,2)
insert into EmpTable values('Homelander','Pune',35000,2)
insert into EmpTable values('Pankaj','Bihar',45000,3)
insert into EmpTable values('Rohan','Nagpur',50000,4)
insert into EmpTable values('Jai Guru','Tata Nagar',35000,4)

alter table EmpTable 
Drop constraint FK__EmpTable__Dept__3D5E1FD2--if the table has the foreign key constrain then first we need to drop the foreign kry then the coloumn
 
alter table EmpTable 
Drop column Dept --drops the coloumn from the table

 
--Add the column called dept into the EmpTable
Alter table EmpTable
add DeptId int
References DeptTable(DeptId)

select * from  EmpTable
select * from  DeptTable
 

 
 