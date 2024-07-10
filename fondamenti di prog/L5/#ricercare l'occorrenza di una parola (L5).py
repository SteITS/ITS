# ricercare l'occorrenza di una parola in un testo(L5)

Testo="Il tuo compito è scrivere un programma che legga il numero di blocchi che hanno i costruttori e produca l'altezza della piramide che può essere costruita usando questi blocchi. Nota: l'altezza è misurata dal numero di strati completati - se i costruttori non hanno un numero sufficiente di blocchi e non possono completare il livello successivo, terminano immediatamente il loro lavoro."
parola=input("Inserisci la parola che vuoi trovare nel testo: ")
countP=0
i=-1
print(len(Testo))
while i<len(Testo):
    i=Testo.find(parola,i+1,len(Testo))
    if(i==-1):
        break
    countP+=1

print(countP)