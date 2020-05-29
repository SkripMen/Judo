using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ErrorText.Visible = false;
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginText_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            String login = UserInput.Text;
            String password = PasswordInput.Text;

            DataBase db = new DataBase();
            string command = String.Format("SELECT * FROM users WHERE login = '{0}' AND hash = '{1}';", login, password);
            object[] DBT = db.SendCommand(command);
            if (DBT[0] != null)
            {
                if (DBT[1].ToString() == login && DBT[2].ToString() == password)
                {
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
            }
            else ErrorText.Visible = true;
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
