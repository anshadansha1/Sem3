#2.3 : program to implement CRUD operations

# Step 1 : Import  
import sqlite3

# Step 2 : Setting Path
db_path = 'E:\\MCA\\Semesters\\SEM 3\\Python(MCA306)\\Python_LAB\\Python_LAB_Cycle\\DB2_crud.db'

# Step 3 : Establish connection
def create_connection(db_file):
    conn = None
    try:
        conn = sqlite3.connect(db_file)
        print("Connection Established!")
    except sqlite3.Error as e:
        print(e)
    return conn

# Step 4 : Create Table
def create_table(conn):
    try:
        cmd = '''CREATE TABLE IF NOT EXISTS student (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                email TEXT NOT NULL
                );
            '''
        conn.execute(cmd)
        print("Table Created/already Exists")
    except sqlite3.Error as e:
        print(e)

# Step 5 : Insert Values to Table
def insert_student(conn, student):
    try:
        cmd = '''INSERT INTO student(name, email) VALUES(?, ?)'''
        conn.execute(cmd, student)
        conn.commit()
        print("Student inserted.")
    except sqlite3.Error as e:
        print(e)

# Step 6 : Read values from table
def read_student(conn):
    try:
        cmd = "SELECT * from student"
        cursor = conn.execute(cmd)
        rows = cursor.fetchall()
        for row in rows:
            print(row)
    except sqlite3.Error as e:
        print(e)

# Step 7 : Update values
def update_student(conn, student_id, new_name):
    try:
        cmd = "UPDATE student SET name = ? WHERE id = ?"
        conn.execute(cmd, (new_name, student_id))
        conn.commit()
        print("Student updated.")
    except sqlite3.Error as e:
        print(e)

# Step 8 : Delete values
def delete_student(conn, student_id):
    try:
        cmd = "DELETE FROM student WHERE id = ?"
        conn.execute(cmd, (student_id,))
        conn.commit()
        print("Student deleted.")
    except sqlite3.Error as e:
        print(e)
    
def main():
    # DB connection creation
    conn = create_connection(db_path)

    if conn is not None:
        # Create Table
        create_table(conn)

        # Insert students
        insert_student(conn, ('Anshad Muhammad', 'mca2336@rajagiri.edu'))
        insert_student(conn, ('Dilsha Basheer', 'mca2318@rajagiri.edu'))

        # Read and Display
        print("Students Before update:\n")
        read_student(conn)

        # Update a student
        update_student(conn, 1, 'Anshad P A')

        # Display after update
        print("Students after update:\n")
        read_student(conn)

        # Delete a Student
        delete_student(conn, 2)

        # Display after deletion
        print("Students after deletion:\n")
        read_student(conn)

        # Close connection
        conn.close()
    else:
        print("Error! Cannot create the database connection.")

if __name__ == '__main__':
    main()
