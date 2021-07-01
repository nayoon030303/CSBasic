using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
   
    class Program
    {
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public override string ToString()
            {
                return this.id + ":" + this.name;
            }

            public Product(string name, int price)
            {
                //Product.counter = counter + 1;
                counter++;
                this.id = counter;
                this.name = name;
                this.price = price;
            }


        }

        class Sample
        {
            public static int value;

            //자동으로 생성되는 생성자 이기 때문에 매개변수를 넣을 수 없다.
            //접근제어자, 리턴값이 없다.
            //클래스변수만 접근 가능(인스턴스 불가능)
            static Sample()
            {
                value = 10;
                Console.WriteLine("처음으로 로드");
            }
        }

        int someModifier = 0;

        public int instanceVariable = 10;

        public int instanceMethod() 
        {
            return 0;
        }
     
        class MyMath
        { 
            public static int Abs(int input)
            {
                return input < 0 ? -input : input;
            }
            public static long Abs(long input)
            {
                return input < 0 ? -input : input;
            }
            public static double Abs(double input)
            {
                return input < 0 ? -input : input;
            }

            //Method Signature가 같은 경우 오버로딩 불가능
           /* public static int Abs(long aw)
            {
                return 0;
            }*/

        }

        

        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }

            //Method Signature, return은 포함 x
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i=min; i<=max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }

            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨!");
            }
            
        }


        static void Main(string[] args)
        {

            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(20,10));
            Console.WriteLine(me.Multi(3,10));
            me.Print();

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-333));

            //클래스 메서드에서는 인스턴스 변수, 메서드 접근 불가 
            //객체를 만들어 접근해야한다.
            //Console.WriteLine(instanceVariable);

            Program p = new Program();

            Console.WriteLine(p.instanceVariable);
            p.instanceMethod();

            Console.WriteLine(MyMath.Abs(5));
            Console.WriteLine(MyMath.Abs(-234));
            Console.WriteLine(MyMath.Abs(52.123));
            Console.WriteLine(MyMath.Abs(4678984561211111111));


            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 2500);
            Product productC= new Product("옥수수", 1500);

            //Console.WriteLine(productA.id + ":" + productA.name);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

           
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("첫 번째 위치");
        }
    }
}