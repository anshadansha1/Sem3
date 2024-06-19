#File handling:

#To create a file
# f = open("file1.txt","x") 

#To Write into a file
f2 = open("file2.txt","w")
f2.write("Hello from code")

#To read a file 
f3 = open("file1.txt","r") 
print(f3.read())

#To append to a File
f4 = open("file1.txt","a")
f4.write("Appending to FIle1")

#To delete a file :
import os 
os.remove("filedel.txt")