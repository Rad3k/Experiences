using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProgramSQL
{
    static class Definitions
    {
        // Předávací protokoly
        public static List<string> JmenoPC = new List<string>();
        public static List<string> CPU = new List<string>();
        public static List<string> Ram = new List<string>();
        public static List<string> OS = new List<string>();
        public static List<string> GPU = new List<string>();
        public static List<string> HDD = new List<string>();
        public static List<string> Monitor = new List<string>();
        public static List<string> Klavesnice = new List<string>();
        public static List<string> Mys = new List<string>();
        public static List<string> MainDesk = new List<string>();

        // CreateSQL
        public static List<string> CisloSubjektu = new List<string>();
        public static List<string> ReferenceSubjektu = new List<string>();
        public static List<string> Preklady = new List<string>();
        public static List<string> Popis = new List<string>();

        // Organizace
        public static List<string> jmeno_org = new List<string>();
        public static List<string> adresa_org = new List<string>();
        public static List<string> psc_org = new List<string>();
        public static List<string> ico_org = new List<string>();

        // Fakturační adresa
        public static List<string> jmeno_fa = new List<string>();
        public static List<string> adresa_fa = new List<string>();
        public static List<string> psc_fa = new List<string>();
        public static List<string> ico_fa = new List<string>();

        // Expozitura
        public static List<string> jmeno_exp = new List<string>();
        public static List<string> adresa_exp = new List<string>();
        public static List<string> psc_exp = new List<string>();
        public static List<string> ico_exp = new List<string>();

        public static string predloha;
        public static string zdroj;
    }
}
