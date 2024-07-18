select * from EmpTable
select * from DeptTable
select * from EmpTable where empAddress='Pune';
select * from EmpTable where empAddress='Bangalore' and empSalary>5000

select 
MAX(empSalary) as MaxSalary,
MIN(empSalary) as MInSalary,
Avg (empSalary) as avgSalary 
from EmpTable

select top(10) empName,empSalary 
from EmpTable 
where empSalary>40000 
order by empSalary desc

select top 50 percent * from EmpTable
 
 Select * from 
 (select top 50 percent * from EmpTable 
 order by empId desc) TEMP
 Order by empId ASC

 --this is equi join as it allows to get comman data based on some condition
select 
EmpTable.empName,DeptTable.deptName
from 
EmpTable join DeptTable 
on 
EmpTable.depId=DeptTable.depId

--wtite a query to set the deptid as null for a random set of employees
 
Declare @NumberofRowsToUpdate int=25;
with RandomRows as(
select top (@NumberofRowsToUpdate)*
from EmpTable
order by NEWID()
)
 
update RandomRows
set depId=null;
 
select COUNT(*) from EmpTable where depId is null


-------------------Left join---------------------------------
select EmpTable.*,coalesce(DeptTable.Deptname,'not set'), DeptTable.Deptname 
from EmpTable
left join DeptTable on 
EmpTable.depId=DeptTable.depId
-------------------------coalesce it is used to replace value for a given field


-----------------------------------right join-----------------------------
select EmpTable.*,DeptTable.deptName 
from EmpTable right join DeptTable 
on 
EmpTable.depId=DeptTable.depId

-----------------------------full join-----------------------------------------------------
 
select EmpTable.*,DeptTable.Deptname from
EmpTable full outer join DeptTable on 
EmpTable.depId=DeptTable.depId;

--------------------------Group by clause------------------------------------------------
---------find all the employeee name by city
select empName,empAddress from EmpTable group by empName,empAddress
---find count of employee from eachname
 
select count(empName),empAddress from EmpTable group by empAddress order by empAddress;
 
--when using group by select should be part of the group by or it should be an aggregate function.
 
--get the distribution of salaries from each city and get higest on top
select sum(empSalary)
as salary,empAddress
from EmpTable 
group by empAddress
order by salary desc;
 
-----get the max min and avg salary for each city-----
select max(empSalary) as maximum,min(empSalary) as minimum,avg(empSalary) as average
,empAddress
from EmpTable 
group by empAddress;
 
--get the list of employees who salary is more than the avg salary in their city
 
Declare @avgsal int =0
 
select empSalary,empAddress,empname,avg(empSalary)as salary from
EmpTable group by empName,empSalary,empAddress