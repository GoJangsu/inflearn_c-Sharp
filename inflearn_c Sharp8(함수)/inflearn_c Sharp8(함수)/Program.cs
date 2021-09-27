using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test8_함수_
{
    //함수가 있는 클래스
    public class Study
    {
        //함수1 (main에서 '함수1'을 호출함)
        public void callFunction()
        {
            Console.WriteLine("함수를 호출하였습니다!\n\n");
        }

        //함수2  (main함수에서 변수에 3을 대입함) 
        public void getFunction(int Num1)
        {
            Console.WriteLine("매개변수가 하나만 존재하고 a의값은? " + Num1 + "\n\n");
        }

        //함수3 (main함수에서 변수에 3, 5를 대입함) 
        public int addFunction(int Num2, int Num3)
        {
            Console.WriteLine("덧셈 함수를 호출하였습니다!");
            int addNum = Num2 + Num3;
            return addNum;
        }

        //Study 함수를 호출하는 메인 클래스
        class Program
        {
            static void Main(string[] args)
            {
                Study function = new Study();

                //'함수1'을 호출함 
                function.callFunction();

                //'함수2'를 호출함
                function.getFunction(3);

                //'함수3'을 호출함
                int result = function.addFunction(3, 5);
                Console.WriteLine("3 + 5의 결과는?" + result + "\n\n");
            }

        }
    }
}