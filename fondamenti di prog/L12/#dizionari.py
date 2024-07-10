dizionario = {"cat": "chat", "dog": "chien", "horse": "cheval"}
phone = {"boss": 553456778, "enzo": 4964347374}
dizionario_vuoto = {}
print(dizionario)
print(dizionario["cat"])
parole = ["cat", "lion", "horse"]
for p in parole:
    if p in dizionario:
        print(p, "-->", dizionario[p])
    else:
        print(p, " non presente nel dizionario")

# stampa del dizionario tramite la chiave
print("----------------------------")

for k in dizionario.keys():
    print(k, "-->", dizionario[k])

print("----------------------------")

for k in sorted(dizionario.keys()):
    print(k, "-->", dizionario[k])

print("---stampa dal dizionario ordinato con items---")

for k, v in sorted(dizionario.items(), reverse=True):
    print(k, "-->", v)
print(type(dizionario.keys()))
diz = sorted(dizionario)
print(diz)
st = list(dizionario.keys())
print(st)
st1 = list(dizionario)
print(st1)
