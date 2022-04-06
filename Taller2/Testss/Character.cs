using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    class Character: Card
    {
        private int attackPoints;
        private int resistPoints;
        public enum C_Affinity { Knight, Mage, Undead };
        private C_Affinity affinity;
        public Equip[] array;
        public Character(int costPoints, string name, Card_Rarity rarity, int attackPoints, int resistPoints) : base(costPoints, name, rarity)
        {
            this.attackPoints = attackPoints;
            this.resistPoints = resistPoints;
        }

        public int AttackPoints { get => attackPoints; }
        public int ResistPoints { get => resistPoints; }
        public C_Affinity Affinity { get => affinity; set => affinity = value; }
    }
}
