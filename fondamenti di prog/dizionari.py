dizionario={"cat":"chat","dog":"chien","horse":"cheval"}
phone={"boss":553456778,"enzo":4954347374}
dizionario_vuoto={}
print(dizionario)
print(dizionario["cat"])
parole=["cat","lion","horse"]
#controlla se una parola della lista è presente nel dizionario e stampa il valore
for p in parole:
    if p in dizionario:
        print(p,"-->",dizionario[p])
    else:
        print(p," non presente nel dizionario")
        
dizionario={"dog":"chien","horse":"cheval","cat":"chat"}        
#stampa del dizionario tramite la chiave
print("----stampa del dizionario tramite la chiave------")
for k in dizionario.keys():
    print(k,"-->",dizionario[k])

print("----stampa del dizionario ordinato con keys()------")
for k in sorted(dizionario.keys()):
    print(k,"-->",dizionario[k])

print("----stampa del dizionario ordinato con items()------")
for chiave,valore in sorted(dizionario.items(),reverse=True):
        print(chiave,"-->",valore)
print("nuovo dizionario ordinato ")  
d=dict()
for chiave,valore in sorted(dizionario.items()):
     d.update({chiave:valore})
print(d)
print("**********nuovo dizionario ordinato")
d1=dict(sorted(dizionario.items()))
print(d1)
print("***************")
print(type(dizionario.keys()))
#aggiungo un dizionario ad un altro
d2=dict()
d.update({"frog":"grenouille"})
d2=d
print("aggiungo un dizionario ad un altro")
print(d2)
diz=sorted(dizionario)

print(diz,type(diz))
st=list(dizionario.keys())
print(st)
st1=list(dizionario)
print(st1)
p=dizionario.pop("cat")
print(dizionario)
print(p,type(p))
    
    
