using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_Database_Form
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void bback_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }
    }
}
