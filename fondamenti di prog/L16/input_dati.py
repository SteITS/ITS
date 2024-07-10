#controllo numero intero(L6)
def input_gen(st,tipo):
    while True:
        try:
            x=tipo(input(st))
            if tipo==str:
                if(x==""):
                    raise Exception()
            break
        except:
            print("Errore!! Input errato...")
    return x

#contolla num > m
def input_range(st,tipo,m1,m2):
    while True:
        n=input_gen(st,tipo)
        if not (n>= m1 and n <= m2):
            print("Input errato: Inserisci numero compreso tra "+str(m1)+" e "+str(m2)+"!")
        else:
            break
    return n



def input_maggiore(st,tipo,m,):
    while True:
        n=input_gen(st,tipo)
        if not (n > m):
            print("Input errato: Inserisci numero maggiore di "+str(m))
        else:
            break
    return n

def input_data(st):
    from datetime import datetime
    while True:
        stdata=input(st)
        try:
            d=datetime.strptime(stdata,'%d/%m/%Y')
            break
        except:
            print("Errore! Data errata...")
    return d

#from InputDati import *

def main():
    '''    n=input_gen("Inserisci numero: ",int)
    print(n,type(n))
    m=input_gen("Inserisci numero float: ",float)
    print(m,type(m))
    s=input_gen("Inserisci stringa: ",str)
    print(s,type(s))

    n=input_maggiore("Inserisci numero positivo: ",float,0)
    print(n)
    n=input_range("Inserisci numero tra 2 e 10: ",float,2,10)
    print(n)

    d=input_data("Inserisci data (gg/mm/aaaa): ")
    print(d)
'''
main()

