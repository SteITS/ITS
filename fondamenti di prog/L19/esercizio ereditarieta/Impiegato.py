from Dipendente import Dipendente
class Impiegato:
    def __init__(self,nome,indirizzo,sesso, ufficio:str):
        Dipendente.__init__(self,nome,indirizzo,sesso)
        self._ufficio = ufficio
        
    def get_ufficio(self):
        return self.__ufficio
    def set_ufficio(self,ufficio):
        self.__ufficio=ufficio
        
    def __str__(self) -> str:
        return super()+" "+"Ufficio: "+self.__ufficio