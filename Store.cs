using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Store
    {
        public static List<Item> ItemList = new List<Item>();

        static private void AllocateNumber()
        { 
            for (int i = 0; i < ItemList.Count; i++)
            {
                ItemList[i].itemNumber = i + 1;
            }
        }

        static void AddStoreItem()
        {
            ItemList.Add(new Item("수련자 갑옷", 5, "수련에 도움을 주는 갑옷입니다.", 1000, "방어력", false, false, 0));
            ItemList.Add(new Item("무쇠갑옷", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1500, "방어력", false, false, 0));
            ItemList.Add(new Item("스파르타의 갑옷", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 1000, "방어력", false, false, 0));
            ItemList.Add(new Item("낡은 검", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 500, "공격력", false, false, 0));
            ItemList.Add(new Item("청동 도끼", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1000, "공격력", false, false, 0));
            ItemList.Add(new Item("스파르타의 창", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 1000, "공격력", false, false, 0));
            AllocateNumber();
        }

        static public void InStore()
        {
            if (ItemList.Count < 1)
            {
                AddStoreItem();
            }

            Console.Clear();

            Console.WriteLine("<상점>");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
            Console.WriteLine($"[보유 골드]\n{Player.gold} G \n");
            Console.WriteLine("[아이템 목록]");


            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");
            
            for (int i = 0; i < ItemList.Count; i++)
            {
                Console.Write($"- {ItemList[i].itemName} | {ItemList[i].powerType} + {ItemList[i].power} | {ItemList[i].explain} | ");
                
                if (ItemList[i].isBought)
                {
                    Console.Write("구매완료");
                }
                else
                {
                    Console.Write($"{ItemList[i].itemGold} G");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");


            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            while (choose != 0 && choose != 1) {            
                Console.WriteLine("잘못된 입력입니다.\n");
                choose = Program.UserInput();
            }

            if (choose == 1)
            {
                ItemPurchase();
            }
            else if (choose == 0)
            {
                Program.GameStart();
            }
        }

        static private void ItemPurchase()
        {
            Console.Clear();

            Console.WriteLine("<상점 - 아이템 구매>");
            Console.WriteLine(" 필요한 아이템을 얻을 수 있는 상점입니다.\n");
            Console.WriteLine($"[보유 골드]\n{Player.gold} G \n");
            Console.WriteLine("[아이템 목록]");

            
            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");

            for (int i = 0; i < ItemList.Count; i++)
            {
                Console.Write($" - {ItemList[i].itemNumber} {ItemList[i].itemName} | {ItemList[i].powerType} + {ItemList[i].power} | {ItemList[i].explain} | ");

                if (ItemList[i].isBought)   // 이미 구매한 상태라면
                {
                    Console.Write("구매완료 ");
                }
                else
                {
                    Console.Write($"{ItemList[i].itemGold} G");  // 구매가 되지 않았다면
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");


            Console.WriteLine("0. 나가기\n");
            int choose = Program.UserInput();

            while (choose != 0)
            {
                if (choose > 0 && choose <= ItemList.Count) // 일치하는 아이템 선택
                {
                    if (ItemList[choose - 1].isBought) //    근데 그게 구매가 된 거다
                    {
                        Console.WriteLine("이미 구매한 아이템입니다.");
                    }
                    else  //    구매가 안 돼서 구매 가능하다
                    {
                        if (Player.gold >= ItemList[choose - 1].itemGold)     //근데 돈이 돼서 진짜 살 수 있다
                        {
                            Player.gold -= ItemList[choose - 1].itemGold;     //   재화 감소
                            Inventory.InvenItem.Add(ItemList[choose - 1]);    //   인벤토리에 아이템 추가
                            ItemList[choose - 1].isBought = true;             // 상점에 구매완료 표시
                            Console.WriteLine("구매를 완료했습니다.\n");
                        }
                        else    //  근데 보유 재화가 부족하다
                        {
                            Console.WriteLine("Gold가 부족합니다.\n");
                        }
                    }
                }
                else    //일치하는 아이템을 선택하지 않았다면
                {
                    Console.WriteLine("잘못된 입력입니다.\n");
                }

                choose = Program.UserInput();

            }

            if (choose == 0)
            {
                InStore();
            }
        }
    }
}


