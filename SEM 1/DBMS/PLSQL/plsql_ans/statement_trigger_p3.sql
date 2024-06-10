CREATE OR REPLACE trigger mytrig1 BEFORE delete or insert or update
ON emp_tab 

BEGIN

if (TO_CHAR(SYSDATE,'day') IN ('sat','sun','mon')) OR  (TO_CHAR(SYSDATE,'hh:mi') BETWEEN '08:30' AND '18:30') 
THEN
RAISE_APPLICATION_ERROR(-20500,'table is secured');

end if;

END;
