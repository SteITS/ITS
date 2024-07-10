#calcola fattoriale di un numero n
from input_dati import *
def fattoriale(n:int):
    if n<0:
        f=None
    elif n<2:
        f=1
    else:
        f=1
        for i in range(2,n+1):
            f *= i
    return f

def main():
    x=input_gen("Inserisci numero intero: ",int)
    n=fattoriale(x)
    print("fattoriale di "+str(x)+" = ", n)
main()