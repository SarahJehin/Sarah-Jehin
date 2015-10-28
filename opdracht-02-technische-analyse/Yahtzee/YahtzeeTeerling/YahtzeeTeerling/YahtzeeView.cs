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
    public partial class YahtzeeView : UserControl
    {
        public YahtzeeController _yController;

        public List<TeerlingController> teerlingen = new List<TeerlingController>();

        //to access the score and highscore methods from ScorebordController
        public ScorebordController scoreController = new ScorebordController();

        public YahtzeeView(YahtzeeController yController)
        {
            _yController = yController;

            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
            for (int teerlingNummer = 0; teerlingNummer < _yController._yModel.AantalTeerlingen; ++teerlingNummer)
            {
                TeerlingController nieuweTeerling = new TeerlingController(); //instantie van controller aanmaken
                //voeg controller toe aan teerlingen lijst
                teerlingen.Add(nieuweTeerling);
            }

            //teerlingen tonen
            for (int teerlingNummer = 0; teerlingNummer < _yController._yModel.AantalTeerlingen; ++teerlingNummer)
            {
                //haal de teerling op basis van de key uit de list
                TeerlingController huidigeTeerling = teerlingen[teerlingNummer];

                // haal de teerling uit de teerling controller
                TeerlingView huidigeTeerlingView = huidigeTeerling.getView();

                //bepaal de huidige x positie horizontaal van teerling
                int xPos = huidigeTeerlingView.Width * teerlingNummer;

                //zet de locatie van teerling op basis van x pos
                huidigeTeerlingView.Location = new Point(xPos, 0);

                //voeg view toe aan huidige view
                Controls.Add(huidigeTeerlingView);

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            List<int> aantalOgen = new List<int> { };

            //je mag max. 3 keer werpen, dan moet je spel gereset worden
                if (teerlingen[0]._model.AantalWorpen < _yController._yModel.MaxAantalWorpen)
            {
                //als hier op geklikt wordt moet de werpTeerling methode van de controller het aantal keer uitgevoerd worden dat er dobbelstenen zijn
                foreach (TeerlingController teerling in teerlingen)
                {
                    //je gaat voor elke teerling de werp uitvoeren
                    teerling.werpTeerling();
                    //je gaat via de controller de view (eigenlijk de presenter, maar is 1 in C#) ophalen (adhv getView), zo kan je dus vanaf Yahtzee in de view geraken om de methode updateLabel aan te roepen
                    teerling.getView().updateLabel();

                    //voor elke dobbelsteen het aantal ogen ophalen en in een lijst zetten en die dan doorgeven aan de scorebordcontroller
                    aantalOgen.Add(teerling._model.AantalOgen);
                }
                teerlingen[0]._model.AantalWorpen++;
                scoreController.calculateScore(aantalOgen);
                scoreController.getScoreView().updateScore();
                Console.WriteLine(scoreController.scoreModel.HuidigeScore); //gecheckt en de score wordt juist berekend, alleen wordt hij dus niet getoond.
            }
            else //anders moet het spel gereset worden //eigenlijk moeten hier de labels vastgezet worden en rood worden
            {
                foreach (TeerlingController teerling in teerlingen)
                {
                    //teerling.getView().clearLabel(); //hierdoor zal er de tekst gereset in het label komen
                    if (!teerling._model.StaatVast)
                    {
                        teerling.teerlingVastzetten();
                        button_reset.Visible = true;
                    }
                    
                }
                teerlingen[0]._model.AantalWorpen = 0;
            }

            scoreController.calculateHighScore();
            scoreController.getScoreView().updateHighScore();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            //hierin moeten alle labels op leeg gezet worden en het aantal worpen op 0 en de labels moeten terug 'losgemaakt' worden
            foreach (TeerlingController teerling in teerlingen)
            {
                teerling.getView().clearLabel(); //hierdoor zal er de tekst gereset in het label komen
                if (teerling._model.StaatVast)
                {
                    teerling.teerlingVastzetten(); //alle labels staan vast, dus gaan we ze met de methode teerlingVastzetten terug loszetten
                }

            }
            teerlingen[0]._model.AantalWorpen = 0;
            button_reset.Visible = false; //als het spel gereset is, mag deze button weer verdwijnen
        }
    }
}
