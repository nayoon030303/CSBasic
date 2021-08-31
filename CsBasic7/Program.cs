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
        }
    }
}
