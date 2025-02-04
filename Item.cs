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
            public string type;
            public int itemNumber;

            public Item(string _itemName, int _stat, string _explain, int _itemGold, string _type, bool _isBought, bool _isEquipped, int _itemNumber)
            {
                itemName = _itemName;
                stat = _stat;
                explain = _explain;
                itemGold = _itemGold;
                type = _type;
                isBought = _isBought;
                isEquipped = _isEquipped;
                itemNumber = _itemNumber;
            }

        }
 }

