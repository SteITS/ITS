#trova errori(L6)
#questo programma ha un errore, se inserisco solo valori pos termina senza errori
#il debugger trova gli errori
#quando si fa il test del codice si devono testare tutte i possibili casi per essere sicuri
#che il programma non abbia errori

temperature=float(input("Inserisci la temperatura "))
if(temperature>0):
    print("temperatura maggiore di 0")
elif temperature<0:
    print("temperatura minore di 0")
else:
    print("zero")
