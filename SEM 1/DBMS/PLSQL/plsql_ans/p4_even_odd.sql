declare
num1 number;
res number;

begin
num1:=&num1;
res:=MOD(num1,2);

if res=0 then 
dbms_output.put_line('Entered number is EVEN');
else
dbms_output.put_line('Entered number is ODD');
end if;

end;