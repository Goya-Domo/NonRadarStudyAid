using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonRadar
{
    public partial class frmMapTest : Form
    {
        private List<Airway> Airways;
        private Leg CurrentLeg;
        private Random rand;

        public frmMapTest()
        {
            InitializeComponent();
            rand = new Random();
        }

        public frmMapTest(List<Airway> airways)
        {
            InitializeComponent();
            this.Airways = airways;
            rand = new Random();
            NextItem();
        }

        private void NextItem()
        {
            mtxBearing1.Text = "";
            mtxBearing2.Text = "";
            mtxDistance.Text = "";
            mtxBearing1.Focus();

            Airway CurrentAirway = Airways[rand.Next(Airways.Count)];
            List<Leg> Legs = CurrentAirway.GetLegs();

            CurrentLeg = Legs[rand.Next(Legs.Count)];

            //Removes 0-length legs
            while(CurrentLeg.Nav1.Identifier.Equals(CurrentLeg.Nav2.Identifier))
            { CurrentLeg = Legs[rand.Next(Legs.Count)]; }

            txtAirway.Text = CurrentAirway.Name;
            txtNav1.Text = CurrentLeg.Nav1.Identifier;
            txtNav2.Text = CurrentLeg.Nav2.Identifier;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (CurrentLeg == null)
                return;

            bool correct = true;

            if (CurrentLeg.Bearing1 != null)
            {
                if (int.Parse(mtxBearing1.Text) == CurrentLeg.Bearing1)
                {

                }
                else
                {
                    correct = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(mtxBearing1.Text))
                {
                    correct = false;
                }
            }

            if (CurrentLeg.Bearing2 != null)
            {
                if (int.Parse(mtxBearing2.Text) == CurrentLeg.Bearing2)
                {

                }
                else
                {
                    correct = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(mtxBearing2.Text))
                {
                    correct = false;
                }
            }

            if (int.Parse(mtxDistance.Text) == CurrentLeg.Distance)
            {

            }
            else
            {
                correct = false;
            }

            if (correct)
            {
                NextItem();                
            }
            else
            {
                MessageBox.Show("Naw");
            }
        }
    }
}
