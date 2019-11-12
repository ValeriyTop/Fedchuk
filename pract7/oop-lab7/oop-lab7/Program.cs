using System;
using ClassLibrary;

namespace oop_lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People("Валеря", "Федчук", "31 квiтня 2000 року");
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Abiturient a1 = new Abiturient(100, 50, "Школа №6", p1);
            p1 = a1;
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Student s1 = new Student(4, "P-41", "Чисельні методи", "КПК НУ ЛП", a1);
            p1 = s1;
            p1.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();

            People p2 = new People("Оксана", "Юрочко", "08 сiчня 1982 року");
            p2.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();
            Vykladach v1 = new Vykladach("Вчитель", "Чисельні методи", "КПК НУ ЛП", p2);
            p2 = v1;
            p2.ShowInfo();
            Console.Write("\nPress enter to continue");
            Console.ReadKey();

            KorystuvachBiblioteku k1 = new KorystuvachBiblioteku(4, "4 листопада 2019", 12, s1);
            p1 = k1;
            p1.ShowInfo();
        }
    }
}
