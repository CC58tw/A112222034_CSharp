using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // List to hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
       





        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone thisPhone = new CellPhone();

            // Get the phone data.
            decimal price;

            thisPhone.Brand = brandTextBox.Text;
            thisPhone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out price))
                thisPhone.Price = price;
            else
                MessageBox.Show("資料格式錯誤");

            // Add the CellPhone object to the List.
            phoneList.Add(thisPhone);

            // Add an entry to the list box.
            phoneListBox.Items.Add(thisPhone.Brand + " " + thisPhone.Model);

            // Clear the TextBox controls.
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            priceTextBox.Text = "";

            // Reset the focus.
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = phoneListBox.SelectedIndex;

            // Display the selected item's price.
            MessageBox.Show("售價: " + phoneList[index].Price.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
