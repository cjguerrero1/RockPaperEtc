using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedRockPaperEtc
{
    public class Human : Player
    {
        public Human(string name, int playerScore, int playerChoice)
            :base(name, playerScore, playerChoice)
        {
            this.name = name;
            this.playerScore = playerScore;
        }
      
    }
}

