from Dipendente import Dipendente
class Docente:
    def __init__(self, nome, indirizzo,sesso,disciplina,ruolo):
        Dipendente.__init__(self,nome,indirizzo,sesso)
        self._disciplina = disciplina
        self._ruolo = ruolo
        
    def get_ruolo(self):
        return self.__ruolo
    def get_disciplina(self):
        return self.__disciplina
    
    def set_ruolo(self,ruolo):
        self.__ruolo=ruolo
    def set_disciplina(self,disciplina):
        self.__disciplina=disciplina
        
    def __str__(self):
        return super()+" "+"Ruolo: "+self.__ruolo+" Disciplina: "+self.__disciplina
