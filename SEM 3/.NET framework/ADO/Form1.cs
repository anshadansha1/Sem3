
namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            //Create a new datbase
            DataTable table = new DataTable("MyTable");

            //Define Columns:
            DataColumn column1 = new DataColumn("ID", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Age", typeof(int));

            //Add Columns to the table
            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);

            //Add some rows to the table:
            DataRow row1 = table.NewRow();
            row1["ID"] = 1;
            row1["Name"] = "Anshad Muhammad";
            row1["Age"] = 24;
            rable.Rows.Add(row1);
            
            DataRow row2 = table.NewRow();
            row2["ID"] = 2;
            row2["Name"] = "Dilsha C P";
            row2["Age"] = 23;

            //Bind the DataTable to the DataGridview
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
