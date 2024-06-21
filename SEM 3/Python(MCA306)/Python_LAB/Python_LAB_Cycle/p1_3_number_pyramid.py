#Program to display number Pyramid
def numPyramid(n):
    for i in range(1 , n + 1):
        for j in range( n - i):
            print(" ",end ="") #To print leading spaces
            
        for j in range(1 , i+1):
            print(j ,end="") #printing num in ascending order
            
        for j in range (i - 1 ,0 , -1):
            print(j , end="") #print in desc order
            
        print() # To move to next line
            
            
n = int(input("Enter how many no.of rows to display : "))
numPyramid(n)


    
