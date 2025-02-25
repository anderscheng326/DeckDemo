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

        /*test case for deck - intialize, cut, shuffle
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
        */

        //final test case - testing previous program dealing to 5 players
        Deck deck = new Deck();

        Card[] player1 = new Card[5]; //array for player1 hand max 5 cards
        Card[] player2 = new Card[5];
        Card[] player3 = new Card[5];
        Card[] player4 = new Card[5];

        // deal 2 cards each to 4 players (deal properly, dealing
        // the first card to each player before dealing the
        // second card to each player)
        for (int round = 0; round < 2; round++)
        {
            player1[round] = deck.TakeTopCard();
            player2[round] = deck.TakeTopCard();
            player3[round] = deck.TakeTopCard();
            player4[round] = deck.TakeTopCard();
        }

        // deal 1 more card to players 2 and 3
        player2[2] = deck.TakeTopCard();
        player3[2] = deck.TakeTopCard();


        // flip all the cards over - consider using foreach in update
        for (int round =0; round <2 ; round++) //for hands with 2 cards
        {
            if (player1[round].FaceUp==false)
            {
                player1[round].FlipOver();
            }

            if (player4[round].FaceUp==false)
            {
                player4[round].FlipOver();
            }
        }

        for (int round =0; round <3 ; round++) //for hands with 3 cards
        {
            if (player2[round].FaceUp==false)
            {
                player2[round].FlipOver();
            }

            if (player3[round].FaceUp==false)
            {
                player3[round].FlipOver();
            }
        }


        // print the cards for player 1
        Console.WriteLine("Player 1 Hand:");
        for (int round = 0; round < 2; round++)
        {
            Console.WriteLine(" Card " + (round+1) +"-" + player1[round].Rank +" "+player1[round].Suit); 
        }

        // print the cards for player 2
        Console.WriteLine("Player 2 Hand:");
        for (int round = 0; round < 3; round++)
        {
            Console.WriteLine(" Card " + (round+1) +"-" + player2[round].Rank +" "+player2[round].Suit); 
        }

        // print the cards for player 3
        Console.WriteLine("Player 3 Hand:");
        for (int round = 0; round < 3; round++)
        {
            Console.WriteLine(" Card " + (round+1) +"-" + player3[round].Rank +" "+player3[round].Suit); 
        }

        // print the cards for player 4
        Console.WriteLine("Player 4 Hand:");
        for (int round = 0; round < 2; round++)
        {
            Console.WriteLine(" Card " + (round+1) +"-" + player4[round].Rank +" "+player4[round].Suit); 
        }
        

    }

}
