using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test4_배열_
{
    class Program
    {
        public void array1st()
        {
            //배열의 선언 방법.
            string[] programing = new string[10];
            string[] language = { "C언어", "Python", "JavaScript", "C#" };

            //배열의 요소 출력.
            Console.WriteLine("첫번째 값은 " + language[0] + " 입니다.\n");
            Console.WriteLine("세번째 값은 " + language[2] + " 입니다.\n");
            Console.WriteLine("네번째 값은 " + language[3] + " 입니다.\n");

            //배열의 요소변경.
            language[2] = "Java";
            Console.WriteLine("변경된 값을 출력하면 " + language[0] + " 입니다.\n");

            //배열의 길이 구하기.
            Console.WriteLine("배열의 길이는 " + language.Length + " 입니다.\n\n");
        }

        public void array2nd()
        {
            //2차원배열의 선언
            int[,] myNum = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine("2차원 배열인 myNum [0,2] 위치의 값은 " + myNum[0, 2] + " 입니다.\n\n");

        }

        public void JaggedArray()
        {
            //가변배열
            int[][] myNum2 = new int[4][];
            myNum2[0] = new int[2] { 1, 2 };
            myNum2[1] = new int[3] { 3, 4, 5 };
            myNum2[2] = new int[4] { 6, 7, 8, 9 };
            myNum2[3] = new int[2];

            /* myNum2의 배열
            [1] [2]
            [3] [4] [5]
            [6] [7] [8] [9]
            [0] [0]
             */

            Console.WriteLine("가변배열인 myNum2[2][1] 위치의 값은 " + myNum2[2][1] + " 입니다.\n\n");


        }


        static void Main(string[] args)
        {
            Program array = new Program();

            array.array1st();
            array.array2nd();
            array.JaggedArray();
        }
    }
}