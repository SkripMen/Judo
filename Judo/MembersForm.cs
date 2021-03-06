﻿using System;
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
        int panellogin;
        bool Hidden;
        bool ChangeProve = false;
        bool is_guest;

        public MembersForm(bool IS_guest)
        {
            is_guest = IS_guest;
            InitializeComponent();
            SearchPanel.Visible = true;
            panellogin = SearchPanel.Width;
            Hidden = false;
            EqualDGV();
        }
        private void EqualDGV()
        {
            EditBox.Visible = !is_guest;
            ImportBut.Visible = !is_guest;
            DataBase DB = new DataBase();
            DataSet ds = DB.DGView("SELECT * FROM participants;");
            ds.Tables[0].Columns[1].ColumnName = "Имя";
            ds.Tables[0].Columns[2].ColumnName = "Фамилия";
            ds.Tables[0].Columns[3].ColumnName = "Пол";
            ds.Tables[0].Columns[4].ColumnName = "Год";
            ds.Tables[0].Columns[5].ColumnName = "Город рождения";
            ds.Tables[0].Columns[6].ColumnName = "Место проживания";
            ds.Tables[0].Columns[7].ColumnName = "Клуб";
            ds.Tables[0].Columns[8].ColumnName = "Вес";
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 95;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 35;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 300;
            dataGridView1.Columns[7].Width = 125;
            dataGridView1.Columns[8].Width = 85;
        }
        private void SearchBut_Click(object sender, EventArgs e)
        {
            if (SearchPanel.Visible == false) timer.Start();
            else if (SearchPanel.Visible == true && SearchBox.Text != "")
            {
                timer.Stop();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchBox.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                dataGridView1.FirstDisplayedScrollingRowIndex = i;
                                break;
                            }
                        }
                    }
                }
            }
            else timer.Start();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            if (ChangeProve)
            {
                DialogResult ifb = MessageBox.Show(
                                "Сохранить изменения?",
                                "Сообщение",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                                );
                if (ifb == DialogResult.Yes)
                {
                    dataGridView1.AllowUserToAddRows = false;
                    DataBase DB = new DataBase();
                    string command = String.Format("DELETE * FROM participants");
                    DB.SendCommand(command);
                    string[,] OneLine = new string[dataGridView1.Rows.Count, dataGridView1.Columns.Count];
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int b = 1; b < dataGridView1.Columns.Count; b++)
                        {
                            OneLine[i, b] = dataGridView1.Rows[i].Cells[b].Value.ToString();
                            if (OneLine[i, b] == null || OneLine[i, b] == "")
                            {
                                OneLine[i, b] = "Не указано";
                            }
                        }
                        DB.SendCommand(String.Format(
                            "INSERT INTO participants (fName, Surname, Gender, Birthday, Birthtown, Locations, Sportsclub, Weight)" +
                            " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                            OneLine[i, 1],
                            OneLine[i, 2],
                            OneLine[i, 3],
                            OneLine[i, 4],
                            OneLine[i, 5],
                            OneLine[i, 6],
                            OneLine[i, 7],
                            OneLine[i, 8]
                            ));
                    }
                    dataGridView1.AllowUserToAddRows = true;
                }
            }

            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.is_guest = this.is_guest;
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
            OpenFileDialog OPF = new OpenFileDialog();
            DataBase DB = new DataBase();
            OPF.Filter = "Файлы txt|*.txt|Файлы csv|*.csv|Файлы xlsx|*.xlsx|Все файлы|*.*";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                string[] FileLines = File.ReadAllLines(OPF.FileName);
                string[] OneLine = new string[8];
                switch (OPF.FileName.Split('.')[1])
                {
                    case "txt":
                        for (int i = 0; i < FileLines.Length; i++)
                        {
                            if (FileLines[i] == "" || FileLines[i] == null)
                            {
                                continue;
                            }
                            FileLines[i] = FileLines[i].Replace("\'", "`");
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
                        break;
                    case "csv":
                        for (int i = 0; i < FileLines.Length; i++)
                        {
                            if (FileLines[i] == "" || FileLines[i] == null)
                            {
                                continue;
                            }
                            FileLines[i] = FileLines[i].Replace("\'", "`");
                            string[] RowsF = FileLines[i].Split(new char[] { ',', ';', ':' });
                            if (RowsF.Length == 9)
                            {
                                continue;
                            }
                            OneLine[0] = RowsF[2].Trim();
                            OneLine[1] = RowsF[1].Trim();
                            OneLine[2] = RowsF[3].Trim();
                            OneLine[3] = RowsF[4].Trim();
                            OneLine[4] = RowsF[5].Trim();
                            OneLine[5] = RowsF[6].Trim() + RowsF[7].Trim();
                            OneLine[6] = RowsF[8].Trim();
                            OneLine[7] = RowsF[9].Trim();
                            for (int b = 0; b < OneLine.Length; b++)
                            {
                                if (OneLine[b] == null || OneLine[b] == "")
                                {
                                    OneLine[b] = "Не указано";
                                }
                            }
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
                        break;
                    case "xlsx":
                        DB.Excel(OPF.FileName);
                        break;
                }
                EqualDGV();
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.SendCommand("DELETE * FROM participants");

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                SearchPanel.Width = SearchPanel.Width + 20;
                if (SearchPanel.Width >= panellogin)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                SearchPanel.Width = SearchPanel.Width - 20;
                if (SearchPanel.Width <= 0)
                {
                    timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void EditBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeProve = true;
            if (EditBox.Checked)
            { 
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {                
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
            }
        }
    }
}
