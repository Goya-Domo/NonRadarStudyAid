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

        private bool bearing1Correct, bearing2Correct, distanceCorrect, correctingMode;

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
            bearing1Correct = false;
            bearing2Correct = false;
            distanceCorrect = false;
            correctingMode = false;

            mtxBearing1.Text = "";
            mtxBearing2.Text = "";
            mtxDistance.Text = "";
            mtxBearing1.Focus();

            Airway CurrentAirway = Airways[rand.Next(Airways.Count)];
            List<Leg> Legs = CurrentAirway.GetLegs();

            CurrentLeg = Legs[rand.Next(Legs.Count)];

            //Removes 0-length legs
            while (CurrentLeg.Nav1.Identifier.Equals(CurrentLeg.Nav2.Identifier))
            { CurrentLeg = Legs[rand.Next(Legs.Count)]; }

            txtAirway.Text = CurrentAirway.Name;
            txtNav1.Text = CurrentLeg.Nav1.Identifier;
            txtNav2.Text = CurrentLeg.Nav2.Identifier;

            mtxBearing1.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (CurrentLeg == null)
                return;
            
            bearing1Correct = false;
            bearing2Correct = false;
            distanceCorrect = false;

            if (CurrentLeg.Bearing1 != null)
            {
                if (int.Parse(mtxBearing1.Text) == CurrentLeg.Bearing1)
                {
                    bearing1Correct = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(mtxBearing1.Text))
                {
                    bearing1Correct = true;
                }
            }

            if (CurrentLeg.Bearing2 != null)
            {
                if (int.Parse(mtxBearing2.Text) == CurrentLeg.Bearing2)
                {
                    bearing2Correct = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(mtxBearing2.Text))
                {                 
                    bearing2Correct = true;
                }                
            }

            if (int.Parse(mtxDistance.Text) == CurrentLeg.Distance)
            {
                distanceCorrect = true;
            }

            if (distanceCorrect && bearing1Correct && bearing2Correct)
            {
                NextItem();
            }
            else
            {
                if (correctingMode)
                {
                    bool stillWrong = false;
                    if (!bearing1Correct)
                    {
                        mtxBearing1.Text = (CurrentLeg.Bearing1 == null) ? "" : CurrentLeg.Bearing1.ToString();
                        stillWrong = true;
                    }
                    if (!bearing2Correct)
                    {
                        mtxBearing2.Text = (CurrentLeg.Bearing2 == null) ? "" : CurrentLeg.Bearing2.ToString();
                        stillWrong = true;
                    }
                    if (!distanceCorrect)
                    {
                        mtxDistance.Text = CurrentLeg.Distance.ToString();
                        stillWrong = true;
                    }

                    if (!stillWrong)
                    {
                        NextItem();
                        return;
                    }
                    else
                    {
                        correctingMode = false;
                        return;
                    }
                }

                if (!bearing1Correct)
                {
                    if (!correctingMode)
                    {
                        mtxBearing1.Focus();
                        mtxBearing1.SelectAll();
                        correctingMode = true;
                    }
                }
                if (!distanceCorrect)
                {
                    if (!correctingMode)
                    {
                        mtxDistance.Focus();
                        mtxDistance.SelectAll();
                        correctingMode = true;
                    }
                }
                if (!bearing2Correct)
                {
                    if (!correctingMode)
                    {
                        mtxBearing2.Focus();
                        mtxBearing2.SelectAll();
                        correctingMode = true;
                    }
                }
            }
        }
    }
}
