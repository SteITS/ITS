#calcola pari e dispari
from input_dati import *
def calcola_pari_dispari():
    #prendere in input più numeri e contare pari e dispari
    pari=0
    dispari=0
    number=input_gen("Inserisci numero (0 per terminare): ",int)
    while number!=0:
        if number % 2 == 0:
            pari +=1
        else:
            dispari +=1
        number=input_gen("Inserisci numero (0 per terminare): ",int)

    return pari,dispari
    
def main():
    p,d=calcola_pari_dispari()
    print("pari = ",p,"dispari = ",d)
main()