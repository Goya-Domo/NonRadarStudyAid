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
            bool success = false;

            if (awStream == null)
                return false;

            Reader = new StreamReader(awStream);

            while(Reader.Peek() != -1)
            {
                //!TODO
                Airway airway = new Airway(Reader.ReadLine().Split(':')[0]);
                
                string awRaw = Reader.ReadLine();
                string[] awSplit = awRaw.Split('-');

                for (int ndx = 0; ndx < awSplit.Length; ndx++)
                {
                    if (char.IsLetter(awSplit[ndx][0]) && char.IsLetter(awSplit[ndx][2]))
                    {
                        string type = awSplit[ndx].Split(new[] { '<', '>' })[1];
                        Navaid nav1 = new Navaid(awSplit[ndx].Substring(0, 3), NavTools.ParseNavType(type));
                        Navaid.AddFix(nav1);

                        int bearing1 = int.Parse(awSplit[ndx].Substring(3, 3));
                    }
                }
            }

            return success;
        }
    }
}
