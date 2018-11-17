//Grading ID: D5236
//Program 2
//CIS 200-01
//Due Date: 10/25/18
//This form accepts user input and creates letter objects.

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
    public partial class LetterForm : Form
    {
        private Address _oAddress; // Origin Address
        private Address _dAddress; // Destincation Address
        private string _fixedCost; // Fixed Cost
        List<Address> addresses = new List<Address>(); // List of Addresses

        //Precondition: None
        //Postcondition: Letter form is created
        public LetterForm(List<Address> AddressList)
        {
            InitializeComponent();

            AddressList = addresses;
        }

        internal List<Address> Addresses
        {
            get
            {
                return addresses;
            }
        }

        //Precondition: None
        //Postcondition: Returns the Origin Address of the form
        internal Address OriginAddressIndex
        {
            get
            {
                return _oAddress;
            }

            set
            {
                _oAddress = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns the Destination Address of the form
        internal Address DestinationAddressIndex
        {
            get
            {
                return _dAddress;
            }

            set
            {
                _dAddress = value;
            }
        }

        //Precondition: None
        //Postcondition: Returns the Fixed Cost of the form
        internal string FixedCost
        {
            get
            {
                return _fixedCost;
            }

            set
            {
                _fixedCost = value;
            }
        }

        //Precondition: None
        //Postcondition: Loads the combo boxes of the letter form
        private void LetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in addresses)
            {
                originAddressBox.Items.Add(a);
                destAddressBox.Items.Add(a);
            }
        }

        //Precondition: None
        //Postcondition: If originAddressBox is empty, error provider shows and will not allow submition of form
        private void originAddressBox_Validating(object sender, CancelEventArgs e)
        {
            if (originAddressBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(originAddressBox, "Must select an origin address.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void originAddressBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originAddressBox, "");
        }

        //Precondition: None
        //Postcondition: If destAddressBox is empty, error provider shows and will not allow submition of form
        private void destAddressBox_Validating(object sender, CancelEventArgs e)
        {
            if (destAddressBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(destAddressBox, "Must select a destination address.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void destAddressBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destAddressBox, "");
        }

        //Precondition: None
        //Postcondition: If fixedCostBox does not parse or is greater than 0, error provider shows and will not allow submition of form
        private void fixedCostBox_Validating(object sender, CancelEventArgs e)
        {
            decimal fixedCost;

            if (!decimal.TryParse(fixedCostBox.Text, out fixedCost) || fixedCost < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(fixedCostBox, "Fixed cost must be a valid amount greater than 0.");
            }
        }

        //Precondition: Validation succeeded
        //Postcondition: Error messages are cleared
        private void fixedCostBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostBox, "");
        }

        //Precondition: OK button has been activated
        //Postcondition: Letter form has been submitted
        private void okButton_Click(object sender, EventArgs e)
        {
            OriginAddressIndex = (Address)originAddressBox.SelectedItem;
            DestinationAddressIndex = (Address)destAddressBox.SelectedItem;
            FixedCost = fixedCostBox.Text;

            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        //Precondition: Cancel button has been activated
        //Postcondition: Letter form has been canceled
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
