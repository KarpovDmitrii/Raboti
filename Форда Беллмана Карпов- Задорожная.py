from pprint import pprint
n=int(input("сколько будет точек?"))
v=int(input("какая вершина интересует?"))-1
a=[]
inf=float("Inf")
a=[[inf,1,inf,inf,3],[inf,inf,8,7,1],[inf,inf,inf,1,-5],[inf,inf,2,inf,inf],[inf,inf,inf,4,inf]]
b=[]
for i in range(n):
    a.append([])
    b.append([])
b.append([])
for i in range(n):
    for j in range(n):
        inp=input()
        if inp =="inf":
            inp=float("Inf")
        a[i].append(int(inp))
for i in range(n):
    if i==v:
        b[0].append(0)
    else:
        b[0].append(inf)
for i in range(1,n+1):
    for j in range(n):
        m=[]
        for k in range(n):
            m.append(min(b[i-1][k]+a[k][j], b[i-1][j]))
        b[i].append(min(m))
if b[-1]!=b[-2]:
    print("отрицательный цикл")
else:
    print(b[-1])


