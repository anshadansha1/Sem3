declare
stno number(4);
sum_s number(3);
begin
stno:=&stno;

select mark1+mark2+mark3 into sum_s from student_mark where s_no=stno;

if sum_s>=50 then
dbms_output.put_line('No moderation Required');

elsif sum_s>=45 and sum_s<50 then
update student_mark set mark1=mark1+5 where s_no=stno;
dbms_output.put_line('Moderation Applied');

else
dbms_output.put_line('Moderation not Applicable');
end if;

end;