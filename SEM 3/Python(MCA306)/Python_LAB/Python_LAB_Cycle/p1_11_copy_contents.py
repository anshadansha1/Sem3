# Write a Python program to copy the contents of a file into another file, line by line.

# Function to copy contents from one file to another
def Copy(sourceFile, destinationFile):
    try:
        # Open the source file in read mode
        with open(sourceFile, 'r') as src:
            # Open the destination file in write mode
            with open(destinationFile, 'w') as dest:
                # Read and write each line from source to destination
                for line in src:
                    dest.write(line)
        print(f"\nContents are copied from {sourceFile} to {destinationFile} Successfully.")
    except FileNotFoundError:
        print(f"\nThe file {sourceFile} does not exist.")
    except IOError as e:
        print(f"An error occurred: {e}")

# Take input from user:
sourceFile = input("\nEnter the source file name: ")
destinationFile = input("\nEnter the destination file name: ")

Copy(sourceFile, destinationFile) #Calling method