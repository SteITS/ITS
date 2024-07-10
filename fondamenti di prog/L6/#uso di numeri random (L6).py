#uso di numeri random (L6)
import random

numero=random.random()
print(numero)
from random import random,seed,randrange,randint,sample
"""
numero=random()
print(numero)

for i in range(5):
    print(random())
    print(randrange(1,20)) #randrange(1,20) genera numero casuale tra 1 e 20
seed()
for i in range(5):
    print(randint(1,20),end=",")

lista_numeri_casuali=[]
for x in range(0,6):
    y=randint(1,45)
    lista_numeri_casuali.append(y)

print(lista_numeri_casuali)
"""
lista=sample(range(1,45),6)
print(lista)
