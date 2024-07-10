from tkinter import messagebox,filedialog  

nomefile=filedialog.askopenfilename(filetypes=(("File di testo","*.txt"),("Tutti i file","*"),("File Python","*")))
print(nomefile)

res=messagebox.showinfo("info","bab")
print(res) #restituise ok

info=messagebox.askquestion("Domanda","sei sicuro?")
print(info) #restituisce yes/no

ris=messagebox.showwarning(title="Attenzione",message="valore errato")
print(ris)