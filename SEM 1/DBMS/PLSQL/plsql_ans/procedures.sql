create or replace procedure sum1(a IN number,b IN number)
AS
s number(5,2);

begin
s:=a+b;
dbms_output.put_line('sum is :'||s);

end;