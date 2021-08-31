using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasic7
{
    
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
        }
    }
}
