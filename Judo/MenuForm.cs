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
    public partial class MenuForm : Form
    {
        int panelset;
        bool Hidden;
        public MenuForm()
        {
            InitializeComponent();
            //SettingsPanel.Visible = false;
            panelset = SettingsPanel.Width;
            Hidden = false;
        }

        Point lastPoint;

        private void Settings_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void MembersBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersForm membersForm = new MembersForm();
            membersForm.Show();
        }

        private void ChangePas_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.Show();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                SettingsPanel.Width = SettingsPanel.Width - 15;
                if (SettingsPanel.Width <= 0)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                SettingsPanel.Width = SettingsPanel.Width + 15;
                if (SettingsPanel.Width >= 145)
                {
                    timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void PartyBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            DayForm dayForm = new DayForm();
            dayForm.Show();
        }

        private void TatamiBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            TatamiForm tatamiForm = new TatamiForm();
            tatamiForm.Show();
        }
    }
}
