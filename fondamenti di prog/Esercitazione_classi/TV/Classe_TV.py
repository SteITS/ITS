class TV:
    def __init__(self,acceso:False,volume:int,canale:int,silenzioso:False):
        self.__acceso=acceso
        self.__volume=volume
        self.__canale=canale
        self.__silenzioso=silenzioso
        
    #metodi getter
    def get_acceso(self):
        return self.__acceso
    def get_volume(self):
        return self.__volume
    def get_canale(self):
        return self.__canale
    def get_silenzioso(self):
        return self.__silenzioso
    
    #metodi setter
    def set_acceso(self,acceso):
        self.__acceso=acceso
    def set_volume(self,volume):
        self.__volume=volume
    def set_canale(self,canale):
        self.__canale=canale
    def set_silenzioso(self,silenzioso):
        self.__silenzioso=silenzioso
        
    def Pulsante_Accensione(self):
        if self.__acceso==False:
            self.__acceso=True;
        else:
            self.__acceso=False;
            
    def Imposta_Canale(self,canale):
        self.set_canale(canale)
        
    def Canale_Successivo(self):
        if self.get_canale() < 99:
            self.set_canale(self.__canale+1);
        else:
            self.set_canale(0);
            
    def Canale_Precedente(self):
        if self.get_canale() > 0:
            self.set_canale(self.__canale-1);
        else:
            self.set_canale(99);
        
    def Aumenta_Volume(self):
        if self.get_volume() < 10:
            self.set_volume(self.__volume+1)
            
    def Abbassa_Volume(self):
        if self.get_volume() > 0:
            self.set_volume(self.__volume-1)
    
    def Pulsante_Silenzioso(self):
        if self.get_silenzioso()==False:
            self.set_silenzioso(True)
        else:
            self.set_silenzioso(False)
        
    def __str__(self):
        return "acceso: "+str(self.__acceso)+"\n volume: "+str(self.__volume)+"\n canale: "+str(self.__canale)+"\n silenzioso: "+str(self.__silenzioso)