using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test3_연산자
{

    class Program
    {
        //연산자1
        public void Operator()
        {
            //단항 연산자
            int a = 5;
            a++;
            Console.WriteLine(a);

            //이항연산자
            int b = 3;
            int c = a - b;
            Console.WriteLine(c);

            //삼항 연산자
            int d = (5 > 3) ? 2 : 0;
            Console.WriteLine(d);
        }


        //연산자2
        public void logic()
        {
            //논리 연산자  &&(AND연산), ||(OR연산)
            bool logic1 = true;
            bool logic2 = false;
            if (logic1 || logic2)
            {
                Console.WriteLine("\n\n둘의 OR연산자 결과는 true");
            }
            else
            {
                Console.WriteLine("둘의 OR연산자 결과는 false");
            }


            //비트 연산자  &(AND연산), |(OR연산), ^(XOR연산)
            int num1 = 16;
            int num2 = 28;
            int num3 = num1 & num2;
            Console.WriteLine(num3 + ("\n"));
        }



        static void Main(string[] args)
        {
            //연산자1,2
            Program numOperator = new Program();
            numOperator.Operator();
            numOperator.logic();
        }
    }
}
