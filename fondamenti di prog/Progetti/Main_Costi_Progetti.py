import os
from GestioneProgetti import GestioneProgetti
from Dirigente import Dirigente
from FunzionarioSenior import FunzionarioSenior
from FunzionarioJunior import FunzionarioJunior
from TecnicoEleAut import TecnicoEleAut
from TecnicoInFTel import TecnicoInfTel
from datetime import date
from Libreria import *

def menu():
    stringa_menu="""
        -------------------------
        ******** GESTIONE COSTI DEI PROGETTI ******
        
          1. Inserisci partecipente al progetto
          2. Elimina partecipante al progetto
          3. Ricerca partecipante al progetto
          4. Stampa Elenco partecipanti al progetto
          5. Totale costi complessivi progetto
          6. Totale partecipanti al progetto
          
          0. Uscita
    """
    while True:
        print(stringa_menu)
        sc = input("Scelta operazione: ")
        if (sc =='0' or sc =='1' or sc =='2' or sc =='3' or sc =='4' or sc =='5' or sc =='6'):
            break
        else:
            print(" scelta errata!!",sc)
        input("premi invio....")
        os.system("cls")
    return sc

def input_partecipante(GP):
    ins=False
    tipo=input_range("inserisci partecipante: \n 1)Dirigente 2)Funz Senior 3)Funz Junior 4)Tec Inf 5)Tec Elet \n Scegli: ",int,1,5)
    p=input_dati(tipo)
    if (p!=None):
        GP.aggiungiPersona(p)
        ins=True 
    return ins
        
def input_dati(tipo):
    p=None
    nome=input_gen("inserisci nome: ",str)
    cognome=input_gen("inserisci cognome: ",str)    
    matri=input_gen("inserisci matricola: ",str) 
    anno=input_maggiore("inserisci anno assunzione: ",int,1900)
    ore=input_maggiore("inserisci ore lavorate: ",int)
    match tipo:
        case 1:
            p=Dirigente(nome,cognome,matri,anno,ore)
        case 2:
            p=FunzionarioSenior(nome,cognome,matri,anno,ore)            
        case 3:
            p=FunzionarioJunior(nome,cognome,matri,anno,ore)             
        case 4:
            interno=input_range("Il tecnico è interno o esterno? 1)Interno 0)Esterno :",int,0,1)
            p=TecnicoInfTel(nome,cognome,matri,anno,ore,interno)             
        case 5:
            interno=input_range("Il tecnico è interno o esterno? 1)Interno 0)Esterno :",int,0,1)
            p=TecnicoInfTel(nome,cognome,matri,anno,ore,interno)             
    return p
'''
def input_Persone(GP):
    dirig1=Dirigente("Mario","Bianchi","123",2010,200)
    FunzS1=FunzionarioSenior("Paolo","Rossi","221",2012, 100)
    FunzJ1=FunzionarioJunior("Marco","Verde","222", 2013, 92)
    TecI2=TecnicoInfTel("Davide","corti","301",2010,35,False)        
    TecE1=TecnicoEleAut("Giorgio","Marek","401",2008,28,True)
    GP.aggiungiPersona(TecE1)
    GP.aggiungiPersona(TecI2);
    GP.aggiungiPersona(dirig1);
    GP.aggiungiPersona(FunzS1);
    GP.aggiungiPersona(FunzJ1);
    return True
'''
def main():
    ANNO=date.today().year    
    GP=GestioneProgetti()
    while True:
        s=menu()
        match s:
            case '1':
                print("** Inserisci partecipente al progetto **")
                ins=input_partecipante(GP)
                #ins=input_Persone(GP)                
                if (ins==True ):
                    print("inserimento ok!!")
                else:
                    print("inserimento NON ok!!")
            case '2':
                if GP.getTotalePersone()>0:                
                    print("** Elimina partecipante al progetto **")
                    dip=input_gen("Inserisci il cognome da eliminare: ",str)
                    elem=GP.eliminaPersona(dip)
                    if elem==True:
                        print("eliminato partecipante: ",dip)
                    else:
                        print("partecipante non trovato")
                else:
                    print("non ci sono partecipanti! ")

            case '3':
                if GP.getTotalePersone()>0: 
                    print("** Ricerca partecipante al progetto **")
                    dip=input_gen("Inserisci il cognome del partecipante: ",str)                
                    trovato,elem = GP.cercaPersona(dip)
                    if trovato==True:
                        print("la persona  ",dip," è nell'elenco del progetto")
                    else:
                        print("la persona ",dip," non lavora al progetto")
                else:
                    print("non ci sono partecipanti! ")

            case '4':
                if GP.getTotalePersone()>0: 
                    print("** Stampa Elenco partecipanti al progetto **")               
                    print(GP.elencoPersone()+"Totali Persone: ",GP.getTotalePersone())
                else:
                    print("non ci sono partecipanti! ")               
            case '5':
                if GP.getTotalePersone()>0: 
                    print("** Totale costi complessivi progetto **")               
                    print(GP.Costiprogetto(ANNO) )
                else:
                    print("non ci sono partecipanti! ")
            case '6':
                if GP.getTotalePersone()>0: 
                    print("** Totale prtecipanti al progetto **")               
                    print("Persone totali: ",GP.getTotalePersone() )
                else:
                    print("non ci sono partecipanti! ")                    
            case '0':
                print("fine programma")
                break

        input("premi invio per continuare.....")
        os.system("cls")        

    
main()