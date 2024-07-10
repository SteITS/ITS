#Sconto Kilobyte Database
def main():
    prezzo=float(input("inserisci prezzo: "))
    if(prezzo<0):
        print("prezzo non valido")
    else:
        if(prezzo < 128):
            prezzo=prezzo-prezzo*0.08
        else:
            prezzo=prezzo-prezzo*0.16
        print("Il prezzo finale e'",prezzo)
main()