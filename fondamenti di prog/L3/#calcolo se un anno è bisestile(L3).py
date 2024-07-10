#calcolo se un anno è bisestile
def main():
    import datetime
    print("calcolo anno bisestile")
    anno=int(input("inserisci un anno: "))
    if anno<1582:
        print("non e' un anno del calendario gregoriano")
    else:
        if(anno%100 !=0):
            print("anno bisestile")
        elif(anno%400 !=0):
            print("anno non bisestile")
        elif(anno%4!=0):
            print("anno non bisestile")
        else:
            print("anno bisestile")
main()