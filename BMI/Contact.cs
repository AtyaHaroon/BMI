using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            this.Hide();
        }

        private void dash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void service_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.Show();
            this.Hide();
        }
    }
}
