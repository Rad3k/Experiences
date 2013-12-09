using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace ProgramSQL
{
    class ControlFile
    {
        public void cteniSouboru()
        {
            using (FileStream protocols = new FileStream(Definitions.zdroj, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(protocols, Encoding.Default, true))
                    {
                        while (true)
                        {
                            string s = sr.ReadToEnd();

                            // Hlavní nabídka
                            string name, proces, ram, os, hdd, gpu;
                            // Přislušenství
                            string monitor;

                            // Komponenty
                            int n = s.IndexOf("name");
                            n = s.IndexOf(' ', n + 1);
                            name = s.Substring(n, 15);
                            Definitions.JmenoPC.Add(name);

                            int o = s.IndexOf("Operating");
                            o = s.IndexOf("System", o);
                            o = s.IndexOf(' ', o + 1);
                            os = s.Substring(o, 25);
                            Definitions.OS.Add(os);

                            int g = s.IndexOf("Card");
                            g = s.IndexOf("name", g);
                            g = s.IndexOf(' ', g + 1);
                            gpu = s.Substring(g, 40);
                            Definitions.GPU.Add(gpu);

                            int p = s.IndexOf("Processor");
                            p = s.IndexOf(' ', p + 1);
                            proces = s.Substring(p, 48);
                            Definitions.CPU.Add(proces);

                            /*
                            int mb = s.IndexOf("Memory");
                            mb = s.IndexOf(' ', mb + 1);
                            ram = s.Substring(mb, 8);
                            Definitions.MainDesk.Add(ram);
                             * */

                            int r = s.IndexOf("Memory");
                            r = s.IndexOf(' ', r + 1);
                            ram = s.Substring(r, 8);
                            Definitions.Ram.Add(ram);

                            int h = s.IndexOf("Disk");
                            h = s.IndexOf("Model", h);
                            h = s.IndexOf(' ', h + 1);
                            hdd = s.Substring(h, 12);
                            Definitions.HDD.Add(hdd);

                            // Přislušenství
                            int m = s.IndexOf("Monitor");
                            m = s.IndexOf("Model", m);
                            m = s.IndexOf(' ', m + 1);
                            monitor = s.Substring(m, 20);
                            Definitions.Monitor.Add(monitor);
                            Definitions.Klavesnice.Add("Klávesnice");
                            Definitions.Mys.Add("Myš");
                            break;
                        }
                        sr.Close();
                    }
                }

                catch (IOException e)
                {
                    using (StreamWriter sw = new StreamWriter("errors.txt", false, new UnicodeEncoding(true, true)))
                    {
                        sw.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
