#fattoriale (L6)
#fattoriale di 8 = 8*7*6*5*4*3*2*1= 40320
n=int(input("Inserisci un numero maggiore di 0: "))
if(n<0):
    print("Il fattoriale di un num negativo è indefinito")
else:
    x=1
    for i in range(1,n+1):
        x=x*i
print("Il fattoriale di ",n,"è: ",x)