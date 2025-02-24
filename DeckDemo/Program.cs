public class Test
{
    public static void Main(string[] args)
     {  
        /*test case for card class
        Card card1 = new Card(Rank.Ace, Suit.Spades);
        Console.WriteLine($"{card1.Rank} of {card1.Suit}");
        Console.WriteLine($"FaceUp: {card1.FaceUp}");
        Console.WriteLine("Flipping the card!");
        card1.FlipOver();
        Console.WriteLine($"FaceUp: {card1.FaceUp}");
        */

        //test case for deck - intialize, cut, shuffle
        Deck deck = new Deck();
        Console.WriteLine("Inital Deck:");

        foreach(var card in deck.Cards)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }

        Console.WriteLine("\nCutting Deck");
        deck.Cut(26);

        foreach(var card in deck.Cards)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }

        Console.WriteLine("\nShuffled Deck");
        deck.Shuffle();

        foreach(var card in deck.Cards)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}");
        }


    }

}
