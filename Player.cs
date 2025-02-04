using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexTRPG
{
    public class Player
    {
       static public int lv = 1;
       static public string name;
       static public string job = "전사";
       static public int atk = 10;
       static public int def = 5;
       static public int hp = 100;
       static public int gold = 1500;


        public Player(int _lv, string _name, string _job, int _atk, int _def, int _hp, int _gold)
        {
            lv = _lv;
            name = _name;
            job = _job;
            atk = _atk;
            def = _def;
            hp = _hp;
            gold = _gold;
        }
    }
}
