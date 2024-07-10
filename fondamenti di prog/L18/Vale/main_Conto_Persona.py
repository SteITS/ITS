from Persona import Persona
from Conto import ContoCorrente
from Libreria import *
import os

from sys import path
curr_dir = os.getcwd()   #prende la directory corrente
#print(curr_dir)
#path.append('..\\')                    # aggiunge al path di sistema la cartella superiore
#path.append("c:\\windows\\system32")  # aggiunge una cartella al path
#path.append(curr_dir)  # aggiunge la cartella al path
#print(path)


def menu():
    while True:
        stmenu = '''
        1) Crea Conto per persone
        2) Prelievo dal conto N.
        3) versamento al conto N.
        4) Bonifico
        5) Stampa elenco conti di una persona
        6) Stampa elenco conti in ordine di numero di conto
        7) Stampa  elenco conti in ordine di saldo       
        8) Fine
        '''        
        print(stmenu)
        sc=input("Scelta operazione: ")
        if sc=='1' or sc=='2' or sc=='3' or sc=='4' or sc=='5' or sc=='6' or sc=='7' or sc=='8' :
            break
        else:
            print(" Scelta errata ", sc)
        input("premi invio per continuare......")
        os.system("cls")
    return sc

def input_dati():
    np=input_gen("Quanti proprietari ci sono? ",int)
    proprietari=[]
    for i in range(int(np)):
        print("inserisci dati del proprietario ",i+1)
        nome=""
        cognome=""
        nome = input_gen("Inserisci il nome : ",str)        
        cognome = input_gen("Inserisci il cognome : ",str)        
        proprietari.append([nome,cognome])
    saldo = input_maggiore("Inserisci il saldo del conto: ",float,0)
    return proprietari,saldo
    
def creaContoPersone(elenco,proprietari,saldo):
    conto =  ContoCorrente(saldo)
    for p in proprietari:
        nome=p[0]
        cognome=p[1]
        #print(p,nome,cognome)
        p = Persona(nome,cognome)
        #print(p.getNome(),p.getCognome())
        conto.setProprietari(p)
    elenco.append(conto)    
   # persone_oggetti.append(oggetto)
    return elenco

def stampaElencoConti(elenco):
    for c in elenco:
        print("Proprietari: ")
        for p in c.getProprietari():
            print(p)
        print(c)            
        print("------------")

def stampaElencoContiProp(elenco,nome,cognome):
    for c in elenco:
        #print(c)
        print("\nProprietario: ",nome,cognome)
        for p in c.getProprietari():
            no=p.getNome()
            co=p.getCognome()
            if no==nome and co==cognome:
                print(c)            
                print("------------")
    print("** fine elenco **")     
def bonifico(elenco,nc1,nc2,valore):
    """
    ritorna 0 se il bonifico viene effettuato; ritorna -1 se il conto 1 non esiste; ritorna -2 se il conto 2 non esiste
    ritorna -3 se non è stato possibile fare il prelievo dal conto 1; ritorna -4 se non è stato possibile fare il versamento
    sul conto 2
    """
    trovato =False
    for c in elenco:
        if c.getNumconto()==nc1:
            #pre=c.prelievo(valore)
            conto1=c
            trovato=True
            break
    if trovato==True :  # se è stato 
        trovato2=False
        for c in elenco:
            if c.getNumconto()==nc2:
                conto2=c
                #vers=c.versamento(valore)
                trovato2=True
                break 
        if trovato2==True:
            pre=conto1.prelievo(valore)
            if pre==0:
                vers=conto2.versamento(valore)
                if vers==0:
                    return 0  # bonifico  effettuato
                else:
                    #se non viene fatto il versmaneto sul conto2, si deve annullare anche il prelievo dal conto1
                    conto1.versamento(valore)
                    return -4 # bonifico annullato. non è stato possibile fare il versamento sul conto2
            else:
                return -3  # non è stato possibile fare il prelievo
        else:
            return -2  
    else:
        return -1  

def versamento(elenco,nconto,v):
    trovato=False
    for c in  elenco:
        if c.getNumconto()==nconto:
            res=c.versamento(v)
            trovato =True            
            if res==0:  #versamento effettuato
                return 0
            else:
                return -1 #versamento non effettuato
    if trovato==False:
        return -2	#conto non trovato

def prelievo(elenco,nconto,v):
    trovato=False
    for c in  elenco:
        if c.getNumconto()==nconto:
            res=c.prelievo(v)
            trovato =True
            if res==0:  #versamento effettuato
                return 0
            else:
                return -1 #versamento non effettuato
    print(trovato)            
    if trovato==False:
        return -2	#conto non trovato



def main():
    elenco:list[ContoCorrente] = []  #elenco di oggetti Conti con associati persone
#    persona=None
#    conto=None
    loop = True
    while loop:
        os.system("cls")        
        scelta = menu()
        match scelta:
            case '1':
                print("input dati per creare conto per delle persone")
                proprietari,saldo=input_dati()
                elenco=creaContoPersone(elenco,proprietari,saldo)
                #elenco=associaContoPersona(elenco,persona,conto)
                #persona=creaOggettoPersona()
                print("creato conto per  ",proprietari ) 

 
            case '2':
                if len(elenco)>0:
                    print("Prelievo dal conto")                 
                    nconto=input_maggiore("inserisci il numero del conto: ",int,0)
                    v=input_maggiore("inserisci il valore da prelevare: ",float,0)
                    ris=prelievo(elenco,nconto,v)
                    if ris==0:
                        print ("Prelievo di ",v, "euro effettuato dal conto N. ",nconto)
                    elif ris==-1:
                        print ("prelievo non effettuato")
                    elif ris==-2:
                        print("Conto non esiste!")
                else:
                    print("non ci sono conti correnti")
            case '3':
                if len(elenco)>0:
                
                    print("Versamento su conto")
                    nconto=input_maggiore("inserisci il numero del conto: ",int,0)
                    v=input_maggiore("inserisci il valore del versamento: ",float,0)
                    ris=versamento(elenco,nconto,v)
                    if ris==0:
                        print ("versamento di ",v, "euro effettuato sul conto N. ",nconto)
                    elif ris==-1:
                        print ("Versamento non effettuato")
                    elif ris==-2:
                        print("Conto non esiste!")
                else:
                    print("non ci sono conti correnti")                    
            case  '4':
                if len(elenco)>0:                
                    print("Bonifico ")                   
                    conto1 = input_maggiore("da quale conto si vuole prelevare? inserisci il numero del conto:  ",int,0)
                    valore = input_maggiore("Quanto si vuole prelevare? ",float,0)
                    conto2 = input_maggiore("inserisci il numero del conto del destinatario:  ",int,0)
                    ris=bonifico(elenco,conto1,conto2,valore)
                    if ris==0:
                        print("Bonifio effettuato ")
                    elif ris==-1:
                        print("Conto n.  ",conto1, "non esiste! Bonifico Annullato")
                    elif ris==-2:
                        print("Conto n.  ",conto2, "non esiste! Bonifico Annullato")
                else:
                    print("non ci sono conti correnti")
            case '5':
                if len(elenco)>0:
                    print("Stampa elenco conti di una persona")
                    nome=input_gen("Inserisci il nome della persona: ",str)
                    cognome=input_gen("Inserisci il cognome della persona: ",str)
                    stampaElencoContiProp(elenco,nome,cognome)

                else:
                    print("non ci sono conti correnti")                

            case '6':
                if len(elenco)>0:
                    print("Stampa elenco conti correnti in ordine di Numero conto")
                    print("Stampa elenco Conti correnti in ordine crecente di numero del conto")
                    elenco.sort(key=lambda x: x.getNumconto())
                    stampaElencoConti(elenco)
                else:
                    print("non ci sono conti correnti")
            case '7':
                if len(elenco)>0:
                    print("Stampa elenco conti correnti in ordine di saldo")
                    print("Stampa elenco Conti correnti in ordine crescente di saldo")
                    elenco.sort(key=lambda x: x.getSaldo())
                    stampaElencoConti(elenco)
                else:
                    print("non ci sono conti correnti")         
            case '8':
                loop = False
        input("Premi invio per continuare..")

if __name__=="__main__":
    main()