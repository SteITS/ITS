class Squadra:
    def __init__(self,V:int,S:int,P:int,GF:int,GS:int):
        self.__V=V
        self.__S=S
        self.__P=P
        self.__GF=GF
        self.__GS=GS
        
        
    def get_V(self):
        return self.__V
    def get_S(self):
        return self.__S
    def get_P(self):
        return self.__P
    def get_GF(self):
        return self.__GF
    def get_GS(self):
        return self.__GS
    
    def set_V(self,V):
        self.__V=V
    def set_S(self,S):
        self.__S=S
    def set_P(self,P):
        self.__P=P
    def set_GF(self,GF):
        self.__GF=GF
    def set_GS(self,GS):
        self.__GS=GS
        
    def punti(self):
        return self.get_V() * 3 + self.get_P()
    
    def inizioanno(self):
        self.set_V(0)
        self.set_S(0)
        self.set_P(0)
        self.set_GF(0)
        self.set_GS(0)
        