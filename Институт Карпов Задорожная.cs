using static System.Net.Mime.MediaTypeNames;

public class Vspom
{
    public string fio;
    public Vspom(string fio)
    {
        this.fio = fio;
    }
    public void Deconstruct(out string ofio)
    {
        ofio = fio;
    }
}
public class Uprav : Vspom
{
    public string[,] prikazi;
    public Uprav(string fio, string[,] prikazi) : base(fio)
    {
        this.prikazi = prikazi;
    }
    public void Deconstruct(out string ofio, out string[,] oprikazi)
    {
        ofio = fio;
        oprikazi = prikazi;
    }
}
public class Prep : Vspom
{
    public string[] predmeti;
    public string[,] mesrab;
    public int stag;
    public Prep(string fio, string[] predmeti, string[,] mesreb, int stag) : base(fio)
    {
        this.predmeti = predmeti;
        this.mesrab = mesreb;
        this.stag = stag;
    }
    public void Deconstruct(out string ofio, out string[] opredmeti, out string[,] omesreb, out int ostag)
    {
        ofio = fio;
        opredmeti = predmeti;
        omesreb = mesrab;
        ostag = stag;
    }
}
public class Stud : Vspom
{
    public string[,] ocenki;
    public Stud(string fio, string[,] ocenki) : base(fio)
    {
        this.ocenki = ocenki;
    }
    public void Deconstruct(out string ofio, out string[,] oocenki)
    {
        ofio = fio;
        oocenki = ocenki;
    }
}
class Program
{
    static void DolgStud(Stud[] a)
    {
        int ok = 0;
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string[,] oocenki) = a[i];
            for (int j = 0; j < oocenki.Length / 3; j++)
            {
                if (oocenki[j, 2] == "2")
                {
                    Console.WriteLine($"студент {ofio} , преподаватель {oocenki[j, 0]}, предмет {oocenki[j, 1]}, оценка {oocenki[j, 2]}");
                    ok++;
                }
            }
        }
        if (ok == 0) Console.WriteLine("пусто");
    }
    static void DolgPrep(Stud[] a)
    {
        int ok = 0;
        Console.WriteLine("Введите ФИО преподавателя");
        string prepodovatel = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string[,] oocenki) = a[i];
            for (int j = 0; j < oocenki.Length / 3; j++)
            {
                if (oocenki[j, 2] == "2" && oocenki[j, 0] == prepodovatel)
                {
                    Console.WriteLine($"студент {ofio} , преподователь {oocenki[j, 0]}, предмет {oocenki[j, 1]}, оценка {oocenki[j, 2]}");
                    ok++;
                }
            }
        }
        if (ok == 0) Console.WriteLine("пусто");
    }
    static void Predmeti(Prep[] a)
    {
        int ok = 0;
        Console.WriteLine("Введите ФИО преподавателя");
        string prepodovatel = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string[] opredmeti, string[,] omesrab, int ostag) = a[i];
            if (ofio == prepodovatel)
            {
                for (int j = 0; j < opredmeti.Length; j++)
                {
                    Console.WriteLine($"{opredmeti[j]}");
                    ok++;
                }
            }
        }
        if (ok == 0) Console.WriteLine("пусто");
    }
    static void Prikazi(Uprav[] a)
    {
        int ok = 0;
        Console.Write("Приказы выданные (всем/преподавателям/студентам/вспомогательному): ");
        string komu = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string[,] oprikazi) = a[i];
            for (int j = 0; j < oprikazi.Length / 2; j++)
            {
                if (oprikazi[j, 0] == komu)
                {
                    Console.WriteLine($"{ofio}, приказ {oprikazi[j, 1]}");
                    ok++;
                }
            }
        }
        if (ok == 0) Console.WriteLine("пусто");
    }
    static void Stag(Prep[] a)
    {
        int ok = 0;
        Console.WriteLine("Введите ФИО преподавателя");
        string pr = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            (string ofio, string[] predmeti, string[,] mesrab, int stag) = a[i];
            if (ofio == pr)
            {
                Console.WriteLine(mesrab[mesrab.Length / 3 - 1, 1].Substring(6, 4));
                int stagnp = 2023 - Convert.ToInt32(mesrab[mesrab.Length / 3 - 1, 1].Substring(6, 4));
                Console.WriteLine($"общий стаж: {stag}, стаж работы в ОмГТУ: {stagnp}");
                ok++;
            }
        }
        if (ok == 0) Console.WriteLine("пусто");
    }
    static void Main()
    {
        StreamReader sr = new StreamReader("C:\\Users\\Алина\\Desktop\\13.txt");
        int n = Convert.ToInt32(sr.ReadLine());
        Vspom[] vsp = new Vspom[n];
        for (int i = 0; i < n; i++)
        {
            string o = sr.ReadLine();
            Vspom v = new Vspom(o);
            vsp[i] = v;
        }

        n = Convert.ToInt32(sr.ReadLine());
        Uprav[] upr = new Uprav[n];
        for (int i = 0; i < n; i++)
        {
            string fio = sr.ReadLine();
            int m = Convert.ToInt32(sr.ReadLine());
            string[,] prik = new string[m, 2];
            for (int j = 0; j < m; j++)
            {
                string k = sr.ReadLine();
                string p = sr.ReadLine();
                prik[j, 0] = k;
                prik[j, 1] = p;
            }
            Uprav u = new Uprav(fio, prik);
            upr[i] = u;
        }

        n = Convert.ToInt32(sr.ReadLine());
        Prep[] prepod = new Prep[n];
        for (int i = 0; i < n; i++)
        {
            string fio = sr.ReadLine();
            int m = Convert.ToInt32(sr.ReadLine());
            string[] predmet = new string[m];
            for (int j = 0; j < m; j++)
            {
                predmet[j] = sr.ReadLine();
            }
            int k = Convert.ToInt32(sr.ReadLine());
            string[,] mr = new string[k, 3];
            for (int j = 0; j < k; j++)
            {
                mr[j, 0] = sr.ReadLine();
                mr[j, 1] = sr.ReadLine();
                mr[j, 2] = sr.ReadLine();
            }
            int st = Convert.ToInt32(sr.ReadLine());
            Prep v = new Prep(fio, predmet, mr, st);
            prepod[i] = v;
        }

        n = Convert.ToInt32(sr.ReadLine());
        Stud[] studen = new Stud[n];
        for (int i = 0; i < n; i++)
        {
            string fio = sr.ReadLine();
            int m = Convert.ToInt32(sr.ReadLine());
            string[,] zena = new string[m, 3];
            for (int j = 0; j < m; j++)
            {
                zena[j, 0] = sr.ReadLine();
                zena[j, 1] = sr.ReadLine();
                zena[j, 2] = sr.ReadLine();
            }
            Stud v = new Stud(fio, zena);
            studen[i] = v;
        }
        bool t = true;
        while (t == true)
        {
            Console.WriteLine("\n1.Список всех студентов, у которых есть долги \n2.Список студентов, у которых есть долги у определённого преподавателя \n3.Приказы" +
               "\n4.Список дисциплин, которые ведёт определённый преподаватель \n5.Общий стаж работы преподавателя и стаж его работы в ОмГТУ \n6.Завершение программы");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (w == 1)
            {
                DolgStud(studen);
                Thread.Sleep(4000);
            }
            if (w == 2)
            {
                DolgPrep(studen);
                Thread.Sleep(4000);
            }
            if (w == 3)
            {
                Prikazi(upr);
                Thread.Sleep(4000);
            }
            if (w == 4)
            {
                Predmeti(prepod);
                Thread.Sleep(4000);
            }
            if (w == 5)
            {
                Stag(prepod);
                Thread.Sleep(4000);
            }
            if (w == 6)
            {
                return;
            }
        }
    }
}