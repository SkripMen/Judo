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

    public partial class ChangeForm : Form
    {
        string login;
        public ChangeForm(string Login)
        {
            login = Login;
            InitializeComponent();
            ErrorText.Visible = false;
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void PasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ChangeBut_Click(object sender, EventArgs e)
        {
            String passOld = PasOllBox.Text;
            String passNew = PasNewBox.Text;
            String passNew2 = PasNewRepBox.Text;
            Boolean visible = false;
            HashClass hash = new HashClass();
            DataBase db = new DataBase();

            if (passNew != passNew2 || passNew.Length == 0)
            {

                ErrorText.Visible = true;
                visible = true;
            }
            else
            {
                ErrorText.Visible = false;
                visible = false;
            }
            if (visible == false)
            {
                string command = String.Format("SELECT * FROM users WHERE login = '{0}';", login);
                object[] DBT = db.SendCommand(command);
                if (DBT[0] != null)
                {
                    if (DBT[1].ToString() == login && hash.VerifyHashedPassword(DBT[2].ToString(), passOld))
                    {
                        db.SendCommand(String.Format("UPDATE users SET hash='{0}' WHERE id = {1};", hash.HashPassword(passNew), DBT[0]));
                        this.Hide();
                    }
                    else ErrorText.Visible = true;
                }
                else ErrorText.Visible = true;
            }
            else ErrorText.Visible = true;
        }
    }
}
