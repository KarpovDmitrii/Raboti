a = open("C:/Users/User/Desktop/234.txt")
n,m=a.readline().split()
n=int(n)
m=int(m)
x,y,z=a.readline().split()
x=int(x)
y=int(y)
z=int(z)
k=[]
for i in range(m):
    k.append(a.readline().strip())
for q in k:
    A=q[0]
    t=q[-2]+q[-1]
    C=int(q.split()[1])
    if A=="Z" and z==C:
        if t==" 1":
            a=y
            y=n+1-x
            x=a
        if t=="-1":
            a=x
            x=n+1-y
            y=a
    elif A=="X" and x==C:
        if t==" 1":
            a=z
            z=n+1-y
            y=a
        if t=="-1":
            a=y
            y=n+1-z
            z=a
    elif A=="Y" and y==C:
        if t=="-1":
            a=x
            x=n+1-z
            z=a
        if t==" 1":
            a=z
            z=n+1-x
            x=a
print(x,y,z)