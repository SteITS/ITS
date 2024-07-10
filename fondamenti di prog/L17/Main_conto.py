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
*                           Conto Corrente                         *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) Crea oggetto Persona                            
*  2) Prelievo dal conto N.                             
*  3) Versamento al conto N.
*  4) Bonifico
*  5) Stampa elenco conti di una persona
*  6) Stampa elenco conti associati in ordine crescente di numero conto
*  7) Stampa elenco conti in ordine crescente di saldo    
*  8) Fine                                           
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
    
def creaOggettoPersona(elenco):
    conto=creaOggettoConto()
    v=input_gen("Quanti proprietari ci sono per questo conto?",int)
    for i in range(v):
        nome=input_gen("Inserisci nome della persona: ",str)
        cognome=input_gen("Inserisci cognome della persona: ",str)
        persona=Persona(nome,cognome)
        associaContoPersona(persona,conto,elenco)
    return conto

def creaOggettoConto():
    saldo=input_maggiore("Inserisci il saldo: ",int,0)
    conto=ContoCorrente(saldo)
    return conto

def associaContoPersona(persona,conto,elenco):
    conto.set_proprietario(persona)
    
def stampaElencoConti(elenco,conto):
    for c in elenco:
        print(c)
        '''for i in (conto.get_proprietario()):
            print(i)'''

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
                s =-2 #"conto 2 non trovato"
            else:
                s=0 #"bonifico effettuato!"
    else:
        s=-1 #"Conto 1 non trovato"
    
    return s,st1,st2
        
def stampaPersona(n,c,elenco):
    for i in elenco:
        for j in i.get_proprietario():
            if j.get_nome() == n and j.get_cognome() == c:
                print(i)
                trovato=True
    if trovato == False:
        print("Conto non trovato")
        
def main():
    elenco=[]
    loop=True
    while loop:
        scelta=menu()
        match scelta:
            case 1:
                print("Crea oggetto persona\n")
                conto=creaOggettoPersona(elenco)
                elenco.append(conto)
                print("Oggetto persona creato")
            case 2:
                print("Prelievo dal conto N")
                if(len(elenco)>0):
                    nconto=input_range("Inserisci il num del conto da cui prelevare",int,0,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi prelevare",int,0)
                    ris=prelievo(elenco,nconto,valore)
                    print(ris)
            
            case 3:
                print("Versamento al conto N")
                if(len(elenco)>0):
                    nconto=input_range("Inserisci il num del conto da versare",int,0,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi versare",int,0)
                    ris=versamento(elenco,nconto,valore)
                    print(ris)
            case 4:
                print("Bonifico")
                if(len(elenco)>1):
                    nconto1=input_range("Inserisci il num del conto da cui prelevare",int,0,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi prelevare",int,0)
                    nconto2=input_range("Inserisci il num del conto al quale vuoi versare",int,0,len(elenco))
                    ris=bonifico(elenco,nconto1,nconto2,valore)
            case 5:
                    print("Stampa elenco conti di una persona")
                    trovato=False
                    n=input_gen("Inserisci nome della persona: ",str)
                    c=input_gen("Inserisci cognome della persona: ",str)
                    stampaPersona(n,c,elenco)
            case 6:
                print("Stampa elenco conti associati in ordine crescente di numero conto")
                elenco.sort(key=lambda x:x.get_numconto())
                stampaElencoConti(elenco,conto)
            case 7:
                print("Stampa elenco conti in ordine crescente di saldo")
                elenco.sort(key=lambda x:x.get_saldo())
                stampaElencoConti(elenco,conto)
            case 8:
                print("Adios")
                loop=False
        input("premi invio per continuare...")
        os.system("cls")
        
main()