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
            Character card = new Character(5, name, Card.Card_Rarity.UltraRare,8,19);
            deck.AddCard(card);
           
            SupportSkill card1= new SupportSkill(5, name, Card.Card_Rarity.UltraRare,SupportSkill.Effect_Type.ReduceAll,9);
            deck.AddCard(card1);
            Character ch = new Character(1, name, Card.Card_Rarity.UltraRare, 8, 19);
            deck.AddCard(ch);
            Character ch2 = new Character(1, name, Card.Card_Rarity.UltraRare, 8, 19);
            deck.AddCard(ch2);

            //Deben haber 4 cartas en el deck
            Assert.AreEqual(4,deck.Amount);

            //Ahora el costPoint del deck es menor que el de la carta y no se añade
           Equip card2 = new Equip(14, "Equip", Card.Card_Rarity.Common, Equip.Target_Attribute.ALL, 9, Equip.E_Affinity.Undead);
            deck.AddCard(card2);
            Assert.IsTrue(4==deck.Amount);
            
        }

        [Test]
        public void TestSustraction()
        {
            List<Card> cards = new List<Card>();
           

            Deck deck = new Deck(cards, 20);
            Equip card = new Equip(1,"Character", Card.Card_Rarity.UltraRare,Equip.Target_Attribute.ALL,8,Equip.E_Affinity.Undead);
            deck.AddCard(card);
            Assert.AreEqual(19, deck.CostPoints);
            Equip card1 = new Equip(9, "Equip", Card.Card_Rarity.UltraRare, Equip.Target_Attribute.ALL,9, Equip.E_Affinity.Undead);
            deck.AddCard(card1);
            Assert.AreEqual(10, deck.CostPoints);

        }


        [Test]
        public void TestSupportSkillReduceAp()
        {
            List<Card> cards = new List<Card>();
            SupportSkill reduceAPCard = new SupportSkill(1,"TestSkillReduceAp", Card.Card_Rarity.Common, SupportSkill.Effect_Type.ReduceAP, 10);

            //Character
            Character character = new Character(1, "Hero", Card.Card_Rarity.Common, 15, 20);

            character.ApplyEffect(reduceAPCard);
            Assert.AreEqual(5, character.AttackPoints);

        }

        [Test]
        public void TestSupportSkillReduceRp()
        {
            List<Card> cards = new List<Card>();
            SupportSkill reduceAPCard = new SupportSkill(1, "TestSkillReduceAp", Card.Card_Rarity.Common, SupportSkill.Effect_Type.ReduceRP, 10);

            //Character
            Character character = new Character(1, "Hero", Card.Card_Rarity.Common, 15, 20);

            character.ApplyEffect(reduceAPCard);
            Assert.AreEqual(10, character.ResistPoints);

        }

        [Test]
        public void TestSupportSkillReduceAllStats()
        {
            List<Card> cards = new List<Card>();
            SupportSkill reduceAPCard = new SupportSkill(1, "TestSkillReduceAp", Card.Card_Rarity.Common, SupportSkill.Effect_Type.ReduceAll, 10);

            //Character
            Character character = new Character(1, "Hero", Card.Card_Rarity.Common, 15, 20);

            character.ApplyEffect(reduceAPCard);
            Assert.AreEqual(5, character.AttackPoints);
            Assert.AreEqual(10, character.ResistPoints);
        }

        [Test]
        public void TestSupportSkillDestroyEquip()
        {
            List<Card> cards = new List<Card>();
            SupportSkill reduceAPCard = new SupportSkill(1, "TestSkillReduceDestroyEquip", Card.Card_Rarity.Common, SupportSkill.Effect_Type.DestroyEquip, 0);

            //Character
            Character character = new Character(1, "Hero", Card.Card_Rarity.Common, 15, 20);
            Equip ApEquip = new Equip(2, "TestApEquip", Card.Card_Rarity.Common, Equip.Target_Attribute.AP, 5, Equip.E_Affinity.All);

            character.AddEquip(ApEquip);
            character.AddEquip(ApEquip);
            character.AddEquip(ApEquip);

            Assert.AreEqual(3, character.characterEquip.Count);

            character.ApplyEffect(reduceAPCard);

            Assert.AreEqual(2, character.characterEquip.Count);

        }

        [Test]
        public void TestCharacterConflict()
        {
            Match match = new Match();
            List<Card> cards = new List<Card>();
            List<Card> cards2 = new List<Card>();
            Deck deck = new Deck(cards, 20);
            Deck deck2 = new Deck(cards2, 20);
            match.Addplayer(deck);
            match.Addplayer(deck2);
            Character character = new Character(1, "Hero", Card.Card_Rarity.Common, 15, 20);
            Character character2 = new Character(1, "Hero2", Card.Card_Rarity.Common, 8, 20);
            deck.AddCard(character);
            deck2.AddCard(character2);

            Assert.AreEqual(1,deck.Cards.Count);
            Assert.AreEqual(1, deck2.Cards.Count);

            Assert.Null(match.MatchWinner);

            character.Attack(character2);

            Assert.AreEqual(5, character2.ResistPoints);

            character.Attack(character2);

            Assert.AreEqual(0, deck2.Cards.Count);
            Assert.AreEqual(deck, match.MatchWinner);


        }
    }
}