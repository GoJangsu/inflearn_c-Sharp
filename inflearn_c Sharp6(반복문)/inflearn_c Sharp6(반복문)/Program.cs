using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test6_반복문_
{
    class Program
    {
        //while문
        public void while_loop()
        {
            Console.WriteLine("입력한 숫자만큼 반복하기");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n입력한값은 " + num + " 입니다.\n");

            while (num >= 1)
            {
                Console.WriteLine("카운트 다운 " + num + " 회 남았습니다.");
                num--;
            }
        }

        //for문
        public void for_loop()
        {
            Console.WriteLine("\n\n입력한 줄 수 만큼 피라미드 별찍기");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        //foreach문
        public void foreach_loop()
        {
            string[] programing = { "C언어", "Java", "Pytion", "JavaScript", "C#" };

            Console.WriteLine("\n");

            foreach (string language in programing)
            {
                Console.WriteLine("프로그래밍 언어의 종류로는" + language + "가(이) 있다.");
            }
            Console.Write("\n");
        }


        static void Main(string[] args)
        {
            Program loop = new Program();
            loop.while_loop();
            loop.for_loop();
            loop.foreach_loop();
        }
    }
}