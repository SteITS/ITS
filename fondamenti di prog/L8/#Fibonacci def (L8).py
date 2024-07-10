#Fibonacci def (L8)

def Fibonacci():
    new=1
    old=0
    actual=0
    for i in range(0,25):
        actual=new+old
        new=old
        old=actual
        print(actual)

def main():
    Fibonacci()
main()