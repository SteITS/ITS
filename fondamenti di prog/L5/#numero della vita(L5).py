#numero della vita(L5)
#calcolca il numero della vita di una persona
#conoscendo la data di nascita
#esempio: 01/01/1987 0+1+0+1+1+9+8+7+2= 27 --> 2+7 --> 9

data=input("inserisci la data di nascita(formato: YYYYMMDD): ")
if len(data)!=8 or not data.isdigit():
    print("formato della data errato")
else:
    while len(data)>1:
        somma=0
        for numero in data:
            somma += int(numero)
        data=str(somma)

print(somma)