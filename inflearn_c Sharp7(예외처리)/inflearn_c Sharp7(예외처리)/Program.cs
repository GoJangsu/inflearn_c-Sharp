using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//try, catch, finally를 통한 오류를 예측하고,후속 처리를 할 수 있다.

namespace inflearn_test7_예외처리_
{
    class Program
    {
        public void error()
        {
            //오류가 발생할 것 같은 구문
            try
            {
                Console.WriteLine("값을 입력해주세요.\n");
                int i = Int32.Parse(Console.ReadLine());

                string[] numbers = { "서울", "마포구", "한세", "사이버", "보안고" };
                Console.WriteLine("\n입력한 값의 위치에는 " + numbers[i] + " 가 있습니다. \n\n");

            }


            //오류발생시 실행 (배열 범위 밖의 index를 엑세스 할 때)
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\n특정오류만 잡았습니다.Main함수의 IndexOutOf....\n");
                Console.WriteLine("오류내용은 " + e.ToString() + "\n\n");
            }


            //오류 발생시 실행 (모든 에러의 최상위 에러, 모든 에러와 호환)
            catch (Exception e)
            {
                Console.WriteLine("\n오류가 발생되어 코드가 실행됩니다.\n");
                Console.WriteLine("오류내용은 " + e.ToString() + "\n\n");
            }

            //오류 발생, 오류 미발생시에도 무조건 실행
            finally
            {
                Console.WriteLine("오류발생,오류미발생이여도 무조건 실행되는 부분입니다.\n\n");
            }
        }


        static void Main(string[] args)
        {
            Program error_EX = new Program();
            error_EX.error();
        }
    }
}

/*
 try : 오류가 발생할 것 같은 구문

 catch : 오류 발생시에만 실행
    Exception : 모든 에러의 최상위 에러, 모든 에러와 호환
    DivideByZeroException : 정수 값 또는 소수 값을 0으로 나누려 할 때
    IndexOutOfRangeException : 배열 범위 밖의 index를 엑세스 할 때
    FormatException : 변수의 형식이 맞지 않을 때
    OverflowException : 오버플로우가 발생할 때

 finally : 오류발생, 오류미발생에도  무조건 실행
 */
