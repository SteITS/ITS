#mangia vocali
#chiede all'utente una frase dalla tastiera
#converte la frase in maiuscolo e poi elimina le vocali
#stampa senza vocali
frase2=""
frase=input("Inserisci una frase: ")
frase=frase.upper()
for lettera in frase:
    if lettera in "AEIOU":
        continue
    else:
        frase2+=lettera

print(frase2)