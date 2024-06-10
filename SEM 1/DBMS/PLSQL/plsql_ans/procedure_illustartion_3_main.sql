DECLARE

CURSOR c_employees IS SELECT empname,extract(year from sysdate) - extract(year from hire_date) as exp_clt ,salary FROM employee;

exp_clt NUMBER;
incre_out NUMBER;
empname varchar(30);
salry number(10,2);

BEGIN

OPEN c_employees;

LOOP
FETCH c_employees INTO empname,exp_clt,salry;
EXIT WHEN c_employees%NOTFOUND;
	incrsalry_check(exp_clt,salry,incre_out);
	dbms_output.put_line('Name of Employee : '|| empname);
	dbms_output.put_line('Increment : '|| incre_out);
	
END LOOP;
CLOSE c_employees;
	
 
END;