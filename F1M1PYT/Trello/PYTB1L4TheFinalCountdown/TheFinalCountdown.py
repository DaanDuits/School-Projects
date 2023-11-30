import time
import webbrowser
I = 10000
print(I)
while(I > 0):
    I -= 1
    print(I)
if I == 0:
    webbrowser.open("https://www.youtube.com/watch?v=pFDiev2mNps", new=1)