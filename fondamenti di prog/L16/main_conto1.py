from ContoCorrente import ContoCorrente
from Persona import Persona
from input_dati import *
import os
from sys import path

cur_dir=os.getcwd()
#print(cur_dir)
#print(path)
path.append(cur_dir)
#print(path)
def menu():
    stringa_menu ="""
    ********************************************************************
    *                GESIONE conto corrente                        *
    ********************************************************************
    ********************************************************************
    *                    Menu utente principale                        *
    ********************************************************************
            1) Crea persona
            2) Crea Conto
            3) Associa Conto Persona
            4) Prelievo dal conto N.
            5) Versamento al conto N.
            6) Bonifico
            7) Stampa elenco conti associati in ordine crescente di numero conto
            8) Stampa elenco conti in ordine crescente di saldo
            9) Fine                                             *
    ********************************************************************
    """    
    while True:
        print(stringa_menu)
        sc = input("Scelta operazione: ")
        if sc.isdigit() and int(sc) in range(1,10) :# sc in[1,2,3,4,5,6,7,8,9]
            break
        else:
            print(" scelta errata!!",sc)
        '''
        if sc=='1' or sc =='2' or sc =='3' or sc =='4'or sc =='5' or sc =='6'or sc =='7' or sc =='8':
            break
        else:
            print(" scelta errata!!",sc)
        '''
        input("premi invio....")
        os.system("cls")
    return sc

def CreaOggettoPersona():
    nome=input_gen("inserisci nome della persona: ",str)
    cognome=input_gen("inserisci cognome della persona: ",str)
    persona=Persona(nome,cognome)
    return persona
def CreaOggettoConto():
    saldo=input_range("inserisci il saldo: ",int,0,1000)
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
    trovato=False
    for c in elenco:
        if c.get_numconto()==nconto1:
            conto1=c
            trovato=True
    if trovato==True:
        trovato2=False
        for c in elenco:
            if c.get_numconto()==nconto2:
                conto2=c
                st1=conto1.prelievo(valore)
                st2=conto2.versamento(valore)
                trovato2=True
        if trovato2==False:
            s="conto 2 non trovato"
        else:
            s="bonifico effettuato!!"
    else:
         s="conto1 non trovato"
    return s,st1,st2
                
                
        
def main():
    elenco=[]
    conto=None
    persona=None
    loop =True
    while loop:
        scelta=menu()
        match scelta:
            case '1':
                os.system("cls")
                print("Crea oggetto persona\n")
                persona=CreaOggettoPersona()
                print("Oggetto persona creato",persona)
            case '2':
                 print("Crea oggetto conto corrente")
                 conto=CreaOggettoConto()
                 print("oggetto Conto creato",conto)
            case '3':
                print("Associa Conto Persona")
                if(persona==None):
                    print("oggetto persona non esiste")
                elif (conto==None):
                    print("oggetto conto non esiste")
                else:
                    if conto not in elenco:
                        associaContoPersona(persona,conto,elenco)
                        print("\nAssociati oggetti ",persona," conto ",conto)
                    else:
                        print("conto già associato")
            case '4':
                if(len(elenco)>0):
                    print("Prelievo dal conto N.")
                    nconto=input_range("Inserisci il numero del conto da cui prelevare: ",int,1,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi prelevare: ",int,0)
                    st,st1,st2=prelievo(elenco,nconto,valore)
                    print(st+"\n")
                    
            case '5':
                if(len(elenco)>0):
                    print("Versamento al conto N.")
                    nconto=input_range("Inserisci il numero del conto su cui versare: ",int,1,len(elenco))
                    valore=input_maggiore("Inserisci quanto vuoi versare: ",int,0)
                    ris=versamento(elenco,nconto,valore)
                    print(ris)
                    
            case '6':
                if(len(elenco)>1):                
                    print("Bonifico")
                    nconto1=input_range("Inserisci il numero del conto da cui prelevare: ",int,1,len(elenco))
                    valore=input_maggiore("Inserisci il valore del bonifico: ",int,0)                    
                    nconto2=input_range("Inserisci il numero del conto su cui versare: ",int,1,len(elenco))
                    ris=bonifico(elenco,nconto1,nconto2,valore)
                    print(ris)                    
                    
            case '7':
                print("Stampa elenco conti associati in ordine crescente di numero conto")
                elenco.sort(key=lambda x:x.get_numconto())
                stampaElencoConti(elenco)
            case '8':
                print("Stampa elenco conti in ordine crescente di saldo")
                elenco.sort(key=lambda x:x.get_saldo())
                stampaElencoConti(elenco)

            case '9':
                loop=False
        input("premi invio per continuare.... ")
        os.system("cls")
    

main()
