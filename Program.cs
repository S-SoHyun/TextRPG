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
        static public string userName = "Unknown";



        static void Main(string[] args)
        {
            Player player = new Player(01, userName, "전사", 10, 5, 100, 1500);

            Item basicArmor = new Item("수련자 갑옷", 5, "수련에 도움을 주는 갑옷입니다.", 1000, false, false);
            Item steelArmor = new Item("무쇠갑옷", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1500, false, false);
            Item sArmor = new Item("스파르타의 갑옷", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 1000, false, false);
            Item sword = new Item("낡은 검", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 1000, false, false);
            Item axe = new Item("청동 도끼", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1000, false, false);
            Item spear = new Item("스파르타의 창", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 1000, false, false);

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
            Console.WriteLine("스파르타 던전에 오신 전사님, 환영합니다.");
            Console.WriteLine("원하시는 이름을 입력해주세요.\n");

            string userName = Console.ReadLine();

            Console.WriteLine($"\n입력하신 이름은 {userName} 입니다.");
            Console.WriteLine("1. 확인\n2. 취소\n");

            int choose = UserInput();

            if (choose == 1)
            {
                GameStart();
            }
            else if (choose == 2)
            {
                SelectName();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                SelectName();
            }
        }


        static public void GameStart()         // 게임 스타트
        {
            Console.WriteLine("\n스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.Write("\n");
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점\n");

            int choose = UserInput();

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
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                GameStart();
            }
        }
    }
}
