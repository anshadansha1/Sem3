#Pyramid

for  i in range(5) : 
     
    for j in range(5 - i - 1) : # Print leading spaces
        print(" ",end=" ")

    for k in range(2 * i - 1) : # Print stars
        print('* ',end="")

    print() # Move to the next line
    
