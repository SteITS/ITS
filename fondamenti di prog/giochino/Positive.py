import tkinter as tk
from tkinter import messagebox
import random
import os
import sys

print(os.path.join(sys.prefix, 'Scripts', 'pyinstaller.exe'))

messaggio = [
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
numero=random.randint(0,8)

# Crea la finestra principale
root = tk.Tk()
root.withdraw()  # Nascondi la finestra principale

# Mostra il messaggio di dialogo
messagebox.showinfo("Positive", messaggio[numero])

# Chiudi la finestra principale
root.destroy()