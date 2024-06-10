declare

begin
update employee set salary=&salary where job='ANALYST';

if sql%found then
dbms_output.put_line(sql%rowcount||' records are updated in the employee table');

else
sedbms_output.put_line(' No records are updated in the employee table');

end if;

end;
