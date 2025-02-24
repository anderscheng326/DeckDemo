public class Test
{
    public static void Main(string[] args)
     {  
        //test case for card class
        Card card1 = new Card(Rank.Ace, Suit.Spades);
        Console.WriteLine($"{card1.Rank} of {card1.Suit}");
        Console.WriteLine($"FaceUp: {card1.IsFaceUp}");
        Console.WriteLine("Flipping the card!");
        card1.FlipOver();
        Console.WriteLine($"FaceUp: {card1.IsFaceUp}");

     }

}