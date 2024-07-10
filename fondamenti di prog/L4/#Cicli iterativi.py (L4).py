#Cicli iterativi
conta=0
for i in range(1,6):

    if i==2:
        continue
    if i==3:
        break #interrompe il for
        print(i)

#-------
#uso del while

numero=int(input("Inserisci un numero oppure -1 per terminare "))
while numero !=-1:
    conta=conta+1
    numero=int(input("Inserisci un numero oppure -1 per terminare "))
    if numero==3:
        break
    if numero==4:
        continue
    print(conta)

from input_dati import *