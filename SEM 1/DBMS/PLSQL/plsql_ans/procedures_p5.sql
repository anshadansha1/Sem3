create or replace procedure sum1(a IN number,b IN OUT number)
AS

begin
b:=a+b;
end;