n=int(input("сколько будет букв?"))
a=[]
for i in range(n):
    a.append([])
for i in range(n):
    for j in range(n):
        a[i].append(int(input()))
y=[]
for i in range(n):
    for j in range(i):
        if a[i][j]!=0:
            y.append(a[i][j])
y=sorted(y)
h=[]
for i in y:
    for j in range(n):
        for k in range(n):
            if a[j][k]==i:
                if sorted([j+1 , k+1]) not in h:
                    h.append(sorted([j+1 , k+1]))
pod=[]
for i in range(n):
    pod.append (str(i+1))
sump=0
for u in y:
    for i in range(n):
        for j in range(n):
            if a[i][j]==u:
                if pod[i][0] not in pod[j] or pod[j][0] not in pod[i]  :
                    pod[i]+=str(j+1)+str(i+1)+pod[j]; pod[i]="".join(sorted(set(pod[i])))
                    for g in pod[i]:
                            pod[int(g)-1]=pod[i]
                    sump+=u
print(sump)