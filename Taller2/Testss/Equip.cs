using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
     class Equip: Card
    {
        public enum Target_Attribute {AP, RP, ALL };
        public enum E_Affinity { Knight, Mage, Undead, All };
        private E_Affinity affinity;
        private Target_Attribute target_Attribute;
        int effectPoints;

        internal E_Affinity Affinity { get => affinity; }
        internal Target_Attribute Target_Attribute1 { get => target_Attribute;}
        public int EffectPoints { get => effectPoints;}

        public Equip(int costPoints, string name, Card_Rarity rarity, Target_Attribute target_Attribute, int effectPoints, E_Affinity affinity) : base(costPoints, name, rarity)
        {
            this.target_Attribute = target_Attribute; 
            this.effectPoints = effectPoints;
            this.affinity = affinity; 
        }
    }
}
