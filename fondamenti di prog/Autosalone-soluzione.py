# esercizio gestione Autosalone
from input_dati import *
import os
from random import randint
import operator


stringa_menu ="""
********************************************************************
*                GESIONE AUTOSALONE                                *
********************************************************************
********************************************************************
*                    Menu utente principale                        *
********************************************************************
*  1) Inserimento dati AUTO                                        *
*  2) Visuallizza cognome acquirenti auto superiore a 1500 cc      *
*  3) Totale di auto   immatricolate in un anno                    *
*  4) Ordina per anno di immatricolazione                          *
*  5) Stampare elenco auto                                         *
*  6) =======> Uscita                                              *
********************************************************************
"""


def menu():
    while True:
        print(stringa_menu)
        sc = input_range("Scelta operazione: ",int,1,6)
        if sc in range(1,7):
            break
        else:
            print(" scelta errata!!",sc)

        input("premi invio....")
        os.system("cls")
    return sc
def Inserimento(elenco):
    while True:
        p=[]
        nomeauto=input_gen("Inserisci la marca dell'auto: ",str)
        nome=input_gen("inserisci il nome: ",str)
        cognome=input_gen("inserisci il cognome: ",str)
        anno=input_gen("Inserisci l'anno di immatricolazione: ",int)
        cilindrata=input_gen("Inserisci la cilindrata: ",int)
        p=[nomeauto,cilindrata,anno,nome,cognome]
        #p.append(nomeauto)
        #p.append(cilindrata)
        #p.append(anno)
        #p.append(nome)
        #p.append(cognome)
        elenco.append(p)
        scelta=input_range("vuoi uscire? 1.Si 2.No",int,1,2)
        if scelta==1:
            break    
def StampaSup1500(elenco):
    for p in elenco:
        if p[1]>1500:
            print(p)
           
def TotaleAutoAnno(elenco,anno):
    '''calcola il totale auto di un anno preso in input; input elenco,anno'''     
    tot=0
    for p in elenco:
        if p[2]==anno:
            tot+=1
    return tot

def OrdinaPerAnno(elenco):
    elenco.sort(key=lambda x:x[2])
    return True     

def StampaAuto(elenco):
    '''stampa elenco delle auto:    input: elenco'''
    print("******************* Auto Immatricolate ordinate per Anno **************")
    print
    print("Anno: ",elenco[0][2])    
    for i in range(len(elenco)):
        if i>0 and elenco[i][2]!=elenco[i-1][2]:
            print("Anno: ",elenco[i][2])
        print("\t",elenco[i][0],",",elenco[i][1],",",elenco[i][3])

def main():
    #si suppone che la struttura dati che si vuole realizzare sia come la seguente (lista di di lista):
    Autosalone=[
          ["Fiat",1200, 2004, "Marco","Rossi"],
          ["Opel",2000, 1999, "Antonio","Bianchi"],
          ["Mercedes",2500, 1999, "Sergio","verdi"],
    ]    
    elenco=Autosalone
    ins=True
    while True:
        s=menu()
        match s:
            case 1:
                print("Inserimento dati")
                ret=Inserimento(elenco) 
                print("Inserimento dati effettuato...")
                ins=True
            case 2:
                ret=OrdinaPerAnno(elenco)
                print("Visuallizza cognome acquirenti auto superiore a 1500 cc")
                if ins==True:
                    StampaSup1500(elenco)
                else:
                    print("Dati non inseriti! Inserire prima i dati.")
            case 3:
                print("Totale auto immatricolate in un anno ")
                if ins==True:
                    anno=input_gen("inserisci anno: ",int)
                    totale=TotaleAutoAnno(elenco,anno)
                    print(totale)
                else:
                    print("Dati non inseriti! Inserire prima i dati.")                
            case 4:
                print("Ordina per anno di immatricolazione")
                if ins==True:
                    ret=OrdinaPerAnno(elenco)
                    #StampaClassificaAllenatori(fanta)
                else:
                    print("Dati non inseriti! Inserire prima i dati.")
            case 5:
                print("Stampare elenco auto")
                if ins==True:
                    StampaAuto(elenco)
                else:
                    print("Dati non inseriti! Inserire prima i dati.")              
            case 6:
                print("fine programma")
                break
            
        input("premi invio per continuare.....")
        os.system("cls")

main()
