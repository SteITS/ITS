#giorni al compleanno
import datetime
oggi=datetime.date.today()

print("inserisci il giorno e il mese del compleanno: ")
giorno=int(input("Giorno (da 1 a xx: )"))
mese=int(input("mese (da 1 a 12): "))

compleanno=datetime.date(oggi.year,mese,giorno)
if (compleanno < oggi):
    compleanno=compleanno.replace(year=oggi.year+1)

giorni=compleanno-oggi
print("giorni che mancano: ", giorni.days)