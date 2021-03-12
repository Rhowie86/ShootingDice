using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice


    // refactor to use a constructor for the taunt.
    // override play method to display the taunt.
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "ohhhh you think you are good at dice? well you suck!";

        public void SmackTalk()
        {
            Console.WriteLine($"{ Taunt}");
        }
    }
}