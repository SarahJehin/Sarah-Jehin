using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {

        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            YahtzeeController yahtzeeGame = new YahtzeeController();

            YahtzeeView yahtzeeView = yahtzeeGame.getYView();

            Controls.Add(yahtzeeView);

            ScorebordController scorebordController = yahtzeeGame.getYView().scoreController;

            ScorebordView scorebordView = scorebordController.getScoreView();

            //bepaal de huidige x positie horizontaal van teerling
            int xPosScorebord = yahtzeeView.Width;

            //zet de locatie van teerling op basis van x pos
            scorebordView.Location = new Point(xPosScorebord, 0);

            //voeg view toe aan huidige view
            Controls.Add(scorebordView);

        }




            /*public int aantalTeerlingen = 5;
            public List<TeerlingController> teerlingen = new List<TeerlingController>();

            public int maxAantalWorpen = 3;

            public Yahtzee()
            {
                InitializeComponent();
            }

            private void Yahtzee_Load(object sender, EventArgs e)
            {
                //int aantalTeerlingen = 5;

                //List<TeerlingController> teerlingen = new List<TeerlingController>();

                //maak instanties van teerlingen aan en voeg deze toe aan de list
                for(int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
                {
                    TeerlingController nieuweTeerling = new TeerlingController(); //instantie van controller aanmaken
                    //voeg controller toe aan teerlingen lijst
                    teerlingen.Add(nieuweTeerling);
                }

                //teerlingen tonen
                for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
                {
                    //haal de teerling op basis van de key uit de list
                    TeerlingController huidigeTeerling =  teerlingen[teerlingNummer];

                    // haal de teerling uit de teerling controller
                    TeerlingView huidigeTeerlingView = huidigeTeerling.getView();

                    //bepaal de huidige x positie horizontaal van teerling
                    int xPos = huidigeTeerlingView.Width * teerlingNummer;

                    //zet de locatie van teerling op basis van x pos
                    huidigeTeerlingView.Location = new Point(xPos, 0);

                    //voeg view toe aan huidige view
                    Controls.Add(huidigeTeerlingView);

                }


                //TeerlingController nieuweTeerling = new TeerlingController(); //instantie van controller aanmaken

                //Controls.Add(nieuweTeerling.getView());
            }

            private void button1_Click(object sender, EventArgs e)
            {




                //je mag max. 3 keer werpen, dan moet je spel gereset worden
                if(teerlingen[0]._model.AantalWorpen < maxAantalWorpen)
                {
                    //als hier op geklikt wordt moet de werpTeerling methode van de controller het aantal keer uitgevoerd worden dat er dobbelstenen zijn
                    foreach (TeerlingController teerling in teerlingen)
                    {
                        //je gaat voor elke teerling de werp uitvoeren
                        teerling.werpTeerling();
                        //je gaat via de controller de view (eigenlijk de presenter, maar is 1 in C#) ophalen (adhv getView), zo kan je dus vanaf Yahtzee in de view geraken om de methode updateLabel aan te roepen
                        teerling.getView().updateLabel();
                    }
                    teerlingen[0]._model.AantalWorpen++;
                }
                else //anders moet het spel gereset worden
                {

                }



            }*/
        }
}
