telefono = '+392574856985' # True
#telefono = '395851256954' # False (manca il '+')
#telefono = '++7485125874' # False (manca il prefisso)
#telefono = '+39333457Ciao' # False (mi pare ovvio :D )
#telefono = "+3912" # False (troppo corto)
#telefono = '+393481489945' # True

f=False

if telefono.startswith("+39"):
    if len(telefono)==13:
        if telefono[1:12].isdigit():
                f=True
if f==True:
    print("il numero di telefono e' attivo")
else:
    print("il numero di telefono non e' attivo")