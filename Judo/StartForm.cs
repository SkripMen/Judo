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
    public partial class StartForm : Form
    {
        int panellogin;
        bool Hidden;
        bool lox;

        public StartForm()
        {
            InitializeComponent();
            ErrorText.Visible = false;
            ErrorText2.Visible = false;
            ErrorText3.Visible = false;
            panellogin = LoginPanel.Width;
            Hidden = false;
            lox = false;
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            String login = UserInput.Text;
            String password = PasswordInput.Text;
            HashClass hash = new HashClass();
            DataBase db = new DataBase();
            string command = String.Format("SELECT * FROM users WHERE login = '{0}';", login);
            object[] DBT = db.SendCommand(command);
            if (DBT[0] != null)
            {
                if (DBT[1].ToString() == login && hash.VerifyHashedPassword(DBT[2].ToString(), password))
                {
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                else ErrorText.Visible = true;
            }
            else ErrorText.Visible = true;
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                LoginPanel.Width = LoginPanel.Width + 20;
                if (LoginPanel.Width >= panellogin)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                    this.Text = "Judo | Авторизация";
                    Title.Text = "Авторизация";
                }
            }
            else
            {
                LoginPanel.Width = LoginPanel.Width - 20;
                if (LoginPanel.Width <= 0)
                {
                    timer.Stop();
                    Hidden = true;
                    this.Refresh();
                    this.Text = "Judo | Регистрация";
                    Title.Text = "Регистрация";
                }
            }
        }

        private void RegistrationBut_Click(object sender, EventArgs e)
        {
            String login = LoginInput.Text;
            String password = PasInput.Text;
            String passwordRep = PasswordRepeatInput.Text;
            Boolean visible = false;
            HashClass hash = new HashClass();
            if (password != passwordRep || password.Length == 0)
            {
                ErrorText2.Visible = true;
                visible = true;
            }
            else
            {
                ErrorText2.Visible = false;
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
                    ErrorText3.Visible = true;
                    return true;
                }
                else
                {
                    ErrorText3.Visible = false;
                    return false;
                }
            }
            else
            {
                ErrorText3.Visible = false;
                return false;
            }

        }

        private void LoginButt_Click(object sender, EventArgs e)
        {
            timer.Start();
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

        private void LoxBur_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            lox = true;
            this.Hide();
            menuForm.Show();
        }
    }
}
