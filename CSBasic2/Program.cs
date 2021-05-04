using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }

            double score = 3.7;

            if (score == 4.5)
            {
                Console.WriteLine("신");
            }
            else if (score >= 4.2)
            {
                Console.WriteLine("교수님의 사랑");
            }
            else if (score >= 3.5)
            {
                Console.WriteLine("교수님의 사랑");
            }
            else if (score >= 2.5)
            {
                Console.WriteLine("일반인");
            }
            else if (score >= 1.75)
            {
                Console.WriteLine("오락문화의 선구자");
            }
            else if (score >= 1.0)
            {
                Console.WriteLine("불가촉천민");
            }
            else if (score >= 0.5)
            {
                Console.WriteLine("자벌레");
            }
            else if (score >=0)
            {
                Console.WriteLine("플라크톤");
            }
            else
            {
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
            }
        }
    }
}
