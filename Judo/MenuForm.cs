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
        public MenuForm()
        {
            InitializeComponent();
            SettingsPanel.Visible = false;
        }

        Point lastPoint;



        private void Settings_Click(object sender, EventArgs e)
        {
            if(SettingsPanel.Visible == false)
                SettingsPanel.Visible = true;
            else
                SettingsPanel.Visible = false;
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MembersBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersForm membersForm = new MembersForm();
            membersForm.Show();
        }

        private void ChangePas_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            ChangeForm changeForm = new ChangeForm();
            changeForm.Show();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
