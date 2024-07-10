from input_dati import *
def migliaia(anno):
    k = ""
    if anno == 1 : k = "M"
    if anno == 2 : k = "MM"
    if anno == 3 : k = "MMM"
    return k

def centinaia(anno):
    c = ""
    if anno == 1 : c = "C"
    if anno == 2 : c = "CC"
    if anno == 3 : c = "CCC"
    if anno == 4 : c = "CD"
    if anno == 5 : c = "D"
    if anno == 6 : c = "DC"
    if anno == 7 : c = "DCC"
    if anno == 8 : c = "DCCC"
    if anno == 9 : c = "CM"
    return c

def decine(anno):
    d = ""
    if anno == 1 : d = "X"
    if anno == 2 : d = "XX"
    if anno == 3 : d = "XXX"
    if anno == 4 : d = "XL"
    if anno == 5 : d = "L"
    if anno == 6 : d = "LX"
    if anno == 7 : d = "LXX"
    if anno == 8 : d = "LXXX"
    if anno == 9 : d = "XC"
    return d

def unita(anno):
    u = ""
    if anno == 1 : u = "I"
    if anno == 2 : u = "II"
    if anno == 3 : u = "III"
    if anno == 4 : u = "IIII"
    if anno == 5 : u = "V"
    if anno == 6 : u = "VI"
    if anno == 7 : u = "VII"
    if anno == 8 : u = "VIII"
    if anno == 9 : u = "IX"
    return u



def main():
    anno=input_range("Inserisci num tra 0 e 3999:",int,0,3999)
    if anno<10:
        u=unita(anno)
        print(u)
    elif 10<anno<100:
        u=unita(anno)
        d=decine(anno)
        final=d+u
        print(final)
    elif 100<anno<1000:
        c=centinaia(anno)
        u=unita(anno)
        d=decine(anno)
        final=c+d+u
        print(final)
    elif 1000<anno<4000:
        k=migliaia(anno)
        c=centinaia(anno)
        u=unita(anno)
        d=decine(anno)
        final=k+c+d+u
        print(final)
main()    
