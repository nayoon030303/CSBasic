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

            int _int = 273;
            long _long = 3545203904;
            float _float = 52.123f;
            double _double = 52.1234;
            char _char = '귤';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            //var 키워드 지역변수로만 사용 가능. 
            var userName = "Kim na yoon";
            var userAge = 10;
            Console.WriteLine(userName);
            Console.WriteLine(userAge);

            Console.WriteLine(userName.GetType());
            Console.WriteLine(userAge.GetType());


            //read && write
          /*  string input;
            while(true)
            {
                Console.Write("입력>>");
                input = Console.ReadLine();
                if (input.Equals("q"))
                    break;
                else
                    Console.WriteLine(input);
            }*/

            var a = (int)10.0;
            var b1 = (float)10;
            var c1 = (double)10;

            long longNumber = 234555566666666L + 234555566666666L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber2 = 52773;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);

            Console.WriteLine("int, long, float, double 맥스밸류");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(Double.MaxValue);


            Console.WriteLine("문자열의 숫자로의 형변환");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("237"));
            Console.WriteLine(float.Parse("52.345"));
            Console.WriteLine(double.Parse("103,345"));
            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("237").GetType());
            Console.WriteLine(float.Parse("52.345").GetType());
            Console.WriteLine(double.Parse("103,345").GetType());

            //잘못된 형변환
            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("abc"));
                Console.WriteLine(int.Parse("육십삼"));
                Console.WriteLine(int.Parse("Seven"));

            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("알 수 없는 에러:" + e.Message);
            }

            //ToString()
            (10).ToString();
            (58.123).ToString();

            double numberToString = 52.273103;
            Console.WriteLine(numberToString.ToString("0.0"));
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.00000"));

            //숫자와 문자열 덧셈
            Console.WriteLine(52 + 273); //325
            Console.WriteLine("52" + 273); //52273
            Console.WriteLine(52 + "273");
            Console.WriteLine("52"+"273");
            Console.WriteLine(52 + 2 + 273);
            Console.WriteLine("52" + 2 + "273"); //522273
            Console.WriteLine(52 + "2" + 273);//522273
            Console.WriteLine(52 + 2 + "273");//54273
            Console.WriteLine(52 + '1' + "273");

            int number = 5227303;
            string outputA = number + "";

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("TRUE"));
            Console.WriteLine(bool.Parse("truE"));
            Console.WriteLine(bool.Parse("TrUe"));

            int outputInt = int.MinValue;
            Console.WriteLine(outputInt);
            Console.WriteLine(-(long)outputInt);
            //Console.WriteLine(-(-2147483648));
            Console.WriteLine(-(-2147483647));
        }
    }
}
