//Grading ID: D5236
//Program 2
//CIS 200-01
//Due Date: 10/25/18
//This form accepts user input and creates address objects.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        private const int MIN_ZIP = 00000; // Minimum zip for validation
        private const int MAX_ZIP = 99999; // Maximum zip for validation

        public AddressForm()
        {
            InitializeComponent();

            List<string> stateOptions = new List<string> { "CA", "KY", "LA", "ME", "NY", "TN", "TX" }; // State combobox options

            foreach (string state in stateOptions)
                stateBox.Items.Add(state);
        }

        //Precondition: None
        //Postcondition: Returns the Address name of the form
        internal string AddName
        {
            get
            {
                return nameBox.Text;
            }

            set
            {
                nameBox.Text = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns Address line 1 of the form
        internal string Address1
        {
            get
            {
                return addressBox1.Text;
            }

            set
            {
                addressBox1.Text = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns Address line 2 of the form
        internal string Address2
        {
            get
            {
                return addressBox2.Text;
            }

            set
            {
                addressBox2.Text = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns the City of the form
        internal string City
        {
            get
            {
                return cityBox.Text;
            }

            set
            {
                cityBox.Text = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns the State of the form
        internal string State
        {
            get
            {
                return stateBox.SelectedItem.ToString();
            }

            set
            {
                stateBox.SelectedItem = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns the Zip of the form
        internal string Zip
        {
            get
            {
                return zipBox.Text;
            }

            set
            {
                zipBox.Text = value;
            }
        }

        //Precondition: None
        //Postcondition: If nameBox is null or white space, error provider shows and will not allow submition of form
        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nameBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nameBox, "Textbox cannot be empty.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void nameBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(nameBox, "");
        }

        //Precondition: None
        //Postcondition: If addressBox1 is null or white space, error provider shows and will not allow submition of form
        private void addressBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressBox1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(addressBox1, "Textbox cannot be empty.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void addressBox1_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(addressBox1, "");
        }

        //Precondition: None
        //Postcondition: If cityBox is null or white space, error provider shows and will not allow submition of form
        private void cityBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cityBox, "Textbox cannot be empty.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void cityBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cityBox, "");
        }

        //Precondition: None
        //Postcondition: If stateBox is empty, error provider shows and will not allow submition of form
        private void stateBox_Validating(object sender, CancelEventArgs e)
        {
            if(stateBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(stateBox, "Must select a state.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void stateBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(stateBox, "");
        }

        //Precondition: None
        //Postcondition: If zipBox does not parse or between MIN_ZIP and MAX_ZIP, error provider shows and will not allow submition of form
        private void zipBox_Validating(object sender, CancelEventArgs e)
        {
            int zipCode;

            if(!int.TryParse(zipBox.Text, out zipCode))
            {
                e.Cancel = true;
                errorProvider.SetError(zipBox, "Zip must be a numberic number.");
            }
            else
            {
                if(zipCode < MIN_ZIP || zipCode > MAX_ZIP)
                {
                    e.Cancel = true;
                    errorProvider.SetError(zipBox, "Zip code must be between 00000 and 99999.");
                }
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void zipBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(zipBox, "");
        }

        //Precondition: OK button has been activated
        //Postcondition: Address form has been submitted
        private void okayButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //Precondition: Cancel button has been activated
        //Postcondition: Address form has been canceled
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
