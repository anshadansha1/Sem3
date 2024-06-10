#LIST[using square brackets]:
list1 = [1.2,-2,3,4,5]
list2 = ['Anshad','Nihal','Majo','Sree']
list3 = [25,44,('a','b','c')]

print(type(list1))
print(list1)
print(type(list2))
print(list2)
print(type(list3))
print(list3)
print(list1[-1])
list1.insert(2,"muhd nihal") #insert()
print(list1[2])
list1.append("Hari") #append() at last of list 
print(list1,"---------------->\n")
listcopy = list1.copy() #copy() list1 to a new list
print("Copy of list1->\n",listcopy)

#LIST using Constructor :
list4 = list((2,4,6,8))
print(type(list4))
print(list4)

#TUPLE 
mytuple = ("apple", "banana", "cherry")
mytuple2 = ("apple", "banana", "cherry",[1,2,3])

print(type(mytuple))
print(mytuple)
print(type(mytuple2))
print(mytuple2)

#SETS
myset = {"apple", "banana", "cherry",('Red','Black')}
print(type(myset))
print(myset)
set1 = {1,2,3,4,5}
set2 = {'a','b','c','d',21,22,23,'a',22,'23'}
print('----------->\n',set1)
print(set2)



#Dictionaries

thisdict = {
  "brand": "Ford",
  "model": "Mustang",
  "year": 1964,
  "colors": ["red", "white", "blue"],
  "Rating" :{
      "style" : 4.5,
      "color" : 5
  }
  
}

thisdict2 = {
  "brand": "Toyota",
  "model": "Crysta",
  "year": 2020,
  "colors": ["red", "white", "blue"],
  "Rating" :{
      "style" : 5,
      "color" : 3.9
  }
  
}

print(type(thisdict))
print(thisdict)
print(thisdict["Rating"])#accessing value inside dictionaries
print(thisdict.get("brand"))#accessing using 'get'
print(thisdict,thisdict2)

#NESTED Dictionaries
dictionery = {
    "thisdict" :{
        "brand": "Ford",
        "model": "Mustang",
        "year": 1964,
        "colors": ["red", "white", "blue"],
        "Rating" :{
            "style" : 4.5,
            "color" : 5
            }
    },
    "thisdict2" : {
        "brand": "Ford",
        "model": "Mustang",
        "year": 1964,
        "colors": ["red", "white", "blue"],
        "Rating" :{
            "style" : 4.5,
            "color" : 5
            }
    }
}
print(dictionery["thisdict"]["Rating"])



thisdict["year"] = 2018 #changing values
thisdict.update({"year": 2020}) #updating values