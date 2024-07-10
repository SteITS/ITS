class Dipendente:
    def __init__(self, nome:str, indirizzo:str, sesso:str):
        self._nome = nome
        self._indirizzo = indirizzo
        self._sesso = sesso
        
    def get_nome(self):
        return self.__nome
    def get_indirizzo(self):
        return self.__indirizzo
    def get_sesso(self):
        return self.__sesso

    def set_nome(self,nome):
        self._nome=nome
    def set_indirizzo(self,indirizzo):
        self._indirizzo=indirizzo
    def set_sesso(self,sesso):
        self._sesso=sesso
        
    def __str__(self):
        return "Nome: "+self.__nome+" Indirizzo: "+self.__indirizzo+" sesso: "+self.__sesso