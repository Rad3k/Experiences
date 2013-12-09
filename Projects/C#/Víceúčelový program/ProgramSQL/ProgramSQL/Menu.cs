using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramSQL;

namespace ProgramSQL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Close(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "",
            MessageBoxButtons.YesNo) == DialogResult.Yes)

                // The user wants to exit the application. 
                Application.Exit();
        }

        private void Button_ConvertToExcel(object sender, EventArgs e)
        {
            ExcelSoubor excelFile = new ExcelSoubor();
            excelFile.Show();
        }

        private void Button_Organizace(object sender, EventArgs e)
        {
            //SQLSelect select = new SQLSelect();
            //select.selectDataFromDB();

            uncomplete_inform correct = new uncomplete_inform();
            correct.Show();
        }

        private void Button_CreateSQL(object sender, EventArgs e)
        {
            PrekladSoubor preklad = new PrekladSoubor();
            preklad.Show();
        }
    }
}