-------------using in clause-----------

select * from EmpTable----normal
where
empAddress='Pune' or empAddress='Bangalore' or  empAddress='Hyderabad'


select * from EmpTable--in clause
where
empAddress in('Pune','Bangalore','Hyderabad')


-------------using having clause-----------
