using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class ScorebordView : UserControl
    {
        ScorebordController scoreController;

        

        public ScorebordView( ScorebordController _scoreController)
        {
            scoreController = _scoreController;
            //Console.WriteLine("instantie van view"); 
            InitializeComponent();
        }

        private void ScorebordView_Load(object sender, EventArgs e)
        {
            //hier werkt het wel, maar in de updateScore niet :(
            //label_score_waarde.Text = scoreController.scoreModel.HuidigeScore.ToString();
        }
        
        public void updateScore()
        {
            Console.WriteLine("In showScore methode");
            label_score_waarde.Text = scoreController.scoreModel.HuidigeScore.ToString();
            //label_score_waarde.Text = "test";

            Console.WriteLine("huidige score is " + scoreController.scoreModel.HuidigeScore.ToString());
        }

        public void updateHighScore()
        {
            label_highscore_waarde.Text = scoreController.scoreModel.HighScore.ToString(); //alles werkt behalve de scores in de labels zetten
            Console.WriteLine("highscore is " + scoreController.scoreModel.HighScore);
        }
    }
}
