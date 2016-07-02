using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGames
{
    class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public Deck()
        {
            CreateDeck();
        }

        public Deck(int NumOfDecks)
        {
            for (int i = 0; i< NumOfDecks;i++)
            {
                CreateDeck();
            }
        }

        void CreateDeck()
        {
            if (Cards == null)
                Cards = new List<Card>();
            Cards.Add(new Card(1,1,1,"Ace of Spades","AceSpades.img",1));
            Cards.Add(new Card(2, 2, 1, "Two of Spades", "2Spades.img", 1));
            Cards.Add(new Card(3, 3, 1, "Three of Spades", "3Spades.img", 1));
            Cards.Add(new Card(4, 4, 1, "Four of Spades", "4Spades.img", 1));
            Cards.Add(new Card(5, 5, 1, "Five of Spades", "5Spades.img", 1));
            Cards.Add(new Card(6, 6, 1, "Six of Spades", "6Spades.img", 1));
            Cards.Add(new Card(7, 7, 1, "Seven of Spades", "7Spades.img", 1));
            Cards.Add(new Card(8, 8, 1, "Eight of Spades", "8Spades.img", 1));
            Cards.Add(new Card(9, 9, 1, "Nine of Spades", "9Spades.img", 1));
            Cards.Add(new Card(10, 10, 1, "Ten of Spades", "10Spades.img", 1));
            Cards.Add(new Card(11, 10, 1, "Jack of Spades", "jackSpades.img", 1));
            Cards.Add(new Card(12, 10, 1, "Queen of Spades", "queenSpades.img", 1));
            Cards.Add(new Card(13, 10, 1, "King of Spades", "kingSpades.img", 1));
            Cards.Add(new Card(1, 1, 2, "Ace of Diamonds", "AceDiamonds.img", 2));
            Cards.Add(new Card(2, 2, 2, "Two of Diamonds", "2Diamonds.img", 2));
            Cards.Add(new Card(3, 3, 2, "Three of Diamonds", "3Diamonds.img", 2));
            Cards.Add(new Card(4, 4, 2, "Four of Diamonds", "4Diamonds.img", 2));
            Cards.Add(new Card(5, 5, 2, "Five of Diamonds", "5Diamonds.img", 2));
            Cards.Add(new Card(6, 6, 2, "Six of Diamonds", "6Diamonds.img", 2));
            Cards.Add(new Card(7, 7, 2, "Seven of Diamonds", "7Diamonds.img", 2));
            Cards.Add(new Card(8, 8, 2, "Eight of Diamonds", "8Diamonds.img", 2));
            Cards.Add(new Card(9, 9, 2, "Nine of Diamonds", "9Diamonds.img", 2));
            Cards.Add(new Card(10, 10, 2, "Ten of Diamonds", "10Diamonds.img", 2));
            Cards.Add(new Card(11, 10, 2, "Jack of Diamonds", "jackDiamonds.img", 2));
            Cards.Add(new Card(12, 10, 2, "Queen of Diamonds", "queenDiamonds.img", 2));
            Cards.Add(new Card(13, 10, 2, "King of Diamonds", "kingDiamonds.img", 2));
            Cards.Add(new Card(1, 1, 1, "Ace of Clubs", "AceClubs.img", 3));
            Cards.Add(new Card(2, 2, 1, "Two of Clubs", "2Clubs.img", 3));
            Cards.Add(new Card(3, 3, 1, "Three of Clubs", "3Clubs.img", 3));
            Cards.Add(new Card(4, 4, 1, "Four of Clubs", "4Clubs.img", 3));
            Cards.Add(new Card(5, 5, 1, "Five of Clubs", "5Clubs.img", 3));
            Cards.Add(new Card(6, 6, 1, "Six of Clubs", "6Clubs.img", 3));
            Cards.Add(new Card(7, 7, 1, "Seven of Clubs", "7Clubs.img", 3));
            Cards.Add(new Card(8, 8, 1, "Eight of Clubs", "8Clubs.img", 3));
            Cards.Add(new Card(9, 9, 1, "Nine of Clubs", "9Clubs.img", 3));
            Cards.Add(new Card(10, 10, 1, "Ten of Clubs", "10Clubs.img", 3));
            Cards.Add(new Card(11, 10, 1, "Jack of Clubs", "jackClubs.img", 3));
            Cards.Add(new Card(12, 10, 1, "Queen of Clubs", "queenClubs.img", 3));
            Cards.Add(new Card(13, 10, 1, "King of Clubs", "kingClubs.img", 3));
            Cards.Add(new Card(1, 1, 2, "Ace of Hearts", "AceHearts.img",4));
            Cards.Add(new Card(2, 2, 2, "Two of Hearts", "2Hearts.img", 4));
            Cards.Add(new Card(3, 3, 2, "Three of Hearts", "3Hearts.img", 4));
            Cards.Add(new Card(4, 4, 2, "Four of Hearts", "4Hearts.img", 4));
            Cards.Add(new Card(5, 5, 2, "Five of Hearts", "5Hearts.img", 4));
            Cards.Add(new Card(6, 6, 2, "Six of Hearts", "6Hearts.img", 4));
            Cards.Add(new Card(7, 7, 2, "Seven of Hearts", "7Hearts.img", 4));
            Cards.Add(new Card(8, 8, 2, "Eight of Hearts", "8Hearts.img", 4));
            Cards.Add(new Card(9, 9, 2, "Nine of Hearts", "9Hearts.img", 4));
            Cards.Add(new Card(10, 10, 2, "Ten of Hearts", "10Hearts.img", 4));
            Cards.Add(new Card(11, 10, 2, "Jack of Hearts", "jackHearts.img", 4));
            Cards.Add(new Card(12, 10, 2, "Queen of Hearts", "queenHearts.img", 4));
            Cards.Add(new Card(13, 10, 2, "King of Hearts", "kingHearts.img", 4));
        }

        public void Shuffle(int Times, string Server, string Client, int Nonce)
        {
            for (int i =0; i<Times;i++)
            {
                List<Card> NewCards = new List<Card>();
                while (Cards.Count>0)
                {
                    int x = CasinoGames.Numbers.GetMultiLucky(Server, Client, Nonce, NewCards.Count,0,Cards.Count);
                    NewCards.Add(Cards[x]);
                    Cards.RemoveAt(x);
                }
                Cards = NewCards;
            }
            

        }

    }

    
    class Card
    {
        public Card()
        {

        }

        public Card(int Value, int Value2, int Color, string Name, string Image,int Suite)
        {
            this.Value = Value;
            this.Value2 = Value2;
            this.Color = Color;
            this.Name = Name;
            this.Image = Image;
            this.Suite = Suite;
        }
        public int Suite { get; set; }
        public int Value { get; set; }
        public int Value2 { get; set; }
        public int Color { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
