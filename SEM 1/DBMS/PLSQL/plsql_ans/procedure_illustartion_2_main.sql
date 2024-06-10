declare
CURSOR empnames IS SELECT UPPER(empname) from employee;

empname varchar(30);

begin

OPEN empnames;

LOOP
FETCH empnames INTO empname;
EXIT WHEN empnames%NOTFOUND;
palindrome_checker(empname);

END LOOP;
CLOSE empnames;

end;