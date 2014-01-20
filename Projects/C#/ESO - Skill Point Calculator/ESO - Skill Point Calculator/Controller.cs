using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESO___Skill_Point_Calculator
{
    class Controller
    {
        public bool ControllFile(string pathFile)
        {
            if (pathFile.Contains("elderscrolls-online.tiscali.cz"))
                return true;
            else
                return false;
        }
    }
}
