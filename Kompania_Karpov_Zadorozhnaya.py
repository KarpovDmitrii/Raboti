f=open("C:/Users/User/Desktop/13.txt")
n=f.readlines()
b=n[-1].strip()
n=n[0:-2]
a1={}
for i in range(0,len(n),2):
    a1[n[i].strip()]=[]
for i in range(0,len(n),2):
    a1[n[i].strip()].append(n[i+1].strip())
for i in a1:
    if b in str(i):
        b=i
a={}
for i in a1:
    if len(i)==4:
        for j in a1:
            if i in j and i!=j:
                a[j]=a1[i]+a1[j]
            if j in i and i!=j:
                a[i]=a1[i]+a1[j]
            else:
                for k in a1[j]:
                    if i in k:
                        a[k]=a1[i]
    else:
        a[i]=a1[i]
for i in a:
    for j in range(len(a[i])):
        if len(a[i][j])==4:
            for k in a:
                if a[i][j] in k:
                    a[i][j]=k
q=[]
if b not in a:
    print("no")
else:
    q+=a[b]
    for p in range(len(n)):
        for i in range(p, len(q)):
            if q[i] in a:
                q+=a[q[i]]
    q=sorted(set(q))
    for i in q:
        if len(i)==4:
            print(i+" unknown name")
        else:
            print(i)