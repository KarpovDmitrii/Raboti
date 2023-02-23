n=int(input("сколько будет букв?"))
a=[]
for i in range(n):
    a.append([])
for i in range(n):
    for j in range(n):
        a[i].append(int(input()))
#a=[[0,2,2,0,7,0,0,0],[2,0,2,9,2,0,0,0],[2,2,0,0,5,0,0,0],[0,9,0,0,10,5,2,16],[7,2,5,10,0,0,9,0],[0,0,0,5,0,0,0,17],[0,0,0,2,9,0,0,17],[0,0,0,16,0,17,17,0]]
n=len(a)
s="1"
k=0
o=[]
for i in range(n):
    o.append(str(i+1))
while not (sorted(s)==o):
    b = []
    for i in s:
        i=int(i)
        for j in range(n):
            if a[i-1][j]!=0 and str(j+1) not in s:
                b.append(a[i-1][j])
    z=0

    for l in s:
        if z==0 and b!=[]:
            l=int(l)
            for j in range(n):
                if a[l-1][j]==min(b):
                    if str(j+1) not in s:
                        s+=str(j+1)
                        k+=min(b)
                        z=1
print(s, k, o)