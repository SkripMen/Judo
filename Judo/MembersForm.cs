using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
            SearchPanel.Visible = true;
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            if (SearchPanel.Visible == true)
                SearchPanel.Visible = false;
            else if (SearchPanel.Visible == false && SearchBox.Text != "")
                MessageBox.Show("Нy ты типо что-то нашел, молодец");
            else
                SearchPanel.Visible = true;
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        Point lastPoint;

        private void TextPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TextPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
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

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImportBut_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt|Файлы cs|*.csv";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                string[] FileLines = File.ReadAllLines(OPF.FileName);
                int i = 0;
                int peri = dataGridView1.Rows.Count;
                i += peri;
                for (; i < FileLines.Length+peri; i++)
                {
                    dataGridView1.Rows.Add();
                    string[] RowsF = FileLines[i-peri].Split(new char[] { ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    dataGridView1.Rows[i].Cells["Имя"].Value = RowsF[0].Trim();
                    dataGridView1.Rows[i].Cells["Фамилия"].Value = RowsF[1].Trim();
                    dataGridView1.Rows[i].Cells["Пол"].Value = RowsF[2].Trim();
                    dataGridView1.Rows[i].Cells["Год"].Value = RowsF[3].Trim();
                    dataGridView1.Rows[i].Cells["Город_рождения"].Value = RowsF[4].Trim();
                    int LastI = RowsF[RowsF.Length - 1].LastIndexOf(' ');
                    dataGridView1.Rows[i].Cells["Вес"].Value = RowsF[RowsF.Length - 1].Substring(LastI, RowsF[RowsF.Length - 1].Length - LastI).Trim();
                    if (RowsF.Length == 7)
                    {
                        dataGridView1.Rows[i].Cells["Клуб"].Value = RowsF[6].Substring(0, LastI).Trim();
                        dataGridView1.Rows[i].Cells["Место_проживания"].Value = RowsF[5].Trim();
                    }
                    else dataGridView1.Rows[i].Cells["Место_проживания"].Value = RowsF[5].Substring(0, LastI).Trim();
                    foreach (DataGridViewCell item in dataGridView1.Rows[i].Cells)
                    {
                        if (item.Value == null || item.Value == "")
                        {
                            item.Value = "Не указано";
                        }

                    }
                }
                dataGridView1.AllowUserToAddRows = true;
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
