#esercizio 
#conta le parole ( con più di due caratteri) in una frase lunga
#indicazione usare split()e strip()

frase="Ciao! sono un, umano totsugeki , bab."
frase1=""
frase1=frase.split()
print(frase1)
frase3=[]
for i in range (len(frase1)):
    frase1[i]=frase1[i].strip("!.,:")
    print(frase1[i])
    if len(frase1[i]) > 2:
        frase3.append(frase1[i])

print(frase3)
print(len(frase3))