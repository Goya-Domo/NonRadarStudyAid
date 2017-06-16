using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    class Airspace
    {
        private List<Airway> airways;

        private static Airspace JanLo;

        public Airspace()
        {
            airways = new List<Airway>();
        }

        public static void AddAirway(Airway airway)
        {
            JanLo.airways.Add(airway);
        }

        public static void Initialize()
        {
            JanLo = new Airspace();
        }
    }
}
