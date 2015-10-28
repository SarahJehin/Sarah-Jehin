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
    public partial class TeerlingView : UserControl //dit is eigenlijk de presenter, de view noemt TeerlingView.cs [Design]
    {
        TeerlingController _controller;
        public Label teerlingLabel1;

        public TeerlingView( TeerlingController controller) //constructor
        {
            _controller = controller;

            InitializeComponent();
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
            werpButton.Visible = _controller._model.IsVisible;
            teerlingLabel1 = teerlingLabel;
        }

        private void werpButton_Click(object sender, EventArgs e)
        {
            if(!_controller._model.StaatVast)
            {
                // waarde van teerling ophalen uit het model
                _controller.werpTeerling();

                teerlingLabel.Text = _controller._model.AantalOgen.ToString();
            }
            
            

            //onderstaande berekening mag hier niet staan, want dit is de view --> moet dus eigenlijk naar controller
            /*
            Random random = new Random();
            int nieuwGetal = random.Next(1, 7);
            teerlingLabel.Text = nieuwGetal.ToString();
            */
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
            //hierin moet een soort _controller.teerlingVastzetten() methode komen
            _controller.teerlingVastzetten();
            /*if(_controller._model.StaatVast)
            {
                teerlingLabel1.BackColor = Color.IndianRed;
            }
            else
            {
                teerlingLabel1.BackColor = Color.Transparent;
            }*/
        }

        public void updateLabel()
        {
            if (!_controller._model.StaatVast)
            {

                teerlingLabel.Text = _controller._model.AantalOgen.ToString();
            }
        }

        public void clearLabel()
        {
            teerlingLabel.Text = "gereset";
        }

    }
}
