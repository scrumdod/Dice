using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dice.Model
{
    public class DiceScores
    {
        public string TeamName { get; set; }
        public List<TurnScore> Scores { get; set; }
        public void Generate(string teamName)
        {
            this.TeamName = teamName;
            List<TurnScore> scores = new List<TurnScore>();
            DiceScore score = new DiceScore();
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                TurnScore turn = new TurnScore();
                turn.Dice1Score = score.Roll(random);
                turn.Dice1Image = score.FindImage(turn.Dice1Score);
                turn.Dice2Score = score.Roll(random);
                turn.Dice2Image = score.FindImage(turn.Dice2Score);
                turn.Dice3Score = score.Roll(random);
                turn.Dice3Image = score.FindImage(turn.Dice3Score);
                scores.Add(turn);
            }
            this.Scores = scores;           
        }
        private void Save(List<DiceScore> scores) { }
    }
}
