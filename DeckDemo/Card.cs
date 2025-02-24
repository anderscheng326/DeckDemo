/*
UML
Class: Card
 Fields:
    -rank:Rank
    -suit:Suit
    -isFaceUp:bool

 Properties:
    +rank:Rank
    +suit:Suit

 Methods:
    +FlipOver():void

 Constructor:
    Card(){rank:Rank, suit:Suit}
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    //Fields, example: Rank rank;
    //check the help documentation for the fields
    Rank rank;
    Suit suit;
    bool isFaceUp;

    //Card Constructor
    public Card(Rank rank, Suit suit)
    {
        this.suit = suit;
        this.rank = rank;
        this.isFaceUp = false;
    }
  
    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }

    public Rank Rank{get {return rank;}}

    public Suit Suit{get {return suit;}}

    public bool IsFaceUp{get {return isFaceUp;}}

    public void FlipOver()
    {
        isFaceUp = !isFaceUp;
    }
        
} 