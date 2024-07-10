#controlla stringhe
while True:
    try:
        st=input("Inserisci 'S' o 'F' o 'C': ")
        if st!='S' and st != 'F' and st != 'C':
            raise Exception("valore " +st+ " non valido.Inserisci 'S' o 'F' o 'C': ")
        break
    except Exception as error:
        print(error)
        

#    else:
#        break

print("hai inserito: ",st)