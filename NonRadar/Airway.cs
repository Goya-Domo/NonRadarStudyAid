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
    }
}
