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
        public static List<Item> ItemList = new List<Item>();    // 아이템 담을 리스트 생성

        static private void AllocateNumber()    // 아이템이 들어오는 순서대로 번호 할당
        { 
            for (int i = 0; i < ItemList.Count; i++)
            {
                ItemList[i].itemNumber = i + 1;
            }
        }

        static void AddStoreItem()    // 상점 아이템 생성
        {
            ItemList.Add(new Item("수련자 갑옷", 5, "수련에 도움을 주는 갑옷입니다.", 1000, "방어력", false, false, 0));
            ItemList.Add(new Item("무쇠갑옷", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1500, "방어력", false, false, 0));
            ItemList.Add(new Item("스파르타의 갑옷", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 1000, "방어력", false, false, 0));
            ItemList.Add(new Item("낡은 검", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 500, "공격력", false, false, 0));
            ItemList.Add(new Item("청동 도끼", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1000, "공격력", false, false, 0));
            ItemList.Add(new Item("스파르타의 창", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 1000, "공격력", false, false, 0));
            AllocateNumber();
        }

        static public void InStore()    // 상점 들어옴
        {
            if (ItemList.Count < 1)    // 아이템 리스트 안에 아무것도 없을 경우 상점 아이템을 생성
            {
                AddStoreItem();
            }

            Console.Clear();

            Console.WriteLine("<상점>");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
            Console.WriteLine($"[보유 골드]");
            Console.WriteLine($"{Player.gold} G \n");
            Console.WriteLine("[아이템 목록]");


            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");
            
            for (int i = 0; i < ItemList.Count; i++)
            {
                Console.Write($"- {ItemList[i].itemName} | {ItemList[i].powerType} + {ItemList[i].power} | {ItemList[i].explain} | ");
                
                if (ItemList[i].isBought)    // 아이템을 구매했으면 끝에 구매완료가 나옴
                {
                    Console.Write("구매완료");
                }
                else    // 구매 안 했으면 끝에 아이템 가격이 나옴
                {
                    Console.Write($"{ItemList[i].itemGold} G");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");
            

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기\n");

            int choose = Program.UserInput();

            while (choose != 0 && choose != 1) {            // 제시된 숫자 이외의 것을 고를 경우 알림
                Console.WriteLine("잘못된 입력입니다.\n");
                choose = Program.UserInput();
            }

            if (choose == 1)
            {
                ItemPurchase();    // 아이템 구매 창으로 감
            }
            else if (choose == 0)
            {
                Program.GameStart();    // 시작 화면으로 돌아감
            }
        }

        static private void ItemPurchase()    // 아이템 구매 창
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
                if (choose > 0 && choose <= ItemList.Count)    // 아이템 선택
                {
                    if (ItemList[choose - 1].isBought)    // 이미 구매가 됐다면 구매 막기
                    {
                        Console.WriteLine("이미 구매한 아이템입니다.");
                    }
                    else
                    {
                        if (Player.gold >= ItemList[choose - 1].itemGold)     // 구매가 안 됐고 보유 골드도 충분하다면
                        {
                            Player.gold -= ItemList[choose - 1].itemGold;
                            Inventory.InvenItem.Add(ItemList[choose - 1]);    //   인벤토리 리스트에 구매한 아이템 추가
                            ItemList[choose - 1].isBought = true;
                            Console.WriteLine("구매를 완료했습니다.\n");
                        }
                        else    //  구매가 안 됐지만 보유 골드가 부족하면 구매 막기
                        {
                            Console.WriteLine("Gold가 부족합니다.\n");
                        }
                    }
                }
                else    // 제시된 숫자 이외의 것을 고를 경우 알림
                {
                    Console.WriteLine("잘못된 입력입니다.\n");
                }

                choose = Program.UserInput();

            }

            if (choose == 0)
            {
                InStore();    // 상점으로 돌아감
            }

            // ItemSell() 미구현 - isBought, isEquipped를 이용해서 간편하게 처리하고 싶었는데 잘 안 됐음
            //static private void ItemSell() 
            //{
            //    Console.Clear();

            //    Console.WriteLine("<상점 - 아이템 판매>");
            //    Console.WriteLine(" 필요한 아이템을 얻을 수 있는 상점입니다.\n");
            //    Console.WriteLine($"[보유 골드]\n{Player.gold} G \n");

            //    Console.WriteLine("[아이템 목록]");
            //    Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");


            //    Inventory.AllocateNumber();

            //    for (int i = 0; i < Inventory.InvenItem.Count; i++)
            //    {
            //        Console.Write($"- ");
            //        if (Inventory.InvenItem[i].isBought)   // 산 거 다시 돌려놓기
            //        {
            //            Inventory.InvenItem[i].isBought = false;
            //        }
            //        Console.WriteLine($" {Inventory.InvenItem[i].itemNumber} {Inventory.InvenItem[i].itemName} | {Inventory.InvenItem[i].powerType} + {Inventory.InvenItem[i].power} | {Inventory.InvenItem[i].explain} | {Inventory.InvenItem[i].itemGold * 0.85} G");
            //    }

            //    Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓\n");

            //    Console.WriteLine("0. 나가기\n");
            //    int choose = Program.UserInput();

            //    while (choose != 0)
            //    {
            //        if (choose > 0 && choose <= Inventory.InvenItem.Count)
            //        {
            //            if (!Inventory.InvenItem[choose - 1].isBought)    // 이미 판매한 경우
            //            {
            //                Console.WriteLine("이미 판매한 아이템입니다.");
            //            }
            //            else if (Inventory.InvenItem[choose - 1].isBought && Inventory.InvenItem[choose - 1].isEquipped)    // 판매 안 했는데 장착이 된 경우
            //            {
            //                Inventory.InvenItem[choose - 1].isEquipped = false;
            //                Inventory.InvenItem[choose - 1].isBought = false;
            //                Player.gold += Inventory.InvenItem[choose - 1].itemGold * 0.85f;
            //                Inventory.InvenItem.Remove(Inventory.InvenItem[choose - 1]);
            //                Console.WriteLine("아이템을 성공적으로 판매하였습니다.");
            //            }
            //            else if (Inventory.InvenItem[choose - 1].isBought && Inventory.InvenItem[choose - 1].isEquipped == false) // 판매 안 했는데 장착은 안 된 경우
            //            {
            //                Inventory.InvenItem[choose - 1].isBought = false;
            //                Player.gold += Inventory.InvenItem[choose - 1].itemGold * 0.85f;
            //                Console.WriteLine("아이템을 성공적으로 판매하였습니다.");
            //            }
            //        }
            //        else    // 제시된 숫자 이외의 것을 고를 경우 알림
            //        {
            //            Console.WriteLine("잘못된 입력입니다.\n");
            //        }

            //        choose = Program.UserInput();
            //    }
        }
    }
}


