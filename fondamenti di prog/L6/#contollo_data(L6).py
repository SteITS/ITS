#contollo_data(L6)
#verifica se una data è valida
from datetime import datetime
while True:
    stdata=input("Inserisci una data (gg/mm/aaaa): ")
    try:
        d=datetime.strptime(stdata,'%d/%m/%Y')
        break
    except:
        print("Errore data non valida")

print(d)