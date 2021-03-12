using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer
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


        //make a random number generator that is based on the length of the list. reference roll()
        //select something from the list based on that number.


    }
}