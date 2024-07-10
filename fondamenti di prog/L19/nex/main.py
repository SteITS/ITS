from Umano import Umano
from Animale import Animale
from FiguraMitologica import FiguraMitologica

def main():
    u1=Umano("FRANCO","FRANCESE")
    u2=Umano("MAURIO","CINESE")
    u3=Umano("AYOUB","ARABO")
    print(u1,"\n",u2,"\n",u3)
    print(u3.comeseiformato())
    
    a1=Animale("CANE","REX","BAU")
    a2=Animale("GATTO","GARFIELD","MIAO")
    a3=Animale("ELEFANTE","DUMBO","BARRRRRRRRR")
    print(a1,"\n",a2,"\n",a3)
    print(a2.comeseiformato())
    f1=FiguraMitologica("CENTAURO","GIARGIANESE","CAVALLO","IHIHIHI","GRECA")
    f2=FiguraMitologica("SFINGE","ARABO","LEONE","ROOAR","EGIZIA")
    print(f1,"\n",f2)
    print(f2.comeseiformato())
    
main()
    