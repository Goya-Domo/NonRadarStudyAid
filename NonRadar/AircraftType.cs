using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
   public class AircraftType
    {
        private static List<AircraftType> AllTypes;

        public string Identifier    { get; }
        public string Model         { get; }

        public int CLIMBRATE        { get; }
        public int DESCENDRATE      { get; }

        public int MAXSPEED         { get; }
        public int MINSPEED         { get; }
        public int SERVICECEILING   { get; }

        public AircraftType(string identifier, string model, int minspeed, int maxspeed, int climbrate, int ceiling)
        {
            Identifier = identifier;
            Model = model;

            MINSPEED = minspeed;
            MAXSPEED = maxspeed;

            CLIMBRATE = climbrate;
            DESCENDRATE = climbrate;

            SERVICECEILING = ceiling;
        }

        public static bool AddType(string identifier, string model, int minspeed, int maxspeed, int climbrate, int ceiling)
        {
            foreach(AircraftType type in AllTypes)
            {
                if (type.Identifier.Equals(identifier))
                {
                    return true;
                }
            }

            AllTypes.Add(new AircraftType(identifier, model, minspeed, maxspeed, climbrate, ceiling));
            return true;
        }

        public static void Initialize()
        {
            AllTypes = new List<AircraftType>();
        }        
    }
}
