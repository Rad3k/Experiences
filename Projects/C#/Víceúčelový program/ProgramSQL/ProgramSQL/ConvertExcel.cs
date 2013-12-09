using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramSQL
{
    public partial class ConvertExcel : Form
    {
        public ConvertExcel()
        {
            InitializeComponent();
            ControlFile soubor = new ControlFile();
            soubor.cteniSouboru();

            foreach (string jmenopc in Definitions.PCName)
                jmenoPC.Text = jmenopc;
            foreach (string graphics in Definitions.GPU)
                grafika.Text = graphics;
            foreach (string cpu_t in Definitions.CPU)
                cpu.Text = cpu_t;
            foreach (string os in Definitions.OS)
                o_system.Text = os;
            foreach (string monitors in Definitions.Monitor)
                monitor.Text = monitors;
            foreach (string klav in Definitions.Keyboard)
                klavesnice.Text = klav;
            foreach (string mouse in Definitions.Mouse)
                mys.Text = mouse;
            foreach (string harddisk in Definitions.HDD)
                hdd.Text = harddisk;
            foreach (string rams in Definitions.Ram)
                ram.Text = rams;
            foreach (string mainboard in Definitions.Motherboard)
                maindesk.Text = mainboard;
        }

        private void Button_Continue(object sender, EventArgs e)
        {
            Definitions.PCName.RemoveAt(0);
            Definitions.PCName.Add(jmenoPC.Text);
            Definitions.GPU.RemoveAt(0);
            Definitions.GPU.Add(grafika.Text);
            Definitions.CPU.RemoveAt(0);
            Definitions.CPU.Add(cpu.Text);
            Definitions.OS.RemoveAt(0);
            Definitions.OS.Add(o_system.Text);    
            Definitions.Monitor.RemoveAt(0);
            Definitions.Monitor.Add(monitor.Text);
            Definitions.Keyboard.RemoveAt(0);
            Definitions.Keyboard.Add(klavesnice.Text);
            Definitions.Mouse.RemoveAt(0);
            Definitions.Mouse.Add(mys.Text);
            Definitions.HDD.RemoveAt(0);
            Definitions.HDD.Add(hdd.Text);
            //Definitions.Motherboard.RemoveAt(0);
            //Definitions.Motherboard.Add(maindesk.Text);

            ConvertToExcel excel = new ConvertToExcel();
            excel.ExportToExcel();
            Close();
        }
    }
}
