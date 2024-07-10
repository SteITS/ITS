from Classe_TV import *
from input_dati import *
import os

stringa_menu ="""
********************************************************************
*                           Telecomando                            *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) TV ON/OFF                                   
*  2) Imposta canale                                   
*  3) Canale SU                           
*  4) Canale GIU                        
*  5) Volume SU                          
*  6) Volume GIU     
*  7) Mute ON/OFF
*  8) Stampa TV
*  9) Spegni                                         
********************************************************************
"""


def menu():
    while True:
        print(stringa_menu)
        s = input_range("Scelta operazione: ",int,1,9)
        if s in range(1,10):
            break
        else:
            print(" scelta errata!!",s)
    return s



def main():
    telecomando=TV(False,0,0,False)
    while True:
        s=menu()
        match s:
            case 1:
                telecomando.Pulsante_Accensione()
                print("TV: ",telecomando.get_acceso())
            case 2:
                if telecomando.get_acceso()==True:
                    c=input_range("Inserisci un canale a 0 a 99: ",int,0,99)
                    telecomando.Imposta_Canale(c)
                    print("Canale: ",telecomando.get_canale())
                else:
                    print("La TV è spenta")
            case 3:
                if telecomando.get_acceso()==True:
                    telecomando.Canale_Successivo()
                    print("Canale: ",telecomando.get_canale())
                else:
                    print("La TV è spenta")
            case 4:
                if telecomando.get_acceso()==True:
                    telecomando.Canale_Precedente()
                    print("Canale: ",telecomando.get_canale())
                else:
                    print("La TV è spenta")
            case 5:
                if telecomando.get_acceso()==True:
                    telecomando.Aumenta_Volume()
                    print("Volume: ",telecomando.get_volume())
                else:
                    print("La TV è spenta")
            case 6:
                if telecomando.get_acceso()==True:
                    telecomando.Abbassa_Volume()
                    print("Volume: ",telecomando.get_volume())
                else:
                    print("La TV è spenta")
            case 7:
                if telecomando.get_acceso()==True:
                    telecomando.Pulsante_Silenzioso()
                    print("Muto: ",telecomando.get_silenzioso())
                else:
                    print("La TV è spenta")
            case 8:
                print(telecomando)
            case 9:
                print("arrivederci")
                break
                          
        input("premi invio per continure...")
        os.system("cls")
    
main()