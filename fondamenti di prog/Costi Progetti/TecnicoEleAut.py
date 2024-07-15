from Persona import Persona

class TecnicoEleAut(Persona):
    costo=50
    def __init__(self,nome:str,cognome:str,matricola:str,annoInizio:int,orelav:int,interno:bool):
        super().__init__(nome,cognome,matricola,annoInizio)
        self.__orelavorate=orelav
        self.__interno=interno

    def getorelavorate(self):
        return self.__orelavorate
    
    def set_orelavorate(self,orelav):
        self.__orelavorate=orelav
        
    def getinterno(self):
        return self.__interno
    def setinterno(self,interno:bool):
        self.__interno=interno

    #metodo di classe (statico) per conoscere il costo orario del tecnico
    @classmethod
    def getcosto(cls):
        return cls.costo
    
    def getCostoC(self,anno=None):
        #anni=Persona.ANNOATTUALE-self._annoassunz;
        anni=anno-self.getannoassunz()
        if self.__interno==True:
            risultato=(TecnicoEleAut.costo*self.__orelavorate)+anni*self.__orelavorate;
        else:
            risultato=TecnicoEleAut.costo*self.__orelavorate;
        return risultato;

    def __str__(self):
        st="INTERNO " if self.__interno==True else " ESTERNO "
        return super().__str__()+" Ore lavorate: "+str(self.__orelavorate)+ " "+st

