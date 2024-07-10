#convertitore temperature(L9)
from input_dati import *
def scegli():
    v1=input_gen("Che valore vuoi convertire C/K/F? ",str)
    while True:
        v1=v1.upper()
        if v1 == "C" or v1 == "F" or v1=="K":
            break
        else:
            v1=input_gen("Valore non riconosciuto. Che valore vuoi convertire C/K/F? ",str)


    v2=input_gen("In cosa vuoi convertire C/K/F? ",str)
    while True: 
        v2=v2.upper()
        if v2 == "C" or v2 == "F" or v2=="K":
            break
        else:
            v2=input_gen("Valore non riconosciuto. In cosa vuoi convertire C/K/F? ",str) 
    return v1,v2


def valore(v1):
    while True:
        if v1=="C":
            temp=input_range("Inserisci temperatura in celsius: ",float,-999.99,999.99)
            if temp>-999.99 and temp<999.99:
                hold=temp
                break
        elif v1=="F":
            temp=input_range("Inserisci temperatura in fahrenheit: ",float,-1272.99,1272.99)
            if temp>-1272.99 and temp<1272.99:
                hold=temp
                temp=(temp-32)/1.8
                break
        else:
            temp=input_range("Inserisci temperatura in kelvin: ",float,-1830.99,1830.99)
            if temp>-1830.99 and temp<1830.99:
                hold=temp
                temp=temp-273.15
                break
    return temp,hold

def calcolo(temp,v2):
    if v2=="C":
        temp=temp
    elif v2=="F":
        temp=(temp*1.8)+32
    else:
        temp=temp+273.15
    return temp


def main():
    v1,v2=scegli()
    temp,hold=valore(v1)
    final=calcolo(temp,v2)
    print(hold,v1," equivale a ",final,v2)
    
main()