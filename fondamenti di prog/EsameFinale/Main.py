from Veicolo import Veicolo
from Autovettura import AutoVettura
from Furgone import Furgone
from GestioneVeicoli import GestioneVeicoli
import os
from input_dati import *
GV=GestioneVeicoli()

def menu():
    stringa_menu="""
        --------------------------------
        ******** GESTIONE VEICOLI ******
        
          1. Inserisci veicolo
          2. Cancella Veicolo per targa
          3. Cerca veicolo per targa
          4. Stampa elenco dei veicoli in ordine crescente di targa
          5. Stampa numero totale dei veicoli
          6. Stampa costo totale dei veicoli
          7. Fine
        ---------------------------------
    """
    while True:
        print(stringa_menu)
        sc = input("Scelta operazione: ")
        if (sc =='7' or sc =='1' or sc =='2' or sc =='3' or sc =='4' or sc =='5' or sc =='6'):
            break
        else:
            print(" scelta errata!!",sc)
        input("premi invio....")
        os.system("cls")
    return sc


def Tipo():
    t=input_range("Che tipo di veicolo è? 1.Autovettura 2.Furgone",int,1,2)
    Input_dati(t)

def Input_dati(t):
    match t:
        case 1:
            marca=input_gen("Inserisci marca veicolo: ",str)
            targa=input_gen("Inserisci Targa Veicolo: ",str)
            costo=input_gen("Inserisci Costo Veicolo: ",float)
            posti=input_gen("Inserisci Posti Veicolo: ",int)
            oggetto=AutoVettura(marca,targa,costo,posti)
            GV.aggiungi_veicolo(oggetto)
        case 2:
            marca=input_gen("Inserisci marca veicolo: ",str)
            targa=input_gen("Inserisci Targa Veicolo: ",str)
            costo=input_gen("Inserisci Costo Veicolo: ",float)
            capacita=input_gen("Inserisci Capacita Veicolo: ",int)
            oggetto=AutoVettura(marca,targa,costo,capacita)
            GV.aggiungi_veicolo(oggetto)
            
def main():  
    flag=False
    while True:
        s=menu()
        match s:
            case '1':
                print("Inserimento Veicolo")
                Tipo()
                flag=True
            case '2':
                if flag == True:
                    targa=input_gen("Inserisci Targa Veicolo da eliminare: ",str)
                    f=GV.cancella_veicolo(targa)
                    print("Veicolo cancellato? "+str(f))
                else:
                    print("Devi prima inserire un veicolo")
            case '3':
                if flag == True:
                    targa=input_gen("Inserisci Targa Veicolo da cercare: ",str)
                    f,i=GV.cerca_veicolo(targa)
                    if i!=-1:
                        print("Veicolo trovato in pos: "+str(i))
                    else:
                        print("Veicolo non presente")
                else:
                    print("Devi prima inserire un veicolo")
                    
            case '4':
                if flag == True:
                    GV.ordina_veicoli("targa")
                    GV.stampa_veicoli()
                else:
                    print("Devi prima inserire un veicolo")
            case '5':
                if flag == True:
                    n=GV.totale_veicoli()
                    print("N di veicoli: "+str(n))
                else:
                    print("Devi prima inserire un veicolo")
            case '6':
                if flag == True:
                    n=GV.costo_totale()
                    print("Costo totale dei veicoli: "+str(n))
                else:
                    print("Devi prima inserire un veicolo")
            case '7':
                print("Uscita dal programma...")
                break
        input("premi invio per continuare.....")
        os.system("cls") 
main()


                