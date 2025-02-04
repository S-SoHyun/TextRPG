using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Inventory
    {
        public static List<Item> InvenItem = new List<Item>();    // 인벤템 리스트 생성. 상점에서 구매한 아이템이 여기로 들어올 것

        static private void AllocateNumber()    // 아이템이 들어오는 순서대로 번호 할당
        {
            for (int i = 0; i < InvenItem.Count; i++)
            {
                InvenItem[i].itemNumber = i + 1;
            }
        }

        static public void InventoryCheck()    // 인벤토리 확인 창
        {
            AllocateNumber();

            Console.Clear();

            Console.WriteLine("<인벤토리>");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
          
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");

            for (int i = 0; i < InvenItem.Count; i++)
            {
                Console.Write($"- ");
                if (InvenItem[i].isEquipped)
                {
                    Console.Write("[E]");
                }
                Console.WriteLine($"{InvenItem[i].itemName} | {InvenItem[i].powerType} + {InvenItem[i].power} | {InvenItem[i].explain}");
            }

            Console.WriteLine("\n〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            while (choose != 0 && choose != 1)    // 제시된 숫자 이외의 것을 고를 경우 알림
            {
                Console.WriteLine("잘못된 입력입니다.\n");
                choose = Program.UserInput();
            }

            if (choose == 1)
            {
                InventoryManage();    // 인벤토리 관리 창으로 감
            }
            else if (choose == 0)
            {
                Program.GameStart();    // 게임 시작 화면으로 돌아감
            }
        }


        static public void InventoryManage()    // 인벤토리 관리
        {
            Console.Clear();

            Console.WriteLine("<인벤토리 - 장착 관리>");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");

            // 아이템 목록
            for (int i = 0; i < InvenItem.Count; i++)
            {
                Console.Write($"- {i + 1}. ");
                if (InvenItem[i].isEquipped)    // 아이템이 장착됐다면 앞에 [E]를 붙임
                {
                    Console.Write("[E] ");
                }
                Console.WriteLine($"{InvenItem[i].itemName} | {InvenItem[i].powerType} + {InvenItem[i].power} | {InvenItem[i].explain}");
            }

            Console.WriteLine("\n〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");

            Console.WriteLine("0. 나가기\n");


            int choose = Program.UserInput();

            while (choose != 0) {
                if (choose > 0 && choose <= InvenItem.Count)    // 아이템 선택
                {
                    if (!InvenItem[choose - 1].isEquipped)    // 장착 상태가 아니면 장착
                    {
                        InvenItem[choose - 1].isEquipped = true;
                        Console.WriteLine("아이템을 장착하였습니다.\n");
                    }
                    else  //  이미 장착 상태라면 장착 해제
                    {
                        InvenItem[choose - 1].isEquipped = false;
                        Console.WriteLine("아이템을 해제하였습니다.\n");
                    }
                }
                else  // 제시된 숫자 이외의 것을 고를 경우 알림
                {
                    Console.WriteLine("잘못된 입력입니다\n");
                }

                choose = Program.UserInput();
            }

            if (choose == 0)
            {
                InventoryCheck();    // 인벤토리 확인 창으로 돌아감
            }
        }
     }
}

