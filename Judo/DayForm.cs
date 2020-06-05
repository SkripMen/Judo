using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Judo
{
    public partial class DayForm : Form
    {
        public DayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DataSet bd = DB.DGView("SELECT * FROM participants;");

            object[,] BDTable = new object[bd.Tables[0].Rows.Count, bd.Tables[0].Columns.Count];
            foreach (DataTable dt in bd.Tables)
            {
                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int b = 0;
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                    {
                        BDTable[i, b] = cell;
                        ++b;
                    }
                    ++i;
                }
            }
            object[,] GroupM = sort(BDTable, "m");
            object[,] GroupF = sort(BDTable, "f");
            object[][,] SLFSLM = new object[][,]{
                sort(GroupF, "8", dateTimePicker1.Value.Date),
                sort(GroupF, "10", dateTimePicker1.Value.Date),
                sort(GroupM, "8", dateTimePicker1.Value.Date),
                sort(GroupM, "10", dateTimePicker1.Value.Date)
            };
            if (SLFSLM[0].GetLength(0) != 0)
            {
                object[][,] SF = MinMax(SLFSLM[0]);
            }
            if (SLFSLM[1].GetLength(0) != 0)
            {
                object[][,] LF = MinMax(SLFSLM[1]);
            }
            if (SLFSLM[2].GetLength(0) != 0)
            {
                object[][,] SM = MinMax(SLFSLM[2]);
            }
            if (SLFSLM[3].GetLength(0) != 0)
            {
                object[][,] LM = MinMax(SLFSLM[3]);
            }








        }

        private object[,] sort(object[,] arr, int minfilter)
        {
            int ArrI;
            int maxfilter = minfilter + 3;
            int countSA = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (int.TryParse(arr[i, 8].ToString(), out ArrI))
                {
                    if (ArrI >= minfilter && ArrI < maxfilter)
                    {
                        ++countSA;
                    }
                }


            }
            object[,] sortArray = new object[countSA, arr.GetLength(1)];
            int d = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (int.TryParse(arr[i, 8].ToString(), out ArrI))
                {
                    if (ArrI >= minfilter && ArrI < maxfilter)
                    {
                        for (int c = 0; c < arr.GetLength(1); c++)
                        {
                            sortArray[d, c] = arr[i, c];
                        }
                        ++d;
                    }
                }

            }
            return sortArray;
        }
        private object[][,] MinMax(object[,] Arr)
        {
            int ArrI;
            int max = Convert.ToInt32(Arr[0, 8].ToString());
            int min = Convert.ToInt32(Arr[0, 8].ToString());
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                if (int.TryParse(Arr[i, 8].ToString(), out ArrI))
                {
                    if (ArrI > max)
                    {
                        max = ArrI;
                    }
                    if (ArrI < min)
                    {
                        min = ArrI;
                    }
                }
            }
            int count = 1;
            for (int i = min; i < max; i += 3)
            {
                ++count;
            }
            object[][,] MassCD = new object[count][,];
            for (int i = 0; min + i * 3 < max; i++)
            {
                MassCD[i] = sort(Arr, min + i * 3);
            }
            return MassCD;

        }
        private object[,] sort(object[,] arr, string filter)
        {
            int countSA = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    if (arr[i, b].ToString() == filter)
                    {
                        ++countSA;
                    }
                }
            }
            object[,] sortArray = new object[countSA, arr.GetLength(1)];
            int d = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    if (arr[i, b].ToString() == filter)
                    {
                        for (int c = 0; c < arr.GetLength(1); c++)
                        {
                            sortArray[d, c] = arr[i, c];
                        }
                        ++d;
                    }
                }
            }
            return sortArray;
        }
        private object[,] sort(object[,] arr, string filter, DateTime Champ)
        {

            DateTime Maxflo = Champ.AddYears(-Convert.ToInt32(filter) + 2);
            DateTime Minflo = Champ.AddYears(-Convert.ToInt32(filter)).AddDays(1);
            DateTime hbc;
            int countSA = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (DateTime.TryParse(arr[i, 4].ToString(), out hbc))
                {
                    if (hbc > Minflo && hbc < Maxflo)
                    {
                        ++countSA;
                    }
                }
            }
            object[,] sortArray = new object[countSA, arr.GetLength(1)];
            int d = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (DateTime.TryParse(arr[i, 4].ToString(), out hbc))
                {
                    if (hbc > Minflo && hbc < Maxflo)
                    {
                        for (int c = 0; c < arr.GetLength(1); c++)
                        {
                            sortArray[d, c] = arr[i, c];
                        }
                        ++d;
                    }
                }
            }
            return sortArray;
        }
    }
}
