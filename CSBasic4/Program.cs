using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    class MyMath
    {
        int scmemnumber= 42;
        public static double PI = 3.141592;
        public static void Greeting()
        {
            Console.WriteLine("Creeting");
        }
    }
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(1,19));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            /*  List<int> list = new List<int>();
              list.Add(52);
              list.Add(276);
              list.Add(33);
              list.Add(56);
              foreach(var item in list)
              {
                  Console.WriteLine(item);
              }*/

            List<int> list = new List<int>() { 52, 33, 114, 55 };
            foreach(var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "\titem:" + item);
               // list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-523));
            Console.WriteLine(Math.Ceiling(52.123));
            Console.WriteLine(Math.Floor(52.123));
            Console.WriteLine(Math.Round(54.34));
            Console.WriteLine(Math.Max(33, 124));
            Console.WriteLine(Math.Min(33, 124));


            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name+":"+product.price+"원");

            Product productA = new Product(){name = "짜장면", price=5000};
            Product productB = new Product(){name = "짬뽕", price=8000};
            Product productC = new Product(){name = "탕수육"};
            Product productD = new Product(){ price = 999999};
            Product productE = new Product(){ price = 3000, name = "양장피"};



        }
    }
}
