using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRadar
{
    public enum NavType
    {
        VORTAC,
        VOR,
        VORDME,
        TACAN,
        INTERSECTION


    }
    public static class NavTools
    {
        public static NavType ParseNavType(string type)
        {
            type = type.ToUpper();

            //Order matters here
            if (type.Contains("VORT"))
            {
                return NavType.VORTAC;
            }
            if (type.Contains("DME"))
            {
                return NavType.VORDME;
            }
            if (type.Contains("VOR"))
            {
                return NavType.VOR;
            }
            if (type.Contains("TAC"))
            {
                return NavType.TACAN;
            }

            return NavType.INTERSECTION;
        }
    }
}
