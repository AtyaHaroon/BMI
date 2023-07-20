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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            this.Hide();
        }

        private void service_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.Show();
            this.Hide();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
            this.Hide();
        }

        private void dash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
