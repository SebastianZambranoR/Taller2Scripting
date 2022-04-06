using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
     class Deck
    {
        //debe tener una lista de carticas o sólo una referencia a la clase carta
        private List<Card> cards = new List<Card>();
        private int costPoints;
        private int amount;

        public Deck(List<Card> cards, int costPoints)
        {
            this.cards = cards;
            this.costPoints = costPoints;
            amount = 0;
        }

        public int CostPoints { get => costPoints; }
        public List<Card> Cards { get => cards; }
        public int Amount { get => amount; set => amount = value; }

        //public string Nombre { get => nombre; set => nombre = value; }

      
        public void AddCard(Card card)
        {
            
           // Card card = new Card(costPoints, name, rarity);
            if (this.costPoints >= card.CostPoints)
            {
               cards.Add(card);
                amount ++;
               
               this.costPoints -= card.CostPoints;
              
            }
            if(this.costPoints < 0) this.costPoints = 0;
        }

        public void CreateCard(int costPoints, string name, Card.Card_Rarity rarity)
        {
            Card card = new Card(costPoints, name, rarity);
        }
    }
}
