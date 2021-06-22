using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();

            // min 이상 max 이하
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());

            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);

            Console.WriteLine(random.Next(20));

            // 1 이상 20 이하의 값
            Console.WriteLine(random.Next(20) + 1);
            Console.WriteLine(random.Next(1, 21));

            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            List<int> list = new List<int>();



        }
    }
}