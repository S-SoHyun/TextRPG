using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Status
    {

        static public void StatusCheck()         // 상태 보기
        {
            Console.WriteLine("\n<상태 보기>\n캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine($"Lv. {Player.lv}");
            Console.WriteLine($"{Player.name} ( {Player.job} ) ");
            Console.WriteLine($"공격력 : {Player.atk}");
            Console.WriteLine($"방어력 : {Player.def}");
            Console.WriteLine($"체 력 : {Player.hp}");
            Console.WriteLine($"Gold : {Player.gold}\n");

            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            if (choose == 0)
            {
                Program.GameStart();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                Program.UserInput();
            }
        }
    }
}
