using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts;

        public Form1()
        {
            InitializeComponent();
            contacts = new List<Contact>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize ComboBox with country list
            cmbCountry.Items.AddRange(new string[] { "USA", "Canada", "UK", "Australia", "India" });

            // Initialize ListView columns
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Phone Number", 100);
            listView1.Columns.Add("Gender", 50);
            listView1.Columns.Add("Favorite", 50);
            listView1.Columns.Add("Country", 100);
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || cmbCountry.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new contact
            var contact = new Contact
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Gender = GetSelectedGender(),
                IsFavorite = chkFavorite.Checked,
                Country = cmbCountry.SelectedItem.ToString()
            };

            // Add to the contacts list and ListView
            contacts.Add(contact);
            AddContactToListView(contact);

            // Clear input fields
            ClearInputFields();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Context menu for ListView item
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Edit selected contact
            if (listView1.SelectedItems.Count == 0)
                return;

            var selectedItem = listView1.SelectedItems[0];
            var contact = contacts[selectedItem.Index];

            txtName.Text = contact.Name;
            txtEmail.Text = contact.Email;
            txtPhoneNumber.Text = contact.PhoneNumber;
            SetSelectedGender(contact.Gender);
            chkFavorite.Checked = contact.IsFavorite;
            cmbCountry.SelectedItem = contact.Country;

            contacts.RemoveAt(selectedItem.Index);
            listView1.Items.Remove(selectedItem);
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete selected contact
            if (listView1.SelectedItems.Count == 0)
                return;

            var selectedItem = listView1.SelectedItems[0];
            contacts.RemoveAt(selectedItem.Index);
            listView1.Items.Remove(selectedItem);
        }

        private void markAsFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mark selected contact as favorite
            if (listView1.SelectedItems.Count == 0)
                return;

            var selectedItem = listView1.SelectedItems[0];
            var contact = contacts[selectedItem.Index];

            contact.IsFavorite = !contact.IsFavorite;
            selectedItem.SubItems[4].Text = contact.IsFavorite ? "Yes" : "No";
        }

        private void chkShowFavorites_CheckedChanged(object sender, EventArgs e)
        {
            // Filter contacts based on favorite status
            listView1.Items.Clear();
            foreach (var contact in contacts)
            {
                if (chkShowFavorites.Checked && !contact.IsFavorite)
                    continue;

                AddContactToListView(contact);
            }
        }

        private void AddContactToListView(Contact contact)
        {
            var item = new ListViewItem(contact.Name);
            item.SubItems.Add(contact.Email);
            item.SubItems.Add(contact.PhoneNumber);
            item.SubItems.Add(contact.Gender);
            item.SubItems.Add(contact.IsFavorite ? "Yes" : "No");
            item.SubItems.Add(contact.Country);
            listView1.Items.Add(item);
        }

        private void ClearInputFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;
            chkFavorite.Checked = false;
            cmbCountry.SelectedIndex = -1;
        }

        private string GetSelectedGender()
        {
            if (rbMale.Checked) return "Male";
            if (rbFemale.Checked) return "Female";
            if (rbOther.Checked) return "Other";
            return string.Empty;
        }

        private void SetSelectedGender(string gender)
        {
            if (gender == "Male") rbMale.Checked = true;
            else if (gender == "Female") rbFemale.Checked = true;
            else if (gender == "Other") rbOther.Checked = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
