#Parent Class :
class Person:
    def __init__(self, fname , lname) :
        self.firstname = fname
        self.lastname = lname
        
    def printName(self):
        print(self.firstname,self.lastname)
        
x = Person('Anshad' , 'Muhammad')
x.printName() 
        
#Child Class :
class Student(Person):
    def __init__(self , fname,lname,age) :
        super().__init__(fname,lname) #super function called to pass values to parent class
        self.Age = age
    def printAll(self) :
        super().printName()
        print(self.Age)
        
y = Student('Nihal','Muhd',23)
y.printAll()