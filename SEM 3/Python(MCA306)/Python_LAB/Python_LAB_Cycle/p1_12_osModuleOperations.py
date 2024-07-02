#1.Use the OS module to perform
    #1.1. Create a directory
    #1.2. Directory Listing
    #1.3. Search for “.py” files
    #1.4. Remove a particular file


import os

def createDirectory(directory):
    try:
        os.makedirs(directory)
        print(f"Directory '{directory}' created successfully.")
    except FileExistsError:
        print(f"Directory '{directory}' already exists.")
    except Exception as e:
        print(f"An error occurred: {e}")

def listDirectory(directory):
    try:
        files = os.listdir(directory)
        print(f"Listing contents of '{directory}':")
        for file in files:
            print(file)
    except FileNotFoundError:
        print(f"Directory '{directory}' does not exist.")
    except Exception as e:
        print(f"An error occurred: {e}")

def searchPythonfiles(directory):
    try:
        py_files = [f for f in os.listdir(directory) if f.endswith('.py')]
        if py_files:
            print(f"'.py' files in '{directory}':")
            for file in py_files:
                print(file)
        else:
            print(f"No '.py' files found in '{directory}'.")
    except FileNotFoundError:
        print(f"Directory '{directory}' does not exist.")
    except Exception as e:
        print(f"An error occurred: {e}")

def removeFile(file_path):
    try:
        os.remove(file_path)
        print(f"File '{file_path}' removed successfully.")
    except FileNotFoundError:
        print(f"File '{file_path}' does not exist.")
    except Exception as e:
        print(f"An error occurred: {e}")


while True:
    print("\nOptions:")
    print("1. Create a directory")
    print("2. List directory contents")
    print("3. Search for '.py' files")
    print("4. Remove a particular file")
    print("5. Exit")
    choice = input("Enter your choice: ")

    if choice == '1':
        directory = input("\nEnter the directory name to create: ")
        createDirectory(directory)
    elif choice == '2':
        directory = input("\nEnter the directory name to list: ")
        listDirectory(directory)
    elif choice == '3':
        directory = input("\nEnter the directory name to search for '.py' files: ")
        searchPythonfiles(directory)
    elif choice == '4':
        file_path = input("\nEnter the file path to remove: ")
        removeFile(file_path)
    elif choice == '5':
        print("\nExiting the program.")
        break
    else:
        print("Invalid choice. Please try again.")
