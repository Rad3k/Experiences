using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rad3k_eu.order.classes
{
    public class Obchod
    {
        public string type { get; set; }
        public string typeMethod { get; set; }
        public string vec { get; set; }
        public string message { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string nick { get; set; }
        public string datum { get; set; }

        public Obchod(string type, string typeMethod, string vec, string message, string name, string value, string nick, string datum)
        {
            this.type = type;
            this.typeMethod = typeMethod;
            this.vec = vec;
            this.message = message;
            this.name = name;
            this.value = value;
            this.nick = nick;
            this.datum = datum;
        }
    }
}