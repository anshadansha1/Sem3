# Create a dictionary to store the name, roll_no, and total_mark of N students.
#Now print the details of the student with the highest total_mark.

def student_with_highest_marks(students):
    if not students:
        return "No students data provided."

    # Initialize variables to track the highest marks and corresponding student details
    highest_marks = -1
    top_student = None

    # Iterate through the students dictionary to find the student with the highest marks
    for roll_no, details in students.items():
        total_marks = details['total_marks']
        if total_marks > highest_marks:
            highest_marks = total_marks
            top_student = details

    return top_student


def main():
    n = int(input("Enter the number of students: "))

    students = {}
    for i in range(n):
        print(f"\nEnter details for student {i+1}:")
        name = input("Enter student name: ")
        roll_no = input("Enter roll number: ")
        total_marks = float(input("Enter total marks: "))
        students[roll_no] = {'name': name, 'roll_no': roll_no, 'total_marks': total_marks}

    top_student = student_with_highest_marks(students)

    if top_student:
        print("\nDetails of the student with the highest total marks:")
        print(f"Name: {top_student['name']}")
        print(f"Roll Number: {top_student['roll_no']}")
        print(f"Total Marks: {top_student['total_marks']}")
    else:
        print("No student records found.")

if __name__ == "__main__":
    main()
