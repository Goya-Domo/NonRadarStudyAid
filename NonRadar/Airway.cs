using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    class Airway
    {
        private string Name { get; }
        private List<Leg> Legs;

        private Airway() {  }

        public Airway(string name)
        {
            this.Name = name;
            Legs = new List<Leg>();
        }

        //public void AddLeg(Navaid nav1, int bearing1, Navaid nav2, int bearing2, Navaid midpoint, int distance, int mea)
        //{
        //    Legs.Add(new NonRadar.Leg(nav1, bearing1, nav2, bearing2, midpoint, distance, mea));
        //}

        public void AddLeg(Leg newLeg)
        {
            Legs.Add(newLeg);
        }
    }
}
