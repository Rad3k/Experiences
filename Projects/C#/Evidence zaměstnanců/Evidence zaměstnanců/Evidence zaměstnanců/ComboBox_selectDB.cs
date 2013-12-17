using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_zaměstnanců
{
    class ComboBox_selectDB
    {
        public string Value;
        public string Text;
        public ComboBox_selectDB(string val, string text)
        {
            Value = val;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
