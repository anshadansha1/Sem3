create or replace procedure proj_emp(emp_name IN varchar)
AS

CURSOR projectfinder is select projname from emp_proj ep INNER JOIN employee e ON e.empno=ep.empno INNER JOIN project p on ep.projno=p.projno where empname=emp_name;

project_name varchar(30);

begin

OPEN projectfinder;
LOOP
FETCH projectfinder INTO project_name;
EXIT when projectfinder%NOTFOUND;
dbms_output.put_line(project_name);

END LOOP;

CLOSE projectfinder;


end;