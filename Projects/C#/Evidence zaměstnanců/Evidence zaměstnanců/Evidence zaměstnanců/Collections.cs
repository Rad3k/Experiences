using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_zaměstnanců
{
    class Collections
    {
        // Nastavení pro připojení do databáze
        public int RealmID;
        public string DataAndLogsDir;
        public string LoginDatabaseInfo;
        public string ProgramDatabaseInfo;
        public string BindIP;

        // Přihlašovací údaje uživatele
        public string Login;
        public string Password;
        public string Email;

        // Nastavení výkonu
        public int UseProcessors;

        // Informace o programu
        public string version;
        public DateTime date;
        public DateTime lastChanged;
    }
}
