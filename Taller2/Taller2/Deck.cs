using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
      class Deck
    {
        //debe tener una lista de carticas o sólo una referencia a la clase carta
        private List<Card> cards = new List<Card>();
        private int costPoints;

        public Deck(List<Card> cards, int costPoints)
        {
            this.cards = cards;
            this.costPoints = costPoints;
        }

        //public string Nombre { get => nombre; set => nombre = value; }

        public void CheckCostPoints()
        {

        }
    }
}
