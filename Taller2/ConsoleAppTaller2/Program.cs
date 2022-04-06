// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Cl> cards = new List<Cl>();
int costPointsc = 5;
int costPointsd = 8;
string name = "Character";//Card card = 
Deck deck = new Deck(cards, costPointsd);
Card card = new Card(costPointsc, name, Card.Card_Rarity.UltraRare);
deck.AddCard(card);
// Assert.AreEqual(1, deck.Amount);
Card card1 = new Card(9, name, Card.Card_Rarity.UltraRare);
deck.AddCard(card1);