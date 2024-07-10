#creo insieme vuoto
n=set()
nomi={"luigi","mario","davide"}
nomi.add("antonio")

nomi.add("luigi") #non aggiunge, c'è già nel set
print(nomi)
nomi.discard("renato") #non elimina, non esiste nel set
nomi.discard("")

if "renato" in nomi:
    nomi.remove("renato")
else:
    print("renato non esiste in nomi")

print("----------------------------------------------------------------------")

alunni={"mario","luigi"}
print(alunni.issubset(nomi))
print(nomi.issuperset(alunni))

persone=nomi.union(alunni)
print("persone= ",persone)
persone=alunni.union(nomi)
print("persone= ",persone)
persone=nomi.intersection(alunni)
print("persone= ",persone)
persone=nomi.difference(alunni)
print("persone= ",persone)
persone=alunni.difference(nomi)
print("persone= ",persone)
nomi.clear()
print(nomi)

numeri=set(range(10))
print(numeri)

st="lamiastringa"
miastringa=set(st)
print(miastringa)

numeri=set(range(10))
print(numeri)
n=[5,7,9,2,3,1,1]
numeri=set(n)
print(numeri)

print("----------------------------------------------------------------------")

