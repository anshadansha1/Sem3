#2.1 : Program to implement mysql 

#Step 1 : import mysql connector
import mysql.connector

#Step 2 : Establish connection 
con = mysql.connector.connect(
    host="localhost",
    user="root",
    password="",
    database="python_test"
)

#Step 3 : Create cursor
mycursor = con.cursor()

#Step 4 : Create table

mycursor.execute("CREATE TABLE students(name VARCHAR(255),age int)")

#Step 5 : Insert data to table
sql = "INSERT INTO"




