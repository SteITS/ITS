import tkinter as tk
from tkinter import messagebox
import random
import os
import sys
#os.chdir(sys.path[0])
print(os.path.join(sys.prefix, 'Scripts', 'pyinstaller.exe'))


messaggio=["Mina esplosiva//balza il turno","Shuffle//Ti sposta in un posto randomico sulla mappa","Rewind//Torna allo spawn","Napoli//Un nemico ti ruba un'item,scegli tu chi"
           ,"Amuleto della sfortuna// per i prossimi 2 turni lancia una moneta.Testa:Giochi il turno; Croce:Salti il turno","Biscotto dell'astinenza//Non puoi utilizzare item per 3 turni",
           "The Fool//Per 2 turni il master gioca al tuo posto","Pugnalata//Un altro giocatore decide la tua sorte:Teletrasporto casuale,Perdita di item,Salta 2 turni",
           "Bavaglio//Zitto per 3 turni,Salta il turno se parli"]
messaggio1 = [
    "ratto esploratore//esplora la stanza dove lo lanci",
    "shottino//dallo ad un giocatore a tua scelta, sviene per 1 turno",
    "ladro di cuori//fai innamorare un giocatore, ti regala un suo item",
    "pozione dell'invisibilità//diventi invisibile all'uso, prossimo evento verrà bloccato e non avrà nessun effetto su di te",
    "campo di forza//ti dice a quanti blocchi di distanza si trovano i nemici da te",
    "big bang//la fine è vicina, ti dice a quanti blocchi è l'uscita",
    "virus//passa l'aids alla persona più vicina a te, quella persona non può usare item per 2 suoi turni",
    "barriera di ghiaccio//crea un muro su un ingresso a tua scelta, nessuno può attraversarlo, si scioglie tra 2 tuoi turni",
    "anello del teletrasporto//teletrasportati su un giocatore a tua scelta"
]
#Crea un numero randomico
def ran():
    numero=random.randint(0,8)
    return numero

# Crea la finestra principale
def scelta_opzione1():
    numero=ran()
    messagebox.showinfo("Negative Penalty", messaggio1[numero])
    
def scelta_opzione2():
    numero=ran()
    messagebox.showinfo("Negative Penalty", messaggio[numero])
# Creare la finestra principale

root = tk.Tk()
root.title("Seleziona un'opzione")
root.geometry("400x250")

# Creare un'etichetta con il testo
label = tk.Label(root, text="Scegli un'opzione:", font=("Arial", 14))
label.pack(pady=20)

# Creare i pulsanti per le due opzioni
button1 = tk.Button(root, text="Positive Bonus", command=scelta_opzione1, font=("Arial", 12))
button1.pack(side=tk.LEFT, padx=20)

button2 = tk.Button(root, text="Negative Penalty", command=scelta_opzione2, font=("Arial", 12))
button2.pack(side=tk.RIGHT, padx=20)

# Avviare il ciclo principale della GUI
root.mainloop()

# Chiudi la finestra principale
#root.destroy()
