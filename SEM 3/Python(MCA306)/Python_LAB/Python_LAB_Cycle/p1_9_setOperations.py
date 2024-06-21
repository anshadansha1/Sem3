#Perform various set operations
# 1. Set Union
# 2. Set Intersection
# 3. Set Difference
def setOperations(set1, set2):
    
    union_set = set1.union(set2)
    

    intersection_set = set1.intersection(set2)
    

    difference_set1 = set1.difference(set2)
    

    difference_set2 = set2.difference(set1)
    
    return union_set, intersection_set, difference_set1, difference_set2


set1 = {1, 2, 3, 4, 5}
set2 = {3, 4, 5, 6, 7}

union_set, intersection_set, difference_set1, difference_set2 = setOperations(set1, set2)

print(f"Set1: {set1}")
print(f"Set2: {set2}")

print(f"Union of Set1 and Set2: {union_set}")
print(f"Intersection of Set1 and Set2: {intersection_set}")
print(f"Difference (Set1 - Set2): {difference_set1}")
print(f"Difference (Set2 - Set1): {difference_set2}")
