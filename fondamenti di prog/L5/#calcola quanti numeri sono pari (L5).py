#calcola quanti numeri sono pari e quanti sono dispari
pari=0
dispari=0
print("programma che calcola quanti numeri sono pari e dispari")
numero=int(input("inserisci un numero (0 per terminare): "))
while numero != 0:
    if(numero%2==0):
        pari = pari +1
    else:
        dispari= dispari+1
    numero=int(input("inserisci un numero (0 per terminare):"))
print(pari, "numeri sono pari, ", dispari, " numeri sono dispari")
