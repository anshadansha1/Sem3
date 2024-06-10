declare
cursor empcur is 
select empno,empname,salary from employee;

eno employee.empno%type; 
ename employee.empname%type;
sal employee.salary%type;

begin
dbms_output.put_line('Employee details ');
open empcur;
fetch empcur into eno,ename,sal;

while empcur%found loop
dbms_output.put_line('Emp No: '||eno);
dbms_output.put_line('Emp Name : '||ename);
dbms_output.put_line('Salary : '||sal);
dbms_output.put_line('*************************');
fetch empcur into eno,ename,sal;

end loop;

close empcur;
end;