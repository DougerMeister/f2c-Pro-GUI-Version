using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f2c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /** Custom Code **/
        private void ConvertTemp2c() 
        {
            string strTemp = FahrenheitTextBox.Text;
            double doubleTemp = Convert.ToDouble(strTemp);
            doubleTemp = ((doubleTemp - 32) * (5.0 / 9.0));
            doubleTemp = (Math.Truncate(doubleTemp * 10) / 10);
            string convertedTemp = Convert.ToString(doubleTemp);
            this.ConvertedTemp.Text = convertedTemp + "C";
            this.ConvertedTemp.ForeColor = Color.DarkBlue;
        }
        private void ConvertTemp2f()
        {
            string strTemp = CelsiusTextBox.Text;
            double doubleTemp = Convert.ToDouble(strTemp);
            doubleTemp = ((doubleTemp * (9.0 / 5.0) + 32));
            doubleTemp = (Math.Truncate(doubleTemp * 10) / 10);
            string convertedTemp = Convert.ToString(doubleTemp);
            this.ConvertedTemp.Text = convertedTemp + "F";
            this.ConvertedTemp.ForeColor = Color.DarkRed;
        }
        /** Generated **/
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void F2cButton_Click(object sender, EventArgs e)
        {
            ConvertTemp2c();
        }

        private void C2fButton_Click(object sender, EventArgs e)
        {
            ConvertTemp2f();
        }
    }
}
