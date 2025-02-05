namespace TexTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectName();
        }


        static public int UserInput()          // 유저가 고를 숫자 선택
        {
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return choose;
        }


        static public void SelectName()         // 유저이름 정하기
        {
            Console.Clear();

            Console.WriteLine("스파르타 던전에 오신 전사님, 환영합니다.");
            Console.WriteLine("원하시는 이름을 입력해주세요.\n");

            string userName = Console.ReadLine();

            Console.WriteLine($"\n입력하신 이름은 {userName} 입니다.");
            Console.WriteLine("1. 확인");
            Console.WriteLine("2. 취소\n");

            int choose = UserInput();

            if (choose == 1)
            {
                Player player = new Player(1, userName, "전사", 10, 5, 100, 1500);    // 플레이어 생성
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


        static public void GameStart()         // 게임 스타트 (마을)
        {
            Console.Clear();

            Console.WriteLine($"스파르타 마을에 오신 전사님 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine("\n1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 던전 입장");
            Console.WriteLine("5. 휴식하기\n");


            int choose = UserInput();

            while (choose != 1 && choose != 2 && choose != 3 && choose != 4 && choose != 5)    // 제시된 숫자 이외의 것을 고를 경우 알림
            {
                Console.WriteLine("잘못된 입력입니다.");
                choose = UserInput();
            }


            if (choose == 1)
            {
                Status.StatusCheck();    // 상태 확인 창으로 감
            }
            else if (choose == 2)
            {
                Inventory.InventoryCheck();    // 인벤토리 창으로 감
            }
            else if (choose == 3)
            {
                Store.InStore();    // 상점으로 감
            }
            else if (choose == 4)
            {
                Console.WriteLine("던전이 공사 중입니다.");
                Console.WriteLine("현재 들어갈 수 없습니다.");
                Console.WriteLine("3초 후에 마을로 돌아갑니다.");
                Thread.Sleep(3000);
                GameStart();
            }
            else if(choose == 5)
            {
                Rest.Resting();
            }
        }
    }
}
