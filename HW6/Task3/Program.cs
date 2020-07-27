using System;
using System.Collections;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int[] crsAge = { 0, 0, 0, 0, 0, 0 };  //Инициализация массива (не частотного) для подсчёта студентов 18-20 на курсах
        int cours5 = 0;
        int cours6 = 0;
        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students_1.csv");
        //FileStream fs = new FileStream("students_1.csv", FileMode.Open, FileAccess.Read);
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                list.Add(s[6] + " " + s[5] + " " + s[1] + " " + s[0]);// Курс+возраст+ФИ
                if (int.Parse(s[6]) == 5) cours5++; else if (int.Parse(s[6]) == 6) cours6++;  //Считаем студентов 5 и 6 курсов
                if ((int.Parse(s[5]) >= 18) && (int.Parse(s[5]) <= 20))
                {
                    switch (int.Parse(s[6]))
                    {
                        case 1:
                            crsAge[0]++;
                            break;
                        case 2:
                            crsAge[1]++;
                            break;
                        case 3:
                            crsAge[2]++;
                            break;
                        case 4:
                            crsAge[3]++;
                            break;
                        case 5:
                            crsAge[4]++;
                            break;
                        case 6:
                            crsAge[5]++;
                            break;
                    }
                }

            }
            catch
            {
            }
        }
        sr.Close();
        list.Sort();
        Console.WriteLine("Всего студентов: {0}", list.Count);
        Console.WriteLine("Студентов 5 курса: {0}", cours5);
        Console.WriteLine("Студентов 6 курса: {0}", cours6);
        Console.WriteLine($"Студентов в возрасте 18-20 лет на курсе: \n1: {crsAge[0]}\n2: {crsAge[1]}\n3: {crsAge[2]}\n4: {crsAge[3]}\n5: {crsAge[4]}\n6: {crsAge[5]} ");
        for (int i = 1; i < crsAge.Length + 1; i++) 
        {
            Console.WriteLine($"Студентов {i} курса: {crsAge[i - 1]}");
        }
        foreach (var v in list) Console.WriteLine(v);
        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}

