import os

#obtain relative path:
dir = os.path.realpath(os.path.join(os.path.dirname(__file__), '..', 'data', 'cpu.txt'))

#open file, append it (write) and close it.
f = open(dir, "a")
f.write("Insert CPU data")
f.close()

#pause program
input()