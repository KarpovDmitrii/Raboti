using System.Runtime.Intrinsics.X86;

public class Kniga
{
    public string fio;
    public string name;
    public string idname;
    public string godizd;
    public string nameizd;
    public string janr;
    public string[] vd;
    public Kniga(string fio, string name, string idname, string godizd, string nameizd, string janr, string[] vd)
    {
        this.fio = fio;
        this.name = name;
        this.idname = idname;
        this.godizd = godizd;
        this.nameizd = nameizd;
        this.janr = janr;
        this.vd = vd;
    }
    public void Deconstruct(out string ofio, out string oname, out string oidname, out string ogodizd, out string onameizd, out string ojanr, out string[] ovd)
    {
        ofio = fio;
        oname = name;
        oidname = idname;
        ogodizd = godizd;
        onameizd = nameizd;
        ojanr = janr;
        ovd= vd;
    }
}
class Program{
    static void Izdatelstvo( Kniga[] a)
    {
        Console.WriteLine("какое издательство вас интересует");
        string izd = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string oname, string oidname, string ogodizd, string onameizd, string ojanr, string[] ovd) = a[i];
            if (onameizd == izd)
            {
                Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
            }
        }

    }
    static void Avtor( Kniga[] a)
    {
        Console.WriteLine("какой автор вас интересует");
        string avt=Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string oname, string oidname, string ogodizd, string onameizd, string ojanr, string[] ovd) = a[i];
            if (ofio == avt)
            {
                Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
            }
        }

    }
    static void Janrviborka( Kniga[] a)
    {
        Console.WriteLine("какой автор вас интересует");
        string janr = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string oname, string oidname, string ogodizd, string onameizd, string ojanr, string[] ovd) = a[i];
            if (ojanr == janr)
            {
                Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
            }
        }

    }
    static void Naruk( Kniga[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string oname, string oidname, string ogodizd, string onameizd, string ojanr, string[] ovd) = a[i];
            if (ovd[ovd.Length-1]=="99.99.9999")
            {
                Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
            }
        }
    }
    static void Narukvmoment(Kniga[] a, string dv, string ds)
    {
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string oname, string oidname, string ogodizd, string onameizd, string ojanr, string[] ovd) = a[i];
            for (int j=0; j< ovd.Length; j+=2)
            {
                string tdv = ovd[j];
                string tds = ovd[j+1];
                int p = 0;
                if ((Convert.ToInt32(Convert.ToString(tdv[6]) + Convert.ToString(tdv[7]) + Convert.ToString(tdv[8]) + Convert.ToString(tdv[9]))) == (Convert.ToInt32(Convert.ToString(dv[6]) + Convert.ToString(dv[7]) + Convert.ToString(dv[8]) + Convert.ToString(dv[9]))))
                {
                    if ((Convert.ToInt32(Convert.ToString(tdv[3]) + Convert.ToString(tdv[4]))) > (Convert.ToInt32(Convert.ToString(dv[3]) + Convert.ToString(dv[4]))))
                    {
                        p++; 
                    }
                    else if (((Convert.ToInt32(Convert.ToString(tdv[3]) + Convert.ToString(tdv[4]))) == (Convert.ToInt32(Convert.ToString(dv[3]) + Convert.ToString(dv[4])))))
                    {
                        if ((Convert.ToInt32(Convert.ToString(tdv[0]) + Convert.ToString(tdv[1]))) > (Convert.ToInt32(Convert.ToString(dv[0]) + Convert.ToString(dv[1]))))
                        {
                            p++;
                        }
                    }

                }
                else if ((Convert.ToInt32(Convert.ToString(tdv[6]) + Convert.ToString(tdv[7]) + Convert.ToString(tdv[8]) + Convert.ToString(tdv[9]))) > (Convert.ToInt32(Convert.ToString(dv[6]) + Convert.ToString(dv[7]) + dv[8] + dv[9])))
                {
                    p++;
                }
                if ((Convert.ToInt32(Convert.ToString(tds[6]) + Convert.ToString(tds[7]) + Convert.ToString(tds[8]) + Convert.ToString(tds[9]))) == (Convert.ToInt32(Convert.ToString(ds[6]) + Convert.ToString(ds[7]) + Convert.ToString(ds[8]) + Convert.ToString(ds[9]))))
                {
                    if ((Convert.ToInt32(Convert.ToString(tds[3]) + Convert.ToString(tds[4]))) < (Convert.ToInt32(Convert.ToString(ds[3]) + Convert.ToString(ds[4]))) && p==1)
                    {
                         Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
                        
                    }
                    else if ((Convert.ToInt32(Convert.ToString(tds[3]) + Convert.ToString(tds[4]))) == (Convert.ToInt32(Convert.ToString(ds[3]) + Convert.ToString(ds[4]))))
                    {
                        if ((Convert.ToInt32(Convert.ToString(tds[0]) + Convert.ToString(tds[1]) )) < (Convert.ToInt32(Convert.ToString(ds[0]) + Convert.ToString(ds[1]))) && p==1)
                        {
                            Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
                        }
                    }
                }
                if (((Convert.ToInt32(Convert.ToString(tds[6]) + Convert.ToString(tds[7]) + Convert.ToString(tds[8]) + Convert.ToString(tds[9]))) < (Convert.ToInt32(Convert.ToString(ds[6]) + Convert.ToString(ds[7]) + Convert.ToString(ds[8]) + Convert.ToString(ds[9])))) && p!=0)
                {
                    Console.WriteLine($"{ofio} {oname} {oidname} {ogodizd} {onameizd} {ojanr}");
                }
            }
        }
    }
    static void Zapolnenie(int n, Kniga[] a)
    {
        string fio;
        string name;
        string idname;
        string godizd;
        string nameizd;
        string janr;
        for (int i = 1; i < n+1;i++)
        {
            Console.WriteLine($"Книга №{i}");
            Console.WriteLine("Напишите ФИО автора");
            fio = Console.ReadLine();
            Console.WriteLine("Напишите название книги");
            name = Console.ReadLine();
            Console.WriteLine("Напишите идентификационный номер");
            idname = Console.ReadLine();
            Console.WriteLine("Напишите год издания");
            godizd = Console.ReadLine();
            Console.WriteLine("Напишите наименование издательства");
            nameizd = Console.ReadLine();
            Console.WriteLine("Напишите жанр");
            janr= Console.ReadLine();
            Console.WriteLine("Сколько раз книга была выдана? (дата в формате **.**.****");
            int m = 2*Convert.ToInt32(Console.ReadLine());
            string[] vd = new string[m];
            for (int j = 0; j < m; j+=2)
            {
                Console.WriteLine("напишите дату выдачи");
                vd[j] = Console.ReadLine();
                Console.WriteLine("напишите дату сдачи(если книга не сдана, напишите -)");

                string q = Console.ReadLine();
                if (q == "-") q = "99.99.9999";
                vd[j + 1] = q;
            }
            Kniga k = new Kniga(fio, name, idname, godizd, nameizd, janr, vd);
            a[i-1] = k;
            Console.Clear();
        }
    }
    static void Main()
    {
        Console.WriteLine("Сколько будет книг?");
        int n = Convert.ToInt32(Console.ReadLine());
        Kniga[] a = new Kniga[n]; 
        Console.Clear();
        Zapolnenie(n,a);
        bool t = true;
        while (t==true){
            Console.WriteLine("Выборки:\n1. Издательство \n2. Автор \n3. Жанр \n4. Книги на руках \n5. Книги выбшие на руках в заданном интервале \n6. Завершение программы");
            int w = Convert.ToInt32(Console.ReadLine());
            if (w == 1)
            {
                Izdatelstvo(a);
                Thread.Sleep(4000);
            }
            if (w == 2)
            {
                Avtor(a);
                Thread.Sleep(4000);
            }
            if (w == 3)
            {
                Janrviborka(a);
                Thread.Sleep(4000);
            }
            if (w == 4)
            {
                Naruk(a);
                Thread.Sleep(4000);
            }
            if (w == 5)
            {
                Console.WriteLine("Напишите даты интервала в формате **.**.****");
                string z= Console.ReadLine();
                string x= Console.ReadLine();
                Narukvmoment(a,z,x);
                Thread.Sleep(4000);
            }
            if (w == 6)
            {
                return;
            }

        }
    }
}