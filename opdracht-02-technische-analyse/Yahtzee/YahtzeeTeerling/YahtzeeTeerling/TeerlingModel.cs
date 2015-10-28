using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {
        private int _aantalOgen; //komt normaal in de database te staan
        private bool _staatVast; //staat default op false, dus om te beginnen staat de dobbelsteen niet vast
        private bool _isVisible = false; //gaat bepalen of de individuele werpbuttons visible zijn
        private int _aantalWorpen = 0; //het aantal worpen je al gedaan hebt

        public int AantalOgen //constructor
        {
            get
            {
                return _aantalOgen;
            }

            set
            {
                _aantalOgen = value; //wordt geset door de controller
            }
        }

        public bool StaatVast //constructor voor de bool _staatVast
        {
            get
            {
                return _staatVast;
            }

            set
            {
                _staatVast = value;
            }
        }

        public bool IsVisible //constructor voor de bool _staatVast
        {
            get
            {
                return _isVisible;
            }

            set
            {
                _isVisible = value;
            }
        }

        public int AantalWorpen //constructor
        {
            get
            {
                return _aantalWorpen;
            }

            set
            {
                _aantalWorpen = value; //wordt geset door de controller
            }
        }

    }
}
