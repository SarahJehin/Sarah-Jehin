using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class ScorebordController
    {
        ScorebordView scoreView;
        public ScorebordModel scoreModel;

        //public YahtzeeView yahtzeeView;
        public YahtzeeController yahtzeeController;

        public ScorebordController ()
        {
            scoreView = new ScorebordView(this);
            scoreModel = new ScorebordModel();
            //yahtzeeView = new YahtzeeView(); //dit gaat niet omdat je een yahtzeecontroller moet meegeven
            //yahtzeeView.teerlingen; //via de teerlingen (via foreach) kan je de ogen van alle teerlingen opvragen
            //yahtzeeController = new YahtzeeController();
            //yahtzeeController.getYView().teerlingen; //dit is ook een manier
            Console.WriteLine("instance of controller scores");
        }


        public ScorebordView getScoreView()
        {
            return scoreView;
        }

        public void calculateScore(List<int> listOfOgen)
        {
            int score = 0;
            foreach( int ogen in listOfOgen)
            {
                score += ogen;
            }
            //return score;
            scoreModel.HuidigeScore = score;
        }

        public void calculateHighScore()
        {
            if(scoreModel.HuidigeScore > scoreModel.HighScore)
            {
                scoreModel.HighScore = scoreModel.HuidigeScore;
            }
        }

        public void resetHighScore()
        {
            scoreModel.HighScore = 0;
        }

    }
}
