declare
n number;
fact number;


begin
fact:=1;
n:=&n;



loop
fact:=fact*n;
n:=n-1;
exit when n<=0; 
end loop; 

dbms_output.put_line('Factorial is : ' ||  fact);

end;