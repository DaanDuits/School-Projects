import os
import time
from random import randrange
factory = []
distribution = []
shop = []
while True:
    os.system("cls")
    shop.clear()
    factory.insert(1, "Phone")
    print("Factory: " + str(factory))
    print("Distribution: " + str(distribution))
    print("Shop: " + str(shop))
    factory.clear()
    distribution.insert(1, "Phone")
    time.sleep(1)
    os.system('cls')
    print("Factory: " + str(factory))
    print("Distribution: " + str(distribution))
    print("Shop: " + str(shop))
    distribution.clear()
    shop.insert(1, "Phone")
    time.sleep(1)
    os.system('cls')
    print("Factory: " + str(factory))
    print("Distribution: " + str(distribution))
    print("Shop: " + str(shop))
    time.sleep(1)
    r = randrange(1, 3)
    if r == 1:
        q = input("Repeat? Y/N ")
        if q == "Y":
            continue
        elif q == "N":
            break
    elif r == 2:
        shop.clear()
        os.system("cls")
        print("Factory: " + str(factory))
        print("Distribution: " + str(distribution))
        print("Shop: " + str(shop))
        q = input("Repeat? Y/N ")
        if q == "Y":
            continue
        elif q == "N":
            break

