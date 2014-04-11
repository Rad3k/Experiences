using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rad3k_eu.order.classes
{
	public class games
	{
        public string typeTicket { get; set; }
        public string typeMethod { get; set; }
        public string message { get; set; }
        public string typeName { get; set; }
        public string value { get; set; }
        public string status { get; set; }

        public games(string typeTicket, string typeMethod, string message, string typeName, string value, string status)
        {
            this.typeTicket = typeTicket;
            this.typeMethod = typeMethod;
            this.message = message;
            this.typeName = typeName;
            this.value = value;
            this.status = status;
        }
	}
}