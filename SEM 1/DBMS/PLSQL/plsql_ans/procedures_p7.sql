create or replace procedure empproc(empn IN char)
AS
ename employee.empname%type;
depno employee.deptno%type;

begin

select empname,deptno into ename,depno from employee where  empno=empn;
dbms_output.put_line('Name : '||ename); 
dbms_output.put_line('Deptno : '||depno);
dbms_output.put_line('******************');

end;