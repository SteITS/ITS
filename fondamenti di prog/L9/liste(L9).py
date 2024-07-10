lista=["Ugo","Foscolo","Jesus","Mario","Robi"]
print(lista)
lista[3]="Gianluca"
dim=len(lista)
print(dim)
l=lista[1:3]
print(l)
#scorrere gli elementi
for i in range(len(lista)):
    print(lista[i])
#altro modo
for elemento in lista:
    print(elemento)
#scambiare due elementi della lista
lista[0],lista[4]=lista[4],lista[0]

print(lista)

lista.reverse()
print(lista)
lista.append("Mario")
print(lista.count("Mario"))
print(lista)
lista.insert(3,"Mario")
print(lista)
lista.pop(3)
print(lista)
lista.sort()
print (lista)
lista.sort(reverse=True)
dove=lista.index("Mario")
print (dove)
lista.remove("Gianluca")
l1=lista.copy()
lista.clear()
print (lista)
