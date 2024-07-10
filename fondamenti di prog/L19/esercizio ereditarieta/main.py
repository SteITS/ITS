from Dipendente import Dipendente
from Docente import Docente
from Impiegato import Impiegato
from GestioneDipendenti import GestioneDipendenti
from input_dati import *
import os

stringa_menu="""
1) Aggiunta di un nuovo dipendente
2) Eliminazione di un dipendente
3) Ricerca di un dipendente
4) Visualizzazione di tutti i dipendenti i
5) Stampa del numero totale dei dipendenti
6) Eliminazione di tutti i dipendent
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



def main():
    s=menu()
    match s:
        case 1:
            d=input_gen("D per creare un docente, I per creare un impiegato",str)
            nome=input_gen("Inserisci nome dipendente: ",str)
            indirizzo=input_gen("Inserisci indirizzo dipendente: ",str)
            sesso=input_gen("Inserisci sesso dipendente: ",str)
            
            if d == "D":
                disciplina=input_gen("Inserisci disciplina docente: ",str)
                ruolo=input_gen("Inserisci ruolo docente: ",str)
                um=Docente(nome,indirizzo,sesso,disciplina,ruolo)
                GestioneDipendenti.aggiungidipendente(um)
                print(um)
            elif d=="I":
                ufficio=input_gen("Inserisci ufficio impiegato: ",str)
                um=Impiegato(nome,indirizzo,sesso,ufficio)
                GestioneDipendenti.aggiungidipendente(um)
                
        case 2:
            pass

    input("premi invio per continure...")
    os.system("cls")
    
main()