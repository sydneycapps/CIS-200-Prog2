//Grading ID: D5236
//Program 2
//CIS 200-01
//Due Date: 10/25/18
//This program explores the creation of a simple GUI, use of dialog boxes, validation, and exception handling.

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
    public partial class Prog2Form : Form
    {
        private UserParcelView upv = new UserParcelView();

        public Prog2Form()
        {
            InitializeComponent();

            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Ivy Cat", "1234 Catnip St.",
                "Meowville", "KY", 56789); // Test Address 5
            upv.AddAddress("Mia Dog", "9876 Bone St.",
                "Growlsville", "NY", 78463); // Test Address 6
            upv.AddAddress("Rex Paw", "321 Treats Blvd.", "Apt. 6",
                "Barksville", "TN", 31254); // Test Address 7
            upv.AddAddress("Athena Slithers", "587 Snake Rd.", "Apt. 23",
                "Hissington", "LA", 87436); // Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.50M); // Test Letter 1
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.50M); // Test Letter 2
            upv.AddLetter(upv.AddressAt(4), upv.AddressAt(5), 10M); // Test Letter 3
            upv.AddLetter(upv.AddressAt(6), upv.AddressAt(7), 2M); // Test Letter 4
        }

        //Precondition: File > Exit activated.
        //Postcondition: The form closes.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Precondition: File > About activated.
        //Postcondition: Information about the author pops up.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine;
            MessageBox.Show($"Grading ID: D5236{NL}Program 2{NL}CIS 200-01{NL}Due Date: 10/24/18{NL}" +
                $"This program explores the creation of a simple GUI, use of dialog boxes, validation, and exception handling");
        }

        //Precondition: Insert > Address has been activated.
        //Postcondition: The address object has been created.
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            DialogResult result = addressForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                upv.AddAddress(addressForm.AddName, addressForm.Address1, addressForm.Address2, addressForm.City, 
                    addressForm.State, int.Parse(addressForm.Zip));
            }
        }

        //Precondition: Report > List Addresses has been activated.
        //Postcondition: A list of all address object have been displayed.
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            string NL = Environment.NewLine;

            displayBox.Clear();

            foreach(Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("---------------------");
                result.Append(NL);
            }

            displayBox.Text = result.ToString();
        }

        //Precondition: Insert > Letter has been activated.
        //Postcondition: The letter object has been created.
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(upv.AddressList);
            DialogResult result = letterForm.ShowDialog();

            Address oAddress;
            Address dAddress;
            decimal fixedCost;

            if(result == DialogResult.OK)
            {
                oAddress = letterForm.OriginAddressIndex;
                dAddress = letterForm.DestinationAddressIndex;
                decimal.TryParse(letterForm.FixedCost, out fixedCost);
                upv.AddLetter(oAddress, dAddress, fixedCost);
            }
        }

        //Precondition: Report > List Parcels has been activated.
        //Postcondition: A list of all parcel objects have displayed.
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayBox.Clear();
            StringBuilder result = new StringBuilder();

            string NL = Environment.NewLine;
            decimal totalCost = 0;

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("---------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }
            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            displayBox.Text = result.ToString();
        }
    }
}
