# #Calculator Arithmetic 

num1 = float(input('Enter the first Number : '))
num2 = float(input('Enter the second Number : '))
op = input('Select the operator : \n+\n-\n*\n/\n')

if op == '+' :
    sum = num1 + num2
    print('Sum of two numbers is ',sum)
elif op == '-' : 
    diff = num1 - num2 
    print('Difference of two numbers is ',diff)
elif op == '*' :
    prod = num1 * num2
    print('Product of two numbers is : ',prod)
elif op == '/' :
    if num2 == 0 :
        print('Division by zero Not possible')
    div = num1 / num2
    print('Division : ',div)
else :
    print('Invalid input')