#ciclo2 (L4)
st="abc123XYZ"
print(st)
st1=""
for ch in st: #per ogni carattere presenti in st
    if ch.isupper():
        ch1=ch.lower()
        print((ch1),end="")
    elif ch.islower():
        ch1=ch.upper()
        print(ch1,end="")
    else:
        ch1=ch
        print(ch1,end="")
    st1=st1+ch1

print(" frase invertita: ",st1)