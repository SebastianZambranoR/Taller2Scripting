using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace Testss
{
    public class Tests
    {
        private Deck deck;
      


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            
        }

        public void TestCreateDeck()
        {

        }
        [Test]
        public void TestAddCardToDeck()
        {
            //quiero comprobar que si el costd es mayor al costc, se añada la carta
            List<Card> cards = new List<Card>();
            int costPointsc = 5;
            int costPointsd = 8;
            string name = "Character";
           //Card card = 
            Deck deck = new Deck(cards, costPointsd);
            
            deck.AddCard(costPointsc, name, Card.Card_Rarity.Common);
           

       
        }
    }
}