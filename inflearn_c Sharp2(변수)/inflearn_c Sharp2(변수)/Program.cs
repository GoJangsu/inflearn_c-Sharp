using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test2_변수
{
    //변수 클래스
    public class variable
    {

        //정수
        public int Num = -5; //-2,147,483,648 ~ 2,147,438,647
        public long bigNum = 234232423000L; //-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
        public short shortNum = 2131; //-32,768 ~ 32,767
        public byte byteNum = 250; //0~255

        //참, 거짓
        public bool logic = 1 == 1; //참, 거짓의 상태 표현
        public bool logic2 = 2 == 1;

        //문자
        public string strBf = "Hello World"; //여러 문자를 저장 
        public char str = 'A'; //1개의 문자를 저장

        //실수
        public float flNum = 0.5F; //소수점있는 실수 저장
        public double doubleNum = 0.3242354D;

        public void Printvariable()
        {
            Console.WriteLine(Num);
            Console.WriteLine(bigNum);
            Console.WriteLine(shortNum);
            Console.WriteLine(byteNum + "\n");

            Console.WriteLine(logic);
            Console.WriteLine(logic2 + "\n");

            Console.WriteLine(strBf);
            Console.WriteLine(str + "\n");

            Console.WriteLine(flNum);
            Console.WriteLine(doubleNum + "\n\n");
        }

    }
}