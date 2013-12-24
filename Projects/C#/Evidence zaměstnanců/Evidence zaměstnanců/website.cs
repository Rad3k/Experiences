using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace Evidence_zaměstnanců
{
    class website
    {
        /// <summary>
        /// Opens the Internet Explorer application.
        /// </summary>
        public void BaseWebsite()
        {
            // Start Internet Explorer. Defaults to the home page.
            Process.Start("IExplore.exe", "http://rad3k.eu/");
        }

        /// <summary>
        /// Opens urls and .html documents using Internet Explorer.
        /// </summary>
        public void OpenGitHubRepozitary()
        {
            // url's are not considered documents. They can only be opened
            // by passing them as arguments.
            Process.Start("IExplore.exe", "https://github.com/Rad3k/Experiences/");
        }

        /// <summary>
        /// Uses the ProcessStartInfo class to start new processes, both in a minimized 
        /// mode.
        /// </summary>
        public void OpenWebsiteFaQ()
        {
            Process.Start("IExplore.exe", "http://rad3k.eu/faq");
        }
    }
}
