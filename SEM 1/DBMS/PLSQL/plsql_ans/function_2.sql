declare
x number(5,2);
y number(5,2);
z number(5,2);
begin
x:=&x;
y:=&y;
z:=sum_fn(x,y);
dbms_output.put_line('sum is :'||z);

end;