from Classe_atleta import Atleta
from input_dati import *

def main():
    nome=input_gen("Inserisci nome: ",str)
    cognome=input_gen("Inserisci cognome: ",str)
    altezza=input_maggiore("Inserisci altezza: ",int,0)
    
    Ayoub=Atleta(nome,cognome,altezza)
    print(Ayoub)
    Ayoub.assegna_squadra("Milan")
    Ayoub.effettua_visita(True)
    
    print(Ayoub)
main()