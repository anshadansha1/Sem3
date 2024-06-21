def recSum(num):
    if num == 0 :
        return 0
    else :
        return num + recSum( num - 1)
    


result = recSum(10)
print("Result  : " , result)