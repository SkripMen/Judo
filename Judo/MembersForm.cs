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
            DataBase DB = new DataBase();
            OPF.Filter = "Файлы txt|*.txt|Файлы cs|*.csv";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                string[] FileLines = File.ReadAllLines(OPF.FileName);
                string[] OneLine = new string[8];                
                for (int i = 0; i < FileLines.Length; i++)
                {
                    string[] RowsF = FileLines[i].Split(new char[] { ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    OneLine[0] = RowsF[0].Trim();
                    OneLine[1] = RowsF[1].Trim();
                    OneLine[2] = RowsF[2].Trim();
                    OneLine[3] = RowsF[3].Trim();
                    OneLine[4] = RowsF[4].Trim();
                    int LastI = RowsF[RowsF.Length - 1].LastIndexOf(' ');
                    OneLine[7] = RowsF[RowsF.Length - 1].Substring(LastI, RowsF[RowsF.Length - 1].Length - LastI).Trim();
                    if (RowsF.Length == 7)
                    {
                        OneLine[6] = RowsF[6].Substring(0, LastI).Trim();
                        OneLine[5] = RowsF[5].Trim();
                    }
                    else OneLine[5] = RowsF[5].Substring(0, LastI).Trim();
                    for (int b = 0; b < OneLine.Length; b++)
                    {
                        if (OneLine[b] == null || OneLine[b] == "")
                        {
                            OneLine[b] = "Не указано";
                        }
                    }
                    // fName   Surname Gender  Birthday Birthtown   Locations Sportsclub  Weight
                    DB.SendCommand(String.Format(
                        "INSERT INTO participants (fName, Surname, Gender, Birthday, Birthtown, Locations, Sportsclub, Weight)" +
                        " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                        OneLine[0],                        
                        OneLine[1],                        
                        OneLine[2],                        
                        OneLine[3],                        
                        OneLine[4],                        
                        OneLine[5],                        
                        OneLine[6],                        
                        OneLine[7]                        
                        ));
                }
                dataGridView1.AllowUserToAddRows = true;
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
        }
    }
}
