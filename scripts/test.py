import os

dir = os.getcwd()
f = open(dir + "\data\\cpu\\test.txt", "w")
f.write("Insert CPU data")
f.close()