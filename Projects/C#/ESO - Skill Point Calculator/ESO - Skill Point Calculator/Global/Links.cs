using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ESO___Skill_Point_Calculator
{
    class Links
    {
        public void myWebSite()
        {
            // Start Internet Explorer. Defaults to the home page.
            Process.Start("IExplore.exe", "http://rad3k.eu/");
        }

        public void interestWebSite()
        {
            // url's are not considered documents. They can only be opened
            // by passing them as arguments.
            Process.Start("IExplore.exe", "http://elderscrolls-online.tiscali.cz/");
        }
    }
}
