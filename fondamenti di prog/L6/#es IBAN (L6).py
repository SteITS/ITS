#es IBAN (L6)
#iban=input("Inserisci IBAN italiano: ")
#iban.upper()
#passed=''
#try:
#    len(iban) == 27
#    iban[0]=="I" and iban[1]=="T" and iban[2].isdigit() and iban[3].isdigit()
#except:
#    print("IBAN non corretto")    

#passed=iban[4:] + iban[:4]
#print(passed)

iban =input("Inserisci Iban: ")
if len(iban) > 31:
    print("IBAN troppo lungo")
elif len(iban)<15:
    print("IBAN troppo corto")
else:
    iban=iban[4:]+iban[0:4].upper()
    iban2=""
    for ch in iban:
        if ch.isdigit():
            iban2+=ch
        else:
            iban2+=str(10+ord(ch)-ord('A'))
    iban=int(iban2)
    if iban%97==1:
        print("IBAN inserito è valido")
    else:
        print("IBAN non valido")