from Classe_lampadina import *
from input_dati import *
import os

stringa_menu ="""
********************************************************************
*                           Lampadina                                *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) Crea nuova lampadina                               
*  2) Lampadina ON/OFF                               
*  3) Esci dal programma                                                                   
********************************************************************
"""
def main():
    while True:
        print(stringa_menu)
        s=input_range("Scegli operazione: ",int,1,3)
        match s:
            case 1:
                clicks=input_gen("Inserisci la durata della lampadina: ",int)
                nome=lampadina(False,clicks)
                print("Lampadina creata!")
            case 2:
                if nome!=False:
                    if nome.get_clicks()>0:
                        nome.Pulsante_Accensione()
                        nome.Num_Accensione()
                        print("Stato lampadina:",nome.get_acceso(),",numero di click al malfunzionamento: ",nome.get_clicks())
                    else:
                        print("Crack! La lampadina si è rotta, creane un'altra")
                        nome=False
                else:
                    print("La lampadina non esiste")
            case 3:
                print("Programma chiuso. Lampadine cancellate!")
                break
            
            
        input("premi invio per continure...")
        os.system("cls")
main()