using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Store
    {


        static public void InStore()
        {
            Console.WriteLine("\n상점\n필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]\n{gold} G");

            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
            //Console.WriteLine($"{basicArmor.itemName} | 방어력 + {} | {} | {} ");
            //List<Item>[] items = new List<Item>();

            for (int i = 0; ;)
            {

            }


            //- 수련자 갑옷 | 방어력 + 5 | 수련에 도움을 주는 갑옷입니다.             | 1000 G
            //- 무쇠갑옷 | 방어력 + 9 | 무쇠로 만들어져 튼튼한 갑옷입니다.           | 구매완료
            //- 스파르타의 갑옷 | 방어력 + 15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.| 3500 G
            //- 낡은 검 | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.            | 600 G
            //- 청동 도끼 | 공격력 + 5 | 어디선가 사용됐던거 같은 도끼입니다.        | 1500 G
            //- 스파르타의 창 | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 구매완료

            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");




            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");

            int choose = Program.UserInput();

            if (choose == 1)
            {
                Purchase();
            }
            else if (choose == 0)
            {
                Program.GameStart();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

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
