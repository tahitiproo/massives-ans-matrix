using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZZZina_graFFF
{
    class Program
    {
        struct Studentik
        {
            public string surName, name,nameExam;
            public short yearBirth,sumCounts;
        }
        struct Zhitelb
        {
            public string imya;
            public short nomerPassporta;
            public string trabla;
            public (byte,byte) tarakaniVGolove;
            public Zhitelb(string Imya,short NomerPassporta,string Trabla, (byte,byte) TarakaniVGolove)
            {
                imya = Imya;
                nomerPassporta = NomerPassporta;
                trabla = Trabla;
                tarakaniVGolove = TarakaniVGolove;
            }
        }
        enum Problemi_heating
        {
           Не_подключено_отопление = 1,
           Недостаточный_обогрев,
           Лопнула_батарея,
        }
        enum Problemi_onlati
        {
            Неизвестен_номер_лицевого_счёта = 4,
            Не_выполняется_оплата_онлайн,
        }
        enum Problemi_else
        {
            Получить_справку = 6,
            Записаться_на_тех_обслуживание,
            Встать_на_учёт,
        }
        static void Main(string[] args)
        {
            /*
            Dictionary<(string,string), Studentik> ycheniki = new Dictionary<(string,string), 
                Studentik>();

            Studentik chel1 = new Studentik() { surName = "Морозов", name = "Даниил", 
                yearBirth = 2005, nameExam = "Информатика", sumCounts = 83 };
            Studentik chel2 = new Studentik() { surName = "Сагдуллин", name = "Амир", 
                yearBirth = 2004, nameExam = "Информатика", sumCounts = 85 };
            Studentik chel3 = new Studentik() { surName = "Арсентьев", name = "Кирилл", 
                yearBirth = 2004, nameExam = "Физика", sumCounts = 78 };
            Studentik chel4 = new Studentik() { surName = "Митрофанов", name = "Леонид", 
                yearBirth = 2004, nameExam = "Информатика", sumCounts = 88 };
            Studentik chel5 = new Studentik() { surName = "Саитов", name = "Марат", 
                yearBirth = 2004, nameExam = "Информатика", sumCounts = 74 };
            Studentik chel6 = new Studentik() { surName = "Хамитов", name = "Ринат", 
                yearBirth = 2004, nameExam = "Информатика", sumCounts = 70 };
            Studentik chel7 = new Studentik() { surName = "Макарова", name = "Дарья", 
                yearBirth = 2004, nameExam = "Информатика", sumCounts = 83 };
            Studentik chel8 = new Studentik() { surName = "Иванова", name = "Карина", 
                yearBirth = 2004, nameExam = "Информатика", sumCounts = 90 };
            Studentik chel9 = new Studentik() { surName = "Шапошникова", name = "Екатерина", 
                yearBirth = 2004, nameExam = "Немецкий язык", sumCounts = 96 };
            Studentik chel10 = new Studentik() { surName = "Агиева", name = "Лилия", 
                yearBirth = 2004, nameExam = "Английский язык", sumCounts = 94 };

            ycheniki.Add((chel1.surName, chel1.name),chel1);
            ycheniki.Add((chel2.surName, chel2.name), chel2);
            ycheniki.Add((chel3.surName, chel3.name), chel3);
            ycheniki.Add((chel4.surName, chel4.name), chel4);
            ycheniki.Add((chel5.surName, chel5.name), chel5);
            ycheniki.Add((chel6.surName, chel6.name), chel6);
            ycheniki.Add((chel7.surName, chel7.name), chel7);
            ycheniki.Add((chel8.surName, chel8.name), chel8);
            ycheniki.Add((chel9.surName, chel9.name), chel9);
            ycheniki.Add((chel10.surName, chel10.name), chel10);
            Console.WriteLine("Введите слово: \nНовый студент - чтобы добавить кого-то в лист" +
                "\nУдалить - чтобы удалить кого-то с листа"+
                "\nСортировать - чтобы выполнить сортировку по баллам");
            string op = Console.ReadLine();
            try
            {
                if (op.Equals("новый студент") || op.Equals("Новый студент") || op.Equals("новыйстудент") || op.Equals("Новыйстудент"))
                {
                    Studentik novichok = new Studentik();
                    Console.Write("Введите фамилию: ");
                    novichok.surName = Console.ReadLine();
                    Console.Write("Введите имя: ");
                    novichok.name = Console.ReadLine();
                    Console.Write("Введите год рождения: ");
                    novichok.yearBirth = short.Parse(Console.ReadLine());
                    Console.Write("Введите предмет по выбору: ");
                    novichok.nameExam = Console.ReadLine();
                    Console.Write("Введите кол-во баллов за предмет");
                    novichok.sumCounts = short.Parse(Console.ReadLine());
                    ycheniki.Add((novichok.surName, novichok.name), novichok);
                    Console.WriteLine("Обновлённый список: ");
                    foreach(var k in ycheniki)
                    {
                        Console.WriteLine("{0} {1}",k.Value.surName,k.Value.name);
                    }
                }
                else if (op.Equals("Удалить") | op.Equals("удалить"))
                {
                    Console.WriteLine("Введите через фамилию и имя человека, которого вы хотите удалить из списка");
                    (string, string) ydoli;
                    Console.Write("Введите фамилию человека, которого вы хотите удалить: ");
                    ydoli.Item1 = Console.ReadLine();
                    Console.Write("Введите имя человека, которого вы хотите удалить: ");
                    ydoli.Item2 = Console.ReadLine();
                    ycheniki.Remove(ydoli);
                    Console.WriteLine("Обновленный список: ");
                    foreach (var k in ycheniki)
                    {
                        Console.WriteLine("{0} {1}", k.Value.surName, k.Value.name);
                    }
                }
                else if (op.Equals("Сортировать") | op.Equals("сортировать"))
                {
                    Console.WriteLine("Отсортированный список");
                    var sorted = ycheniki.OrderBy(x => x.Value.sumCounts);
                    foreach (var k   in sorted)
                    {
                        Console.WriteLine($"{k.Value.name}, {k.Value.surName}, {k.Value.yearBirth}, {k.Value.nameExam}, {k.Value.sumCounts}");
                    }
                }
                else
                {
                    Console.WriteLine("Такой опции в меню не существует");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ваш запрос некорректен");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            
            Console.WriteLine("Упражнение 2");
            try
            {
                Console.WriteLine("Введите оценку рефери от 0 до 9 команде Bavarian Beer Bears через пробел");
                int[] bavarianbeerbears = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                Console.WriteLine("Введите оценку рефери от 0 до 9 команде Scandinavian Schollers через пробел");
                int[] scandinavianschollers = Console.ReadLine().Split().Select(y => int.Parse(y)).ToArray();
                Console.WriteLine(PivoZavr(bavarianbeerbears, scandinavianschollers));
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибка!!! Введи целые числа через пробел.");
            }
            */
            
            Console.WriteLine("Мать его ЖЭК");
            Zhak();

            Console.WriteLine("Граф");

            Graf();
        }
        static void Zhak()
        {
            string fileName1 = @"C:\Users\Username\source\repos\struct\ZZZina_graFFF\TextFile1.txt";
            string[] file1 = File.ReadAllText(fileName1).Split(',').ToArray();

            string fileName2 = @"C:\Users\Username\source\repos\struct\ZZZina_graFFF\TextFile2.txt";
            string[] file2 = File.ReadAllText(fileName2).Split(',').ToArray();

            string fileName3 = @"C:\Users\Username\source\repos\struct\ZZZina_graFFF\TextFile3.txt";
            string[] file3 = File.ReadAllText(fileName3).Split(',').ToArray();

            string fileName4 = @"C:\Users\Username\source\repos\struct\ZZZina_graFFF\TextFile4.txt";
            string[] file4 = File.ReadAllText(fileName4).Split(',').ToArray();

            string fileName5 = @"C:\Users\Username\source\repos\struct\ZZZina_graFFF\TextFile5.txt";
            string[] file5 = File.ReadAllText(fileName5).Split(',').ToArray();
            
            Zhitelb zhitel1 = new Zhitelb(file1[0], short.Parse(file1[1]), file1[2], (byte.Parse(file1[3]), byte.Parse(file1[4])));
            Zhitelb zhitel2 = new Zhitelb(file2[0], short.Parse(file2[1]), file2[2], (byte.Parse(file2[3]), byte.Parse(file2[4])));
            Zhitelb zhitel3 = new Zhitelb(file3[0], short.Parse(file3[1]), file3[2], (byte.Parse(file3[3]), byte.Parse(file3[4])));
            Zhitelb zhitel4 = new Zhitelb(file4[0], short.Parse(file4[1]), file4[2], (byte.Parse(file4[3]), byte.Parse(file4[4])));
            Zhitelb zhitel5 = new Zhitelb(file5[0], short.Parse(file5[1]), file5[2], (byte.Parse(file5[3]), byte.Parse(file5[4])));
            Stack<Zhitelb> peredZinoy = new Stack<Zhitelb>();

            peredZinoy.Push(zhitel1);
            peredZinoy.Push(zhitel2);
            peredZinoy.Push(zhitel3);
            peredZinoy.Push(zhitel4);
            peredZinoy.Push(zhitel5);

            LinkedList<string> oknootopl = new LinkedList<string>();
            LinkedList<string> oknodenbgi = new LinkedList<string>();
            LinkedList<string> oknosprositb = new LinkedList<string>();

            while (peredZinoy.Count > 0)
            {
                Zhitelb chel = peredZinoy.Pop();
                byte skandalist = chel.tarakaniVGolove.Item1;
                string ima = chel.imya;
                string fraza = chel.trabla;
                byte intel = chel.tarakaniVGolove.Item2;
                if (intel == 0)
                {
                    Random rnd = new Random();
                    int sluch = rnd.Next(1, 4);
                    if (sluch == 1)
                    { Ochered(ref oknodenbgi, skandalist, ima); }
                    else if (sluch == 2)
                    { Ochered(ref oknootopl, skandalist, ima); }
                    else
                    { Ochered(ref oknosprositb, skandalist, ima); }
                }
                else if (fraza.Contains("payment") || fraza.Contains("деньги") || fraza.Contains("account") || fraza.Contains("карт"))
                { Ochered(ref oknodenbgi, skandalist, ima); }
                else if (fraza.Contains("подключено") || fraza.Contains("недостаточно") || fraza.Contains("heating") || fraza.Contains("battery"))
                { Ochered(ref oknootopl, skandalist, ima); }
                else
                { Ochered(ref oknosprositb, skandalist, ima); }
            }
            Console.WriteLine("Очередь в денежное окно");
            foreach (string ocher in oknodenbgi)
            {
                Console.WriteLine(ocher);
            }
            Console.WriteLine("Очередь в окно отопления");
            foreach (string ocher in oknootopl)
            {
                Console.WriteLine(ocher);
            }
            Console.WriteLine("Очередь в окно гадов, которым только спросить");
            foreach (string ocher in oknosprositb)
            {
                Console.WriteLine(ocher);
            }
        }
        static void Ochered(ref LinkedList<string> a, byte skand,string ima)
        {
            if (skand < 5)
                a.AddLast(ima);

            else if (skand >= 5)
            {
                Console.WriteLine("На сколько человек хотите обогнать?");
                byte obgon = byte.Parse(Console.ReadLine());

                if (a.Count <= obgon)
                {
                    a.AddFirst(ima);
                }
                else
                {
                    Vper(ref a, obgon, ima);
                }
            }
        }
        static void Vper(ref LinkedList<string> a, int b, string y)
        {   
            int len = a.Count;
            int count = 0;
            foreach(string s in a)
            {
                count++;
                if(len - b == count)
                {
                    a.AddAfter(a.Find(s), y);
                    return;
                }
            }
        }
        static string Type_problem(int k, Random x)
        {
            if (k < 4)
            {
                return Enum.GetName(typeof(Problemi_heating), x.Next(1, 4));
            }
            else if ((k >= 4) && (k < 6))
            {
                return Enum.GetName(typeof(Problemi_onlati), x.Next(4, 6));
            }
            else
                return Enum.GetName(typeof(Problemi_else), x.Next(6, 9));
        }
        static byte Pyatyorki(int[] piv4anskiy)
        {
            try
            {
                foreach (int el in piv4anskiy)
                {
                    if ((el < 0) | (el > 9))
                    {
                        string exc = "Введите верную оценку";
                        throw new ArgumentOutOfRangeException(exc);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! От 0 до 9!!!");
            }
            byte k = 0;
            foreach (int el in piv4anskiy)
            {
                if (el == 5)
                {
                    k++;
                }
            }
            return k;
        }
        static string PivoZavr(int[] pivas, int[] pivandopala)
        {
            if (((Pyatyorki(pivas)) == (Pyatyorki(pivandopala))))
                return "Drinks All Round! Free Beers on Bjorg!";
            else
                return "Ой, Бьорг - пончик! Ни для кого пива!";
        }
        static void Graf()
        {
            Random rand = new Random();
            Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
            string exit = "";
            int u;
            do
            {
                u = rand.Next(3, 5);
                bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
                int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

                for (int i = 0; i < u + 1; i++)
                {
                    g[i] = new int[u + 1];
                    Console.Write("\n({0}) вершина -->[", i + 1);
                    for (int j = 0; j < u + 1; j++)
                    {
                        g[i][j] = rand.Next(0, 2);
                    }
                    g[i][i] = 0;
                    foreach (var item in g[i])
                    {
                        Console.Write(" {0}", item);
                    }
                    Console.Write("]\n");

                }
                used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

                q.Enqueue(u);
                Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
                while (q.Count != 0)
                {
                    u = q.Peek();
                    q.Dequeue();
                    Console.WriteLine("Перешли к узлу {0}", u + 1);

                    for (int i = 0; i < g.Length; i++)
                    {
                        if (Convert.ToBoolean(g[u][i]))
                        {
                            if (!used[i])
                            {
                                used[i] = true;
                                q.Enqueue(i);
                                Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                            }
                        }
                    }
                }
                Console.WriteLine("Завершить программу?");
                exit = Console.ReadLine();
                Console.Clear();
            } while (!exit.Equals("да") || !exit.Equals("lf"));
            Console.ReadKey();
        }
        
    }
}
