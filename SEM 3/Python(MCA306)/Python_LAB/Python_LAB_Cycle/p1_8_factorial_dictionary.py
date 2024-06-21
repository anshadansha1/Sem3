#1.8. Write a function to find the factorial of a number but also store the factorials calculated in a dictionary.
def factorial_with_cache(n, cache={}):
    if n < 0:
        raise ValueError("Factorial is not defined for negative numbers.")
    if n in cache:
        return cache[n]
    if n == 0 or n == 1:
        result = 1
    else:
        result = n * factorial_with_cache(n - 1, cache)
    cache[n] = result
    print(cache[n])
    return result

number = int(input("Enter a number to calculate its factorial: "))
factorial = factorial_with_cache(number)
print(f"The factorial of {number} is: {factorial}")

