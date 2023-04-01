from pprint import pprint
n=int(input("сколько будет точек?"))
a=[]
for i in range(n):
    a.append([])
for i in range(n):
    for j in range(n):
        inp=input()
        if inp =="inf":
            inp=float("Inf")
        a[i].append(int(inp))
for k in range(len(a)):
    for i in range(len(a)):
        for j in range(len(a)):
            if i == j:
                continue
            else:
                a[i][j] = min(a[i][k] + a[k][j], a[i][j])
pprint(a)