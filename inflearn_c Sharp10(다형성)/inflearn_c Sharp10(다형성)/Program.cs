using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test10_다형성_
{
    class Animal
    {
        public virtual void animalBark()
        {
            Console.WriteLine("동물이 소리를 냅니다.\n");
        }
    }

    class Cat : Animal
    {
        //오버라이딩(Overriding)
        public override void animalBark()
        {
            base.animalBark();
            Console.WriteLine("야옹야옹");
        }

        //오버로딩(Overloading)
        public void animalBark2(int a)
        {
            Console.WriteLine(a);
        }

        public void animalBark2(int a, int b)
        {
            Console.WriteLine(a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal = new Cat();
            animal.animalBark();
            /*
            코드의 재사용성 증가.
            객체만 변경하면 기존시스템에서 수정/미수정 시 사용가능.
             */
        }
    }
}