create or replace procedure sum1(a IN number,b IN number,c OUT number)
AS

begin
c:=a+b;
end;