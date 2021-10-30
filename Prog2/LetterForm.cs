/**
 * Student ID: 1778666
 * Program #: 2
 * Due Date: 10/25/21
 * Course Section: 50
 * Description: Form to create a new Letter
**/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class LetterForm : Form
    {
        private const int MIN_COST = 0; // Min value for fixed cost
        private readonly Address[] _originAddresses; // Data source for origin address combo box
        private readonly Address[] _destinationAddresses; // Data source for destination address combo box

        // Letter's send from address
        internal Address OriginAddress
        {
            // Precondition: None
            // Postcondition: Returns selection of cbOriginAddress as Address
            get
            {
                return cbOriginAddress.SelectedItem as Address;
            }
        }

        // Letter's send to address
        internal Address DestinationAddress
        {
            // Precondition: None
            // Postcondition: Returns selection of cbDestinationAddress as Address
            get
            {
                return cbDestinationAddress.SelectedItem as Address;
            }
        }

        // The cost to send the letter
        internal decimal FixedCost
        {
            // Precondition: None
            // Postcondition: Returns value of tbFixedCost Text property as decimal
            get
            {
                return decimal.Parse(tbFixedCost.Text);
            }
        }

        // Precondition: addresses not null
        // Postcondition: LetterForm is created with address combo boxes loaded with addresses
        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            _originAddresses = new Address[addresses.Count];
            _destinationAddresses = new Address[addresses.Count];

            addresses.CopyTo(_originAddresses);
            addresses.CopyTo(_destinationAddresses);

            cbOriginAddress.DataSource = _originAddresses;
            cbOriginAddress.DisplayMember = "Name";
            cbOriginAddress.ValueMember = "Name";

            cbDestinationAddress.DataSource = _destinationAddresses;
            cbDestinationAddress.DisplayMember = "Name";
            cbDestinationAddress.ValueMember = "Name";
        }

        // Precondition: sender is ComboBox
        // Postcondition: sender is validated, showing error if nothing is selected
        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            var comboBox = sender as ComboBox;

            if(comboBox?.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox, "Must make selection");
                e.Cancel = true;
                comboBox.DroppedDown = true;
            }
        }

        // Precondition: sender is tbFixedCost
        // Postcondition: tbFixedCost is validated, showing error if value is not a number
        private void tbFixedCost_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(tbFixedCost.Text, out decimal cost))
            {
                errorProvider1.SetError(tbFixedCost, "Must be a number");
                e.Cancel = true;
                tbFixedCost.SelectAll();
            }
            else if (cost < MIN_COST)
            {
                errorProvider1.SetError(tbFixedCost, "Must not be negative");
                e.Cancel = true;
                tbFixedCost.SelectAll();
            }
        }

        // Precondition: sender is valid
        // Postcondition: Error is cleared from sender
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(sender as Control, "");
        }

        // Precondition: All form fields valid
        // Postcondition: Dialog is closed with OK result
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        // Precondition: None
        // Postcondition: Dialog is closed with Cancel result
        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DialogResult = DialogResult.Cancel;
        }
    }
}
