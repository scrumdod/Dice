using System;

namespace Dice.Model
{
    public class DiceScore
    {
        public int Roll(Random random)
        {
            return random.Next(1,7);
        }

        public string FindImage(int score)
        {
            string basePath = "~/images/die_";
            return basePath + score + ".gif";
        }
    }
}