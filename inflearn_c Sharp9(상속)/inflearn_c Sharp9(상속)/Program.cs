using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test9_상속_
{
    //부모 클래스(parentsClass)
    class parentsClass
    {
        protected string year = "2021년\n\n";

        public void study()
        {
            Console.WriteLine("C# 공부를 합니다.\n");
        }
    }

    //자식 클래스(childClass)가 부모클래스(parentsClass)를 상속받음
    class childClass : parentsClass
    {
        public string Start()
        {
            return year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            childClass Inheritance = new childClass();
            Inheritance.study();

            Console.WriteLine(Inheritance.Start());

            /*
             오류발생
             Inheritance.a;
             */
        }

    }
}
