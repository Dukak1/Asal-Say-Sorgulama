def Asalmi(x:int):
    flag = True
    if x == 2:
        return flag
    elif x % 2== 0:
        flag = False
    
    if flag:
        for i in range(3,int(x/2)):
            if x % i ==0:
                print(x,"sayısının",i,"sayısına bölümü:",x/i,"kalan ise 0'dır.")
                flag = False
                break
    return flag

x = int(input("Sayı girin : "))
print(Asalmi(x))