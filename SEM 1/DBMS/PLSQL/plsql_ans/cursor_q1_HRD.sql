declare

begin

update employee set salary=salary+salary*0.15 where empno=&empno;

if sql%found then
dbms_output.put_line(sql%rowcount ||' SALARY HAS BEEN UPDATED');

else
dbms_output.put_line('NO RECORDS UPDATED');

end if;
end;