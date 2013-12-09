using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ProgramSQL
{
    public partial class PrekladEditor : Form
    {
        public PrekladEditor()
        {
            InitializeComponent();
        }

        private void Button_Subjekt(object sender, EventArgs e)
        {
            DataSet da = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string od = textBox1.Text;
            string _do = textBox2.Text;
            string nazev = textBox7.Text;

            string FileName = Definitions.zdroj;
            string _ConnectionString = string.Empty;
            string _Extension = Path.GetExtension(FileName);
            // Checking for the extentions, if XLS connect using Jet OleDB
            if (_Extension.Equals(".xls", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0", FileName);
            }
            // Use ACE OleDb
            else if (_Extension.Equals(".xlsx", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", FileName);
            }

            OleDbConnection con = new OleDbConnection(_ConnectionString);
            string strCmd = "SELECT * FROM [" + nazev + "$" + od + ":" + _do + "]";
            OleDbCommand cmd = new OleDbCommand(strCmd, con);

            try
            {
                con.Open();
                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);
                dataGridView1.DataSource = da.Tables[0];
                Definitions.CisloSubjektu.RemoveRange(0, Definitions.CisloSubjektu.Count);
                for (int i = 0; i < dataGridView1.RowCount; ++i)
                    Definitions.CisloSubjektu.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void Button_Reference(object sender, EventArgs e)
        {
            DataSet da = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string od = textBox3.Text;
            string _do = textBox5.Text;
            string nazev = textBox7.Text;

            string FileName = Definitions.zdroj;
            string _ConnectionString = string.Empty;
            string _Extension = Path.GetExtension(FileName);
            //Checking for the extentions, if XLS connect using Jet OleDB
            if (_Extension.Equals(".xls", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format(
                    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0", FileName);
            }
            //Use ACE OleDb
            else if (_Extension.Equals(".xlsx", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", FileName);
            }

            OleDbConnection con = new OleDbConnection(_ConnectionString);
            string strCmd = "SELECT * FROM [" + nazev + "$" + od + ":" + _do + "]";
            OleDbCommand cmd = new OleDbCommand(strCmd, con);

            try
            {
                con.Open();
                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);
                dataGridView2.DataSource = da.Tables[0];
                Definitions.ReferenceSubjektu.RemoveRange(0, Definitions.ReferenceSubjektu.Count);
                for (int i = 0; i < dataGridView2.RowCount; ++i)
                    Definitions.ReferenceSubjektu.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void Button_Preklady(object sender, EventArgs e)
        {
            DataSet da = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string od = textBox4.Text;
            string _do = textBox6.Text;
            string nazev = textBox7.Text;

            string FileName = Definitions.zdroj;
            string _ConnectionString = string.Empty;
            string _Extension = Path.GetExtension(FileName);
            //Checking for the extentions, if XLS connect using Jet OleDB
            if (_Extension.Equals(".xls", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format(
                    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0", FileName);
            }
            //Use ACE OleDb
            else if (_Extension.Equals(".xlsx", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", FileName);
            }

            OleDbConnection con = new OleDbConnection(_ConnectionString);
            string strCmd = "SELECT * FROM [" + nazev + "$" + od + ":" + _do + "]";
            OleDbCommand cmd = new OleDbCommand(strCmd, con);

            try
            {
                con.Open();
                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);
                dataGridView3.DataSource = da.Tables[0];
                Definitions.Preklady.RemoveRange(0, Definitions.Preklady.Count);
                for (int i = 0; i < dataGridView3.RowCount; ++i)
                    Definitions.Preklady.Add(dataGridView3.Rows[i].Cells[0].Value.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void Button_Continue(object sender, EventArgs e)
        {
            SQLCreator sql = new SQLCreator();
            sql.Show();
        }

        private void Button_Popis(object sender, EventArgs e)
        {
            DataSet da = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string od = textBox8.Text;
            string _do = textBox9.Text;
            string nazev = textBox7.Text;

            string FileName = Definitions.zdroj;
            string _ConnectionString = string.Empty;
            string _Extension = Path.GetExtension(FileName);
            //Checking for the extentions, if XLS connect using Jet OleDB
            if (_Extension.Equals(".xls", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format(
                    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0", FileName);
            }
            //Use ACE OleDb
            else if (_Extension.Equals(".xlsx", StringComparison.CurrentCultureIgnoreCase))
            {
                _ConnectionString = string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", FileName);
            }

            OleDbConnection con = new OleDbConnection(_ConnectionString);
            string strCmd = "SELECT * FROM [" + nazev + "$" + od + ":" + _do + "]";
            OleDbCommand cmd = new OleDbCommand(strCmd, con);

            try
            {
                con.Open();
                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);
                dataGridView4.DataSource = da.Tables[0];
                Definitions.Popis.RemoveRange(0, Definitions.Popis.Count);
                for (int i = 0; i < dataGridView4.RowCount; ++i)
                    Definitions.Popis.Add(dataGridView4.Rows[i].Cells[0].Value.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }
    }
}
