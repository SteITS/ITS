class lampadina:
    def __init__(self,acceso:False,clicks:int):
        self.__acceso=acceso
        self.__clicks=clicks
        
    #metodi getter
    def get_acceso(self):
        return self.__acceso
    def get_clicks(self):
        return self.__clicks
    
    #metodi setter
    def set_acceso(self,acceso):
        self.__acceso=acceso
    def set_clicks(self,clicks):
        self.__clicks=clicks
        
    def __str__(self):
        return "acceso: "+str(self.__acceso)
    
    def Pulsante_Accensione(self):
        if self.__acceso==False:
            self.__acceso=True;
        else:
            self.__acceso=False;
            
    def Num_Accensione(self):
        self.set_clicks(self.__clicks-1);