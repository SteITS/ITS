#calcola bis e giorno mese(L8)
from input_dati import *

def is_bisestile(anno):
    r=False
    if(anno%400==0 or (anno%4==0 and anno%100!=0)):
        r=True
    return r
def giorni_in_mese(m,a):
    if m<1  or m>12:
        return None
    else:
        giorni=[31,28,31,30,31,30,31,31,30,31,30,31]
        g=giorni[m-1]
        if m==2 and is_bisestile(a):
            g=29
        return g
    
def main():
    print("Programma ritorna num giorni del mese e dell'anno specifico")
    stdata=input_gen("inserisci mese e anno (mm/aaaa): ",str)
    mese,anno=stdata.split("/")
    if mese.isdigit() and anno.isdigit():
        mese=int(mese)
        anno=int(anno)
        giorni=giorni_in_mese(mese,anno)
        if giorni != None:
            print("Giorni del mese ",mese, " sono: ",giorni)
        else:
            print("data errata!")
    #print(stdata)

main()

