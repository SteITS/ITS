from input_dati import *

def a(x):
    return x[0]

def input_auto(elenco):
    while True:
        auto=[]
        anno=input_range("Inserisci anno immatricolazione: ",int,1900,2024)
        marca=input_gen("Inserisci marca auto: ",str)
        cilindrata=input_range("Inserisci cilindrata es:3500: ",int,50,8000)
        nome=input_gen("Inserisci Nome proprietario: ",str)
        cognome=input_gen("Inserisci Cognome proprietario: ",str)
        auto.append(anno)
        auto.append(marca)
        auto.append(cilindrata)
        auto.append(nome)
        auto.append(cognome)
        elenco.append(auto)
        scelta=input_range("Vuoi uscire 1.Si 2.No ",int,1,2)
        if scelta==1:
            break
    
def ordinamento_anno(elenco):
    copia=[]
    for i in elenco:
        elenco.sort(key=a)
        copia=elenco
    return copia;


def print_elenco(copia):
    print("Ordinamento per anno")
    for p in copia:
        if(p[2]<1500):
            print(p)
        else:
            del p[3]
            print(p)

def anno_richiesta(copia):
    anno_richiesto=input_range("Inserisci anno vendite veicoli: ",int,1900,2024)
    i=0
    for p in copia:
        if(p[0]==anno_richiesto):
            i+=1
            print(p)
        else:
            print("nessuna auto venduta nell'anno ",anno_richiesto)    
    print(i," auto vendute nel ",anno_richiesto)


def main():
    elenco=[]
    input_auto(elenco)
    copia=ordinamento_anno(elenco)
    print_elenco(copia)
    anno_richiesta(copia)
main()