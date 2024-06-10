CREATE OR REPLACE trigger trig1 BEFORE delete or insert or update
ON emp_tab 
FOR EACH ROW
WHEN(new.job='DEVELOPER' OR old.job='DEVELOPER')
BEGIN

if deleting then
 insert into emp_x values(:old.eno,:old.ename,:old.esal,:old.job,sysdate);

elsif inserting then
 insert into emp_new values(:new.eno,:new.ename,:new.esal,:new.job);

else
 insert into emp_modified values(:old.eno,:old.ename,:old.esal,:old.job);

end if;

END;
