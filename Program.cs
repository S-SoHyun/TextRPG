namespace TexTRPG
{
    internal class Program
    {
        //  변수 목록
        static public int choose;

        //enum Number
        //{
        //    zero = 0,
        //    one,
        //    two,
        //    three,
        //}

        static void Main(string[] args)
        {
            SelectName();
        }


        static private int UserInput()
        {
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return choose;
        }


        static private void SelectName()
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


        static private void GameStart()
        {
            Console.WriteLine("\n스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.Write("\n");
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점\n");

            int choose = UserInput();

            if (choose == 1)
            {
                Statement();
            }
            else if (choose == 2)
            {
                Inventory();
            }
            else if (choose == 3)
            {
                Store();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                GameStart();
            }
        }






        static private void Statement()
        {
            Console.WriteLine("\n상태 보기 \n캐릭터의 정보가 표시됩니다.\n");

            //Console.WriteLine("Lv. 01");
            //Console.WriteLine($"Chad");
            //Console.WriteLine($"공격력 : {}");
            //Console.WriteLine($"방어력 : {}");
            //Console.WriteLine($"체 력 : {}");
            //Console.WriteLine($"Gold : {}" \n);

            Console.WriteLine("0. 나가기");


        }



        static private void Inventory()
        {
            Console.WriteLine("\n인벤토리 \n보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]\n");

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            UserInput();

            //if ( 0이라면 )
            //{
            //    GameStart();
            //}
            //else if ( 1이라면 )
            //{
            //     장착 관리에 가도록.
            //}
            // 둘다 아니라면
            // Console.WriteLine("잘못된 입력입니다.");


        }


        static private void Store()
        {
            Console.WriteLine("\n상점\n필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]\n{gold} G");


            Console.WriteLine("[아이템 목록]");

            //- 수련자 갑옷 | 방어력 + 5 | 수련에 도움을 주는 갑옷입니다.             | 1000 G
            //- 무쇠갑옷 | 방어력 + 9 | 무쇠로 만들어져 튼튼한 갑옷입니다.           | 구매완료
            //- 스파르타의 갑옷 | 방어력 + 15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.| 3500 G
            //- 낡은 검 | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.            | 600 G
            //- 청동 도끼 | 공격력 + 5 | 어디선가 사용됐던거 같은 도끼입니다.        | 1500 G
            //- 스파르타의 창 | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 구매완료



            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");

            UserInput();

            //만약 1을 눌렀다면 
            //    아이템 구매되기
            //만약 0이라면
            //    GameStart();
            // 둘다 아니라면
            // Console.WriteLine("잘못된 입력입니다.");

        }

        static private void Purchase()
        {
            //일치하는 아이템 선택
            //    근데 그게 구매가 된 거다
            //        Console.WriteLine("이미 구매한 아이템입니다.");
            //    구매가 안 돼서 구매 가능하다
            //        근데 돈이 돼서 진짜 살 수 있다
            //            Console.WriteLine("구매를 완료했습니다.");
            //            재화 감소
            //            인벤토리에 아이템 추가
            //            상점에 구매완료 표시
            //        근데 보유 재화가 부족하다
            //            Console.WriteLine("Gold가 부족합니다.");
            
            //일치하는 아이템을 선택하지 않았다면
            //    Console.WriteLine("잘못된 입력입니다.");




        }






        





    }
}
