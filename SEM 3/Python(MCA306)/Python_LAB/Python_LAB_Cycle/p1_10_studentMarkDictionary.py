# Create a dictionary to store the name, roll_no, and total_mark of N students.
#Now print the details of the student with the highest total_mark.

#lambda x: x['marks'] is a lambda function defined inline.
#  It takes an argument x (which represents each student dictionary in students) and returns x['marks']. 
# This lambda function extracts the 'marks' value from each student dictionary.
def student_details(N):
    student=[]
    for i in range(N):
        print("\nEnter details of Student ",i+1," : ")
        name = input("Enter student name: ")    
        roll_no=input("Enter the roll no:")
        marks = int(input("Enter the marks: "))
        students={
            'name':name,
            'roll_no':roll_no,
            'marks':marks

        }
        student.append(students)
    return student
def find_top_student(students):
    top_student = max(students, key=lambda x: x['marks'])
    return top_student

N=int(input("Enter the number of students:"))
Student=student_details(N)
print("Student Details:\n")
print(Student)
top_student=find_top_student(Student)
print("Details of Top Student:\n")
print("Name:",top_student['name'])
print("Roll No:",top_student['roll_no'])
print("Marks:",top_student['marks'])