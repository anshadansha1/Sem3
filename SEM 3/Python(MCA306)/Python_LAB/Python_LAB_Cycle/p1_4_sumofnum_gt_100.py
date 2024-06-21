#Program to find the number and 
#Sum of all num > 100 and < 200 that are divisible by 7
def findNumAndSum():
    count = 0
    total_sum = 0
    
    for num in range(101, 200):
        if num % 7 == 0:
            count += 1
            total_sum += num
    
    return count, total_sum

count, totalSum = findNumAndSum()
print(f"The number of integers greater than 100 and less than 200 that are divisible by 7 is: {count}")
print(f"The sum of all these integers is: {totalSum}")
