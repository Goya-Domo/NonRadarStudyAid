using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    public class Navaid
    {
        static private List<Navaid> allFixes = new List<Navaid>();

        public string Identifier { get; }
        public NavType Type { get; }
        public bool Compulsory { get; }

        public Navaid(string identifier, NavType type)
        {
            Identifier = identifier;
            Type = type;
            Compulsory = true;
        }

        public Navaid(string identifier, NavType type, bool compulsory)
        {
            Identifier = identifier;
            Type = type;

            if (Type == NavType.INTERSECTION)
            {
                Compulsory = compulsory;
            }
            else
            {
                Compulsory = true;
            }
        }

        public static void AddFix(string identifier, NavType type)
        {
            if (GetFix(identifier) == null)
            {
                allFixes.Add(new Navaid(identifier, type));
            }
        }

        public static void AddFix(Navaid newNav)
        {
            if (GetFix(newNav.Identifier) == null)
            {
                allFixes.Add(newNav);
            }
        }

        public static Navaid GetFix(string identifier)
        {
            for (int ndx = 0; ndx < allFixes.Count; ndx++)
            {
                if (allFixes[ndx].Identifier.Equals(identifier))
                {
                    return allFixes[ndx];
                }
            }
            return null;
        }
    }
}
