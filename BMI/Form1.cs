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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float weights = float.Parse(textBox1.Text);
            float heights = float.Parse(textBox2.Text);
            float pounds = weights * 2.20f;
            float inch = heights * 12;
            float BMI = pounds / (inch * inch) * 703f;
            string result = "";
            if (BMI < 18.5)
            {
                result = "you're in the underweight range";
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                result = "you're in the healthy weight range";
            }
            else if (BMI > 25 && BMI < 29.9)
            {
                result = "you're in the overweight range";
            }
            else if (BMI > 30)
            {
                result = "you're in the obese range";
            }

            clasi.Visible = true;
            bmi.Visible = true;
            bmi.Text = "your BMI is:" + BMI;
            clasi.Text = "" + result;
        }
    }
}
