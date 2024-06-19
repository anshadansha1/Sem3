#Creating a Class
class Sem3:
    def __init__(self,name,age): #__init__ function is executed when the class is being initiated
        self.name = name
        self.age = age
    def student(self): #any function you write should have a self as parameter
        subjects = {
            'sub1' : 'Data Mining',
            'sub2' : 'Information Security',
            'sub3' : 'Theory of Computation'
        }
        print(subjects)

stud1 = Sem3('Anshad',24) # Object creation 
print(stud1.name,'\n',stud1.age)
stud1.student()