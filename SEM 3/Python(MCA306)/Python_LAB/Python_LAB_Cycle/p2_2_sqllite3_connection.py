import sqlite3
from sqlite3 import Error
import os

def connect_to_sqlite(db_file):
    """ Create a database connection to an SQLite database """
    conn = None
    try:
        conn = sqlite3.connect(db_file)
        print(f"Connected to SQLite, SQLite version: {sqlite3.version}")

        # Create a new SQLite cursor
        cursor = conn.cursor()
        
        # Create a table (if it doesn't already exist)
        cursor.execute('''CREATE TABLE IF NOT EXISTS users (
                            id INTEGER PRIMARY KEY,
                            name TEXT NOT NULL
                          );''')

        # Insert a new row into the users table
        cursor.execute("INSERT INTO users (name) VALUES ('John Doe');")

        # Commit the transaction
        conn.commit()

        # Query all rows in the users table
        cursor.execute("SELECT * FROM users;")
        rows = cursor.fetchall()

        print("Data from the users table:")
        for row in rows:
            print(row)

    except Error as e:
        print(f"Error connecting to SQLite: {e}")
    finally:
        if conn:
            conn.close()
            print("SQLite connection is closed")

if __name__ == "__main__":
    # Print the current working directory
    print(f"Current working directory: {os.getcwd()}")

    # Use an absolute path for the database file
    db_path = os.path.join(os.getcwd(), "test_database.db")
    connect_to_sqlite(db_path)
    
    # Check if the file was created
    if os.path.exists(db_path):
        print(f"Database file '{db_path}' was created successfully at {db_path}.")
    else:
        print(f"Failed to create the database file '{db_path}'.")
