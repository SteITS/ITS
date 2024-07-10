from input_dati import *
import os
from datetime import *

stringa_menu ="""
********************************************************************
*                GESIONE Scontrini                                 *
********************************************************************
********************************************************************
*                    Menu utente principale                        *
********************************************************************
*  1) Inserimento articolo                                         *
*  2) Totale Articoli venduti                                      *
*  3) Totale degli sconti effettuati                               *
*  4) Stampa scontrino senza sconto                                *
*  5) Stampa scontrino con lo sconto                               *
*  6) Stampa scontrino con sconto ordinato per prezzo o per quantità a scelta *
*  7) Fine                                                         *
********************************************************************
"""

stringa_scontrino_SS="""
Scontrino:

 Articolo  Prezzo  Quantità  Tot
"""

def menu():
    while True:
        print(stringa_menu)
        s = input_range("Scelta operazione: ",int,1,7)
        if s in range(1,8):
            break
        else:
            print(" scelta errata!!",s)

    return s

def input_articolo(elenco):
    while True:
        p=[]
        nomeArt=input_gen("Inserisci nome articolo: ",str)
        prezzo=input_gen("Inserisci prezzo: ",int)
        quantita=input_gen("Inserisci quantità: ",int)
        p.append(nomeArt)
        p.append(prezzo)
        p.append(quantita)
        p.append(quantita*prezzo)
        elenco.append(p)
        scelta=input_range("Vuoi uscire 1.Si 2.No ",int,1,2)
        if scelta==1:
            break   

def calcolatot(elenco):
    prezzoSS=0
    for i in elenco:
        prezzoSS += i[1]*i[2]
    return prezzoSS

def totVend(elenco):
    tot=0
    for i in range (len(elenco)):
        tot= tot + elenco[i][2]
    return tot
#for i in elenco
#tot =+ i[2]

def calcoloScontoTot(elenco):
    totSconto=0
    for i in elenco:
        if i[1]*i[2]>50:
            totSconto+=(i[1]*i[2])*(10/100)
        if i[2]>5:
            totSconto+=(i[1]*i[2])*(5/100)
    return totSconto

def calcoloScontoParz(elenco1):
    for i in elenco1:
        totSconto=0
        if i[1]*i[2]>50:
            totSconto+=(i[1]*i[2])*(10/100)
        if i[2]>5:
            totSconto+=(i[1]*i[2])*(5/100)
        i.append(totSconto)
    
def printSS(elenco,prezzoSS):
    while True:
        print(datetime.now())
        txt="{:<20} {:<8} {:<8} {:<8}"
        print(txt.format("Articolo","Prezzo", "Quantita", "Totale"))    
        for i in range (len(elenco)):
            print(txt.format(str(elenco[i][0]),str(elenco[i][1]),str(elenco[i][2]),str(elenco[i][3])))
        print("Tot scontrino: ",prezzoSS)
        break

def printCS(elenco1,prezzoSS,totSconto):
    while True:
        print(datetime.now())
        txt="{:<20} {:<8} {:<8} {:<8} {:<8}"
        print(txt.format("Articolo","Prezzo", "Quantita", "Totale","Sconto"))
        for i in range (len(elenco1)):
            print(txt.format(str(elenco1[i][0]),str(elenco1[i][1]),str(elenco1[i][2]),str(elenco1[i][3]),str(elenco1[i][4])))
        print("Tot scontrino: ",prezzoSS)
        print("Tot sconto: ",totSconto)
        print("Tot scontato: ",prezzoSS-totSconto)
        break

def ordina_prezzo(elenco):
    elenco.sort(key=lambda x: x[1])  

def ordina_quantita(elenco):
    elenco.sort(key=lambda x: x[2])  
        

def SceltaOrdinamento(elenco,prezzoSS):
    while True:
        S=input_range("1.Ordinamento prezzo 2.Ordinamento quantità: ",int,1,2)
        if S==1:
            ordina_prezzo(elenco)
            elenco1=elenco
            totSconto=calcoloScontoTot(elenco)
            calcoloScontoParz(elenco1)
            printCS(elenco1,prezzoSS,totSconto)
            break
        else:
            ordina_quantita(elenco)
            elenco1=elenco
            totSconto=calcoloScontoTot(elenco)
            calcoloScontoParz(elenco1)
            printCS(elenco1,prezzoSS,totSconto)
            break


def main():
    elenco=[]
    ins=False
    while True:
        s=menu()
        match s:
            case 1:
                print("Inserimento articolo...")
                input_articolo(elenco)
                print("Inserimento riuscito")
                prezzoSS=calcolatot(elenco)
                ins=True
            case 2:
                if ins==True:
                    numVend=totVend(elenco)
                    print("Totale articoli venduti: ",numVend)
                else:
                    print("Errore! Devi inserire prima almeno un articolo")
            case 3:
                if ins==True:
                    totSconto=calcoloScontoTot(elenco)
                    print("Lo sconto totale è: ",totSconto)
                else:
                    print("Errore! Devi inserire prima almeno un articolo")
            case 4:
                if ins==True:
                    printSS(elenco,prezzoSS)
                else:
                    print("Errore! Devi inserire prima almeno un articolo")
            case 5:
                if ins==True:
                    elenco1=elenco
                    totSconto=calcoloScontoTot(elenco)
                    calcoloScontoParz(elenco1)
                    printCS(elenco1,prezzoSS,totSconto)
                else:
                    print("Errore! Devi inserire prima almeno un articolo")
            case 6:
                if ins==True:
                    SceltaOrdinamento(elenco,prezzoSS)
                else:
                    print("Errore! Devi inserire prima almeno un articolo")
            case 7:
                print("Arrivederci!")
                break

        input("premi invio per continuare.....")
        os.system("cls")

main()
