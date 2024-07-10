from Umano import Umano
from Animale import Animale
class FiguraMitologica(Umano,Animale):
    def __init__(self, nome, lingua,tipo,verso,mito):
        Umano.__init__(self,nome, lingua)
        Animale.__init__(self,tipo,nome,verso)
        self._mitologia=mito
        
    def __str__(self):
        return ">Sono una Figura Mitologica: metà Uomo e metà "+self._tipo+", mi chiamo "\
        +", parlo "+self._lingua+" oppure posso fare "+self._verso+" e appartengo alla mitologia" + self._mitologia
         