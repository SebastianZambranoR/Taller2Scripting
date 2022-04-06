using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaller2
{
    class Cl
    {

        private Random rnd = new Random();

        private int costPoints;

        private string name;
        public enum Card_Rarity { Common, Rare, SuperRare, UltraRare };
        private Card_Rarity rarity;

        public Cl(int costPoints, string name, Card_Rarity rarity)
        {

            this.costPoints = costPoints;
            this.name = name;
            this.rarity = rarity;

        }
        public int CostPoints { get => costPoints; }
        public string Name { get => name; set => name = value; }
        public Card_Rarity Rarity { get => rarity; set => rarity = value; }
    }
}
