declare
i number;
a number;

begin
i:=3;
while i<=7
loop
a:=3.14*i*i;
insert into circle values(i,a);
i:=i+1;
end loop;


end;

