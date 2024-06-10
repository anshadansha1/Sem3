declare
cursor c_analyst is
select empno,salary from employee where job='ANALYST';

v_empno employee.empno%type;
v_sal employee.salary%type;
v_raise number;

begin

open c_analyst;

fetch c_analyst into v_empno,v_sal;

while c_analyst%found 
loop

v_raise:=v_sal*0.15;

update employee set salary=salary+v_raise where empno=v_empno;

insert into emp_raise values(v_empno,SYSDATE,V_raise);
fetch c_analyst into v_empno,v_sal;
end loop;


close c_analyst;

end;