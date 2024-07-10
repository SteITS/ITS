from sys import path
from os import strerror
import os
from input_dati import *


stringa_menu="""=========== programma che scrive dati degli alunni su file di testo=========

******************************* Menu scelta:********************************
1) Inserire dati e scrittura su file
2) Leggere dati dal file e stamparli
3) Fine programma
****************************************************************************
"""

def menu():
    while True:
        os.system("cls")
        print(stringa_menu)
        sc=input_range("Scelta operazione: ",int,1,3)
        return sc;

def apri_file(messaggio,mod,enc):
    f=None
    file=input(messaggio)
    try:
        if(os.path.exists(file)==True):
            sc=input_gen("File già esiste. Vuoi sovvrascriverlo? S/N ",str) 
            if sc.upper()=="S":
                f=open(file,mode=mod,encoding=enc)
            elif sc.upper()=="N":
                f=open(file,mode="a",encoding=enc)
            else:
                print("Input non riconosciuto")
        else:
            f=open(file,mode=mod,encoding=enc)
    except IOError as e:
        print(strerror(e.errno))
    return f;

def inserimento_dati():
    while True:
        alunno=""
        nome=input_gen("Inserisci nome alunno",str)
        media=input_range("Inserisci media alunno: ",float,1,10)
        if media >=6:
            promosso="P"
        else:
            promosso="R"
        alunno= nome + ";" + str(media) + ";" + promosso + "\n"
        print(alunno)
        sc=input_gen("Vuoi terminare? S/N",str)
        if(sc.upper()=="S"):
            return alunno
        
    
def scrivi_su_file(f,dati):
    f.write(dati)


def main():
    print(os.getcwd())
    while True:
        s=menu()
        match s:
            case 1:
                print("inserimento dati")
                f=apri_file("Inserisci il nome del file su cui scrivere i dati ",'w','utf-8')
                if(f!=None):
                    dati=inserimento_dati()
                    scrivi_su_file(f,dati)
                    f.close()
                else:
                    print("Inserimento dati non effetuato, file già esistente")
            case 2:
                pass
            case 3:
                print("Fine programma")
                break
        input("premi invio per continuare...")
        os.system("cls")
main()