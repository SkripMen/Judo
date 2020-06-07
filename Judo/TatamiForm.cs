using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    public partial class TatamiForm : Form
    {
        int panellogin;
        bool Hidden;

        public TatamiForm()
        {
            InitializeComponent();
            panellogin = SearchPanel.Width;
            Hidden = false;
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
            dataGridView2.Rows.Clear();
            string command = String.Format("SELECT participants.fName &' ' & participants.Surname," +
                "participants.Weight," +
                "participants.Birthday" +
                " FROM Group{0}, participants" +
                " WHERE (Group{0}.idSg = participants.Number)" +
                " AND (Group{0}.idLg = {1})",
                comboBoxLGroup.SelectedIndex + 1,
                comboBoxSGroup.SelectedIndex);
            object[,] OutBD = DGView(command);
            for (int i = 0; i < OutBD.GetLength(0); i++)
            {
                dataGridView2.Rows.Add();
                for (int b = 0; b < OutBD.GetLength(1); b++)
                {
                    dataGridView2.Rows[i].Cells[b].Value = OutBD[i, b];
                }
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(SearchBox.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            dataGridView2.FirstDisplayedScrollingRowIndex = i;
                            dataGridView2.FirstDisplayedScrollingColumnIndex = j;
                            break;
                        }
                    }
                }
            }
        }
        string result;
        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (comboBoxLGroup.SelectedItem == null ||
                comboBoxSGroup.SelectedItem == null ||
                dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show(
                "Ни одна группа не выбрана",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            MessageBox.Show(
                "Печать производиться только выбранной группы",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            result = String.Format("Категория: {0}\n{1}\n", comboBoxLGroup.SelectedItem.ToString().ToLower(), comboBoxSGroup.SelectedItem);
            result += String.Format("\n{0,-20}|{1,3}|{2,14}",
                    "Боец",
                    "Вес",
                    "Дата рождения"
                    );
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                result += String.Format("\n{0,-20}|{1,3}|{2,14}",
                    dataGridView2.Rows[i].Cells[0].Value,
                    dataGridView2.Rows[i].Cells[1].Value,
                    dataGridView2.Rows[i].Cells[2].Value
                    );
            }

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += printDocument1_PrintPage;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {

        }

        private void SearchBut_Click_1(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                SearchPanel.Width = SearchPanel.Width + 10;
                if (SearchPanel.Width >= panellogin)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                SearchPanel.Width = SearchPanel.Width - 10;
                if (SearchPanel.Width <= 0)
                {
                    timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void SearchPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SearchPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
