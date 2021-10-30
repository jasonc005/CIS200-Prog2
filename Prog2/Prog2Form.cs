/**
 * Student ID: 1778666
 * Program #: 2
 * Due Date: 10/25/21
 * Course Section: 50
 * Description: This is the main form of the application
**/

using System;
using System.Text;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private readonly UserParcelView upv; // Stores the Address and Parcel data for the application

        // Precondition: None
        // Postcondition: Form created, upv is created and filled with test data
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202);
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210);
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901);
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101);

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(2), 0.50M);
            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(3), 1.20M);
            upv.AddGroundPackage(upv.AddressAt(0), upv.AddressAt(1), 12, 34, 5, 20);
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(3), 36, 37, 38, 80, 8.35M);
            upv.AddTwoDayAirPackage(upv.AddressAt(3), upv.AddressAt(1), 12, 24, 6, 14, TwoDayAirPackage.Delivery.Saver);
        }

        // Precondition: None
        // Postcondition: MessageBox is shown with about info
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string myInfo = "Student ID: 1778666\n" +
                "Program #: 2\n" +
                "Due Date: 10/25/21\n" +
                "Course Section: 50";
            MessageBox.Show(myInfo, "About", MessageBoxButtons.OK);
        }

        // Precondition: None
        // Postcondition: Application is closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition: None
        // Postcondition: New Address Form is shown and saved if filled out
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            DialogResult result;

            result = addressForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                upv.AddAddress(addressForm.AddressName, addressForm.Address1, addressForm.Address2,
                    addressForm.City, addressForm.State, addressForm.Zip);
            }

            addressForm.Dispose();
        }

        // Precondition: None
        // Postcondition: New Letter Form is shown and saved if filled out
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(upv.AddressList);
            DialogResult result;

            result = letterForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                upv.AddLetter(letterForm.OriginAddress, letterForm.DestinationAddress, letterForm.FixedCost);
            }

            letterForm.Dispose();
        }

        // Precondition: None
        // Postcondition: Addresses displayed on form
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Address address in upv.AddressList)
            {
                stringBuilder.AppendLine(address.ToString());
                stringBuilder.AppendLine("------------------------------------------");
            }

            txtReport.Text = stringBuilder.ToString();
        }

        // Precondition: None
        // Postcondition: Parcels displayed on form
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            decimal totalCost = 0;

            foreach (Parcel parcel in upv.ParcelList)
            {
                stringBuilder.AppendLine(parcel.ToString());
                stringBuilder.AppendLine("------------------------------------------");
                totalCost += parcel.CalcCost();
            }
                        
            stringBuilder.Append($"Total Cost: {totalCost:C}");

            txtReport.Text = stringBuilder.ToString();
        }
    }
}
