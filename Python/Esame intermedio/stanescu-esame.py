from input_dati import *
import os

stringa_menu ="""
********************************************************************
*                GESIONE Fantacalcio                               *
********************************************************************
********************************************************************
*                    Menu utente principale                        *
********************************************************************
*  1) Inserimento dati delle squadre                                         
*  2) Stampa la classifica delle squadre in ordine decrescente di punteggio                                     
*  3) Modifica i punti di una squadra                             
*  4) Stampa classifica titoli degli allenatori in ordine decrescente di titoli                               
*  5) Numero totale di allenatori che hanno vinto Y titoli                              
*  6) Stampa squadre con più di Y punti in classifica (Y preso in input)
*  7) Stampa squadre con allenatori che hanno vinto più di Y titoli (Y preso in input).        
*  8) Fine                                               
********************************************************************
"""

def menu():
    while True:
        print(stringa_menu)
        s = input_range("Scelta operazione: ",int,1,8)
        if s in range(1,9):
            break
        else:
            print(" scelta errata!!",s)
    return s

def input_dati(elenco):
    while True:
        p=[]
        nomesq=input_gen("Inserisci nome squadra: ",str)
        colore=input_gen("Inserisci colore maglia: ",str)
        punti=input_gen("Inserisci punteggio squadra: ",int)
        nomeal=input_gen("Inserisci nome allenatore: ",str)
        cognomeal=input_gen("Inserisci cognome allenatore: ",str)
        titoli=input_gen("Inserisci n titolo vinti: ",int)
        p.append(nomesq)
        p.append(colore)
        p.append(punti)
        p.append(nomeal)
        p.append(cognomeal)
        p.append(titoli)
        elenco.append(p)
        scelta=input_range("Vuoi uscire 1.Si 2.No ",int,1,2)
        if scelta==1:
            break   

def ordina_punteggio(elenco):
    elenco.sort(key=lambda x: x[2], reverse=True)

def stampa_classifica(elenco):
    while True:
        txt="{:<20} {:<8} {:<10}"
        print(txt.format("Squadra","Punti","Colore Maglia"))
        for i in range(len(elenco)):
            print(txt.format(elenco[i][0],elenco[i][2],elenco[i][1]))
        break

def scelta_squadra(elenco):
        s=''
        j=0
        s=input_gen("inserisci il nome della squadra che vuoi modificare i punti: ",str)
        for i in range(len(elenco)):
            if s==elenco[i][0]:
                j+=1
                return s;
        if j!=1:
            print("La squadra", s, "non esiste")

def scegli_punteggio():
    p=input_gen("inserisci i punti squadra: ",int)
    return p

def mod_punti(elenco):
    while True:
        s=scelta_squadra(elenco)
        for i in range(len(elenco)):
            if s == elenco[i][0]:
                p=scegli_punteggio()
                elenco[i][2]=p
                print(elenco[i])
                break
        break

def ordina_titoli(elenco):
    elenco.sort(key=lambda x: x[5], reverse=True)

def stampa_titoli(elenco):
    while True:
        txt="{:<10} {:<10} {:<10} {:<10}"
        print(txt.format("Cognome","Nome","Titoli","Squadra"))
        for i in range(len(elenco)):
            print(txt.format(elenco[i][4],elenco[i][3],elenco[i][5],elenco[i][0]))
        break

def input_tit():
    n=input_gen("inserisci in numero di titoli che vuoi cercare: ",int)
    return n

def conta(elenco):
    n=input_tit()
    c=0
    for i in range(len(elenco)):
        if n == elenco[i][5]:
            c=+1
    return c,n

def input_punti():
    n=input_gen("inserisci il numero di punti: ",int)
    return n

def sqpiu(elenco1):
    while True:
        n=input_punti()
        for i in range(len(elenco1)):
            if n > elenco1[i][2]:
                del elenco1[i]
        stampa_punti(elenco1)
        break

def stampa_punti(elenco1):
    while True:
        txt="{:<10} {:<6}"
        print(txt.format("Squadra","Punti"))
        for i in range(len(elenco1)):
            print(txt.format(elenco1[i][0],elenco1[i][2]))
        break

def squadre_tit(elenco1):
    while True:
        n=input_tit()
        for i in range(len(elenco1)):
            if n > elenco1[i][5]:
                del elenco1[i]
        stampa_titoli(elenco1)
        break

def main():
    elenco=[]
    ins=False
    while True:
        s=menu()
        match s:
            case 1:
                print("Inserimento dati...")
                input_dati(elenco)
                print("Inserimento riuscito")
                ins=True
            case 2:
                if ins==True:
                    ordina_punteggio(elenco)
                    stampa_classifica(elenco)
                else:
                    print("Errore! Devi inserire prima almeno una squadra")
            case 3:
                if ins==True:
                    print("Modifica punteggio...")
                    mod_punti(elenco)
                else:
                    print("Errore! Devi inserire prima almeno una squadra")
            case 4:
                if ins==True:
                    ordina_titoli(elenco)
                    stampa_titoli(elenco)
                else:
                    print("Errore! Devi inserire prima almeno una squadra")
            case 5:
                if ins==True:
                    c,n=conta(elenco)
                    print("totale Allenatori che hanno vinto", n ,"titoli: ",c)
                else:
                    print("Errore! Devi inserire prima almeno una squadra")
            case 6:
                if ins==True:
                    ordina_punteggio(elenco)
                    elenco1=elenco.copy()
                    sqpiu(elenco1)
                else:
                    print("Errore! Devi inserire prima almeno una squadra")
            case 7:
                if ins==True:
                    ordina_titoli(elenco)
                    elenco1=elenco.copy()
                    squadre_tit(elenco1)
                else:
                    print("Errore! Devi inserire prima almeno una squadra")
            case 8:
                print("Arrivederci!")
                break


        input("premi invio per continure...")
        os.system("cls")
main()