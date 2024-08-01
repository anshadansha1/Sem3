using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManagerAnshad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Define all UI elements
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsFavoriteToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkShowFavorites;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label5 = new Label();
            cmbCountry = new ComboBox();
            chkFavorite = new CheckBox();
            rbOther = new RadioButton();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddContact = new Button();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editContactToolStripMenuItem = new ToolStripMenuItem();
            deleteContactToolStripMenuItem = new ToolStripMenuItem();
            markAsFavoriteToolStripMenuItem = new ToolStripMenuItem();
            chkShowFavorites = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1030, 536);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1022, 503);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Contact Entry";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCountry);
            groupBox1.Controls.Add(chkFavorite);
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAddContact);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1020, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Contact Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 349);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 13;
            label5.Text = "Country";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(120, 346);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(200, 28);
            cmbCountry.TabIndex = 11;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(120, 316);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(83, 24);
            chkFavorite.TabIndex = 10;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(120, 260);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(67, 24);
            rbOther.TabIndex = 9;
            rbOther.TabStop = true;
            rbOther.Text = "Other";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(120, 230);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 8;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(120, 200);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 7;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(135, 124);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 127);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(100, 422);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(158, 29);
            btnAddContact.TabIndex = 12;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(chkShowFavorites);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1022, 503);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 35);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(755, 358);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseClick += listView1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editContactToolStripMenuItem, deleteContactToolStripMenuItem, markAsFavoriteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 76);
            // 
            // editContactToolStripMenuItem
            // 
            editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            editContactToolStripMenuItem.Size = new Size(185, 24);
            editContactToolStripMenuItem.Text = "Edit Contact";
            editContactToolStripMenuItem.Click += editContactToolStripMenuItem_Click;
            // 
            // deleteContactToolStripMenuItem
            // 
            deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            deleteContactToolStripMenuItem.Size = new Size(185, 24);
            deleteContactToolStripMenuItem.Text = "Delete Contact";
            deleteContactToolStripMenuItem.Click += deleteContactToolStripMenuItem_Click;
            // 
            // markAsFavoriteToolStripMenuItem
            // 
            markAsFavoriteToolStripMenuItem.Name = "markAsFavoriteToolStripMenuItem";
            markAsFavoriteToolStripMenuItem.Size = new Size(185, 24);
            markAsFavoriteToolStripMenuItem.Text = "Mark as Favorite";
            markAsFavoriteToolStripMenuItem.Click += markAsFavoriteToolStripMenuItem_Click;
            // 
            // chkShowFavorites
            // 
            chkShowFavorites.AutoSize = true;
            chkShowFavorites.Location = new Point(6, 12);
            chkShowFavorites.Name = "chkShowFavorites";
            chkShowFavorites.Size = new Size(129, 24);
            chkShowFavorites.TabIndex = 1;
            chkShowFavorites.Text = "Show Favorites";
            chkShowFavorites.UseVisualStyleBackColor = true;
            chkShowFavorites.CheckedChanged += chkShowFavorites_CheckedChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(1055, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Simple Contact Manager";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label label5;
    }
}
