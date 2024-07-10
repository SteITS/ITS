class Animale:
    def __init__(self,tipo,nome,verso):
        self._tipo=tipo
        self._nome=nome
        self._verso=verso
        
    def comeseiformato(self):
        return "Ho solo 4 gambe"
    
    def __str__(self):
        return ">>> Sono un "+self._tipo+", mi chiamo "+self._nome+" e faccio "+self._verso