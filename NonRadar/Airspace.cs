using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    public class Airspace
    {
        private List<Airway> airways;

        public static Airspace JanLo;

        public Airspace()
        {
            airways = new List<Airway>();
        }

        public List<Airway> GetAirways()
        { return airways; }

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
