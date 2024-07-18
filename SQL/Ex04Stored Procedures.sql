create procedure CreateEmployee
(
		@ename varchar(50),
		@eaddress varchar(200),
		@esalary money,
		@edept  int
) as
insert into EmpTable values(@ename,@eaddress,@esalary,@edept)

exec[dbo].CreateEmployee
        @ename ='Vipul',
		@eaddress ='Bangalore',
		@esalary =10000,
		@edept= 7

GO

select * from EmpTable where empName='Vipul'