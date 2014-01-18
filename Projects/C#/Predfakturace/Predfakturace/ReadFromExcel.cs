using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Predfakturace
{
    class ReadFromExcel : Config
    {
        public void ReadData(string fullpath)
        {
            DataSet da = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string bunka = "C7";
            string nazev = "List1";

            string FileName = fullpath;
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
            string strCmd = "SELECT * FROM [" + nazev + "$" + bunka + "]";
            OleDbCommand cmd = new OleDbCommand(strCmd, con);

            try
            {
                con.Open();
                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);
                /*dataGridView1.DataSource = da.Tables[0];
                Definitions.CisloSubjektu.RemoveRange(0, Definitions.CisloSubjektu.Count);
                for (int i = 0; i < dataGridView1.RowCount; ++i)
                    Definitions.CisloSubjektu.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());*/
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
