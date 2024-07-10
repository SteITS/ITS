#Lotteria
numeri_giocati=[3,7,11,47,34,49]
estrazione=[3,7,11,9,42,49]
centrati=0;
for numero in numeri_giocati:
    if numero in estrazione:
        centrati+1
print (centrati)