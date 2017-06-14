using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    class Leg
    {
        public Navaid Nav1      { get; set; }
        public Navaid Nav2      { get; set; }
        public Navaid MidPoint  { get; set; }
        public int Bearing1     { get; set; }
        public int Bearing2     { get; set; }
        public int Distance     { get; set; }
        public int Mea          { get; set; }

        public Leg(Navaid nav1, int bearing1, Navaid nav2, int bearing2, Navaid midpoint, int distance, int mea)
        {
            this.Nav1 = nav1;
            this.Nav2 = nav2;
            this.Bearing1 = bearing1;
            this.Bearing2 = bearing2;
            this.MidPoint = midpoint;
            this.Distance = distance;
            this.Mea = mea;
        }
    }
}