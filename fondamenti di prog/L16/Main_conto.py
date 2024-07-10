from ContoCorrente import ContoCorrente
from Persona import Persona
from input_dati import *
import os
from sys import path

cur_dir=os.getcwd()
#print(cur_dir)
#print(path)
path.append(cur_dir)
print(path)

stringa_menu ="""
********************************************************************
*                           Treno                                *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) Crea oggetto Persona                            
*  2) Crea oggetto Conto Corrente                               
*  3) Associa Conto Persona
*  4) Prelievo dal conto N
*  5) Versamento al conto N
*  6) Bonifico
*  7) Stampa elenco conti associati in ordine crescente di numero conto
*  8) Stampa elenco conti in ordine crescente di saldo    
*  9) Fine                                           
********************************************************************
"""

def menu():
    while True:
        print(stringa_menu)
        s = input("Scelta operazione: ")
        if int(s) in range(1,11) and s.isdigit():
            break
        else:
            print(" scelta errata!!",s)
        input("premi invio per continure...")
        os.system("cls")
    return int(s)
    
def creaOggettoPersona():
    nome=input_gen("Inserisci nome della persona: ",str)
    cognome=input_gen("Inserisci cognome della persona: ",str)
    persona=Persona(nome,cognome)
    return persona

def creaOggettoConto():
    saldo=input_maggiore("Inserisci il saldo: ",int,0)
    conto=ContoCorrente(saldo)
    return conto

def associaContoPersona(persona,conto,elenco):
    persona.set_conto(conto)
    conto.set_proprietario(persona)
    elenco.append(conto)
    
def stampaElencoConti(elenco):
    for c in elenco:
        print(c.get_proprietario())
        print(c)

def prelievo(elenco,nconto,valore):
    for c in elenco:
        if c.get_numconto()==nconto:
            st=c.prelievo(valore)
    return st

def versamento(elenco,nconto,valore):
    for c in elenco:
        if c.get_numconto()==nconto:
            st=c.versamento(valore)
    return st

def bonifico(elenco,nconto1,nconto2,valore):
    trovato = False
    for c in elenco:
        if c.get_numconto() == nconto1:
            conto1=c
            trovato = True
    if trovato == True:
        trovato2 = False
        for c in elenco:
            if c.get_numconto() == nconto2:
                conto2 = c
                st1=conto1.prelievo(valore)
                st2=conto2.versamento(valore)
                trovato2 = True
            if trovato2 == False:
                s = "conto 2 non trovato"
            else:
                s="bonifico effettuato!"
    else:
        s="Conto 1 non trovato"
    
    return s,st1,st2
        
def main():
    elenco=[]
    loop=True
    while loop:
        scelta=menu()
        match scelta:
            case 1:
                print("Crea oggetto persona\n")
                persona=creaOggettoPersona()
                print("Oggetto persona creato")
            case 2:
                print("Crea oggetto Conto Corrente")
                conto=creaOggettoConto()
                print("oggetto Conto creato",conto)
            case 3:
                print("Associa Conto Persona")
                if(persona==None):
                    print("Oggetto persona non esiste")
                elif conto==None:
                    print("Oggetto conto non esiste")
                else:
                    if conto not in elenco:
                        associaContoPersona(persona,conto,elenco)
                        print("\nAssociati oggetti ",persona," conto ",conto)
                    else:
                        print("Conto già associato")
                        
            case 4:
                print("Prelievo dal conto N")
                if(len(elenco)>0):
                    nconto=input_range("Inserisci il num del conto da cui prelevare",int,0,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi prelevare",int,0)
                    ris=prelievo(elenco,nconto,valore)
                    print(ris)
                    
            case 5:
                print("Versamento al conto N")
                if(len(elenco)>0):
                    nconto=input_range("Inserisci il num del conto da versare",int,0,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi versare",int,0)
                    ris=versamento(elenco,nconto,valore)
                    print(ris)
            case 6:
                print("Bonifico")
                if(len(elenco)>1):
                    nconto1=input_range("Inserisci il num del conto da cui prelevare",int,0,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi prelevare",int,0)
                    nconto2=input_range("Inserisci il num del conto da cui prelevare",int,0,len(elenco))
                    
            case 7:
                print("Stampa elenco conti associati in ordine crescente di numero conto")
                elenco.sort(key=lambda x:x.get_numconto())
                stampaElencoConti(elenco)
            case 8:
                print("Stampa elenco conti in ordine crescente di saldo")
                elenco.sort(key=lambda x:x.get_saldo())
                stampaElencoConti(elenco)
            case 9:
                print("Adios")
                loop=False
        input("premi invio per continure...")
        os.system("cls")
        
main()