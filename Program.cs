using System.Data;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace TexTRPG
{
    public class Program
    {
        //  변수 목록
        static public int choose;
        static public string userName;


        static void Main(string[] args)
        {
            SelectName();
        }


        static public int UserInput()          // 유저 숫자 선택
        {
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return choose;
        }


        static public void SelectName()         // 이름 선택
        {
            Console.Clear();

            Console.WriteLine("스파르타 던전에 오신 전사님, 환영합니다.");
            Console.WriteLine("원하시는 이름을 입력해주세요.\n");

            string userName = Console.ReadLine();

            Console.WriteLine($"\n입력하신 이름은 {userName} 입니다.");
            Console.WriteLine("1. 확인\n2. 취소\n");

            int choose = UserInput();

            if (choose == 1)
            {
                Player player = new Player(1, userName, "전사", 10, 5, 100, 1500);
                GameStart();
            }
            else if (choose == 2)
            {
                SelectName();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.\n");
                Thread.Sleep(500);
                SelectName();
            }
        }


        static public void GameStart()         // 게임 스타트
        {
            Console.Clear();

            Console.WriteLine($"스파르타 마을에 오신 전사님 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine("\n1. 상태 보기\n2. 인벤토리\n3. 상점\n");

            int choose = UserInput();

            while (choose != 1 && choose != 2 && choose != 3)
            {
                Console.WriteLine("잘못된 입력입니다.");
                choose = UserInput();
            }


            if (choose == 1)
            {
                Status.StatusCheck();
            }
            else if (choose == 2)
            {
                Inventory.InventoryCheck();
            }
            else if (choose == 3)
            {
                Store.InStore();
            }
        }
    }
}
