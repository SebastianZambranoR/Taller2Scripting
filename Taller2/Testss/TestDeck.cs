using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace Testss
{
    public class Tests
    {
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
            //Comprobar que si se añaden las cartas
            List<Card> cards = new List<Card>();
            int costPointsc = 5;
            int costPointsd = 20;
            string name = "Character";
          
            Deck deck = new Deck(cards, costPointsd);
            Card card = new Card(costPointsc, name, Card.Card_Rarity.UltraRare);
            deck.AddCard(card);
           
            Card card1= new Card(9, name, Card.Card_Rarity.UltraRare);
            deck.AddCard(card1);
            //Deben haber 2 cartas en el deck
            Assert.AreEqual(2,deck.Amount);
            //Ahora el costPoint del deck es menor que el de la carta y no se añade
            Card card2 = new Card(14, "Equip", Card.Card_Rarity.Common);
            deck.AddCard(card2);
            Assert.IsFalse(3==deck.Amount);


        }

        [Test]
        public void TestSustraction()
        {
            List<Card> cards = new List<Card>();
           

            Deck deck = new Deck(cards, 20);
            Card card = new Card(1,"Character", Card.Card_Rarity.UltraRare);
            deck.AddCard(card);
            Assert.AreEqual(19, deck.CostPoints);
            Card card1 = new Card(9, "Equip", Card.Card_Rarity.UltraRare);
            deck.AddCard(card1);
            Assert.AreEqual(10, deck.CostPoints);

        }

    }
}