from random import randint

def crea_matrice(r,c):
    tab=[]
    for j in range(r):
        riga=[0]*c
        tab.append(riga)
    return tab

def carica_matrice(t):
    for i in range(len(t)):
        for j in range(len(t[0])):
            t[i][j] = randint(10,30)

def print_matrice(t):
    for i in range(len(t)):
        for j in range(len(t[0])):
            print(str(t[i][j]),"|",end="")
        print()

def somma(A,B):
    C=crea_matrice(5,5)
    for riga in range(len(A)):
        for colonna in range(len(B)):
            C[riga][colonna]=A[riga][colonna]+B[riga][colonna]
    return C;

def prodotto(A,B):
    D=crea_matrice(5,5)
    for riga in range(len(A)):
        for colonna in range(len(B)):
            D[riga][colonna]=A[riga][colonna]*B[riga][colonna]
    return D;


def main():
    r=5
    c=5
    A=crea_matrice(r,c)
    B=crea_matrice(r,c)
    carica_matrice(A)
    carica_matrice(B)
    print(A)
    print(B)
    C=somma(A,B)
    D=prodotto(A,B)
    print_matrice(C)
    print_matrice(D)
main()