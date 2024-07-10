#cifrario di Cesare(L6)
txt=input("Inserisci un messaggio: ")
cifrario=''
for char in txt:
#    if not char.isalpha():
#        continue
#    else:
#        char=char.upper()
        code=ord(char)+1
#        if code>ord('Z'):
#            code=ord('A')
        cifrario += chr(code) #converte in carattere il codice ASCII e lo aggiunge alla stringa
print(cifrario)

#decifrazione
decifrato=''
for char in cifrario:
        code=ord(char)-1
        decifrato += chr(code)
print(decifrato)