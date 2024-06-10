create or replace function sum_fn(a IN number,b IN number)
return number
as
c number(5,2);
begin
c:=a+b;
return c;
end;