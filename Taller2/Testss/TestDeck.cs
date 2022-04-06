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
        public void TestAddCardToDeck()
        {
            //Comprobar que si se añaden las cartas
            List<Card> cards = new List<Card>();
            int costPointsc = 5;
            int costPointsd = 20;
            string name = "Character";
          
            Deck deck = new Deck(cards, costPointsd);
            Character card = new Character(1, name, Card.Card_Rarity.UltraRare,8,19);
            deck.AddCard(card);
           
            SupportSkill card1= new SupportSkill(1, name, Card.Card_Rarity.UltraRare,SupportSkill.Effect_Type.ReduceAll,9);
            deck.AddCard(card1);
            Character ch = new Character(1, name, Card.Card_Rarity.UltraRare, 8, 19);
            deck.AddCard(ch);
            Character ch2 = new Character(1, name, Card.Card_Rarity.UltraRare, 8, 19);
            deck.AddCard(ch2);

            //Deben haber 4 cartas en el deck
            Assert.AreEqual(4,deck.Amount);

            //Ahora el costPoint del deck es menor que el de la carta y no se añade
           /* Equip card2 = new Equip(14, "Equip", Card.Card_Rarity.Common);
            deck.AddCard(card2);
            Assert.IsFalse(3==deck.Amount);*/
        }

        [Test]
        public void TestSustraction()
        {
            List<Card> cards = new List<Card>();
           

            Deck deck = new Deck(cards, 20);
            Equip card = new Equip(1,"Character", Card.Card_Rarity.UltraRare);
            deck.AddCard(card);
            Assert.AreEqual(19, deck.CostPoints);
            Equip card1 = new Equip(9, "Equip", Card.Card_Rarity.UltraRare);
            deck.AddCard(card1);
            Assert.AreEqual(10, deck.CostPoints);

        }


        [Test]
        public void TestSupportSkillReduceAp()
        {
            List<Card> cards = new List<Card>();
            Deck deck = new Deck(cards, 5);
            SupportSkill reduceAPCard = new SupportSkill(1,"TestSkillReduceAp", Card.Card_Rarity.Common, SupportSkill.Effect_Type.ReduceAP, 10);

            //Character
            Character character = new Character(1, "Hero", Card.Card_Rarity.Common, 15, 20);

            character.ApplyEffect(reduceAPCard);
            Assert.AreEqual(5, character.AttackPoints);

        }

    }
}