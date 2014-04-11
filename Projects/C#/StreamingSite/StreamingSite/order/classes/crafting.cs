using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rad3k_eu.order.classes
{
    public class crafting
    {
        public string typeTicket { get; set; }
        public string typeMethod { get; set; }
        public string message { get; set; }
        public string typePotion { get; set; }
        public string value { get; set; }
        public string nick { get; set; }
        public string status { get; set; }

        public crafting(string typeTicket, string typeMethod, string message, string typePotion, string value, string nick, string status)
        {
            this.typeTicket = typeTicket;
            this.typeMethod = typeMethod;
            this.message = message;
            this.typePotion = typePotion;
            this.value = value;
            this.nick = nick;
            this.status = status;
        }
    }
}