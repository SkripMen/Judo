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
    public partial class ProgBar : Form
    {
        DateTime dt;
        int duration;

        public ProgBar()
        {
            InitializeComponent();

            Random rand = new Random();
            duration = rand.Next(3000, 10000);
            dt = DateTime.Now.AddMilliseconds(duration);

            progressBar.Minimum = 0;
            progressBar.Maximum = duration;

            timer.Interval = 10;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double temp = duration - (dt - DateTime.Now).TotalMilliseconds;
            if (temp <= duration)
            {
                progressBar.Value = (int)temp;
            }
            else
            {
                timer.Stop();
                progressBar.Maximum = duration;
                this.Hide();
                TatamiForm tatamiForm = new TatamiForm();
                tatamiForm.Show();
            }
            progressBar.Refresh();
            Application.DoEvents();
        }
    }
}
