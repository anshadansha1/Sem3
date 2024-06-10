declare
prdtno Prod_Master.productno%type;
np Prod_Master.new_price%type;
begin
if np<4000 then
update Prod_Master
set new_price=4000 where productno='P0001';
else
dbms_output.put_line('no updation done');
end if;
end;