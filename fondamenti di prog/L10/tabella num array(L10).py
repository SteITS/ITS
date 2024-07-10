#crea una tabella di numeri intera usando lista di lista
from random import randint


def crea_matrice(r,c):
    tab=[]
    for j in range(r):
        riga=[0]*c
        tab.append(riga)
    return tab

def stampa_matrice(t):
    for i in range(len(t)):
        print(t[i])
        #for j in range(len(t[0])):
         #   print(str(t[i][j]),end="")
        #print()

def carica_matrice(t):
    for i in range(len(t)):
        for j in range(len(t[0])):
            t[i][j] = randint(1,100)

def main():
    r=10
    c=15
    l=crea_matrice(r,c)
    #print(l)
    stampa_matrice(l)
    carica_matrice(l)
    print("matrice con numeri random da 1 100:n")
    stampa_matrice(l)


main()