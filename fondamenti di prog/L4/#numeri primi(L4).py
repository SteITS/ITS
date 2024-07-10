#numeri primi(L4)
#un numero è primo se divisibile per 1 e per se stesso.
numero=int(input("Inserisci un numero "))
b=False
st=""
for i in range(2,numero+1):
    if numero%i==0:
        b=True
        st=st+str(i)+","
if(b==False):
    print(numero, " e' primo")
else:
    print("il numero ",numero," non è primo"," i divisori sono ",st[:-1])
            
        