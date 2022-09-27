using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Module2HM6
{
    public class Config
    {
        public LoggerConfig Logger { get; set; }

        public class LoggerConfig
        {
            private static void Main1()
            {
                var obj = new JsonObject
                {
                    Media = new Media[]
                    {
                    new Media
                    {
                        Date = "dd.MM.yyyy",
                        Time = "hh.mm.ss",
                        Path = "Logs/",
                        BackupPath = "BackUp/",
                        Name = "log_{0}",
                        Exctension = "txt"
                    }
                    }
                };

                var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText(@"Macintosh/myJson.json", json);

                Console.ReadKey();
            }
        }

        public class JsonObject
        {
            [JsonProperty("media")]
            public Media[] Media { get; set; }
        }

        public class Media
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("path")]
            public string Path { get; set; }

            [JsonProperty("backup")]
            public string BackupPath { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("ex")]
            public string Exctension { get; set; }
        }
    
    private void SerializationSample()
        {
            var configFile = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);
            XmlSerializer formatter = new XmlSerializer(typeof(Config));
            using (FileStream fs = new FileStream("confif.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, config);
            }
            using (FileStream fs = new FileStream("config.xml", FileMode.OpenOrCreate))
            {
                Config xmlConfig = (Config)formatter.Deserialize(fs);
            }
        }
        
    }
}

