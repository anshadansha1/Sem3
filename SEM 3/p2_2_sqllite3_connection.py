#2.2 : Program to implement database using sqlite3
 
# Step 1 : import sqlite connector
import sqlite3
from sqlite3 import Error
import os

def connect_to_sqlite(db_file):
    conn = None
    try:
        # Step 2 : Establish connection
        conn = sqlite3.connect(db_file)
        print(f"Connected to SQLite, SQLite version: {sqlite3.version}")

        # Step 3: Create a cursor
        cursor = conn.cursor()
        
        # Step 4 :Creating Tables

        # a) Create table 'users'  (For multiline query use ('''))
        cursor.execute('''CREATE TABLE IF NOT EXISTS users (
                            id INTEGER PRIMARY KEY,
                            name TEXT NOT NULL
                          );''')
        
        # b) Create table 'students' 
        cursor.execute("CREATE TABLE IF NOT EXISTS students (id INTEGER PRIMARY KEY, Name TEXT NOT NULL, Age INTEGER);")

        # Step 5 : Insert Values to Table
        
        # a) Insert values to 'users' table
        cursor.execute("INSERT INTO users (name) VALUES ('Anshad');")

        val = [
            ('Dilsha C P',),
            ('Nihal',),
            ('Majo',)
        ]
        cursor.executemany('INSERT INTO users (name) VALUES (?)', val)

        # b) Insert values to 'students' table
        val2 = [
            ('Anshad', 24),
            ('Dilsha C P', 23),
            ('Nihal', 22),
            ('Majo', 22)
        ]
        cursor.executemany('INSERT INTO students (Name, Age) VALUES (?, ?)', val2)

        # Step 6 : Commit the transactions
        conn.commit()

        # Step 7: Fetching rows from table

        # a) Fetch from 'users' table
        cursor.execute("SELECT * FROM users;")
        rows = cursor.fetchall()
        print("\nData from the users table are:\n")
        for row in rows:
            print(row)
        
        # b) Fetch from 'students' table
        cursor.execute("SELECT * FROM students;")
        rows = cursor.fetchall()
        print("\nData from the students table:\n")
        for row in rows:
            print(row)

    except Error as e:
        print(f"Error connecting to SQLite: {e}")
    finally:
        if conn:
            conn.close()
            print("SQLite connection is closed")

if __name__ == "__main__":
    # Use an absolute path for the database file
    db_path = "test2_database.db"
    connect_to_sqlite(db_path)
    
    # Check if the file was created
    if os.path.exists(db_path):
        print(f"Database file '{db_path}' was created successfully.")
    else:
        print(f"Failed to create the database file '{db_path}'.")
