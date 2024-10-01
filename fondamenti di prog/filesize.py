import os
import random
file_name="abc.txt"
file_stats = os.stat(file_name)
f=open(file_name, "w")
while(file_stats.st_size / (1024 * 1024) < 1):
    file_stats = os.stat(file_name)
    f.write(random.choice('ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789'))
f.close
print(f'File Size in MegaBytes is {file_stats.st_size / (1024 * 1024)}')
