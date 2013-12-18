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
            while (true)
            {
                string TextFromConfig = Resource.konfigurace;

                // Nastavení pro připojení do databáze
                int value = TextFromConfig.IndexOf("RealmID");
                value = TextFromConfig.IndexOf('=');
                RealmID = int.Parse(TextFromConfig.Substring(value));

                value = TextFromConfig.IndexOf("DataDir");
                value = TextFromConfig.IndexOf('=', value + 1);
                DataAndLogsDir = TextFromConfig.Substring(value);
                value = TextFromConfig.IndexOf("LogsDir");
                value = TextFromConfig.IndexOf('=', value + 1);
                DataAndLogsDir = DataAndLogsDir + TextFromConfig.Substring(value);

                value = TextFromConfig.IndexOf("LoginDatabaseInfo");
                value = TextFromConfig.IndexOf('=', value + 1);
                LoginDatabaseInfo = TextFromConfig.Substring(value);

                value = TextFromConfig.IndexOf("ProgramDatabaseInfo");
                value = TextFromConfig.IndexOf('=', value + 1);
                ProgramDatabaseInfo = TextFromConfig.Substring(value);

                value = TextFromConfig.IndexOf("BindIP");
                value = TextFromConfig.IndexOf('=', value + 1);
                BindIP = TextFromConfig.Substring(value);
            }
        }
    }
}
