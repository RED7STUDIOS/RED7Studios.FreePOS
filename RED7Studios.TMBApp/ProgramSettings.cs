using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED7Studios.FreePOS
{
    class ProgramSettings
    {
        // ---- GENERAL ----
        public string Version = "1.0.0.0";
        public bool Beta = false;
        // -----------------


        // ---- UPDATES ----
        public string UpdateURL = "https://updates.cldm.ml/freepos/";
        public string UpdateURLXML = "master.xml";
        public string UpdateURLStruct = "downloads";
        // ------------------
    }
}
