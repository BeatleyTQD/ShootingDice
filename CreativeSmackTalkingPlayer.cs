using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        List<string> taunts = new List<string>
        {
            "Yeah, well dat's what happens when you're a genius!",
            "Makin' it look easy here!",
            "*kung fu noises*",
            "I'm not even winded!",
            "Who wants some-a-this?!"
        };

        public override void Play(Player other)
        {
            //generates random number for taunt selection
            Random r = new Random();
            int index = r.Next(taunts.Count);

            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll} and shouts \"{taunts[index]}\"");

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