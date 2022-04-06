using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaller2
{
     class D
    {
        private List<Cl> cards = new List<Cl>();
        private int costPoints;
        private int amount;

        public D(List<Cl> cards, int costPoints)
        {
            this.cards = cards;
            this.costPoints = costPoints;
            amount = 0;
        }

        public int CostPoints { get => costPoints; }
        public List<Cl> Cards { get => cards; }
        public int Amount { get => amount; set => amount = value; }

        //public string Nombre { get => nombre; set => nombre = value; }

    

        public void AddCard(Cl card)
        {

            // Card card = new Card(costPoints, name, rarity);
            if (this.costPoints >= card.CostPoints)
            {
                cards.Add(card);
                amount++;

                this.costPoints -= card.CostPoints;
            }
        }

        public void CreateCard(int costPoints, string name, Cl.Card_Rarity rarity)
        {
            Cl card = new Cl(costPoints, name, rarity);
        }
    }
}
