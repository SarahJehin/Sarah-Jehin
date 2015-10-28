using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeController
    {

        YahtzeeView _yView; //instantie van view aanmaken
        public YahtzeeModel _yModel; //instantie van model aanmaken

        public YahtzeeController()
        {
            _yView = new YahtzeeView(this); //controller injecteert zichzelf in de view, zodat view controller kan aanspreken over een event (bvb een button-klik), hierdoor kan de view methodes van de controller aanspreken om te laten weten als er iets gewijzigd is
            _yModel = new YahtzeeModel();
        }

        public YahtzeeView getYView()
        {
            return _yView;
        }


    }
}
