using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
     class Equip: Card
    {
        public enum E_TargetAttribute { AP,RP,ALL};
        private E_TargetAttribute target;
        public int effectPoints;
        public enum C_Affinity { Knight, Mage, Undead,All };
        private C_Affinity affinity;
        public Equip(int costPoints, string name, Card_Rarity rarity) : base(costPoints, name, rarity)
        {
        }
        public int EffectPoints { get => effectPoints; }
        public E_TargetAttribute Target { get => target; set => target = value; }
        public C_Affinity Affinity { get => affinity; set => affinity = value; }

    }
}
