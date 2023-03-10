import math
f=open("C:/Users/Алина/Desktop/вход.txt")
a,b,c=map(int,f.readline().strip().split())
sx,sy,sz=map(int,f.readline().strip().split())
fx,fy,fz=map(int,f.readline().strip().split())
s=0
if (sx==fx and (sx==a or sx==0)) or (sy==fy and( sy==b or sy==0)) or (sz==fz and (sz==0 or sz==c)):
    s=math.sqrt((sx-fx)**2+(sy-fy)**2+(sz-fz)**2)
elif (abs(sx-fx)==a):
    s1=math.sqrt((sy - fy)**2 + (sz + a + fz) **2)
    s2=math.sqrt((sy - fy)**2 + (2*c - fz + a - sz)**2)
    s3=math.sqrt((sz - fz)**2 + (sy + a + fy)**2)
    s4=math.sqrt((sz - fz) * (sz - fz) + (2*b - fy + a - sy)**2);
    s = min(s1,s2,s3,s4);
elif ((abs(sy-fy))==b):
    s1=math.sqrt((fx-sx)**2 + (fz+sz+b)**2)
    s2=math.sqrt((sx-fx)**2+(2*c-fz-sz+b)**2)
    s3=math.sqrt((sz - fz)**2+ (sx + b + fx)**2)
    s4=math.sqrt((sz - fz)**2+ (2*a - fx + b - sx)**2)
    s = min(s1,s2,s3,s4);
elif (abs(sz-fz)==c):
    s1=math.sqrt((sx-fx)**2+ (sy + c + fy) **2)
    s2=math.sqrt((sx-fx)**2 + (2*b - fy +c - sy)**2)
    s3=math.sqrt((sy-fy)**2 + (sx + c + fx)**2)
    s4=math.sqrt((sy-fy)**2 + (2*a - fx + c - sx)**2)
    s = min(s1,s2,s3,s4);
elif (sx==0 or sx==a or sy==0 or sy==b) and sz!=0 and sz!=c and fz!=c and fz!=0:
    s=math.sqrt((abs(fy-sy)+abs(sx-fx))**2+(fz-sz)**2)
elif sz==0 or sz==c:
    if fy==0 or fy==b:
        s=math.sqrt((abs(fy-sy)+abs(sz-fz))**2+(fx-sx)**2)
    elif fx==0 or fx==a:
        s=math.sqrt((abs(fx-sx)+abs(sz-fz))**2+(fy-sy)**2)
elif fz==0 or fz==c:
    if sy==0 or sy==b:
        s=math.sqrt((abs(sy-fy)+abs(sz-fz))**2+(fx-sx)**2)
    elif sx==0 or sx==a:
        s=math.sqrt((abs(fx-sx)+abs(sz-fz))**2+(fy-sy)**2)
print(round(s,3))