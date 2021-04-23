using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "김나윤";


            /*error*/
            //int break;
            //int 🍔🤣;

            //출력
            Console.Write("이건 안개행");
            Console.Write("입니당");
            Console.WriteLine("");
            Console.WriteLine("이건 개행");

            //자료형(Data Type)
            //Integer
            Console.WriteLine(53 + 273);
            Console.WriteLine(53 *3 -3);
            Console.WriteLine(14/2); //7
            Console.WriteLine(14 / 3); //4
            Console.WriteLine(14 % 3); //2

            //Real Number;
            Console.WriteLine(13.43);
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 / 2.0); //7.0
            Console.WriteLine(14.0 / 3.0); //4.66666666667
            Console.WriteLine(14 / 3.0); //4.66666666667
            Console.WriteLine(14.0 / 3); //4.66666666667

            //Character
            Console.WriteLine('A'); //문자
            //String
            Console.WriteLine("A"); //문자열
            //Escape Character
            Console.WriteLine("\t탭 \\역슬래스 \n 개행 \"");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학\t고");


            //문자 연결 연산자
            //concat concatenate operator
            //concatenation perator
            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E'); //정수 + 정수  +가 덧셈 연산자가 된다.
            Console.WriteLine("ABC" + 'E');

            Console.WriteLine("ABC"[2]); //C
          //  Console.WriteLine("ABC"[3]); //error 예외 발생

            //bool
            bool isPlay = true;
            bool isDeath = false;

            //comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163);
            Console.WriteLine(52 < 163);
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);

            //Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            //단항연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++;
            //이항연산자 - binary operator
            i = 1 + 2;

            //삼항연산자 - ternary operator
            int j;
            j = (i > 3) ? 0 : 1;

            Console.WriteLine(3 < 4 || 5 > 8);
            Console.WriteLine(3 < 4 && 5 > 8);
            Console.WriteLine(!(true)|| 5 > 8);

           // int a = 2143324240;
            //int b = 100000000;
           // Console.WriteLine(a + b);

            //sizeof(자료형)
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("int: " + sizeof(double));
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("int: " + sizeof(int));

            //증감연산자 - 섞어서 쓸 경우
            //전위, 후위에 따라서 출력 앖이 변할 수 있으니 주의
            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);


            //복합대입연산자
            int output = 5;
            output += 10;
            Console.WriteLine(output);

            //문자열 연결 연산자를 사요한 복합 연산자
            string output3 = "Hello";
            output3 += "World";
            output3 = output3 + "?";
            Console.WriteLine(output3);
        
        }
    }
}
