from Classe_treno import *
from input_dati import *
import os

stringa_menu ="""
********************************************************************
*                           Treno                                *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) Crea oggetto Treno                            
*  2) Salgono persone                               
*  3) Scendono persone
*  4) Stampa dati Treno
*  5) Fine                                                                   
********************************************************************
"""

def menu():
    while True:
        print(stringa_menu)
        s = input_range("Scelta operazione: ",int,1,5)
        if s in range(1,6):
            break
        else:
            print(" scelta errata!!",s)
    return s

def main():
    ins=False
    while True:
        s=menu()
        match s:
            case 1:
                ins=True
                treno = Treno (input_gen("Quanti vagoni ci sono? ",int))
                p=input_gen("Quanti passeggeri ci possono essere per vagone? ",int)
                treno.set_passeggerimax(p*treno.get_vagoni())
                print("Passeggeri tot: ",treno.get_passeggerimax())
                
            case 2:
                if ins==True:
                    su=(input_gen("Quanti passeggeri stanno salendo? ",int))
                    if su+treno.get_passeggeri() < treno.get_passeggerimax():
                        treno.salgono_passeggeri(su)
                        print("Al momento ci sono ", treno.get_passeggeri(), "passeggeri")
                    else:
                        print("Troppi Passeggeri, sono saliti solo ",treno.get_passeggerimax()-treno.get_passeggeri(),"passeggeri \n Al momento ci sono ",treno.get_passeggerimax()," passeggeri")
                        treno.set_passeggeri(treno.get_passeggerimax())
                else:
                    print("Crea prima il treno")
            case 3:
                if ins==True:
                    giu=(input_gen("Quanti passeggeri stanno scendendo? ",int))
                    if treno.get_passeggeri()-giu > 0:
                        treno.scendono_passeggeri(giu)
                        print("Al momento ci sono ", treno.get_passeggeri(), "passeggeri")
                    else:
                        print("Troppo pochi passeggeri, sono scesi solo ",giu-treno.get_passeggeri(),"passeggeri \n Al momento ci sono ",0," passeggeri")
                        treno.set_passeggeri(0)
                else:
                    print("Crea prima il treno")
            case 4:
                if ins==True:
                    print(treno,"\nMedia Passeggeri per vagone: ", treno.get_passeggeri()/treno.get_vagoni())
                else:
                    print("Crea prima il treno")
            case 5: 
                print("Ciao")
                
                
                
        input("premi invio per continure...")
        os.system("cls")
        
main()