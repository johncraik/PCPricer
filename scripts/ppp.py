import os
from pcpartpicker import API


def GetCPU(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("cpu")

    #modify directory to add txt file
    dir = os.path.join(dir, 'cpu.txt')

    #open file, append it (write) and close it.
    f = open(dir, "a")
    f.write(data.to_json())
    f.close()
    return data 


def main():
    #load the pcpartpicker (ppp) API
    #set region (parameter) as UK
    api = API("uk")

    #obtain relative path:
    path = os.path.realpath(os.path.join(os.path.dirname(__file__), '..', 'data'))

    #Get ppp data:
    print(GetCPU(api, path))


if __name__ == "__main__":
    main()
