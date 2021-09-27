using System;//System 네임스페이스사용.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inflearn_test1 //네임스페이스선언.
//공간 선언을 통해 중복되는 클래스 이름을 피할 수 있다.

{
    class Study // 하나의 객체를 표현.
    //Ex)클래스가있으면 클래스의 구성요소(맴버변수)와 행동적인요소(method)를 가질 수 있다.

    {
        private string book = "C#.Net Framework"; //멤버변수.

        public void StudyRun() //메소드.
        {
            Console.WriteLine("공부를 시작한다.");
        }
    }

    class Program //C#에서 프로그램의 가장 첫번째 실행되는 Main메소드를 포함하는 용도로 주로 사용.
    {

        static void Main(string[] args) //프로그램의 주시작점.
        {
            System.Console.WriteLine("System을 이용해 호출하기"); //System네임스페이스의 Console클래스의 WriteLine메소드 호출.
            Console.WriteLine("Hello GoJangsu");
        }
    }
}


/*
단축키 목록
Ctrl키 + Shift키 + B키 -> 빌드
Ctrl키 + Shift키 -> 자동 완성
Ctrl키 + S키 -> 저장
Ctrl키 + F5키 -> 실행
*/