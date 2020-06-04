using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

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
        public DataSet DGView(string command)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command, DBConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "participants");
            return ds;
        }
        public void Excel(string provider)
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook ObjWorkBook = excelapp.Workbooks.Open(provider);
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
            string[] RowsF = new string[9];
            string[] OneLine = new string[8];
            int exit = 10;
            for (int i = 0; exit != 0; i++)
            {
                for (int b = 2; b < 10; b++)
                {
                    string elem = ObjWorkSheet.Cells[i + 1, b].Text.ToString();
                    if (elem != null && elem != "")
                    {
                        RowsF[b - 1] = elem;
                    }
                }
                for (int b = 0; b < RowsF.Length; b++)
                {

                    if (RowsF[b] != null && RowsF[b] != "")
                    {

                        for (int d = 0; d < RowsF.Length; d++)
                        {
                            if (RowsF[d] == null)
                            {
                                RowsF[d] = "";
                            }
                        }
                        string[] NSN = RowsF[1].Split(',');
                        if (RowsF[1].Split(',').Length != 1)
                        {
                            OneLine[0] = NSN[1].Trim();
                            OneLine[1] = NSN[0].Trim();
                        }
                        else break;
                        exit = 10;
                        OneLine[2] = RowsF[2].Trim();
                        OneLine[3] = RowsF[3].Trim();
                        OneLine[4] = RowsF[4].Trim();
                        OneLine[5] = RowsF[5].Trim() + RowsF[6].Trim();
                        OneLine[6] = RowsF[7].Trim();
                        OneLine[7] = RowsF[8].Trim();
                        for (int d = 0; d < OneLine.Length; d++)
                        {
                            if (OneLine[d] == "")
                            {
                                OneLine[d] = "Не указано";
                            }
                        }
                        this.SendCommand(String.Format(
                            "INSERT INTO participants (fName, Surname, Gender, Birthday, Birthtown, Locations, Sportsclub, Weight)" +
                            " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                            OneLine[0],
                            OneLine[1],
                            OneLine[2],
                            OneLine[3],
                            OneLine[4],
                            OneLine[5],
                            OneLine[6],
                            OneLine[7]
                        ));
                        for (int x = 0; x < RowsF.Length; x++)
                        {
                            RowsF[x] = null;
                        }
                        break;
                    }
                }
                --exit;
            }
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            excelapp.Quit();
        }
    }
}
