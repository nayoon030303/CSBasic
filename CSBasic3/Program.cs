using System;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int [100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[96]);
            //Console.WriteLine(intArray[100]); //범위 초과
            //Console.WriteLine(intArray[-1]); //음수 사용불가


            int i = 0;
            int[] intArray2 = { 52, 123, 4, 3, 55, 645, 3 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(i + "번째 출력" + intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(종료:exit):");
                input = Console.ReadLine();
            } while (input != "exit");


            for(int j='가'; j<='힣'; j++)
            {
                Console.WriteLine((char)j);
            }
        }
    }
}
