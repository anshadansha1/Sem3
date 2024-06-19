#-----Convet from JSON to Python------
import json

#JSON case:
x =  '{ "name":"John", "age":30, "city":"New York"}'

# parsing JSON which is in  x:
y = json.loads(x)

# As a result we get dictionary:
print(y["age"])
print(type(y))


#-----Convet from Python to Json-----------------------------

# a Python object (dict):
x = {
  "name": "John",
  "age": 30,
  "city": "New York"
}

# convert into JSON:
y = json.dumps(x)

# the result is a JSON string:
print(y)