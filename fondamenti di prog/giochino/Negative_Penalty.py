import tkinter as tk
from tkinter import messagebox
import random
import os
import sys

print(os.path.join(sys.prefix, 'Scripts', 'pyinstaller.exe'))

messaggio=["Mina esplosiva//balza il turno","Shuffle//Ti sposta in un posto randomico sulla mappa","Rewind//Torna allo spawn","Napoli//Un nemico ti ruba un'item,scegli tu chi"
           ,"Amuleto della sfortuna// per i prossimi 2 turni lancia una moneta.Testa:Giochi il turno; Croce:Salti il turno","Biscotto dell'astinenza//Non puoi utilizzare item per 3 turni",
           "The Fool//Per 2 turni il master gioca al tuo posto","Pugnalata//Un altro giocatore decide la tua sorte:Teletrasporto casuale,Perdita di item,Salta 2 turni",
           "Bavaglio//Zitto per 3 turni,Salta il turno se parli"]
numero=random.randint(0,8)

# Crea la finestra principale
root = tk.Tk()
root.withdraw()  # Nascondi la finestra principale

# Mostra il messaggio di dialogo
messagebox.showinfo("Negative Penalty", messaggio[numero])

# Chiudi la finestra principale
root.destroy()

