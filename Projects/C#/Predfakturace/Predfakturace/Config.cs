using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predfakturace
{
    class Config
    {
        // Trace
        List<string> traceToFile = new List<string>();

        public void AddToList(string path)
        {
            traceToFile.Add(path);
        }

        public void AddToUniqueList()
        {
            foreach (string items in traceToFile)
            {
                UniqueValue.traceToFile.Add(items);
            }
        }
    }
}
