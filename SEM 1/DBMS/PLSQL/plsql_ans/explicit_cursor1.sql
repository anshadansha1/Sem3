declare
cursor empcur is 
select empno,empname,salary from employee;

emprec empcur%rowtype; 

begin
dbms_output.put_line('Employee details ');
open empcur;
fetch empcur into emprec;

while empcur%found loop
dbms_output.put_line('Emp No: '||emprec.empno);
dbms_output.put_line('Emp Name : '||emprec.empname);
dbms_output.put_line('Salary : '||emprec.salary);
dbms_output.put_line('*************************');
fetch empcur into emprec;

end loop;

close empcur;
end;