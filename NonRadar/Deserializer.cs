using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NonRadar
{
    class Deserializer
    {
        private StreamReader Reader;
        private FileStream acStream, awStream;
        public string FilePath { get; set; }

        public Deserializer()
        {
            
        }

        public bool FindFiles()
        {
            bool found = false;
            if (!string.IsNullOrEmpty(FilePath))
            {
                if (File.Exists(FilePath + "\\Aircraft.txt"))
                {
                    try
                    {
                        acStream = File.Open(FilePath + "\\Aircraft.txt", FileMode.Open);

                        if (File.Exists(FilePath + "\\Airways.txt"))
                        {
                            awStream = File.Open(FilePath + "\\Airways.txt", FileMode.Open);

                            found = true;
                        }
                    }
                    catch(FileNotFoundException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "File Error");
                    }
                }
            }

            if (!found)
            {
                acStream = null;
                awStream = null;
            }

            return found;
        }

        public bool LoadAirways()
        {
            bool success = true;

            if (awStream == null)
                return false;

            Reader = new StreamReader(awStream);

            //~TODO very bold, could use more verification, or just binary files
            //~TODO Regex would be very effective here
            while(Reader.Peek() != -1)
            {
                //!TODO
                Airway airway = new Airway(Reader.ReadLine().Split(':')[0]);

                Leg leg1 = null, leg2 = null;
                
                string awRaw = Reader.ReadLine();
                string[] awSplit = awRaw.Split('-');
                for (int ndx = 1; ndx < awSplit.Length - 1; ndx += 2)
                {
                    int distance = int.Parse(awSplit[ndx].Split('/')[0]);
                    int mea = int.Parse(awSplit[ndx].Split('/')[1]);

                    Navaid nav1;
                    Navaid nav2;
                    int? bearing1, bearing2;

                    string navString1 = awSplit[ndx - 1];
                    if (navString1.Contains("<"))
                    {
                        string[] split = navString1.Split(new[] { '<', '>' });
                        nav1 = new Navaid(navString1.Substring(0, 3), NavTools.ParseNavType(split[1]));
                        bearing1 = int.Parse(navString1.Substring(3, 3));                        
                    }
                    else
                    {
                        bearing1 = null;
                        nav1 = new Navaid(navString1.Substring(0, 5), NavType.INTERSECTION, (navString1.Length > 5) ? true : false);
                    }

                    string navString2 = awSplit[ndx + 1];
                    if (navString2.Contains("<"))
                    {
                        string[] split = navString2.Split(new[] { '<', '>' });
                        nav2 = new Navaid(navString2.Substring(0, 3), NavTools.ParseNavType(split[1]));
                        bearing2 = int.Parse(navString2.Substring(3, 3));
                    }
                    else
                    {
                        bearing2 = null;
                        nav2 = new Navaid(navString2.Substring(0, 5), NavType.INTERSECTION, (navString2.Length > 5) ? true : false);
                    }

                    Leg thisLeg = new Leg(leg1, nav1, bearing1, nav2, bearing2, distance, mea, null);

                    airway.AddLeg(thisLeg);
                    if (leg1 != null)
                    {
                        leg1.Leg2 = thisLeg;
                    }
                    leg1 = thisLeg;
                }

                Airspace.AddAirway(airway);
            }

            return success;
        }
    }
}
