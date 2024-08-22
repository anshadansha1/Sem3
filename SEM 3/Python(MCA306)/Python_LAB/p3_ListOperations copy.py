#LIST
nameList = ['Anshad','Nihal','Majo','Minu rose','Leo']

#If condition : To find a Name inside a list
if 'Majo' in nameList :
    print('Name Found')
else:
    print('Name Not Found')

#Sorting List :
nameList.sort()

#For Loop :To print all names inside list
for i in nameList :
    print(i)

#While loop:
i = 0 #You should initialize first for while loop
print('\n')
while i <len(nameList) : #Should give termination condition
    print(nameList[i])
    i += 1 
    
