using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab5
{
    public class Currency
    {
        public string NameV { set; get; }
        public int ExRate { set; get; }
        public Currency() { }

        public Currency(string nameV, int exRate)
        {
            NameV = nameV;
            ExRate = exRate;
        }
        public Currency(Currency c)
        {
            this.NameV = c.NameV;
            this.ExRate = c.ExRate;
        }
    }

    public class Product
    {
        public string NameT { set; get; }
        public int Price { set; get; }
        public int Quantity { set; get; }
        public int Weight { set; get; }
        public string Producer { set; get; }
        public Currency[] Cost { set; get; }
        public Product() { }
        public Product(string nameT, string producer, int quantity, int price, int weight, Currency[] cost)
        {
            NameT = nameT;
            Producer = producer;
            Quantity = quantity;
            Price = price;
            Weight = weight;
            Cost = new Currency[cost.Count()];
            for (int i = 0; i < cost.Count(); i++)
            {
                Cost[i] = cost[i];
            }
        }




    }

    class Program
    {

        static Product[] ReadProductsArray()
        {
            string nameV;
            int exRate;
            string nameT, producer;
            int price, quantity, weight;
            int tt = 1;


            Console.WriteLine("Введiть кiлькiсть товару: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Product[] products = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Товар №{i + 1}");
                Console.WriteLine("Введiть назву товару: ");
                nameT = Console.ReadLine();

                Console.WriteLine("Введіть назва компанії-виробника");
                producer = Console.ReadLine();

                Console.WriteLine("Введiть вартість одиниці товару: ");
                price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введiть кількість наявних товарів на складі: ");
                quantity = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Введіть вага одиниці товару");
                weight = Convert.ToInt32(Console.ReadLine());

                Currency[] сurrency = new Currency[tt];
                for (int j = 0; j < tt; j++)
                {
                    Console.WriteLine("Назва валюти: ");
                    nameV = Console.ReadLine();
                    Console.WriteLine("Курс: ");
                    exRate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    сurrency[j] = new Currency(nameV, exRate);
                }


                products[i] = new Product(nameT, producer, price, quantity, weight, сurrency);
            }
            return products;
        }


        static void PrintProduct(Product pro)
        {
            Console.WriteLine($"Назва: {pro.NameT}");
            Console.WriteLine($"Назва компанії-виробника: {pro.Producer}");
            Console.WriteLine($"вартість одиниці товару: {pro.Price}");
            Console.WriteLine($"кількість наявних товарів на складі: {pro.Quantity}");
            Console.WriteLine($"вага одиниці товару: {pro.Weight}");


            for (int i = 0; i < pro.Cost.Count(); i++)
            {
                Console.WriteLine($"Назва валюти: {pro.Cost[i].NameV}");
                Console.WriteLine($"Курс: {pro.Cost[i].ExRate}");
            }
        }


        static void PrintProducts(Product[] pro)
        {
            for (int i = 0; i < pro.Count(); i++)
            {
                Console.WriteLine($"Назва: {pro[i].NameT}");
                Console.WriteLine($"Назва компанії-виробника: {pro[i].Producer}");
                Console.WriteLine($"вартість одиниці товару: {pro[i].Price}");
                Console.WriteLine($"кількість наявних товарів на складі: {pro[i].Quantity}");
                Console.WriteLine($"вага одиниці товару: {pro[i].Weight}");

                for (int j = 0; j < pro[i].Cost.Count(); j++)
                {
                    Console.WriteLine($"Назва валюти: {pro[i].Cost[j].NameV}");
                    Console.WriteLine($"Курс: {pro[i].Cost[j].ExRate}");
                }
            }
        }


        static void SortProductsByPrice(Product[] pro)
        {
            Array.Sort(pro, (s1, s2) => s1.Price.CompareTo(s2.Price));
        }

        static void SortProductsByCount(Product[] pro)
        {
            Array.Sort(pro, (s1, s2) => s1.Quantity.CompareTo(s2.Quantity));
        }

        static void Main(string[] args)
        {
            bool isExit = false;
            int n, w;
            Product[] pro = ReadProductsArray();

            while (!isExit)
            {
                Console.WriteLine();
                Console.WriteLine("1. Вивести iнформацiю про товар.");
                Console.WriteLine("2. Вивести iнформацiю про всi товари.");
                Console.WriteLine("3. Посортувати товари за зростанням ціни.");
                Console.WriteLine("4. Посортувати товари за кількістю на складі.");
                Console.WriteLine("5. Вихiд.");

                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        Console.WriteLine($"Введiть порядковий номер товару: 0-{pro.Count() - 1} : ");
                        w = Convert.ToInt32(Console.ReadLine());
                        PrintProduct(pro[w]);
                        break;
                    case 2:
                        PrintProducts(pro);
                        break;
                    case 3:
                        SortProductsByPrice(pro);
                        break;
                    case 4:
                        SortProductsByCount(pro);
                        break;
                    case 5:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Виберіть цифру від 1 до 5!");
                        break;
                }
                Console.WriteLine();
            }

        }

    }
}
    

