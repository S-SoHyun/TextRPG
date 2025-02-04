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
            public int stat;
            public string explain;
            public int itemGold;
            public bool isBought;
            public bool isEquipped;

            public Item(string _itemName, int _stat, string _explain, int _itemGold, bool _isBought, bool _isEquipped)
            {
                itemName = _itemName;
                stat = _stat;
                explain = _explain;
                itemGold = _itemGold;
                isBought = _isBought;
                isEquipped = _isEquipped;
            }
        }



 }

