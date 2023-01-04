using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomelabManagerblj
{
    public class Filehandler
    {
        public bool PhysicalMissing { get; set; }
        public bool VirtualMissing { get; set; }
        public bool FileError { get; set; }
        Config config = new Config();
        
        public Config LoadConfig()
        {
            
            XmlSerializer ConfigLoader = new XmlSerializer(typeof(Config));
            using (TextReader reader = new StreamReader("Config.xml"))
            {
                config = (Config)ConfigLoader.Deserialize(reader);
            }
            return config;
        }
        public void SaveConfig()
        {
            XmlSerializer ConfigSaver = new XmlSerializer(typeof(Config));
            using (TextWriter writer = new StreamWriter("Config.xml"))
            {
                ConfigSaver.Serialize(writer, config);
            }
        }
        public void IntegrityCheck()
        {

            if (!File.Exists(config.PhysicalSaveFile))
            {
                PhysicalMissing = true;

            }
            if (!File.Exists(config.VirtualSaveFile))
            {
                VirtualMissing = true;

            }
            if (File.Exists(config.PhysicalSaveFile))
            {
                PhysicalMissing = false;

            }
            if (File.Exists(config.VirtualSaveFile))
            {
                VirtualMissing = false;

            }

        }
        public List<Physical> ReadPhysicalSave()
        {
            List<Physical> physicals = new List<Physical>();
            try
            {
                XmlSerializer PhysicalLoader = new XmlSerializer(typeof(List<Physical>));
                using (TextReader reader = new StreamReader(config.PhysicalSaveFile))
                {
                    physicals = (List<Physical>)PhysicalLoader.Deserialize(reader);
                    return physicals;
                }
            }
            catch
            {
                FileError = true;
                return physicals;
            }
        }
        public List<Virtual> ReadVirtualSave()
        {
            List<Virtual> virtuals = new List<Virtual>();
            try
            {
                XmlSerializer VirtualLoader = new XmlSerializer(typeof(List<Virtual>));
                using (TextReader reader = new StreamReader(config.VirtualSaveFile))
                {
                    virtuals = (List<Virtual>)VirtualLoader.Deserialize(reader);
                    return virtuals;
                }
            }
            catch
            {
               FileError = true;
               return virtuals;   
            }
        }
    }
}
