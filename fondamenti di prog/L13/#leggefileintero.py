#leggefileintero
import os
import tkinter.filedialog as fd
curdir=os.getcwd()
print(curdir)
stream=open("files2.py",mode="rt",encoding="utf-8")

txt=stream.read()
print(txt)

p=fd.asksaveasfilename(file="salva come...",filetypes=[("text",".txt"),("python",".py")])
stream=open(p,"w+")
stream.write(txt)
stream.close()
print(p)
print(stream.encoding)