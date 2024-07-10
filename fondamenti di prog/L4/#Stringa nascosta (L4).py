#Stringa nascosta (L4)
st="bdfog"
str=""
st1="abcdefovcg" #true
#st1="accovbdbmg" #false

bln=True
pos=0
pos1=0
for i in range(0,len(st)):
    pos=pos1
    pos1 = st1.find(st[i])
    str=str+st[i]
    if(pos1<pos):
        bln=False
        print(-1)
        break

if bln==True:
    print ("Nella stringa ",st1," è presente la stringa", st)