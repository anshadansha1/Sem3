#Program to calculate the sum of numbers from 0 to 10 using recursion
def recursiveSum(n):
    # Base case
    if n == 0:
        return 0
    else:
        # Recursive case
        return n + recursiveSum(n - 1)


result = recursiveSum(10)
print(f"The sum of numbers from 0 to 10 is: {result}")
