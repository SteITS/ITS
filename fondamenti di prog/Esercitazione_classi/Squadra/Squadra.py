from Classe_Squadra import *
from input_dati import *
import os

stringa_menu ="""
********************************************************************
*                           Gestione Squadre                           *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) Inserisci dati                                   
*  2) Stampa punteggio
*  3) Stampa chi ha fatto più gol                                   
*  4) Stampa chi ha subito più gol                        
*  5) Resetta a 0                       
*  6) Esci                                                                   
********************************************************************
"""

def menu():
    while True:
        print(stringa_menu)
        s = input_range("Scelta operazione: ",int,1,6)
        if s in range(1,7):
            break
        else:
            print(" scelta errata!!",s)
    return s

def input_dati():
    while True:
        p=[]
        vittorie=input_gen("Vittorie: ",int)
        sconfitte=input_gen("Sconfitte: ",int)
        pareggi=input_gen("Pareggi: ",int)
        gol_effetuati=input_gen("Gol effettuati: ",int)
        gol_subiti=input_gen("Gol subiti: ",int)
        p.append(vittorie)
        p.append(sconfitte)
        p.append(pareggi)
        p.append(gol_effetuati)
        p.append(gol_subiti)
        return p

def main():
    while True:
        s=menu()
        match s:
            case 1:
                print("Juventus:")
                p=input_dati()
                juventus=Squadra(p[0],p[1],p[2],p[3],p[4])
                print("Milan:")
                p=input_dati()
                milan=Squadra(p[0],p[1],p[2],p[3],p[4])
                print("Inserimento riuscito")
            case 2:
                print("Juventus: ",juventus.punti(),"\n","Milan: ",milan.punti())
            case 3:
                if(juventus.get_GF()>milan.get_GF()):
                    print("La Juventus ha fatto più gol", juventus.get_GF() )
                else:
                    print("La Milan ha fatto più gol", milan.get_GF() )
            case 4:
                if(juventus.get_GS()>milan.get_GS()):
                    print("La Juventus ha subito più gol", juventus.get_GS() )
                else:
                    print("La Milan ha subito più gol", milan.get_GS() )
            case 5:
                juventus.inizioanno()
                milan.inizioanno()
                print("Anno nuovo! Punteggi resettati")
            case 6:
                print("Adios")
                break
                
                    
                
        input("premi invio per continure...")
        os.system("cls")
main()