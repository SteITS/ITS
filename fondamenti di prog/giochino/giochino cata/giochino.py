

import random
import tkinter as tk
from tkinter import PhotoImage
import os
from sys import path
def main():
    cwd=os.getcwd()
    cwd=str(cwd)
    cwd=cwd.replace('\\','\\\\')
    window = tk.Tk()
    window.title("Mappa con Icone")
    window.geometry("670x670")

    map_image = PhotoImage(file=cwd+"\\\\mappa2.PNG")
    map_label = tk.Label(window, image=map_image)
    map_label.place(x=0, y=0, relwidth=1, relheight=1)
    
    #enemy_icon = PhotoImage(file="path/to/enemy_icon.png")
    stanze_posizioni = [
    [50, 50], [150, 50], [200, 50], [300, 50],
    [425, 50], [490, 80], [590, 80], [300,120],
    [400, 120], [70,140], [150,140], [470,140],
    [250,170], [335,170], [395,170], [570,170],
    [70,220], [150,220], [240,240], [470,240],
    [320,270], [390,270], [580,270], [50,300],
    [180,300], [240,300], [460,330], [300,400],
    [400,400], [550,400], [50,400], [150,400],
    [230,400], [460,430], [150,460], [300,460],
    [370,460], [530,460], [590,460], [50,490],
    [230,490], [440,490], [110,530], [580,530],
    [310,560], [530,560], [50,590], [180,590],
    [400,590],[460,590]
]
    pos_cas=random.randint(0,49)
    for i in range (50):
        icon_numb = random.randint(1,7)
        if icon_numb!=7:
            icon_label = tk.Label(window, image=PhotoImage(file=cwd+"\\\\"+"_icon"+str(icon_numb)+".png"))
            icon_label.place(x=stanze_posizioni[i][0],y=stanze_posizioni[i][1])
        



    #enemy_label = tk.Label(window, image=enemy_icon)
    #enemy_label.place(x=150, y=200)

    window.mainloop()

if __name__ == "__main__":
    main()