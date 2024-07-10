class CD:
    def __init__(self,nome:str,artista:str,prezzo:float,annouscita:int,uscito=False):
        self.__nome=nome
        self.__artista=artista
        self.__prezzo=prezzo
        self.__annouscita=annouscita
        self.__uscito= False
        
        
        #metodi getter
    def get_nome(self):
        return self.__nome
    def get_artista(self):
        return self.__artista
    def get_prezzo(self):
        return self.__prezzo
    def get_annouscita(self):
        return self.__annouscita
    def get_uscito(self):
        return self.__uscito
    
    #metodi setter
    def set_nome(self,nome):
        self.__nome=nome
    def set_artista(self,artista):
        self.__artista=artista
    def set_prezzo(self,prezzo):
        self.__prezzo=prezzo
    def set_annouscita(self,annouscita):
        self.__annouscita=annouscita
    def set_uscito(self,uscito):
        self.__uscito=uscito
        
    def modifica_prezzo(self,prezzo):
        self.set_prezzo(prezzo)
        
    def pubblica(self):
        self.__uscito=True
    
    def esploso(self):
        self.__uscito=False
        
    
    
    def __str__(self):
        return "nome: "+self.__nome+"\n artista: "+self.__artista+"\n prezzo: "+str(self.__prezzo)+"\n Anno Uscita: "+str(self.__annouscita)+"\n uscito: "+ str(self.__uscito)