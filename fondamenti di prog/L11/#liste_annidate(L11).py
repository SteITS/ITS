#lste annidate
#record dati con lista di lista
from input_dati import *

def a(x):
    return x[1]

def b(x):
    return x[2]

def main():
    elenco=[] #dati di persone
    while True:
        persona=[]
        nome=input_gen("Inserisci il nome: ",str)
        cognome=input_gen("Inserisci il cognome: ",str)
        data=input_data("Inserisci data di nascita (gg/mm/aaaa): ")
        sesso=input_gen("Inserisci sesso M/F: ",str)
        persona.append(nome)
        persona.append(cognome)
        persona.append(str(data)[:10])
        persona.append(sesso)
        elenco.append(persona)
        scelta=input_range("Vuoi uscire 1.Si 2.No ",int,1,2)
        if scelta==1:
            break

    for p in elenco:
        print(p)
    print("Ordinamento per cognome")
    elenco.sort(key=a,reverse=True)
    print("Ordinamento per data")
    elenco.sort(key=a,reverse=True)
    for p in elenco:
        print(p)
main()