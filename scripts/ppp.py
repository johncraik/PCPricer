import os
from pcpartpicker import API


def WriteData(data, dir):
    #open file, append it (write) and close it.
    f = open(dir, "a")
    f.write(data.to_json())
    f.close()


def GetCPU(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("cpu")

    #modify directory to add txt file
    dir = os.path.join(dir, 'cpu.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetCPUCooler(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("cpu-cooler")

    #modify directory to add txt file
    dir = os.path.join(dir, 'cpu-cooler.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetGPU(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("video-card")

    #modify directory to add txt file
    dir = os.path.join(dir, 'gpu.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetMotherboard(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("motherboard")

    #modify directory to add txt file
    dir = os.path.join(dir, 'motherboard.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetMemory(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("memory")

    #modify directory to add txt file
    dir = os.path.join(dir, 'memory.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetHDD(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("internal-hard-drive")

    #modify directory to add txt file
    dir = os.path.join(dir, 'hdd.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data

def GetPSU(ppp, dir):
        #obtain the data using the API
    data = ppp.retrieve("power-supply")

    #modify directory to add txt file
    dir = os.path.join(dir, 'psu.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetCase(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("case")

    #modify directory to add txt file
    dir = os.path.join(dir, 'case.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def GetCaseFan(ppp, dir):
    #obtain the data using the API
    data = ppp.retrieve("case-fan")

    #modify directory to add txt file
    dir = os.path.join(dir, 'case-fan.txt')
    WriteData(data, dir)

    #return the data to 'main' func
    return data


def main():
    #load the pcpartpicker (ppp) API
    #set region (parameter) as UK
    api = API("uk")

    #obtain relative path:
    path = os.path.realpath(os.path.join(os.path.dirname(__file__), '..', 'data'))

    #Get ppp data:
    print(GetCPU(api, path))
    print(GetCPUCooler(api, path))
    print(GetGPU(api, path))
    print(GetMotherboard(api, path))
    print(GetMemory(api, path))
    print(GetHDD(api, path))
    print(GetPSU(api, path))
    print(GetCase(api, path))
    print(GetCaseFan(api, path))


if __name__ == "__main__":
    main()
