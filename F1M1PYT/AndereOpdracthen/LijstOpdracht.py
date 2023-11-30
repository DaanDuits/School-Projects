List = [3.4, 2.8, 10.9, 3.7, 22.8, 1.1, 5.8, 11.3]
print(List)
print(List[0] + List[1] + List[2])
for I in List:
    print(I)
List.append(4.9)
print(List)
List.remove(3.7)
var1 = List.pop(2)
var2 = List.pop(0)
print(var1 + var2)
print(List)