using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingController
    {
        TeerlingView _view; //instantie van view aanmaken
        public TeerlingModel _model; //instantie van model aanmaken

        static int seed = 0; //dit dient om te voorkomen dat je in een for loop bij random telkens hetzelfde getal krijgt http://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values

        public TeerlingController()
        {
            _view = new TeerlingView(this); //controller injecteert zichzelf in de view, zodat view controller kan aanspreken over een event (bvb een button-klik), hierdoor kan de view methodes van de controller aanspreken om te laten weten als er iets gewijzigd is
            _model = new TeerlingModel();
        }

        public TeerlingView getView()
        {
            //TeerlingView teerling = new TeerlingView(this); //we maken het hier aan zodat het in de controller wordt aangemaakt ipv in de presenter

            //return teerling;

            return _view;
        }

        public void werpTeerling ()
        {
            //we gaan hier een willekeurig getal genereren --> naar model sturen, zodat model het in de database kan zetten
            //we gaan gebruik maken van een seed om te voorkomen dat je steeds hetzelfde random getal krijgt
            Random random = new Random(seed);  //andere methode is Guid.NewGuid().GetHashCode() --> en dat tussen de haakjes zetten, waar nu seed staat
            int teerlingGetal = random.Next(1, 7);
            //_model wordt hierboven ergens geinstantieerd
            _model.AantalOgen = teerlingGetal;


            seed++;

        }

        public void teerlingVastzetten() //als je de return wil gebruiken, moet je van void een bool maken
        {

            _model.StaatVast = !_model.StaatVast;
            //getView().teerlingLabel1.BackColor = System.Drawing.Color.IndianRed;
            //alles hierin zetten zodat je enkele de methode teerlingVastzetten moet uitvoeren
            if (_model.StaatVast)
            {
                getView().teerlingLabel1.BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                getView().teerlingLabel1.BackColor = System.Drawing.Color.Transparent;
            }

            //return _model.StaatVast;
        }

    }
}
