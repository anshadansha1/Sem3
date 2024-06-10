declare
cursor empcur is 
select empname,deptno,salary from employee order by salary desc; 

ename employee.empname%type;
deptno employee.deptno%type; 
sal employee.salary%type;

begin
dbms_output.put_line('Highest 5 Employee details ');
open empcur;
fetch empcur into ename,deptno,sal;

while empcur%found and empcur%rowcount<=5 
loop

dbms_output.put_line('Emp Name : '||ename);
dbms_output.put_line('Dept No: '||deptno);
dbms_output.put_line('Salary : '||sal);
dbms_output.put_line('*************************');
fetch empcur into ename,deptno,sal;

end loop;

close empcur;
end;