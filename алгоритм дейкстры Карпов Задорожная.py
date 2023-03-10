x,y=map(int, input("точка 1 и точка 2 ").split())
x-=1
y-=1
n=int(input("сколько будет точек? "))
a=[]
for i in range(n):
    a.append([])
m=[]
for i in range(n):
    for j in range(n):
        inp=int(input())
        a[i].append(inp)
        m.append(inp)
rast=[]
pos=[]
for i in range(n):
    rast.append(max(m)**10)
    pos.append(0)
rast[x]=0
for i in range(5):
    m=[]
    x1=x
    for i in range(n):
        if a[x][i]!=0 and pos[i]==0:
            rast[i]=min(rast[i],rast[x]+a[x][i])
            m.append(a[x][i])
            if min(m)==a[x][i]:
                x1=i
        pos[x]=1
    x=x1
print(rast[y])
