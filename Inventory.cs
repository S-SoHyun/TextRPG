using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Inventory
    {

        static public void InventoryCheck()
        {
            Console.WriteLine("\n인벤토리 \n보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");

            List<Item> inven = new List<Item>();

            for (int i = 0; i < inven.Count; i++)
            {
                Console.Write($"- {i + 1}.");
                //if (inven.equipped)
                //{
                //    Console.Write("[E]");
                //}
                //else
                //{
                //    Console.WriteLine($"{inven[i].itemName} | {inven[i].def} {inven[i].explain}");
                //}
            }

            // 인벤 목록 구현!!!!!!!!!!!!!!!!!!!!!!!!!!



            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            if (choose == 1)
            {
                InventoryManage();
            }
            else if (choose == 0)
            {
                Program.GameStart();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                InventoryCheck();
            }

        }


        static public void InventoryManage()
        {
            Console.WriteLine("\n인벤토리 - 장착 관리 \n보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]\n");





        }




    }
}
