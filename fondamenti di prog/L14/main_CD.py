from Classe_CD import CD
from input_dati import *

def main():

    nome=input_gen("Inserisci nome dell'album: ",str)
    artista=input_gen("Inserisci nome artista: ",str)
    prezzo=input_gen("Inserisci prezzo album: ",float)
    annouscita=input_gen("Inserisci anno uscita: ",int)

    disco=CD(nome,artista,prezzo,annouscita)
    disco.pubblica()
    print(disco)
    disco.esploso()
    disco.modifica_prezzo(input_gen("Inserisci nuovo prezzo: ",float))
    print(disco)
    
main()

