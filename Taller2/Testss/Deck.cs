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
        private int characters;
        private int equip;
        private int suportSkill;
            
        public Deck(List<Card> cards, int costPoints)
        {
            this.cards = cards;
            this.costPoints = costPoints;
            amount = 0;
            characters = 0;
            equip = 0;  
            suportSkill = 0;
        }

        public int CostPoints { get => costPoints; }
        public List<Card> Cards { get => cards; }
        public int Amount { get => amount; set => amount = value; }
        public int Characters { get => amount; set => amount = value; } 
        public int Equip { get => equip; set => equip = value; }
        public int SuportSkill { get => suportSkill; set => suportSkill = value; }


        //public string Nombre { get => nombre; set => nombre = value; }

      
        public void AddCard(Card card)
        {
            
           // Card card = new Card(costPoints, name, rarity);
            if (this.costPoints >= card.CostPoints)
            {
                if (card is Character&&characters<5|| card is Equip && equip < 10|| card is SupportSkill && suportSkill < 5)
                {
                   characters ++;
                   equip++;
                   suportSkill++;  
                  cards.Add(card);
                }
               
                this.costPoints -= card.CostPoints;

                amount++;
            }
            if(this.costPoints < 0) this.costPoints = 0;
        }

        //poner restricciones a la baraja
        //hacer contadores dentro de la clase, para cada carta, que tenga un punto para que se active booleano 
        
    }
}
