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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            ErrorText.Visible = false;
            ErrorText2.Visible = false;
        }

        Point lastPoint;
        private void RegPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegText_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegistrationBut_Click(object sender, EventArgs e)
        {
            String login = LoginInput.Text;
            String password = PasswordInput.Text;
            String passwordRep = PasswordRepeatInput.Text;
            Boolean visible = false;
            HashClass hash = new HashClass();
            if (password != passwordRep)
            {
                ErrorText.Visible = true;
                visible = true;
            }
            else
            {
                ErrorText.Visible = false;
                visible = false;
            }
            if (Checked()) return;

            DataBase db = new DataBase();

            if (visible == false)
            {
                db.SendCommand(String.Format("INSERT INTO users (login, hash) VALUES ('{0}', '{1}')", LoginInput.Text, hash.HashPassword(PasswordInput.Text)));
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
            }
        }

        public Boolean Checked()
        {
            DataBase db = new DataBase();
            object[] DBT = db.SendCommand(String.Format("SELECT * FROM users WHERE login = '{0}';", LoginInput.Text));


            if (DBT[0] != null)
            {
                if (DBT[1].ToString() == LoginInput.Text)
                {
                    ErrorText2.Visible = true;
                    return true;
                }
                else
                {
                    ErrorText2.Visible = false;
                    return false;
                }
            }
            else
            {
                ErrorText2.Visible = false;
                return false;
            }

        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
