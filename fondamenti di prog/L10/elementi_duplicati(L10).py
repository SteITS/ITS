'''Eliminare da una lista gli elementi duplicati'''
from random import randint
from input_dati import *
def dimensione():
    dim=input_maggiore("Inserisci un numero maggiore di 0: ",int,0)
    return dim;

def carica_elementi(l, n):
    for i in range(n):
        l.append(randint(1,10))

def elimina_duplicati(l,n):
    b=[]
    for elem in l:
        if elem not in b:
            b.append(elem)
    return b

def main():
    print("Programma che elimina gli elementi duplicati di una lista")
    lista1=[]
    a=dimensione() #chiede all'utente quanti numeri vuole inserire
    print("Inserimento degli elementi nella lista")
    carica_elementi(lista1,a)
    print("lista:\n",lista1)
    print("Elimino duplicati della lista")
    lista2=elimina_duplicati(lista1,a)
    print("Lista senza duplicati: ",lista2)
main()