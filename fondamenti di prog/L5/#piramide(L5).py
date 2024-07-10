#piramide(L5)
altezza = 0
conta = 0
blocchi=int(input("Inserisci base della piramide "))
while blocchi > 0:
    blocchi = blocchi-1
    conta = conta +1
    if(conta>altezza):
        altezza = altezza+1
        conta = 0

print("l'altezza della piramide è di",altezza, "blocchi, con",conta, "blocchi di resto")