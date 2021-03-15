using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public static List<string> taunts { get; } = new List<string>()
        {
            "You are dumb",
            "I hate you",
            "why are you so bad?",
            "Hope you don't cry",
            "A cheeseburger clown could kick your ***"
        };

        //override play() to include below code. ConsoleWriteLine the selected taunt, then run play().
        public static int number = new Random().Next(taunts.Count);
        string theTaunt = taunts[number];

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} says {theTaunt}");
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }


    }
}