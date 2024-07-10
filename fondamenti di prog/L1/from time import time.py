from time import time
from datetime import date
#timestamp restituisce il numero di secondi dal 01/01/1970
timestamp=time()
print("timestamp = ", timestamp)
d=date.fromtimestamp(timestamp)
print("date: ",d)
print(d.strftime("%d/%m/%Y %H:%M:%S"))

from datetime import time
t=time(14,53,20,1)
print("time:",t)
print("ora: ",t.hour)
print("minuti: ",t.minute)
print("secondi: ",t.second)
print("microsecondi: ",t.microsecond)



from datetime import datetime
miadata=datetime(2019,3,24)
oggi=datetime.today()
print("oggi: " ,oggi)
print("now: ", datetime.now())

print("differenza", oggi-miadata)