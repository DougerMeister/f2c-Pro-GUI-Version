/***  f2p(ProGui) Program to convert Fahrenheit to Celsius, or Celsius to Fahrenheit with a graphical user interface.
 *    Written by: DougerMeister
 *    April 16th, 2025
 *    version 1.0
 *    
 *    What: Converts Fahrenheit to Celsius or Celsius to Fahrenheit
 *    
 *    Why: Sometimes you need to convert Celsius to Fahrenheit or Fahrenheit to Celsius.
 *    
 *    How: Takes Numerical value from associated text box and converts it to Fahrenheit or Celsius
 *         then outputs it to a box and changes the color, accordingly.
 *    
***/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace f2c
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FahrenheitTextBox.KeyDown += F2cButton_KeyDown;
            CelsiusTextBox.KeyDown += C2fButton_KeyDown;
        }

        /** Custom Code **/

        /** Allows Form to be used with Enter Key **/
        private void F2cButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // catches enter key if pressed
            {
                ConvertTemp2c(); // calls Fahrenheit conversion to Celsius Code
            }
        } // end F2cButton_KeyDown
        private void C2fButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // catches enter key if pressed
            {
                ConvertTemp2f(); // calls Celsius conversion to Fahrenheit code
            }
        } // end C2fButton_KeyDown


        //Convert Fahrenheit Temp to Celsius
        private void ConvertTemp2c()
        {
            // Sets default value of Fahrenheit Text box to 0
            if (string.IsNullOrEmpty(FahrenheitTextBox.Text))
            {
                FahrenheitTextBox.Text = "0";
            }
            try
            {
                string strTemp = FahrenheitTextBox.Text; // assigns value in Fahrenheit Text box to string
                double doubleTemp = double.Parse(strTemp); // converts the string to a double
                doubleTemp = ((doubleTemp - 32) * (5.0 / 9.0)); // converts Fahrenheit Temperature to Celsius           
                this.ConvertedTemp.Text = string.Format("{0:0.0}F", doubleTemp); // outputs converted temperature to converted temp box and adds F for Fahrenheit to the string
                this.ConvertedTemp.ForeColor = Color.DarkBlue; // Changes color to Blue to represent Celsius
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!");
            }
        } // end ConvertTemp2c
        // Convert Celsius Temp to Fahrenheit
        private void ConvertTemp2f()
        { 
            // sets default value of Celsius text box to "0" if no value entered
            if (string.IsNullOrEmpty(CelsiusTextBox.Text))
            {
                CelsiusTextBox.Text = "0";
            }
            try
            {
                string strTemp = CelsiusTextBox.Text;  // assigns value in Celsius Text Box to a string
                double doubleTemp = double.Parse(strTemp);  // converts the string to a double
                doubleTemp = ((doubleTemp * (9.0 / 5.0) + 32)); // converts the Celsius temperature to Fahrenheit
                this.ConvertedTemp.Text = string.Format("{0:0.0}F", doubleTemp); // outputs converted temperature to converted temp box and adds F for Fahrenheit to the string
                this.ConvertedTemp.ForeColor = Color.DarkRed; // Changes color to Red to represent Fahrenheit
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!");
            }

        } // end ConvertTemp2f



        /** Auto Generated **/
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void F2cButton_Click(object sender, EventArgs e)
        {
                ConvertTemp2c();  // calls custom function to convert Fahrenheit to Celsius
        }

        private void C2fButton_Click(object sender, EventArgs e)
        {
                ConvertTemp2f(); // calls custom function to convert Celsius to Fahrenheit
        }

        private void FahrenheitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    } // end partial class for form 1
} // end namespace f2c
