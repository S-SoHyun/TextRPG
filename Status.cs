using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Status
    {
        // 변수 목록
        static int atkSum;    // 공격력 합계
        static int defSum;    // 방어력 합계

        static private int AtkSum()    // 파워 타입이 공격력이고 장착했다면 다 더함
        {
            atkSum = 0;
            foreach (var item in Inventory.InvenItem)
            {
                if (item.powerType == "공격력" && item.isEquipped)
                {
                    atkSum += item.power;
                }
            }
            return atkSum;
        }
        static private int DefSum()    // 파워 타입이 방어력이고 장착했다면 다 더함
        {
            defSum = 0;
            foreach (var item in Inventory.InvenItem)
            {
                if (item.powerType == "방어력" && item.isEquipped)
                {
                    defSum += item.power;
                }
            }
            return defSum;
        }



        static public void StatusCheck()         // 상태 보기
        {
            Console.Clear();

            AtkSum();
            DefSum();

            Console.WriteLine("<상태 보기>");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine("〓〓〓〓〓〓〓〓〓");

            Console.WriteLine($"Lv. {Player.lv}");
            Console.WriteLine($"{Player.userName} ( {Player.job} ) ");


            if (atkSum != 0)    // 공격력 합계가 0이 아니면 (+ n) 추가
            {
                Console.WriteLine($"공격력 : {Player.atk + atkSum} (+{atkSum})");
            }
            else
            {
                Console.WriteLine($"공격력 : {Player.atk}");
            }

            if (defSum != 0)    // 방어력 합계가 0이 아니면 (+ n) 추가
            {
                Console.WriteLine($"방어력 : {Player.def + defSum} (+{defSum})");
            }
            else
            {
                Console.WriteLine($"방어력 : {Player.def}");
            }

            Console.WriteLine($"체 력 : {Player.hp}");
            Console.WriteLine($"Gold : {Player.gold} G");

            Console.WriteLine("〓〓〓〓〓〓〓〓〓\n");

            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();
            

            while (choose != 0)    // 제시된 숫자 이외의 것을 고를 경우 알림
            {
                Console.WriteLine("잘못된 입력입니다.\n");
                choose = Program.UserInput();
            }

            if (choose == 0)
            {
                Program.GameStart();
            }
        }
    }
}
