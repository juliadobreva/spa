using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static juliaproject2.authenticate;

namespace juliaproject2
{
    public partial class Form1 : Form
    {
        private User authenticatedUser;
        public Form1(User user)
        {
            InitializeComponent();

            authenticatedUser = user;
            label3.Text = $"Welcome, {authenticatedUser.Username}! Let's find the perfect treatment for you!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=spainfo; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM spa_management WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (comboBox1.SelectedItem != null)
                    conditions.Add("service_name = @service_name");

                if (comboBox2.SelectedItem != null)
                    conditions.Add("location_name = @location_name");

                if (comboBox3.SelectedItem != null)
                    conditions.Add("employee_name = @employee_name");

                if (comboBox4.SelectedItem != null)
                    conditions.Add("availability_status = @availability_status");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@service_name", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@location_name", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@employee_name", comboBox3.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@availability_status", comboBox4.SelectedItem.ToString());


                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void book_Click(object sender, EventArgs e)
        {
            using (Form2 userInputForm = new Form2())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }
    }
}
