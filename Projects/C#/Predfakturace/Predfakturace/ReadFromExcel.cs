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
            List<string> wsList = new List<string>();
            DataTable schemaTable;
            DataSet da = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            string name;
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

            try
            {
                con.Open();
                schemaTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                foreach (DataRow row in schemaTable.Rows)
                    wsList.Add(row.Field<string>("TABLE_NAME"));
                name = wsList[0];
                string strCmd = "SELECT J38 FROM [" + name + "]";
                OleDbCommand cmd = new OleDbCommand(strCmd, con);

                da.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(da);
                UniqueValue.money.Add(double.Parse(da.ToString()));
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
