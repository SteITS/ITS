from input_dati import *

def litri_100km_to_miglia_galloni():
    consumo=input_gen("Inserisci consumo lt/100km: ",float)
    kml=100/consumo
    consumo_finale= kml * 2.3521

    return consumo_finale

def miglia_gallone_to_litri_100km():
    consumo=input_gen("Inserisci consumo in MPG: ",float)
    kml=0.425*consumo
    consumo_finale=100/kml

    return consumo_finale

def main():
    conv=input("EUUS per convertire da sistema europea a americano USEU per il contrario: ")
    conv.upper()
    if conv == "EUUS":
        final=litri_100km_to_miglia_galloni()
        print(final)
    else:
        final=miglia_gallone_to_litri_100km()
        print(final)
main()