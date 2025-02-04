﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Inventory
    {
        public static List<Item> InvenItem = new List<Item>();
        // 아이템 넘버가 들어온 순서대로 올 수 있도록






        static public void InventoryCheck()
        {
            for (int i = 0; i < InvenItem.Count; i++)
            {
                InvenItem[i].itemNumber = i + 1;
            }


            Console.Clear();

            Console.WriteLine("<인벤토리>\n보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");


            for (int i = 0; i < InvenItem.Count; i++)
            {
                Console.Write($"- {i + 1}. ");
                if (InvenItem[i].isEquipped)
                {
                    Console.Write("[E] ");
                }
                Console.WriteLine($"{InvenItem[i].itemName} | {InvenItem[i].powerType} + {InvenItem[i].power} | {InvenItem[i].explain}");
            }


            Console.WriteLine("\n1. 장착 관리");
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
                Console.WriteLine("잘못된 입력입니다.\n");
                InventoryCheck();
            }

        }


        static public void InventoryManage()
        {
            Console.Clear();

            Console.WriteLine("<인벤토리 - 장착 관리>\n보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");


            // 아이템 목록
            for (int i = 0; i < InvenItem.Count; i++)
            {
                Console.Write($"- {i + 1}. ");
                if (InvenItem[i].isEquipped)
                {
                    Console.Write("[E] ");
                }
                Console.WriteLine($"{InvenItem[i].itemName} | {InvenItem[i].powerType} + {InvenItem[i].power} | {InvenItem[i].explain}");
            }

            Console.WriteLine("\n0. 나가기\n");


            int choose = Program.UserInput();

            while (choose != 0) {
                if (choose > 0 && choose <= InvenItem.Count) // 일치하는 아이템을 선택했다면(예제에서 1~3 선택시)
                {
                    if (!InvenItem[choose - 1].isEquipped)  // 장착중이지 않다면 → 장착
                    {
                        InvenItem[choose - 1].isEquipped = true; //  [E] 표시 추가
                        Console.WriteLine("아이템을 장착하였습니다.\n");
                    }
                    else  //  이미 장착중이라면 → 장착 해제
                    {
                        InvenItem[choose - 1].isEquipped = false;
                        Console.WriteLine("아이템을 해제하였습니다.\n");
                    }
                }
                else if (choose == 0)
                {
                    InventoryCheck();
                }
                else  //  일치하는 아이템을 선택했지 않았다면(예제에서 1~3이외 선택시)
                {
                    Console.WriteLine("잘못된 입력입니다\n");
                }

                choose = Program.UserInput();
            }

            if (choose == 0)
            {
                InventoryCheck();
            }




            //if (choose > 0 && choose <= InvenItem.Count) // 일치하는 아이템을 선택했다면(예제에서 1~3 선택시)
            //{
            //    if (InvenItem[choose - 1].isEquipped = false)  // 장착중이지 않다면 → 장착
            //    {
            //            InvenItem[choose - 1].isEquipped = true ; //  [E] 표시 추가
            //            Console.WriteLine("아이템을 장착하였습니다.");
            //    }
            //    else  //  이미 장착중이라면 → 장착 해제
            //    {
            //            InvenItem[choose - 1].isEquipped = false;
            //            Console.WriteLine("아이템을 해제하였습니다.");
            //    }
            //}
            //else if (choose == 0)
            //{
            //      InventoryCheck();
            //}
            //else  //  일치하는 아이템을 선택했지 않았다면(예제에서 1~3이외 선택시)
            //{
            //      Console.WriteLine("잘못된 입력입니다\n");
            //}





        }
        }
    }

