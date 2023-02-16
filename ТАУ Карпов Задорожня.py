def d (a):
   b=""
   if len(a)%2==0:
      nach=int(len(a)/2)
   else:
      nach=int(len(a)/2)
   
   b+=a[nach]
   for i in range(1, len(a)):
      if i%2==1:
         b+=a[nach-i]
         nach-=i
      if i%2==0:
         b+=a[nach+i]
         nach+=i
   return b
a=input()
a=a.split()
b=[]
if len(a)%2==0:
   nach=int(len(a)/2)
else:
   nach=int(len(a)/2)

b.append(a[nach])
for i in range(1, len(a)):
   if i%2==1:
      b.append(a[nach-i])
      nach-=i
   if i%2==0:
      b.append(a[nach+i])
      nach+=i
q=""
for i in range(len(b)):
   q+=d(b[i])+" "
print(q)