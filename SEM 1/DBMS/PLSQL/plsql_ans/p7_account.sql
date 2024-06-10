declare
acno number(15);
bal number(10,2);

begin
acno:=&acno;

select ac_balance into bal
from account where 
ac_no=acno;

if bal-2000<500 then
dbms_output.put_line('Transation not possible,Insufficient balance');
else
update account set ac_balance=ac_balance-2000 where ac_no=acno;
dbms_output.put_line('Transaction Successfully completed');
end if;

end;
