using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test5_조건문
{
    class Program
    {
        //if문
        public void if_condition()
        {
        //goto: jump로 이동
        jump: Console.WriteLine("당신의 프로그래밍 성적을 입력해주세요.");
            int ifNum = int.Parse(Console.ReadLine());

            if (ifNum > 100) goto jump;

            else if (ifNum >= 90)
            {
                Console.WriteLine("당신의 성취도는 A 입니다\n\n");
            }
            else if (ifNum >= 80)
            {
                Console.WriteLine("당신의 성취도는 B 입니다\n\n");
            }

            else if (ifNum >= 70)
            {
                Console.WriteLine("당신의 성취도는 C 입니다\n\n");
            }
            else if (ifNum >= 60)
            {
                Console.WriteLine("당신의 성취도는 D 입니다\n\n");
            }
            else
            {
                Console.WriteLine("당신의 성취도는 e 입니다\n\n");
            }
        }

        //Switch문
        public void switch_condition()
        {
        jump: Console.WriteLine("당신의 반을 입력해주세요.\n");
            int classroom = int.Parse(Console.ReadLine());

            switch (classroom)
            {
                case 1:
                    Console.WriteLine("당신은 게임과입니다.\n");
                    break;

                case 2:
                    Console.WriteLine("당신은 유센과 1반 입니다.\n");
                    break;

                case 3:
                    Console.WriteLine("당신은 유센과 2반 입니다.\n");
                    break;

                case 4:
                    Console.WriteLine("당신은 해킹과 1반 입니다.\n");
                    break;

                case 5:
                    Console.WriteLine("당신은 해킹과 2반 입니다.\n");
                    break;

                default:
                    Console.WriteLine("반이 없습니다\n");
                    goto jump;
            }
        }




        static void Main(string[] args)
        {
            Program condition = new Program();
            condition.if_condition();
            condition.switch_condition();
        }
    }
}