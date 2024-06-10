CREATE OR REPLACE PROCEDURE incrsalry_check(
  exp IN NUMBER,
  salry IN NUMBER,
  incr OUT NUMBER) AS
BEGIN

IF exp < 2 THEN
incr := 0;
ELSIF exp < 5 THEN
incr := salry * 0.25;
ELSIF exp < 10 THEN
incr := salry * 0.40;
ELSE
incr := salry *0.50;

END IF;

END;
