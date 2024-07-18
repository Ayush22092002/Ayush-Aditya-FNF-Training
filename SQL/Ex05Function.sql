create Function getEmpCount()
Returns Integer
AS
Begin
DECLARE @count INT
Set @count = (select count(*) from EmpTable)
Return @count
End
 
select dbo.getEmpCount() as EmpCount


create Function getDeptName(@id int)
Returns varchar(50)
AS
Begin
DECLARE @deptName varchar(50)
Set @deptName = (select deptName from DeptTable where depId=@id)
Return @deptName
End
 
select EmpName,  dbo.getdeptName(depId) as Dept from EmpTable

print getdate()


CREATE Function CreateDate(@date date)
returns varchar(50)
as
begin
declare @retval varchar(50)
set @retval='' + cast(Day(@date) as varchar(5)) +'/'+cast(MONTH(@date) as varchar(20)) + '/'+ CAST(YEAR(@date) as varchar(4))
return @retval
end
print dbo.createDate(GetDate())


create function getage(@dob date)
returns int
as
begin
	declare @age int
	set @age=DateDiff(year,@dob,GetDate())
	return @age
end
 
print dbo.getage('10/10/2002')



create function getEmployeeByCity(@city varchar(50))
returns table
as
return(select * from EmpTable where empAddress=@city)

select EmpName,empAddress from dbo.getEmployeeByCity('Bangalore')

alter function getEmployeeByCity(@city varchar(50))
returns table
as
return(select * from EmpTable where empAddress like '%' + @city+ '%')

select EmpName,empAddress from dbo.getEmployeeByCity('an')


