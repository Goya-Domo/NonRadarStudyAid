using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    public class Leg
    {
        public Leg Leg1 { get; set; }
        public Navaid Nav1 { get; }
        public int? Bearing1 { get; }
        public int Mea { get; }
        public int Distance { get; }
        public int? Bearing2 { get; }
        public Navaid Nav2 { get; }
        public Leg Leg2 { get; set; }

        public Leg(Navaid nav1, int? bearing1, Navaid nav2, int? bearing2, int distance, int mea)
        {
            this.Nav1 = nav1;
            this.Nav2 = nav2;
            this.Bearing1 = bearing1;
            this.Bearing2 = bearing2;
            this.Distance = distance;
            this.Mea = mea;
        }

        public Leg(Leg leg1, Navaid nav1, int? bearing1, Navaid nav2, int? bearing2, int distance, int mea, Leg leg2)
        {
            this.Leg1 = leg1;
            this.Nav1 = nav1;
            this.Nav2 = nav2;
            this.Bearing1 = bearing1;
            this.Bearing2 = bearing2;
            this.Distance = distance;
            this.Mea = mea;
            this.Leg2 = leg2;
        }
    }

}