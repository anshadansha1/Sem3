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

#a)Inserting single row

mycursor.execute("INSERT INTO students(name,age) VALUES('Anshad',24)")

#b)Inserting Multiple row

sql = "INSERT INTO students(name,age) VALUES(%s,%s)"
val = [
    ('Dilsha C P',23),
    ('Nihal',22),
    ('Majo',22),
    ('Mariya',22)
]
mycursor.executemany(sql,val)

#Step 6:Commit changes
con.commit()
print(mycursor.rowcount," Was Inserted.")

#Step 7:Select Data from Table

mycursor.execute("SELECT * from students")
myresult = mycursor.fetchall()

for x in myresult :
    print(x)




mycursor.close()
con.close()

