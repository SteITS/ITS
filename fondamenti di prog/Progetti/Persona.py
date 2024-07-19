from abc import ABC, abstractmethod

#creo classe astratta
class Persona(ABC):

    def __init__(self, nome:str,cognome:str,matricola:str,annoassunz:int):
        self.__nome= nome    
        self.__cognome=cognome
        self.__matricola=matricola
        self.__annoassunz=annoassunz
       
    def getnome(self):
        return self.__nome
    def getcognome(self):
        return self.__cognome
    def getmatricola(self):
        return self.__matricola
    def getannoassunz(self):
        return self.__annoassunz
    
    def setnome(self, nome):
        self.__nome=nome
    def setcognome(self, cognome):
        self.__cognome=cognome
    def setmatricola(self, mat):
        self.__matricola=mat
    def setannoaasunz(self, anno):
        self.__annoassunz=anno
        
    # overriding
    def __str__(self):
        return "Nome: "+self.__nome+"\nCognome: "+self.__cognome+"\nMatricola: "+self.__matricola+"\nAnno assunzione: "+str(self.__annoassunz)
    
    @abstractmethod #metodo astratto che calcola il costo di partecipazione al progetto. Non implementato   
    def getCostoC(self,anno=None):
        pass
