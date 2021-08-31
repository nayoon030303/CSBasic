using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasic7
{
    
    class Products
    {
        private List<string> list = new List<string>();

        public Products()
        {
            list.Add("짜장면");
            list.Add("짬뽕");
            list.Add("탕수육");
            list.Add("볶음밥");
            list.Add("마파두부");
        }
        
        public string this[int i]
        {
            get { return list[i]; }
            set { Console.WriteLine(i + "째 상품 설정"); }
        }
    }
    
    class Student
    {
        public override string ToString()
        {
            return "학생";
        }
    }

    class Wanted<T>
        //WHER T:Student
    {
        public T value;
        public Wanted(T value)
        {
            this.value = value;
        }
    }
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
            public string s;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.s = null;
            }
        }

        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        class PointClass
        {
            public int x = 0;
            public int y = 0;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Wanted<string> vs = new Wanted<string>("String");
            Wanted<int> wi = new Wanted<int>(42);
            Wanted<string> ws = new Wanted<string>("String입니다.");
            Wanted<Student> wstudent = new Wanted<Student>(new Student());

            Console.WriteLine(vs);
            Console.WriteLine(wi);
            Console.WriteLine(ws);
            Console.WriteLine(wstudent);

            Products ps = new Products();
            Random rs = new Random();
            int i = rs.Next(0, 5);
            Console.WriteLine(ps[i]);

            Console.Write("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("변환 성공" + output);
            }
            else
            {
                Console.WriteLine("변환 실패"+output);
            }

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재좌료:" + x+","+ y);
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌료" + x + "," + y);

            Point point;
            point.x = 10;
            point.y = 10;

            Point point2 = new Point(10, 10);
            Point point3 = new Point();//0,0으로 초기화 


            //모두 스택에있다
            Point p = new Point(10, 20);
            Point p2 = new Point();
            p2.x = 100;
            p2.y = 200;
            Console.WriteLine(p.x + "," + p.y);
            Console.WriteLine(p2.x + "," + p2.y);


            PointClass pc = new PointClass(10, 20);
            PointClass pc2 = pc;

            pc2.x = 100;
            pc2.y = 200;
            Console.WriteLine(pc.x + "," + pc.y);
            Console.WriteLine(pc2.x + "," + pc2.y);

        }
    }
}
