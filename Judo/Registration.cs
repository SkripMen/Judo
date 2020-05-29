using MySql.Data.MySqlClient;
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

            if (Checked())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@l, @p)", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarBinary).Value = LoginInput.Text;
            command.Parameters.Add("@p", MySqlDbType.VarBinary).Value = PasswordInput.Text;

            db.Connection();

            if (visible == false)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                else
                   MessageBox.Show("Произошла неизвестная ошибка! Попробуйте снова.");
            }

            db.Disconnection();
        }

        public Boolean Checked()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = LoginInput.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
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
