using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomelabManagerblj
{
    public class Config
    {
        public string PhysicalSaveFile = "";
        public string VirtualSaveFile = "";
        public string overviewPage = "";
        public int ttl = 50;
        public int timeout = 1000;
    }
}
