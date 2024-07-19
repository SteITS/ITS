from Persona import Persona

class FunzionarioJunior(Persona):
    costo=70     #variabile statica
    def __init__(self,nome, cognome, matricola,anno,orelav):
        super().__init__(nome,cognome,matricola,anno)
        self.__orelavorate=orelav

    def get_orelavorate(self):
        return self.__orelavorate
    
    def set_orelavorate(self,orelav):
        self.__orelavorate=orelav

    #metodo di classe (statico) per conoscere il costo orario dei funzionari Senior
    @classmethod
    def getcosto(cls):
        return cls.costo
    
    #implementazione del metodo astratto
    def getCostoC(self,anno=None):
        return FunzionarioJunior.costo*self.__orelavorate;

    def __str__(self):
        return super().__str__()+" Ore lavorate: "+str(self.__orelavorate)

