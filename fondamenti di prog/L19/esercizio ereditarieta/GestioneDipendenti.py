from Dipendente import Dipendente 
class GestioneDipendenti:
    def __init__(self,lista:list):
        self.__lista=lista
        
    def aggiungidipendente(self,dipendente:Dipendente):
        self.__lista.append(dipendente)
        
    def eliminadipendente(self,nome:str):
        for c in self.__lista:
            if c.get_nome()==nome:
                del c
                return True
        return False
    
    def cercadipendente(self,nome:str):
        for c in self.__lista:
            if c.get_nome()==nome:
                return True
        
        return False
    
    def cancellatuttidip(self):
        self.__lista.clear()
        if len(self.__lista) == 0:
            return True
        else:
            return False
        
    def totaledipendenti(self):
        return len(self.__lista)
    
    def __str__(self):
        msg=""
        for d in self.__lista:
            msg+=d,"\n"
        return msg