using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Item
    {       
            public string itemName;
            public int power; // 공격력 / 방어력 수치
            public string explain;
            public float itemGold;
            public bool isBought;
            public bool isEquipped;
            public string powerType;
            public int itemNumber;

            public Item(string _itemName, int _power, string _explain, float _itemGold, string _powerType, bool _isBought, bool _isEquipped, int _itemNumber)
            {
                itemName = _itemName;
                power = _power;
                explain = _explain;
                itemGold = _itemGold;
                powerType = _powerType;
                isBought = _isBought;
                isEquipped = _isEquipped;
                itemNumber = _itemNumber;
            }
    }
 }

