from input_dati import *
import os

stringa_menu ="""
********************************************************************
*                GESIONE Rubrica Telefonica                        *
********************************************************************
********************************************************************
*                    Menu utente principale                        *
********************************************************************
*  1) Inserimento del numero di telefono                                     
*  2) Modifica numero di telefono                                    
*  3) Stampa rubrica ordinata (a scelta per Nominativo o Città)                             
*  4) Eliminazione numero di telefono                          
*  5) Scrittura su file "Rubrica.txt"                            
*  6) Lettura su file "Rubrica.txt"      
*  7) Fine                                               
********************************************************************
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

def input_dati(elenco):
    while True:
        p=[]
        nominativo=input_gen("Inserisci nome: ",str)
        telefono1=input_gen("Inserisci numero di telefono primario: ",int)
        telefono2=input_gen("Inserisci numero di telefono secondario: ",int)
        indirizzo=input_gen("Inserisci indirizzo: ",str)
        citta=input_gen("Inserisci città: ",str)
        societa=input_gen("Inserisci società: ", str)
        p.append(nominativo)
        p.append(telefono1)
        p.append(telefono2)
        p.append(indirizzo)
        p.append(citta)
        p.append(societa)
        elenco.append(p)
        scelta=input_range("Vuoi uscire 1.Si 2.No ",int,1,2)
        if scelta==1:
            break   

def scelta_contatto(elenco):
        s=''
        n=0
        j=0
        s=input_gen("inserisci il nome del contatto: ",str)
        for i in range(len(elenco)):
            if s==elenco[i][0]:
                n=input_range("1. Modifica telefono1 2. Modifica telefono2: ",int,1,2)
                j+=1
                return s,n;
        if j!=1:
            print("Il contatto ", s, " non esiste")
            return s,n
            

def scegli_num():
    p=input_gen("inserisci il nuovo num di telefono: ",int)
    return p


def mod_num(elenco):
    while True:
        s,n=scelta_contatto(elenco)
        for i in range(len(elenco)):
            if s == elenco[i][0]:
                if n==1:
                    p=scegli_num()
                    elenco[i][1]=p
                    print(elenco[i])
                if n==2:
                    p=scegli_num()
                    elenco[i][2]=p
                    print(elenco[i])
                break
        break

def ordina_rub(elenco):
    while True:
        s=input_range("1.Ordinamento per nominativo 2.Ordinamento per Città: ",int,1,2)
        if(s==1):
            elenco.sort(key=lambda x: x[0])
        elif(s==2):
            elenco.sort(key=lambda x: x[4])
        stampa_rub(elenco)
        break
        
def stampa_rub(elenco):
    while True:
        txt="{:<10} {:<10} {:<10} {:<10}"
        print(txt.format("Nominativo","telefono 1","Telefono 2","Indirizzo","Città","Società"))
        for i in range(len(elenco)):
            print(txt.format(elenco[i][0],elenco[i][1],elenco[i][2],elenco[i][3],elenco[i][4],elenco[i][5]))
        break
    
def elimina_rub(elenco):
    while True:
        s=scelta_contatto(elenco)
        for i in range(len(elenco)):
            if s == elenco[i][0]:
                del elenco[i]
                break
        break

def scrivi_file(elenco):
    with open("Rubrica.txt", 'w+') as f:
        for i in range(len(elenco)):
            f.write(str(elenco[i]))
            f.write("\n")
    f.close()
    
def leggi_file(elenco1):
    trovato=False
    try:
        with open("Rubrica.txt", 'r+') as f:
            stringa=f.readlines()
            for riga in stringa:
                riga=riga.strip()
                elenco1.append(eval(riga))
                trovato=True
        f.close()
    except:
        print("Il file Rubrica.txt non esiste")
    return trovato


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
                    stampa_rub(elenco)
                    mod_num(elenco)
                else:
                    print("Errore! Devi inserire prima almeno un numero di telefono")
            case 3:
                if ins==True:
                    ordina_rub(elenco)
                else:
                    print("Errore! Devi inserire prima almeno un numero di telefono")
            case 4:
                if ins==True:
                    elimina_rub(elenco)
                    print("Eliminazione riuscita!")
                else:
                    print("Errore! Devi inserire prima almeno un numero di telefono")
            case 5:
                if ins==True:
                    scrivi_file(elenco)
                    print("File creato nella directory standard (dove sta andando Python)")
                else:
                    print("Errore! Devi inserire prima almeno un numero di telefono")
            case 6:
                    elenco1=[]
                    trovato=leggi_file(elenco1)
                    if(trovato==True):
                        ins=True
                    elenco=elenco1
                    print(elenco)
            case 7:
                print("Arrivederci!")
                break
                    
        input("premi invio per continure...")
        os.system("cls")
main()