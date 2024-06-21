#Write a menu-driven program that performs the following operations on
# strings
# 1. Check if the String is a Substring of Another String
# 2. Count Occurrences of Character
# 3. Replace a substring with another substring
# 4. Convert to Capital Letters

def checkSubstring():
    string = input("Enter the main string: ")
    substring = input("Enter the substring to check: ")
    
    if substring in string:
        print(f"'{substring}' is a substring of '{string}'")
    else:
        print(f"'{substring}' is not a substring of '{string}'")

def countOccurrences():
    string = input("Enter the string: ")
    char = input("Enter the character to count: ")
    
    count = string.count(char)
    print(f"Number of occurrences of '{char}' in '{string}': {count}")

def replaceSubstring():
    string = input("Enter the main string: ")
    old_substring = input("Enter the substring to replace: ")
    new_substring = input("Enter the new substring: ")
    
    new_string = string.replace(old_substring, new_substring)
    print(f"Modified string: '{new_string}'")

def convertToUpper():
    string = input("Enter the string to convert to uppercase: ")
    uppercase_string = string.upper()
    print(f"Uppercase string: '{uppercase_string}'")

# Main program
while True:
    print("\nMenu:")
    print("1. Check if String is a Substring of Another String")
    print("2. Count Occurrences of Character")
    print("3. Replace a substring with another substring")
    print("4. Convert to Capital Letters")
    print("5. Exit")
    
    choice = input("Enter your choice (1-5): ")
    
    if choice == '1':
        checkSubstring()
    elif choice == '2':
        countOccurrences()
    elif choice == '3':
        replaceSubstring()
    elif choice == '4':
        convertToUpper()
    elif choice == '5':
        print("Exiting the program...")
        break
    else:
        print("Invalid choice! Please enter a number from 1 to 5.")
