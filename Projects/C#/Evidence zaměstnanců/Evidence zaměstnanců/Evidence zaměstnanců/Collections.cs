using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_zaměstnanců
{
    class Collections
    {
        // Plná cesta configu + název
        public string FullPathConfig;

        // Nastavení pro připojení do databáze
        public int RealmID;
        public string DataAndLogsDir;
        public string LoginDatabaseInfo;
        public string ProgramDatabaseInfo;
        public string BindIP;

        // Nastavení výkonu
        public int UseProcessors;
    }
}
