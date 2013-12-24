using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Evidence_zaměstnanců
{
    class ReadFromConfig : Collections
    {
        public void ReadFromFile()
        {
            string TextFromConfig = Resource.konfigurace;

            // Nastavení pro připojení do databáze
            var value = TextFromConfig.IndexOf("RealmID");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            var value2 = TextFromConfig.IndexOf("\r\n", value);
            RealmID = int.Parse(TextFromConfig.Substring(value, value2 - value));

            value = TextFromConfig.IndexOf("DataDir");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            value2 = TextFromConfig.IndexOf("\r\n", value);
            DataAndLogsDir = TextFromConfig.Substring(value, value2 - value);
            value = TextFromConfig.IndexOf("LogsDir");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            value2 = TextFromConfig.IndexOf("\r\n", value);
            DataAndLogsDir = DataAndLogsDir + TextFromConfig.Substring(value, value2 - value);

            value = TextFromConfig.IndexOf("LoginDatabaseInfo");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            value2 = TextFromConfig.IndexOf("\r\n", value);
            LoginDatabaseInfo = TextFromConfig.Substring(value, value2 - value);

            value = TextFromConfig.IndexOf("ProgramDatabaseInfo");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            value2 = TextFromConfig.IndexOf("\r\n", value);
            ProgramDatabaseInfo = TextFromConfig.Substring(value, value2 - value);

            value = TextFromConfig.IndexOf("BindIP");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            value2 = TextFromConfig.IndexOf("\r\n", value);
            BindIP = TextFromConfig.Substring(value, value2 - value);

            value = TextFromConfig.IndexOf("UseProcessors");
            value = TextFromConfig.IndexOf('=', value);
            value = TextFromConfig.IndexOf(' ', value);
            value2 = TextFromConfig.IndexOf("\r\n", value);
            UseProcessors = int.Parse(TextFromConfig.Substring(value, value2 - value));
        }
    }
}
