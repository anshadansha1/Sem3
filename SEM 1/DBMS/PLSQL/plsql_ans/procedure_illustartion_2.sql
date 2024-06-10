CREATE OR REPLACE PROCEDURE palindrome_checker(arg in varchar2) 
AS
rev varchar2(30);

begin

SELECT reverse(arg) INTO rev from DUAL;
if arg = rev
THEN
dbms_output.put_line(arg);
end if;

end;