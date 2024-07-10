import datetime
d=datetime.datetime(2020 , 11 , 4 , 14 , 53 , 0)
print(d.strftime("%d/%m/%Y %H:%M:%S"))

print(d.strftime("%Y/%B/%d %H:%M:%S"))

print(d.strftime("%A %Y %b %d"))

print(d.strftime("%A %d %B %Y"))

print(d.strftime("Giorno feriale: " + "%w"))

print(d.strftime("Giorno dell'anno: " + "%j"))

print(d.strftime("Numero della settimana dell'anno: " + "%W"))


tot_minuti = int(input("inserisci il numero di minuti della scadenza:"))

print('Mancano:')
print(' ', tot_minuti // (60*24), 'giorni')
print(' ', (tot_minuti % (60*24)) // 60, 'ore')
print(' ', (tot_minuti % (60*24)) % 60, 'minuti')

from datetime import datetime, timedelta
scadenza =timedelta(minutes=5000)
print("scadenza tra: " ,scadenza)