using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeModel
    {

        private int aantalTeerlingen = 5;

        private int maxAantalWorpen = 3;

        public int AantalTeerlingen //constructor
        {
            get
            {
                return aantalTeerlingen;
            }

            set
            {
                aantalTeerlingen = value;
            }
        }

        public int MaxAantalWorpen //constructor
        {
            get
            {
                return maxAantalWorpen;
            }

            set
            {
                maxAantalWorpen = value; //wordt geset door de controller
            }
        }

    }
}
