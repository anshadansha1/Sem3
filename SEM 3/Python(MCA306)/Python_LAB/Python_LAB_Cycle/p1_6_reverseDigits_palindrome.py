#Write a Python program to reverse the digits of a given number and add them
#to the original. If the sum is not a palindrome, repeat this procedure.

def isPalindrome(n):
    original = n
    reverse = 0
    while n > 0:
        digit = n % 10
        reverse = reverse * 10 + digit
        n = n // 10
    return original == reverse

def reverseNumber(n):
    reverse = 0
    while n > 0:
        digit = n % 10
        reverse = reverse * 10 + digit
        n = n // 10 # It returns the quotient which is rounded down to the nearest integer.
    return reverse

def reverseAndAddUntilPalindrome(n):
    while not isPalindrome(n):
        reversed_n = reverseNumber(n)
        n = n + reversed_n
        print(f"Reversed: {reversed_n}, Sum: {n}")
    return n

number = int(input("Enter a number: "))
result = reverseAndAddUntilPalindrome(number)
print(f"The resulting palindrome is: {result}")
