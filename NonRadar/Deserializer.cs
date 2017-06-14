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

        public bool findFiles()
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
    }
}
