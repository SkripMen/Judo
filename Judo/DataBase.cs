using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Judo
{
    class DataBase
    {
        OleDbConnection DBConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=Judo.mdb");
        public object[] SendCommand(string command)
        {
            DBConnection.Open();

            OleDbCommand DBCommand = DBConnection.CreateCommand();

            DBCommand.CommandText = command;
            
            OleDbDataReader DBDataReader = DBCommand.ExecuteReader();

            DBDataReader.Read();
            object[] Rows = new object[DBDataReader.FieldCount];
            //string data = DBDataReader["hash"].ToString();
            if (DBDataReader.HasRows)
            {
                DBDataReader.GetValues(Rows);
            }
            //string data = DBConnection.ToString();
            DBDataReader.Close();
            DBConnection.Close();
            return Rows;
        }
    }
}
