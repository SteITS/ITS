#Indice BMi(L8)
from input_dati import *

def BMI(p,h):
    return p/(h*h)

def feet_to_cm(h):
    cm=h/3.281
    return cm

def libbre_to_kg(p):
    kg=p/2.205
    return kg

def cm_to_m(h):
    h=h/100
    return h

def tinput():
    while True:
        inp=input("EU per le misure europee, EN per le misure inglesi: ")
        inp=inp.upper()
        if(inp=="EU" or inp=="EN"):
            if(inp=="EU"):
                h=input_range("Inserisci Altezza in cm compreto tra 10 e 220: ",float,10,220)
                p=input_range("Inserisci Peso in Kg compreso tra 10 e 180: ",float,10,180)
                h=cm_to_m(h)
                final=BMI(p,h)
                return final
            else:
                h=input_range("Inserisci Altezza in piedi compreso tra 0.3 e 7.2: ",float,0.3,7.2)
                p=input_range("Inserisci Peso in libbre compreso tra 22 e 400: ",float,22,400)
                h=feet_to_cm(h)
                p=libbre_to_kg(p)
                final=BMI(p,h)
                return final
        else:
            print("NON valido,EU per le misure europee, EN per le misure inglesi: ")

def main():
    final=tinput()
    print("Il tuo indice BMI è: ",final)
main()
