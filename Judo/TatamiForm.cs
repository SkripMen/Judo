using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    public partial class TatamiForm : Form
    {
        public TatamiForm()
        {
            InitializeComponent();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private object[,] DGView(string command)
        {
            DataBase DB = new DataBase();
            DataSet bd = DB.DGView(command);
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
            return BDTable;
        }

        private void comboBoxLGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSGroup.Items.Clear();
            string command = String.Format("SELECT idLg FROM Group{0} GROUP BY idLg", comboBoxLGroup.SelectedIndex + 1);
            object[,] OutBD = DGView(command);
            for (int i = 0; i < OutBD.GetLength(0); i++)
            {
                comboBoxSGroup.Items.Add("Группа " + Convert.ToChar(Convert.ToByte(65 + i)).ToString());
            }
        }

        private void comboBoxSGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = String.Format("SELECT participants.* FROM Group{0}, participants" +
                " WHERE (Group{0}.idSg = participants.Number)" +
                " AND (Group{0}.idLg = {1})",
                comboBoxLGroup.SelectedIndex + 1,
                comboBoxSGroup.SelectedIndex);
            object[,] OutBD = DGView(command);
            for (int i = 0; i < OutBD.GetLength(0); i++)
            {
                for (int b = 0; b < OutBD.GetLength(1); b++)
                {
                    Console.Write(OutBD[i, b]);
                }
                Console.WriteLine();
            }
        }
    }
}
