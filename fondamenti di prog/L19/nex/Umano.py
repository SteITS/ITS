class Umano:
    def __init__(self,nome,lingua):
        self._nome=nome
        self._lingua=lingua
        
    def comeseiformato(self):
        return "Ho 2 gambe e due mani"
    
    def __str__(self) :
        return " Nome: "+self._nome+"lingua: "+self._lingua+str(self.comeseiformato())