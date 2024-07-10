from GestioneProgetti import GestioneProgetti
from Dirigente import Dirigente
from TecnicoEleAut import TecnicoEleAut
from TecnicoInfTel import TecnicoInfTel
from FunzionarioJunior import FunzionarioJunior
from FunzionarioSenior import FunzionarioSenior
import os
from input_dati import *

stringa_menu = """
********************************************************************
*                           Gestione Progetto                      *
********************************************************************
********************************************************************
*                                                                  *
********************************************************************
*  1) Aggiungi persona al progetto                           
*  2) Elimina persona dal progetto                            
*  3) Cerca persona nel progetto
*  4) Visualizza elenco persone nel progetto
*  5) Costo totale del progetto
*  6) N di persone partecipanti  
*  7) Fine                                           
********************************************************************
"""


def menu():
    while True:
        print(stringa_menu)
        s = input("Scelta operazione: ")
        if int(s) in range(1, 8) and s.isdigit():
            break
        else:
            print(" scelta errata!!", s)
        input("premi invio per continure...")
        os.system("cls")
    return int(s)


def main():
    elenco = GestioneProgetti()
    loop = True
    while loop:
        scelta = menu()
        match scelta:
            case 1:
                p = input_gen("Dirigente,TecnicoEleAut,TecninoInfTel,FunzionarioJunior,FunzionarioSenior ", str)
                nome = input_gen("Inserisci nome: ", str)
                cognome = input_gen("Inserisci cognome: ", str)
                matricola = input_gen("Inserisci matricola: ", str)
                annoassunz = input_gen("Inserisci annoassunz: ", int)
                ore = input_gen("Inserisci ore lavorate: ", int)
                if p == "Dirigente":
                        persona = Dirigente(nome, cognome, matricola, annoassunz, ore)
                        GestioneProgetti().aggiungipersona(persona)
                        print(persona)
                elif p == "TecnicoEleAut":
                        n = input_gen("e' interno? 1.Si 2.No", int)
                        if n == 1:
                            interno = True
                        else:
                            interno = False
                        p = TecnicoEleAut(nome, cognome, matricola, annoassunz, ore, interno)
                        elenco.aggiungipersona(p)
                        print(p)
                elif p == "TecnicoInfTel":
                        n = input_gen("e' interno? 1.Si 2.No", int)
                        if n == 1:
                            interno = True
                        else:
                            interno = False
                        p = TecnicoInfTel(nome, cognome, matricola, annoassunz, ore, interno)
                        GestioneProgetti().aggiungipersona(p)
                        print(p)
                elif p == "FunzionarioJunior":
                        p = GestioneProgetti().aggiungipersona(
                            FunzionarioJunior(nome, cognome, matricola, annoassunz, ore))
                        print(p)
                elif p == "FunzionarioSenior":
                        p = GestioneProgetti().aggiungipersona(
                            FunzionarioSenior(nome, cognome, matricola, annoassunz, ore))
                        print(p)

            case 2:
                nome = input_gen("Inserisci nome: ", str)
                GestioneProgetti().eliminaPersona(nome)
            case 3:
                nome = input_gen("Inserisci nome: ", str)
                per = GestioneProgetti().cercaPersona(nome)
                print(per)
            case 4:
                print(GestioneProgetti().elencoPersone())

            case 5:
                print(GestioneProgetti().costiProgetto())
            case 6:
                print("N di persone che stanno lavorando sul progetto: ", GestioneProgetti().getTotalePersone())
            case 7:
                loop = False
        input("premi invio per continuare...")
        os.system("cls")


main()
