using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    class Rest
    {
        static public void Resting()
        {
            Console.Clear();
            
            Console.WriteLine("<휴식하기>");
            Console.Write("500 G 를 내면 체력을 회복할 수 있습니다.");
            Console.WriteLine($" (보유 골드 : {Player.gold} G)");

            Console.WriteLine("\n1. 휴식하기");
            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            while (choose != 0)
            {
               if (choose == 1)    // 휴식하기 고르면 보유 골드에서 500원 빼고 체력 100으로 만듦 
               {
                    if (Player.gold >= 500)
                    {
                        Player.hp = 100;
                        Player.gold -= 500;
                        Console.WriteLine($"휴식을 완료했습니다. (보유 골드 : {Player.gold} G)");
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
               }
               else
               {
                    Console.WriteLine("잘못된 입력입니다.");
               }

                choose = Program.UserInput();
            }

            if (choose == 0)
            {
                Program.GameStart();    // 게임 시작 창으로 돌아감
            }
        }
    }
}

