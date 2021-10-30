/**
 * Student ID: 1778666
 * Program #: 2
 * Due Date: 10/25/21
 * Course Section: 50
 * Description: Form to create a new Address
**/

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        private const int MAX_ZIP = 99999; // Max value for Zip field
        private const int MIN_ZIP = 0; // Min value for Zip field
        private readonly string[] STATES = // List of states for State combobox
            new string[] { "CA", "FL", "KY", "MT" };

        // Name associated with the address
        internal string AddressName
        {
            // Precondition: None
            // Postcondition: Returns value of tbName Text property
            get
            {
                return tbName.Text;
            }
        }

        // First street address line
        internal string Address1
        {
            // Precondition: None
            // Postcondition: Returns value of tbAddress1 Text property
            get
            {
                return tbAddress1.Text;
            }
        }

        // Second street address line
        internal string Address2
        {
            // Precondition: None
            // Postcondition: Returns value of tbAddress2 Text property
            get
            {
                return tbAddress2.Text;
            }
        }

        // City associated with the address
        internal string City
        {
            // Precondition: None
            // Postcondition: Returns value of tbCity Text property
            get
            {
                return tbCity.Text;
            }
        }

        // State associated with the address
        internal string State
        {
            // Precondition: None
            // Postcondition: Returns value of cbState SelectedText property
            get
            {
                return cbState.SelectedText;
            }
        }

        // Zip code associated with the address
        internal int Zip
        {
            // Precondition: None
            // Postcondition: Returns value of tbZip Text property as an int
            get
            {
                return int.Parse(tbZip.Text);
            }
        }

        // Precondition: None
        // Postcondition: AddressForm is created with items added to State combo box
        public AddressForm()
        {
            InitializeComponent();

            cbState.Items.AddRange(STATES);
        }

        // Precondition: sender is TextBox
        // Postcondition: sender is validated, showing error if Text value is null or white space
        private void stringField_Validating(object sender, CancelEventArgs e)
        {
            var textBox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox?.Text))
            {
                errorProvider1.SetError(textBox, "Must contain text");
                e.Cancel = true;
                textBox.SelectAll();
            }
        }

        // Precondition: sender is cbState
        // Postcondition: cbState is validated, showing error if nothing is selected
        private void cbState_Validating(object sender, CancelEventArgs e)
        {
            if (cbState.SelectedItem == null)
            {
                errorProvider1.SetError(cbState, "Must make selection");
                e.Cancel = true;
                cbState.DroppedDown = true;
            }
        }

        // Precondition: sender is tbZip
        // Postcondition: tbZip is validated, showing error if value is not number between MIN_ZIP and MAX_ZIP
        private void tbZip_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbZip.Text, out int zip))
            {
                errorProvider1.SetError(tbZip, "Must be a number");
                e.Cancel = true;
                tbZip.SelectAll();
            }
            else if (zip < MIN_ZIP || zip > MAX_ZIP)
            {
                errorProvider1.SetError(tbZip, $"Must be between {MIN_ZIP:D5}-{MAX_ZIP}");
                e.Cancel = true;
                tbZip.SelectAll();
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
