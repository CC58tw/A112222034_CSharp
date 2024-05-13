using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CupsToOunces method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces.


        private double CupsToOunces(double cups)
        { return cups * 8.0; }
        private void CupsToOunces2(double cups, out double ounces)
        { ounces = cups * 8.0; }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Variables to hold cups and ounces
            double cups, ounces;

            // Get the number of cups.
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // Convert the cups to ounces.
                //ounces = CupsToOunces(cups);
                CupsToOunces2(cups, out ounces);

                // Display the ounces.
                ouncesLabel.Text = ounces.ToString("n1");
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Enter a valid number");
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
