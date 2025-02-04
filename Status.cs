using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Status
    {
        static int atkSum = 0;
        static int defSum = 0;

        static private int AtkSum()
        {
            foreach (var item in Inventory.InvenItem)
            {
                if (item.powerType == "공격력" && item.isEquipped)
                {
                    atkSum += item.power;
                }
            }
            return atkSum;
        }
        static private int DefSum()
        {
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

            Console.WriteLine("<상태 보기>\n캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine($"Lv. {Player.lv}");
            Console.WriteLine($"{Player.name} ( {Player.job} ) ");


            if (atkSum != 0)
            {
                Console.WriteLine($"공격력 : {Player.atk + atkSum} (+{atkSum})");
            }
            else
            {
                Console.WriteLine($"공격력 : {Player.atk}");
            }

            if (defSum != 0)
            {
                Console.WriteLine($"방어력 : {Player.def + defSum} (+{defSum})");
            }
            else
            {
                Console.WriteLine($"방어력 : {Player.def}");
            }

            Console.WriteLine($"체 력 : {Player.hp}");
            Console.WriteLine($"Gold : {Player.gold} G\n");

            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            if (choose == 0)
            {
                Program.GameStart();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.\n");

                Program.UserInput();
            }
        }
    }
}
