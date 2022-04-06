using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
     class Equip: Card
    {
        public int targetAttribute;
        public int effectPoints;
        public Equip(int costPoints, string name, Card_Rarity rarity) : base(costPoints, name, rarity)
        {
        }
    }
}
