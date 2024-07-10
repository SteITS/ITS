#stringhe
''''''
a="la mia prima stringa, in doppie virgolette"
b='la mia seconda stringa, in virgolette singole'
c=""""la mia terza stringa
in triple virgolette
le posso mettere su
piu righe"""
d='''dsadad
che 
bello '''

print(len(d))
stringa= "cosi metto \'apici\' e \"doppie virgolette\" nelle stringhe"
#numeri
x=3
y=5
print("\n ho saltato", x,"volte e fatto",y,"flessioni")

print(c[0:21]) #stampa della stringa "c" solamente le lettere dalla posizione 0 alla 21

z=6.2 #con virgola
i=11234 #intero
d=0O23 #base 8
ex=0X123 #base 16
bi=0B11001 #binario
print(i,d,ex,bi, sep="\t")  #sep --> separa le variabili in print

#boolean
g=1
print(g==1)
print(9/2, 9//2, 9%2, 9**2, sep="\t")  # ** -> al quadrato  // -> divisione per interi

#conversione numeri in stringhe -> funzione str() e operatore +
h=str(g)+" a"
print(type(h)) #stampa il tipo di variabile
print(h)
S="10"
r=int(S)
print(S,r,sep="\t")
t=(input("inserisci un numero: "))
print(t)

a=t*3    #moltiplicazione di una stringa es: stringa=21a, stringa*3= 21a21a21a
print(a)

a="atleta"
print("leta" in a)  #in operatore logico, c'è "leta" in "atleta"? True

a=10
b=15
x="io sono {} {}".format('Mario','Rossi') #.format inserisce le stringhe nelle parentesi graffe in ordine
print(x)
data='20/04/2022'
eta=25
print(f"data nascita: {data} eta: {eta}") #f all'inizio è sempre .format
print("data nascita: {0} eta: {1}" .format(data,eta))
print("data nascita: {d} eta: {e}" .format(e=eta,d=data))
print("data nascita: {0} eta: {1:2.3f}" .format(data,eta)) #2.3f -> 2 numeri interi prima della virgola, 3f -> 3 numeri in float dopo la virgola

a=10.5
b="15"
print("sono dirigente da %2.3f anni e impiegato da %s"%(a,b))

""""ARTICOLO PREZZO QUANTITA SCONTO_APPLICATO TOTALE_SCONTATO
    pomodori 5.25   25        23.46           107.41            """

nome="pomodori"
prezzo=5.25
quant=25
sc=23.46
tot=prezzo*quant
txt="{:<20} {:<7} {:<10} {:<18} {:<6}"   #<meno di 20 caratteri per la formattazione
print(txt.format("ARTICOLO","PREZZO","QUANTITA","SCONTO APPLICATO","TOTALE SCONTATO"))
print(txt.format(nome,prezzo,quant,sc,tot))

n1=int(input("inserisci primo numero:"))
n2=int(input("inserisci secondo numero:"))
print("i due numeri inseriti sono:", n1, "e", n2)
"""n3=n1
n1=n2
n2=n3
print("i due numeri scambiati sono:", n1, "e", n2)
"""
n1,n2=n2,n1
print("i due numeri scambiati sono:", n1, "e", n2)

t1=float(input("inserisci la 1a temperatura: "))
t2=float(input("inserisci la 2a temperatura: "))
t3=float(input("inserisci la 3a temperatura: "))
t4=float(input("inserisci la 4a temperatura: "))
media=(t1+t2+t3+t4)/4
print(media)
list=[t1,t2,t3,t4]
import numpy
print(numpy.sum(list)/len(list))

from datetime import date

oggi=date.today()
print("oggi:",oggi)
print("Anno:",oggi.year)
print("mese:",oggi.month)
print("giorno:",oggi.day)

miadata=date(2019,3,24)
print(miadata)
print(miadata.strftime("%d/%m/%Y %H:%M:%S"))

import calendar
print(calendar.calendar(2024))

