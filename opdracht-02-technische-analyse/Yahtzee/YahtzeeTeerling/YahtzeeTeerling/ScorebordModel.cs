using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class ScorebordModel
    {

        //hierin wordt het volgende bijgehouden: de huidige worp, de huidige score (= totaal van de waardes van de dobbelstenen) en de highscore (de hoogste waarde van alle worpen)

        private int huidigeWorp;
        private int huidigeScore = 0;
        private int highScore = 0;

        public int HuidigeWorp //property
        {
            get
            {
                return huidigeWorp;
            }
            set
            {
                huidigeWorp = value;
            }
        }

        public int HuidigeScore //property
        {
            get
            {
                return huidigeScore;
            }
            set
            {
                huidigeScore = value;
            }
        }

        public int HighScore //property
        {
            get
            {
                return highScore;
            }
            set
            {
                highScore = value;
            }
        }
        /*
        public ScorebordModel()
        {
            Console.WriteLine("instantie van scorebordmodel"); //hier worden er ook 2 van aangemaakt, dus er worden ergens 2 controllers aangemaakt
        }*/

    }
}
